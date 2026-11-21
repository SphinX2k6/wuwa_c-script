using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005874 RID: 22644
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryActivityEnterItem : GridProxyAbstract<AnniversarySubActivityDataBase>
	{
		// Token: 0x06037D09 RID: 228617 RVA: 0x00F9C060 File Offset: 0x00F9A260
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x06037D0A RID: 228618 RVA: 0x00F9C1EB File Offset: 0x00F9A3EB
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06037D0B RID: 228619 RVA: 0x00F9C1FE File Offset: 0x00F9A3FE
		[NullableContext(1)]
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06037D0C RID: 228620 RVA: 0x00F9C207 File Offset: 0x00F9A407
		public override void Refresh(AnniversarySubActivityDataBase data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x06037D0D RID: 228621 RVA: 0x00F9C210 File Offset: 0x00F9A410
		public void Refresh(AnniversarySubActivityDataBase data)
		{
			if (data == null)
			{
				this.SetLockState(true);
				return;
			}
			this.Data = data;
			EAnniversaryActivityState currentState = data.GetCurrentState();
			bool flag = data.NeedPlayUnlockSequence();
			bool lockState = currentState == EAnniversaryActivityState.Lock || currentState == EAnniversaryActivityState.Close || flag;
			AnniversaryEntrance? anniversaryEntranceById = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceById((int)data.GetSubId());
			if (anniversaryEntranceById != null)
			{
				base.SetTextureByPath(anniversaryEntranceById.Value.IconPath, base.GetTexture(3), null, null);
			}
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(data.GetActivityId());
			if (activityConfig != null)
			{
				UUIText text = base.GetText(12);
				if (text != null)
				{
					text.ShowTextNew(activityConfig.Value.Title);
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.SetLockState(lockState);
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(5);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			this.RefreshRedDotItem();
			this.RefreshFinished();
			this.ChildUpdateStateInfo();
			this.OnTipsTimerTick();
		}

		// Token: 0x06037D0E RID: 228622 RVA: 0x00F9C324 File Offset: 0x00F9A524
		public void OnTipsTimerTick()
		{
			AnniversarySubActivityDataBase data = this.Data;
			EAnniversaryActivityState? eanniversaryActivityState = (data != null) ? new EAnniversaryActivityState?(data.GetCurrentState()) : null;
			EAnniversaryActivityState eanniversaryActivityState2 = EAnniversaryActivityState.Lock;
			if (eanniversaryActivityState.GetValueOrDefault() == eanniversaryActivityState2 & eanniversaryActivityState != null)
			{
				this.RefreshTimeText();
				return;
			}
			this.ChildUpdateTips();
		}

		// Token: 0x06037D0F RID: 228623 RVA: 0x00F9C374 File Offset: 0x00F9A574
		public void RefreshTimeText()
		{
			if (this.Data == null)
			{
				return;
			}
			long getUnlockTime = this.Data.GetUnlockTime;
			double serverTime = TimeUtil.Instance.GetServerTime();
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(getUnlockTime > 0L && serverTime < (double)getUnlockTime);
			}
			if (getUnlockTime > 0L && serverTime < (double)getUnlockTime)
			{
				string text2 = TextConfig.Instance.GetMultiTextByKey("Activity_Anniversary2 _Countdown") ?? "";
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText(getUnlockTime, text2);
				if (!string.IsNullOrEmpty(remainTimeText))
				{
					UUIText text3 = base.GetText(1);
					if (text3 == null)
					{
						return;
					}
					text3.SetText(remainTimeText, true);
				}
			}
		}

		// Token: 0x06037D10 RID: 228624 RVA: 0x00F9C40B File Offset: 0x00F9A60B
		private void OnClick()
		{
			if (this.Data == null)
			{
				return;
			}
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback((int)this.Data.GetSubId());
		}

		// Token: 0x06037D11 RID: 228625 RVA: 0x00F9C434 File Offset: 0x00F9A634
		public UniTask PlayUnlockSequence()
		{
			AnniversaryActivityEnterItem.<PlayUnlockSequence>d__11 <PlayUnlockSequence>d__;
			<PlayUnlockSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockSequence>d__.<>4__this = this;
			<PlayUnlockSequence>d__.<>1__state = -1;
			<PlayUnlockSequence>d__.<>t__builder.Start<AnniversaryActivityEnterItem.<PlayUnlockSequence>d__11>(ref <PlayUnlockSequence>d__);
			return <PlayUnlockSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06037D12 RID: 228626 RVA: 0x00F9C478 File Offset: 0x00F9A678
		private void SetLockState(bool isLock)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isLock);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(isLock);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(!isLock);
			}
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetIsGray(isLock);
		}

		// Token: 0x06037D13 RID: 228627 RVA: 0x00F9C4D8 File Offset: 0x00F9A6D8
		public void RefreshRedDotItem()
		{
			AnniversarySubActivityDataBase data = this.Data;
			bool? flag;
			if (data == null)
			{
				flag = null;
			}
			else
			{
				ActivityBaseData activityData = data.GetActivityData();
				flag = ((activityData != null) ? new bool?(activityData.RedPointShowState) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(valueOrDefault);
		}

		// Token: 0x06037D14 RID: 228628 RVA: 0x00F9C534 File Offset: 0x00F9A734
		public void RefreshFinished()
		{
			AnniversarySubActivityDataBase data = this.Data;
			bool? flag;
			if (data == null)
			{
				flag = null;
			}
			else
			{
				ActivityBaseData activityData = data.GetActivityData();
				flag = ((activityData != null) ? new bool?(activityData.FinishShowState) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			UUITexture texture = base.GetTexture(14);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(valueOrDefault);
		}

		// Token: 0x06037D15 RID: 228629 RVA: 0x00F9C590 File Offset: 0x00F9A790
		public virtual void ChildUpdateStateInfo()
		{
		}

		// Token: 0x06037D16 RID: 228630 RVA: 0x00F9C592 File Offset: 0x00F9A792
		public virtual void ChildUpdateTips()
		{
		}

		// Token: 0x0401D750 RID: 120656
		protected AnniversarySubActivityDataBase Data;

		// Token: 0x0401D751 RID: 120657
		private Action<int> ClickCallback;

		// Token: 0x0401D752 RID: 120658
		public LevelSequencePlayer SequencePlayer;
	}
}

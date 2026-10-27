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
	// Token: 0x02006924 RID: 26916
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryActivityEnterItem : GridProxyAbstract<AnniversarySubActivityDataBase>
	{
		// Token: 0x060431B1 RID: 274865 RVA: 0x0105AA34 File Offset: 0x01058C34
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

		// Token: 0x060431B2 RID: 274866 RVA: 0x0105ABBF File Offset: 0x01058DBF
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060431B3 RID: 274867 RVA: 0x0105ABD2 File Offset: 0x01058DD2
		[NullableContext(1)]
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060431B4 RID: 274868 RVA: 0x0105ABDB File Offset: 0x01058DDB
		public override void Refresh(AnniversarySubActivityDataBase data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x060431B5 RID: 274869 RVA: 0x0105ABE4 File Offset: 0x01058DE4
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

		// Token: 0x060431B6 RID: 274870 RVA: 0x0105ACF8 File Offset: 0x01058EF8
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

		// Token: 0x060431B7 RID: 274871 RVA: 0x0105AD48 File Offset: 0x01058F48
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

		// Token: 0x060431B8 RID: 274872 RVA: 0x0105ADDF File Offset: 0x01058FDF
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

		// Token: 0x060431B9 RID: 274873 RVA: 0x0105AE08 File Offset: 0x01059008
		public UniTask PlayUnlockSequence()
		{
			AnniversaryActivityEnterItem.<PlayUnlockSequence>d__11 <PlayUnlockSequence>d__;
			<PlayUnlockSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockSequence>d__.<>4__this = this;
			<PlayUnlockSequence>d__.<>1__state = -1;
			<PlayUnlockSequence>d__.<>t__builder.Start<AnniversaryActivityEnterItem.<PlayUnlockSequence>d__11>(ref <PlayUnlockSequence>d__);
			return <PlayUnlockSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060431BA RID: 274874 RVA: 0x0105AE4C File Offset: 0x0105904C
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

		// Token: 0x060431BB RID: 274875 RVA: 0x0105AEAC File Offset: 0x010590AC
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

		// Token: 0x060431BC RID: 274876 RVA: 0x0105AF08 File Offset: 0x01059108
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

		// Token: 0x060431BD RID: 274877 RVA: 0x0105AF64 File Offset: 0x01059164
		public virtual void ChildUpdateStateInfo()
		{
		}

		// Token: 0x060431BE RID: 274878 RVA: 0x0105AF66 File Offset: 0x01059166
		public virtual void ChildUpdateTips()
		{
		}

		// Token: 0x04022EF4 RID: 143092
		protected AnniversarySubActivityDataBase Data;

		// Token: 0x04022EF5 RID: 143093
		private Action<int> ClickCallback;

		// Token: 0x04022EF6 RID: 143094
		public LevelSequencePlayer SequencePlayer;
	}
}

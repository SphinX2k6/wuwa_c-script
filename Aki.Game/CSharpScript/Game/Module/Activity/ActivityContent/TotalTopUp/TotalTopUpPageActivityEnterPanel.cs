using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBA RID: 24506
	public class TotalTopUpPageActivityEnterPanel : UiPanelBase
	{
		// Token: 0x0603E1FA RID: 254458 RVA: 0x00F00DD8 File Offset: 0x00EFEFD8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x0603E1FB RID: 254459 RVA: 0x00F00E58 File Offset: 0x00EFF058
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPageActivityEnterPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPageActivityEnterPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1FC RID: 254460 RVA: 0x00F00E9C File Offset: 0x00EFF09C
		protected override void OnStart()
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			TotalTopUpData totalTopUpData = (instance != null) ? instance.GetSingleActivityData() : null;
			this.EndTime = ((totalTopUpData != null) ? totalTopUpData.EndOpenTime : 0L);
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(2), null, (totalTopUpData != null) ? totalTopUpData.Id : 0);
		}

		// Token: 0x0603E1FD RID: 254461 RVA: 0x00F00EEE File Offset: 0x00EFF0EE
		protected override void OnAfterHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(2), 0);
		}

		// Token: 0x0603E1FE RID: 254462 RVA: 0x00F00F04 File Offset: 0x00EFF104
		private void OnClick()
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SkipToCurrentActivityView();
		}

		// Token: 0x0603E1FF RID: 254463 RVA: 0x00F00F18 File Offset: 0x00EFF118
		public void PlayStartSequence()
		{
			if (!base.GetActive())
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603E200 RID: 254464 RVA: 0x00F00F50 File Offset: 0x00EFF150
		public void OnTick()
		{
			if (!base.GetActive())
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = (double)this.EndTime - serverTime;
			if (num < 0.0)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			this.RefreshTime((long)num);
		}

		// Token: 0x0603E201 RID: 254465 RVA: 0x00F00FA0 File Offset: 0x00EFF1A0
		public void RefreshTime(long time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1002", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
		}

		// Token: 0x04020747 RID: 132935
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020748 RID: 132936
		private long EndTime;
	}
}

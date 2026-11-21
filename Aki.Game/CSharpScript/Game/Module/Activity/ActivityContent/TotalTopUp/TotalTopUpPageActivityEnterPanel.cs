using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA1 RID: 20385
	public class TotalTopUpPageActivityEnterPanel : UiPanelBase
	{
		// Token: 0x06033194 RID: 209300 RVA: 0x00E52A94 File Offset: 0x00E50C94
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

		// Token: 0x06033195 RID: 209301 RVA: 0x00E52B14 File Offset: 0x00E50D14
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPageActivityEnterPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPageActivityEnterPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033196 RID: 209302 RVA: 0x00E52B58 File Offset: 0x00E50D58
		protected override void OnStart()
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			TotalTopUpData totalTopUpData = (instance != null) ? instance.GetSingleActivityData() : null;
			this.EndTime = ((totalTopUpData != null) ? totalTopUpData.EndOpenTime : 0L);
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(2), null, (totalTopUpData != null) ? totalTopUpData.Id : 0);
		}

		// Token: 0x06033197 RID: 209303 RVA: 0x00E52BAA File Offset: 0x00E50DAA
		protected override void OnAfterHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(2), 0);
		}

		// Token: 0x06033198 RID: 209304 RVA: 0x00E52BC0 File Offset: 0x00E50DC0
		private void OnClick()
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SkipToCurrentActivityView();
		}

		// Token: 0x06033199 RID: 209305 RVA: 0x00E52BD4 File Offset: 0x00E50DD4
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

		// Token: 0x0603319A RID: 209306 RVA: 0x00E52C0C File Offset: 0x00E50E0C
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

		// Token: 0x0603319B RID: 209307 RVA: 0x00E52C5C File Offset: 0x00E50E5C
		public void RefreshTime(long time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1002", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
		}

		// Token: 0x0401B219 RID: 111129
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B21A RID: 111130
		private long EndTime;
	}
}

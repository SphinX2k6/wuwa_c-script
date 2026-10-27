using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.CoreCard
{
	// Token: 0x02005268 RID: 21096
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCoreCardView : UiViewBase, IUiViewResource
	{
		// Token: 0x06035F0A RID: 220938 RVA: 0x00CC325E File Offset: 0x00CC145E
		public PhantomArenaCoreCardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035F0B RID: 220939 RVA: 0x00CC3268 File Offset: 0x00CC1468
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnCloseClick))
			};
		}

		// Token: 0x06035F0C RID: 220940 RVA: 0x00CC32FB File Offset: 0x00CC14FB
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035F0D RID: 220941 RVA: 0x00CC3304 File Offset: 0x00CC1504
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCoreCardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCoreCardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F0E RID: 220942 RVA: 0x00CC3347 File Offset: 0x00CC1547
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IPhantomArenaCoreCardData);
			this.SetCard();
			this.SetCardTaskDesc();
			this.BindSequence();
		}

		// Token: 0x06035F0F RID: 220943 RVA: 0x00CC336C File Offset: 0x00CC156C
		protected override void OnBeforeDestroy()
		{
			IPhantomArenaCoreCardData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action callback = data.Callback;
			if (callback == null)
			{
				return;
			}
			callback();
		}

		// Token: 0x06035F10 RID: 220944 RVA: 0x00CC3388 File Offset: 0x00CC1588
		private UniTask InitCard()
		{
			PhantomArenaCoreCardView.<InitCard>d__9 <InitCard>d__;
			<InitCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCard>d__.<>4__this = this;
			<InitCard>d__.<>1__state = -1;
			<InitCard>d__.<>t__builder.Start<PhantomArenaCoreCardView.<InitCard>d__9>(ref <InitCard>d__);
			return <InitCard>d__.<>t__builder.Task;
		}

		// Token: 0x06035F11 RID: 220945 RVA: 0x00CC33CC File Offset: 0x00CC15CC
		private void SetCard()
		{
			int taskCardConfigId = PhantomArenaBattleModel.Instance.OwnData.TaskData.TaskCardConfigId;
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(taskCardConfigId);
			this.CardItem.Refresh(taskCardConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleCardConfig.Name, Array.Empty<object>());
		}

		// Token: 0x06035F12 RID: 220946 RVA: 0x00CC3424 File Offset: 0x00CC1624
		private void SetCardTaskDesc()
		{
			bool isAllFinish = PhantomArenaBattleModel.Instance.OwnData.TaskData.IsAllFinish;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(!isAllFinish);
			}
			if (isAllFinish)
			{
				return;
			}
			int taskCardConfigId = PhantomArenaBattleModel.Instance.OwnData.TaskData.TaskCardConfigId;
			PhantomBattleFourCTask phantomArenaFourTask = PhantomArenaConfig.Instance.GetPhantomArenaFourTask(taskCardConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomArenaFourTask.CoreDesc, Array.Empty<object>());
		}

		// Token: 0x06035F13 RID: 220947 RVA: 0x00CC349E File Offset: 0x00CC169E
		private void BindSequence()
		{
			if (PhantomArenaBattleModel.Instance.OwnData.TaskData.IsAllFinish)
			{
				this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.PlayUpdateSequence));
			}
		}

		// Token: 0x06035F14 RID: 220948 RVA: 0x00CC34D2 File Offset: 0x00CC16D2
		private void PlayUpdateSequence(string sequenceName, string eventName)
		{
			if (sequenceName != "Start")
			{
				return;
			}
			if (eventName == "Update")
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlaySequencePurely("Update", false, false);
			}
		}

		// Token: 0x06035F15 RID: 220949 RVA: 0x00CC3506 File Offset: 0x00CC1706
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_CoreCardNew";
			}
			return "UiView_CoreCard";
		}

		// Token: 0x0401C910 RID: 117008
		protected CommonCardItem CardItem;

		// Token: 0x0401C911 RID: 117009
		private IPhantomArenaCoreCardData Data;

		// Token: 0x0200B451 RID: 46161
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036A26 RID: 223782
			public const int CardItem = 0;

			// Token: 0x04036A27 RID: 223783
			public const int ProgressText = 1;

			// Token: 0x04036A28 RID: 223784
			public const int NameText = 2;

			// Token: 0x04036A29 RID: 223785
			public const int CloseBtn = 3;
		}
	}
}

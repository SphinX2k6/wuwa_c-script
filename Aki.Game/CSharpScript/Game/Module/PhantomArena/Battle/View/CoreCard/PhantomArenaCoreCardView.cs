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
	// Token: 0x02004238 RID: 16952
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCoreCardView : UiViewBase, IUiViewResource
	{
		// Token: 0x0602AE05 RID: 175621 RVA: 0x00C10926 File Offset: 0x00C0EB26
		public PhantomArenaCoreCardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AE06 RID: 175622 RVA: 0x00C10930 File Offset: 0x00C0EB30
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

		// Token: 0x0602AE07 RID: 175623 RVA: 0x00C109C3 File Offset: 0x00C0EBC3
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602AE08 RID: 175624 RVA: 0x00C109CC File Offset: 0x00C0EBCC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCoreCardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCoreCardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE09 RID: 175625 RVA: 0x00C10A0F File Offset: 0x00C0EC0F
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IPhantomArenaCoreCardData);
			this.SetCard();
			this.SetCardTaskDesc();
			this.BindSequence();
		}

		// Token: 0x0602AE0A RID: 175626 RVA: 0x00C10A34 File Offset: 0x00C0EC34
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

		// Token: 0x0602AE0B RID: 175627 RVA: 0x00C10A50 File Offset: 0x00C0EC50
		private UniTask InitCard()
		{
			PhantomArenaCoreCardView.<InitCard>d__9 <InitCard>d__;
			<InitCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCard>d__.<>4__this = this;
			<InitCard>d__.<>1__state = -1;
			<InitCard>d__.<>t__builder.Start<PhantomArenaCoreCardView.<InitCard>d__9>(ref <InitCard>d__);
			return <InitCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE0C RID: 175628 RVA: 0x00C10A94 File Offset: 0x00C0EC94
		private void SetCard()
		{
			int taskCardConfigId = PhantomArenaBattleModel.Instance.OwnData.TaskData.TaskCardConfigId;
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(taskCardConfigId);
			this.CardItem.Refresh(taskCardConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleCardConfig.Name, Array.Empty<object>());
		}

		// Token: 0x0602AE0D RID: 175629 RVA: 0x00C10AEC File Offset: 0x00C0ECEC
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

		// Token: 0x0602AE0E RID: 175630 RVA: 0x00C10B66 File Offset: 0x00C0ED66
		private void BindSequence()
		{
			if (PhantomArenaBattleModel.Instance.OwnData.TaskData.IsAllFinish)
			{
				this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.PlayUpdateSequence));
			}
		}

		// Token: 0x0602AE0F RID: 175631 RVA: 0x00C10B9A File Offset: 0x00C0ED9A
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

		// Token: 0x0602AE10 RID: 175632 RVA: 0x00C10BCE File Offset: 0x00C0EDCE
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_CoreCardNew";
			}
			return "UiView_CoreCard";
		}

		// Token: 0x04017345 RID: 95045
		protected CommonCardItem CardItem;

		// Token: 0x04017346 RID: 95046
		private IPhantomArenaCoreCardData Data;

		// Token: 0x02009E89 RID: 40585
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031479 RID: 201849
			public const int CardItem = 0;

			// Token: 0x0403147A RID: 201850
			public const int ProgressText = 1;

			// Token: 0x0403147B RID: 201851
			public const int NameText = 2;

			// Token: 0x0403147C RID: 201852
			public const int CloseBtn = 3;
		}
	}
}

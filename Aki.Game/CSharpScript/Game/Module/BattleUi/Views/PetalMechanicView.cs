using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D8C RID: 19852
	[NullableContext(1)]
	[Nullable(0)]
	public class PetalMechanicView : UiTickViewBase
	{
		// Token: 0x06031D91 RID: 204177 RVA: 0x00DF0F11 File Offset: 0x00DEF111
		public PetalMechanicView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031D92 RID: 204178 RVA: 0x00DF0F44 File Offset: 0x00DEF144
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031D93 RID: 204179 RVA: 0x00DF0F8C File Offset: 0x00DEF18C
		protected override UniTask OnBeforeStartAsync()
		{
			PetalMechanicView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PetalMechanicView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031D94 RID: 204180 RVA: 0x00DF0FCF File Offset: 0x00DEF1CF
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x06031D95 RID: 204181 RVA: 0x00DF0FFC File Offset: 0x00DEF1FC
		public UniTask NewAllSkillItems()
		{
			PetalMechanicView.<NewAllSkillItems>d__9 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<PetalMechanicView.<NewAllSkillItems>d__9>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031D96 RID: 204182 RVA: 0x00DF1040 File Offset: 0x00DEF240
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PetalMechanicSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			PetalMechanicView.<NewSkillItem>d__10 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<PetalMechanicSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<PetalMechanicView.<NewSkillItem>d__10>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031D97 RID: 204183 RVA: 0x00DF1094 File Offset: 0x00DEF294
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshSkillIconByResId("SP_IconT101");
			this.SkillItemList[0].SetActionType(EInputAction.闪避);
			this.SkillItemList[0].RefreshKeyByActionName(this.ActionNameList[0]);
		}

		// Token: 0x06031D98 RID: 204184 RVA: 0x00DF10E8 File Offset: 0x00DEF2E8
		protected override void OnAddEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(this.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			EventSystem.Instance.Add<IClientEventFlyingFlowerUpdateSubtitle>(EEventName.OnFlyingFlowerUpdateSubtitle, new Action<IClientEventFlyingFlowerUpdateSubtitle>(this.OnFlyingFlowerUpdateSubtitle));
		}

		// Token: 0x06031D99 RID: 204185 RVA: 0x00DF113C File Offset: 0x00DEF33C
		protected override void OnRemoveEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(this.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			EventSystem.Instance.Remove<IClientEventFlyingFlowerUpdateSubtitle>(EEventName.OnFlyingFlowerUpdateSubtitle, new Action<IClientEventFlyingFlowerUpdateSubtitle>(this.OnFlyingFlowerUpdateSubtitle));
		}

		// Token: 0x06031D9A RID: 204186 RVA: 0x00DF118D File Offset: 0x00DEF38D
		protected override void OnBeforeHide()
		{
			AnimatedScreenTextController.Instance.Stop();
		}

		// Token: 0x06031D9B RID: 204187 RVA: 0x00DF119C File Offset: 0x00DEF39C
		protected override void OnBeforeDestroy()
		{
			foreach (PetalMechanicSkillItem petalMechanicSkillItem in this.SkillItemList)
			{
				petalMechanicSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEntityEvents();
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x06031D9C RID: 204188 RVA: 0x00DF121C File Offset: 0x00DEF41C
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			for (int i = 0; i < this.ActionNameList.Length; i++)
			{
				if (actionName == this.ActionNameList[i])
				{
					this.SkillItemList[i].OnInputAction(false);
					return;
				}
			}
		}

		// Token: 0x06031D9D RID: 204189 RVA: 0x00DF1263 File Offset: 0x00DEF463
		private void OnBattleUiCurRoleDataChanged(int i, int i1)
		{
			this.RefreshRoleData();
		}

		// Token: 0x06031D9E RID: 204190 RVA: 0x00DF126C File Offset: 0x00DEF46C
		private void RefreshRoleData()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (this.RoleData == curRoleData)
			{
				return;
			}
			this.RemoveEntityEvents();
			this.RoleData = curRoleData;
			this.AddEntityEvents();
		}

		// Token: 0x06031D9F RID: 204191 RVA: 0x00DF12A1 File Offset: 0x00DEF4A1
		private void AddEntityEvents()
		{
		}

		// Token: 0x06031DA0 RID: 204192 RVA: 0x00DF12A4 File Offset: 0x00DEF4A4
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
			this.RoleData = null;
		}

		// Token: 0x06031DA1 RID: 204193 RVA: 0x00DF1308 File Offset: 0x00DEF508
		protected void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int tagId, BaseTagComponent.TTagSwitchedCallback callback, bool checkExistImmediately = false)
		{
			if (checkExistImmediately && tagComponent.HasTag(tagId))
			{
				callback(tagId, true);
			}
			ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(new int?(tagId), callback, null);
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x06031DA2 RID: 204194 RVA: 0x00DF1348 File Offset: 0x00DEF548
		protected override void OnTick(float delta)
		{
			foreach (PetalMechanicSkillItem petalMechanicSkillItem in this.SkillItemList)
			{
				petalMechanicSkillItem.Tick(delta);
			}
		}

		// Token: 0x06031DA3 RID: 204195 RVA: 0x00DF139C File Offset: 0x00DEF59C
		private void OnFlyingFlowerUpdateSubtitle(IClientEventFlyingFlowerUpdateSubtitle @event)
		{
			AnimatedScreenTextController.Instance.PlayByFlow(@event.Flow);
		}

		// Token: 0x0401A629 RID: 108073
		private readonly string[] ActionNameList = new string[]
		{
			"闪避"
		};

		// Token: 0x0401A62A RID: 108074
		private readonly List<PetalMechanicSkillItem> SkillItemList = new List<PetalMechanicSkillItem>();

		// Token: 0x0401A62B RID: 108075
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401A62C RID: 108076
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200AA8A RID: 43658
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034B48 RID: 215880
			Item1
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200422F RID: 16943
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillTriggerMask : UiPanelBase, IAreaCanvas
	{
		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x0602AD76 RID: 175478 RVA: 0x00C0EFA9 File Offset: 0x00C0D1A9
		// (set) Token: 0x0602AD77 RID: 175479 RVA: 0x00C0EFB1 File Offset: 0x00C0D1B1
		public bool IsInSkillInteract
		{
			get
			{
				return this.IsInSkillInteractInternal;
			}
			set
			{
				this.IsInSkillInteractInternal = value;
				UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			}
		}

		// Token: 0x0602AD78 RID: 175480 RVA: 0x00C0EFC4 File Offset: 0x00C0D1C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnConfirmClick)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnCancelClick))
			};
		}

		// Token: 0x0602AD79 RID: 175481 RVA: 0x00C0F0B1 File Offset: 0x00C0D2B1
		private void OnConfirmClick()
		{
			ISkillInteractMainUiInteract uiInteract = this.UiInteract;
			if (uiInteract == null)
			{
				return;
			}
			uiInteract.ReceiveClickData(ESkillInteractMainUiInteractType.ConfirmBtn, new object[0]);
		}

		// Token: 0x0602AD7A RID: 175482 RVA: 0x00C0F0CB File Offset: 0x00C0D2CB
		private void OnCancelClick()
		{
			ISkillInteractMainUiInteract uiInteract = this.UiInteract;
			if (uiInteract == null)
			{
				return;
			}
			uiInteract.ReceiveClickData(ESkillInteractMainUiInteractType.CancelBtn, new object[0]);
		}

		// Token: 0x0602AD7B RID: 175483 RVA: 0x00C0F0E5 File Offset: 0x00C0D2E5
		protected override void OnStart()
		{
			this.ViewProxy.CanvasManager.AddAreaCanvas(this);
		}

		// Token: 0x0602AD7C RID: 175484 RVA: 0x00C0F0F8 File Offset: 0x00C0D2F8
		public void ShowTriggerMask(int? skillId)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(skillId != null);
			}
			this.SetActive(true);
			this.IsInSkillInteract = true;
		}

		// Token: 0x0602AD7D RID: 175485 RVA: 0x00C0F121 File Offset: 0x00C0D321
		public void RefreshTips(int selectNum, int allNum)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "PhantomBattle_1068", new <>z__ReadOnlyArray<object>(new object[]
			{
				allNum,
				selectNum,
				allNum
			}));
		}

		// Token: 0x0602AD7E RID: 175486 RVA: 0x00C0F15F File Offset: 0x00C0D35F
		public void RefreshSkill(string skillName, string skillDesc, string[] paramsList)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), skillName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), skillDesc, paramsList);
		}

		// Token: 0x0602AD7F RID: 175487 RVA: 0x00C0F18C File Offset: 0x00C0D38C
		public void RefreshCancelBtnActive(bool isPassive)
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!isPassive);
		}

		// Token: 0x0602AD80 RID: 175488 RVA: 0x00C0F1BB File Offset: 0x00C0D3BB
		public void HideTriggerMask()
		{
			this.SetActive(false);
			this.IsInSkillInteract = false;
		}

		// Token: 0x0602AD81 RID: 175489 RVA: 0x00C0F1CB File Offset: 0x00C0D3CB
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x0602AD82 RID: 175490 RVA: 0x00C0F1D4 File Offset: 0x00C0D3D4
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return true;
		}

		// Token: 0x0602AD83 RID: 175491 RVA: 0x00C0F1D7 File Offset: 0x00C0D3D7
		public void HandleSortOrder()
		{
		}

		// Token: 0x0602AD84 RID: 175492 RVA: 0x00C0F1D9 File Offset: 0x00C0D3D9
		public void CancelSortOrder()
		{
		}

		// Token: 0x0602AD85 RID: 175493 RVA: 0x00C0F1DB File Offset: 0x00C0D3DB
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x04017323 RID: 95011
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x04017324 RID: 95012
		private PhantomArenaBattleProxy ViewProxy;

		// Token: 0x04017325 RID: 95013
		private bool IsInSkillInteractInternal;

		// Token: 0x02009E71 RID: 40561
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031401 RID: 201729
			public const int ConfirmBtn = 0;

			// Token: 0x04031402 RID: 201730
			public const int SkillItem = 1;

			// Token: 0x04031403 RID: 201731
			public const int SkillName = 2;

			// Token: 0x04031404 RID: 201732
			public const int SkillDesc = 3;

			// Token: 0x04031405 RID: 201733
			public const int TipsItem = 4;

			// Token: 0x04031406 RID: 201734
			public const int Tips = 5;

			// Token: 0x04031407 RID: 201735
			public const int CancelBtn = 6;
		}
	}
}

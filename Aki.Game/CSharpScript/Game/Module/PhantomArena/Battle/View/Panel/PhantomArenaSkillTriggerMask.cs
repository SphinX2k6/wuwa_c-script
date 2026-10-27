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
	// Token: 0x0200525F RID: 21087
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillTriggerMask : UiPanelBase, IAreaCanvas
	{
		// Token: 0x17008263 RID: 33379
		// (get) Token: 0x06035E7B RID: 220795 RVA: 0x00CC1919 File Offset: 0x00CBFB19
		// (set) Token: 0x06035E7C RID: 220796 RVA: 0x00CC1921 File Offset: 0x00CBFB21
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

		// Token: 0x06035E7D RID: 220797 RVA: 0x00CC1934 File Offset: 0x00CBFB34
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

		// Token: 0x06035E7E RID: 220798 RVA: 0x00CC1A21 File Offset: 0x00CBFC21
		private void OnConfirmClick()
		{
			ISkillInteractMainUiInteract uiInteract = this.UiInteract;
			if (uiInteract == null)
			{
				return;
			}
			uiInteract.ReceiveClickData(ESkillInteractMainUiInteractType.ConfirmBtn, new object[0]);
		}

		// Token: 0x06035E7F RID: 220799 RVA: 0x00CC1A3B File Offset: 0x00CBFC3B
		private void OnCancelClick()
		{
			ISkillInteractMainUiInteract uiInteract = this.UiInteract;
			if (uiInteract == null)
			{
				return;
			}
			uiInteract.ReceiveClickData(ESkillInteractMainUiInteractType.CancelBtn, new object[0]);
		}

		// Token: 0x06035E80 RID: 220800 RVA: 0x00CC1A55 File Offset: 0x00CBFC55
		protected override void OnStart()
		{
			this.ViewProxy.CanvasManager.AddAreaCanvas(this);
		}

		// Token: 0x06035E81 RID: 220801 RVA: 0x00CC1A68 File Offset: 0x00CBFC68
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

		// Token: 0x06035E82 RID: 220802 RVA: 0x00CC1A91 File Offset: 0x00CBFC91
		public void RefreshTips(int selectNum, int allNum)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "PhantomBattle_1068", new <>z__ReadOnlyArray<object>(new object[]
			{
				allNum,
				selectNum,
				allNum
			}));
		}

		// Token: 0x06035E83 RID: 220803 RVA: 0x00CC1ACF File Offset: 0x00CBFCCF
		public void RefreshSkill(string skillName, string skillDesc, string[] paramsList)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), skillName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), skillDesc, paramsList);
		}

		// Token: 0x06035E84 RID: 220804 RVA: 0x00CC1AFC File Offset: 0x00CBFCFC
		public void RefreshCancelBtnActive(bool isPassive)
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!isPassive);
		}

		// Token: 0x06035E85 RID: 220805 RVA: 0x00CC1B2B File Offset: 0x00CBFD2B
		public void HideTriggerMask()
		{
			this.SetActive(false);
			this.IsInSkillInteract = false;
		}

		// Token: 0x06035E86 RID: 220806 RVA: 0x00CC1B3B File Offset: 0x00CBFD3B
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x06035E87 RID: 220807 RVA: 0x00CC1B44 File Offset: 0x00CBFD44
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return true;
		}

		// Token: 0x06035E88 RID: 220808 RVA: 0x00CC1B47 File Offset: 0x00CBFD47
		public void HandleSortOrder()
		{
		}

		// Token: 0x06035E89 RID: 220809 RVA: 0x00CC1B49 File Offset: 0x00CBFD49
		public void CancelSortOrder()
		{
		}

		// Token: 0x06035E8A RID: 220810 RVA: 0x00CC1B4B File Offset: 0x00CBFD4B
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x0401C8EE RID: 116974
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x0401C8EF RID: 116975
		private PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C8F0 RID: 116976
		private bool IsInSkillInteractInternal;

		// Token: 0x0200B439 RID: 46137
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040369AE RID: 223662
			public const int ConfirmBtn = 0;

			// Token: 0x040369AF RID: 223663
			public const int SkillItem = 1;

			// Token: 0x040369B0 RID: 223664
			public const int SkillName = 2;

			// Token: 0x040369B1 RID: 223665
			public const int SkillDesc = 3;

			// Token: 0x040369B2 RID: 223666
			public const int TipsItem = 4;

			// Token: 0x040369B3 RID: 223667
			public const int Tips = 5;

			// Token: 0x040369B4 RID: 223668
			public const int CancelBtn = 6;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F85 RID: 16261
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineNormalItem : UiPanelBase
	{
		// Token: 0x06029266 RID: 168550 RVA: 0x00B8E030 File Offset: 0x00B8C230
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClick))
			};
		}

		// Token: 0x06029267 RID: 168551 RVA: 0x00B8E0C4 File Offset: 0x00B8C2C4
		public void RefreshItem(QuestMultiLineBranchData branchData)
		{
			if (branchData == null)
			{
				this.BranchData = null;
				base.GetItem(1).SetUIActive(false);
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			this.BranchData = branchData;
			base.SetTextureByPath(QuestMultiLineUtils.GetIconForGender(branchData.Icons), base.GetTexture(0), null, null);
			base.GetItem(1).SetUIActive(branchData.State == EBranchState.Finish);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), branchData.Name, Array.Empty<object>());
		}

		// Token: 0x06029268 RID: 168552 RVA: 0x00B8E151 File Offset: 0x00B8C351
		public void SetClickFunction(Action<int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x06029269 RID: 168553 RVA: 0x00B8E15A File Offset: 0x00B8C35A
		public void ResetFinishIcon()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0602926A RID: 168554 RVA: 0x00B8E169 File Offset: 0x00B8C369
		private void OnClick()
		{
			QuestMultiLineBranchData branchData = this.BranchData;
			if (branchData != null && branchData.State == EBranchState.Finish)
			{
				return;
			}
			Action<int> clickFunction = this.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction(this.BranchData.BranchId);
		}

		// Token: 0x04016660 RID: 91744
		[Nullable(2)]
		private Action<int> ClickFunction;

		// Token: 0x04016661 RID: 91745
		[Nullable(2)]
		private QuestMultiLineBranchData BranchData;
	}
}

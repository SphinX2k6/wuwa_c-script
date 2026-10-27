using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FBC RID: 20412
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineNormalItem : UiPanelBase
	{
		// Token: 0x060343F8 RID: 214008 RVA: 0x00C44878 File Offset: 0x00C42A78
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

		// Token: 0x060343F9 RID: 214009 RVA: 0x00C4490C File Offset: 0x00C42B0C
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

		// Token: 0x060343FA RID: 214010 RVA: 0x00C44999 File Offset: 0x00C42B99
		public void SetClickFunction(Action<int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x060343FB RID: 214011 RVA: 0x00C449A2 File Offset: 0x00C42BA2
		public void ResetFinishIcon()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x060343FC RID: 214012 RVA: 0x00C449B1 File Offset: 0x00C42BB1
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

		// Token: 0x0401BC8B RID: 113803
		[Nullable(2)]
		private Action<int> ClickFunction;

		// Token: 0x0401BC8C RID: 113804
		[Nullable(2)]
		private QuestMultiLineBranchData BranchData;
	}
}

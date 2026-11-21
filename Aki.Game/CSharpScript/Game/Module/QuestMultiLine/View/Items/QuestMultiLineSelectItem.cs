using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F89 RID: 16265
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineSelectItem : UiPanelBase
	{
		// Token: 0x06029278 RID: 168568 RVA: 0x00B8E880 File Offset: 0x00B8CA80
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickOk))
			};
		}

		// Token: 0x06029279 RID: 168569 RVA: 0x00B8E900 File Offset: 0x00B8CB00
		public void RefreshItem(QuestMultiLineBranchData branchData)
		{
			if (branchData == null)
			{
				this.BranchData = null;
				base.SetUiActive(false);
				return;
			}
			this.BranchData = branchData;
			base.SetTextureByPath(QuestMultiLineUtils.GetIconForGender(branchData.Icons), base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), branchData.Desc, Array.Empty<object>());
		}

		// Token: 0x0602927A RID: 168570 RVA: 0x00B8E964 File Offset: 0x00B8CB64
		public void SetClickFunction(Action<int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x0602927B RID: 168571 RVA: 0x00B8E96D File Offset: 0x00B8CB6D
		private void OnClickOk()
		{
			Action<int> clickFunction = this.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction(this.BranchData.BranchId);
		}

		// Token: 0x0401666C RID: 91756
		[Nullable(2)]
		private Action<int> ClickFunction;

		// Token: 0x0401666D RID: 91757
		[Nullable(2)]
		private QuestMultiLineBranchData BranchData;
	}
}

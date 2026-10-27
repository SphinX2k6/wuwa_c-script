using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FC0 RID: 20416
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineSelectItem : UiPanelBase
	{
		// Token: 0x0603440A RID: 214026 RVA: 0x00C450C8 File Offset: 0x00C432C8
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

		// Token: 0x0603440B RID: 214027 RVA: 0x00C45148 File Offset: 0x00C43348
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

		// Token: 0x0603440C RID: 214028 RVA: 0x00C451AC File Offset: 0x00C433AC
		public void SetClickFunction(Action<int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x0603440D RID: 214029 RVA: 0x00C451B5 File Offset: 0x00C433B5
		private void OnClickOk()
		{
			Action<int> clickFunction = this.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction(this.BranchData.BranchId);
		}

		// Token: 0x0401BC97 RID: 113815
		[Nullable(2)]
		private Action<int> ClickFunction;

		// Token: 0x0401BC98 RID: 113816
		[Nullable(2)]
		private QuestMultiLineBranchData BranchData;
	}
}

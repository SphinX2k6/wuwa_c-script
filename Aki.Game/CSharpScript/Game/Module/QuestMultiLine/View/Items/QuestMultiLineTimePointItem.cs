using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FC6 RID: 20422
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestMultiLineTimePointItem : GridProxyAbstract<QuestMultiLineTimePointData>
	{
		// Token: 0x0603442E RID: 214062 RVA: 0x00C45D74 File Offset: 0x00C43F74
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClick)),
				new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleClick))
			};
		}

		// Token: 0x0603442F RID: 214063 RVA: 0x00C45E78 File Offset: 0x00C44078
		public override void Refresh(QuestMultiLineTimePointData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetSprite(0).SetUIActive(true);
			this.RefreshPointSprite(data);
			if (this.Data.IsUnLock)
			{
				base.GetText(6).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.NameBottom, Array.Empty<object>());
			}
			else
			{
				base.GetText(6).SetUIActive(false);
				base.GetText(3).SetText("???", true);
			}
			this.RefreshRedDot();
			this.RefreshSelected(isSelected);
		}

		// Token: 0x06034430 RID: 214064 RVA: 0x00C45F24 File Offset: 0x00C44124
		private UniTask RefreshPointSprite(QuestMultiLineTimePointData data)
		{
			QuestMultiLineTimePointItem.<RefreshPointSprite>d__4 <RefreshPointSprite>d__;
			<RefreshPointSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPointSprite>d__.<>4__this = this;
			<RefreshPointSprite>d__.data = data;
			<RefreshPointSprite>d__.<>1__state = -1;
			<RefreshPointSprite>d__.<>t__builder.Start<QuestMultiLineTimePointItem.<RefreshPointSprite>d__4>(ref <RefreshPointSprite>d__);
			return <RefreshPointSprite>d__.<>t__builder.Task;
		}

		// Token: 0x06034431 RID: 214065 RVA: 0x00C45F70 File Offset: 0x00C44170
		private void RefreshRedDot()
		{
			QuestMultiLineTimePointData data = this.Data;
			bool uiactive = data != null && data.IsUnLock && QuestMultiLineModel.Instance.GetTimePointRedDot(this.Data.Id);
			base.GetItem(4).SetUIActive(uiactive);
		}

		// Token: 0x06034432 RID: 214066 RVA: 0x00C45FB7 File Offset: 0x00C441B7
		public override void OnSelected(bool fireEvent)
		{
			QuestMultiLineModel.Instance.ClearTimePointRedDot(this.Data.Id);
			this.RefreshRedDot();
			this.RefreshSelected(true);
		}

		// Token: 0x06034433 RID: 214067 RVA: 0x00C45FDB File Offset: 0x00C441DB
		public override void OnDeselected(bool fireEvent)
		{
			this.RefreshSelected(false);
		}

		// Token: 0x06034434 RID: 214068 RVA: 0x00C45FE4 File Offset: 0x00C441E4
		public void RefreshSelected(bool selected)
		{
			UUIText text = base.GetText(3);
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(selected, fcolor);
			UUIText text2 = base.GetText(6);
			UUIItem uuiitem2 = text2;
			fcolor = new FColor?(text2.changeColor);
			uuiitem2.SetChangeColor(selected, fcolor);
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				extendToggle.SetToggleStateForce(state, false, false, false);
			}
		}

		// Token: 0x06034435 RID: 214069 RVA: 0x00C4604A File Offset: 0x00C4424A
		public void SetFunction(Action<QuestMultiLineTimePointData> buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06034436 RID: 214070 RVA: 0x00C46053 File Offset: 0x00C44253
		private void OnClick()
		{
			Action<QuestMultiLineTimePointData> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.Data);
		}

		// Token: 0x06034437 RID: 214071 RVA: 0x00C4606B File Offset: 0x00C4426B
		private void OnToggleClick(EToggleState state)
		{
			this.OnClick();
		}

		// Token: 0x0401BCC4 RID: 113860
		[Nullable(2)]
		private QuestMultiLineTimePointData Data;

		// Token: 0x0401BCC5 RID: 113861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineTimePointData> ButtonFunction;
	}
}

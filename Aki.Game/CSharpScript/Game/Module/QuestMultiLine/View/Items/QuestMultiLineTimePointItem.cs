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
	// Token: 0x02003F8F RID: 16271
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestMultiLineTimePointItem : GridProxyAbstract<QuestMultiLineTimePointData>
	{
		// Token: 0x0602929C RID: 168604 RVA: 0x00B8F52C File Offset: 0x00B8D72C
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

		// Token: 0x0602929D RID: 168605 RVA: 0x00B8F630 File Offset: 0x00B8D830
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

		// Token: 0x0602929E RID: 168606 RVA: 0x00B8F6DC File Offset: 0x00B8D8DC
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

		// Token: 0x0602929F RID: 168607 RVA: 0x00B8F728 File Offset: 0x00B8D928
		private void RefreshRedDot()
		{
			QuestMultiLineTimePointData data = this.Data;
			bool uiactive = data != null && data.IsUnLock && QuestMultiLineModel.Instance.GetTimePointRedDot(this.Data.Id);
			base.GetItem(4).SetUIActive(uiactive);
		}

		// Token: 0x060292A0 RID: 168608 RVA: 0x00B8F76F File Offset: 0x00B8D96F
		public override void OnSelected(bool fireEvent)
		{
			QuestMultiLineModel.Instance.ClearTimePointRedDot(this.Data.Id);
			this.RefreshRedDot();
			this.RefreshSelected(true);
		}

		// Token: 0x060292A1 RID: 168609 RVA: 0x00B8F793 File Offset: 0x00B8D993
		public override void OnDeselected(bool fireEvent)
		{
			this.RefreshSelected(false);
		}

		// Token: 0x060292A2 RID: 168610 RVA: 0x00B8F79C File Offset: 0x00B8D99C
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

		// Token: 0x060292A3 RID: 168611 RVA: 0x00B8F802 File Offset: 0x00B8DA02
		public void SetFunction(Action<QuestMultiLineTimePointData> buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x060292A4 RID: 168612 RVA: 0x00B8F80B File Offset: 0x00B8DA0B
		private void OnClick()
		{
			Action<QuestMultiLineTimePointData> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.Data);
		}

		// Token: 0x060292A5 RID: 168613 RVA: 0x00B8F823 File Offset: 0x00B8DA23
		private void OnToggleClick(EToggleState state)
		{
			this.OnClick();
		}

		// Token: 0x04016699 RID: 91801
		[Nullable(2)]
		private QuestMultiLineTimePointData Data;

		// Token: 0x0401669A RID: 91802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineTimePointData> ButtonFunction;
	}
}

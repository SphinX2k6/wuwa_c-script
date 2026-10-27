using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F34 RID: 28468
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherCircleItem : AutoAttachExhibitionItemAbstract
	{
		// Token: 0x0604541C RID: 283676 RVA: 0x01122AF7 File Offset: 0x01120CF7
		public CipherCircleItem(AActor uiItem) : base(uiItem)
		{
		}

		// Token: 0x0604541D RID: 283677 RVA: 0x01122B30 File Offset: 0x01120D30
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0604541E RID: 283678 RVA: 0x01122B54 File Offset: 0x01120D54
		public override void RefreshItem(int showItemIndex)
		{
			this.CurrentNumber = new int?(this.Data[base.GetShowItemIndex()]);
			if (this.CurrentNumber == null)
			{
				return;
			}
			base.GetText(0).SetText(this.CurrentNumber.Value.ToString(), true);
		}

		// Token: 0x0604541F RID: 283679 RVA: 0x01122BA8 File Offset: 0x01120DA8
		public override void OnSelect()
		{
			base.OnSelect();
			CipherModel.Instance.SetCurPassword(this.OwnerId, this.CurrentNumber.Value);
			base.GetText(0).useChangeColor = false;
			if (this.ItemSelectedCallback == null)
			{
				return;
			}
			this.ItemSelectedCallback(this.CurrentNumber.Value);
		}

		// Token: 0x06045420 RID: 283680 RVA: 0x01122C02 File Offset: 0x01120E02
		public override void OnUnSelect()
		{
			base.OnUnSelect();
			base.GetText(0).SetColor(this.NormalColor);
			base.GetText(0).useChangeColor = true;
		}

		// Token: 0x06045421 RID: 283681 RVA: 0x01122C29 File Offset: 0x01120E29
		public override void SetData(object param)
		{
			this.Data = (param as int[]);
		}

		// Token: 0x06045422 RID: 283682 RVA: 0x01122C37 File Offset: 0x01120E37
		public void InitItem(int ownerId, Action<int> cb)
		{
			this.OwnerId = ownerId;
			this.ItemSelectedCallback = cb;
		}

		// Token: 0x06045423 RID: 283683 RVA: 0x01122C48 File Offset: 0x01120E48
		public void HandleConfirm(bool result)
		{
			FColor color = this.WrongColor;
			if (result)
			{
				color = this.RightColor;
			}
			base.GetText(0).SetColor(color);
		}

		// Token: 0x06045424 RID: 283684 RVA: 0x01122C73 File Offset: 0x01120E73
		public int? GetNumber()
		{
			return this.CurrentNumber;
		}

		// Token: 0x040241BF RID: 147903
		private const string WRONG_COLOR = "BB5C58";

		// Token: 0x040241C0 RID: 147904
		private const string RIGHT_COLOR = "F6D03F";

		// Token: 0x040241C1 RID: 147905
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x040241C2 RID: 147906
		private int OwnerId;

		// Token: 0x040241C3 RID: 147907
		private int? CurrentNumber;

		// Token: 0x040241C4 RID: 147908
		[Nullable(2)]
		private int[] Data;

		// Token: 0x040241C5 RID: 147909
		private readonly FColor WrongColor = FColor.FromHex("BB5C58");

		// Token: 0x040241C6 RID: 147910
		private readonly FColor RightColor = FColor.FromHex("F6D03F");

		// Token: 0x040241C7 RID: 147911
		private readonly FColor NormalColor = FColor.FromHex("FFFFFF");

		// Token: 0x040241C8 RID: 147912
		[Nullable(2)]
		private Action<int> ItemSelectedCallback;

		// Token: 0x0200CD75 RID: 52597
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DEA6 RID: 253606
			public const int TextNum = 0;
		}
	}
}

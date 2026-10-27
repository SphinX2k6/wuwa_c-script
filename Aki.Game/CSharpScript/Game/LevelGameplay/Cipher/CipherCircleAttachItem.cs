using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F33 RID: 28467
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherCircleAttachItem : AutoAttachItem<int>
	{
		// Token: 0x06045413 RID: 283667 RVA: 0x01122971 File Offset: 0x01120B71
		[NullableContext(2)]
		public CipherCircleAttachItem(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x06045414 RID: 283668 RVA: 0x011229AA File Offset: 0x01120BAA
		protected override void OnMoveItem()
		{
		}

		// Token: 0x06045415 RID: 283669 RVA: 0x011229AC File Offset: 0x01120BAC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06045416 RID: 283670 RVA: 0x011229D0 File Offset: 0x01120BD0
		protected override void OnRefreshItem(int data)
		{
			this.CurrentNumber = new int?(data);
			if (this.CurrentNumber == null)
			{
				return;
			}
			base.GetText(0).SetText(this.CurrentNumber.Value.ToString(), true);
		}

		// Token: 0x06045417 RID: 283671 RVA: 0x01122A18 File Offset: 0x01120C18
		public override void OnSelect()
		{
			CipherModel.Instance.SetCurPassword(this.OwnerId, this.CurrentNumber.Value);
			UUIText text = base.GetText(0);
			UUIItem uuiitem = text;
			bool bUseChangeColor = false;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			if (this.ItemSelectedCallback == null)
			{
				return;
			}
			this.ItemSelectedCallback(this.CurrentNumber.Value);
		}

		// Token: 0x06045418 RID: 283672 RVA: 0x01122A7C File Offset: 0x01120C7C
		protected override void OnUnSelect()
		{
			UUIText text = base.GetText(0);
			text.SetColor(this.NormalColor);
			UUIItem uuiitem = text;
			bool bUseChangeColor = true;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x06045419 RID: 283673 RVA: 0x01122AB2 File Offset: 0x01120CB2
		[NullableContext(2)]
		public void InitData(int ownerId, Action<int> cb)
		{
			this.OwnerId = ownerId;
			this.ItemSelectedCallback = cb;
		}

		// Token: 0x0604541A RID: 283674 RVA: 0x01122AC4 File Offset: 0x01120CC4
		public void HandleConfirm(bool result)
		{
			FColor color = this.WrongColor;
			if (result)
			{
				color = this.RightColor;
			}
			base.GetText(0).SetColor(color);
		}

		// Token: 0x0604541B RID: 283675 RVA: 0x01122AEF File Offset: 0x01120CEF
		public int? GetNumber()
		{
			return this.CurrentNumber;
		}

		// Token: 0x040241B6 RID: 147894
		private const string WRONG_COLOR = "BB5C58";

		// Token: 0x040241B7 RID: 147895
		private const string RIGHT_COLOR = "F6D03F";

		// Token: 0x040241B8 RID: 147896
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x040241B9 RID: 147897
		private int OwnerId;

		// Token: 0x040241BA RID: 147898
		private int? CurrentNumber;

		// Token: 0x040241BB RID: 147899
		private readonly FColor WrongColor = FColor.FromHex("BB5C58");

		// Token: 0x040241BC RID: 147900
		private readonly FColor RightColor = FColor.FromHex("F6D03F");

		// Token: 0x040241BD RID: 147901
		private readonly FColor NormalColor = FColor.FromHex("FFFFFF");

		// Token: 0x040241BE RID: 147902
		[Nullable(2)]
		private Action<int> ItemSelectedCallback;

		// Token: 0x0200CD74 RID: 52596
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DEA5 RID: 253605
			public const int TextNum = 0;
		}
	}
}

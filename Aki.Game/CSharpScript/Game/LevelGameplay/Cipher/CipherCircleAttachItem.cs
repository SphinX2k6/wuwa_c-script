using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x020060B4 RID: 24756
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherCircleAttachItem : AutoAttachItem<int>
	{
		// Token: 0x0603B5C1 RID: 243137 RVA: 0x010CC91D File Offset: 0x010CAB1D
		[NullableContext(2)]
		public CipherCircleAttachItem(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0603B5C2 RID: 243138 RVA: 0x010CC956 File Offset: 0x010CAB56
		protected override void OnMoveItem()
		{
		}

		// Token: 0x0603B5C3 RID: 243139 RVA: 0x010CC958 File Offset: 0x010CAB58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603B5C4 RID: 243140 RVA: 0x010CC97C File Offset: 0x010CAB7C
		protected override void OnRefreshItem(int data)
		{
			this.CurrentNumber = new int?(data);
			if (this.CurrentNumber == null)
			{
				return;
			}
			base.GetText(0).SetText(this.CurrentNumber.Value.ToString(), true);
		}

		// Token: 0x0603B5C5 RID: 243141 RVA: 0x010CC9C4 File Offset: 0x010CABC4
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

		// Token: 0x0603B5C6 RID: 243142 RVA: 0x010CCA28 File Offset: 0x010CAC28
		protected override void OnUnSelect()
		{
			UUIText text = base.GetText(0);
			text.SetColor(this.NormalColor);
			UUIItem uuiitem = text;
			bool bUseChangeColor = true;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0603B5C7 RID: 243143 RVA: 0x010CCA5E File Offset: 0x010CAC5E
		[NullableContext(2)]
		public void InitData(int ownerId, Action<int> cb)
		{
			this.OwnerId = ownerId;
			this.ItemSelectedCallback = cb;
		}

		// Token: 0x0603B5C8 RID: 243144 RVA: 0x010CCA70 File Offset: 0x010CAC70
		public void HandleConfirm(bool result)
		{
			FColor color = this.WrongColor;
			if (result)
			{
				color = this.RightColor;
			}
			base.GetText(0).SetColor(color);
		}

		// Token: 0x0603B5C9 RID: 243145 RVA: 0x010CCA9B File Offset: 0x010CAC9B
		public int? GetNumber()
		{
			return this.CurrentNumber;
		}

		// Token: 0x0401F46B RID: 128107
		private const string WRONG_COLOR = "BB5C58";

		// Token: 0x0401F46C RID: 128108
		private const string RIGHT_COLOR = "F6D03F";

		// Token: 0x0401F46D RID: 128109
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x0401F46E RID: 128110
		private int OwnerId;

		// Token: 0x0401F46F RID: 128111
		private int? CurrentNumber;

		// Token: 0x0401F470 RID: 128112
		private readonly FColor WrongColor = FColor.FromHex("BB5C58");

		// Token: 0x0401F471 RID: 128113
		private readonly FColor RightColor = FColor.FromHex("F6D03F");

		// Token: 0x0401F472 RID: 128114
		private readonly FColor NormalColor = FColor.FromHex("FFFFFF");

		// Token: 0x0401F473 RID: 128115
		[Nullable(2)]
		private Action<int> ItemSelectedCallback;

		// Token: 0x0200B966 RID: 47462
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040392D4 RID: 234196
			public const int TextNum = 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x020060B5 RID: 24757
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherCircleItem : AutoAttachExhibitionItemAbstract
	{
		// Token: 0x0603B5CA RID: 243146 RVA: 0x010CCAA3 File Offset: 0x010CACA3
		public CipherCircleItem(AActor uiItem) : base(uiItem)
		{
		}

		// Token: 0x0603B5CB RID: 243147 RVA: 0x010CCADC File Offset: 0x010CACDC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603B5CC RID: 243148 RVA: 0x010CCB00 File Offset: 0x010CAD00
		public override void RefreshItem(int showItemIndex)
		{
			this.CurrentNumber = new int?(this.Data[base.GetShowItemIndex()]);
			if (this.CurrentNumber == null)
			{
				return;
			}
			base.GetText(0).SetText(this.CurrentNumber.Value.ToString(), true);
		}

		// Token: 0x0603B5CD RID: 243149 RVA: 0x010CCB54 File Offset: 0x010CAD54
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

		// Token: 0x0603B5CE RID: 243150 RVA: 0x010CCBAE File Offset: 0x010CADAE
		public override void OnUnSelect()
		{
			base.OnUnSelect();
			base.GetText(0).SetColor(this.NormalColor);
			base.GetText(0).useChangeColor = true;
		}

		// Token: 0x0603B5CF RID: 243151 RVA: 0x010CCBD5 File Offset: 0x010CADD5
		public override void SetData(object param)
		{
			this.Data = (param as int[]);
		}

		// Token: 0x0603B5D0 RID: 243152 RVA: 0x010CCBE3 File Offset: 0x010CADE3
		public void InitItem(int ownerId, Action<int> cb)
		{
			this.OwnerId = ownerId;
			this.ItemSelectedCallback = cb;
		}

		// Token: 0x0603B5D1 RID: 243153 RVA: 0x010CCBF4 File Offset: 0x010CADF4
		public void HandleConfirm(bool result)
		{
			FColor color = this.WrongColor;
			if (result)
			{
				color = this.RightColor;
			}
			base.GetText(0).SetColor(color);
		}

		// Token: 0x0603B5D2 RID: 243154 RVA: 0x010CCC1F File Offset: 0x010CAE1F
		public int? GetNumber()
		{
			return this.CurrentNumber;
		}

		// Token: 0x0401F474 RID: 128116
		private const string WRONG_COLOR = "BB5C58";

		// Token: 0x0401F475 RID: 128117
		private const string RIGHT_COLOR = "F6D03F";

		// Token: 0x0401F476 RID: 128118
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x0401F477 RID: 128119
		private int OwnerId;

		// Token: 0x0401F478 RID: 128120
		private int? CurrentNumber;

		// Token: 0x0401F479 RID: 128121
		[Nullable(2)]
		private int[] Data;

		// Token: 0x0401F47A RID: 128122
		private readonly FColor WrongColor = FColor.FromHex("BB5C58");

		// Token: 0x0401F47B RID: 128123
		private readonly FColor RightColor = FColor.FromHex("F6D03F");

		// Token: 0x0401F47C RID: 128124
		private readonly FColor NormalColor = FColor.FromHex("FFFFFF");

		// Token: 0x0401F47D RID: 128125
		[Nullable(2)]
		private Action<int> ItemSelectedCallback;

		// Token: 0x0200B967 RID: 47463
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040392D5 RID: 234197
			public const int TextNum = 0;
		}
	}
}

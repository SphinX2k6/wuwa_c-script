using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D0 RID: 13520
	[NullableContext(2)]
	[Nullable(0)]
	public class PropertyTimeCounter
	{
		// Token: 0x0602269E RID: 140958 RVA: 0x009BFC68 File Offset: 0x009BDE68
		public void Init(int id, ECharacterBodySpecifiedType bodyType, int sectionIndex, ECharacterSlotSpecifiedType slotType, FName propertyName, FKuroCurveFloat curveFloatData, FKuroCurveLinearColor curveColorData, float wholeTime, EPropertyCurveDataType dataType)
		{
			this.Id = id;
			this.BodyType = bodyType;
			this.SectionIndex = sectionIndex;
			this.SlotType = slotType;
			this.PropertyName = new FName?(propertyName);
			this.WholeTime = wholeTime;
			this.DataType = dataType;
			this.Counter = 0f;
			EPropertyCurveDataType dataType2 = this.DataType;
			if (dataType2 == EPropertyCurveDataType.Float)
			{
				this.CurveFloatData = curveFloatData;
				this.CurveColorData = null;
				return;
			}
			if (dataType2 != EPropertyCurveDataType.Color)
			{
				return;
			}
			this.CurveColorData = curveColorData;
			this.CurveFloatData = null;
		}

		// Token: 0x04012EF7 RID: 77559
		public int Id;

		// Token: 0x04012EF8 RID: 77560
		public float Factor;

		// Token: 0x04012EF9 RID: 77561
		public float WholeTime;

		// Token: 0x04012EFA RID: 77562
		public float Counter;

		// Token: 0x04012EFB RID: 77563
		public ECharacterBodySpecifiedType BodyType;

		// Token: 0x04012EFC RID: 77564
		public int SectionIndex;

		// Token: 0x04012EFD RID: 77565
		public ECharacterSlotSpecifiedType SlotType;

		// Token: 0x04012EFE RID: 77566
		public FName? PropertyName;

		// Token: 0x04012EFF RID: 77567
		public FKuroCurveFloat CurveFloatData;

		// Token: 0x04012F00 RID: 77568
		public FKuroCurveLinearColor CurveColorData;

		// Token: 0x04012F01 RID: 77569
		public EPropertyCurveDataType DataType;
	}
}

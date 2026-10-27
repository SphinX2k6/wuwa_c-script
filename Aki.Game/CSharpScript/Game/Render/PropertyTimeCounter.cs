using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A8 RID: 17832
	[NullableContext(2)]
	[Nullable(0)]
	public class PropertyTimeCounter
	{
		// Token: 0x0602DFB4 RID: 188340 RVA: 0x00A93A48 File Offset: 0x00A91C48
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

		// Token: 0x040188BC RID: 100540
		public int Id;

		// Token: 0x040188BD RID: 100541
		public float Factor;

		// Token: 0x040188BE RID: 100542
		public float WholeTime;

		// Token: 0x040188BF RID: 100543
		public float Counter;

		// Token: 0x040188C0 RID: 100544
		public ECharacterBodySpecifiedType BodyType;

		// Token: 0x040188C1 RID: 100545
		public int SectionIndex;

		// Token: 0x040188C2 RID: 100546
		public ECharacterSlotSpecifiedType SlotType;

		// Token: 0x040188C3 RID: 100547
		public FName? PropertyName;

		// Token: 0x040188C4 RID: 100548
		public FKuroCurveFloat CurveFloatData;

		// Token: 0x040188C5 RID: 100549
		public FKuroCurveLinearColor CurveColorData;

		// Token: 0x040188C6 RID: 100550
		public EPropertyCurveDataType DataType;
	}
}

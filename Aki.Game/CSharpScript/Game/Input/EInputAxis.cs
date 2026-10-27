using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FCA RID: 28618
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EInputAxis : IEquatable<EInputAxis>
	{
		// Token: 0x060459AF RID: 285103 RVA: 0x01149A72 File Offset: 0x01147C72
		private EInputAxis(string name, byte inputAxisEnum)
		{
			this.Name = name;
			this.Value = inputAxisEnum;
		}

		// Token: 0x060459B0 RID: 285104 RVA: 0x01149A82 File Offset: 0x01147C82
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x060459B1 RID: 285105 RVA: 0x01149A8A File Offset: 0x01147C8A
		public bool Equals(EInputAxis other)
		{
			return this.Name == other.Name;
		}

		// Token: 0x060459B2 RID: 285106 RVA: 0x01149AA0 File Offset: 0x01147CA0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EInputAxis)
			{
				EInputAxis other = (EInputAxis)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060459B3 RID: 285107 RVA: 0x01149AC5 File Offset: 0x01147CC5
		public override int GetHashCode()
		{
			string name = this.Name;
			if (name == null)
			{
				return 0;
			}
			return name.GetHashCode();
		}

		// Token: 0x060459B4 RID: 285108 RVA: 0x01149AD8 File Offset: 0x01147CD8
		public static bool operator ==(EInputAxis left, EInputAxis right)
		{
			return left.Value == right.Value;
		}

		// Token: 0x060459B5 RID: 285109 RVA: 0x01149AE8 File Offset: 0x01147CE8
		public static bool operator !=(EInputAxis left, EInputAxis right)
		{
			return left.Value != right.Value;
		}

		// Token: 0x060459B6 RID: 285110 RVA: 0x01149AFB File Offset: 0x01147CFB
		public static implicit operator byte(EInputAxis axis)
		{
			return axis.Value;
		}

		// Token: 0x060459B7 RID: 285111 RVA: 0x01149B04 File Offset: 0x01147D04
		public static explicit operator EInputAxis(byte value)
		{
			switch (value)
			{
			case 0:
				return EInputAxis.None;
			case 1:
				return EInputAxis.LookUp;
			case 2:
				return EInputAxis.Turn;
			case 3:
				return EInputAxis.MoveForward;
			case 4:
				return EInputAxis.MoveRight;
			case 5:
				return EInputAxis.Zoom;
			case 6:
				return EInputAxis.WheelAxis;
			default:
				return default(EInputAxis);
			}
		}

		// Token: 0x04024536 RID: 148790
		public readonly string Name;

		// Token: 0x04024537 RID: 148791
		public readonly byte Value;

		// Token: 0x04024538 RID: 148792
		public const byte NoneValue = 0;

		// Token: 0x04024539 RID: 148793
		public static readonly EInputAxis None = new EInputAxis("None", 0);

		// Token: 0x0402453A RID: 148794
		public const byte LookUpValue = 1;

		// Token: 0x0402453B RID: 148795
		public static readonly EInputAxis LookUp = new EInputAxis("LookUp", 1);

		// Token: 0x0402453C RID: 148796
		public const byte TurnValue = 2;

		// Token: 0x0402453D RID: 148797
		public static readonly EInputAxis Turn = new EInputAxis("Turn", 2);

		// Token: 0x0402453E RID: 148798
		public const byte MoveForwardValue = 3;

		// Token: 0x0402453F RID: 148799
		public static readonly EInputAxis MoveForward = new EInputAxis("MoveForward", 3);

		// Token: 0x04024540 RID: 148800
		public const byte MoveRightValue = 4;

		// Token: 0x04024541 RID: 148801
		public static readonly EInputAxis MoveRight = new EInputAxis("MoveRight", 4);

		// Token: 0x04024542 RID: 148802
		public const byte ZoomValue = 5;

		// Token: 0x04024543 RID: 148803
		public static readonly EInputAxis Zoom = new EInputAxis("Zoom", 5);

		// Token: 0x04024544 RID: 148804
		public const byte WheelAxisValue = 6;

		// Token: 0x04024545 RID: 148805
		public static readonly EInputAxis WheelAxis = new EInputAxis("WheelAxis", 6);

		// Token: 0x04024546 RID: 148806
		[StaticVariableRuleIgnore]
		public static IReadOnlyList<EInputAxis> Defines = new List<EInputAxis>
		{
			EInputAxis.None,
			EInputAxis.LookUp,
			EInputAxis.Turn,
			EInputAxis.MoveForward,
			EInputAxis.MoveRight,
			EInputAxis.Zoom,
			EInputAxis.WheelAxis
		};
	}
}

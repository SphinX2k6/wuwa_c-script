using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input
{
	// Token: 0x0200614B RID: 24907
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EInputAxis : IEquatable<EInputAxis>
	{
		// Token: 0x0603BB5F RID: 244575 RVA: 0x010F386A File Offset: 0x010F1A6A
		private EInputAxis(string name, byte inputAxisEnum)
		{
			this.Name = name;
			this.Value = inputAxisEnum;
		}

		// Token: 0x0603BB60 RID: 244576 RVA: 0x010F387A File Offset: 0x010F1A7A
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0603BB61 RID: 244577 RVA: 0x010F3882 File Offset: 0x010F1A82
		public bool Equals(EInputAxis other)
		{
			return this.Name == other.Name;
		}

		// Token: 0x0603BB62 RID: 244578 RVA: 0x010F3898 File Offset: 0x010F1A98
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

		// Token: 0x0603BB63 RID: 244579 RVA: 0x010F38BD File Offset: 0x010F1ABD
		public override int GetHashCode()
		{
			string name = this.Name;
			if (name == null)
			{
				return 0;
			}
			return name.GetHashCode();
		}

		// Token: 0x0603BB64 RID: 244580 RVA: 0x010F38D0 File Offset: 0x010F1AD0
		public static bool operator ==(EInputAxis left, EInputAxis right)
		{
			return left.Value == right.Value;
		}

		// Token: 0x0603BB65 RID: 244581 RVA: 0x010F38E0 File Offset: 0x010F1AE0
		public static bool operator !=(EInputAxis left, EInputAxis right)
		{
			return left.Value != right.Value;
		}

		// Token: 0x0603BB66 RID: 244582 RVA: 0x010F38F3 File Offset: 0x010F1AF3
		public static implicit operator byte(EInputAxis axis)
		{
			return axis.Value;
		}

		// Token: 0x0603BB67 RID: 244583 RVA: 0x010F38FC File Offset: 0x010F1AFC
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

		// Token: 0x0401F7EB RID: 129003
		public readonly string Name;

		// Token: 0x0401F7EC RID: 129004
		public readonly byte Value;

		// Token: 0x0401F7ED RID: 129005
		public const byte NoneValue = 0;

		// Token: 0x0401F7EE RID: 129006
		public static readonly EInputAxis None = new EInputAxis("None", 0);

		// Token: 0x0401F7EF RID: 129007
		public const byte LookUpValue = 1;

		// Token: 0x0401F7F0 RID: 129008
		public static readonly EInputAxis LookUp = new EInputAxis("LookUp", 1);

		// Token: 0x0401F7F1 RID: 129009
		public const byte TurnValue = 2;

		// Token: 0x0401F7F2 RID: 129010
		public static readonly EInputAxis Turn = new EInputAxis("Turn", 2);

		// Token: 0x0401F7F3 RID: 129011
		public const byte MoveForwardValue = 3;

		// Token: 0x0401F7F4 RID: 129012
		public static readonly EInputAxis MoveForward = new EInputAxis("MoveForward", 3);

		// Token: 0x0401F7F5 RID: 129013
		public const byte MoveRightValue = 4;

		// Token: 0x0401F7F6 RID: 129014
		public static readonly EInputAxis MoveRight = new EInputAxis("MoveRight", 4);

		// Token: 0x0401F7F7 RID: 129015
		public const byte ZoomValue = 5;

		// Token: 0x0401F7F8 RID: 129016
		public static readonly EInputAxis Zoom = new EInputAxis("Zoom", 5);

		// Token: 0x0401F7F9 RID: 129017
		public const byte WheelAxisValue = 6;

		// Token: 0x0401F7FA RID: 129018
		public static readonly EInputAxis WheelAxis = new EInputAxis("WheelAxis", 6);

		// Token: 0x0401F7FB RID: 129019
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

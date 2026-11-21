using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Reflection.Emit
{
	// Token: 0x020007C9 RID: 1993
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct OpCode : IEquatable<OpCode>
	{
		// Token: 0x06008020 RID: 32800 RVA: 0x0012E074 File Offset: 0x0012C274
		internal OpCode(OpCodeValues value, int flags)
		{
			this.m_value = value;
			this.m_flags = flags;
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x0012E084 File Offset: 0x0012C284
		public int EvaluationStackDelta
		{
			get
			{
				return this.m_flags >> 28;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x0012E08F File Offset: 0x0012C28F
		public OperandType OperandType
		{
			get
			{
				return (OperandType)(this.m_flags & 31);
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x0012E09A File Offset: 0x0012C29A
		public FlowControl FlowControl
		{
			get
			{
				return (FlowControl)(this.m_flags >> 5 & 15);
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06008024 RID: 32804 RVA: 0x0012E0A7 File Offset: 0x0012C2A7
		public OpCodeType OpCodeType
		{
			get
			{
				return (OpCodeType)(this.m_flags >> 9 & 7);
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x0012E0B4 File Offset: 0x0012C2B4
		public StackBehaviour StackBehaviourPop
		{
			get
			{
				return (StackBehaviour)(this.m_flags >> 12 & 31);
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06008026 RID: 32806 RVA: 0x0012E0C2 File Offset: 0x0012C2C2
		public StackBehaviour StackBehaviourPush
		{
			get
			{
				return (StackBehaviour)(this.m_flags >> 17 & 31);
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x0012E0D0 File Offset: 0x0012C2D0
		public int Size
		{
			get
			{
				return this.m_flags >> 22 & 3;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x0012E0DD File Offset: 0x0012C2DD
		public short Value
		{
			get
			{
				return (short)this.m_value;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x0012E0E8 File Offset: 0x0012C2E8
		public string Name
		{
			get
			{
				if (this.Size == 0)
				{
					return null;
				}
				string[] array = OpCode.g_nameCache;
				if (array == null)
				{
					array = new string[287];
					OpCode.g_nameCache = array;
				}
				OpCodeValues opCodeValues = (OpCodeValues)((ushort)this.Value);
				int num = (int)opCodeValues;
				if (num > 255)
				{
					if (num < 65024 || num > 65054)
					{
						return null;
					}
					num = 256 + (num - 65024);
				}
				string text = Volatile.Read<string>(ref array[num]);
				if (text != null)
				{
					return text;
				}
				text = Enum.GetName<OpCodeValues>(opCodeValues).ToLowerInvariant().Replace('_', '.');
				Volatile.Write<string>(ref array[num], text);
				return text;
			}
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x0012E188 File Offset: 0x0012C388
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is OpCode)
			{
				OpCode obj2 = (OpCode)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x0012E1AD File Offset: 0x0012C3AD
		public bool Equals(OpCode obj)
		{
			return obj.Value == this.Value;
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x0012E1BE File Offset: 0x0012C3BE
		public static bool operator ==(OpCode a, OpCode b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x0012E1C8 File Offset: 0x0012C3C8
		public static bool operator !=(OpCode a, OpCode b)
		{
			return !(a == b);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x0012E1D4 File Offset: 0x0012C3D4
		public override int GetHashCode()
		{
			return (int)this.Value;
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x0012E1DC File Offset: 0x0012C3DC
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x040018B2 RID: 6322
		private readonly OpCodeValues m_value;

		// Token: 0x040018B3 RID: 6323
		private readonly int m_flags;

		// Token: 0x040018B4 RID: 6324
		private static volatile string[] g_nameCache;
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000592 RID: 1426
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Sse2 : Sse
	{
		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x00061AC6 File Offset: 0x0005FCC6
		public new static bool IsSupported
		{
			get
			{
				return Sse2.IsSupported;
			}
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00109A12 File Offset: 0x00107C12
		public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00109A1B File Offset: 0x00107C1B
		public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00109A24 File Offset: 0x00107C24
		public static Vector128<short> Add(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x00109A2D File Offset: 0x00107C2D
		public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x00109A36 File Offset: 0x00107C36
		public static Vector128<int> Add(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00109A3F File Offset: 0x00107C3F
		public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00109A48 File Offset: 0x00107C48
		public static Vector128<long> Add(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00109A51 File Offset: 0x00107C51
		public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00109A5A File Offset: 0x00107C5A
		public static Vector128<double> Add(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Add(left, right);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00109A63 File Offset: 0x00107C63
		public static Vector128<double> AddScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.AddScalar(left, right);
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x00109A6C File Offset: 0x00107C6C
		public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.AddSaturate(left, right);
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00109A75 File Offset: 0x00107C75
		public static Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.AddSaturate(left, right);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x00109A7E File Offset: 0x00107C7E
		public static Vector128<short> AddSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.AddSaturate(left, right);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x00109A87 File Offset: 0x00107C87
		public static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.AddSaturate(left, right);
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00109A90 File Offset: 0x00107C90
		public static Vector128<byte> And(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00109A99 File Offset: 0x00107C99
		public static Vector128<sbyte> And(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00109AA2 File Offset: 0x00107CA2
		public static Vector128<short> And(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00109AAB File Offset: 0x00107CAB
		public static Vector128<ushort> And(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00109AB4 File Offset: 0x00107CB4
		public static Vector128<int> And(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00109ABD File Offset: 0x00107CBD
		public static Vector128<uint> And(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00109AC6 File Offset: 0x00107CC6
		public static Vector128<long> And(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x00109ACF File Offset: 0x00107CCF
		public static Vector128<ulong> And(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x00109AD8 File Offset: 0x00107CD8
		public static Vector128<double> And(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.And(left, right);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x00109AE1 File Offset: 0x00107CE1
		public static Vector128<byte> AndNot(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x00109AEA File Offset: 0x00107CEA
		public static Vector128<sbyte> AndNot(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x00109AF3 File Offset: 0x00107CF3
		public static Vector128<short> AndNot(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00109AFC File Offset: 0x00107CFC
		public static Vector128<ushort> AndNot(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00109B05 File Offset: 0x00107D05
		public static Vector128<int> AndNot(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x00109B0E File Offset: 0x00107D0E
		public static Vector128<uint> AndNot(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x00109B17 File Offset: 0x00107D17
		public static Vector128<long> AndNot(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x00109B20 File Offset: 0x00107D20
		public static Vector128<ulong> AndNot(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x00109B29 File Offset: 0x00107D29
		public static Vector128<double> AndNot(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.AndNot(left, right);
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00109B32 File Offset: 0x00107D32
		public static Vector128<byte> Average(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Average(left, right);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00109B3B File Offset: 0x00107D3B
		public static Vector128<ushort> Average(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.Average(left, right);
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x00109B44 File Offset: 0x00107D44
		public static Vector128<sbyte> CompareEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00109B4D File Offset: 0x00107D4D
		public static Vector128<byte> CompareEqual(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00109B56 File Offset: 0x00107D56
		public static Vector128<short> CompareEqual(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x00109B5F File Offset: 0x00107D5F
		public static Vector128<ushort> CompareEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00109B68 File Offset: 0x00107D68
		public static Vector128<int> CompareEqual(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x00109B71 File Offset: 0x00107D71
		public static Vector128<uint> CompareEqual(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x00109B7A File Offset: 0x00107D7A
		public static Vector128<double> CompareEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareEqual(left, right);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00109B83 File Offset: 0x00107D83
		public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.CompareGreaterThan(left, right);
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00109B8C File Offset: 0x00107D8C
		public static Vector128<short> CompareGreaterThan(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.CompareGreaterThan(left, right);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00109B95 File Offset: 0x00107D95
		public static Vector128<int> CompareGreaterThan(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.CompareGreaterThan(left, right);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00109B9E File Offset: 0x00107D9E
		public static Vector128<double> CompareGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareGreaterThan(left, right);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00109BA7 File Offset: 0x00107DA7
		public static Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00109BB0 File Offset: 0x00107DB0
		public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.CompareLessThan(left, right);
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x00109BB9 File Offset: 0x00107DB9
		public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.CompareLessThan(left, right);
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x00109BC2 File Offset: 0x00107DC2
		public static Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.CompareLessThan(left, right);
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x00109BCB File Offset: 0x00107DCB
		public static Vector128<double> CompareLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareLessThan(left, right);
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x00109BD4 File Offset: 0x00107DD4
		public static Vector128<double> CompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareLessThanOrEqual(left, right);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00109BDD File Offset: 0x00107DDD
		public static Vector128<double> CompareNotEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareNotEqual(left, right);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00109BE6 File Offset: 0x00107DE6
		public static Vector128<double> CompareNotGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareNotGreaterThan(left, right);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x00109BEF File Offset: 0x00107DEF
		public static Vector128<double> CompareNotGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareNotGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00109BF8 File Offset: 0x00107DF8
		public static Vector128<double> CompareNotLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareNotLessThan(left, right);
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x00109C01 File Offset: 0x00107E01
		public static Vector128<double> CompareNotLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareNotLessThanOrEqual(left, right);
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00109C0A File Offset: 0x00107E0A
		public static Vector128<double> CompareOrdered(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareOrdered(left, right);
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00109C13 File Offset: 0x00107E13
		public static Vector128<double> CompareScalarEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarEqual(left, right);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x00109C1C File Offset: 0x00107E1C
		public static Vector128<double> CompareScalarGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarGreaterThan(left, right);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00109C25 File Offset: 0x00107E25
		public static Vector128<double> CompareScalarGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00109C2E File Offset: 0x00107E2E
		public static Vector128<double> CompareScalarLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarLessThan(left, right);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00109C37 File Offset: 0x00107E37
		public static Vector128<double> CompareScalarLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarLessThanOrEqual(left, right);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x00109C40 File Offset: 0x00107E40
		public static Vector128<double> CompareScalarNotEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarNotEqual(left, right);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00109C49 File Offset: 0x00107E49
		public static Vector128<double> CompareScalarNotGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarNotGreaterThan(left, right);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00109C52 File Offset: 0x00107E52
		public static Vector128<double> CompareScalarNotGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarNotGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x00109C5B File Offset: 0x00107E5B
		public static Vector128<double> CompareScalarNotLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarNotLessThan(left, right);
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00109C64 File Offset: 0x00107E64
		public static Vector128<double> CompareScalarNotLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarNotLessThanOrEqual(left, right);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00109C6D File Offset: 0x00107E6D
		public static Vector128<double> CompareScalarOrdered(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrdered(left, right);
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00109C76 File Offset: 0x00107E76
		public static bool CompareScalarOrderedEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedEqual(left, right);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x00109C7F File Offset: 0x00107E7F
		public static bool CompareScalarOrderedGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedGreaterThan(left, right);
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x00109C88 File Offset: 0x00107E88
		public static bool CompareScalarOrderedGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x00109C91 File Offset: 0x00107E91
		public static bool CompareScalarOrderedLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedLessThan(left, right);
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x00109C9A File Offset: 0x00107E9A
		public static bool CompareScalarOrderedLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedLessThanOrEqual(left, right);
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x00109CA3 File Offset: 0x00107EA3
		public static bool CompareScalarOrderedNotEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarOrderedNotEqual(left, right);
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00109CAC File Offset: 0x00107EAC
		public static Vector128<double> CompareScalarUnordered(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnordered(left, right);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x00109CB5 File Offset: 0x00107EB5
		public static bool CompareScalarUnorderedEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedEqual(left, right);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x00109CBE File Offset: 0x00107EBE
		public static bool CompareScalarUnorderedGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedGreaterThan(left, right);
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x00109CC7 File Offset: 0x00107EC7
		public static bool CompareScalarUnorderedGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x00109CD0 File Offset: 0x00107ED0
		public static bool CompareScalarUnorderedLessThan(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedLessThan(left, right);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x00109CD9 File Offset: 0x00107ED9
		public static bool CompareScalarUnorderedLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedLessThanOrEqual(left, right);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00109CE2 File Offset: 0x00107EE2
		public static bool CompareScalarUnorderedNotEqual(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareScalarUnorderedNotEqual(left, right);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x00109CEB File Offset: 0x00107EEB
		public static Vector128<double> CompareUnordered(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.CompareUnordered(left, right);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00109CF4 File Offset: 0x00107EF4
		public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, int value)
		{
			return Sse2.ConvertScalarToVector128Double(upper, value);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00109CFD File Offset: 0x00107EFD
		public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, Vector128<float> value)
		{
			return Sse2.ConvertScalarToVector128Double(upper, value);
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x00109D06 File Offset: 0x00107F06
		public static Vector128<int> ConvertScalarToVector128Int32(int value)
		{
			return Sse2.ConvertScalarToVector128Int32(value);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00109D0E File Offset: 0x00107F0E
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, Vector128<double> value)
		{
			return Sse2.ConvertScalarToVector128Single(upper, value);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00109D17 File Offset: 0x00107F17
		public static Vector128<uint> ConvertScalarToVector128UInt32(uint value)
		{
			return Sse2.ConvertScalarToVector128UInt32(value);
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x00109D1F File Offset: 0x00107F1F
		public static int ConvertToInt32(Vector128<int> value)
		{
			return Sse2.ConvertToInt32(value);
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00109D27 File Offset: 0x00107F27
		public static int ConvertToInt32(Vector128<double> value)
		{
			return Sse2.ConvertToInt32(value);
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00109D2F File Offset: 0x00107F2F
		public static int ConvertToInt32WithTruncation(Vector128<double> value)
		{
			return Sse2.ConvertToInt32WithTruncation(value);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00109D37 File Offset: 0x00107F37
		public static uint ConvertToUInt32(Vector128<uint> value)
		{
			return Sse2.ConvertToUInt32(value);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00109D3F File Offset: 0x00107F3F
		public static Vector128<double> ConvertToVector128Double(Vector128<int> value)
		{
			return Sse2.ConvertToVector128Double(value);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00109D47 File Offset: 0x00107F47
		public static Vector128<double> ConvertToVector128Double(Vector128<float> value)
		{
			return Sse2.ConvertToVector128Double(value);
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00109D4F File Offset: 0x00107F4F
		public static Vector128<int> ConvertToVector128Int32(Vector128<float> value)
		{
			return Sse2.ConvertToVector128Int32(value);
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x00109D57 File Offset: 0x00107F57
		public static Vector128<int> ConvertToVector128Int32(Vector128<double> value)
		{
			return Sse2.ConvertToVector128Int32(value);
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00109D5F File Offset: 0x00107F5F
		public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector128<float> value)
		{
			return Sse2.ConvertToVector128Int32WithTruncation(value);
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00109D67 File Offset: 0x00107F67
		public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector128<double> value)
		{
			return Sse2.ConvertToVector128Int32WithTruncation(value);
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x00109D6F File Offset: 0x00107F6F
		public static Vector128<float> ConvertToVector128Single(Vector128<int> value)
		{
			return Sse2.ConvertToVector128Single(value);
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00109D77 File Offset: 0x00107F77
		public static Vector128<float> ConvertToVector128Single(Vector128<double> value)
		{
			return Sse2.ConvertToVector128Single(value);
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00109D7F File Offset: 0x00107F7F
		public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Divide(left, right);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00109D88 File Offset: 0x00107F88
		public static Vector128<double> DivideScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.DivideScalar(left, right);
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00109D91 File Offset: 0x00107F91
		public static ushort Extract(Vector128<ushort> value, [ConstantExpected] byte index)
		{
			return Sse2.Extract(value, index);
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00109D9A File Offset: 0x00107F9A
		public static Vector128<short> Insert(Vector128<short> value, short data, [ConstantExpected] byte index)
		{
			return Sse2.Insert(value, data, index);
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00109DA4 File Offset: 0x00107FA4
		public static Vector128<ushort> Insert(Vector128<ushort> value, ushort data, [ConstantExpected] byte index)
		{
			return Sse2.Insert(value, data, index);
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00109DAE File Offset: 0x00107FAE
		public unsafe static Vector128<sbyte> LoadAlignedVector128(sbyte* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00109DB6 File Offset: 0x00107FB6
		public unsafe static Vector128<byte> LoadAlignedVector128(byte* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00109DBE File Offset: 0x00107FBE
		public unsafe static Vector128<short> LoadAlignedVector128(short* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00109DC6 File Offset: 0x00107FC6
		public unsafe static Vector128<ushort> LoadAlignedVector128(ushort* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00109DCE File Offset: 0x00107FCE
		public unsafe static Vector128<int> LoadAlignedVector128(int* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00109DD6 File Offset: 0x00107FD6
		public unsafe static Vector128<uint> LoadAlignedVector128(uint* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00109DDE File Offset: 0x00107FDE
		public unsafe static Vector128<long> LoadAlignedVector128(long* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00109DE6 File Offset: 0x00107FE6
		public unsafe static Vector128<ulong> LoadAlignedVector128(ulong* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00109DEE File Offset: 0x00107FEE
		public unsafe static Vector128<double> LoadAlignedVector128(double* address)
		{
			return Sse2.LoadAlignedVector128(address);
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00109DF6 File Offset: 0x00107FF6
		public static void LoadFence()
		{
			Sse2.LoadFence();
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x00109DFD File Offset: 0x00107FFD
		public unsafe static Vector128<double> LoadHigh(Vector128<double> lower, double* address)
		{
			return Sse2.LoadHigh(lower, address);
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x00109E06 File Offset: 0x00108006
		public unsafe static Vector128<double> LoadLow(Vector128<double> upper, double* address)
		{
			return Sse2.LoadLow(upper, address);
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x00109E0F File Offset: 0x0010800F
		public unsafe static Vector128<int> LoadScalarVector128(int* address)
		{
			return Sse2.LoadScalarVector128(address);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00109E17 File Offset: 0x00108017
		public unsafe static Vector128<uint> LoadScalarVector128(uint* address)
		{
			return Sse2.LoadScalarVector128(address);
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x00109E1F File Offset: 0x0010801F
		public unsafe static Vector128<long> LoadScalarVector128(long* address)
		{
			return Sse2.LoadScalarVector128(address);
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x00109E27 File Offset: 0x00108027
		public unsafe static Vector128<ulong> LoadScalarVector128(ulong* address)
		{
			return Sse2.LoadScalarVector128(address);
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x00109E2F File Offset: 0x0010802F
		public unsafe static Vector128<double> LoadScalarVector128(double* address)
		{
			return Sse2.LoadScalarVector128(address);
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x00109E37 File Offset: 0x00108037
		public unsafe static Vector128<sbyte> LoadVector128(sbyte* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x00109E3F File Offset: 0x0010803F
		public unsafe static Vector128<byte> LoadVector128(byte* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00109E47 File Offset: 0x00108047
		public unsafe static Vector128<short> LoadVector128(short* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x00109E4F File Offset: 0x0010804F
		public unsafe static Vector128<ushort> LoadVector128(ushort* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x00109E57 File Offset: 0x00108057
		public unsafe static Vector128<int> LoadVector128(int* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x00109E5F File Offset: 0x0010805F
		public unsafe static Vector128<uint> LoadVector128(uint* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x00109E67 File Offset: 0x00108067
		public unsafe static Vector128<long> LoadVector128(long* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x00109E6F File Offset: 0x0010806F
		public unsafe static Vector128<ulong> LoadVector128(ulong* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00109E77 File Offset: 0x00108077
		public unsafe static Vector128<double> LoadVector128(double* address)
		{
			return Sse2.LoadVector128(address);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x00109E7F File Offset: 0x0010807F
		public unsafe static void MaskMove(Vector128<sbyte> source, Vector128<sbyte> mask, sbyte* address)
		{
			Sse2.MaskMove(source, mask, address);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00109E89 File Offset: 0x00108089
		public unsafe static void MaskMove(Vector128<byte> source, Vector128<byte> mask, byte* address)
		{
			Sse2.MaskMove(source, mask, address);
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00109E93 File Offset: 0x00108093
		public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Max(left, right);
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00109E9C File Offset: 0x0010809C
		public static Vector128<short> Max(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Max(left, right);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00109EA5 File Offset: 0x001080A5
		public static Vector128<double> Max(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Max(left, right);
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00109EAE File Offset: 0x001080AE
		public static Vector128<double> MaxScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.MaxScalar(left, right);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00109EB7 File Offset: 0x001080B7
		public static void MemoryFence()
		{
			Sse2.MemoryFence();
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00109EBE File Offset: 0x001080BE
		public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Min(left, right);
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00109EC7 File Offset: 0x001080C7
		public static Vector128<short> Min(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Min(left, right);
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x00109ED0 File Offset: 0x001080D0
		public static Vector128<double> Min(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Min(left, right);
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x00109ED9 File Offset: 0x001080D9
		public static Vector128<double> MinScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.MinScalar(left, right);
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x00109EE2 File Offset: 0x001080E2
		public static int MoveMask(Vector128<sbyte> value)
		{
			return Sse2.MoveMask(value);
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x00109EEA File Offset: 0x001080EA
		public static int MoveMask(Vector128<byte> value)
		{
			return Sse2.MoveMask(value);
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x00109EF2 File Offset: 0x001080F2
		public static int MoveMask(Vector128<double> value)
		{
			return Sse2.MoveMask(value);
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x00109EFA File Offset: 0x001080FA
		public static Vector128<long> MoveScalar(Vector128<long> value)
		{
			return Sse2.MoveScalar(value);
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x00109F02 File Offset: 0x00108102
		public static Vector128<ulong> MoveScalar(Vector128<ulong> value)
		{
			return Sse2.MoveScalar(value);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x00109F0A File Offset: 0x0010810A
		public static Vector128<double> MoveScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse2.MoveScalar(upper, value);
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x00109F13 File Offset: 0x00108113
		public static Vector128<ulong> Multiply(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.Multiply(left, right);
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x00109F1C File Offset: 0x0010811C
		public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Multiply(left, right);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x00109F25 File Offset: 0x00108125
		public static Vector128<int> MultiplyAddAdjacent(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.MultiplyAddAdjacent(left, right);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00109F2E File Offset: 0x0010812E
		public static Vector128<short> MultiplyHigh(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.MultiplyHigh(left, right);
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x00109F37 File Offset: 0x00108137
		public static Vector128<ushort> MultiplyHigh(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.MultiplyHigh(left, right);
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00109F40 File Offset: 0x00108140
		public static Vector128<short> MultiplyLow(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.MultiplyLow(left, right);
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00109F49 File Offset: 0x00108149
		public static Vector128<ushort> MultiplyLow(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.MultiplyLow(left, right);
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00109F52 File Offset: 0x00108152
		public static Vector128<double> MultiplyScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.MultiplyScalar(left, right);
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00109F5B File Offset: 0x0010815B
		public static Vector128<byte> Or(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00109F64 File Offset: 0x00108164
		public static Vector128<sbyte> Or(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00109F6D File Offset: 0x0010816D
		public static Vector128<short> Or(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00109F76 File Offset: 0x00108176
		public static Vector128<ushort> Or(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x00109F7F File Offset: 0x0010817F
		public static Vector128<int> Or(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00109F88 File Offset: 0x00108188
		public static Vector128<uint> Or(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00109F91 File Offset: 0x00108191
		public static Vector128<long> Or(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00109F9A File Offset: 0x0010819A
		public static Vector128<ulong> Or(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00109FA3 File Offset: 0x001081A3
		public static Vector128<double> Or(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Or(left, right);
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00109FAC File Offset: 0x001081AC
		public static Vector128<sbyte> PackSignedSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.PackSignedSaturate(left, right);
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00109FB5 File Offset: 0x001081B5
		public static Vector128<short> PackSignedSaturate(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.PackSignedSaturate(left, right);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00109FBE File Offset: 0x001081BE
		public static Vector128<byte> PackUnsignedSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.PackUnsignedSaturate(left, right);
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x00109FC7 File Offset: 0x001081C7
		public static Vector128<short> ShiftLeftLogical(Vector128<short> value, Vector128<short> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x00109FD0 File Offset: 0x001081D0
		public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, Vector128<ushort> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x00109FD9 File Offset: 0x001081D9
		public static Vector128<int> ShiftLeftLogical(Vector128<int> value, Vector128<int> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x00109FE2 File Offset: 0x001081E2
		public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, Vector128<uint> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x00109FEB File Offset: 0x001081EB
		public static Vector128<long> ShiftLeftLogical(Vector128<long> value, Vector128<long> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x00109FF4 File Offset: 0x001081F4
		public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, Vector128<ulong> count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x00109FFD File Offset: 0x001081FD
		public static Vector128<short> ShiftLeftLogical(Vector128<short> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x0010A006 File Offset: 0x00108206
		public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x0010A00F File Offset: 0x0010820F
		public static Vector128<int> ShiftLeftLogical(Vector128<int> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x0010A018 File Offset: 0x00108218
		public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x0010A021 File Offset: 0x00108221
		public static Vector128<long> ShiftLeftLogical(Vector128<long> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x0010A02A File Offset: 0x0010822A
		public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftLeftLogical(value, count);
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x0010A033 File Offset: 0x00108233
		public static Vector128<sbyte> ShiftLeftLogical128BitLane(Vector128<sbyte> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x0010A03C File Offset: 0x0010823C
		public static Vector128<byte> ShiftLeftLogical128BitLane(Vector128<byte> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x0010A045 File Offset: 0x00108245
		public static Vector128<short> ShiftLeftLogical128BitLane(Vector128<short> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x0010A04E File Offset: 0x0010824E
		public static Vector128<ushort> ShiftLeftLogical128BitLane(Vector128<ushort> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x0010A057 File Offset: 0x00108257
		public static Vector128<int> ShiftLeftLogical128BitLane(Vector128<int> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x0010A060 File Offset: 0x00108260
		public static Vector128<uint> ShiftLeftLogical128BitLane(Vector128<uint> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x0010A069 File Offset: 0x00108269
		public static Vector128<long> ShiftLeftLogical128BitLane(Vector128<long> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x0010A072 File Offset: 0x00108272
		public static Vector128<ulong> ShiftLeftLogical128BitLane(Vector128<ulong> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x0010A07B File Offset: 0x0010827B
		public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, Vector128<short> count)
		{
			return Sse2.ShiftRightArithmetic(value, count);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0010A084 File Offset: 0x00108284
		public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, Vector128<int> count)
		{
			return Sse2.ShiftRightArithmetic(value, count);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x0010A08D File Offset: 0x0010828D
		public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightArithmetic(value, count);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x0010A096 File Offset: 0x00108296
		public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightArithmetic(value, count);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x0010A09F File Offset: 0x0010829F
		public static Vector128<short> ShiftRightLogical(Vector128<short> value, Vector128<short> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x0010A0A8 File Offset: 0x001082A8
		public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, Vector128<ushort> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x0010A0B1 File Offset: 0x001082B1
		public static Vector128<int> ShiftRightLogical(Vector128<int> value, Vector128<int> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0010A0BA File Offset: 0x001082BA
		public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, Vector128<uint> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x0010A0C3 File Offset: 0x001082C3
		public static Vector128<long> ShiftRightLogical(Vector128<long> value, Vector128<long> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x0010A0CC File Offset: 0x001082CC
		public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, Vector128<ulong> count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x0010A0D5 File Offset: 0x001082D5
		public static Vector128<short> ShiftRightLogical(Vector128<short> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x0010A0DE File Offset: 0x001082DE
		public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x0010A0E7 File Offset: 0x001082E7
		public static Vector128<int> ShiftRightLogical(Vector128<int> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x0010A0F0 File Offset: 0x001082F0
		public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x0010A0F9 File Offset: 0x001082F9
		public static Vector128<long> ShiftRightLogical(Vector128<long> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x0010A102 File Offset: 0x00108302
		public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, [ConstantExpected] byte count)
		{
			return Sse2.ShiftRightLogical(value, count);
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x0010A10B File Offset: 0x0010830B
		public static Vector128<sbyte> ShiftRightLogical128BitLane(Vector128<sbyte> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x0010A114 File Offset: 0x00108314
		public static Vector128<byte> ShiftRightLogical128BitLane(Vector128<byte> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x0010A11D File Offset: 0x0010831D
		public static Vector128<short> ShiftRightLogical128BitLane(Vector128<short> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0010A126 File Offset: 0x00108326
		public static Vector128<ushort> ShiftRightLogical128BitLane(Vector128<ushort> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x0010A12F File Offset: 0x0010832F
		public static Vector128<int> ShiftRightLogical128BitLane(Vector128<int> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x0010A138 File Offset: 0x00108338
		public static Vector128<uint> ShiftRightLogical128BitLane(Vector128<uint> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x0010A141 File Offset: 0x00108341
		public static Vector128<long> ShiftRightLogical128BitLane(Vector128<long> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x0010A14A File Offset: 0x0010834A
		public static Vector128<ulong> ShiftRightLogical128BitLane(Vector128<ulong> value, [ConstantExpected] byte numBytes)
		{
			return Sse2.ShiftRightLogical128BitLane(value, numBytes);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x0010A153 File Offset: 0x00108353
		public static Vector128<int> Shuffle(Vector128<int> value, [ConstantExpected] byte control)
		{
			return Sse2.Shuffle(value, control);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x0010A15C File Offset: 0x0010835C
		public static Vector128<uint> Shuffle(Vector128<uint> value, [ConstantExpected] byte control)
		{
			return Sse2.Shuffle(value, control);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x0010A165 File Offset: 0x00108365
		public static Vector128<double> Shuffle(Vector128<double> left, Vector128<double> right, [ConstantExpected] byte control)
		{
			return Sse2.Shuffle(left, right, control);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x0010A16F File Offset: 0x0010836F
		public static Vector128<short> ShuffleHigh(Vector128<short> value, [ConstantExpected] byte control)
		{
			return Sse2.ShuffleHigh(value, control);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0010A178 File Offset: 0x00108378
		public static Vector128<ushort> ShuffleHigh(Vector128<ushort> value, [ConstantExpected] byte control)
		{
			return Sse2.ShuffleHigh(value, control);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0010A181 File Offset: 0x00108381
		public static Vector128<short> ShuffleLow(Vector128<short> value, [ConstantExpected] byte control)
		{
			return Sse2.ShuffleLow(value, control);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x0010A18A File Offset: 0x0010838A
		public static Vector128<ushort> ShuffleLow(Vector128<ushort> value, [ConstantExpected] byte control)
		{
			return Sse2.ShuffleLow(value, control);
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x0010A193 File Offset: 0x00108393
		public static Vector128<double> Sqrt(Vector128<double> value)
		{
			return Sse2.Sqrt(value);
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x0010A19B File Offset: 0x0010839B
		public static Vector128<double> SqrtScalar(Vector128<double> value)
		{
			return Sse2.SqrtScalar(value);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x0010A1A3 File Offset: 0x001083A3
		public static Vector128<double> SqrtScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse2.SqrtScalar(upper, value);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0010A1AC File Offset: 0x001083AC
		public unsafe static void Store(sbyte* address, Vector128<sbyte> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x0010A1B5 File Offset: 0x001083B5
		public unsafe static void Store(byte* address, Vector128<byte> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0010A1BE File Offset: 0x001083BE
		public unsafe static void Store(short* address, Vector128<short> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x0010A1C7 File Offset: 0x001083C7
		public unsafe static void Store(ushort* address, Vector128<ushort> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x0010A1D0 File Offset: 0x001083D0
		public unsafe static void Store(int* address, Vector128<int> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x0010A1D9 File Offset: 0x001083D9
		public unsafe static void Store(uint* address, Vector128<uint> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x0010A1E2 File Offset: 0x001083E2
		public unsafe static void Store(long* address, Vector128<long> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x0010A1EB File Offset: 0x001083EB
		public unsafe static void Store(ulong* address, Vector128<ulong> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x0010A1F4 File Offset: 0x001083F4
		public unsafe static void Store(double* address, Vector128<double> source)
		{
			Sse2.Store(address, source);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x0010A1FD File Offset: 0x001083FD
		public unsafe static void StoreAligned(sbyte* address, Vector128<sbyte> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x0010A206 File Offset: 0x00108406
		public unsafe static void StoreAligned(byte* address, Vector128<byte> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x0010A20F File Offset: 0x0010840F
		public unsafe static void StoreAligned(short* address, Vector128<short> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x0010A218 File Offset: 0x00108418
		public unsafe static void StoreAligned(ushort* address, Vector128<ushort> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x0010A221 File Offset: 0x00108421
		public unsafe static void StoreAligned(int* address, Vector128<int> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x0010A22A File Offset: 0x0010842A
		public unsafe static void StoreAligned(uint* address, Vector128<uint> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x0010A233 File Offset: 0x00108433
		public unsafe static void StoreAligned(long* address, Vector128<long> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x0010A23C File Offset: 0x0010843C
		public unsafe static void StoreAligned(ulong* address, Vector128<ulong> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x0010A245 File Offset: 0x00108445
		public unsafe static void StoreAligned(double* address, Vector128<double> source)
		{
			Sse2.StoreAligned(address, source);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x0010A24E File Offset: 0x0010844E
		public unsafe static void StoreAlignedNonTemporal(sbyte* address, Vector128<sbyte> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x0010A257 File Offset: 0x00108457
		public unsafe static void StoreAlignedNonTemporal(byte* address, Vector128<byte> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x0010A260 File Offset: 0x00108460
		public unsafe static void StoreAlignedNonTemporal(short* address, Vector128<short> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x0010A269 File Offset: 0x00108469
		public unsafe static void StoreAlignedNonTemporal(ushort* address, Vector128<ushort> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x0010A272 File Offset: 0x00108472
		public unsafe static void StoreAlignedNonTemporal(int* address, Vector128<int> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x0010A27B File Offset: 0x0010847B
		public unsafe static void StoreAlignedNonTemporal(uint* address, Vector128<uint> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x0010A284 File Offset: 0x00108484
		public unsafe static void StoreAlignedNonTemporal(long* address, Vector128<long> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x0010A28D File Offset: 0x0010848D
		public unsafe static void StoreAlignedNonTemporal(ulong* address, Vector128<ulong> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x0010A296 File Offset: 0x00108496
		public unsafe static void StoreAlignedNonTemporal(double* address, Vector128<double> source)
		{
			Sse2.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x0010A29F File Offset: 0x0010849F
		public unsafe static void StoreHigh(double* address, Vector128<double> source)
		{
			Sse2.StoreHigh(address, source);
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x0010A2A8 File Offset: 0x001084A8
		public unsafe static void StoreLow(double* address, Vector128<double> source)
		{
			Sse2.StoreLow(address, source);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x0010A2B1 File Offset: 0x001084B1
		public unsafe static void StoreNonTemporal(int* address, int value)
		{
			Sse2.StoreNonTemporal(address, value);
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x0010A2BA File Offset: 0x001084BA
		public unsafe static void StoreNonTemporal(uint* address, uint value)
		{
			Sse2.StoreNonTemporal(address, value);
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x0010A2C3 File Offset: 0x001084C3
		public unsafe static void StoreScalar(int* address, Vector128<int> source)
		{
			Sse2.StoreScalar(address, source);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x0010A2CC File Offset: 0x001084CC
		public unsafe static void StoreScalar(uint* address, Vector128<uint> source)
		{
			Sse2.StoreScalar(address, source);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x0010A2D5 File Offset: 0x001084D5
		public unsafe static void StoreScalar(long* address, Vector128<long> source)
		{
			Sse2.StoreScalar(address, source);
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x0010A2DE File Offset: 0x001084DE
		public unsafe static void StoreScalar(ulong* address, Vector128<ulong> source)
		{
			Sse2.StoreScalar(address, source);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x0010A2E7 File Offset: 0x001084E7
		public unsafe static void StoreScalar(double* address, Vector128<double> source)
		{
			Sse2.StoreScalar(address, source);
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0010A2F0 File Offset: 0x001084F0
		public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x0010A2F9 File Offset: 0x001084F9
		public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x0010A302 File Offset: 0x00108502
		public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x0010A30B File Offset: 0x0010850B
		public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x0010A314 File Offset: 0x00108514
		public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x0010A31D File Offset: 0x0010851D
		public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x0010A326 File Offset: 0x00108526
		public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x0010A32F File Offset: 0x0010852F
		public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x0010A338 File Offset: 0x00108538
		public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Subtract(left, right);
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x0010A341 File Offset: 0x00108541
		public static Vector128<double> SubtractScalar(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.SubtractScalar(left, right);
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x0010A34A File Offset: 0x0010854A
		public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.SubtractSaturate(left, right);
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x0010A353 File Offset: 0x00108553
		public static Vector128<short> SubtractSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.SubtractSaturate(left, right);
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0010A35C File Offset: 0x0010855C
		public static Vector128<byte> SubtractSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.SubtractSaturate(left, right);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x0010A365 File Offset: 0x00108565
		public static Vector128<ushort> SubtractSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.SubtractSaturate(left, right);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x0010A36E File Offset: 0x0010856E
		public static Vector128<ushort> SumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.SumAbsoluteDifferences(left, right);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x0010A377 File Offset: 0x00108577
		public static Vector128<byte> UnpackHigh(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x0010A380 File Offset: 0x00108580
		public static Vector128<sbyte> UnpackHigh(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x0010A389 File Offset: 0x00108589
		public static Vector128<short> UnpackHigh(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x0010A392 File Offset: 0x00108592
		public static Vector128<ushort> UnpackHigh(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x0010A39B File Offset: 0x0010859B
		public static Vector128<int> UnpackHigh(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x0010A3A4 File Offset: 0x001085A4
		public static Vector128<uint> UnpackHigh(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x0010A3AD File Offset: 0x001085AD
		public static Vector128<long> UnpackHigh(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x0010A3B6 File Offset: 0x001085B6
		public static Vector128<ulong> UnpackHigh(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0010A3BF File Offset: 0x001085BF
		public static Vector128<double> UnpackHigh(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.UnpackHigh(left, right);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x0010A3C8 File Offset: 0x001085C8
		public static Vector128<byte> UnpackLow(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x0010A3D1 File Offset: 0x001085D1
		public static Vector128<sbyte> UnpackLow(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x0010A3DA File Offset: 0x001085DA
		public static Vector128<short> UnpackLow(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x0010A3E3 File Offset: 0x001085E3
		public static Vector128<ushort> UnpackLow(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x0010A3EC File Offset: 0x001085EC
		public static Vector128<int> UnpackLow(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x0010A3F5 File Offset: 0x001085F5
		public static Vector128<uint> UnpackLow(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x0010A3FE File Offset: 0x001085FE
		public static Vector128<long> UnpackLow(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x0010A407 File Offset: 0x00108607
		public static Vector128<ulong> UnpackLow(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x0010A410 File Offset: 0x00108610
		public static Vector128<double> UnpackLow(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.UnpackLow(left, right);
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x0010A419 File Offset: 0x00108619
		public static Vector128<byte> Xor(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x0010A422 File Offset: 0x00108622
		public static Vector128<sbyte> Xor(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x0010A42B File Offset: 0x0010862B
		public static Vector128<short> Xor(Vector128<short> left, Vector128<short> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x0010A434 File Offset: 0x00108634
		public static Vector128<ushort> Xor(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x0010A43D File Offset: 0x0010863D
		public static Vector128<int> Xor(Vector128<int> left, Vector128<int> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x0010A446 File Offset: 0x00108646
		public static Vector128<uint> Xor(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0010A44F File Offset: 0x0010864F
		public static Vector128<long> Xor(Vector128<long> left, Vector128<long> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x0010A458 File Offset: 0x00108658
		public static Vector128<ulong> Xor(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x0010A461 File Offset: 0x00108661
		public static Vector128<double> Xor(Vector128<double> left, Vector128<double> right)
		{
			return Sse2.Xor(left, right);
		}

		// Token: 0x02000593 RID: 1427
		[Intrinsic]
		public new abstract class X64 : Sse.X64
		{
			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06006DB4 RID: 28084 RVA: 0x0010A46A File Offset: 0x0010866A
			public new static bool IsSupported
			{
				get
				{
					return Sse2.X64.IsSupported;
				}
			}

			// Token: 0x06006DB5 RID: 28085 RVA: 0x0010A471 File Offset: 0x00108671
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, long value)
			{
				return Sse2.X64.ConvertScalarToVector128Double(upper, value);
			}

			// Token: 0x06006DB6 RID: 28086 RVA: 0x0010A47A File Offset: 0x0010867A
			public static Vector128<long> ConvertScalarToVector128Int64(long value)
			{
				return Sse2.X64.ConvertScalarToVector128Int64(value);
			}

			// Token: 0x06006DB7 RID: 28087 RVA: 0x0010A482 File Offset: 0x00108682
			public static Vector128<ulong> ConvertScalarToVector128UInt64(ulong value)
			{
				return Sse2.X64.ConvertScalarToVector128UInt64(value);
			}

			// Token: 0x06006DB8 RID: 28088 RVA: 0x0010A48A File Offset: 0x0010868A
			public static long ConvertToInt64(Vector128<long> value)
			{
				return Sse2.X64.ConvertToInt64(value);
			}

			// Token: 0x06006DB9 RID: 28089 RVA: 0x0010A492 File Offset: 0x00108692
			public static long ConvertToInt64(Vector128<double> value)
			{
				return Sse2.X64.ConvertToInt64(value);
			}

			// Token: 0x06006DBA RID: 28090 RVA: 0x0010A49A File Offset: 0x0010869A
			public static long ConvertToInt64WithTruncation(Vector128<double> value)
			{
				return Sse2.X64.ConvertToInt64WithTruncation(value);
			}

			// Token: 0x06006DBB RID: 28091 RVA: 0x0010A4A2 File Offset: 0x001086A2
			public static ulong ConvertToUInt64(Vector128<ulong> value)
			{
				return Sse2.X64.ConvertToUInt64(value);
			}

			// Token: 0x06006DBC RID: 28092 RVA: 0x0010A4AA File Offset: 0x001086AA
			public unsafe static void StoreNonTemporal(long* address, long value)
			{
				Sse2.X64.StoreNonTemporal(address, value);
			}

			// Token: 0x06006DBD RID: 28093 RVA: 0x0010A4B3 File Offset: 0x001086B3
			public unsafe static void StoreNonTemporal(ulong* address, ulong value)
			{
				Sse2.X64.StoreNonTemporal(address, value);
			}
		}
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000590 RID: 1424
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Sse : X86Base
	{
		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06006C2C RID: 27692 RVA: 0x001096ED File Offset: 0x001078ED
		public new static bool IsSupported
		{
			get
			{
				return Sse.IsSupported;
			}
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x001096F4 File Offset: 0x001078F4
		public static Vector128<float> Add(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Add(left, right);
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x001096FD File Offset: 0x001078FD
		public static Vector128<float> AddScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.AddScalar(left, right);
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x00109706 File Offset: 0x00107906
		public static Vector128<float> And(Vector128<float> left, Vector128<float> right)
		{
			return Sse.And(left, right);
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x0010970F File Offset: 0x0010790F
		public static Vector128<float> AndNot(Vector128<float> left, Vector128<float> right)
		{
			return Sse.AndNot(left, right);
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x00109718 File Offset: 0x00107918
		public static Vector128<float> CompareEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareEqual(left, right);
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x00109721 File Offset: 0x00107921
		public static Vector128<float> CompareGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareGreaterThan(left, right);
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x0010972A File Offset: 0x0010792A
		public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x00109733 File Offset: 0x00107933
		public static Vector128<float> CompareLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareLessThan(left, right);
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x0010973C File Offset: 0x0010793C
		public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareLessThanOrEqual(left, right);
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00109745 File Offset: 0x00107945
		public static Vector128<float> CompareNotEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareNotEqual(left, right);
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0010974E File Offset: 0x0010794E
		public static Vector128<float> CompareNotGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareNotGreaterThan(left, right);
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00109757 File Offset: 0x00107957
		public static Vector128<float> CompareNotGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareNotGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x00109760 File Offset: 0x00107960
		public static Vector128<float> CompareNotLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareNotLessThan(left, right);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00109769 File Offset: 0x00107969
		public static Vector128<float> CompareNotLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareNotLessThanOrEqual(left, right);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x00109772 File Offset: 0x00107972
		public static Vector128<float> CompareOrdered(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareOrdered(left, right);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x0010977B File Offset: 0x0010797B
		public static Vector128<float> CompareScalarEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarEqual(left, right);
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x00109784 File Offset: 0x00107984
		public static Vector128<float> CompareScalarGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarGreaterThan(left, right);
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x0010978D File Offset: 0x0010798D
		public static Vector128<float> CompareScalarGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00109796 File Offset: 0x00107996
		public static Vector128<float> CompareScalarLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarLessThan(left, right);
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x0010979F File Offset: 0x0010799F
		public static Vector128<float> CompareScalarLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarLessThanOrEqual(left, right);
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x001097A8 File Offset: 0x001079A8
		public static Vector128<float> CompareScalarNotEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarNotEqual(left, right);
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x001097B1 File Offset: 0x001079B1
		public static Vector128<float> CompareScalarNotGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarNotGreaterThan(left, right);
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x001097BA File Offset: 0x001079BA
		public static Vector128<float> CompareScalarNotGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarNotGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x001097C3 File Offset: 0x001079C3
		public static Vector128<float> CompareScalarNotLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarNotLessThan(left, right);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x001097CC File Offset: 0x001079CC
		public static Vector128<float> CompareScalarNotLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarNotLessThanOrEqual(left, right);
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x001097D5 File Offset: 0x001079D5
		public static Vector128<float> CompareScalarOrdered(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrdered(left, right);
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x001097DE File Offset: 0x001079DE
		public static bool CompareScalarOrderedEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedEqual(left, right);
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x001097E7 File Offset: 0x001079E7
		public static bool CompareScalarOrderedGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedGreaterThan(left, right);
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x001097F0 File Offset: 0x001079F0
		public static bool CompareScalarOrderedGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x001097F9 File Offset: 0x001079F9
		public static bool CompareScalarOrderedLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedLessThan(left, right);
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00109802 File Offset: 0x00107A02
		public static bool CompareScalarOrderedLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedLessThanOrEqual(left, right);
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x0010980B File Offset: 0x00107A0B
		public static bool CompareScalarOrderedNotEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarOrderedNotEqual(left, right);
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x00109814 File Offset: 0x00107A14
		public static Vector128<float> CompareScalarUnordered(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnordered(left, right);
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x0010981D File Offset: 0x00107A1D
		public static bool CompareScalarUnorderedEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedEqual(left, right);
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x00109826 File Offset: 0x00107A26
		public static bool CompareScalarUnorderedGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedGreaterThan(left, right);
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x0010982F File Offset: 0x00107A2F
		public static bool CompareScalarUnorderedGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedGreaterThanOrEqual(left, right);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x00109838 File Offset: 0x00107A38
		public static bool CompareScalarUnorderedLessThan(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedLessThan(left, right);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00109841 File Offset: 0x00107A41
		public static bool CompareScalarUnorderedLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedLessThanOrEqual(left, right);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x0010984A File Offset: 0x00107A4A
		public static bool CompareScalarUnorderedNotEqual(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareScalarUnorderedNotEqual(left, right);
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00109853 File Offset: 0x00107A53
		public static Vector128<float> CompareUnordered(Vector128<float> left, Vector128<float> right)
		{
			return Sse.CompareUnordered(left, right);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x0010985C File Offset: 0x00107A5C
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, int value)
		{
			return Sse.ConvertScalarToVector128Single(upper, value);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00109865 File Offset: 0x00107A65
		public static int ConvertToInt32(Vector128<float> value)
		{
			return Sse.ConvertToInt32(value);
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x0010986D File Offset: 0x00107A6D
		public static int ConvertToInt32WithTruncation(Vector128<float> value)
		{
			return Sse.ConvertToInt32WithTruncation(value);
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00109875 File Offset: 0x00107A75
		public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Divide(left, right);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x0010987E File Offset: 0x00107A7E
		public static Vector128<float> DivideScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.DivideScalar(left, right);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00109887 File Offset: 0x00107A87
		public unsafe static Vector128<float> LoadAlignedVector128(float* address)
		{
			return Sse.LoadAlignedVector128(address);
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x0010988F File Offset: 0x00107A8F
		public unsafe static Vector128<float> LoadHigh(Vector128<float> lower, float* address)
		{
			return Sse.LoadHigh(lower, address);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00109898 File Offset: 0x00107A98
		public unsafe static Vector128<float> LoadLow(Vector128<float> upper, float* address)
		{
			return Sse.LoadLow(upper, address);
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x001098A1 File Offset: 0x00107AA1
		public unsafe static Vector128<float> LoadScalarVector128(float* address)
		{
			return Sse.LoadScalarVector128(address);
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x001098A9 File Offset: 0x00107AA9
		public unsafe static Vector128<float> LoadVector128(float* address)
		{
			return Sse.LoadVector128(address);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x001098B1 File Offset: 0x00107AB1
		public static Vector128<float> Max(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Max(left, right);
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x001098BA File Offset: 0x00107ABA
		public static Vector128<float> MaxScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.MaxScalar(left, right);
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x001098C3 File Offset: 0x00107AC3
		public static Vector128<float> Min(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Min(left, right);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x001098CC File Offset: 0x00107ACC
		public static Vector128<float> MinScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.MinScalar(left, right);
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x001098D5 File Offset: 0x00107AD5
		public static Vector128<float> MoveHighToLow(Vector128<float> left, Vector128<float> right)
		{
			return Sse.MoveHighToLow(left, right);
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x001098DE File Offset: 0x00107ADE
		public static Vector128<float> MoveLowToHigh(Vector128<float> left, Vector128<float> right)
		{
			return Sse.MoveLowToHigh(left, right);
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x001098E7 File Offset: 0x00107AE7
		public static int MoveMask(Vector128<float> value)
		{
			return Sse.MoveMask(value);
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x001098EF File Offset: 0x00107AEF
		public static Vector128<float> MoveScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse.MoveScalar(upper, value);
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x001098F8 File Offset: 0x00107AF8
		public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Multiply(left, right);
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00109901 File Offset: 0x00107B01
		public static Vector128<float> MultiplyScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.MultiplyScalar(left, right);
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x0010990A File Offset: 0x00107B0A
		public static Vector128<float> Or(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Or(left, right);
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x00109913 File Offset: 0x00107B13
		public unsafe static void Prefetch0(void* address)
		{
			Sse.Prefetch0(address);
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x0010991B File Offset: 0x00107B1B
		public unsafe static void Prefetch1(void* address)
		{
			Sse.Prefetch1(address);
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00109923 File Offset: 0x00107B23
		public unsafe static void Prefetch2(void* address)
		{
			Sse.Prefetch2(address);
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x0010992B File Offset: 0x00107B2B
		public unsafe static void PrefetchNonTemporal(void* address)
		{
			Sse.PrefetchNonTemporal(address);
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x00109933 File Offset: 0x00107B33
		public static Vector128<float> Reciprocal(Vector128<float> value)
		{
			return Sse.Reciprocal(value);
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x0010993B File Offset: 0x00107B3B
		public static Vector128<float> ReciprocalScalar(Vector128<float> value)
		{
			return Sse.ReciprocalScalar(value);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x00109943 File Offset: 0x00107B43
		public static Vector128<float> ReciprocalScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse.ReciprocalScalar(upper, value);
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x0010994C File Offset: 0x00107B4C
		public static Vector128<float> ReciprocalSqrt(Vector128<float> value)
		{
			return Sse.ReciprocalSqrt(value);
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x00109954 File Offset: 0x00107B54
		public static Vector128<float> ReciprocalSqrtScalar(Vector128<float> value)
		{
			return Sse.ReciprocalSqrtScalar(value);
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x0010995C File Offset: 0x00107B5C
		public static Vector128<float> ReciprocalSqrtScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse.ReciprocalSqrtScalar(upper, value);
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x00109965 File Offset: 0x00107B65
		public static Vector128<float> Shuffle(Vector128<float> left, Vector128<float> right, [ConstantExpected] byte control)
		{
			return Sse.Shuffle(left, right, control);
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x0010996F File Offset: 0x00107B6F
		public static Vector128<float> Sqrt(Vector128<float> value)
		{
			return Sse.Sqrt(value);
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x00109977 File Offset: 0x00107B77
		public static Vector128<float> SqrtScalar(Vector128<float> value)
		{
			return Sse.SqrtScalar(value);
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x0010997F File Offset: 0x00107B7F
		public static Vector128<float> SqrtScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse.SqrtScalar(upper, value);
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00109988 File Offset: 0x00107B88
		public unsafe static void Store(float* address, Vector128<float> source)
		{
			Sse.Store(address, source);
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00109991 File Offset: 0x00107B91
		public unsafe static void StoreAligned(float* address, Vector128<float> source)
		{
			Sse.StoreAligned(address, source);
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x0010999A File Offset: 0x00107B9A
		public unsafe static void StoreAlignedNonTemporal(float* address, Vector128<float> source)
		{
			Sse.StoreAlignedNonTemporal(address, source);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x001099A3 File Offset: 0x00107BA3
		public static void StoreFence()
		{
			Sse.StoreFence();
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x001099AA File Offset: 0x00107BAA
		public unsafe static void StoreHigh(float* address, Vector128<float> source)
		{
			Sse.StoreHigh(address, source);
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x001099B3 File Offset: 0x00107BB3
		public unsafe static void StoreLow(float* address, Vector128<float> source)
		{
			Sse.StoreLow(address, source);
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x001099BC File Offset: 0x00107BBC
		public unsafe static void StoreScalar(float* address, Vector128<float> source)
		{
			Sse.StoreScalar(address, source);
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x001099C5 File Offset: 0x00107BC5
		public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Subtract(left, right);
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x001099CE File Offset: 0x00107BCE
		public static Vector128<float> SubtractScalar(Vector128<float> left, Vector128<float> right)
		{
			return Sse.SubtractScalar(left, right);
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x001099D7 File Offset: 0x00107BD7
		public static Vector128<float> UnpackHigh(Vector128<float> left, Vector128<float> right)
		{
			return Sse.UnpackHigh(left, right);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x001099E0 File Offset: 0x00107BE0
		public static Vector128<float> UnpackLow(Vector128<float> left, Vector128<float> right)
		{
			return Sse.UnpackLow(left, right);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x001099E9 File Offset: 0x00107BE9
		public static Vector128<float> Xor(Vector128<float> left, Vector128<float> right)
		{
			return Sse.Xor(left, right);
		}

		// Token: 0x02000591 RID: 1425
		[Intrinsic]
		public new abstract class X64 : X86Base.X64
		{
			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06006C84 RID: 27780 RVA: 0x001099F2 File Offset: 0x00107BF2
			public new static bool IsSupported
			{
				get
				{
					return Sse.X64.IsSupported;
				}
			}

			// Token: 0x06006C85 RID: 27781 RVA: 0x001099F9 File Offset: 0x00107BF9
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, long value)
			{
				return Sse.X64.ConvertScalarToVector128Single(upper, value);
			}

			// Token: 0x06006C86 RID: 27782 RVA: 0x00109A02 File Offset: 0x00107C02
			public static long ConvertToInt64(Vector128<float> value)
			{
				return Sse.X64.ConvertToInt64(value);
			}

			// Token: 0x06006C87 RID: 27783 RVA: 0x00109A0A File Offset: 0x00107C0A
			public static long ConvertToInt64WithTruncation(Vector128<float> value)
			{
				return Sse.X64.ConvertToInt64WithTruncation(value);
			}
		}
	}
}

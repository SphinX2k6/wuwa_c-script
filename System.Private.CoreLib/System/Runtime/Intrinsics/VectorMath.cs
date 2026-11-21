using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x0200054F RID: 1359
	internal static class VectorMath
	{
		// Token: 0x06005058 RID: 20568 RVA: 0x00104714 File Offset: 0x00102914
		public static TVectorDouble CosDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Abs(x);
			TVectorInt64 left = Unsafe.BitCast<TVectorDouble, TVectorInt64>(tvectorDouble);
			TVectorDouble tvectorDouble2;
			if (ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4605249457297304857L)))
			{
				TVectorDouble right = x * x;
				if (ISimdVector<TVectorInt64, long>.GreaterThanAny(left, ISimdVector<TVectorInt64, long>.Create(4548635623644200959L)))
				{
					tvectorDouble2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(VectorMath.CosDoublePoly<TVectorDouble>(x), right, ISimdVector<TVectorDouble, double>.Create(-0.5)), right, ISimdVector<TVectorDouble, double>.One);
				}
				else
				{
					tvectorDouble2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.5), right, ISimdVector<TVectorDouble, double>.One);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4707126720094797824L)))
				{
					return VectorMath.<CosDouble>g__ScalarFallback|0_0<TVectorDouble, TVectorInt64>(x);
				}
				ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(tvectorDouble);
				TVectorDouble item = valueTuple.Item1;
				TVectorDouble item2 = valueTuple.Item2;
				TVectorInt64 item3 = valueTuple.Item3;
				TVectorDouble right2 = VectorMath.SinDoubleLarge<TVectorDouble>(item, item2);
				TVectorDouble left2 = VectorMath.CosDoubleLarge<TVectorDouble>(item, item2);
				tvectorDouble2 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), left2, right2);
				tvectorDouble2 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 + ISimdVector<TVectorInt64, long>.One & ISimdVector<TVectorInt64, long>.Create(2L), ISimdVector<TVectorInt64, long>.Zero)), +tvectorDouble2, -tvectorDouble2);
			}
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.GreaterThan(left, ISimdVector<TVectorInt64, long>.Create(4485585228861014015L))), tvectorDouble2, ISimdVector<TVectorDouble, double>.One);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00104948 File Offset: 0x00102B48
		public static TVectorSingle CosSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorSingle tvectorSingle = ISimdVector<TVectorSingle, float>.Abs(x);
			TVectorInt32 left = Unsafe.BitCast<TVectorSingle, TVectorInt32>(tvectorSingle);
			TVectorSingle left2;
			if (ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1061752796)))
			{
				if (ISimdVector<TVectorInt32, int>.GreaterThanAny(left, ISimdVector<TVectorInt32, int>.Create(1006632959)))
				{
					if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
					{
						left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.CosSingleSmall<TVectorDouble>(VectorMath.Widen<TVectorSingle, TVectorDouble>(x)));
					}
					else
					{
						left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.CosSingleSmall<TVectorDouble>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x)), VectorMath.CosSingleSmall<TVectorDouble>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x)));
					}
				}
				else
				{
					TVectorSingle right = x * x;
					left2 = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(-0.5f), right, ISimdVector<TVectorSingle, float>.One);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1251513984)))
				{
					return VectorMath.<CosSingle>g__ScalarFallback|1_1<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(x);
				}
				if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
				{
					left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<CosSingle>g__CoreImpl|1_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.Widen<TVectorSingle, TVectorDouble>(tvectorSingle)));
				}
				else
				{
					left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<CosSingle>g__CoreImpl|1_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(tvectorSingle)), VectorMath.<CosSingle>g__CoreImpl|1_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(tvectorSingle)));
				}
			}
			return ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorInt32, TVectorSingle>(ISimdVector<TVectorInt32, int>.GreaterThan(left, ISimdVector<TVectorInt32, int>.Create(956301311))), left2, ISimdVector<TVectorSingle, float>.One);
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00104AD8 File Offset: 0x00102CD8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector CopySign<[IsUnmanaged] TVector, T>(TVector value, TVector sign) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(VectorMath.Create<TVector, T>(--0f), sign, value);
			}
			if (typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(VectorMath.Create<TVector, T>(--0.0), sign, value);
			}
			return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.IsNegative(value ^ sign), -value, value);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00104B80 File Offset: 0x00102D80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector DegreesToRadians<[IsUnmanaged] TVector, T>(TVector degrees) where TVector : struct, ValueType, ISimdVector<TVector, T> where T : IFloatingPointIeee754<T>
		{
			return degrees * ISimdVector<TVector, T>.Create(IFloatingPointConstants<T>.Pi) / ISimdVector<TVector, T>.Create(INumberBase<T>.CreateTruncating<int>(180));
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00104BD8 File Offset: 0x00102DD8
		public static TVectorDouble ExpDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorUInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			if (ISimdVector<TVectorUInt64, ulong>.LessThanOrEqualAll(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(ISimdVector<TVectorDouble, double>.Abs(x)), ISimdVector<TVectorUInt64, ulong>.Create(4649438849678704640UL)))
			{
				TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(x, ISimdVector<TVectorDouble, double>.Create(1.4426950408889634), ISimdVector<TVectorDouble, double>.Create(6755399441055744.0));
				TVectorUInt64 left = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble);
				TVectorDouble left2 = tvectorDouble - ISimdVector<TVectorDouble, double>.Create(6755399441055744.0);
				TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left2, ISimdVector<TVectorDouble, double>.Create(-0.693359375), x);
				tvectorDouble2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left2, ISimdVector<TVectorDouble, double>.Create(0.00021219444005469057), tvectorDouble2);
				TVectorDouble tvectorDouble3 = tvectorDouble2 * tvectorDouble2;
				TVectorDouble tvectorDouble4 = tvectorDouble3 * tvectorDouble3;
				TVectorDouble right = tvectorDouble4 * tvectorDouble4;
				return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(2.499430431958571E-08), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(2.7632293298250954E-07)), tvectorDouble3, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(2.7557622532543023E-06), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(2.4801486521374483E-05))), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.00019841269432677495), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(0.001388888895122404)), tvectorDouble3, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.008333333333559272), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(0.04166666666649277))), tvectorDouble4, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.1666666666666617), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(0.5000000000000018)), tvectorDouble3, tvectorDouble2 + ISimdVector<TVectorDouble, double>.One))) * Unsafe.BitCast<TVectorUInt64, TVectorDouble>(left + ISimdVector<TVectorUInt64, ulong>.Create(1023UL) << 52);
			}
			return VectorMath.<ExpDouble>g__ScalarFallback|4_0<TVectorDouble, TVectorUInt64>(x);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00104E7C File Offset: 0x0010307C
		public static TVectorSingle ExpSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorUInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorUInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorUInt32 : struct, ValueType, ISimdVector<TVectorUInt32, uint> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorSingle tvectorSingle;
			if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
			{
				tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<ExpSingle>g__CoreImpl|5_0<TVectorSingle, TVectorUInt32, TVectorDouble, TVectorUInt64>(VectorMath.Widen<TVectorSingle, TVectorDouble>(x)));
			}
			else
			{
				tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<ExpSingle>g__CoreImpl|5_0<TVectorSingle, TVectorUInt32, TVectorDouble, TVectorUInt64>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x)), VectorMath.<ExpSingle>g__CoreImpl|5_0<TVectorSingle, TVectorUInt32, TVectorDouble, TVectorUInt64>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x)));
			}
			if (ISimdVector<TVectorUInt32, uint>.GreaterThanAny(Unsafe.BitCast<TVectorSingle, TVectorUInt32>(ISimdVector<TVectorSingle, float>.Abs(x)), ISimdVector<TVectorUInt32, uint>.Create(1118699520U)))
			{
				tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(ISimdVector<TVectorSingle, float>.GreaterThan(x, ISimdVector<TVectorSingle, float>.Create(88.72284f)), ISimdVector<TVectorSingle, float>.Create(float.PositiveInfinity), tvectorSingle);
				tvectorSingle = ISimdVector<TVectorSingle, float>.AndNot(tvectorSingle, ISimdVector<TVectorSingle, float>.LessThan(x, ISimdVector<TVectorSingle, float>.Create(-103.97208f)));
			}
			return tvectorSingle;
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00104F64 File Offset: 0x00103164
		public static TVectorDouble HypotDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorUInt64>(TVectorDouble x, TVectorDouble y) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Abs(x);
			TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.Abs(y);
			TVectorDouble condition = ISimdVector<TVectorDouble, double>.IsPositiveInfinity(tvectorDouble) | ISimdVector<TVectorDouble, double>.IsPositiveInfinity(tvectorDouble2);
			TVectorDouble condition2 = ISimdVector<TVectorDouble, double>.IsNaN(tvectorDouble) | ISimdVector<TVectorDouble, double>.IsNaN(tvectorDouble2);
			TVectorUInt64 tvectorUInt = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble);
			TVectorUInt64 tvectorUInt2 = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble2);
			TVectorUInt64 right = ISimdVector<TVectorUInt64, ulong>.Create(2047UL);
			TVectorUInt64 tvectorUInt3 = tvectorUInt >> 52 & right;
			TVectorUInt64 tvectorUInt4 = tvectorUInt2 >> 52 & right;
			TVectorUInt64 tvectorUInt5 = tvectorUInt3 - tvectorUInt4;
			TVectorDouble condition3 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(ISimdVector<TVectorUInt64, ulong>.GreaterThanOrEqual(tvectorUInt5, ISimdVector<TVectorUInt64, ulong>.Create(54UL)) & ISimdVector<TVectorUInt64, ulong>.LessThanOrEqual(tvectorUInt5, ISimdVector<TVectorUInt64, ulong>.Create(18446744073709551562UL)));
			TVectorDouble left = tvectorDouble + tvectorDouble2;
			TVectorUInt64 right2 = ISimdVector<TVectorUInt64, ulong>.Create(1523UL);
			TVectorUInt64 tvectorUInt6 = ISimdVector<TVectorUInt64, ulong>.GreaterThan(tvectorUInt3, right2) | ISimdVector<TVectorUInt64, ulong>.GreaterThan(tvectorUInt4, right2);
			TVectorDouble right3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt6), ISimdVector<TVectorDouble, double>.Create(4.149515568880993E+180), ISimdVector<TVectorDouble, double>.One);
			TVectorUInt64 right4 = tvectorUInt6 & ISimdVector<TVectorUInt64, ulong>.Create(15744584297287254016UL);
			TVectorUInt64 right5 = ISimdVector<TVectorUInt64, ulong>.Create(523UL);
			TVectorUInt64 tvectorUInt7 = ISimdVector<TVectorUInt64, ulong>.AndNot(ISimdVector<TVectorUInt64, ulong>.LessThan(tvectorUInt3, right5) | ISimdVector<TVectorUInt64, ulong>.LessThan(tvectorUInt4, right5), tvectorUInt6);
			right3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt7), ISimdVector<TVectorDouble, double>.Create(2.409919865102884E-181), right3);
			right4 = ISimdVector<TVectorUInt64, ulong>.ConditionalSelect(tvectorUInt7, ISimdVector<TVectorUInt64, ulong>.Create(2702159776422297600UL), right4);
			tvectorUInt += right4;
			tvectorUInt2 += right4;
			TVectorDouble left2 = ISimdVector<TVectorDouble, double>.Create(9.232978617785736E-128);
			TVectorUInt64 left3 = ISimdVector<TVectorUInt64, ulong>.Create(4503599627370496UL);
			TVectorUInt64 tvectorUInt8 = ISimdVector<TVectorUInt64, ulong>.IsZero(tvectorUInt3) & tvectorUInt7;
			tvectorUInt += (left3 & tvectorUInt8);
			tvectorDouble = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt);
			tvectorDouble -= (left2 & Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt8));
			TVectorUInt64 tvectorUInt9 = ISimdVector<TVectorUInt64, ulong>.IsZero(tvectorUInt4) & tvectorUInt7;
			tvectorUInt2 += (left3 & tvectorUInt9);
			tvectorDouble2 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt2);
			tvectorDouble2 -= (left2 & Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt9));
			tvectorUInt = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble);
			tvectorUInt2 = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble2);
			TVectorDouble tvectorDouble3 = ISimdVector<TVectorDouble, double>.LessThan(tvectorDouble, tvectorDouble2);
			TVectorDouble left4 = tvectorDouble;
			tvectorDouble = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble3, tvectorDouble2, tvectorDouble);
			tvectorDouble2 = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble3, left4, tvectorDouble2);
			TVectorUInt64 left5 = tvectorUInt;
			tvectorUInt = ISimdVector<TVectorUInt64, ulong>.ConditionalSelect(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble3), tvectorUInt2, tvectorUInt);
			tvectorUInt2 = ISimdVector<TVectorUInt64, ulong>.ConditionalSelect(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble3), left5, tvectorUInt2);
			TVectorUInt64 right6 = ISimdVector<TVectorUInt64, ulong>.Create(18446744073575333888UL);
			TVectorDouble tvectorDouble4 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt & right6);
			TVectorDouble tvectorDouble5 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt2 & right6);
			TVectorDouble tvectorDouble6 = tvectorDouble - tvectorDouble4;
			TVectorDouble tvectorDouble7 = tvectorDouble2 - tvectorDouble5;
			TVectorDouble tvectorDouble8 = tvectorDouble * tvectorDouble;
			TVectorDouble tvectorDouble9 = tvectorDouble2 * tvectorDouble2;
			TVectorDouble tvectorDouble10 = tvectorDouble8 + tvectorDouble9;
			TVectorDouble tvectorDouble11 = tvectorDouble8 - tvectorDouble10 + tvectorDouble9;
			tvectorDouble11 += ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble4, tvectorDouble4, -tvectorDouble8);
			tvectorDouble11 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble4 * 2.0, tvectorDouble6, tvectorDouble11);
			tvectorDouble11 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble6, tvectorDouble6, tvectorDouble11);
			TVectorDouble condition4 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>(ISimdVector<TVectorUInt64, ulong>.IsZero(tvectorUInt5));
			TVectorDouble tvectorDouble12 = tvectorDouble11;
			tvectorDouble12 += ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble5, tvectorDouble5, -tvectorDouble9);
			tvectorDouble12 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble5 * 2.0, tvectorDouble7, tvectorDouble12);
			tvectorDouble12 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble7, tvectorDouble7, tvectorDouble12);
			tvectorDouble11 = ISimdVector<TVectorDouble, double>.ConditionalSelect(condition4, tvectorDouble12, tvectorDouble11);
			TVectorDouble right7 = ISimdVector<TVectorDouble, double>.Sqrt(tvectorDouble10 + tvectorDouble11) * right3;
			right7 = ISimdVector<TVectorDouble, double>.ConditionalSelect(condition3, left, right7);
			right7 = ISimdVector<TVectorDouble, double>.ConditionalSelect(condition2, ISimdVector<TVectorDouble, double>.Create(double.NaN), right7);
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(condition, ISimdVector<TVectorDouble, double>.Create(double.PositiveInfinity), right7);
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x0010554C File Offset: 0x0010374C
		public static TVectorSingle HypotSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorDouble>(TVectorSingle x, TVectorSingle y) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorSingle vector = ISimdVector<TVectorSingle, float>.Abs(x);
			TVectorSingle vector2 = ISimdVector<TVectorSingle, float>.Abs(y);
			TVectorSingle condition = ISimdVector<TVectorSingle, float>.IsPositiveInfinity(vector) | ISimdVector<TVectorSingle, float>.IsPositiveInfinity(vector2);
			TVectorSingle condition2 = ISimdVector<TVectorSingle, float>.IsNaN(vector) | ISimdVector<TVectorSingle, float>.IsNaN(vector2);
			TVectorSingle right;
			if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
			{
				right = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<HypotSingle>g__CoreImpl|7_0<TVectorSingle, TVectorDouble>(VectorMath.Widen<TVectorSingle, TVectorDouble>(vector), VectorMath.Widen<TVectorSingle, TVectorDouble>(vector2)));
			}
			else
			{
				right = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<HypotSingle>g__CoreImpl|7_0<TVectorSingle, TVectorDouble>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(vector), VectorMath.WidenLower<TVectorSingle, TVectorDouble>(vector2)), VectorMath.<HypotSingle>g__CoreImpl|7_0<TVectorSingle, TVectorDouble>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(vector), VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(vector2)));
			}
			right = ISimdVector<TVectorSingle, float>.ConditionalSelect(condition2, ISimdVector<TVectorSingle, float>.Create(float.NaN), right);
			return ISimdVector<TVectorSingle, float>.ConditionalSelect(condition, ISimdVector<TVectorSingle, float>.Create(float.PositiveInfinity), right);
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x0010564D File Offset: 0x0010384D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector Lerp<[IsUnmanaged] TVector, T>(TVector x, TVector y, TVector amount) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			return ISimdVector<TVector, T>.MultiplyAddEstimate(x, ISimdVector<TVector, T>.One - amount, y * amount);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00105680 File Offset: 0x00103880
		public static TVectorDouble LogDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64, [IsUnmanaged] TVectorUInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorDouble tvectorDouble = x;
			TVectorUInt64 tvectorUInt = ISimdVector<TVectorUInt64, ulong>.GreaterThanOrEqual(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x) - ISimdVector<TVectorUInt64, ulong>.Create(4503599627370496UL), ISimdVector<TVectorUInt64, ulong>.Create(9214364837600034816UL));
			if (tvectorUInt != ISimdVector<TVectorUInt64, ulong>.Zero)
			{
				TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.IsNegative(x);
				tvectorDouble = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(double.NaN), tvectorDouble);
				TVectorDouble tvectorDouble3 = ISimdVector<TVectorDouble, double>.IsZero(x);
				tvectorDouble = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble3, ISimdVector<TVectorDouble, double>.Create(double.NegativeInfinity), tvectorDouble);
				TVectorDouble tvectorDouble4 = tvectorDouble3 | tvectorDouble2 | ISimdVector<TVectorDouble, double>.IsNaN(x) | ISimdVector<TVectorDouble, double>.IsPositiveInfinity(x);
				x = ISimdVector<TVectorDouble, double>.ConditionalSelect(ISimdVector<TVectorDouble, double>.AndNot(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt), tvectorDouble4), Unsafe.BitCast<TVectorUInt64, TVectorDouble>(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x * 4503599627370496.0) - ISimdVector<TVectorUInt64, ulong>.Create(234187180623265792UL)), x);
				tvectorUInt = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble4);
			}
			TVectorUInt64 tvectorUInt2 = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x) - ISimdVector<TVectorUInt64, ulong>.Create(4604180019048437077UL);
			TVectorDouble left = VectorMath.ConvertToDouble<TVectorInt64, TVectorDouble>(Unsafe.BitCast<TVectorUInt64, TVectorInt64>(tvectorUInt2) >> 52);
			TVectorDouble tvectorDouble5 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>((tvectorUInt2 & ISimdVector<TVectorUInt64, ulong>.Create(4503599627370495UL)) + ISimdVector<TVectorUInt64, ulong>.Create(4604180019048437077UL)) - ISimdVector<TVectorDouble, double>.One;
			TVectorDouble tvectorDouble6 = tvectorDouble5 * tvectorDouble5;
			TVectorDouble tvectorDouble7 = tvectorDouble6 * tvectorDouble6;
			TVectorDouble tvectorDouble8 = tvectorDouble7 * tvectorDouble7;
			TVectorDouble addend = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble8 * tvectorDouble8, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.08690617411690876), tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.08897063600357775), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.04537017099489198)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.049370587082412105), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.06399503509896004)))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble8, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.06796346521153573), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.07129671894628731)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.0768176033283113), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.08334060052755186))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.09091434982346239), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.09999975049550124)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.11111095235715944), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.12500000512783127)))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.1428571456002771), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.1666666666089195)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.19999999997598522), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.25000000000029743))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.33333333333341475), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.49999999999999956)), tvectorDouble6, tvectorDouble5))));
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt), tvectorDouble, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left, ISimdVector<TVectorDouble, double>.Create(0.693359375), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left, ISimdVector<TVectorDouble, double>.Create(-0.00021219444005469057), addend)));
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00105B8C File Offset: 0x00103D8C
		public static TVectorSingle LogSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorUInt32>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorUInt32 : struct, ValueType, ISimdVector<TVectorUInt32, uint>
		{
			TVectorSingle tvectorSingle = x;
			TVectorUInt32 tvectorUInt = ISimdVector<TVectorUInt32, uint>.GreaterThanOrEqual(Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x) - ISimdVector<TVectorUInt32, uint>.Create(8388608U), ISimdVector<TVectorUInt32, uint>.Create(2130706432U));
			if (tvectorUInt != ISimdVector<TVectorUInt32, uint>.Zero)
			{
				TVectorSingle tvectorSingle2 = ISimdVector<TVectorSingle, float>.IsNegative(x);
				tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(tvectorSingle2, ISimdVector<TVectorSingle, float>.Create(float.NaN), tvectorSingle);
				TVectorSingle tvectorSingle3 = ISimdVector<TVectorSingle, float>.IsZero(x);
				tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(tvectorSingle3, ISimdVector<TVectorSingle, float>.Create(float.NegativeInfinity), tvectorSingle);
				TVectorSingle tvectorSingle4 = tvectorSingle3 | tvectorSingle2 | ISimdVector<TVectorSingle, float>.IsNaN(x) | ISimdVector<TVectorSingle, float>.IsPositiveInfinity(x);
				x = ISimdVector<TVectorSingle, float>.ConditionalSelect(ISimdVector<TVectorSingle, float>.AndNot(Unsafe.BitCast<TVectorUInt32, TVectorSingle>(tvectorUInt), tvectorSingle4), Unsafe.BitCast<TVectorUInt32, TVectorSingle>(Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x * 8388608f) - ISimdVector<TVectorUInt32, uint>.Create(192937984U)), x);
				tvectorUInt = Unsafe.BitCast<TVectorSingle, TVectorUInt32>(tvectorSingle4);
			}
			TVectorUInt32 tvectorUInt2 = Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x) - ISimdVector<TVectorUInt32, uint>.Create(1059760811U);
			TVectorSingle left = VectorMath.ConvertToSingle<TVectorInt32, TVectorSingle>(Unsafe.BitCast<TVectorUInt32, TVectorInt32>(tvectorUInt2) >> 23);
			TVectorSingle tvectorSingle5 = Unsafe.BitCast<TVectorUInt32, TVectorSingle>((tvectorUInt2 & ISimdVector<TVectorUInt32, uint>.Create(8388607U)) + ISimdVector<TVectorUInt32, uint>.Create(1059760811U)) - ISimdVector<TVectorSingle, float>.Create(1f);
			TVectorSingle tvectorSingle6 = tvectorSingle5 * tvectorSingle5;
			TVectorSingle tvectorSingle7 = tvectorSingle6 * tvectorSingle6;
			TVectorSingle right = tvectorSingle7 * tvectorSingle7;
			TVectorSingle addend = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(tvectorSingle6, ISimdVector<TVectorSingle, float>.Create(-0.13657966f), ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.14401625f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.1197452f))), right, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.13902695f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.16700386f)), tvectorSingle6, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.20018855f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.24999046f))), tvectorSingle7, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.33332965f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.5000001f)), tvectorSingle6, tvectorSingle5)));
			return ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorUInt32, TVectorSingle>(tvectorUInt), tvectorSingle, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(left, ISimdVector<TVectorSingle, float>.Create(0.6931472f), addend));
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00105EE0 File Offset: 0x001040E0
		public static TVectorDouble Log2Double<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64, [IsUnmanaged] TVectorUInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorDouble tvectorDouble = x;
			TVectorUInt64 tvectorUInt = ISimdVector<TVectorUInt64, ulong>.GreaterThanOrEqual(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x) - ISimdVector<TVectorUInt64, ulong>.Create(4503599627370496UL), ISimdVector<TVectorUInt64, ulong>.Create(9214364837600034816UL));
			if (tvectorUInt != ISimdVector<TVectorUInt64, ulong>.Zero)
			{
				TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.IsNegative(x);
				tvectorDouble = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(double.NaN), tvectorDouble);
				TVectorDouble tvectorDouble3 = ISimdVector<TVectorDouble, double>.IsZero(x);
				tvectorDouble = ISimdVector<TVectorDouble, double>.ConditionalSelect(tvectorDouble3, ISimdVector<TVectorDouble, double>.Create(double.NegativeInfinity), tvectorDouble);
				TVectorDouble tvectorDouble4 = tvectorDouble3 | tvectorDouble2 | ISimdVector<TVectorDouble, double>.IsNaN(x) | ISimdVector<TVectorDouble, double>.IsPositiveInfinity(x);
				x = ISimdVector<TVectorDouble, double>.ConditionalSelect(ISimdVector<TVectorDouble, double>.AndNot(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt), tvectorDouble4), Unsafe.BitCast<TVectorUInt64, TVectorDouble>(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x * 4503599627370496.0) - ISimdVector<TVectorUInt64, ulong>.Create(234187180623265792UL)), x);
				tvectorUInt = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble4);
			}
			TVectorUInt64 tvectorUInt2 = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(x) - ISimdVector<TVectorUInt64, ulong>.Create(4604180019048437077UL);
			TVectorDouble addend = VectorMath.ConvertToDouble<TVectorInt64, TVectorDouble>(Unsafe.BitCast<TVectorUInt64, TVectorInt64>(tvectorUInt2) >> 52);
			TVectorDouble tvectorDouble5 = Unsafe.BitCast<TVectorUInt64, TVectorDouble>((tvectorUInt2 & ISimdVector<TVectorUInt64, ulong>.Create(4503599627370495UL)) + ISimdVector<TVectorUInt64, ulong>.Create(4604180019048437077UL)) - ISimdVector<TVectorDouble, double>.One;
			TVectorDouble tvectorDouble6 = tvectorDouble5 * tvectorDouble5;
			TVectorDouble tvectorDouble7 = tvectorDouble6 * tvectorDouble6;
			TVectorDouble tvectorDouble8 = tvectorDouble7 * tvectorDouble7;
			TVectorDouble left = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble8 * tvectorDouble8, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.08690617411690876), tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.08897063600357775), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.04537017099489198)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.049370587082412105), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.06399503509896004)))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble8, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.06796346521153573), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.07129671894628731)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.0768176033283113), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.08334060052755186))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.09091434982346239), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.09999975049550124)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.11111095235715944), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.12500000512783127)))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble7, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.1428571456002771), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.1666666666089195)), tvectorDouble6, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.19999999997598522), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.25000000000029743))), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.33333333333341475), tvectorDouble5, ISimdVector<TVectorDouble, double>.Create(-0.49999999999999956)), tvectorDouble6, tvectorDouble5))));
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorUInt64, TVectorDouble>(tvectorUInt), tvectorDouble, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left, ISimdVector<TVectorDouble, double>.Create(1.4426918029785156), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(left, ISimdVector<TVectorDouble, double>.Create(3.2379104477823597E-06), addend)));
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x001063EC File Offset: 0x001045EC
		public static TVectorSingle Log2Single<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorUInt32>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorUInt32 : struct, ValueType, ISimdVector<TVectorUInt32, uint>
		{
			TVectorSingle tvectorSingle = x;
			TVectorUInt32 tvectorUInt = ISimdVector<TVectorUInt32, uint>.GreaterThanOrEqual(Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x) - ISimdVector<TVectorUInt32, uint>.Create(8388608U), ISimdVector<TVectorUInt32, uint>.Create(2130706432U));
			if (tvectorUInt != ISimdVector<TVectorUInt32, uint>.Zero)
			{
				TVectorSingle tvectorSingle2 = ISimdVector<TVectorSingle, float>.IsNegative(x);
				tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(tvectorSingle2, ISimdVector<TVectorSingle, float>.Create(float.NaN), tvectorSingle);
				TVectorSingle tvectorSingle3 = ISimdVector<TVectorSingle, float>.IsZero(x);
				tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(tvectorSingle3, ISimdVector<TVectorSingle, float>.Create(float.NegativeInfinity), tvectorSingle);
				TVectorSingle tvectorSingle4 = tvectorSingle3 | tvectorSingle2 | ISimdVector<TVectorSingle, float>.IsNaN(x) | ISimdVector<TVectorSingle, float>.IsPositiveInfinity(x);
				x = ISimdVector<TVectorSingle, float>.ConditionalSelect(ISimdVector<TVectorSingle, float>.AndNot(Unsafe.BitCast<TVectorUInt32, TVectorSingle>(tvectorUInt), tvectorSingle4), Unsafe.BitCast<TVectorUInt32, TVectorSingle>(Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x * 8388608f) - ISimdVector<TVectorUInt32, uint>.Create(192937984U)), x);
				tvectorUInt = Unsafe.BitCast<TVectorSingle, TVectorUInt32>(tvectorSingle4);
			}
			TVectorUInt32 tvectorUInt2 = Unsafe.BitCast<TVectorSingle, TVectorUInt32>(x) - ISimdVector<TVectorUInt32, uint>.Create(1059760811U);
			TVectorSingle left = VectorMath.ConvertToSingle<TVectorInt32, TVectorSingle>(Unsafe.BitCast<TVectorUInt32, TVectorInt32>(tvectorUInt2) >> 23);
			TVectorSingle tvectorSingle5 = Unsafe.BitCast<TVectorUInt32, TVectorSingle>((tvectorUInt2 & ISimdVector<TVectorUInt32, uint>.Create(8388607U)) + ISimdVector<TVectorUInt32, uint>.Create(1059760811U)) - ISimdVector<TVectorSingle, float>.One;
			TVectorSingle tvectorSingle6 = tvectorSingle5 * tvectorSingle5;
			TVectorSingle tvectorSingle7 = tvectorSingle6 * tvectorSingle6;
			TVectorSingle right = tvectorSingle7 * tvectorSingle7;
			TVectorSingle right2 = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.21228963f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.22616665f)), right, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.19948183f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.23594281f)), tvectorSingle6, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.2888971f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.36084408f))), tvectorSingle7, ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(0.48089063f), tvectorSingle5, ISimdVector<TVectorSingle, float>.Create(-0.72134554f)), tvectorSingle6, ISimdVector<TVectorSingle, float>.Create(1.4426951f) * tvectorSingle5)));
			return ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorUInt32, TVectorSingle>(tvectorUInt), tvectorSingle, left + right2);
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00106728 File Offset: 0x00104928
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector Max<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(y, x) | ISimdVector<TVector, T>.IsNaN(x) | (ISimdVector<TVector, T>.Equals(x, y) & ISimdVector<TVector, T>.IsNegative(y)), x, y);
			}
			return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.GreaterThan(x, y), x, y);
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x001067E8 File Offset: 0x001049E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MaxMagnitude<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				TVector tvector = ISimdVector<TVector, T>.Abs(x);
				TVector right = ISimdVector<TVector, T>.Abs(y);
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.GreaterThan(tvector, right) | ISimdVector<TVector, T>.IsNaN(tvector) | (ISimdVector<TVector, T>.Equals(tvector, right) & ISimdVector<TVector, T>.IsPositive(x)), x, y);
			}
			return VectorMath.MaxMagnitudeNumber<TVector, T>(x, y);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x001068B0 File Offset: 0x00104AB0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MaxMagnitudeNumber<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return ISimdVector<TVector, T>.Max(x, y);
			}
			TVector tvector = ISimdVector<TVector, T>.Abs(x);
			TVector tvector2 = ISimdVector<TVector, T>.Abs(y);
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.GreaterThan(tvector, tvector2) | ISimdVector<TVector, T>.IsNaN(tvector2) | (ISimdVector<TVector, T>.Equals(tvector, tvector2) & ISimdVector<TVector, T>.IsPositive(x)), x, y);
			}
			return ISimdVector<TVector, T>.ConditionalSelect((ISimdVector<TVector, T>.GreaterThan(tvector, tvector2) & ISimdVector<TVector, T>.IsPositive(tvector2)) | (ISimdVector<TVector, T>.Equals(tvector, tvector2) & ISimdVector<TVector, T>.IsNegative(y)) | ISimdVector<TVector, T>.IsNegative(tvector), x, y);
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x00106A7C File Offset: 0x00104C7C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MaxNumber<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(y, x) | ISimdVector<TVector, T>.IsNaN(y) | (ISimdVector<TVector, T>.Equals(x, y) & ISimdVector<TVector, T>.IsNegative(y)), x, y);
			}
			return ISimdVector<TVector, T>.Max(x, y);
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00106B30 File Offset: 0x00104D30
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector Min<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(x, y) | ISimdVector<TVector, T>.IsNaN(x) | (ISimdVector<TVector, T>.Equals(x, y) & ISimdVector<TVector, T>.IsNegative(x)), x, y);
			}
			return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(x, y), x, y);
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00106BF0 File Offset: 0x00104DF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MinMagnitude<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				TVector tvector = ISimdVector<TVector, T>.Abs(x);
				TVector right = ISimdVector<TVector, T>.Abs(y);
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(tvector, right) | ISimdVector<TVector, T>.IsNaN(tvector) | (ISimdVector<TVector, T>.Equals(tvector, right) & ISimdVector<TVector, T>.IsNegative(x)), x, y);
			}
			return VectorMath.MinMagnitudeNumber<TVector, T>(x, y);
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00106CB8 File Offset: 0x00104EB8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MinMagnitudeNumber<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return ISimdVector<TVector, T>.Min(x, y);
			}
			TVector tvector = ISimdVector<TVector, T>.Abs(x);
			TVector tvector2 = ISimdVector<TVector, T>.Abs(y);
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(tvector, tvector2) | ISimdVector<TVector, T>.IsNaN(tvector2) | (ISimdVector<TVector, T>.Equals(tvector, tvector2) & ISimdVector<TVector, T>.IsNegative(x)), x, y);
			}
			return ISimdVector<TVector, T>.ConditionalSelect((ISimdVector<TVector, T>.LessThan(tvector, tvector2) & ISimdVector<TVector, T>.IsPositive(tvector)) | (ISimdVector<TVector, T>.Equals(tvector, tvector2) & ISimdVector<TVector, T>.IsNegative(x)) | ISimdVector<TVector, T>.IsNegative(tvector2), x, y);
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00106E84 File Offset: 0x00105084
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector MinNumber<[IsUnmanaged] TVector, T>(TVector x, TVector y) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ISimdVector<TVector, T>.ConditionalSelect(ISimdVector<TVector, T>.LessThan(x, y) | ISimdVector<TVector, T>.IsNaN(y) | (ISimdVector<TVector, T>.Equals(x, y) & ISimdVector<TVector, T>.IsNegative(x)), x, y);
			}
			return ISimdVector<TVector, T>.Min(x, y);
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00106F38 File Offset: 0x00105138
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TVector RadiansToDegrees<[IsUnmanaged] TVector, T>(TVector radians) where TVector : struct, ValueType, ISimdVector<TVector, T> where T : IFloatingPointIeee754<T>
		{
			return radians * ISimdVector<TVector, T>.Create(INumberBase<T>.CreateTruncating<int>(180)) / ISimdVector<TVector, T>.Create(IFloatingPointConstants<T>.Pi);
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00106F90 File Offset: 0x00105190
		public static TVectorDouble RoundDouble<[IsUnmanaged] TVectorDouble>(TVectorDouble vector, MidpointRounding mode) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			switch (mode)
			{
			case MidpointRounding.ToEven:
				return ISimdVector<TVectorDouble, double>.Round(vector);
			case MidpointRounding.AwayFromZero:
				return ISimdVector<TVectorDouble, double>.Truncate(vector + VectorMath.CopySign<TVectorDouble, double>(ISimdVector<TVectorDouble, double>.Create(0.49999999999999994), vector));
			case MidpointRounding.ToZero:
				return ISimdVector<TVectorDouble, double>.Truncate(vector);
			case MidpointRounding.ToNegativeInfinity:
				return ISimdVector<TVectorDouble, double>.Floor(vector);
			case MidpointRounding.ToPositiveInfinity:
				return ISimdVector<TVectorDouble, double>.Ceiling(vector);
			default:
				ThrowHelper.ThrowArgumentException_InvalidEnumValue<MidpointRounding>(mode, "mode");
				return default(TVectorDouble);
			}
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00107034 File Offset: 0x00105234
		public static TVectorSingle RoundSingle<[IsUnmanaged] TVectorSingle>(TVectorSingle vector, MidpointRounding mode) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float>
		{
			switch (mode)
			{
			case MidpointRounding.ToEven:
				return ISimdVector<TVectorSingle, float>.Round(vector);
			case MidpointRounding.AwayFromZero:
				return ISimdVector<TVectorSingle, float>.Truncate(vector + VectorMath.CopySign<TVectorSingle, float>(ISimdVector<TVectorSingle, float>.Create(0.49999997f), vector));
			case MidpointRounding.ToZero:
				return ISimdVector<TVectorSingle, float>.Truncate(vector);
			case MidpointRounding.ToNegativeInfinity:
				return ISimdVector<TVectorSingle, float>.Floor(vector);
			case MidpointRounding.ToPositiveInfinity:
				return ISimdVector<TVectorSingle, float>.Ceiling(vector);
			default:
				ThrowHelper.ThrowArgumentException_InvalidEnumValue<MidpointRounding>(mode, "mode");
				return default(TVectorSingle);
			}
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x001070D4 File Offset: 0x001052D4
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<TVectorDouble, TVectorDouble> SinCosDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Abs(x);
			TVectorInt64 left = Unsafe.BitCast<TVectorDouble, TVectorInt64>(tvectorDouble);
			TVectorDouble tvectorDouble3;
			TVectorDouble tvectorDouble4;
			if (ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4605249457297304857L)))
			{
				TVectorDouble tvectorDouble2 = x * x;
				if (ISimdVector<TVectorInt64, long>.GreaterThanAny(left, ISimdVector<TVectorInt64, long>.Create(4548635623644200959L)))
				{
					tvectorDouble3 = VectorMath.SinDoublePoly<TVectorDouble>(x);
					tvectorDouble4 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(VectorMath.CosDoublePoly<TVectorDouble>(x), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(-0.5)), tvectorDouble2, ISimdVector<TVectorDouble, double>.One);
				}
				else
				{
					TVectorDouble right = tvectorDouble2 * x;
					tvectorDouble3 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.16666666666666666), right, x);
					tvectorDouble4 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.5), tvectorDouble2, ISimdVector<TVectorDouble, double>.One);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4707126720094797824L)))
				{
					return VectorMath.<SinCosDouble>g__ScalarFallback|24_0<TVectorDouble, TVectorInt64>(x);
				}
				ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(tvectorDouble);
				TVectorDouble item = valueTuple.Item1;
				TVectorDouble item2 = valueTuple.Item2;
				TVectorInt64 item3 = valueTuple.Item3;
				TVectorDouble tvectorDouble5 = VectorMath.SinDoubleLarge<TVectorDouble>(item, item2);
				TVectorDouble tvectorDouble6 = VectorMath.CosDoubleLarge<TVectorDouble>(item, item2);
				tvectorDouble3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), tvectorDouble5, tvectorDouble6);
				tvectorDouble4 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), tvectorDouble6, tvectorDouble5);
				TVectorInt64 tvectorInt = IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(Unsafe.BitCast<TVectorDouble, TVectorInt64>(x), 63);
				tvectorDouble3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(((tvectorInt & IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item3, 1)) | (~tvectorInt & ~IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item3, 1))) & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), -tvectorDouble3, +tvectorDouble3);
				tvectorDouble4 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 + ISimdVector<TVectorInt64, long>.One & ISimdVector<TVectorInt64, long>.Create(2L), ISimdVector<TVectorInt64, long>.Zero)), +tvectorDouble4, -tvectorDouble4);
			}
			tvectorDouble3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.GreaterThan(left, ISimdVector<TVectorInt64, long>.Create(4485585228861014015L))), tvectorDouble3, x);
			tvectorDouble4 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.GreaterThan(left, ISimdVector<TVectorInt64, long>.Create(4485585228861014015L))), tvectorDouble4, ISimdVector<TVectorDouble, double>.One);
			return new ValueTuple<TVectorDouble, TVectorDouble>(tvectorDouble3, tvectorDouble4);
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x0010748C File Offset: 0x0010568C
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<TVectorSingle, TVectorSingle> SinCosSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorInt32 left = Unsafe.BitCast<TVectorSingle, TVectorInt32>(ISimdVector<TVectorSingle, float>.Abs(x));
			TVectorSingle tvectorSingle;
			TVectorSingle tvectorSingle2;
			if (ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1061752796)))
			{
				if (ISimdVector<TVectorInt32, int>.GreaterThanAny(left, ISimdVector<TVectorInt32, int>.Create(1006632959)))
				{
					if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
					{
						TVectorDouble tvectorDouble = VectorMath.Widen<TVectorSingle, TVectorDouble>(x);
						tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.SinSinglePoly<TVectorDouble>(tvectorDouble));
						tvectorSingle2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.CosSingleSmall<TVectorDouble>(tvectorDouble));
					}
					else
					{
						TVectorDouble tvectorDouble2 = VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x);
						TVectorDouble tvectorDouble3 = VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x);
						tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.SinSinglePoly<TVectorDouble>(tvectorDouble2), VectorMath.SinSinglePoly<TVectorDouble>(tvectorDouble3));
						tvectorSingle2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.CosSingleSmall<TVectorDouble>(tvectorDouble2), VectorMath.CosSingleSmall<TVectorDouble>(tvectorDouble3));
					}
				}
				else
				{
					TVectorSingle tvectorSingle3 = x * x;
					TVectorSingle right = tvectorSingle3 * x;
					tvectorSingle = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(-0.16666667f), right, x);
					tvectorSingle2 = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(-0.5f), tvectorSingle3, ISimdVector<TVectorSingle, float>.One);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1251513984)))
				{
					return VectorMath.<SinCosSingle>g__ScalarFallback|25_1<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(x);
				}
				if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
				{
					ValueTuple<TVectorDouble, TVectorDouble> valueTuple = VectorMath.<SinCosSingle>g__CoreImpl|25_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.Widen<TVectorSingle, TVectorDouble>(x));
					TVectorDouble item = valueTuple.Item1;
					TVectorDouble item2 = valueTuple.Item2;
					tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(item);
					tvectorSingle2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(item2);
				}
				else
				{
					ValueTuple<TVectorDouble, TVectorDouble> valueTuple2 = VectorMath.<SinCosSingle>g__CoreImpl|25_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x));
					TVectorDouble item3 = valueTuple2.Item1;
					TVectorDouble item4 = valueTuple2.Item2;
					ValueTuple<TVectorDouble, TVectorDouble> valueTuple3 = VectorMath.<SinCosSingle>g__CoreImpl|25_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x));
					TVectorDouble item5 = valueTuple3.Item1;
					TVectorDouble item6 = valueTuple3.Item2;
					tvectorSingle = VectorMath.Narrow<TVectorDouble, TVectorSingle>(item3, item5);
					tvectorSingle2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(item4, item6);
				}
			}
			tvectorSingle = ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorInt32, TVectorSingle>(ISimdVector<TVectorInt32, int>.GreaterThan(left, ISimdVector<TVectorInt32, int>.Create(956301311))), tvectorSingle, x);
			tvectorSingle2 = ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorInt32, TVectorSingle>(ISimdVector<TVectorInt32, int>.GreaterThan(left, ISimdVector<TVectorInt32, int>.Create(956301311))), tvectorSingle2, ISimdVector<TVectorSingle, float>.One);
			return new ValueTuple<TVectorSingle, TVectorSingle>(tvectorSingle, tvectorSingle2);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x001076E4 File Offset: 0x001058E4
		public static TVectorDouble SinDouble<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Abs(x);
			TVectorInt64 left = Unsafe.BitCast<TVectorDouble, TVectorInt64>(tvectorDouble);
			TVectorDouble tvectorDouble2;
			if (ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4605249457297304857L)))
			{
				TVectorDouble left2 = x * x;
				if (ISimdVector<TVectorInt64, long>.GreaterThanAny(left, ISimdVector<TVectorInt64, long>.Create(4548635623644200959L)))
				{
					tvectorDouble2 = VectorMath.SinDoublePoly<TVectorDouble>(x);
				}
				else
				{
					TVectorDouble right = left2 * x;
					tvectorDouble2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.16666666666666666), right, x);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt64, long>.LessThanAll(left, ISimdVector<TVectorInt64, long>.Create(4707126720094797824L)))
				{
					return VectorMath.<SinDouble>g__ScalarFallback|26_0<TVectorDouble, TVectorInt64>(x);
				}
				ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(tvectorDouble);
				TVectorDouble item = valueTuple.Item1;
				TVectorDouble item2 = valueTuple.Item2;
				TVectorInt64 item3 = valueTuple.Item3;
				TVectorDouble left3 = VectorMath.SinDoubleLarge<TVectorDouble>(item, item2);
				TVectorDouble right2 = VectorMath.CosDoubleLarge<TVectorDouble>(item, item2);
				tvectorDouble2 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item3 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), left3, right2);
				TVectorInt64 tvectorInt = IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(Unsafe.BitCast<TVectorDouble, TVectorInt64>(x), 63);
				tvectorDouble2 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(((tvectorInt & IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item3, 1)) | (~tvectorInt & ~IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item3, 1))) & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), -tvectorDouble2, +tvectorDouble2);
			}
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.GreaterThan(left, ISimdVector<TVectorInt64, long>.Create(4485585228861014015L))), tvectorDouble2, x);
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00107934 File Offset: 0x00105B34
		public static TVectorSingle SinSingle<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorInt32 left = Unsafe.BitCast<TVectorSingle, TVectorInt32>(ISimdVector<TVectorSingle, float>.Abs(x));
			TVectorSingle left2;
			if (ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1061752796)))
			{
				if (ISimdVector<TVectorInt32, int>.GreaterThanAny(left, ISimdVector<TVectorInt32, int>.Create(1006632959)))
				{
					if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
					{
						left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.SinSinglePoly<TVectorDouble>(VectorMath.Widen<TVectorSingle, TVectorDouble>(x)));
					}
					else
					{
						left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.SinSinglePoly<TVectorDouble>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x)), VectorMath.SinSinglePoly<TVectorDouble>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x)));
					}
				}
				else
				{
					TVectorSingle right = x * x * x;
					left2 = ISimdVector<TVectorSingle, float>.MultiplyAddEstimate(ISimdVector<TVectorSingle, float>.Create(-0.16666667f), right, x);
				}
			}
			else
			{
				if (!ISimdVector<TVectorInt32, int>.LessThanAll(left, ISimdVector<TVectorInt32, int>.Create(1251513984)))
				{
					return VectorMath.<SinSingle>g__ScalarFallback|27_1<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(x);
				}
				if (ISimdVector<TVectorSingle, float>.Count == ISimdVector<TVectorDouble, double>.Count)
				{
					left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<SinSingle>g__CoreImpl|27_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.Widen<TVectorSingle, TVectorDouble>(x)));
				}
				else
				{
					left2 = VectorMath.Narrow<TVectorDouble, TVectorSingle>(VectorMath.<SinSingle>g__CoreImpl|27_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenLower<TVectorSingle, TVectorDouble>(x)), VectorMath.<SinSingle>g__CoreImpl|27_0<TVectorSingle, TVectorInt32, TVectorDouble, TVectorInt64>(VectorMath.WidenUpper<TVectorSingle, TVectorDouble>(x)));
				}
			}
			return ISimdVector<TVectorSingle, float>.ConditionalSelect(Unsafe.BitCast<TVectorInt32, TVectorSingle>(ISimdVector<TVectorInt32, int>.GreaterThan(left, ISimdVector<TVectorInt32, int>.Create(956301311))), left2, x);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00107AB8 File Offset: 0x00105CB8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble ConvertToDouble<[IsUnmanaged] TVectorInt64, [IsUnmanaged] TVectorDouble>(TVectorInt64 vector) where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble result;
			Unsafe.SkipInit<TVectorDouble>(out result);
			if (typeof(TVectorInt64) == typeof(Vector<long>))
			{
				result = (TVectorDouble)((object)Vector.ConvertToDouble((Vector<long>)((object)vector)));
			}
			else if (typeof(TVectorInt64) == typeof(Vector64<long>))
			{
				result = (TVectorDouble)((object)Vector64.ConvertToDouble((Vector64<long>)((object)vector)));
			}
			else if (typeof(TVectorInt64) == typeof(Vector128<long>))
			{
				result = (TVectorDouble)((object)Vector128.ConvertToDouble((Vector128<long>)((object)vector)));
			}
			else if (typeof(TVectorInt64) == typeof(Vector256<long>))
			{
				result = (TVectorDouble)((object)Vector256.ConvertToDouble((Vector256<long>)((object)vector)));
			}
			else if (typeof(TVectorInt64) == typeof(Vector512<long>))
			{
				result = (TVectorDouble)((object)Vector512.ConvertToDouble((Vector512<long>)((object)vector)));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00107BF0 File Offset: 0x00105DF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorSingle ConvertToSingle<[IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorSingle>(TVectorInt32 vector) where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float>
		{
			TVectorSingle result;
			Unsafe.SkipInit<TVectorSingle>(out result);
			if (typeof(TVectorInt32) == typeof(Vector<int>))
			{
				result = (TVectorSingle)((object)Vector.ConvertToSingle((Vector<int>)((object)vector)));
			}
			else if (typeof(TVectorInt32) == typeof(Vector64<int>))
			{
				result = (TVectorSingle)((object)Vector64.ConvertToSingle((Vector64<int>)((object)vector)));
			}
			else if (typeof(TVectorInt32) == typeof(Vector128<int>))
			{
				result = (TVectorSingle)((object)Vector128.ConvertToSingle((Vector128<int>)((object)vector)));
			}
			else if (typeof(TVectorInt32) == typeof(Vector256<int>))
			{
				result = (TVectorSingle)((object)Vector256.ConvertToSingle((Vector256<int>)((object)vector)));
			}
			else if (typeof(TVectorInt32) == typeof(Vector512<int>))
			{
				result = (TVectorSingle)((object)Vector512.ConvertToSingle((Vector512<int>)((object)vector)));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00107D28 File Offset: 0x00105F28
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble CosDoubleLarge<[IsUnmanaged] TVectorDouble>(TVectorDouble r, TVectorDouble rr) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble right = tvectorDouble * tvectorDouble;
			TVectorDouble tvectorDouble2 = tvectorDouble * 0.5;
			TVectorDouble right2 = tvectorDouble2 - ISimdVector<TVectorDouble, double>.One;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(VectorMath.CosDoublePoly<TVectorDouble>(r), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(r, rr, ISimdVector<TVectorDouble, double>.One + right2 - tvectorDouble2)) - right2;
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00107DCC File Offset: 0x00105FCC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble CosDoublePoly<[IsUnmanaged] TVectorDouble>(TVectorDouble r) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble tvectorDouble2 = tvectorDouble * tvectorDouble;
			TVectorDouble right = tvectorDouble2 * tvectorDouble2;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-1.138263981623609E-11), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(2.0876146382372144E-09)), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-2.755731727234489E-07), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(2.4801587298767044E-05)), tvectorDouble2, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.0013888888888887398), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(0.041666666666666664))));
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00107EB8 File Offset: 0x001060B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble CosSingleLarge<[IsUnmanaged] TVectorDouble>(TVectorDouble r) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble right = tvectorDouble * tvectorDouble;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(VectorMath.CosSinglePoly<TVectorDouble>(r), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.5), tvectorDouble, ISimdVector<TVectorDouble, double>.One));
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00107F20 File Offset: 0x00106120
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble CosSinglePoly<[IsUnmanaged] TVectorDouble>(TVectorDouble r) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble right = tvectorDouble * tvectorDouble;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-2.755731727234489E-07), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(2.4801587298767044E-05)), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.0013888888888887398), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(0.041666666666666664)));
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x00107FC0 File Offset: 0x001061C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble CosSingleSmall<[IsUnmanaged] TVectorDouble>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = x * x;
			TVectorDouble right = tvectorDouble * tvectorDouble;
			TVectorDouble right2 = tvectorDouble * 0.5;
			TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.One - right2;
			TVectorDouble addend = tvectorDouble2 + (ISimdVector<TVectorDouble, double>.One - tvectorDouble2 - right2);
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(VectorMath.CosSinglePoly<TVectorDouble>(x), right, addend);
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00108058 File Offset: 0x00106258
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVector Create<[IsUnmanaged] TVector, T>(double value) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			TVector result;
			Unsafe.SkipInit<TVector>(out result);
			if (typeof(TVector) == typeof(Vector<double>))
			{
				result = (TVector)((object)Vector.Create<double>(value));
			}
			else if (typeof(TVector) == typeof(Vector64<double>))
			{
				result = (TVector)((object)Vector64.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector128<double>))
			{
				result = (TVector)((object)Vector128.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector256<double>))
			{
				result = (TVector)((object)Vector256.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector512<double>))
			{
				result = (TVector)((object)Vector512.Create(value));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00108160 File Offset: 0x00106360
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVector Create<[IsUnmanaged] TVector, T>(float value) where TVector : struct, ValueType, ISimdVector<TVector, T>
		{
			TVector result;
			Unsafe.SkipInit<TVector>(out result);
			if (typeof(TVector) == typeof(Vector<float>))
			{
				result = (TVector)((object)Vector.Create<float>(value));
			}
			else if (typeof(TVector) == typeof(Vector64<float>))
			{
				result = (TVector)((object)Vector64.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector128<float>))
			{
				result = (TVector)((object)Vector128.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector256<float>))
			{
				result = (TVector)((object)Vector256.Create(value));
			}
			else if (typeof(TVector) == typeof(Vector512<float>))
			{
				result = (TVector)((object)Vector512.Create(value));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00108268 File Offset: 0x00106468
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorSingle Narrow<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorSingle>(TVectorDouble vector) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float>
		{
			TVectorSingle result;
			Unsafe.SkipInit<TVectorSingle>(out result);
			if (typeof(TVectorDouble) == typeof(Vector128<double>))
			{
				if (false)
				{
				}
				Vector128<double> vector2 = (Vector128<double>)((object)vector);
				result = (TVectorSingle)((object)Vector64.Narrow(vector2.GetLower<double>(), vector2.GetUpper<double>()));
			}
			else if (typeof(TVectorDouble) == typeof(Vector256<double>))
			{
				if (false)
				{
				}
				Vector256<double> vector3 = (Vector256<double>)((object)vector);
				result = (TVectorSingle)((object)Vector128.Narrow(vector3.GetLower<double>(), vector3.GetUpper<double>()));
			}
			else if (typeof(TVectorDouble) == typeof(Vector512<double>))
			{
				if (false)
				{
				}
				Vector512<double> vector4 = (Vector512<double>)((object)vector);
				result = (TVectorSingle)((object)Vector256.Narrow(vector4.GetLower<double>(), vector4.GetUpper<double>()));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00108360 File Offset: 0x00106560
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorSingle Narrow<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorSingle>(TVectorDouble lower, TVectorDouble upper) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float>
		{
			TVectorSingle result;
			Unsafe.SkipInit<TVectorSingle>(out result);
			if (typeof(TVectorDouble) == typeof(Vector<double>))
			{
				result = (TVectorSingle)((object)Vector.Narrow((Vector<double>)((object)lower), (Vector<double>)((object)upper)));
			}
			else if (typeof(TVectorDouble) == typeof(Vector64<double>))
			{
				result = (TVectorSingle)((object)Vector64.Narrow((Vector64<double>)((object)lower), (Vector64<double>)((object)upper)));
			}
			else if (typeof(TVectorDouble) == typeof(Vector128<double>))
			{
				result = (TVectorSingle)((object)Vector128.Narrow((Vector128<double>)((object)lower), (Vector128<double>)((object)upper)));
			}
			else if (typeof(TVectorDouble) == typeof(Vector256<double>))
			{
				result = (TVectorSingle)((object)Vector256.Narrow((Vector256<double>)((object)lower), (Vector256<double>)((object)upper)));
			}
			else if (typeof(TVectorDouble) == typeof(Vector512<double>))
			{
				result = (TVectorSingle)((object)Vector512.Narrow((Vector512<double>)((object)lower), (Vector512<double>)((object)upper)));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x001084D4 File Offset: 0x001066D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble SinDoubleLarge<[IsUnmanaged] TVectorDouble>(TVectorDouble r, TVectorDouble rr) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble tvectorDouble2 = tvectorDouble * r;
			TVectorDouble tvectorDouble3 = tvectorDouble * tvectorDouble;
			TVectorDouble right = tvectorDouble3 * tvectorDouble3;
			TVectorDouble right2 = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(1.5918144304485914E-10), right, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-2.5051132068021698E-08), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(2.7557316103728802E-06)), tvectorDouble3, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-0.00019841269836761127), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(0.00833333333333095))));
			return r - ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.16666666666666666), tvectorDouble2, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(rr, ISimdVector<TVectorDouble, double>.Create(0.5), -(tvectorDouble2 * right2)), tvectorDouble, -rr));
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x0010862C File Offset: 0x0010682C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble SinDoublePoly<[IsUnmanaged] TVectorDouble>(TVectorDouble r) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble right = tvectorDouble * r;
			TVectorDouble tvectorDouble2 = tvectorDouble * tvectorDouble;
			TVectorDouble right2 = tvectorDouble2 * tvectorDouble2;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(1.5918144304485914E-10), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(-2.5051132068021698E-08)), right2, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(2.7557316103728802E-06), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(-0.00019841269836761127)), tvectorDouble2, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.00833333333333095), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(-0.16666666666666666)))), right, r);
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00108734 File Offset: 0x00106934
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble SinSinglePoly<[IsUnmanaged] TVectorDouble>(TVectorDouble r) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble tvectorDouble = r * r;
			TVectorDouble right = tvectorDouble * r;
			TVectorDouble right2 = tvectorDouble * tvectorDouble;
			return ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(2.7557316103728802E-06), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(-0.00019841269836761127)), right2, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.00833333333333095), tvectorDouble, ISimdVector<TVectorDouble, double>.Create(-0.16666666666666666))), right, r);
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x001087EC File Offset: 0x001069EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"r",
			"rr",
			"region"
		})]
		private static ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> SinCosReduce<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble ax) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.6366197723675814), ax, ISimdVector<TVectorDouble, double>.Create(6755399441055744.0));
			TVectorInt64 item = Unsafe.BitCast<TVectorDouble, TVectorInt64>(tvectorDouble);
			tvectorDouble -= ISimdVector<TVectorDouble, double>.Create(6755399441055744.0);
			TVectorDouble left = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(-1.5707963267341256), tvectorDouble, ax);
			TVectorDouble right = tvectorDouble * 6.077100506303966E-11;
			TVectorDouble tvectorDouble2 = left - right;
			right = ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(2.0222662487959506E-21), tvectorDouble, -(left - tvectorDouble2 - right));
			left = tvectorDouble2;
			tvectorDouble2 -= right;
			return new ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64>(tvectorDouble2, left - tvectorDouble2 - right, item);
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00108918 File Offset: 0x00106B18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble Widen<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorDouble>(TVectorSingle vector) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble result;
			Unsafe.SkipInit<TVectorDouble>(out result);
			if (typeof(TVectorSingle) == typeof(Vector64<float>))
			{
				if (false)
				{
				}
				Vector64<float> source = (Vector64<float>)((object)vector);
				Vector64<double> lower = Vector64.WidenLower(source);
				Vector64<double> upper = Vector64.WidenUpper(source);
				result = (TVectorDouble)((object)Vector128.Create(lower, upper));
			}
			else if (typeof(TVectorSingle) == typeof(Vector128<float>))
			{
				if (false)
				{
				}
				Vector128<float> source2 = (Vector128<float>)((object)vector);
				Vector128<double> lower2 = Vector128.WidenLower(source2);
				Vector128<double> upper2 = Vector128.WidenUpper(source2);
				result = (TVectorDouble)((object)Vector256.Create(lower2, upper2));
			}
			else if (typeof(TVectorSingle) == typeof(Vector256<float>))
			{
				if (false)
				{
				}
				Vector256<float> source3 = (Vector256<float>)((object)vector);
				Vector256<double> lower3 = Vector256.WidenLower(source3);
				Vector256<double> upper3 = Vector256.WidenUpper(source3);
				result = (TVectorDouble)((object)Vector512.Create(lower3, upper3));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00108A1C File Offset: 0x00106C1C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble WidenLower<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorDouble>(TVectorSingle vector) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble result;
			Unsafe.SkipInit<TVectorDouble>(out result);
			if (typeof(TVectorSingle) == typeof(Vector<float>))
			{
				result = (TVectorDouble)((object)Vector.WidenLower((Vector<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector64<float>))
			{
				result = (TVectorDouble)((object)Vector64.WidenLower((Vector64<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector128<float>))
			{
				result = (TVectorDouble)((object)Vector128.WidenLower((Vector128<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector256<float>))
			{
				result = (TVectorDouble)((object)Vector256.WidenLower((Vector256<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector512<float>))
			{
				result = (TVectorDouble)((object)Vector512.WidenLower((Vector512<float>)((object)vector)));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00108B54 File Offset: 0x00106D54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TVectorDouble WidenUpper<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorDouble>(TVectorSingle vector) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			TVectorDouble result;
			Unsafe.SkipInit<TVectorDouble>(out result);
			if (typeof(TVectorSingle) == typeof(Vector<float>))
			{
				result = (TVectorDouble)((object)Vector.WidenUpper((Vector<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector64<float>))
			{
				result = (TVectorDouble)((object)Vector64.WidenUpper((Vector64<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector128<float>))
			{
				result = (TVectorDouble)((object)Vector128.WidenUpper((Vector128<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector256<float>))
			{
				result = (TVectorDouble)((object)Vector256.WidenUpper((Vector256<float>)((object)vector)));
			}
			else if (typeof(TVectorSingle) == typeof(Vector512<float>))
			{
				result = (TVectorDouble)((object)Vector512.WidenUpper((Vector512<float>)((object)vector)));
			}
			else
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00108C8C File Offset: 0x00106E8C
		[CompilerGenerated]
		internal static TVectorDouble <CosDouble>g__ScalarFallback|0_0<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Zero;
			for (int i = 0; i < ISimdVector<TVectorDouble, double>.Count; i++)
			{
				double value = double.Cos(x[i]);
				tvectorDouble = tvectorDouble.WithElement(i, value);
			}
			return tvectorDouble;
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00108CDC File Offset: 0x00106EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static TVectorDouble <CosSingle>g__CoreImpl|1_0<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble ax) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(ax);
			TVectorDouble item = valueTuple.Item1;
			TVectorInt64 item2 = valueTuple.Item3;
			TVectorDouble right = VectorMath.SinSinglePoly<TVectorDouble>(item);
			TVectorDouble left = VectorMath.CosSingleLarge<TVectorDouble>(item);
			TVectorDouble value = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), left, right);
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 + ISimdVector<TVectorInt64, long>.One & ISimdVector<TVectorInt64, long>.Create(2L), ISimdVector<TVectorInt64, long>.Zero)), +value, -value);
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00108DB8 File Offset: 0x00106FB8
		[CompilerGenerated]
		internal static TVectorSingle <CosSingle>g__ScalarFallback|1_1<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorSingle tvectorSingle = ISimdVector<TVectorSingle, float>.Zero;
			for (int i = 0; i < ISimdVector<TVectorSingle, float>.Count; i++)
			{
				float value = float.Cos(x[i]);
				tvectorSingle = tvectorSingle.WithElement(i, value);
			}
			return tvectorSingle;
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00108E08 File Offset: 0x00107008
		[CompilerGenerated]
		internal static TVectorDouble <ExpDouble>g__ScalarFallback|4_0<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorUInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Zero;
			for (int i = 0; i < ISimdVector<TVectorDouble, double>.Count; i++)
			{
				double value = double.Exp(x[i]);
				tvectorDouble = tvectorDouble.WithElement(i, value);
			}
			return tvectorDouble;
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00108E58 File Offset: 0x00107058
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static TVectorDouble <ExpSingle>g__CoreImpl|5_0<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorUInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorUInt64>(TVectorDouble x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorUInt32 : struct, ValueType, ISimdVector<TVectorUInt32, uint> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorUInt64 : struct, ValueType, ISimdVector<TVectorUInt64, ulong>
		{
			TVectorDouble left = x * ISimdVector<TVectorDouble, double>.Create(1.4426950408889634);
			TVectorDouble right = ISimdVector<TVectorDouble, double>.Create(6755399441055744.0);
			TVectorDouble tvectorDouble = left + right;
			TVectorUInt64 value = Unsafe.BitCast<TVectorDouble, TVectorUInt64>(tvectorDouble);
			TVectorDouble tvectorDouble2 = left - (tvectorDouble - right);
			TVectorDouble tvectorDouble3 = tvectorDouble2 * tvectorDouble2;
			return Unsafe.BitCast<TVectorUInt64, TVectorDouble>(Unsafe.BitCast<TVectorDouble, TVectorUInt64>(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble3 * tvectorDouble3, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.001341000536524434), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(0.009676036358193323)), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(tvectorDouble3, ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.05550297297702539), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(0.2402210737432219)), ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(ISimdVector<TVectorDouble, double>.Create(0.6931472254087585), tvectorDouble2, ISimdVector<TVectorDouble, double>.Create(1.0000000754895704))))) + (value << 52));
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00108FBD File Offset: 0x001071BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static TVectorDouble <HypotSingle>g__CoreImpl|7_0<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorDouble>(TVectorDouble x, TVectorDouble y) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double>
		{
			return ISimdVector<TVectorDouble, double>.Sqrt(ISimdVector<TVectorDouble, double>.MultiplyAddEstimate(x, x, y * y));
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00108FE4 File Offset: 0x001071E4
		[CompilerGenerated]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		internal static ValueTuple<TVectorDouble, TVectorDouble> <SinCosDouble>g__ScalarFallback|24_0<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Zero;
			TVectorDouble tvectorDouble2 = ISimdVector<TVectorDouble, double>.Zero;
			for (int i = 0; i < ISimdVector<TVectorDouble, double>.Count; i++)
			{
				ValueTuple<double, double> valueTuple = double.SinCos(x[i]);
				double item = valueTuple.Item1;
				double item2 = valueTuple.Item2;
				tvectorDouble = tvectorDouble.WithElement(i, item);
				tvectorDouble2 = tvectorDouble2.WithElement(i, item2);
			}
			return new ValueTuple<TVectorDouble, TVectorDouble>(tvectorDouble, tvectorDouble2);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x0010905C File Offset: 0x0010725C
		[CompilerGenerated]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		internal static ValueTuple<TVectorDouble, TVectorDouble> <SinCosSingle>g__CoreImpl|25_0<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(ISimdVector<TVectorDouble, double>.Abs(x));
			TVectorDouble item = valueTuple.Item1;
			TVectorInt64 item2 = valueTuple.Item3;
			TVectorDouble tvectorDouble = VectorMath.SinSinglePoly<TVectorDouble>(item);
			TVectorDouble tvectorDouble2 = VectorMath.CosSingleLarge<TVectorDouble>(item);
			TVectorDouble tvectorDouble3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), tvectorDouble, tvectorDouble2);
			TVectorDouble tvectorDouble4 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), tvectorDouble2, tvectorDouble);
			TVectorInt64 tvectorInt = IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(Unsafe.BitCast<TVectorDouble, TVectorInt64>(x), 63);
			tvectorDouble3 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(((tvectorInt & IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item2, 1)) | (~tvectorInt & ~IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item2, 1))) & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), -tvectorDouble3, +tvectorDouble3);
			tvectorDouble4 = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 + ISimdVector<TVectorInt64, long>.One & ISimdVector<TVectorInt64, long>.Create(2L), ISimdVector<TVectorInt64, long>.Zero)), +tvectorDouble4, -tvectorDouble4);
			return new ValueTuple<TVectorDouble, TVectorDouble>(tvectorDouble3, tvectorDouble4);
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00109254 File Offset: 0x00107454
		[CompilerGenerated]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		internal static ValueTuple<TVectorSingle, TVectorSingle> <SinCosSingle>g__ScalarFallback|25_1<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorSingle tvectorSingle = ISimdVector<TVectorSingle, float>.Zero;
			TVectorSingle tvectorSingle2 = ISimdVector<TVectorSingle, float>.Zero;
			for (int i = 0; i < ISimdVector<TVectorSingle, float>.Count; i++)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(x[i]);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				tvectorSingle = tvectorSingle.WithElement(i, item);
				tvectorSingle2 = tvectorSingle2.WithElement(i, item2);
			}
			return new ValueTuple<TVectorSingle, TVectorSingle>(tvectorSingle, tvectorSingle2);
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x001092CC File Offset: 0x001074CC
		[CompilerGenerated]
		internal static TVectorDouble <SinDouble>g__ScalarFallback|26_0<[IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorDouble tvectorDouble = ISimdVector<TVectorDouble, double>.Zero;
			for (int i = 0; i < ISimdVector<TVectorDouble, double>.Count; i++)
			{
				double value = double.Sin(x[i]);
				tvectorDouble = tvectorDouble.WithElement(i, value);
			}
			return tvectorDouble;
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x0010931C File Offset: 0x0010751C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static TVectorDouble <SinSingle>g__CoreImpl|27_0<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorDouble x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			ValueTuple<TVectorDouble, TVectorDouble, TVectorInt64> valueTuple = VectorMath.SinCosReduce<TVectorDouble, TVectorInt64>(ISimdVector<TVectorDouble, double>.Abs(x));
			TVectorDouble item = valueTuple.Item1;
			TVectorInt64 item2 = valueTuple.Item3;
			TVectorDouble left = VectorMath.SinSinglePoly<TVectorDouble>(item);
			TVectorDouble right = VectorMath.CosSingleLarge<TVectorDouble>(item);
			TVectorDouble value = ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(item2 & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), left, right);
			TVectorInt64 tvectorInt = IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(Unsafe.BitCast<TVectorDouble, TVectorInt64>(x), 63);
			return ISimdVector<TVectorDouble, double>.ConditionalSelect(Unsafe.BitCast<TVectorInt64, TVectorDouble>(ISimdVector<TVectorInt64, long>.Equals(((tvectorInt & IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item2, 1)) | (~tvectorInt & ~IShiftOperators<TVectorInt64, int, TVectorInt64>.op_UnsignedRightShift(item2, 1))) & ISimdVector<TVectorInt64, long>.One, ISimdVector<TVectorInt64, long>.Zero)), -value, +value);
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x00109458 File Offset: 0x00107658
		[CompilerGenerated]
		internal static TVectorSingle <SinSingle>g__ScalarFallback|27_1<[IsUnmanaged] TVectorSingle, [IsUnmanaged] TVectorInt32, [IsUnmanaged] TVectorDouble, [IsUnmanaged] TVectorInt64>(TVectorSingle x) where TVectorSingle : struct, ValueType, ISimdVector<TVectorSingle, float> where TVectorInt32 : struct, ValueType, ISimdVector<TVectorInt32, int> where TVectorDouble : struct, ValueType, ISimdVector<TVectorDouble, double> where TVectorInt64 : struct, ValueType, ISimdVector<TVectorInt64, long>
		{
			TVectorSingle tvectorSingle = ISimdVector<TVectorSingle, float>.Zero;
			for (int i = 0; i < ISimdVector<TVectorSingle, float>.Count; i++)
			{
				float value = float.Sin(x[i]);
				tvectorSingle = tvectorSingle.WithElement(i, value);
			}
			return tvectorSingle;
		}
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200056B RID: 1387
	[CLSCompliant(false)]
	public abstract class Avx : Sse42
	{
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Add(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Add(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> AddSubtract(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> AddSubtract(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> And(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> And(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> AndNot(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> AndNot(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Blend(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Blend(Vector256<double> left, Vector256<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> BlendVariable(Vector256<float> left, Vector256<float> right, Vector256<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> BlendVariable(Vector256<double> left, Vector256<double> right, Vector256<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> BroadcastScalarToVector128(float* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> BroadcastScalarToVector256(float* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> BroadcastScalarToVector256(double* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> BroadcastVector128ToVector256(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> BroadcastVector128ToVector256(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Ceiling(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Ceiling(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Compare(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Compare(Vector256<float> left, Vector256<float> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareGreaterThan(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareGreaterThanOrEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareLessThan(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareLessThanOrEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareNotEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareNotGreaterThan(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareNotGreaterThanOrEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareNotLessThan(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareNotLessThanOrEqual(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareOrdered(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> CompareUnordered(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Compare(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Compare(Vector256<double> left, Vector256<double> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareGreaterThan(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareGreaterThanOrEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareLessThan(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareLessThanOrEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareNotEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareNotGreaterThan(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareNotGreaterThanOrEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareNotLessThan(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareNotLessThanOrEqual(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareOrdered(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> CompareUnordered(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ConvertToVector256Double(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ConvertToVector256Double(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32WithTruncation(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> DotProduct(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> DuplicateEvenIndexed(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> DuplicateEvenIndexed(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> DuplicateOddIndexed(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractVector128(Vector256<byte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ExtractVector128(Vector256<sbyte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ExtractVector128(Vector256<short> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractVector128(Vector256<ushort> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ExtractVector128(Vector256<int> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractVector128(Vector256<uint> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ExtractVector128(Vector256<long> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ExtractVector128(Vector256<ulong> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ExtractVector128(Vector256<float> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ExtractVector128(Vector256<double> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Floor(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Floor(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> HorizontalAdd(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> HorizontalAdd(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> HorizontalSubtract(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> HorizontalSubtract(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> InsertVector128(Vector256<byte> value, Vector128<byte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> InsertVector128(Vector256<sbyte> value, Vector128<sbyte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> InsertVector128(Vector256<short> value, Vector128<short> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> InsertVector128(Vector256<ushort> value, Vector128<ushort> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> InsertVector128(Vector256<int> value, Vector128<int> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> InsertVector128(Vector256<uint> value, Vector128<uint> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> InsertVector128(Vector256<long> value, Vector128<long> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> InsertVector128(Vector256<ulong> value, Vector128<ulong> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> InsertVector128(Vector256<float> value, Vector128<float> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> InsertVector128(Vector256<double> value, Vector128<double> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> LoadAlignedVector256(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> LoadAlignedVector256(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> LoadAlignedVector256(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> LoadAlignedVector256(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> LoadAlignedVector256(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> LoadAlignedVector256(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> LoadAlignedVector256(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> LoadAlignedVector256(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> LoadAlignedVector256(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> LoadAlignedVector256(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> LoadDquVector256(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> LoadDquVector256(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> LoadDquVector256(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> LoadDquVector256(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> LoadDquVector256(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> LoadDquVector256(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> LoadDquVector256(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> LoadDquVector256(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> LoadVector256(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> LoadVector256(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> LoadVector256(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> LoadVector256(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> LoadVector256(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> LoadVector256(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> LoadVector256(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> LoadVector256(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> LoadVector256(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> LoadVector256(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> MaskLoad(float* address, Vector128<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> MaskLoad(double* address, Vector128<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> MaskLoad(float* address, Vector256<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> MaskLoad(double* address, Vector256<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(float* address, Vector128<float> mask, Vector128<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(double* address, Vector128<double> mask, Vector128<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(float* address, Vector256<float> mask, Vector256<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(double* address, Vector256<double> mask, Vector256<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Max(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Max(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Min(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Min(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int MoveMask(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int MoveMask(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Or(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Or(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Permute(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Permute(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Permute(Vector256<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Permute(Vector256<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Permute2x128(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Permute2x128(Vector256<sbyte> left, Vector256<sbyte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Permute2x128(Vector256<short> left, Vector256<short> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Permute2x128(Vector256<ushort> left, Vector256<ushort> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Permute2x128(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Permute2x128(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Permute2x128(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Permute2x128(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Permute2x128(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Permute2x128(Vector256<double> left, Vector256<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> PermuteVar(Vector128<float> left, Vector128<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> PermuteVar(Vector128<double> left, Vector128<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> PermuteVar(Vector256<float> left, Vector256<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> PermuteVar(Vector256<double> left, Vector256<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Reciprocal(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ReciprocalSqrt(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundCurrentDirection(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundCurrentDirection(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundToNearestInteger(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundToNearestInteger(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundToNegativeInfinity(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundToNegativeInfinity(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundToPositiveInfinity(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundToPositiveInfinity(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundToZero(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundToZero(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Shuffle(Vector256<float> value, Vector256<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Shuffle(Vector256<double> value, Vector256<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Sqrt(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Sqrt(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, Vector256<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, Vector256<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, Vector256<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, Vector256<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, Vector256<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, Vector256<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(long* address, Vector256<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ulong* address, Vector256<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, Vector256<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(double* address, Vector256<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(sbyte* address, Vector256<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(byte* address, Vector256<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(short* address, Vector256<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(ushort* address, Vector256<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(int* address, Vector256<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(uint* address, Vector256<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(long* address, Vector256<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(ulong* address, Vector256<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(float* address, Vector256<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(double* address, Vector256<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(sbyte* address, Vector256<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(byte* address, Vector256<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(short* address, Vector256<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(ushort* address, Vector256<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(int* address, Vector256<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(uint* address, Vector256<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(long* address, Vector256<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(ulong* address, Vector256<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(float* address, Vector256<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(double* address, Vector256<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestC(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestNotZAndNotC(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestZ(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> UnpackHigh(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> UnpackHigh(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> UnpackLow(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> UnpackLow(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Xor(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Xor(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200056C RID: 1388
		public new abstract class X64 : Sse42.X64
		{
			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x060063E4 RID: 25572 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}
		}
	}
}

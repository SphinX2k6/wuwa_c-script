using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB7 RID: 2999
	public struct Damage : IFlatbufferObject
	{
		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x0020393C File Offset: 0x00201B3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00203949 File Offset: 0x00201B49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x00203950 File Offset: 0x00201B50
		public static Damage GetRootAsDamage(ByteBuffer _bb)
		{
			return Damage.GetRootAsDamage(_bb, default(Damage));
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x0020396C File Offset: 0x00201B6C
		public static Damage GetRootAsDamage(ByteBuffer _bb, Damage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x00203989 File Offset: 0x00201B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00203998 File Offset: 0x00201B98
		public Damage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x002039A8 File Offset: 0x00201BA8
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06005B3A RID: 23354 RVA: 0x002039F0 File Offset: 0x00201BF0
		public string Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00203A27 File Offset: 0x00201C27
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00203A36 File Offset: 0x00201C36
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00203A50 File Offset: 0x00201C50
		public DicStringString? ConstVariables(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06005B3E RID: 23358 RVA: 0x00203AB0 File Offset: 0x00201CB0
		public int ConstVariablesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x00203ADC File Offset: 0x00201CDC
		public int ExecutionTiming
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x00203B1C File Offset: 0x00201D1C
		public int CalculateType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x00203B5C File Offset: 0x00201D5C
		public int Element
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06005B42 RID: 23362 RVA: 0x00203B9C File Offset: 0x00201D9C
		public int DamageTextType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06005B43 RID: 23363 RVA: 0x00203BDC File Offset: 0x00201DDC
		public int DamageTextAreaId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06005B44 RID: 23364 RVA: 0x00203C1C File Offset: 0x00201E1C
		public long PayloadId
		{
			get
			{
				int num = this.__p.__offset(20);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x00203C64 File Offset: 0x00201E64
		public int Type
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00203CA4 File Offset: 0x00201EA4
		public int SubType(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x00203CE4 File Offset: 0x00201EE4
		public int SubTypeLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00203D10 File Offset: 0x00201F10
		public Span<int> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00203D20 File Offset: 0x00201F20
		public int[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06005B4A RID: 23370 RVA: 0x00203D38 File Offset: 0x00201F38
		public int SmashType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00203D78 File Offset: 0x00201F78
		public int CureBaseValue(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x00203DB8 File Offset: 0x00201FB8
		public int CureBaseValueLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00203DE4 File Offset: 0x00201FE4
		public Span<int> GetCureBaseValueBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00203DF4 File Offset: 0x00201FF4
		public int[] GetCureBaseValueArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x00203E0C File Offset: 0x0020200C
		public int RelatedProperty
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x00203E4C File Offset: 0x0020204C
		public int RateLv(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x00203E8C File Offset: 0x0020208C
		public int RateLvLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x00203EB8 File Offset: 0x002020B8
		public Span<int> GetRateLvBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x00203EC8 File Offset: 0x002020C8
		public int[] GetRateLvArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00203EE0 File Offset: 0x002020E0
		public int HardnessLv(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x00203F20 File Offset: 0x00202120
		public int HardnessLvLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00203F4C File Offset: 0x0020214C
		public Span<int> GetHardnessLvBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00203F5C File Offset: 0x0020215C
		public int[] GetHardnessLvArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00203F74 File Offset: 0x00202174
		public int ToughLv(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06005B59 RID: 23385 RVA: 0x00203FB4 File Offset: 0x002021B4
		public int ToughLvLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00203FE0 File Offset: 0x002021E0
		public Span<int> GetToughLvBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00203FF0 File Offset: 0x002021F0
		public int[] GetToughLvArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00204008 File Offset: 0x00202208
		public int Energy(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06005B5D RID: 23389 RVA: 0x00204048 File Offset: 0x00202248
		public int EnergyLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00204074 File Offset: 0x00202274
		public Span<int> GetEnergyBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00204084 File Offset: 0x00202284
		public int[] GetEnergyArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x0020409C File Offset: 0x0020229C
		public int SpecialEnergy1(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06005B61 RID: 23393 RVA: 0x002040DC File Offset: 0x002022DC
		public int SpecialEnergy1Length
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00204108 File Offset: 0x00202308
		public Span<int> GetSpecialEnergy1Bytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00204118 File Offset: 0x00202318
		public int[] GetSpecialEnergy1Array()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00204130 File Offset: 0x00202330
		public int SpecialEnergy2(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00204170 File Offset: 0x00202370
		public int SpecialEnergy2Length
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x0020419C File Offset: 0x0020239C
		public Span<int> GetSpecialEnergy2Bytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x002041AC File Offset: 0x002023AC
		public int[] GetSpecialEnergy2Array()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x002041C4 File Offset: 0x002023C4
		public int SpecialEnergy3(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06005B69 RID: 23401 RVA: 0x00204204 File Offset: 0x00202404
		public int SpecialEnergy3Length
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x00204230 File Offset: 0x00202430
		public Span<int> GetSpecialEnergy3Bytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00204240 File Offset: 0x00202440
		public int[] GetSpecialEnergy3Array()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00204258 File Offset: 0x00202458
		public int SpecialEnergy4(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06005B6D RID: 23405 RVA: 0x00204298 File Offset: 0x00202498
		public int SpecialEnergy4Length
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x002042C4 File Offset: 0x002024C4
		public Span<int> GetSpecialEnergy4Bytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x002042D4 File Offset: 0x002024D4
		public int[] GetSpecialEnergy4Array()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x002042EC File Offset: 0x002024EC
		public int SpecialEnergy5(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06005B71 RID: 23409 RVA: 0x0020432C File Offset: 0x0020252C
		public int SpecialEnergy5Length
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00204358 File Offset: 0x00202558
		public Span<int> GetSpecialEnergy5Bytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x00204368 File Offset: 0x00202568
		public int[] GetSpecialEnergy5Array()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x00204380 File Offset: 0x00202580
		public int ElementPowerType
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x002043C0 File Offset: 0x002025C0
		public int Dying(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x00204400 File Offset: 0x00202600
		public int DyingLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x0020442C File Offset: 0x0020262C
		public Span<int> GetDyingBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x0020443C File Offset: 0x0020263C
		public int[] GetDyingArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00204454 File Offset: 0x00202654
		public int ElementPower(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x00204494 File Offset: 0x00202694
		public int ElementPowerLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x002044C0 File Offset: 0x002026C0
		public Span<int> GetElementPowerBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x002044D0 File Offset: 0x002026D0
		public int[] GetElementPowerArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x002044E8 File Offset: 0x002026E8
		public int FormulaType
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00204528 File Offset: 0x00202728
		public int FormulaParam1(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x00204568 File Offset: 0x00202768
		public int FormulaParam1Length
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00204594 File Offset: 0x00202794
		public Span<int> GetFormulaParam1Bytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x002045A4 File Offset: 0x002027A4
		public int[] GetFormulaParam1Array()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x002045BC File Offset: 0x002027BC
		public int FormulaParam2(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06005B83 RID: 23427 RVA: 0x002045FC File Offset: 0x002027FC
		public int FormulaParam2Length
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00204628 File Offset: 0x00202828
		public Span<int> GetFormulaParam2Bytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00204638 File Offset: 0x00202838
		public int[] GetFormulaParam2Array()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x00204650 File Offset: 0x00202850
		public int FormulaParam3(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x00204690 File Offset: 0x00202890
		public int FormulaParam3Length
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x002046BC File Offset: 0x002028BC
		public Span<int> GetFormulaParam3Bytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x002046CC File Offset: 0x002028CC
		public int[] GetFormulaParam3Array()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x002046E4 File Offset: 0x002028E4
		public int FormulaParam4(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06005B8B RID: 23435 RVA: 0x00204724 File Offset: 0x00202924
		public int FormulaParam4Length
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00204750 File Offset: 0x00202950
		public Span<int> GetFormulaParam4Bytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x00204760 File Offset: 0x00202960
		public int[] GetFormulaParam4Array()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00204778 File Offset: 0x00202978
		public int FormulaParam5(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06005B8F RID: 23439 RVA: 0x002047B8 File Offset: 0x002029B8
		public int FormulaParam5Length
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x002047E4 File Offset: 0x002029E4
		public Span<int> GetFormulaParam5Bytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x002047F4 File Offset: 0x002029F4
		public int[] GetFormulaParam5Array()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x0020480C File Offset: 0x00202A0C
		public int FormulaParam6(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06005B93 RID: 23443 RVA: 0x0020484C File Offset: 0x00202A4C
		public int FormulaParam6Length
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00204878 File Offset: 0x00202A78
		public Span<int> GetFormulaParam6Bytes()
		{
			return this.__p.__vector_as_span<int>(68, 4);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00204888 File Offset: 0x00202A88
		public int[] GetFormulaParam6Array()
		{
			return this.__p.__vector_as_array<int>(68) ?? Array.Empty<int>();
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x002048A0 File Offset: 0x00202AA0
		public int FormulaParam7(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x002048E0 File Offset: 0x00202AE0
		public int FormulaParam7Length
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x0020490C File Offset: 0x00202B0C
		public Span<int> GetFormulaParam7Bytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x0020491C File Offset: 0x00202B1C
		public int[] GetFormulaParam7Array()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x00204934 File Offset: 0x00202B34
		public int FormulaParam8(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06005B9B RID: 23451 RVA: 0x00204974 File Offset: 0x00202B74
		public int FormulaParam8Length
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x002049A0 File Offset: 0x00202BA0
		public Span<int> GetFormulaParam8Bytes()
		{
			return this.__p.__vector_as_span<int>(72, 4);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x002049B0 File Offset: 0x00202BB0
		public int[] GetFormulaParam8Array()
		{
			return this.__p.__vector_as_array<int>(72) ?? Array.Empty<int>();
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x002049C8 File Offset: 0x00202BC8
		public int FormulaParam9(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06005B9F RID: 23455 RVA: 0x00204A08 File Offset: 0x00202C08
		public int FormulaParam9Length
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00204A34 File Offset: 0x00202C34
		public Span<int> GetFormulaParam9Bytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00204A44 File Offset: 0x00202C44
		public int[] GetFormulaParam9Array()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00204A5C File Offset: 0x00202C5C
		public int FormulaParam10(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06005BA3 RID: 23459 RVA: 0x00204A9C File Offset: 0x00202C9C
		public int FormulaParam10Length
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00204AC8 File Offset: 0x00202CC8
		public Span<int> GetFormulaParam10Bytes()
		{
			return this.__p.__vector_as_span<int>(76, 4);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00204AD8 File Offset: 0x00202CD8
		public int[] GetFormulaParam10Array()
		{
			return this.__p.__vector_as_array<int>(76) ?? Array.Empty<int>();
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x00204AF0 File Offset: 0x00202CF0
		public int ImmuneType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00204B30 File Offset: 0x00202D30
		public int Percent0(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06005BA8 RID: 23464 RVA: 0x00204B70 File Offset: 0x00202D70
		public int Percent0Length
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00204B9C File Offset: 0x00202D9C
		public Span<int> GetPercent0Bytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00204BAC File Offset: 0x00202DAC
		public int[] GetPercent0Array()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00204BC4 File Offset: 0x00202DC4
		public int Percent1(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x00204C04 File Offset: 0x00202E04
		public int Percent1Length
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00204C30 File Offset: 0x00202E30
		public Span<int> GetPercent1Bytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00204C40 File Offset: 0x00202E40
		public int[] GetPercent1Array()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00204C58 File Offset: 0x00202E58
		public int FluctuationLower(int j)
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x00204C98 File Offset: 0x00202E98
		public int FluctuationLowerLength
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00204CC4 File Offset: 0x00202EC4
		public Span<int> GetFluctuationLowerBytes()
		{
			return this.__p.__vector_as_span<int>(84, 4);
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x00204CD4 File Offset: 0x00202ED4
		public int[] GetFluctuationLowerArray()
		{
			return this.__p.__vector_as_array<int>(84) ?? Array.Empty<int>();
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x00204CEC File Offset: 0x00202EEC
		public int FluctuationUpper(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x00204D2C File Offset: 0x00202F2C
		public int FluctuationUpperLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00204D58 File Offset: 0x00202F58
		public Span<int> GetFluctuationUpperBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00204D68 File Offset: 0x00202F68
		public int[] GetFluctuationUpperArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00204D80 File Offset: 0x00202F80
		public int WeaknessLvl(int j)
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x00204DC0 File Offset: 0x00202FC0
		public int WeaknessLvlLength
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00204DEC File Offset: 0x00202FEC
		public Span<int> GetWeaknessLvlBytes()
		{
			return this.__p.__vector_as_span<int>(88, 4);
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00204DFC File Offset: 0x00202FFC
		public int[] GetWeaknessLvlArray()
		{
			return this.__p.__vector_as_array<int>(88) ?? Array.Empty<int>();
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00204E14 File Offset: 0x00203014
		public DicIntInt? WeaknessRatio(int j)
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x00204E78 File Offset: 0x00203078
		public int WeaknessRatioLength
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06005BBD RID: 23485 RVA: 0x00204EA4 File Offset: 0x002030A4
		public int SpecialWeaknessDamageRatio
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00204EE4 File Offset: 0x002030E4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConstVariablesFrozenDict()缓存字典，遍历请使用ConstVariablesIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> ConstVariables()
		{
			return this.ConstVariablesIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00204F3A File Offset: 0x0020313A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> ConstVariablesIter()
		{
			Damage.<ConstVariablesIter>d__187 <ConstVariablesIter>d__ = new Damage.<ConstVariablesIter>d__187(-2);
			<ConstVariablesIter>d__.<>3__<>4__this = this;
			return <ConstVariablesIter>d__;
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x00204F50 File Offset: 0x00203150
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CureBaseValueIter()或GetCureBaseValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CureBaseValue()
		{
			Damage damage = this;
			return damage.GetCureBaseValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00204F74 File Offset: 0x00203174
		[NullableContext(1)]
		public readonly IEnumerable<int> CureBaseValueIter()
		{
			Damage.<CureBaseValueIter>d__189 <CureBaseValueIter>d__ = new Damage.<CureBaseValueIter>d__189(-2);
			<CureBaseValueIter>d__.<>3__<>4__this = this;
			return <CureBaseValueIter>d__;
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00204F8C File Offset: 0x0020318C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DyingIter()或GetDyingBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Dying()
		{
			Damage damage = this;
			return damage.GetDyingArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00204FB0 File Offset: 0x002031B0
		[NullableContext(1)]
		public readonly IEnumerable<int> DyingIter()
		{
			Damage.<DyingIter>d__191 <DyingIter>d__ = new Damage.<DyingIter>d__191(-2);
			<DyingIter>d__.<>3__<>4__this = this;
			return <DyingIter>d__;
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x00204FC8 File Offset: 0x002031C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementPowerIter()或GetElementPowerBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ElementPower()
		{
			Damage damage = this;
			return damage.GetElementPowerArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x00204FEC File Offset: 0x002031EC
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementPowerIter()
		{
			Damage.<ElementPowerIter>d__193 <ElementPowerIter>d__ = new Damage.<ElementPowerIter>d__193(-2);
			<ElementPowerIter>d__.<>3__<>4__this = this;
			return <ElementPowerIter>d__;
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x00205004 File Offset: 0x00203204
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnergyIter()或GetEnergyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Energy()
		{
			Damage damage = this;
			return damage.GetEnergyArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00205028 File Offset: 0x00203228
		[NullableContext(1)]
		public readonly IEnumerable<int> EnergyIter()
		{
			Damage.<EnergyIter>d__195 <EnergyIter>d__ = new Damage.<EnergyIter>d__195(-2);
			<EnergyIter>d__.<>3__<>4__this = this;
			return <EnergyIter>d__;
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00205040 File Offset: 0x00203240
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FluctuationLowerIter()或GetFluctuationLowerBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FluctuationLower()
		{
			Damage damage = this;
			return damage.GetFluctuationLowerArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00205064 File Offset: 0x00203264
		[NullableContext(1)]
		public readonly IEnumerable<int> FluctuationLowerIter()
		{
			Damage.<FluctuationLowerIter>d__197 <FluctuationLowerIter>d__ = new Damage.<FluctuationLowerIter>d__197(-2);
			<FluctuationLowerIter>d__.<>3__<>4__this = this;
			return <FluctuationLowerIter>d__;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x0020507C File Offset: 0x0020327C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FluctuationUpperIter()或GetFluctuationUpperBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FluctuationUpper()
		{
			Damage damage = this;
			return damage.GetFluctuationUpperArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x002050A0 File Offset: 0x002032A0
		[NullableContext(1)]
		public readonly IEnumerable<int> FluctuationUpperIter()
		{
			Damage.<FluctuationUpperIter>d__199 <FluctuationUpperIter>d__ = new Damage.<FluctuationUpperIter>d__199(-2);
			<FluctuationUpperIter>d__.<>3__<>4__this = this;
			return <FluctuationUpperIter>d__;
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x002050B8 File Offset: 0x002032B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam1Iter()或GetFormulaParam1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam1()
		{
			Damage damage = this;
			return damage.GetFormulaParam1Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x002050DC File Offset: 0x002032DC
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam1Iter()
		{
			Damage.<FormulaParam1Iter>d__201 <FormulaParam1Iter>d__ = new Damage.<FormulaParam1Iter>d__201(-2);
			<FormulaParam1Iter>d__.<>3__<>4__this = this;
			return <FormulaParam1Iter>d__;
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x002050F4 File Offset: 0x002032F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam10Iter()或GetFormulaParam10Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam10()
		{
			Damage damage = this;
			return damage.GetFormulaParam10Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x00205118 File Offset: 0x00203318
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam10Iter()
		{
			Damage.<FormulaParam10Iter>d__203 <FormulaParam10Iter>d__ = new Damage.<FormulaParam10Iter>d__203(-2);
			<FormulaParam10Iter>d__.<>3__<>4__this = this;
			return <FormulaParam10Iter>d__;
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x00205130 File Offset: 0x00203330
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam2Iter()或GetFormulaParam2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam2()
		{
			Damage damage = this;
			return damage.GetFormulaParam2Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x00205154 File Offset: 0x00203354
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam2Iter()
		{
			Damage.<FormulaParam2Iter>d__205 <FormulaParam2Iter>d__ = new Damage.<FormulaParam2Iter>d__205(-2);
			<FormulaParam2Iter>d__.<>3__<>4__this = this;
			return <FormulaParam2Iter>d__;
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x0020516C File Offset: 0x0020336C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam3Iter()或GetFormulaParam3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam3()
		{
			Damage damage = this;
			return damage.GetFormulaParam3Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00205190 File Offset: 0x00203390
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam3Iter()
		{
			Damage.<FormulaParam3Iter>d__207 <FormulaParam3Iter>d__ = new Damage.<FormulaParam3Iter>d__207(-2);
			<FormulaParam3Iter>d__.<>3__<>4__this = this;
			return <FormulaParam3Iter>d__;
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x002051A8 File Offset: 0x002033A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam4Iter()或GetFormulaParam4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam4()
		{
			Damage damage = this;
			return damage.GetFormulaParam4Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x002051CC File Offset: 0x002033CC
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam4Iter()
		{
			Damage.<FormulaParam4Iter>d__209 <FormulaParam4Iter>d__ = new Damage.<FormulaParam4Iter>d__209(-2);
			<FormulaParam4Iter>d__.<>3__<>4__this = this;
			return <FormulaParam4Iter>d__;
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x002051E4 File Offset: 0x002033E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam5Iter()或GetFormulaParam5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam5()
		{
			Damage damage = this;
			return damage.GetFormulaParam5Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x00205208 File Offset: 0x00203408
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam5Iter()
		{
			Damage.<FormulaParam5Iter>d__211 <FormulaParam5Iter>d__ = new Damage.<FormulaParam5Iter>d__211(-2);
			<FormulaParam5Iter>d__.<>3__<>4__this = this;
			return <FormulaParam5Iter>d__;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00205220 File Offset: 0x00203420
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam6Iter()或GetFormulaParam6Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam6()
		{
			Damage damage = this;
			return damage.GetFormulaParam6Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x00205244 File Offset: 0x00203444
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam6Iter()
		{
			Damage.<FormulaParam6Iter>d__213 <FormulaParam6Iter>d__ = new Damage.<FormulaParam6Iter>d__213(-2);
			<FormulaParam6Iter>d__.<>3__<>4__this = this;
			return <FormulaParam6Iter>d__;
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x0020525C File Offset: 0x0020345C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam7Iter()或GetFormulaParam7Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam7()
		{
			Damage damage = this;
			return damage.GetFormulaParam7Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x00205280 File Offset: 0x00203480
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam7Iter()
		{
			Damage.<FormulaParam7Iter>d__215 <FormulaParam7Iter>d__ = new Damage.<FormulaParam7Iter>d__215(-2);
			<FormulaParam7Iter>d__.<>3__<>4__this = this;
			return <FormulaParam7Iter>d__;
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00205298 File Offset: 0x00203498
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam8Iter()或GetFormulaParam8Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam8()
		{
			Damage damage = this;
			return damage.GetFormulaParam8Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x002052BC File Offset: 0x002034BC
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam8Iter()
		{
			Damage.<FormulaParam8Iter>d__217 <FormulaParam8Iter>d__ = new Damage.<FormulaParam8Iter>d__217(-2);
			<FormulaParam8Iter>d__.<>3__<>4__this = this;
			return <FormulaParam8Iter>d__;
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x002052D4 File Offset: 0x002034D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormulaParam9Iter()或GetFormulaParam9Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormulaParam9()
		{
			Damage damage = this;
			return damage.GetFormulaParam9Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x002052F8 File Offset: 0x002034F8
		[NullableContext(1)]
		public readonly IEnumerable<int> FormulaParam9Iter()
		{
			Damage.<FormulaParam9Iter>d__219 <FormulaParam9Iter>d__ = new Damage.<FormulaParam9Iter>d__219(-2);
			<FormulaParam9Iter>d__.<>3__<>4__this = this;
			return <FormulaParam9Iter>d__;
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x00205310 File Offset: 0x00203510
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HardnessLvIter()或GetHardnessLvBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HardnessLv()
		{
			Damage damage = this;
			return damage.GetHardnessLvArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x00205334 File Offset: 0x00203534
		[NullableContext(1)]
		public readonly IEnumerable<int> HardnessLvIter()
		{
			Damage.<HardnessLvIter>d__221 <HardnessLvIter>d__ = new Damage.<HardnessLvIter>d__221(-2);
			<HardnessLvIter>d__.<>3__<>4__this = this;
			return <HardnessLvIter>d__;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x0020534C File Offset: 0x0020354C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Percent0Iter()或GetPercent0Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Percent0()
		{
			Damage damage = this;
			return damage.GetPercent0Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x00205370 File Offset: 0x00203570
		[NullableContext(1)]
		public readonly IEnumerable<int> Percent0Iter()
		{
			Damage.<Percent0Iter>d__223 <Percent0Iter>d__ = new Damage.<Percent0Iter>d__223(-2);
			<Percent0Iter>d__.<>3__<>4__this = this;
			return <Percent0Iter>d__;
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00205388 File Offset: 0x00203588
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Percent1Iter()或GetPercent1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Percent1()
		{
			Damage damage = this;
			return damage.GetPercent1Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x002053AC File Offset: 0x002035AC
		[NullableContext(1)]
		public readonly IEnumerable<int> Percent1Iter()
		{
			Damage.<Percent1Iter>d__225 <Percent1Iter>d__ = new Damage.<Percent1Iter>d__225(-2);
			<Percent1Iter>d__.<>3__<>4__this = this;
			return <Percent1Iter>d__;
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x002053C4 File Offset: 0x002035C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RateLvIter()或GetRateLvBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RateLv()
		{
			Damage damage = this;
			return damage.GetRateLvArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x002053E8 File Offset: 0x002035E8
		[NullableContext(1)]
		public readonly IEnumerable<int> RateLvIter()
		{
			Damage.<RateLvIter>d__227 <RateLvIter>d__ = new Damage.<RateLvIter>d__227(-2);
			<RateLvIter>d__.<>3__<>4__this = this;
			return <RateLvIter>d__;
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00205400 File Offset: 0x00203600
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialEnergy1Iter()或GetSpecialEnergy1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialEnergy1()
		{
			Damage damage = this;
			return damage.GetSpecialEnergy1Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00205424 File Offset: 0x00203624
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialEnergy1Iter()
		{
			Damage.<SpecialEnergy1Iter>d__229 <SpecialEnergy1Iter>d__ = new Damage.<SpecialEnergy1Iter>d__229(-2);
			<SpecialEnergy1Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy1Iter>d__;
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x0020543C File Offset: 0x0020363C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialEnergy2Iter()或GetSpecialEnergy2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialEnergy2()
		{
			Damage damage = this;
			return damage.GetSpecialEnergy2Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x00205460 File Offset: 0x00203660
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialEnergy2Iter()
		{
			Damage.<SpecialEnergy2Iter>d__231 <SpecialEnergy2Iter>d__ = new Damage.<SpecialEnergy2Iter>d__231(-2);
			<SpecialEnergy2Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy2Iter>d__;
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00205478 File Offset: 0x00203678
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialEnergy3Iter()或GetSpecialEnergy3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialEnergy3()
		{
			Damage damage = this;
			return damage.GetSpecialEnergy3Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x0020549C File Offset: 0x0020369C
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialEnergy3Iter()
		{
			Damage.<SpecialEnergy3Iter>d__233 <SpecialEnergy3Iter>d__ = new Damage.<SpecialEnergy3Iter>d__233(-2);
			<SpecialEnergy3Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy3Iter>d__;
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x002054B4 File Offset: 0x002036B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialEnergy4Iter()或GetSpecialEnergy4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialEnergy4()
		{
			Damage damage = this;
			return damage.GetSpecialEnergy4Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x002054D8 File Offset: 0x002036D8
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialEnergy4Iter()
		{
			Damage.<SpecialEnergy4Iter>d__235 <SpecialEnergy4Iter>d__ = new Damage.<SpecialEnergy4Iter>d__235(-2);
			<SpecialEnergy4Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy4Iter>d__;
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x002054F0 File Offset: 0x002036F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialEnergy5Iter()或GetSpecialEnergy5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialEnergy5()
		{
			Damage damage = this;
			return damage.GetSpecialEnergy5Array() ?? Array.Empty<int>();
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x00205514 File Offset: 0x00203714
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialEnergy5Iter()
		{
			Damage.<SpecialEnergy5Iter>d__237 <SpecialEnergy5Iter>d__ = new Damage.<SpecialEnergy5Iter>d__237(-2);
			<SpecialEnergy5Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy5Iter>d__;
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x0020552C File Offset: 0x0020372C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubTypeIter()或GetSubTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubType()
		{
			Damage damage = this;
			return damage.GetSubTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00205550 File Offset: 0x00203750
		[NullableContext(1)]
		public readonly IEnumerable<int> SubTypeIter()
		{
			Damage.<SubTypeIter>d__239 <SubTypeIter>d__ = new Damage.<SubTypeIter>d__239(-2);
			<SubTypeIter>d__.<>3__<>4__this = this;
			return <SubTypeIter>d__;
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x00205568 File Offset: 0x00203768
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ToughLvIter()或GetToughLvBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ToughLv()
		{
			Damage damage = this;
			return damage.GetToughLvArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x0020558C File Offset: 0x0020378C
		[NullableContext(1)]
		public readonly IEnumerable<int> ToughLvIter()
		{
			Damage.<ToughLvIter>d__241 <ToughLvIter>d__ = new Damage.<ToughLvIter>d__241(-2);
			<ToughLvIter>d__.<>3__<>4__this = this;
			return <ToughLvIter>d__;
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x002055A4 File Offset: 0x002037A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaknessLvlIter()或GetWeaknessLvlBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaknessLvl()
		{
			Damage damage = this;
			return damage.GetWeaknessLvlArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x002055C8 File Offset: 0x002037C8
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaknessLvlIter()
		{
			Damage.<WeaknessLvlIter>d__243 <WeaknessLvlIter>d__ = new Damage.<WeaknessLvlIter>d__243(-2);
			<WeaknessLvlIter>d__.<>3__<>4__this = this;
			return <WeaknessLvlIter>d__;
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x002055E0 File Offset: 0x002037E0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeaknessRatioFrozenDict()缓存字典，遍历请使用WeaknessRatioIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WeaknessRatio()
		{
			return this.WeaknessRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x00205636 File Offset: 0x00203836
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WeaknessRatioIter()
		{
			Damage.<WeaknessRatioIter>d__245 <WeaknessRatioIter>d__ = new Damage.<WeaknessRatioIter>d__245(-2);
			<WeaknessRatioIter>d__.<>3__<>4__this = this;
			return <WeaknessRatioIter>d__;
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x0020564C File Offset: 0x0020384C
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetConstVariables(string key)
		{
			this.EnsureConstVariablesCacheIfNeeded();
			string result;
			if (!this.ConstVariablesCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x00205674 File Offset: 0x00203874
		public int? GetWeaknessRatio(int key)
		{
			this.EnsureWeaknessRatioCacheIfNeeded();
			int value;
			if (!this.WeaknessRatioCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x002056A8 File Offset: 0x002038A8
		private void EnsureConstVariablesCacheIfNeeded()
		{
			if (this.ConstVariablesCache != null)
			{
				return;
			}
			this.ConstVariablesCache = this.ConstVariablesIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00205710 File Offset: 0x00203910
		private void EnsureWeaknessRatioCacheIfNeeded()
		{
			if (this.WeaknessRatioCache != null)
			{
				return;
			}
			this.WeaknessRatioCache = this.WeaknessRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x00205776 File Offset: 0x00203976
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetConstVariablesFrozenDict(string key)
		{
			this.EnsureConstVariablesCacheIfNeeded();
			return this.ConstVariablesCache;
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x00205784 File Offset: 0x00203984
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWeaknessRatioFrozenDict(int key)
		{
			this.EnsureWeaknessRatioCacheIfNeeded();
			return this.WeaknessRatioCache;
		}

		// Token: 0x04004BDB RID: 19419
		private Table __p;

		// Token: 0x04004BDC RID: 19420
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ConstVariablesCache;

		// Token: 0x04004BDD RID: 19421
		[Nullable(2)]
		private FrozenDictionary<int, int> WeaknessRatioCache;
	}
}

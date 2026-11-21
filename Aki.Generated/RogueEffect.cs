using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C7 RID: 4295
	public struct RogueEffect : IFlatbufferObject
	{
		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600C52D RID: 50477 RVA: 0x00300D5A File Offset: 0x002FEF5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x00300D67 File Offset: 0x002FEF67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x00300D70 File Offset: 0x002FEF70
		public static RogueEffect GetRootAsRogueEffect(ByteBuffer _bb)
		{
			return RogueEffect.GetRootAsRogueEffect(_bb, default(RogueEffect));
		}

		// Token: 0x0600C530 RID: 50480 RVA: 0x00300D8C File Offset: 0x002FEF8C
		public static RogueEffect GetRootAsRogueEffect(ByteBuffer _bb, RogueEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C531 RID: 50481 RVA: 0x00300DA9 File Offset: 0x002FEFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C532 RID: 50482 RVA: 0x00300DB8 File Offset: 0x002FEFB8
		public RogueEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600C533 RID: 50483 RVA: 0x00300DC8 File Offset: 0x002FEFC8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600C534 RID: 50484 RVA: 0x00300E04 File Offset: 0x002FF004
		public int MainEffectType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600C535 RID: 50485 RVA: 0x00300E40 File Offset: 0x002FF040
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x00300E7C File Offset: 0x002FF07C
		public int ConditionArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600C537 RID: 50487 RVA: 0x00300EBC File Offset: 0x002FF0BC
		public int ConditionArgsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C538 RID: 50488 RVA: 0x00300EE8 File Offset: 0x002FF0E8
		public Span<int> GetConditionArgsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x00300EF8 File Offset: 0x002FF0F8
		public int[] GetConditionArgsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600C53A RID: 50490 RVA: 0x00300F10 File Offset: 0x002FF110
		public int Count
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

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600C53B RID: 50491 RVA: 0x00300F50 File Offset: 0x002FF150
		public int RoomCount
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

		// Token: 0x0600C53C RID: 50492 RVA: 0x00300F90 File Offset: 0x002FF190
		public long BuffArray1(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600C53D RID: 50493 RVA: 0x00300FDC File Offset: 0x002FF1DC
		public int BuffArray1Length
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x00301008 File Offset: 0x002FF208
		public Span<long> GetBuffArray1Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x0030101D File Offset: 0x002FF21D
		public long[] GetBuffArray1Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x0030105C File Offset: 0x002FF25C
		public string ExtraEffectTypeArray1(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600C541 RID: 50497 RVA: 0x00301098 File Offset: 0x002FF298
		public int ExtraEffectTypeArray1Length
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x003010C4 File Offset: 0x002FF2C4
		public string ExtraEffectTypeArgsArray1(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0600C543 RID: 50499 RVA: 0x00301100 File Offset: 0x002FF300
		public int ExtraEffectTypeArgsArray1Length
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x0030112C File Offset: 0x002FF32C
		public long BuffArray2(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x00301178 File Offset: 0x002FF378
		public int BuffArray2Length
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x003011A4 File Offset: 0x002FF3A4
		public Span<long> GetBuffArray2Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x003011B9 File Offset: 0x002FF3B9
		public long[] GetBuffArray2Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x003011F8 File Offset: 0x002FF3F8
		public string ExtraEffectTypeArray2(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600C549 RID: 50505 RVA: 0x00301234 File Offset: 0x002FF434
		public int ExtraEffectTypeArray2Length
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

		// Token: 0x0600C54A RID: 50506 RVA: 0x00301260 File Offset: 0x002FF460
		public string ExtraEffectTypeArgsArray2(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600C54B RID: 50507 RVA: 0x0030129C File Offset: 0x002FF49C
		public int ExtraEffectTypeArgsArray2Length
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x003012C8 File Offset: 0x002FF4C8
		[NullableContext(1)]
		public long[] BuffArray1()
		{
			return this.GetBuffArray1Array();
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x003012D0 File Offset: 0x002FF4D0
		[NullableContext(1)]
		public IEnumerable<long> BuffArray1Iter()
		{
			RogueEffect.<BuffArray1Iter>d__46 <BuffArray1Iter>d__ = new RogueEffect.<BuffArray1Iter>d__46(-2);
			<BuffArray1Iter>d__.<>3__<>4__this = this;
			return <BuffArray1Iter>d__;
		}

		// Token: 0x0600C54E RID: 50510 RVA: 0x003012E5 File Offset: 0x002FF4E5
		[NullableContext(1)]
		public long[] BuffArray2()
		{
			return this.GetBuffArray2Array();
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x003012ED File Offset: 0x002FF4ED
		[NullableContext(1)]
		public IEnumerable<long> BuffArray2Iter()
		{
			RogueEffect.<BuffArray2Iter>d__48 <BuffArray2Iter>d__ = new RogueEffect.<BuffArray2Iter>d__48(-2);
			<BuffArray2Iter>d__.<>3__<>4__this = this;
			return <BuffArray2Iter>d__;
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x00301302 File Offset: 0x002FF502
		[NullableContext(1)]
		public int[] ConditionArgs()
		{
			return this.GetConditionArgsArray();
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x0030130A File Offset: 0x002FF50A
		[NullableContext(1)]
		public IEnumerable<int> ConditionArgsIter()
		{
			RogueEffect.<ConditionArgsIter>d__50 <ConditionArgsIter>d__ = new RogueEffect.<ConditionArgsIter>d__50(-2);
			<ConditionArgsIter>d__.<>3__<>4__this = this;
			return <ConditionArgsIter>d__;
		}

		// Token: 0x0600C552 RID: 50514 RVA: 0x0030131F File Offset: 0x002FF51F
		[NullableContext(1)]
		public string[] ExtraEffectTypeArgsArray1()
		{
			return this.ExtraEffectTypeArgsArray1Iter().ToArray<string>();
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x0030132C File Offset: 0x002FF52C
		[NullableContext(1)]
		public IEnumerable<string> ExtraEffectTypeArgsArray1Iter()
		{
			RogueEffect.<ExtraEffectTypeArgsArray1Iter>d__52 <ExtraEffectTypeArgsArray1Iter>d__ = new RogueEffect.<ExtraEffectTypeArgsArray1Iter>d__52(-2);
			<ExtraEffectTypeArgsArray1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArgsArray1Iter>d__;
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x00301341 File Offset: 0x002FF541
		[NullableContext(1)]
		public string[] ExtraEffectTypeArgsArray2()
		{
			return this.ExtraEffectTypeArgsArray2Iter().ToArray<string>();
		}

		// Token: 0x0600C555 RID: 50517 RVA: 0x0030134E File Offset: 0x002FF54E
		[NullableContext(1)]
		public IEnumerable<string> ExtraEffectTypeArgsArray2Iter()
		{
			RogueEffect.<ExtraEffectTypeArgsArray2Iter>d__54 <ExtraEffectTypeArgsArray2Iter>d__ = new RogueEffect.<ExtraEffectTypeArgsArray2Iter>d__54(-2);
			<ExtraEffectTypeArgsArray2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArgsArray2Iter>d__;
		}

		// Token: 0x0600C556 RID: 50518 RVA: 0x00301363 File Offset: 0x002FF563
		[NullableContext(1)]
		public string[] ExtraEffectTypeArray1()
		{
			return this.ExtraEffectTypeArray1Iter().ToArray<string>();
		}

		// Token: 0x0600C557 RID: 50519 RVA: 0x00301370 File Offset: 0x002FF570
		[NullableContext(1)]
		public IEnumerable<string> ExtraEffectTypeArray1Iter()
		{
			RogueEffect.<ExtraEffectTypeArray1Iter>d__56 <ExtraEffectTypeArray1Iter>d__ = new RogueEffect.<ExtraEffectTypeArray1Iter>d__56(-2);
			<ExtraEffectTypeArray1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArray1Iter>d__;
		}

		// Token: 0x0600C558 RID: 50520 RVA: 0x00301385 File Offset: 0x002FF585
		[NullableContext(1)]
		public string[] ExtraEffectTypeArray2()
		{
			return this.ExtraEffectTypeArray2Iter().ToArray<string>();
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x00301392 File Offset: 0x002FF592
		[NullableContext(1)]
		public IEnumerable<string> ExtraEffectTypeArray2Iter()
		{
			RogueEffect.<ExtraEffectTypeArray2Iter>d__58 <ExtraEffectTypeArray2Iter>d__ = new RogueEffect.<ExtraEffectTypeArray2Iter>d__58(-2);
			<ExtraEffectTypeArray2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArray2Iter>d__;
		}

		// Token: 0x040056A4 RID: 22180
		private Table __p;
	}
}

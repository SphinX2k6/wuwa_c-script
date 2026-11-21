using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F25 RID: 3877
	public struct MotorFightBuffGate : IFlatbufferObject
	{
		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x002ABDD1 File Offset: 0x002A9FD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x002ABDDE File Offset: 0x002A9FDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x002ABDE8 File Offset: 0x002A9FE8
		public static MotorFightBuffGate GetRootAsMotorFightBuffGate(ByteBuffer _bb)
		{
			return MotorFightBuffGate.GetRootAsMotorFightBuffGate(_bb, default(MotorFightBuffGate));
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x002ABE04 File Offset: 0x002AA004
		public static MotorFightBuffGate GetRootAsMotorFightBuffGate(ByteBuffer _bb, MotorFightBuffGate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x002ABE21 File Offset: 0x002AA021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x002ABE30 File Offset: 0x002AA030
		public MotorFightBuffGate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06009E2C RID: 40492 RVA: 0x002ABE40 File Offset: 0x002AA040
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

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06009E2D RID: 40493 RVA: 0x002ABE7C File Offset: 0x002AA07C
		public int GateTemptId
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

		// Token: 0x06009E2E RID: 40494 RVA: 0x002ABEB8 File Offset: 0x002AA0B8
		public int BuffEffect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06009E2F RID: 40495 RVA: 0x002ABEF8 File Offset: 0x002AA0F8
		public int BuffEffectLength
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

		// Token: 0x06009E30 RID: 40496 RVA: 0x002ABF23 File Offset: 0x002AA123
		public Span<int> GetBuffEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x002ABF32 File Offset: 0x002AA132
		public int[] GetBuffEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x002ABF4C File Offset: 0x002AA14C
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x002ABF8C File Offset: 0x002AA18C
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x002ABFCC File Offset: 0x002AA1CC
		public int BornBuffLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x002ABFF8 File Offset: 0x002AA1F8
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x002AC008 File Offset: 0x002AA208
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x002AC020 File Offset: 0x002AA220
		public string DetailDesc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E38 RID: 40504 RVA: 0x002AC058 File Offset: 0x002AA258
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009E39 RID: 40505 RVA: 0x002AC068 File Offset: 0x002AA268
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x002AC080 File Offset: 0x002AA280
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x002AC0B8 File Offset: 0x002AA2B8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x002AC0C8 File Offset: 0x002AA2C8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x002AC0E0 File Offset: 0x002AA2E0
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x002AC11C File Offset: 0x002AA31C
		public int DescArgsLength
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

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06009E3F RID: 40511 RVA: 0x002AC148 File Offset: 0x002AA348
		public int AffectedByRate
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06009E40 RID: 40512 RVA: 0x002AC188 File Offset: 0x002AA388
		public int Type
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x002AC1C8 File Offset: 0x002AA3C8
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x002AC205 File Offset: 0x002AA405
		[NullableContext(1)]
		public int[] BornBuff()
		{
			return this.GetBornBuffArray();
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x002AC20D File Offset: 0x002AA40D
		[NullableContext(1)]
		public IEnumerable<int> BornBuffIter()
		{
			MotorFightBuffGate.<BornBuffIter>d__42 <BornBuffIter>d__ = new MotorFightBuffGate.<BornBuffIter>d__42(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x002AC222 File Offset: 0x002AA422
		[NullableContext(1)]
		public int[] BuffEffect()
		{
			return this.GetBuffEffectArray();
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x002AC22A File Offset: 0x002AA42A
		[NullableContext(1)]
		public IEnumerable<int> BuffEffectIter()
		{
			MotorFightBuffGate.<BuffEffectIter>d__44 <BuffEffectIter>d__ = new MotorFightBuffGate.<BuffEffectIter>d__44(-2);
			<BuffEffectIter>d__.<>3__<>4__this = this;
			return <BuffEffectIter>d__;
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x002AC23F File Offset: 0x002AA43F
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x002AC24C File Offset: 0x002AA44C
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			MotorFightBuffGate.<DescArgsIter>d__46 <DescArgsIter>d__ = new MotorFightBuffGate.<DescArgsIter>d__46(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x040054CD RID: 21709
		private Table __p;
	}
}

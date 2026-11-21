using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128F RID: 4751
	public struct TrapDefenseBdBuff : IFlatbufferObject
	{
		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0600F00B RID: 61451 RVA: 0x00361900 File Offset: 0x0035FB00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F00C RID: 61452 RVA: 0x0036190D File Offset: 0x0035FB0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F00D RID: 61453 RVA: 0x00361914 File Offset: 0x0035FB14
		public static TrapDefenseBdBuff GetRootAsTrapDefenseBdBuff(ByteBuffer _bb)
		{
			return TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(_bb, default(TrapDefenseBdBuff));
		}

		// Token: 0x0600F00E RID: 61454 RVA: 0x00361930 File Offset: 0x0035FB30
		public static TrapDefenseBdBuff GetRootAsTrapDefenseBdBuff(ByteBuffer _bb, TrapDefenseBdBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F00F RID: 61455 RVA: 0x0036194D File Offset: 0x0035FB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F010 RID: 61456 RVA: 0x0036195C File Offset: 0x0035FB5C
		public TrapDefenseBdBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0600F011 RID: 61457 RVA: 0x0036196C File Offset: 0x0035FB6C
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

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0600F012 RID: 61458 RVA: 0x003619A8 File Offset: 0x0035FBA8
		public int Level
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

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0600F013 RID: 61459 RVA: 0x003619E4 File Offset: 0x0035FBE4
		public int GroupId
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

		// Token: 0x0600F014 RID: 61460 RVA: 0x00361A20 File Offset: 0x0035FC20
		public int Gainings(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0600F015 RID: 61461 RVA: 0x00361A60 File Offset: 0x0035FC60
		public int GainingsLength
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

		// Token: 0x0600F016 RID: 61462 RVA: 0x00361A8C File Offset: 0x0035FC8C
		public Span<int> GetGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600F017 RID: 61463 RVA: 0x00361A9C File Offset: 0x0035FC9C
		public int[] GetGainingsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0600F018 RID: 61464 RVA: 0x00361AB4 File Offset: 0x0035FCB4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F019 RID: 61465 RVA: 0x00361AEC File Offset: 0x0035FCEC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F01A RID: 61466 RVA: 0x00361AFC File Offset: 0x0035FCFC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x0600F01B RID: 61467 RVA: 0x00361B14 File Offset: 0x0035FD14
		public string Desc
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

		// Token: 0x0600F01C RID: 61468 RVA: 0x00361B4C File Offset: 0x0035FD4C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F01D RID: 61469 RVA: 0x00361B5C File Offset: 0x0035FD5C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F01E RID: 61470 RVA: 0x00361B74 File Offset: 0x0035FD74
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x0600F01F RID: 61471 RVA: 0x00361BB0 File Offset: 0x0035FDB0
		public int DescArgsLength
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

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0600F020 RID: 61472 RVA: 0x00361BDC File Offset: 0x0035FDDC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F021 RID: 61473 RVA: 0x00361C14 File Offset: 0x0035FE14
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F022 RID: 61474 RVA: 0x00361C24 File Offset: 0x0035FE24
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0600F023 RID: 61475 RVA: 0x00361C3C File Offset: 0x0035FE3C
		public string SubIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F024 RID: 61476 RVA: 0x00361C74 File Offset: 0x0035FE74
		public Span<byte> GetSubIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F025 RID: 61477 RVA: 0x00361C84 File Offset: 0x0035FE84
		public byte[] GetSubIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F026 RID: 61478 RVA: 0x00361C9C File Offset: 0x0035FE9C
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600F027 RID: 61479 RVA: 0x00361CA9 File Offset: 0x0035FEA9
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			TrapDefenseBdBuff.<DescArgsIter>d__39 <DescArgsIter>d__ = new TrapDefenseBdBuff.<DescArgsIter>d__39(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600F028 RID: 61480 RVA: 0x00361CBE File Offset: 0x0035FEBE
		[NullableContext(1)]
		public int[] Gainings()
		{
			return this.GetGainingsArray();
		}

		// Token: 0x0600F029 RID: 61481 RVA: 0x00361CC6 File Offset: 0x0035FEC6
		[NullableContext(1)]
		public IEnumerable<int> GainingsIter()
		{
			TrapDefenseBdBuff.<GainingsIter>d__41 <GainingsIter>d__ = new TrapDefenseBdBuff.<GainingsIter>d__41(-2);
			<GainingsIter>d__.<>3__<>4__this = this;
			return <GainingsIter>d__;
		}

		// Token: 0x040058E1 RID: 22753
		private Table __p;
	}
}

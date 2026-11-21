using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE4 RID: 3812
	public struct MatchThreeGoal : IFlatbufferObject
	{
		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x060098F4 RID: 39156 RVA: 0x002A07E8 File Offset: 0x0029E9E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x002A07F5 File Offset: 0x0029E9F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x002A07FC File Offset: 0x0029E9FC
		public static MatchThreeGoal GetRootAsMatchThreeGoal(ByteBuffer _bb)
		{
			return MatchThreeGoal.GetRootAsMatchThreeGoal(_bb, default(MatchThreeGoal));
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x002A0818 File Offset: 0x0029EA18
		public static MatchThreeGoal GetRootAsMatchThreeGoal(ByteBuffer _bb, MatchThreeGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x002A0835 File Offset: 0x0029EA35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x002A0844 File Offset: 0x0029EA44
		public MatchThreeGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x060098FA RID: 39162 RVA: 0x002A0854 File Offset: 0x0029EA54
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

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x060098FB RID: 39163 RVA: 0x002A0890 File Offset: 0x0029EA90
		public int CondType
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

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x002A08CC File Offset: 0x0029EACC
		public string CondDesc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x002A0903 File Offset: 0x0029EB03
		public Span<byte> GetCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x002A0912 File Offset: 0x0029EB12
		public byte[] GetCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x002A092C File Offset: 0x0029EB2C
		public int Params(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06009900 RID: 39168 RVA: 0x002A096C File Offset: 0x0029EB6C
		public int ParamsLength
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

		// Token: 0x06009901 RID: 39169 RVA: 0x002A0998 File Offset: 0x0029EB98
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x002A09A8 File Offset: 0x0029EBA8
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x002A09C0 File Offset: 0x0029EBC0
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x002A09C8 File Offset: 0x0029EBC8
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			MatchThreeGoal.<ParamsIter>d__22 <ParamsIter>d__ = new MatchThreeGoal.<ParamsIter>d__22(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005485 RID: 21637
		private Table __p;
	}
}

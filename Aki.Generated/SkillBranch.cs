using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B6 RID: 4278
	public struct SkillBranch : IFlatbufferObject
	{
		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600D331 RID: 54065 RVA: 0x00312499 File Offset: 0x00310699
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D332 RID: 54066 RVA: 0x003124A6 File Offset: 0x003106A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D333 RID: 54067 RVA: 0x003124B0 File Offset: 0x003106B0
		public static SkillBranch GetRootAsSkillBranch(ByteBuffer _bb)
		{
			return SkillBranch.GetRootAsSkillBranch(_bb, default(SkillBranch));
		}

		// Token: 0x0600D334 RID: 54068 RVA: 0x003124CC File Offset: 0x003106CC
		public static SkillBranch GetRootAsSkillBranch(ByteBuffer _bb, SkillBranch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D335 RID: 54069 RVA: 0x003124E9 File Offset: 0x003106E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D336 RID: 54070 RVA: 0x003124F8 File Offset: 0x003106F8
		public SkillBranch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600D337 RID: 54071 RVA: 0x00312508 File Offset: 0x00310708
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

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600D338 RID: 54072 RVA: 0x00312544 File Offset: 0x00310744
		public string Name
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

		// Token: 0x0600D339 RID: 54073 RVA: 0x0031257B File Offset: 0x0031077B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D33A RID: 54074 RVA: 0x0031258A File Offset: 0x0031078A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600D33B RID: 54075 RVA: 0x003125A4 File Offset: 0x003107A4
		public string Icon
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

		// Token: 0x0600D33C RID: 54076 RVA: 0x003125DB File Offset: 0x003107DB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x003125EA File Offset: 0x003107EA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600D33E RID: 54078 RVA: 0x00312604 File Offset: 0x00310804
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x0031263C File Offset: 0x0031083C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x0031264C File Offset: 0x0031084C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051CB RID: 20939
		private Table __p;
	}
}

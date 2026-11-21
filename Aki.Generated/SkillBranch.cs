using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B1 RID: 4529
	public struct SkillBranch : IFlatbufferObject
	{
		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600DB0E RID: 56078 RVA: 0x00331959 File Offset: 0x0032FB59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00331966 File Offset: 0x0032FB66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00331970 File Offset: 0x0032FB70
		public static SkillBranch GetRootAsSkillBranch(ByteBuffer _bb)
		{
			return SkillBranch.GetRootAsSkillBranch(_bb, default(SkillBranch));
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x0033198C File Offset: 0x0032FB8C
		public static SkillBranch GetRootAsSkillBranch(ByteBuffer _bb, SkillBranch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x003319A9 File Offset: 0x0032FBA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x003319B8 File Offset: 0x0032FBB8
		public SkillBranch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x003319C8 File Offset: 0x0032FBC8
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

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600DB15 RID: 56085 RVA: 0x00331A04 File Offset: 0x0032FC04
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

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00331A3B File Offset: 0x0032FC3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00331A4A File Offset: 0x0032FC4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600DB18 RID: 56088 RVA: 0x00331A64 File Offset: 0x0032FC64
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

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00331A9B File Offset: 0x0032FC9B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00331AAA File Offset: 0x0032FCAA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600DB1B RID: 56091 RVA: 0x00331AC4 File Offset: 0x0032FCC4
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

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00331AFC File Offset: 0x0032FCFC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x00331B0C File Offset: 0x0032FD0C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040057CA RID: 22474
		private Table __p;
	}
}

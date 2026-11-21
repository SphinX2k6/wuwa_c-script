using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFB RID: 3835
	public struct MonsterHandBookType : IFlatbufferObject
	{
		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06009B34 RID: 39732 RVA: 0x002A5809 File Offset: 0x002A3A09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x002A5816 File Offset: 0x002A3A16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x002A5820 File Offset: 0x002A3A20
		public static MonsterHandBookType GetRootAsMonsterHandBookType(ByteBuffer _bb)
		{
			return MonsterHandBookType.GetRootAsMonsterHandBookType(_bb, default(MonsterHandBookType));
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x002A583C File Offset: 0x002A3A3C
		public static MonsterHandBookType GetRootAsMonsterHandBookType(ByteBuffer _bb, MonsterHandBookType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x002A5859 File Offset: 0x002A3A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x002A5868 File Offset: 0x002A3A68
		public MonsterHandBookType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06009B3A RID: 39738 RVA: 0x002A5878 File Offset: 0x002A3A78
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

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x002A58B4 File Offset: 0x002A3AB4
		public string Descrtption
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

		// Token: 0x06009B3C RID: 39740 RVA: 0x002A58EB File Offset: 0x002A3AEB
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x002A58FA File Offset: 0x002A3AFA
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A0 RID: 21664
		private Table __p;
	}
}

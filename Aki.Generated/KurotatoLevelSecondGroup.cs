using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8B RID: 3723
	public struct KurotatoLevelSecondGroup : IFlatbufferObject
	{
		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x0028EB30 File Offset: 0x0028CD30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0028EB3D File Offset: 0x0028CD3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x0028EB44 File Offset: 0x0028CD44
		public static KurotatoLevelSecondGroup GetRootAsKurotatoLevelSecondGroup(ByteBuffer _bb)
		{
			return KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(_bb, default(KurotatoLevelSecondGroup));
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x0028EB60 File Offset: 0x0028CD60
		public static KurotatoLevelSecondGroup GetRootAsKurotatoLevelSecondGroup(ByteBuffer _bb, KurotatoLevelSecondGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x0028EB7D File Offset: 0x0028CD7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x0028EB8C File Offset: 0x0028CD8C
		public KurotatoLevelSecondGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x060090A2 RID: 37026 RVA: 0x0028EB9C File Offset: 0x0028CD9C
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

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x060090A3 RID: 37027 RVA: 0x0028EBD8 File Offset: 0x0028CDD8
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

		// Token: 0x060090A4 RID: 37028 RVA: 0x0028EC0F File Offset: 0x0028CE0F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x0028EC1E File Offset: 0x0028CE1E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x0028EC38 File Offset: 0x0028CE38
		public string TitleBg
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

		// Token: 0x060090A7 RID: 37031 RVA: 0x0028EC6F File Offset: 0x0028CE6F
		public Span<byte> GetTitleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0028EC7E File Offset: 0x0028CE7E
		public byte[] GetTitleBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400541D RID: 21533
		private Table __p;
	}
}

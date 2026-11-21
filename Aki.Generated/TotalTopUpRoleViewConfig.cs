using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001267 RID: 4711
	public struct TotalTopUpRoleViewConfig : IFlatbufferObject
	{
		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x00359E66 File Offset: 0x00358066
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC91 RID: 60561 RVA: 0x00359E73 File Offset: 0x00358073
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC92 RID: 60562 RVA: 0x00359E7C File Offset: 0x0035807C
		public static TotalTopUpRoleViewConfig GetRootAsTotalTopUpRoleViewConfig(ByteBuffer _bb)
		{
			return TotalTopUpRoleViewConfig.GetRootAsTotalTopUpRoleViewConfig(_bb, default(TotalTopUpRoleViewConfig));
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x00359E98 File Offset: 0x00358098
		public static TotalTopUpRoleViewConfig GetRootAsTotalTopUpRoleViewConfig(ByteBuffer _bb, TotalTopUpRoleViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x00359EB5 File Offset: 0x003580B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x00359EC4 File Offset: 0x003580C4
		public TotalTopUpRoleViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600EC96 RID: 60566 RVA: 0x00359ED4 File Offset: 0x003580D4
		public int ItemId
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

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600EC97 RID: 60567 RVA: 0x00359F10 File Offset: 0x00358110
		public string SpinePrefabResource
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

		// Token: 0x0600EC98 RID: 60568 RVA: 0x00359F47 File Offset: 0x00358147
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EC99 RID: 60569 RVA: 0x00359F56 File Offset: 0x00358156
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600EC9A RID: 60570 RVA: 0x00359F70 File Offset: 0x00358170
		public string TexturePath
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

		// Token: 0x0600EC9B RID: 60571 RVA: 0x00359FA7 File Offset: 0x003581A7
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x00359FB6 File Offset: 0x003581B6
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600EC9D RID: 60573 RVA: 0x00359FD0 File Offset: 0x003581D0
		public string RoleBackgroundPath
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

		// Token: 0x0600EC9E RID: 60574 RVA: 0x0035A008 File Offset: 0x00358208
		public Span<byte> GetRoleBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EC9F RID: 60575 RVA: 0x0035A018 File Offset: 0x00358218
		public byte[] GetRoleBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058B5 RID: 22709
		private Table __p;
	}
}

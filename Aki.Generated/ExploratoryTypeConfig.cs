using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2C RID: 3372
	public struct ExploratoryTypeConfig : IFlatbufferObject
	{
		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x0024644E File Offset: 0x0024464E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0024645B File Offset: 0x0024465B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x00246464 File Offset: 0x00244664
		public static ExploratoryTypeConfig GetRootAsExploratoryTypeConfig(ByteBuffer _bb)
		{
			return ExploratoryTypeConfig.GetRootAsExploratoryTypeConfig(_bb, default(ExploratoryTypeConfig));
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x00246480 File Offset: 0x00244680
		public static ExploratoryTypeConfig GetRootAsExploratoryTypeConfig(ByteBuffer _bb, ExploratoryTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0024649D File Offset: 0x0024469D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x002464AC File Offset: 0x002446AC
		public ExploratoryTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060070F5 RID: 28917 RVA: 0x002464BC File Offset: 0x002446BC
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x002464F8 File Offset: 0x002446F8
		public int Key
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060070F7 RID: 28919 RVA: 0x00246534 File Offset: 0x00244734
		public string Name
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

		// Token: 0x060070F8 RID: 28920 RVA: 0x0024656B File Offset: 0x0024476B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0024657A File Offset: 0x0024477A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x060070FA RID: 28922 RVA: 0x00246594 File Offset: 0x00244794
		public int BelongType
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

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x060070FB RID: 28923 RVA: 0x002465D4 File Offset: 0x002447D4
		public string Desc
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

		// Token: 0x060070FC RID: 28924 RVA: 0x0024660C File Offset: 0x0024480C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x0024661C File Offset: 0x0024481C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005271 RID: 21105
		private Table __p;
	}
}

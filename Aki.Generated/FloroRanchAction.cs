using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9D RID: 3229
	public struct FloroRanchAction : IFlatbufferObject
	{
		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060071F8 RID: 29176 RVA: 0x00237830 File Offset: 0x00235A30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x0023783D File Offset: 0x00235A3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x00237844 File Offset: 0x00235A44
		public static FloroRanchAction GetRootAsFloroRanchAction(ByteBuffer _bb)
		{
			return FloroRanchAction.GetRootAsFloroRanchAction(_bb, default(FloroRanchAction));
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x00237860 File Offset: 0x00235A60
		public static FloroRanchAction GetRootAsFloroRanchAction(ByteBuffer _bb, FloroRanchAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x0023787D File Offset: 0x00235A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x0023788C File Offset: 0x00235A8C
		public FloroRanchAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060071FE RID: 29182 RVA: 0x0023789C File Offset: 0x00235A9C
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

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x002378D8 File Offset: 0x00235AD8
		public string Desc
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

		// Token: 0x06007200 RID: 29184 RVA: 0x0023790F File Offset: 0x00235B0F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x0023791E File Offset: 0x00235B1E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CF4 RID: 19700
		private Table __p;
	}
}

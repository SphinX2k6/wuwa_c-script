using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B85 RID: 2949
	public struct ClueEntrance : IFlatbufferObject
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x001F7D4C File Offset: 0x001F5F4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x001F7D59 File Offset: 0x001F5F59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x001F7D60 File Offset: 0x001F5F60
		public static ClueEntrance GetRootAsClueEntrance(ByteBuffer _bb)
		{
			return ClueEntrance.GetRootAsClueEntrance(_bb, default(ClueEntrance));
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x001F7D7C File Offset: 0x001F5F7C
		public static ClueEntrance GetRootAsClueEntrance(ByteBuffer _bb, ClueEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x001F7D99 File Offset: 0x001F5F99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x001F7DA8 File Offset: 0x001F5FA8
		public ClueEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x001F7DB8 File Offset: 0x001F5FB8
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x001F7DF4 File Offset: 0x001F5FF4
		public int ContentGroupId
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x001F7E30 File Offset: 0x001F6030
		public string Title
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

		// Token: 0x06005653 RID: 22099 RVA: 0x001F7E67 File Offset: 0x001F6067
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x001F7E76 File Offset: 0x001F6076
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B89 RID: 19337
		private Table __p;
	}
}

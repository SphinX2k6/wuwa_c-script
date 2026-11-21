using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118F RID: 4495
	public struct SelectRoleItemPerformance : IFlatbufferObject
	{
		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600D7E1 RID: 55265 RVA: 0x0032A5EC File Offset: 0x003287EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x0032A5F9 File Offset: 0x003287F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x0032A600 File Offset: 0x00328800
		public static SelectRoleItemPerformance GetRootAsSelectRoleItemPerformance(ByteBuffer _bb)
		{
			return SelectRoleItemPerformance.GetRootAsSelectRoleItemPerformance(_bb, default(SelectRoleItemPerformance));
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x0032A61C File Offset: 0x0032881C
		public static SelectRoleItemPerformance GetRootAsSelectRoleItemPerformance(ByteBuffer _bb, SelectRoleItemPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0032A639 File Offset: 0x00328839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x0032A648 File Offset: 0x00328848
		public SelectRoleItemPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600D7E7 RID: 55271 RVA: 0x0032A658 File Offset: 0x00328858
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x0032A694 File Offset: 0x00328894
		public string SpineAtlasPath
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

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x0032A6CB File Offset: 0x003288CB
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x0032A6DA File Offset: 0x003288DA
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600D7EB RID: 55275 RVA: 0x0032A6F4 File Offset: 0x003288F4
		public string SpineDataPath
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

		// Token: 0x0600D7EC RID: 55276 RVA: 0x0032A72B File Offset: 0x0032892B
		public Span<byte> GetSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D7ED RID: 55277 RVA: 0x0032A73A File Offset: 0x0032893A
		public byte[] GetSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x0032A754 File Offset: 0x00328954
		public string BgPrefabPath
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

		// Token: 0x0600D7EF RID: 55279 RVA: 0x0032A78C File Offset: 0x0032898C
		public Span<byte> GetBgPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x0032A79C File Offset: 0x0032899C
		public byte[] GetBgPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040057A0 RID: 22432
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001094 RID: 4244
	public struct SelectRoleItemPerformance : IFlatbufferObject
	{
		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600D00E RID: 53262 RVA: 0x0030B054 File Offset: 0x00309254
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x0030B061 File Offset: 0x00309261
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x0030B068 File Offset: 0x00309268
		public static SelectRoleItemPerformance GetRootAsSelectRoleItemPerformance(ByteBuffer _bb)
		{
			return SelectRoleItemPerformance.GetRootAsSelectRoleItemPerformance(_bb, default(SelectRoleItemPerformance));
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x0030B084 File Offset: 0x00309284
		public static SelectRoleItemPerformance GetRootAsSelectRoleItemPerformance(ByteBuffer _bb, SelectRoleItemPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x0030B0A1 File Offset: 0x003092A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x0030B0B0 File Offset: 0x003092B0
		public SelectRoleItemPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600D014 RID: 53268 RVA: 0x0030B0C0 File Offset: 0x003092C0
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

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600D015 RID: 53269 RVA: 0x0030B0FC File Offset: 0x003092FC
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

		// Token: 0x0600D016 RID: 53270 RVA: 0x0030B133 File Offset: 0x00309333
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D017 RID: 53271 RVA: 0x0030B142 File Offset: 0x00309342
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600D018 RID: 53272 RVA: 0x0030B15C File Offset: 0x0030935C
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

		// Token: 0x0600D019 RID: 53273 RVA: 0x0030B193 File Offset: 0x00309393
		public Span<byte> GetSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D01A RID: 53274 RVA: 0x0030B1A2 File Offset: 0x003093A2
		public byte[] GetSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600D01B RID: 53275 RVA: 0x0030B1BC File Offset: 0x003093BC
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

		// Token: 0x0600D01C RID: 53276 RVA: 0x0030B1F4 File Offset: 0x003093F4
		public Span<byte> GetBgPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D01D RID: 53277 RVA: 0x0030B204 File Offset: 0x00309404
		public byte[] GetBgPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A1 RID: 20897
		private Table __p;
	}
}

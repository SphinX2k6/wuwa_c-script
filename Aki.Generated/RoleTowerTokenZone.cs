using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115B RID: 4443
	public struct RoleTowerTokenZone : IFlatbufferObject
	{
		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600D327 RID: 54055 RVA: 0x00320314 File Offset: 0x0031E514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D328 RID: 54056 RVA: 0x00320321 File Offset: 0x0031E521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D329 RID: 54057 RVA: 0x00320328 File Offset: 0x0031E528
		public static RoleTowerTokenZone GetRootAsRoleTowerTokenZone(ByteBuffer _bb)
		{
			return RoleTowerTokenZone.GetRootAsRoleTowerTokenZone(_bb, default(RoleTowerTokenZone));
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x00320344 File Offset: 0x0031E544
		public static RoleTowerTokenZone GetRootAsRoleTowerTokenZone(ByteBuffer _bb, RoleTowerTokenZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x00320361 File Offset: 0x0031E561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D32C RID: 54060 RVA: 0x00320370 File Offset: 0x0031E570
		public RoleTowerTokenZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600D32D RID: 54061 RVA: 0x00320380 File Offset: 0x0031E580
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

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600D32E RID: 54062 RVA: 0x003203BC File Offset: 0x0031E5BC
		public int ActivityId
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

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600D32F RID: 54063 RVA: 0x003203F8 File Offset: 0x0031E5F8
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

		// Token: 0x0600D330 RID: 54064 RVA: 0x0032042F File Offset: 0x0031E62F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D331 RID: 54065 RVA: 0x0032043E File Offset: 0x0031E63E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005763 RID: 22371
		private Table __p;
	}
}

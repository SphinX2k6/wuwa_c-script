using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001095 RID: 4245
	public struct SelectRolePerformance : IFlatbufferObject
	{
		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600D01E RID: 53278 RVA: 0x0030B21C File Offset: 0x0030941C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x0030B229 File Offset: 0x00309429
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x0030B230 File Offset: 0x00309430
		public static SelectRolePerformance GetRootAsSelectRolePerformance(ByteBuffer _bb)
		{
			return SelectRolePerformance.GetRootAsSelectRolePerformance(_bb, default(SelectRolePerformance));
		}

		// Token: 0x0600D021 RID: 53281 RVA: 0x0030B24C File Offset: 0x0030944C
		public static SelectRolePerformance GetRootAsSelectRolePerformance(ByteBuffer _bb, SelectRolePerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D022 RID: 53282 RVA: 0x0030B269 File Offset: 0x00309469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x0030B278 File Offset: 0x00309478
		public SelectRolePerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600D024 RID: 53284 RVA: 0x0030B288 File Offset: 0x00309488
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

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600D025 RID: 53285 RVA: 0x0030B2C4 File Offset: 0x003094C4
		public int HelpId
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

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600D026 RID: 53286 RVA: 0x0030B300 File Offset: 0x00309500
		public string PrefabPath
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

		// Token: 0x0600D027 RID: 53287 RVA: 0x0030B337 File Offset: 0x00309537
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D028 RID: 53288 RVA: 0x0030B346 File Offset: 0x00309546
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A2 RID: 20898
		private Table __p;
	}
}

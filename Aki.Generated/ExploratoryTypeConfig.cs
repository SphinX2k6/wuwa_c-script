using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C49 RID: 3145
	public struct ExploratoryTypeConfig : IFlatbufferObject
	{
		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x00227162 File Offset: 0x00225362
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x0022716F File Offset: 0x0022536F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x00227178 File Offset: 0x00225378
		public static ExploratoryTypeConfig GetRootAsExploratoryTypeConfig(ByteBuffer _bb)
		{
			return ExploratoryTypeConfig.GetRootAsExploratoryTypeConfig(_bb, default(ExploratoryTypeConfig));
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00227194 File Offset: 0x00225394
		public static ExploratoryTypeConfig GetRootAsExploratoryTypeConfig(ByteBuffer _bb, ExploratoryTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x002271B1 File Offset: 0x002253B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x002271C0 File Offset: 0x002253C0
		public ExploratoryTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x002271D0 File Offset: 0x002253D0
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06006AF4 RID: 27380 RVA: 0x0022720C File Offset: 0x0022540C
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x00227248 File Offset: 0x00225448
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

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0022727F File Offset: 0x0022547F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x0022728E File Offset: 0x0022548E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x002272A8 File Offset: 0x002254A8
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

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x002272E8 File Offset: 0x002254E8
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

		// Token: 0x06006AFA RID: 27386 RVA: 0x00227320 File Offset: 0x00225520
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00227330 File Offset: 0x00225530
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C8E RID: 19598
		private Table __p;
	}
}

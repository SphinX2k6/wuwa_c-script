using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001252 RID: 4690
	public struct TeleportTransitionConfig : IFlatbufferObject
	{
		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600EAAA RID: 60074 RVA: 0x00355BE9 File Offset: 0x00353DE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x00355BF6 File Offset: 0x00353DF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x00355C00 File Offset: 0x00353E00
		public static TeleportTransitionConfig GetRootAsTeleportTransitionConfig(ByteBuffer _bb)
		{
			return TeleportTransitionConfig.GetRootAsTeleportTransitionConfig(_bb, default(TeleportTransitionConfig));
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x00355C1C File Offset: 0x00353E1C
		public static TeleportTransitionConfig GetRootAsTeleportTransitionConfig(ByteBuffer _bb, TeleportTransitionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAAE RID: 60078 RVA: 0x00355C39 File Offset: 0x00353E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAAF RID: 60079 RVA: 0x00355C48 File Offset: 0x00353E48
		public TeleportTransitionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600EAB0 RID: 60080 RVA: 0x00355C58 File Offset: 0x00353E58
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

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600EAB1 RID: 60081 RVA: 0x00355C94 File Offset: 0x00353E94
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

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x00355CCB File Offset: 0x00353ECB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x00355CDA File Offset: 0x00353EDA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600EAB4 RID: 60084 RVA: 0x00355CF4 File Offset: 0x00353EF4
		public string Data
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

		// Token: 0x0600EAB5 RID: 60085 RVA: 0x00355D2B File Offset: 0x00353F2B
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EAB6 RID: 60086 RVA: 0x00355D3A File Offset: 0x00353F3A
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400589C RID: 22684
		private Table __p;
	}
}

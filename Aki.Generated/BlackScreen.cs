using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AE RID: 4526
	public struct BlackScreen : IFlatbufferObject
	{
		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x00346A29 File Offset: 0x00344C29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9AE RID: 59822 RVA: 0x00346A36 File Offset: 0x00344C36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x00346A40 File Offset: 0x00344C40
		public static BlackScreen GetRootAsBlackScreen(ByteBuffer _bb)
		{
			return BlackScreen.GetRootAsBlackScreen(_bb, default(BlackScreen));
		}

		// Token: 0x0600E9B0 RID: 59824 RVA: 0x00346A5C File Offset: 0x00344C5C
		public static BlackScreen GetRootAsBlackScreen(ByteBuffer _bb, BlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x00346A79 File Offset: 0x00344C79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x00346A88 File Offset: 0x00344C88
		public BlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x00346A98 File Offset: 0x00344C98
		public string ShowAnimName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x00346ACF File Offset: 0x00344CCF
		public Span<byte> GetShowAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x00346ADE File Offset: 0x00344CDE
		public byte[] GetShowAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x00346AF8 File Offset: 0x00344CF8
		public string HideAnimName
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

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x00346B2F File Offset: 0x00344D2F
		public Span<byte> GetHideAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x00346B3E File Offset: 0x00344D3E
		public byte[] GetHideAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052FB RID: 21243
		private Table __p;
	}
}

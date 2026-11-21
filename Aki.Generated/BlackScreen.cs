using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E4 RID: 4836
	public struct BlackScreen : IFlatbufferObject
	{
		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x0600F71E RID: 63262 RVA: 0x003716B5 File Offset: 0x0036F8B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F71F RID: 63263 RVA: 0x003716C2 File Offset: 0x0036F8C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F720 RID: 63264 RVA: 0x003716CC File Offset: 0x0036F8CC
		public static BlackScreen GetRootAsBlackScreen(ByteBuffer _bb)
		{
			return BlackScreen.GetRootAsBlackScreen(_bb, default(BlackScreen));
		}

		// Token: 0x0600F721 RID: 63265 RVA: 0x003716E8 File Offset: 0x0036F8E8
		public static BlackScreen GetRootAsBlackScreen(ByteBuffer _bb, BlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F722 RID: 63266 RVA: 0x00371705 File Offset: 0x0036F905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F723 RID: 63267 RVA: 0x00371714 File Offset: 0x0036F914
		public BlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0600F724 RID: 63268 RVA: 0x00371724 File Offset: 0x0036F924
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

		// Token: 0x0600F725 RID: 63269 RVA: 0x0037175B File Offset: 0x0036F95B
		public Span<byte> GetShowAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F726 RID: 63270 RVA: 0x0037176A File Offset: 0x0036F96A
		public byte[] GetShowAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0600F727 RID: 63271 RVA: 0x00371784 File Offset: 0x0036F984
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

		// Token: 0x0600F728 RID: 63272 RVA: 0x003717BB File Offset: 0x0036F9BB
		public Span<byte> GetHideAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F729 RID: 63273 RVA: 0x003717CA File Offset: 0x0036F9CA
		public byte[] GetHideAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400593E RID: 22846
		private Table __p;
	}
}

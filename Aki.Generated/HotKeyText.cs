using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D56 RID: 3414
	public struct HotKeyText : IFlatbufferObject
	{
		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x0025C654 File Offset: 0x0025A854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x0025C661 File Offset: 0x0025A861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x0025C668 File Offset: 0x0025A868
		public static HotKeyText GetRootAsHotKeyText(ByteBuffer _bb)
		{
			return HotKeyText.GetRootAsHotKeyText(_bb, default(HotKeyText));
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x0025C684 File Offset: 0x0025A884
		public static HotKeyText GetRootAsHotKeyText(ByteBuffer _bb, HotKeyText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x0025C6A1 File Offset: 0x0025A8A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x0025C6B0 File Offset: 0x0025A8B0
		public HotKeyText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06008238 RID: 33336 RVA: 0x0025C6C0 File Offset: 0x0025A8C0
		public string TextId
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

		// Token: 0x06008239 RID: 33337 RVA: 0x0025C6F7 File Offset: 0x0025A8F7
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x0025C706 File Offset: 0x0025A906
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x0600823B RID: 33339 RVA: 0x0025C720 File Offset: 0x0025A920
		public string Name
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

		// Token: 0x0600823C RID: 33340 RVA: 0x0025C757 File Offset: 0x0025A957
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x0025C766 File Offset: 0x0025A966
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DD5 RID: 19925
		private Table __p;
	}
}

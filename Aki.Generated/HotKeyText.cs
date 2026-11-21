using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3B RID: 3643
	public struct HotKeyText : IFlatbufferObject
	{
		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600884C RID: 34892 RVA: 0x0027AD80 File Offset: 0x00278F80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x0027AD8D File Offset: 0x00278F8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x0027AD94 File Offset: 0x00278F94
		public static HotKeyText GetRootAsHotKeyText(ByteBuffer _bb)
		{
			return HotKeyText.GetRootAsHotKeyText(_bb, default(HotKeyText));
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x0027ADB0 File Offset: 0x00278FB0
		public static HotKeyText GetRootAsHotKeyText(ByteBuffer _bb, HotKeyText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x0027ADCD File Offset: 0x00278FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x0027ADDC File Offset: 0x00278FDC
		public HotKeyText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06008852 RID: 34898 RVA: 0x0027ADEC File Offset: 0x00278FEC
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

		// Token: 0x06008853 RID: 34899 RVA: 0x0027AE23 File Offset: 0x00279023
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x0027AE32 File Offset: 0x00279032
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06008855 RID: 34901 RVA: 0x0027AE4C File Offset: 0x0027904C
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

		// Token: 0x06008856 RID: 34902 RVA: 0x0027AE83 File Offset: 0x00279083
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x0027AE92 File Offset: 0x00279092
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053BA RID: 21434
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE2 RID: 3298
	public struct GachaSequenceConfig : IFlatbufferObject
	{
		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06007833 RID: 30771 RVA: 0x0024614A File Offset: 0x0024434A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00246157 File Offset: 0x00244357
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00246160 File Offset: 0x00244360
		public static GachaSequenceConfig GetRootAsGachaSequenceConfig(ByteBuffer _bb)
		{
			return GachaSequenceConfig.GetRootAsGachaSequenceConfig(_bb, default(GachaSequenceConfig));
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x0024617C File Offset: 0x0024437C
		public static GachaSequenceConfig GetRootAsGachaSequenceConfig(ByteBuffer _bb, GachaSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00246199 File Offset: 0x00244399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x002461A8 File Offset: 0x002443A8
		public GachaSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x002461B8 File Offset: 0x002443B8
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

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x002461F4 File Offset: 0x002443F4
		public string SequencePath
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

		// Token: 0x0600783B RID: 30779 RVA: 0x0024622B File Offset: 0x0024442B
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x0024623A File Offset: 0x0024443A
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D53 RID: 19795
		private Table __p;
	}
}

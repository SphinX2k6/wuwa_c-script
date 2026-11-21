using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001211 RID: 4625
	public struct SpeakerAfterChange : IFlatbufferObject
	{
		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x00348DFD File Offset: 0x00346FFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x00348E0A File Offset: 0x0034700A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x00348E14 File Offset: 0x00347014
		public static SpeakerAfterChange GetRootAsSpeakerAfterChange(ByteBuffer _bb)
		{
			return SpeakerAfterChange.GetRootAsSpeakerAfterChange(_bb, default(SpeakerAfterChange));
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00348E30 File Offset: 0x00347030
		public static SpeakerAfterChange GetRootAsSpeakerAfterChange(ByteBuffer _bb, SpeakerAfterChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00348E4D File Offset: 0x0034704D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00348E5C File Offset: 0x0034705C
		public SpeakerAfterChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x00348E6C File Offset: 0x0034706C
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

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x00348EA8 File Offset: 0x003470A8
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

		// Token: 0x0600E4F9 RID: 58617 RVA: 0x00348EDF File Offset: 0x003470DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E4FA RID: 58618 RVA: 0x00348EEE File Offset: 0x003470EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x00348F08 File Offset: 0x00347108
		public string Icon
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

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00348F3F File Offset: 0x0034713F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00348F4E File Offset: 0x0034714E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005851 RID: 22609
		private Table __p;
	}
}

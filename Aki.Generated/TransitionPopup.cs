using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001287 RID: 4743
	public struct TransitionPopup : IFlatbufferObject
	{
		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x0035EC74 File Offset: 0x0035CE74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EEC4 RID: 61124 RVA: 0x0035EC81 File Offset: 0x0035CE81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EEC5 RID: 61125 RVA: 0x0035EC88 File Offset: 0x0035CE88
		public static TransitionPopup GetRootAsTransitionPopup(ByteBuffer _bb)
		{
			return TransitionPopup.GetRootAsTransitionPopup(_bb, default(TransitionPopup));
		}

		// Token: 0x0600EEC6 RID: 61126 RVA: 0x0035ECA4 File Offset: 0x0035CEA4
		public static TransitionPopup GetRootAsTransitionPopup(ByteBuffer _bb, TransitionPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EEC7 RID: 61127 RVA: 0x0035ECC1 File Offset: 0x0035CEC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EEC8 RID: 61128 RVA: 0x0035ECD0 File Offset: 0x0035CED0
		public TransitionPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0600EEC9 RID: 61129 RVA: 0x0035ECE0 File Offset: 0x0035CEE0
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

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0600EECA RID: 61130 RVA: 0x0035ED1C File Offset: 0x0035CF1C
		public int Style
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

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0600EECB RID: 61131 RVA: 0x0035ED58 File Offset: 0x0035CF58
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

		// Token: 0x0600EECC RID: 61132 RVA: 0x0035ED8F File Offset: 0x0035CF8F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EECD RID: 61133 RVA: 0x0035ED9E File Offset: 0x0035CF9E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0600EECE RID: 61134 RVA: 0x0035EDB8 File Offset: 0x0035CFB8
		public string ContentText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EECF RID: 61135 RVA: 0x0035EDF0 File Offset: 0x0035CFF0
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EED0 RID: 61136 RVA: 0x0035EE00 File Offset: 0x0035D000
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058D9 RID: 22745
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0D RID: 3597
	public struct HelpText : IFlatbufferObject
	{
		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06008472 RID: 33906 RVA: 0x002723DD File Offset: 0x002705DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x002723EA File Offset: 0x002705EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x002723F4 File Offset: 0x002705F4
		public static HelpText GetRootAsHelpText(ByteBuffer _bb)
		{
			return HelpText.GetRootAsHelpText(_bb, default(HelpText));
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x00272410 File Offset: 0x00270610
		public static HelpText GetRootAsHelpText(ByteBuffer _bb, HelpText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x0027242D File Offset: 0x0027062D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x0027243C File Offset: 0x0027063C
		public HelpText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06008478 RID: 33912 RVA: 0x0027244C File Offset: 0x0027064C
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

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06008479 RID: 33913 RVA: 0x00272488 File Offset: 0x00270688
		public int GroupId
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

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x0600847A RID: 33914 RVA: 0x002724C4 File Offset: 0x002706C4
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

		// Token: 0x0600847B RID: 33915 RVA: 0x002724FB File Offset: 0x002706FB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x0027250A File Offset: 0x0027070A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x0600847D RID: 33917 RVA: 0x00272524 File Offset: 0x00270724
		public string Picture
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

		// Token: 0x0600847E RID: 33918 RVA: 0x0027255C File Offset: 0x0027075C
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x0027256C File Offset: 0x0027076C
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06008480 RID: 33920 RVA: 0x00272584 File Offset: 0x00270784
		public string Content
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

		// Token: 0x06008481 RID: 33921 RVA: 0x002725BC File Offset: 0x002707BC
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x002725CC File Offset: 0x002707CC
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06008483 RID: 33923 RVA: 0x002725E4 File Offset: 0x002707E4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06008484 RID: 33924 RVA: 0x00272624 File Offset: 0x00270824
		public int Style
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x00272664 File Offset: 0x00270864
		public int TimeDilation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005385 RID: 21381
		private Table __p;
	}
}

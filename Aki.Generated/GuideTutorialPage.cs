using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E03 RID: 3587
	public struct GuideTutorialPage : IFlatbufferObject
	{
		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x0600838E RID: 33678 RVA: 0x002707B3 File Offset: 0x0026E9B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x002707C0 File Offset: 0x0026E9C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x002707C8 File Offset: 0x0026E9C8
		public static GuideTutorialPage GetRootAsGuideTutorialPage(ByteBuffer _bb)
		{
			return GuideTutorialPage.GetRootAsGuideTutorialPage(_bb, default(GuideTutorialPage));
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x002707E4 File Offset: 0x0026E9E4
		public static GuideTutorialPage GetRootAsGuideTutorialPage(ByteBuffer _bb, GuideTutorialPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x00270801 File Offset: 0x0026EA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x00270810 File Offset: 0x0026EA10
		public GuideTutorialPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06008394 RID: 33684 RVA: 0x00270820 File Offset: 0x0026EA20
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

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06008395 RID: 33685 RVA: 0x0027085C File Offset: 0x0026EA5C
		public string Pic
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

		// Token: 0x06008396 RID: 33686 RVA: 0x00270893 File Offset: 0x0026EA93
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x002708A2 File Offset: 0x0026EAA2
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x002708BC File Offset: 0x0026EABC
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

		// Token: 0x06008399 RID: 33689 RVA: 0x002708F3 File Offset: 0x0026EAF3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x00270902 File Offset: 0x0026EB02
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0027091C File Offset: 0x0026EB1C
		public string SubTitle
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

		// Token: 0x0600839C RID: 33692 RVA: 0x00270954 File Offset: 0x0026EB54
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x00270964 File Offset: 0x0026EB64
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x0600839E RID: 33694 RVA: 0x0027097C File Offset: 0x0026EB7C
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

		// Token: 0x0600839F RID: 33695 RVA: 0x002709B4 File Offset: 0x0026EBB4
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x002709C4 File Offset: 0x0026EBC4
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060083A1 RID: 33697 RVA: 0x002709DC File Offset: 0x0026EBDC
		public string Button(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x060083A2 RID: 33698 RVA: 0x00270A18 File Offset: 0x0026EC18
		public int ButtonLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x00270A44 File Offset: 0x0026EC44
		[NullableContext(1)]
		public string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x00270A51 File Offset: 0x0026EC51
		[NullableContext(1)]
		public IEnumerable<string> ButtonIter()
		{
			GuideTutorialPage.<ButtonIter>d__30 <ButtonIter>d__ = new GuideTutorialPage.<ButtonIter>d__30(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x0400537B RID: 21371
		private Table __p;
	}
}

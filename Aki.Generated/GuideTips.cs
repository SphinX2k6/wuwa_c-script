using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E01 RID: 3585
	public struct GuideTips : IFlatbufferObject
	{
		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06008353 RID: 33619 RVA: 0x0026FEE8 File Offset: 0x0026E0E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0026FEF5 File Offset: 0x0026E0F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x0026FEFC File Offset: 0x0026E0FC
		public static GuideTips GetRootAsGuideTips(ByteBuffer _bb)
		{
			return GuideTips.GetRootAsGuideTips(_bb, default(GuideTips));
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x0026FF18 File Offset: 0x0026E118
		public static GuideTips GetRootAsGuideTips(ByteBuffer _bb, GuideTips obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x0026FF35 File Offset: 0x0026E135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0026FF44 File Offset: 0x0026E144
		public GuideTips __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06008359 RID: 33625 RVA: 0x0026FF54 File Offset: 0x0026E154
		public int GuideId
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

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x0026FF90 File Offset: 0x0026E190
		public string Content
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

		// Token: 0x0600835B RID: 33627 RVA: 0x0026FFC7 File Offset: 0x0026E1C7
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0026FFD6 File Offset: 0x0026E1D6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0026FFF0 File Offset: 0x0026E1F0
		public string Button(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600835E RID: 33630 RVA: 0x0027002C File Offset: 0x0026E22C
		public int ButtonLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x00270058 File Offset: 0x0026E258
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06008360 RID: 33632 RVA: 0x00270094 File Offset: 0x0026E294
		public int InputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x002700C0 File Offset: 0x0026E2C0
		public string LimitInputEnums(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06008362 RID: 33634 RVA: 0x002700FC File Offset: 0x0026E2FC
		public int LimitInputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x00270128 File Offset: 0x0026E328
		public bool UseLoopAnim
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06008364 RID: 33636 RVA: 0x00270168 File Offset: 0x0026E368
		public int UseMask
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

		// Token: 0x06008365 RID: 33637 RVA: 0x002701A5 File Offset: 0x0026E3A5
		[NullableContext(1)]
		public string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x002701B2 File Offset: 0x0026E3B2
		[NullableContext(1)]
		public IEnumerable<string> ButtonIter()
		{
			GuideTips.<ButtonIter>d__28 <ButtonIter>d__ = new GuideTips.<ButtonIter>d__28(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x002701C7 File Offset: 0x0026E3C7
		[NullableContext(1)]
		public string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x002701D4 File Offset: 0x0026E3D4
		[NullableContext(1)]
		public IEnumerable<string> InputEnumsIter()
		{
			GuideTips.<InputEnumsIter>d__30 <InputEnumsIter>d__ = new GuideTips.<InputEnumsIter>d__30(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x002701E9 File Offset: 0x0026E3E9
		[NullableContext(1)]
		public string[] LimitInputEnums()
		{
			return this.LimitInputEnumsIter().ToArray<string>();
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x002701F6 File Offset: 0x0026E3F6
		[NullableContext(1)]
		public IEnumerable<string> LimitInputEnumsIter()
		{
			GuideTips.<LimitInputEnumsIter>d__32 <LimitInputEnumsIter>d__ = new GuideTips.<LimitInputEnumsIter>d__32(-2);
			<LimitInputEnumsIter>d__.<>3__<>4__this = this;
			return <LimitInputEnumsIter>d__;
		}

		// Token: 0x04005379 RID: 21369
		private Table __p;
	}
}

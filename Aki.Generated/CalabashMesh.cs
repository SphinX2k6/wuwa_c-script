using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3E RID: 3134
	public struct CalabashMesh : IFlatbufferObject
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x0020E76E File Offset: 0x0020C96E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0020E77B File Offset: 0x0020C97B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0020E784 File Offset: 0x0020C984
		public static CalabashMesh GetRootAsCalabashMesh(ByteBuffer _bb)
		{
			return CalabashMesh.GetRootAsCalabashMesh(_bb, default(CalabashMesh));
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x0020E7A0 File Offset: 0x0020C9A0
		public static CalabashMesh GetRootAsCalabashMesh(ByteBuffer _bb, CalabashMesh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x0020E7BD File Offset: 0x0020C9BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x0020E7CC File Offset: 0x0020C9CC
		public CalabashMesh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060057DB RID: 22491 RVA: 0x0020E7DC File Offset: 0x0020C9DC
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

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x0020E818 File Offset: 0x0020CA18
		public int MeshId
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

		// Token: 0x060057DD RID: 22493 RVA: 0x0020E854 File Offset: 0x0020CA54
		public string OldEffects(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060057DE RID: 22494 RVA: 0x0020E890 File Offset: 0x0020CA90
		public int OldEffectsLength
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

		// Token: 0x060057DF RID: 22495 RVA: 0x0020E8BC File Offset: 0x0020CABC
		public string NewEffects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060057E0 RID: 22496 RVA: 0x0020E8F8 File Offset: 0x0020CAF8
		public int NewEffectsLength
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

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x0020E924 File Offset: 0x0020CB24
		public int HideParaglider
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0020E961 File Offset: 0x0020CB61
		[NullableContext(1)]
		public string[] NewEffects()
		{
			return this.NewEffectsIter().ToArray<string>();
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0020E96E File Offset: 0x0020CB6E
		[NullableContext(1)]
		public IEnumerable<string> NewEffectsIter()
		{
			CalabashMesh.<NewEffectsIter>d__21 <NewEffectsIter>d__ = new CalabashMesh.<NewEffectsIter>d__21(-2);
			<NewEffectsIter>d__.<>3__<>4__this = this;
			return <NewEffectsIter>d__;
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x0020E983 File Offset: 0x0020CB83
		[NullableContext(1)]
		public string[] OldEffects()
		{
			return this.OldEffectsIter().ToArray<string>();
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0020E990 File Offset: 0x0020CB90
		[NullableContext(1)]
		public IEnumerable<string> OldEffectsIter()
		{
			CalabashMesh.<OldEffectsIter>d__23 <OldEffectsIter>d__ = new CalabashMesh.<OldEffectsIter>d__23(-2);
			<OldEffectsIter>d__.<>3__<>4__this = this;
			return <OldEffectsIter>d__;
		}

		// Token: 0x0400513E RID: 20798
		private Table __p;
	}
}

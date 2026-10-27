using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200488C RID: 18572
	public struct INodeBreakPoint : IFlatbufferObject
	{
		// Token: 0x170086B1 RID: 34481
		// (get) Token: 0x0601CF9C RID: 118684 RVA: 0x00418338 File Offset: 0x00416538
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF9D RID: 118685 RVA: 0x00418345 File Offset: 0x00416545
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF9E RID: 118686 RVA: 0x0041834C File Offset: 0x0041654C
		public static INodeBreakPoint GetRootAsINodeBreakPoint(ByteBuffer _bb)
		{
			return INodeBreakPoint.GetRootAsINodeBreakPoint(_bb, default(INodeBreakPoint));
		}

		// Token: 0x0601CF9F RID: 118687 RVA: 0x00418368 File Offset: 0x00416568
		public static INodeBreakPoint GetRootAsINodeBreakPoint(ByteBuffer _bb, INodeBreakPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x00418385 File Offset: 0x00416585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x00418394 File Offset: 0x00416594
		public INodeBreakPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086B2 RID: 34482
		// (get) Token: 0x0601CFA2 RID: 118690 RVA: 0x004183A4 File Offset: 0x004165A4
		public bool Before
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086B3 RID: 34483
		// (get) Token: 0x0601CFA3 RID: 118691 RVA: 0x004183E4 File Offset: 0x004165E4
		public bool After
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086B4 RID: 34484
		// (get) Token: 0x0601CFA4 RID: 118692 RVA: 0x00418424 File Offset: 0x00416624
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x00418460 File Offset: 0x00416660
		public static Offset<INodeBreakPoint> CreateINodeBreakPoint(FlatBufferBuilder builder, bool Before = false, bool After = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INodeBreakPoint.AddNullMask(builder, NullMask);
			INodeBreakPoint.AddAfter(builder, After);
			INodeBreakPoint.AddBefore(builder, Before);
			return INodeBreakPoint.EndINodeBreakPoint(builder);
		}

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x00418484 File Offset: 0x00416684
		public static void StartINodeBreakPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CFA7 RID: 118695 RVA: 0x0041848D File Offset: 0x0041668D
		public static void AddBefore(FlatBufferBuilder builder, bool before)
		{
			builder.AddBool(0, before, false);
		}

		// Token: 0x0601CFA8 RID: 118696 RVA: 0x00418498 File Offset: 0x00416698
		public static void AddAfter(FlatBufferBuilder builder, bool after)
		{
			builder.AddBool(1, after, false);
		}

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x004184A3 File Offset: 0x004166A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601CFAA RID: 118698 RVA: 0x004184AE File Offset: 0x004166AE
		public static Offset<INodeBreakPoint> EndINodeBreakPoint(FlatBufferBuilder builder)
		{
			return new Offset<INodeBreakPoint>(builder.EndTable());
		}

		// Token: 0x0601CFAB RID: 118699 RVA: 0x004184BC File Offset: 0x004166BC
		public INodeBreakPointT UnPack()
		{
			INodeBreakPointT nodeBreakPointT = new INodeBreakPointT();
			this.UnPackTo(nodeBreakPointT);
			return nodeBreakPointT;
		}

		// Token: 0x0601CFAC RID: 118700 RVA: 0x004184D7 File Offset: 0x004166D7
		public void UnPackTo(INodeBreakPointT _o)
		{
			_o.Before = this.Before;
			_o.After = this.After;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CFAD RID: 118701 RVA: 0x00418500 File Offset: 0x00416700
		public static Offset<INodeBreakPoint> Pack(FlatBufferBuilder builder, INodeBreakPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<INodeBreakPoint>);
			}
			return INodeBreakPoint.CreateINodeBreakPoint(builder, _o.Before, _o.After, _o.NullMask);
		}

		// Token: 0x0400CE73 RID: 52851
		private Table __p;
	}
}

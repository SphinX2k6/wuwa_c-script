using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF1 RID: 19697
	public struct INodeBreakPoint : IFlatbufferObject
	{
		// Token: 0x17008CF9 RID: 36089
		// (get) Token: 0x0601E789 RID: 124809 RVA: 0x00444AD4 File Offset: 0x00442CD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E78A RID: 124810 RVA: 0x00444AE1 File Offset: 0x00442CE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E78B RID: 124811 RVA: 0x00444AE8 File Offset: 0x00442CE8
		public static INodeBreakPoint GetRootAsINodeBreakPoint(ByteBuffer _bb)
		{
			return INodeBreakPoint.GetRootAsINodeBreakPoint(_bb, default(INodeBreakPoint));
		}

		// Token: 0x0601E78C RID: 124812 RVA: 0x00444B04 File Offset: 0x00442D04
		public static INodeBreakPoint GetRootAsINodeBreakPoint(ByteBuffer _bb, INodeBreakPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E78D RID: 124813 RVA: 0x00444B21 File Offset: 0x00442D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E78E RID: 124814 RVA: 0x00444B30 File Offset: 0x00442D30
		public INodeBreakPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CFA RID: 36090
		// (get) Token: 0x0601E78F RID: 124815 RVA: 0x00444B40 File Offset: 0x00442D40
		public bool Before
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CFB RID: 36091
		// (get) Token: 0x0601E790 RID: 124816 RVA: 0x00444B80 File Offset: 0x00442D80
		public bool After
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CFC RID: 36092
		// (get) Token: 0x0601E791 RID: 124817 RVA: 0x00444BC0 File Offset: 0x00442DC0
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

		// Token: 0x0601E792 RID: 124818 RVA: 0x00444BFC File Offset: 0x00442DFC
		public static Offset<INodeBreakPoint> CreateINodeBreakPoint(FlatBufferBuilder builder, bool Before = false, bool After = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INodeBreakPoint.AddNullMask(builder, NullMask);
			INodeBreakPoint.AddAfter(builder, After);
			INodeBreakPoint.AddBefore(builder, Before);
			return INodeBreakPoint.EndINodeBreakPoint(builder);
		}

		// Token: 0x0601E793 RID: 124819 RVA: 0x00444C20 File Offset: 0x00442E20
		public static void StartINodeBreakPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E794 RID: 124820 RVA: 0x00444C29 File Offset: 0x00442E29
		public static void AddBefore(FlatBufferBuilder builder, bool before)
		{
			builder.AddBool(0, before, false);
		}

		// Token: 0x0601E795 RID: 124821 RVA: 0x00444C34 File Offset: 0x00442E34
		public static void AddAfter(FlatBufferBuilder builder, bool after)
		{
			builder.AddBool(1, after, false);
		}

		// Token: 0x0601E796 RID: 124822 RVA: 0x00444C3F File Offset: 0x00442E3F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601E797 RID: 124823 RVA: 0x00444C4A File Offset: 0x00442E4A
		public static Offset<INodeBreakPoint> EndINodeBreakPoint(FlatBufferBuilder builder)
		{
			return new Offset<INodeBreakPoint>(builder.EndTable());
		}

		// Token: 0x0601E798 RID: 124824 RVA: 0x00444C58 File Offset: 0x00442E58
		public INodeBreakPointT UnPack()
		{
			INodeBreakPointT nodeBreakPointT = new INodeBreakPointT();
			this.UnPackTo(nodeBreakPointT);
			return nodeBreakPointT;
		}

		// Token: 0x0601E799 RID: 124825 RVA: 0x00444C73 File Offset: 0x00442E73
		public void UnPackTo(INodeBreakPointT _o)
		{
			_o.Before = this.Before;
			_o.After = this.After;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E79A RID: 124826 RVA: 0x00444C9C File Offset: 0x00442E9C
		public static Offset<INodeBreakPoint> Pack(FlatBufferBuilder builder, INodeBreakPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<INodeBreakPoint>);
			}
			return INodeBreakPoint.CreateINodeBreakPoint(builder, _o.Before, _o.After, _o.NullMask);
		}

		// Token: 0x0400D8AC RID: 55468
		private Table __p;
	}
}

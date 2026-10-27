using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B0 RID: 17072
	public struct IZaxisViewRange : IFlatbufferObject
	{
		// Token: 0x17007926 RID: 31014
		// (get) Token: 0x060194B3 RID: 103603 RVA: 0x003A1A26 File Offset: 0x0039FC26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060194B4 RID: 103604 RVA: 0x003A1A33 File Offset: 0x0039FC33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060194B5 RID: 103605 RVA: 0x003A1A3C File Offset: 0x0039FC3C
		public static IZaxisViewRange GetRootAsIZaxisViewRange(ByteBuffer _bb)
		{
			return IZaxisViewRange.GetRootAsIZaxisViewRange(_bb, default(IZaxisViewRange));
		}

		// Token: 0x060194B6 RID: 103606 RVA: 0x003A1A58 File Offset: 0x0039FC58
		public static IZaxisViewRange GetRootAsIZaxisViewRange(ByteBuffer _bb, IZaxisViewRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060194B7 RID: 103607 RVA: 0x003A1A75 File Offset: 0x0039FC75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060194B8 RID: 103608 RVA: 0x003A1A84 File Offset: 0x0039FC84
		public IZaxisViewRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007927 RID: 31015
		// (get) Token: 0x060194B9 RID: 103609 RVA: 0x003A1A94 File Offset: 0x0039FC94
		public int Up
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

		// Token: 0x17007928 RID: 31016
		// (get) Token: 0x060194BA RID: 103610 RVA: 0x003A1AD0 File Offset: 0x0039FCD0
		public int Down
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

		// Token: 0x17007929 RID: 31017
		// (get) Token: 0x060194BB RID: 103611 RVA: 0x003A1B0C File Offset: 0x0039FD0C
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

		// Token: 0x060194BC RID: 103612 RVA: 0x003A1B48 File Offset: 0x0039FD48
		public static Offset<IZaxisViewRange> CreateIZaxisViewRange(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IZaxisViewRange.AddDown(builder, Down);
			IZaxisViewRange.AddUp(builder, Up);
			IZaxisViewRange.AddNullMask(builder, NullMask);
			return IZaxisViewRange.EndIZaxisViewRange(builder);
		}

		// Token: 0x060194BD RID: 103613 RVA: 0x003A1B6C File Offset: 0x0039FD6C
		public static void StartIZaxisViewRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060194BE RID: 103614 RVA: 0x003A1B75 File Offset: 0x0039FD75
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x060194BF RID: 103615 RVA: 0x003A1B80 File Offset: 0x0039FD80
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x060194C0 RID: 103616 RVA: 0x003A1B8B File Offset: 0x0039FD8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060194C1 RID: 103617 RVA: 0x003A1B96 File Offset: 0x0039FD96
		public static Offset<IZaxisViewRange> EndIZaxisViewRange(FlatBufferBuilder builder)
		{
			return new Offset<IZaxisViewRange>(builder.EndTable());
		}

		// Token: 0x060194C2 RID: 103618 RVA: 0x003A1BA4 File Offset: 0x0039FDA4
		public IZaxisViewRangeT UnPack()
		{
			IZaxisViewRangeT zaxisViewRangeT = new IZaxisViewRangeT();
			this.UnPackTo(zaxisViewRangeT);
			return zaxisViewRangeT;
		}

		// Token: 0x060194C3 RID: 103619 RVA: 0x003A1BBF File Offset: 0x0039FDBF
		public void UnPackTo(IZaxisViewRangeT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060194C4 RID: 103620 RVA: 0x003A1BE8 File Offset: 0x0039FDE8
		public static Offset<IZaxisViewRange> Pack(FlatBufferBuilder builder, IZaxisViewRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IZaxisViewRange>);
			}
			return IZaxisViewRange.CreateIZaxisViewRange(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400BF56 RID: 48982
		private Table __p;
	}
}

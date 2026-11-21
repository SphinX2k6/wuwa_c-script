using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200470C RID: 18188
	public struct IZaxisViewRange : IFlatbufferObject
	{
		// Token: 0x17007F57 RID: 32599
		// (get) Token: 0x0601AC1F RID: 109599 RVA: 0x003CD0FE File Offset: 0x003CB2FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AC20 RID: 109600 RVA: 0x003CD10B File Offset: 0x003CB30B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AC21 RID: 109601 RVA: 0x003CD114 File Offset: 0x003CB314
		public static IZaxisViewRange GetRootAsIZaxisViewRange(ByteBuffer _bb)
		{
			return IZaxisViewRange.GetRootAsIZaxisViewRange(_bb, default(IZaxisViewRange));
		}

		// Token: 0x0601AC22 RID: 109602 RVA: 0x003CD130 File Offset: 0x003CB330
		public static IZaxisViewRange GetRootAsIZaxisViewRange(ByteBuffer _bb, IZaxisViewRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AC23 RID: 109603 RVA: 0x003CD14D File Offset: 0x003CB34D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AC24 RID: 109604 RVA: 0x003CD15C File Offset: 0x003CB35C
		public IZaxisViewRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F58 RID: 32600
		// (get) Token: 0x0601AC25 RID: 109605 RVA: 0x003CD16C File Offset: 0x003CB36C
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

		// Token: 0x17007F59 RID: 32601
		// (get) Token: 0x0601AC26 RID: 109606 RVA: 0x003CD1A8 File Offset: 0x003CB3A8
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

		// Token: 0x17007F5A RID: 32602
		// (get) Token: 0x0601AC27 RID: 109607 RVA: 0x003CD1E4 File Offset: 0x003CB3E4
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

		// Token: 0x0601AC28 RID: 109608 RVA: 0x003CD220 File Offset: 0x003CB420
		public static Offset<IZaxisViewRange> CreateIZaxisViewRange(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IZaxisViewRange.AddDown(builder, Down);
			IZaxisViewRange.AddUp(builder, Up);
			IZaxisViewRange.AddNullMask(builder, NullMask);
			return IZaxisViewRange.EndIZaxisViewRange(builder);
		}

		// Token: 0x0601AC29 RID: 109609 RVA: 0x003CD244 File Offset: 0x003CB444
		public static void StartIZaxisViewRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AC2A RID: 109610 RVA: 0x003CD24D File Offset: 0x003CB44D
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x0601AC2B RID: 109611 RVA: 0x003CD258 File Offset: 0x003CB458
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x0601AC2C RID: 109612 RVA: 0x003CD263 File Offset: 0x003CB463
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601AC2D RID: 109613 RVA: 0x003CD26E File Offset: 0x003CB46E
		public static Offset<IZaxisViewRange> EndIZaxisViewRange(FlatBufferBuilder builder)
		{
			return new Offset<IZaxisViewRange>(builder.EndTable());
		}

		// Token: 0x0601AC2E RID: 109614 RVA: 0x003CD27C File Offset: 0x003CB47C
		public IZaxisViewRangeT UnPack()
		{
			IZaxisViewRangeT zaxisViewRangeT = new IZaxisViewRangeT();
			this.UnPackTo(zaxisViewRangeT);
			return zaxisViewRangeT;
		}

		// Token: 0x0601AC2F RID: 109615 RVA: 0x003CD297 File Offset: 0x003CB497
		public void UnPackTo(IZaxisViewRangeT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AC30 RID: 109616 RVA: 0x003CD2C0 File Offset: 0x003CB4C0
		public static Offset<IZaxisViewRange> Pack(FlatBufferBuilder builder, IZaxisViewRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IZaxisViewRange>);
			}
			return IZaxisViewRange.CreateIZaxisViewRange(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400C963 RID: 51555
		private Table __p;
	}
}

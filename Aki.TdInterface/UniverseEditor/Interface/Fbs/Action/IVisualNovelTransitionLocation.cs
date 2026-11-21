using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF4 RID: 32244
	public struct IVisualNovelTransitionLocation : IFlatbufferObject
	{
		// Token: 0x1700F184 RID: 61828
		// (get) Token: 0x0603A443 RID: 238659 RVA: 0x007D9DDC File Offset: 0x007D7FDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A444 RID: 238660 RVA: 0x007D9DE9 File Offset: 0x007D7FE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A445 RID: 238661 RVA: 0x007D9DF0 File Offset: 0x007D7FF0
		public static IVisualNovelTransitionLocation GetRootAsIVisualNovelTransitionLocation(ByteBuffer _bb)
		{
			return IVisualNovelTransitionLocation.GetRootAsIVisualNovelTransitionLocation(_bb, default(IVisualNovelTransitionLocation));
		}

		// Token: 0x0603A446 RID: 238662 RVA: 0x007D9E0C File Offset: 0x007D800C
		public static IVisualNovelTransitionLocation GetRootAsIVisualNovelTransitionLocation(ByteBuffer _bb, IVisualNovelTransitionLocation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A447 RID: 238663 RVA: 0x007D9E29 File Offset: 0x007D8029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A448 RID: 238664 RVA: 0x007D9E38 File Offset: 0x007D8038
		public IVisualNovelTransitionLocation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F185 RID: 61829
		// (get) Token: 0x0603A449 RID: 238665 RVA: 0x007D9E48 File Offset: 0x007D8048
		public EVisualNovelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelTransitionType.Location;
				}
				return (EVisualNovelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F186 RID: 61830
		// (get) Token: 0x0603A44A RID: 238666 RVA: 0x007D9E84 File Offset: 0x007D8084
		public int LocationId
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

		// Token: 0x1700F187 RID: 61831
		// (get) Token: 0x0603A44B RID: 238667 RVA: 0x007D9EC0 File Offset: 0x007D80C0
		public int TransitionBackgroundId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F188 RID: 61832
		// (get) Token: 0x0603A44C RID: 238668 RVA: 0x007D9EFC File Offset: 0x007D80FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A44D RID: 238669 RVA: 0x007D9F39 File Offset: 0x007D8139
		public static Offset<IVisualNovelTransitionLocation> CreateIVisualNovelTransitionLocation(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location, int LocationId = 0, int TransitionBackgroundId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelTransitionLocation.AddTransitionBackgroundId(builder, TransitionBackgroundId);
			IVisualNovelTransitionLocation.AddLocationId(builder, LocationId);
			IVisualNovelTransitionLocation.AddNullMask(builder, NullMask);
			IVisualNovelTransitionLocation.AddType(builder, Type);
			return IVisualNovelTransitionLocation.EndIVisualNovelTransitionLocation(builder);
		}

		// Token: 0x0603A44E RID: 238670 RVA: 0x007D9F65 File Offset: 0x007D8165
		public static void StartIVisualNovelTransitionLocation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A44F RID: 238671 RVA: 0x007D9F6E File Offset: 0x007D816E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A450 RID: 238672 RVA: 0x007D9F79 File Offset: 0x007D8179
		public static void AddLocationId(FlatBufferBuilder builder, int locationId)
		{
			builder.AddInt(1, locationId, 0);
		}

		// Token: 0x0603A451 RID: 238673 RVA: 0x007D9F84 File Offset: 0x007D8184
		public static void AddTransitionBackgroundId(FlatBufferBuilder builder, int transitionBackgroundId)
		{
			builder.AddInt(2, transitionBackgroundId, 0);
		}

		// Token: 0x0603A452 RID: 238674 RVA: 0x007D9F8F File Offset: 0x007D818F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A453 RID: 238675 RVA: 0x007D9F9A File Offset: 0x007D819A
		public static Offset<IVisualNovelTransitionLocation> EndIVisualNovelTransitionLocation(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionLocation>(builder.EndTable());
		}

		// Token: 0x0603A454 RID: 238676 RVA: 0x007D9FA8 File Offset: 0x007D81A8
		public IVisualNovelTransitionLocationT UnPack()
		{
			IVisualNovelTransitionLocationT visualNovelTransitionLocationT = new IVisualNovelTransitionLocationT();
			this.UnPackTo(visualNovelTransitionLocationT);
			return visualNovelTransitionLocationT;
		}

		// Token: 0x0603A455 RID: 238677 RVA: 0x007D9FC3 File Offset: 0x007D81C3
		public void UnPackTo(IVisualNovelTransitionLocationT _o)
		{
			_o.Type = this.Type;
			_o.LocationId = this.LocationId;
			_o.TransitionBackgroundId = this.TransitionBackgroundId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A456 RID: 238678 RVA: 0x007D9FF8 File Offset: 0x007D81F8
		public static Offset<IVisualNovelTransitionLocation> Pack(FlatBufferBuilder builder, IVisualNovelTransitionLocationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionLocation>);
			}
			return IVisualNovelTransitionLocation.CreateIVisualNovelTransitionLocation(builder, _o.Type, _o.LocationId, _o.TransitionBackgroundId, _o.NullMask);
		}

		// Token: 0x0401359A RID: 79258
		private Table __p;
	}
}

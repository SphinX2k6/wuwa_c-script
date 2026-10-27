using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E6 RID: 30182
	public struct IVisualNovelTransitionLocation : IFlatbufferObject
	{
		// Token: 0x1700E546 RID: 58694
		// (get) Token: 0x06036F9E RID: 225182 RVA: 0x00775CE0 File Offset: 0x00773EE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F9F RID: 225183 RVA: 0x00775CED File Offset: 0x00773EED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FA0 RID: 225184 RVA: 0x00775CF4 File Offset: 0x00773EF4
		public static IVisualNovelTransitionLocation GetRootAsIVisualNovelTransitionLocation(ByteBuffer _bb)
		{
			return IVisualNovelTransitionLocation.GetRootAsIVisualNovelTransitionLocation(_bb, default(IVisualNovelTransitionLocation));
		}

		// Token: 0x06036FA1 RID: 225185 RVA: 0x00775D10 File Offset: 0x00773F10
		public static IVisualNovelTransitionLocation GetRootAsIVisualNovelTransitionLocation(ByteBuffer _bb, IVisualNovelTransitionLocation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FA2 RID: 225186 RVA: 0x00775D2D File Offset: 0x00773F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FA3 RID: 225187 RVA: 0x00775D3C File Offset: 0x00773F3C
		public IVisualNovelTransitionLocation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E547 RID: 58695
		// (get) Token: 0x06036FA4 RID: 225188 RVA: 0x00775D4C File Offset: 0x00773F4C
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

		// Token: 0x1700E548 RID: 58696
		// (get) Token: 0x06036FA5 RID: 225189 RVA: 0x00775D88 File Offset: 0x00773F88
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

		// Token: 0x1700E549 RID: 58697
		// (get) Token: 0x06036FA6 RID: 225190 RVA: 0x00775DC4 File Offset: 0x00773FC4
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

		// Token: 0x1700E54A RID: 58698
		// (get) Token: 0x06036FA7 RID: 225191 RVA: 0x00775E00 File Offset: 0x00774000
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

		// Token: 0x06036FA8 RID: 225192 RVA: 0x00775E3D File Offset: 0x0077403D
		public static Offset<IVisualNovelTransitionLocation> CreateIVisualNovelTransitionLocation(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location, int LocationId = 0, int TransitionBackgroundId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelTransitionLocation.AddTransitionBackgroundId(builder, TransitionBackgroundId);
			IVisualNovelTransitionLocation.AddLocationId(builder, LocationId);
			IVisualNovelTransitionLocation.AddNullMask(builder, NullMask);
			IVisualNovelTransitionLocation.AddType(builder, Type);
			return IVisualNovelTransitionLocation.EndIVisualNovelTransitionLocation(builder);
		}

		// Token: 0x06036FA9 RID: 225193 RVA: 0x00775E69 File Offset: 0x00774069
		public static void StartIVisualNovelTransitionLocation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036FAA RID: 225194 RVA: 0x00775E72 File Offset: 0x00774072
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FAB RID: 225195 RVA: 0x00775E7D File Offset: 0x0077407D
		public static void AddLocationId(FlatBufferBuilder builder, int locationId)
		{
			builder.AddInt(1, locationId, 0);
		}

		// Token: 0x06036FAC RID: 225196 RVA: 0x00775E88 File Offset: 0x00774088
		public static void AddTransitionBackgroundId(FlatBufferBuilder builder, int transitionBackgroundId)
		{
			builder.AddInt(2, transitionBackgroundId, 0);
		}

		// Token: 0x06036FAD RID: 225197 RVA: 0x00775E93 File Offset: 0x00774093
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036FAE RID: 225198 RVA: 0x00775E9E File Offset: 0x0077409E
		public static Offset<IVisualNovelTransitionLocation> EndIVisualNovelTransitionLocation(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionLocation>(builder.EndTable());
		}

		// Token: 0x06036FAF RID: 225199 RVA: 0x00775EAC File Offset: 0x007740AC
		public IVisualNovelTransitionLocationT UnPack()
		{
			IVisualNovelTransitionLocationT visualNovelTransitionLocationT = new IVisualNovelTransitionLocationT();
			this.UnPackTo(visualNovelTransitionLocationT);
			return visualNovelTransitionLocationT;
		}

		// Token: 0x06036FB0 RID: 225200 RVA: 0x00775EC7 File Offset: 0x007740C7
		public void UnPackTo(IVisualNovelTransitionLocationT _o)
		{
			_o.Type = this.Type;
			_o.LocationId = this.LocationId;
			_o.TransitionBackgroundId = this.TransitionBackgroundId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036FB1 RID: 225201 RVA: 0x00775EFC File Offset: 0x007740FC
		public static Offset<IVisualNovelTransitionLocation> Pack(FlatBufferBuilder builder, IVisualNovelTransitionLocationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionLocation>);
			}
			return IVisualNovelTransitionLocation.CreateIVisualNovelTransitionLocation(builder, _o.Type, _o.LocationId, _o.TransitionBackgroundId, _o.NullMask);
		}

		// Token: 0x04012550 RID: 75088
		private Table __p;
	}
}

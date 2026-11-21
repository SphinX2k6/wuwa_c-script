using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C9 RID: 27081
	public struct ICheckClimb : IFlatbufferObject
	{
		// Token: 0x1700C744 RID: 51012
		// (get) Token: 0x0602E749 RID: 190281 RVA: 0x00656ADA File Offset: 0x00654CDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E74A RID: 190282 RVA: 0x00656AE7 File Offset: 0x00654CE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E74B RID: 190283 RVA: 0x00656AF0 File Offset: 0x00654CF0
		public static ICheckClimb GetRootAsICheckClimb(ByteBuffer _bb)
		{
			return ICheckClimb.GetRootAsICheckClimb(_bb, default(ICheckClimb));
		}

		// Token: 0x0602E74C RID: 190284 RVA: 0x00656B0C File Offset: 0x00654D0C
		public static ICheckClimb GetRootAsICheckClimb(ByteBuffer _bb, ICheckClimb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E74D RID: 190285 RVA: 0x00656B29 File Offset: 0x00654D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E74E RID: 190286 RVA: 0x00656B38 File Offset: 0x00654D38
		public ICheckClimb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C745 RID: 51013
		// (get) Token: 0x0602E74F RID: 190287 RVA: 0x00656B48 File Offset: 0x00654D48
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C746 RID: 51014
		// (get) Token: 0x0602E750 RID: 190288 RVA: 0x00656BA8 File Offset: 0x00654DA8
		public int Distance
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

		// Token: 0x1700C747 RID: 51015
		// (get) Token: 0x0602E751 RID: 190289 RVA: 0x00656BE4 File Offset: 0x00654DE4
		public int FallBackClimbPointId
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

		// Token: 0x1700C748 RID: 51016
		// (get) Token: 0x0602E752 RID: 190290 RVA: 0x00656C20 File Offset: 0x00654E20
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

		// Token: 0x0602E753 RID: 190291 RVA: 0x00656C5D File Offset: 0x00654E5D
		public static Offset<ICheckClimb> CreateICheckClimb(FlatBufferBuilder builder, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), int Distance = 0, int FallBackClimbPointId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICheckClimb.AddFallBackClimbPointId(builder, FallBackClimbPointId);
			ICheckClimb.AddDistance(builder, Distance);
			ICheckClimb.AddDirection(builder, DirectionOffset);
			ICheckClimb.AddNullMask(builder, NullMask);
			return ICheckClimb.EndICheckClimb(builder);
		}

		// Token: 0x0602E754 RID: 190292 RVA: 0x00656C89 File Offset: 0x00654E89
		public static void StartICheckClimb(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E755 RID: 190293 RVA: 0x00656C92 File Offset: 0x00654E92
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x0602E756 RID: 190294 RVA: 0x00656CA2 File Offset: 0x00654EA2
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(1, distance, 0);
		}

		// Token: 0x0602E757 RID: 190295 RVA: 0x00656CAD File Offset: 0x00654EAD
		public static void AddFallBackClimbPointId(FlatBufferBuilder builder, int fallBackClimbPointId)
		{
			builder.AddInt(2, fallBackClimbPointId, 0);
		}

		// Token: 0x0602E758 RID: 190296 RVA: 0x00656CB8 File Offset: 0x00654EB8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E759 RID: 190297 RVA: 0x00656CC3 File Offset: 0x00654EC3
		public static Offset<ICheckClimb> EndICheckClimb(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClimb>(builder.EndTable());
		}

		// Token: 0x0602E75A RID: 190298 RVA: 0x00656CD0 File Offset: 0x00654ED0
		public ICheckClimbT UnPack()
		{
			ICheckClimbT checkClimbT = new ICheckClimbT();
			this.UnPackTo(checkClimbT);
			return checkClimbT;
		}

		// Token: 0x0602E75B RID: 190299 RVA: 0x00656CEC File Offset: 0x00654EEC
		public void UnPackTo(ICheckClimbT _o)
		{
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Distance = this.Distance;
			_o.FallBackClimbPointId = this.FallBackClimbPointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E75C RID: 190300 RVA: 0x00656D4C File Offset: 0x00654F4C
		public static Offset<ICheckClimb> Pack(FlatBufferBuilder builder, ICheckClimbT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClimb>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckClimb.CreateICheckClimb(builder, directionOffset, _o.Distance, _o.FallBackClimbPointId, _o.NullMask);
		}

		// Token: 0x04011738 RID: 71480
		private Table __p;
	}
}

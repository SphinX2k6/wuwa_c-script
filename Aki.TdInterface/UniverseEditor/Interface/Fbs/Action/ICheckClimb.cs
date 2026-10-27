using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006358 RID: 25432
	public struct ICheckClimb : IFlatbufferObject
	{
		// Token: 0x1700BDBC RID: 48572
		// (get) Token: 0x0602BFDF RID: 180191 RVA: 0x0060B986 File Offset: 0x00609B86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFE0 RID: 180192 RVA: 0x0060B993 File Offset: 0x00609B93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFE1 RID: 180193 RVA: 0x0060B99C File Offset: 0x00609B9C
		public static ICheckClimb GetRootAsICheckClimb(ByteBuffer _bb)
		{
			return ICheckClimb.GetRootAsICheckClimb(_bb, default(ICheckClimb));
		}

		// Token: 0x0602BFE2 RID: 180194 RVA: 0x0060B9B8 File Offset: 0x00609BB8
		public static ICheckClimb GetRootAsICheckClimb(ByteBuffer _bb, ICheckClimb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BFE3 RID: 180195 RVA: 0x0060B9D5 File Offset: 0x00609BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BFE4 RID: 180196 RVA: 0x0060B9E4 File Offset: 0x00609BE4
		public ICheckClimb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDBD RID: 48573
		// (get) Token: 0x0602BFE5 RID: 180197 RVA: 0x0060B9F4 File Offset: 0x00609BF4
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

		// Token: 0x1700BDBE RID: 48574
		// (get) Token: 0x0602BFE6 RID: 180198 RVA: 0x0060BA54 File Offset: 0x00609C54
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

		// Token: 0x1700BDBF RID: 48575
		// (get) Token: 0x0602BFE7 RID: 180199 RVA: 0x0060BA90 File Offset: 0x00609C90
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

		// Token: 0x1700BDC0 RID: 48576
		// (get) Token: 0x0602BFE8 RID: 180200 RVA: 0x0060BACC File Offset: 0x00609CCC
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

		// Token: 0x0602BFE9 RID: 180201 RVA: 0x0060BB09 File Offset: 0x00609D09
		public static Offset<ICheckClimb> CreateICheckClimb(FlatBufferBuilder builder, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), int Distance = 0, int FallBackClimbPointId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICheckClimb.AddFallBackClimbPointId(builder, FallBackClimbPointId);
			ICheckClimb.AddDistance(builder, Distance);
			ICheckClimb.AddDirection(builder, DirectionOffset);
			ICheckClimb.AddNullMask(builder, NullMask);
			return ICheckClimb.EndICheckClimb(builder);
		}

		// Token: 0x0602BFEA RID: 180202 RVA: 0x0060BB35 File Offset: 0x00609D35
		public static void StartICheckClimb(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BFEB RID: 180203 RVA: 0x0060BB3E File Offset: 0x00609D3E
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x0602BFEC RID: 180204 RVA: 0x0060BB4E File Offset: 0x00609D4E
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(1, distance, 0);
		}

		// Token: 0x0602BFED RID: 180205 RVA: 0x0060BB59 File Offset: 0x00609D59
		public static void AddFallBackClimbPointId(FlatBufferBuilder builder, int fallBackClimbPointId)
		{
			builder.AddInt(2, fallBackClimbPointId, 0);
		}

		// Token: 0x0602BFEE RID: 180206 RVA: 0x0060BB64 File Offset: 0x00609D64
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602BFEF RID: 180207 RVA: 0x0060BB6F File Offset: 0x00609D6F
		public static Offset<ICheckClimb> EndICheckClimb(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClimb>(builder.EndTable());
		}

		// Token: 0x0602BFF0 RID: 180208 RVA: 0x0060BB7C File Offset: 0x00609D7C
		public ICheckClimbT UnPack()
		{
			ICheckClimbT checkClimbT = new ICheckClimbT();
			this.UnPackTo(checkClimbT);
			return checkClimbT;
		}

		// Token: 0x0602BFF1 RID: 180209 RVA: 0x0060BB98 File Offset: 0x00609D98
		public void UnPackTo(ICheckClimbT _o)
		{
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Distance = this.Distance;
			_o.FallBackClimbPointId = this.FallBackClimbPointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BFF2 RID: 180210 RVA: 0x0060BBF8 File Offset: 0x00609DF8
		public static Offset<ICheckClimb> Pack(FlatBufferBuilder builder, ICheckClimbT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClimb>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckClimb.CreateICheckClimb(builder, directionOffset, _o.Distance, _o.FallBackClimbPointId, _o.NullMask);
		}

		// Token: 0x04010923 RID: 67875
		private Table __p;
	}
}

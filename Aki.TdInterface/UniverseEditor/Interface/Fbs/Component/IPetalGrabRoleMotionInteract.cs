using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D2E RID: 23854
	public struct IPetalGrabRoleMotionInteract : IFlatbufferObject
	{
		// Token: 0x1700AF56 RID: 44886
		// (get) Token: 0x06027A51 RID: 162385 RVA: 0x0056C509 File Offset: 0x0056A709
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A52 RID: 162386 RVA: 0x0056C516 File Offset: 0x0056A716
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A53 RID: 162387 RVA: 0x0056C520 File Offset: 0x0056A720
		public static IPetalGrabRoleMotionInteract GetRootAsIPetalGrabRoleMotionInteract(ByteBuffer _bb)
		{
			return IPetalGrabRoleMotionInteract.GetRootAsIPetalGrabRoleMotionInteract(_bb, default(IPetalGrabRoleMotionInteract));
		}

		// Token: 0x06027A54 RID: 162388 RVA: 0x0056C53C File Offset: 0x0056A73C
		public static IPetalGrabRoleMotionInteract GetRootAsIPetalGrabRoleMotionInteract(ByteBuffer _bb, IPetalGrabRoleMotionInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A55 RID: 162389 RVA: 0x0056C559 File Offset: 0x0056A759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x0056C568 File Offset: 0x0056A768
		public IPetalGrabRoleMotionInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF57 RID: 44887
		// (get) Token: 0x06027A57 RID: 162391 RVA: 0x0056C578 File Offset: 0x0056A778
		public ERoleMotionInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return (ERoleMotionInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF58 RID: 44888
		// (get) Token: 0x06027A58 RID: 162392 RVA: 0x0056C5B4 File Offset: 0x0056A7B4
		public EPetalGrabHandType HandOption
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPetalGrabHandType.LeftHand;
				}
				return (EPetalGrabHandType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF59 RID: 44889
		// (get) Token: 0x06027A59 RID: 162393 RVA: 0x0056C5F0 File Offset: 0x0056A7F0
		public IPosAndRot? GrabPointOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027A5A RID: 162394 RVA: 0x0056C650 File Offset: 0x0056A850
		public IPetalGrabEvent? GrabEvents(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPetalGrabEvent?(default(IPetalGrabEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF5A RID: 44890
		// (get) Token: 0x06027A5B RID: 162395 RVA: 0x0056C6B4 File Offset: 0x0056A8B4
		public int GrabEventsLength
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

		// Token: 0x1700AF5B RID: 44891
		// (get) Token: 0x06027A5C RID: 162396 RVA: 0x0056C6E0 File Offset: 0x0056A8E0
		public int NextPointEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF5C RID: 44892
		// (get) Token: 0x06027A5D RID: 162397 RVA: 0x0056C720 File Offset: 0x0056A920
		public int FlightSplineId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF5D RID: 44893
		// (get) Token: 0x06027A5E RID: 162398 RVA: 0x0056C760 File Offset: 0x0056A960
		public TSplineMovePattern FlightSplineMovePatternType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TSplineMovePattern.NONE;
				}
				return (TSplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027A5F RID: 162399 RVA: 0x0056C7A0 File Offset: 0x0056A9A0
		public TTable? FlightSplineMovePattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027A60 RID: 162400 RVA: 0x0056C7E8 File Offset: 0x0056A9E8
		public IAirPassageMove FlightSplineMovePatternAsIAirPassageMove()
		{
			return this.FlightSplineMovePattern<IAirPassageMove>().Value;
		}

		// Token: 0x06027A61 RID: 162401 RVA: 0x0056C804 File Offset: 0x0056AA04
		public IMechaAirPassageMove FlightSplineMovePatternAsIMechaAirPassageMove()
		{
			return this.FlightSplineMovePattern<IMechaAirPassageMove>().Value;
		}

		// Token: 0x06027A62 RID: 162402 RVA: 0x0056C820 File Offset: 0x0056AA20
		public IMotorcycleTrack FlightSplineMovePatternAsIMotorcycleTrack()
		{
			return this.FlightSplineMovePattern<IMotorcycleTrack>().Value;
		}

		// Token: 0x06027A63 RID: 162403 RVA: 0x0056C83C File Offset: 0x0056AA3C
		public IPathLineMove FlightSplineMovePatternAsIPathLineMove()
		{
			return this.FlightSplineMovePattern<IPathLineMove>().Value;
		}

		// Token: 0x06027A64 RID: 162404 RVA: 0x0056C858 File Offset: 0x0056AA58
		public IPetalGrabMove FlightSplineMovePatternAsIPetalGrabMove()
		{
			return this.FlightSplineMovePattern<IPetalGrabMove>().Value;
		}

		// Token: 0x06027A65 RID: 162405 RVA: 0x0056C874 File Offset: 0x0056AA74
		public IRacingTrackMove FlightSplineMovePatternAsIRacingTrackMove()
		{
			return this.FlightSplineMovePattern<IRacingTrackMove>().Value;
		}

		// Token: 0x06027A66 RID: 162406 RVA: 0x0056C890 File Offset: 0x0056AA90
		public ISlideTrackMove FlightSplineMovePatternAsISlideTrackMove()
		{
			return this.FlightSplineMovePattern<ISlideTrackMove>().Value;
		}

		// Token: 0x1700AF5E RID: 44894
		// (get) Token: 0x06027A67 RID: 162407 RVA: 0x0056C8AC File Offset: 0x0056AAAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027A68 RID: 162408 RVA: 0x0056C8EC File Offset: 0x0056AAEC
		public static Offset<IPetalGrabRoleMotionInteract> CreateIPetalGrabRoleMotionInteract(FlatBufferBuilder builder, ERoleMotionInteractType Type = ERoleMotionInteractType.PetalGrab, EPetalGrabHandType HandOption = EPetalGrabHandType.LeftHand, Offset<IPosAndRot> GrabPointOffsetOffset = default(Offset<IPosAndRot>), VectorOffset GrabEventsOffset = default(VectorOffset), int NextPointEntityId = 0, int FlightSplineId = 0, TSplineMovePattern FlightSplineMovePattern_type = TSplineMovePattern.NONE, int FlightSplineMovePatternOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IPetalGrabRoleMotionInteract.AddFlightSplineMovePattern(builder, FlightSplineMovePatternOffset);
			IPetalGrabRoleMotionInteract.AddFlightSplineId(builder, FlightSplineId);
			IPetalGrabRoleMotionInteract.AddNextPointEntityId(builder, NextPointEntityId);
			IPetalGrabRoleMotionInteract.AddGrabEvents(builder, GrabEventsOffset);
			IPetalGrabRoleMotionInteract.AddGrabPointOffset(builder, GrabPointOffsetOffset);
			IPetalGrabRoleMotionInteract.AddNullMask(builder, NullMask);
			IPetalGrabRoleMotionInteract.AddFlightSplineMovePatternType(builder, FlightSplineMovePattern_type);
			IPetalGrabRoleMotionInteract.AddHandOption(builder, HandOption);
			IPetalGrabRoleMotionInteract.AddType(builder, Type);
			return IPetalGrabRoleMotionInteract.EndIPetalGrabRoleMotionInteract(builder);
		}

		// Token: 0x06027A69 RID: 162409 RVA: 0x0056C94C File Offset: 0x0056AB4C
		public static void StartIPetalGrabRoleMotionInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06027A6A RID: 162410 RVA: 0x0056C956 File Offset: 0x0056AB56
		public static void AddType(FlatBufferBuilder builder, ERoleMotionInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027A6B RID: 162411 RVA: 0x0056C961 File Offset: 0x0056AB61
		public static void AddHandOption(FlatBufferBuilder builder, EPetalGrabHandType handOption)
		{
			builder.AddByte(1, (byte)handOption, 0);
		}

		// Token: 0x06027A6C RID: 162412 RVA: 0x0056C96C File Offset: 0x0056AB6C
		public static void AddGrabPointOffset(FlatBufferBuilder builder, Offset<IPosAndRot> grabPointOffsetOffset)
		{
			builder.AddOffset(2, grabPointOffsetOffset.Value, 0);
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x0056C97C File Offset: 0x0056AB7C
		public static void AddGrabEvents(FlatBufferBuilder builder, VectorOffset grabEventsOffset)
		{
			builder.AddOffset(3, grabEventsOffset.Value, 0);
		}

		// Token: 0x06027A6E RID: 162414 RVA: 0x0056C98C File Offset: 0x0056AB8C
		public static VectorOffset CreateGrabEventsVector(FlatBufferBuilder builder, Offset<IPetalGrabEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A6F RID: 162415 RVA: 0x0056C9CC File Offset: 0x0056ABCC
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, Offset<IPetalGrabEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPetalGrabEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A70 RID: 162416 RVA: 0x0056C9E6 File Offset: 0x0056ABE6
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPetalGrabEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPetalGrabEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A71 RID: 162417 RVA: 0x0056CA04 File Offset: 0x0056AC04
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPetalGrabEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A72 RID: 162418 RVA: 0x0056CA1D File Offset: 0x0056AC1D
		public static void StartGrabEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A73 RID: 162419 RVA: 0x0056CA28 File Offset: 0x0056AC28
		public static void AddNextPointEntityId(FlatBufferBuilder builder, int nextPointEntityId)
		{
			builder.AddInt(4, nextPointEntityId, 0);
		}

		// Token: 0x06027A74 RID: 162420 RVA: 0x0056CA33 File Offset: 0x0056AC33
		public static void AddFlightSplineId(FlatBufferBuilder builder, int flightSplineId)
		{
			builder.AddInt(5, flightSplineId, 0);
		}

		// Token: 0x06027A75 RID: 162421 RVA: 0x0056CA3E File Offset: 0x0056AC3E
		public static void AddFlightSplineMovePatternType(FlatBufferBuilder builder, TSplineMovePattern flightSplineMovePatternType)
		{
			builder.AddByte(6, (byte)flightSplineMovePatternType, 0);
		}

		// Token: 0x06027A76 RID: 162422 RVA: 0x0056CA49 File Offset: 0x0056AC49
		public static void AddFlightSplineMovePattern(FlatBufferBuilder builder, int flightSplineMovePatternOffset)
		{
			builder.AddOffset(7, flightSplineMovePatternOffset, 0);
		}

		// Token: 0x06027A77 RID: 162423 RVA: 0x0056CA54 File Offset: 0x0056AC54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06027A78 RID: 162424 RVA: 0x0056CA5F File Offset: 0x0056AC5F
		public static Offset<IPetalGrabRoleMotionInteract> EndIPetalGrabRoleMotionInteract(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabRoleMotionInteract>(builder.EndTable());
		}

		// Token: 0x06027A79 RID: 162425 RVA: 0x0056CA6C File Offset: 0x0056AC6C
		public IPetalGrabRoleMotionInteractT UnPack()
		{
			IPetalGrabRoleMotionInteractT petalGrabRoleMotionInteractT = new IPetalGrabRoleMotionInteractT();
			this.UnPackTo(petalGrabRoleMotionInteractT);
			return petalGrabRoleMotionInteractT;
		}

		// Token: 0x06027A7A RID: 162426 RVA: 0x0056CA88 File Offset: 0x0056AC88
		public void UnPackTo(IPetalGrabRoleMotionInteractT _o)
		{
			_o.Type = this.Type;
			_o.HandOption = this.HandOption;
			_o.GrabPointOffset = ((this.GrabPointOffset != null) ? this.GrabPointOffset.Value.UnPack() : null);
			_o.GrabEvents = new List<IPetalGrabEventT>();
			for (int i = 0; i < this.GrabEventsLength; i++)
			{
				_o.GrabEvents.Add((this.GrabEvents(i) != null) ? this.GrabEvents(i).Value.UnPack() : null);
			}
			_o.NextPointEntityId = this.NextPointEntityId;
			_o.FlightSplineId = this.FlightSplineId;
			_o.FlightSplineMovePattern = new TSplineMovePatternUnion();
			_o.FlightSplineMovePattern.Type = this.FlightSplineMovePatternType;
			switch (this.FlightSplineMovePatternType)
			{
			case TSplineMovePattern.IAirPassageMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IAirPassageMove>() != null) ? this.FlightSplineMovePattern<IAirPassageMove>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.IMechaAirPassageMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IMechaAirPassageMove>() != null) ? this.FlightSplineMovePattern<IMechaAirPassageMove>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.IMotorcycleTrack:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IMotorcycleTrack>() != null) ? this.FlightSplineMovePattern<IMotorcycleTrack>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.IPathLineMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IPathLineMove>() != null) ? this.FlightSplineMovePattern<IPathLineMove>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.IPetalGrabMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IPetalGrabMove>() != null) ? this.FlightSplineMovePattern<IPetalGrabMove>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.IRacingTrackMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<IRacingTrackMove>() != null) ? this.FlightSplineMovePattern<IRacingTrackMove>().Value.UnPack() : null);
				break;
			case TSplineMovePattern.ISlideTrackMove:
				_o.FlightSplineMovePattern.Value = ((this.FlightSplineMovePattern<ISlideTrackMove>() != null) ? this.FlightSplineMovePattern<ISlideTrackMove>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027A7B RID: 162427 RVA: 0x0056CD3C File Offset: 0x0056AF3C
		public static Offset<IPetalGrabRoleMotionInteract> Pack(FlatBufferBuilder builder, IPetalGrabRoleMotionInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabRoleMotionInteract>);
			}
			Offset<IPosAndRot> grabPointOffsetOffset = (_o.GrabPointOffset == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.GrabPointOffset);
			VectorOffset grabEventsOffset = default(VectorOffset);
			if (_o.GrabEvents != null)
			{
				Offset<IPetalGrabEvent>[] array = new Offset<IPetalGrabEvent>[_o.GrabEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPetalGrabEvent.Pack(builder, _o.GrabEvents[i]);
				}
				grabEventsOffset = IPetalGrabRoleMotionInteract.CreateGrabEventsVector(builder, array);
			}
			TSplineMovePattern flightSplineMovePattern_type = (_o.FlightSplineMovePattern == null) ? TSplineMovePattern.NONE : _o.FlightSplineMovePattern.Type;
			int flightSplineMovePatternOffset = (_o.FlightSplineMovePattern == null) ? 0 : TSplineMovePatternUnion.Pack(builder, _o.FlightSplineMovePattern);
			return IPetalGrabRoleMotionInteract.CreateIPetalGrabRoleMotionInteract(builder, _o.Type, _o.HandOption, grabPointOffsetOffset, grabEventsOffset, _o.NextPointEntityId, _o.FlightSplineId, flightSplineMovePattern_type, flightSplineMovePatternOffset, _o.NullMask);
		}

		// Token: 0x0400F885 RID: 63621
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005835 RID: 22581
	public struct IFoxJumpPositionOnPathDrivenSpawnedActor : IFlatbufferObject
	{
		// Token: 0x1700A377 RID: 41847
		// (get) Token: 0x060248DD RID: 149725 RVA: 0x00505ABC File Offset: 0x00503CBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060248DE RID: 149726 RVA: 0x00505AC9 File Offset: 0x00503CC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060248DF RID: 149727 RVA: 0x00505AD0 File Offset: 0x00503CD0
		public static IFoxJumpPositionOnPathDrivenSpawnedActor GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(ByteBuffer _bb)
		{
			return IFoxJumpPositionOnPathDrivenSpawnedActor.GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(_bb, default(IFoxJumpPositionOnPathDrivenSpawnedActor));
		}

		// Token: 0x060248E0 RID: 149728 RVA: 0x00505AEC File Offset: 0x00503CEC
		public static IFoxJumpPositionOnPathDrivenSpawnedActor GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(ByteBuffer _bb, IFoxJumpPositionOnPathDrivenSpawnedActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060248E1 RID: 149729 RVA: 0x00505B09 File Offset: 0x00503D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060248E2 RID: 149730 RVA: 0x00505B18 File Offset: 0x00503D18
		public IFoxJumpPositionOnPathDrivenSpawnedActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A378 RID: 41848
		// (get) Token: 0x060248E3 RID: 149731 RVA: 0x00505B28 File Offset: 0x00503D28
		public EFoxJumpInteractPointRelationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFoxJumpInteractPointRelationType.ThisEntity;
				}
				return (EFoxJumpInteractPointRelationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A379 RID: 41849
		// (get) Token: 0x060248E4 RID: 149732 RVA: 0x00505B64 File Offset: 0x00503D64
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A37A RID: 41850
		// (get) Token: 0x060248E5 RID: 149733 RVA: 0x00505BC4 File Offset: 0x00503DC4
		public IVectorInfo? RaycastDestOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A37B RID: 41851
		// (get) Token: 0x060248E6 RID: 149734 RVA: 0x00505C24 File Offset: 0x00503E24
		public IFoxJumpShapeAndPointsParams? BottomParams
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFoxJumpShapeAndPointsParams?(default(IFoxJumpShapeAndPointsParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A37C RID: 41852
		// (get) Token: 0x060248E7 RID: 149735 RVA: 0x00505C84 File Offset: 0x00503E84
		public int BottomRangeSplineEntityId
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

		// Token: 0x1700A37D RID: 41853
		// (get) Token: 0x060248E8 RID: 149736 RVA: 0x00505CC4 File Offset: 0x00503EC4
		public IFoxJumpShapeAndPointsParams? TopParams
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IFoxJumpShapeAndPointsParams?(default(IFoxJumpShapeAndPointsParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A37E RID: 41854
		// (get) Token: 0x060248E9 RID: 149737 RVA: 0x00505D24 File Offset: 0x00503F24
		public IBoxTriggerShape? HollowShape
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IBoxTriggerShape?(default(IBoxTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A37F RID: 41855
		// (get) Token: 0x060248EA RID: 149738 RVA: 0x00505D84 File Offset: 0x00503F84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060248EB RID: 149739 RVA: 0x00505DC4 File Offset: 0x00503FC4
		public static Offset<IFoxJumpPositionOnPathDrivenSpawnedActor> CreateIFoxJumpPositionOnPathDrivenSpawnedActor(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType Type = EFoxJumpInteractPointRelationType.ThisEntity, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RaycastDestOffsetOffset = default(Offset<IVectorInfo>), Offset<IFoxJumpShapeAndPointsParams> BottomParamsOffset = default(Offset<IFoxJumpShapeAndPointsParams>), int BottomRangeSplineEntityId = 0, Offset<IFoxJumpShapeAndPointsParams> TopParamsOffset = default(Offset<IFoxJumpShapeAndPointsParams>), Offset<IBoxTriggerShape> HollowShapeOffset = default(Offset<IBoxTriggerShape>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddHollowShape(builder, HollowShapeOffset);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddTopParams(builder, TopParamsOffset);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddBottomRangeSplineEntityId(builder, BottomRangeSplineEntityId);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddBottomParams(builder, BottomParamsOffset);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddRaycastDestOffset(builder, RaycastDestOffsetOffset);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddOffset(builder, OffsetOffset);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddNullMask(builder, NullMask);
			IFoxJumpPositionOnPathDrivenSpawnedActor.AddType(builder, Type);
			return IFoxJumpPositionOnPathDrivenSpawnedActor.EndIFoxJumpPositionOnPathDrivenSpawnedActor(builder);
		}

		// Token: 0x060248EC RID: 149740 RVA: 0x00505E1B File Offset: 0x0050401B
		public static void StartIFoxJumpPositionOnPathDrivenSpawnedActor(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060248ED RID: 149741 RVA: 0x00505E24 File Offset: 0x00504024
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060248EE RID: 149742 RVA: 0x00505E2F File Offset: 0x0050402F
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060248EF RID: 149743 RVA: 0x00505E3F File Offset: 0x0050403F
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x060248F0 RID: 149744 RVA: 0x00505E4F File Offset: 0x0050404F
		public static void AddBottomParams(FlatBufferBuilder builder, Offset<IFoxJumpShapeAndPointsParams> bottomParamsOffset)
		{
			builder.AddOffset(3, bottomParamsOffset.Value, 0);
		}

		// Token: 0x060248F1 RID: 149745 RVA: 0x00505E5F File Offset: 0x0050405F
		public static void AddBottomRangeSplineEntityId(FlatBufferBuilder builder, int bottomRangeSplineEntityId)
		{
			builder.AddInt(4, bottomRangeSplineEntityId, 0);
		}

		// Token: 0x060248F2 RID: 149746 RVA: 0x00505E6A File Offset: 0x0050406A
		public static void AddTopParams(FlatBufferBuilder builder, Offset<IFoxJumpShapeAndPointsParams> topParamsOffset)
		{
			builder.AddOffset(5, topParamsOffset.Value, 0);
		}

		// Token: 0x060248F3 RID: 149747 RVA: 0x00505E7A File Offset: 0x0050407A
		public static void AddHollowShape(FlatBufferBuilder builder, Offset<IBoxTriggerShape> hollowShapeOffset)
		{
			builder.AddOffset(6, hollowShapeOffset.Value, 0);
		}

		// Token: 0x060248F4 RID: 149748 RVA: 0x00505E8A File Offset: 0x0050408A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060248F5 RID: 149749 RVA: 0x00505E95 File Offset: 0x00504095
		public static Offset<IFoxJumpPositionOnPathDrivenSpawnedActor> EndIFoxJumpPositionOnPathDrivenSpawnedActor(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpPositionOnPathDrivenSpawnedActor>(builder.EndTable());
		}

		// Token: 0x060248F6 RID: 149750 RVA: 0x00505EA4 File Offset: 0x005040A4
		public IFoxJumpPositionOnPathDrivenSpawnedActorT UnPack()
		{
			IFoxJumpPositionOnPathDrivenSpawnedActorT foxJumpPositionOnPathDrivenSpawnedActorT = new IFoxJumpPositionOnPathDrivenSpawnedActorT();
			this.UnPackTo(foxJumpPositionOnPathDrivenSpawnedActorT);
			return foxJumpPositionOnPathDrivenSpawnedActorT;
		}

		// Token: 0x060248F7 RID: 149751 RVA: 0x00505EC0 File Offset: 0x005040C0
		public void UnPackTo(IFoxJumpPositionOnPathDrivenSpawnedActorT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RaycastDestOffset = ((this.RaycastDestOffset != null) ? this.RaycastDestOffset.Value.UnPack() : null);
			_o.BottomParams = ((this.BottomParams != null) ? this.BottomParams.Value.UnPack() : null);
			_o.BottomRangeSplineEntityId = this.BottomRangeSplineEntityId;
			_o.TopParams = ((this.TopParams != null) ? this.TopParams.Value.UnPack() : null);
			_o.HollowShape = ((this.HollowShape != null) ? this.HollowShape.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060248F8 RID: 149752 RVA: 0x00505FE0 File Offset: 0x005041E0
		public static Offset<IFoxJumpPositionOnPathDrivenSpawnedActor> Pack(FlatBufferBuilder builder, IFoxJumpPositionOnPathDrivenSpawnedActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpPositionOnPathDrivenSpawnedActor>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> raycastDestOffsetOffset = (_o.RaycastDestOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RaycastDestOffset);
			Offset<IFoxJumpShapeAndPointsParams> bottomParamsOffset = (_o.BottomParams == null) ? default(Offset<IFoxJumpShapeAndPointsParams>) : IFoxJumpShapeAndPointsParams.Pack(builder, _o.BottomParams);
			Offset<IFoxJumpShapeAndPointsParams> topParamsOffset = (_o.TopParams == null) ? default(Offset<IFoxJumpShapeAndPointsParams>) : IFoxJumpShapeAndPointsParams.Pack(builder, _o.TopParams);
			Offset<IBoxTriggerShape> hollowShapeOffset = (_o.HollowShape == null) ? default(Offset<IBoxTriggerShape>) : IBoxTriggerShape.Pack(builder, _o.HollowShape);
			return IFoxJumpPositionOnPathDrivenSpawnedActor.CreateIFoxJumpPositionOnPathDrivenSpawnedActor(builder, _o.Type, offsetOffset, raycastDestOffsetOffset, bottomParamsOffset, _o.BottomRangeSplineEntityId, topParamsOffset, hollowShapeOffset, _o.NullMask);
		}

		// Token: 0x0400F062 RID: 61538
		private Table __p;
	}
}

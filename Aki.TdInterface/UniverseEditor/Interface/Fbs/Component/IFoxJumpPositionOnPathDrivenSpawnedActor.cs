using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052CA RID: 21194
	public struct IFoxJumpPositionOnPathDrivenSpawnedActor : IFlatbufferObject
	{
		// Token: 0x17009B6E RID: 39790
		// (get) Token: 0x06022919 RID: 141593 RVA: 0x004CA9C0 File Offset: 0x004C8BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x004CA9CD File Offset: 0x004C8BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602291B RID: 141595 RVA: 0x004CA9D4 File Offset: 0x004C8BD4
		public static IFoxJumpPositionOnPathDrivenSpawnedActor GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(ByteBuffer _bb)
		{
			return IFoxJumpPositionOnPathDrivenSpawnedActor.GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(_bb, default(IFoxJumpPositionOnPathDrivenSpawnedActor));
		}

		// Token: 0x0602291C RID: 141596 RVA: 0x004CA9F0 File Offset: 0x004C8BF0
		public static IFoxJumpPositionOnPathDrivenSpawnedActor GetRootAsIFoxJumpPositionOnPathDrivenSpawnedActor(ByteBuffer _bb, IFoxJumpPositionOnPathDrivenSpawnedActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602291D RID: 141597 RVA: 0x004CAA0D File Offset: 0x004C8C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602291E RID: 141598 RVA: 0x004CAA1C File Offset: 0x004C8C1C
		public IFoxJumpPositionOnPathDrivenSpawnedActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B6F RID: 39791
		// (get) Token: 0x0602291F RID: 141599 RVA: 0x004CAA2C File Offset: 0x004C8C2C
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

		// Token: 0x17009B70 RID: 39792
		// (get) Token: 0x06022920 RID: 141600 RVA: 0x004CAA68 File Offset: 0x004C8C68
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

		// Token: 0x17009B71 RID: 39793
		// (get) Token: 0x06022921 RID: 141601 RVA: 0x004CAAC8 File Offset: 0x004C8CC8
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

		// Token: 0x17009B72 RID: 39794
		// (get) Token: 0x06022922 RID: 141602 RVA: 0x004CAB28 File Offset: 0x004C8D28
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

		// Token: 0x17009B73 RID: 39795
		// (get) Token: 0x06022923 RID: 141603 RVA: 0x004CAB88 File Offset: 0x004C8D88
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

		// Token: 0x17009B74 RID: 39796
		// (get) Token: 0x06022924 RID: 141604 RVA: 0x004CABC8 File Offset: 0x004C8DC8
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

		// Token: 0x17009B75 RID: 39797
		// (get) Token: 0x06022925 RID: 141605 RVA: 0x004CAC28 File Offset: 0x004C8E28
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

		// Token: 0x17009B76 RID: 39798
		// (get) Token: 0x06022926 RID: 141606 RVA: 0x004CAC88 File Offset: 0x004C8E88
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

		// Token: 0x06022927 RID: 141607 RVA: 0x004CACC8 File Offset: 0x004C8EC8
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

		// Token: 0x06022928 RID: 141608 RVA: 0x004CAD1F File Offset: 0x004C8F1F
		public static void StartIFoxJumpPositionOnPathDrivenSpawnedActor(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06022929 RID: 141609 RVA: 0x004CAD28 File Offset: 0x004C8F28
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602292A RID: 141610 RVA: 0x004CAD33 File Offset: 0x004C8F33
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602292B RID: 141611 RVA: 0x004CAD43 File Offset: 0x004C8F43
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x0602292C RID: 141612 RVA: 0x004CAD53 File Offset: 0x004C8F53
		public static void AddBottomParams(FlatBufferBuilder builder, Offset<IFoxJumpShapeAndPointsParams> bottomParamsOffset)
		{
			builder.AddOffset(3, bottomParamsOffset.Value, 0);
		}

		// Token: 0x0602292D RID: 141613 RVA: 0x004CAD63 File Offset: 0x004C8F63
		public static void AddBottomRangeSplineEntityId(FlatBufferBuilder builder, int bottomRangeSplineEntityId)
		{
			builder.AddInt(4, bottomRangeSplineEntityId, 0);
		}

		// Token: 0x0602292E RID: 141614 RVA: 0x004CAD6E File Offset: 0x004C8F6E
		public static void AddTopParams(FlatBufferBuilder builder, Offset<IFoxJumpShapeAndPointsParams> topParamsOffset)
		{
			builder.AddOffset(5, topParamsOffset.Value, 0);
		}

		// Token: 0x0602292F RID: 141615 RVA: 0x004CAD7E File Offset: 0x004C8F7E
		public static void AddHollowShape(FlatBufferBuilder builder, Offset<IBoxTriggerShape> hollowShapeOffset)
		{
			builder.AddOffset(6, hollowShapeOffset.Value, 0);
		}

		// Token: 0x06022930 RID: 141616 RVA: 0x004CAD8E File Offset: 0x004C8F8E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06022931 RID: 141617 RVA: 0x004CAD99 File Offset: 0x004C8F99
		public static Offset<IFoxJumpPositionOnPathDrivenSpawnedActor> EndIFoxJumpPositionOnPathDrivenSpawnedActor(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpPositionOnPathDrivenSpawnedActor>(builder.EndTable());
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x004CADA8 File Offset: 0x004C8FA8
		public IFoxJumpPositionOnPathDrivenSpawnedActorT UnPack()
		{
			IFoxJumpPositionOnPathDrivenSpawnedActorT foxJumpPositionOnPathDrivenSpawnedActorT = new IFoxJumpPositionOnPathDrivenSpawnedActorT();
			this.UnPackTo(foxJumpPositionOnPathDrivenSpawnedActorT);
			return foxJumpPositionOnPathDrivenSpawnedActorT;
		}

		// Token: 0x06022933 RID: 141619 RVA: 0x004CADC4 File Offset: 0x004C8FC4
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

		// Token: 0x06022934 RID: 141620 RVA: 0x004CAEE4 File Offset: 0x004C90E4
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

		// Token: 0x0400E455 RID: 58453
		private Table __p;
	}
}

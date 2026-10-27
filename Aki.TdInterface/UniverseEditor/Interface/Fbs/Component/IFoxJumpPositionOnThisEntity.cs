using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052CD RID: 21197
	public struct IFoxJumpPositionOnThisEntity : IFlatbufferObject
	{
		// Token: 0x17009B7F RID: 39807
		// (get) Token: 0x06022947 RID: 141639 RVA: 0x004CB1A7 File Offset: 0x004C93A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022948 RID: 141640 RVA: 0x004CB1B4 File Offset: 0x004C93B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022949 RID: 141641 RVA: 0x004CB1BC File Offset: 0x004C93BC
		public static IFoxJumpPositionOnThisEntity GetRootAsIFoxJumpPositionOnThisEntity(ByteBuffer _bb)
		{
			return IFoxJumpPositionOnThisEntity.GetRootAsIFoxJumpPositionOnThisEntity(_bb, default(IFoxJumpPositionOnThisEntity));
		}

		// Token: 0x0602294A RID: 141642 RVA: 0x004CB1D8 File Offset: 0x004C93D8
		public static IFoxJumpPositionOnThisEntity GetRootAsIFoxJumpPositionOnThisEntity(ByteBuffer _bb, IFoxJumpPositionOnThisEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602294B RID: 141643 RVA: 0x004CB1F5 File Offset: 0x004C93F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602294C RID: 141644 RVA: 0x004CB204 File Offset: 0x004C9404
		public IFoxJumpPositionOnThisEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B80 RID: 39808
		// (get) Token: 0x0602294D RID: 141645 RVA: 0x004CB214 File Offset: 0x004C9414
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

		// Token: 0x17009B81 RID: 39809
		// (get) Token: 0x0602294E RID: 141646 RVA: 0x004CB250 File Offset: 0x004C9450
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

		// Token: 0x17009B82 RID: 39810
		// (get) Token: 0x0602294F RID: 141647 RVA: 0x004CB2B0 File Offset: 0x004C94B0
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

		// Token: 0x17009B83 RID: 39811
		// (get) Token: 0x06022950 RID: 141648 RVA: 0x004CB310 File Offset: 0x004C9510
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B84 RID: 39812
		// (get) Token: 0x06022951 RID: 141649 RVA: 0x004CB350 File Offset: 0x004C9550
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022952 RID: 141650 RVA: 0x004CB38D File Offset: 0x004C958D
		public static Offset<IFoxJumpPositionOnThisEntity> CreateIFoxJumpPositionOnThisEntity(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType Type = EFoxJumpInteractPointRelationType.ThisEntity, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RaycastDestOffsetOffset = default(Offset<IVectorInfo>), int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFoxJumpPositionOnThisEntity.AddSplineEntityId(builder, SplineEntityId);
			IFoxJumpPositionOnThisEntity.AddRaycastDestOffset(builder, RaycastDestOffsetOffset);
			IFoxJumpPositionOnThisEntity.AddOffset(builder, OffsetOffset);
			IFoxJumpPositionOnThisEntity.AddNullMask(builder, NullMask);
			IFoxJumpPositionOnThisEntity.AddType(builder, Type);
			return IFoxJumpPositionOnThisEntity.EndIFoxJumpPositionOnThisEntity(builder);
		}

		// Token: 0x06022953 RID: 141651 RVA: 0x004CB3C1 File Offset: 0x004C95C1
		public static void StartIFoxJumpPositionOnThisEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022954 RID: 141652 RVA: 0x004CB3CA File Offset: 0x004C95CA
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022955 RID: 141653 RVA: 0x004CB3D5 File Offset: 0x004C95D5
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x06022956 RID: 141654 RVA: 0x004CB3E5 File Offset: 0x004C95E5
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x06022957 RID: 141655 RVA: 0x004CB3F5 File Offset: 0x004C95F5
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06022958 RID: 141656 RVA: 0x004CB400 File Offset: 0x004C9600
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022959 RID: 141657 RVA: 0x004CB40B File Offset: 0x004C960B
		public static Offset<IFoxJumpPositionOnThisEntity> EndIFoxJumpPositionOnThisEntity(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpPositionOnThisEntity>(builder.EndTable());
		}

		// Token: 0x0602295A RID: 141658 RVA: 0x004CB418 File Offset: 0x004C9618
		public IFoxJumpPositionOnThisEntityT UnPack()
		{
			IFoxJumpPositionOnThisEntityT foxJumpPositionOnThisEntityT = new IFoxJumpPositionOnThisEntityT();
			this.UnPackTo(foxJumpPositionOnThisEntityT);
			return foxJumpPositionOnThisEntityT;
		}

		// Token: 0x0602295B RID: 141659 RVA: 0x004CB434 File Offset: 0x004C9634
		public void UnPackTo(IFoxJumpPositionOnThisEntityT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RaycastDestOffset = ((this.RaycastDestOffset != null) ? this.RaycastDestOffset.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602295C RID: 141660 RVA: 0x004CB4C4 File Offset: 0x004C96C4
		public static Offset<IFoxJumpPositionOnThisEntity> Pack(FlatBufferBuilder builder, IFoxJumpPositionOnThisEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpPositionOnThisEntity>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> raycastDestOffsetOffset = (_o.RaycastDestOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RaycastDestOffset);
			return IFoxJumpPositionOnThisEntity.CreateIFoxJumpPositionOnThisEntity(builder, _o.Type, offsetOffset, raycastDestOffsetOffset, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x0400E45E RID: 58462
		private Table __p;
	}
}

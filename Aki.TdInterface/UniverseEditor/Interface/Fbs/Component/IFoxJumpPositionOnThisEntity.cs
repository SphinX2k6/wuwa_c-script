using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005838 RID: 22584
	public struct IFoxJumpPositionOnThisEntity : IFlatbufferObject
	{
		// Token: 0x1700A388 RID: 41864
		// (get) Token: 0x0602490B RID: 149771 RVA: 0x005062A3 File Offset: 0x005044A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602490C RID: 149772 RVA: 0x005062B0 File Offset: 0x005044B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602490D RID: 149773 RVA: 0x005062B8 File Offset: 0x005044B8
		public static IFoxJumpPositionOnThisEntity GetRootAsIFoxJumpPositionOnThisEntity(ByteBuffer _bb)
		{
			return IFoxJumpPositionOnThisEntity.GetRootAsIFoxJumpPositionOnThisEntity(_bb, default(IFoxJumpPositionOnThisEntity));
		}

		// Token: 0x0602490E RID: 149774 RVA: 0x005062D4 File Offset: 0x005044D4
		public static IFoxJumpPositionOnThisEntity GetRootAsIFoxJumpPositionOnThisEntity(ByteBuffer _bb, IFoxJumpPositionOnThisEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602490F RID: 149775 RVA: 0x005062F1 File Offset: 0x005044F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024910 RID: 149776 RVA: 0x00506300 File Offset: 0x00504500
		public IFoxJumpPositionOnThisEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A389 RID: 41865
		// (get) Token: 0x06024911 RID: 149777 RVA: 0x00506310 File Offset: 0x00504510
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

		// Token: 0x1700A38A RID: 41866
		// (get) Token: 0x06024912 RID: 149778 RVA: 0x0050634C File Offset: 0x0050454C
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

		// Token: 0x1700A38B RID: 41867
		// (get) Token: 0x06024913 RID: 149779 RVA: 0x005063AC File Offset: 0x005045AC
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

		// Token: 0x1700A38C RID: 41868
		// (get) Token: 0x06024914 RID: 149780 RVA: 0x0050640C File Offset: 0x0050460C
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

		// Token: 0x1700A38D RID: 41869
		// (get) Token: 0x06024915 RID: 149781 RVA: 0x0050644C File Offset: 0x0050464C
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

		// Token: 0x06024916 RID: 149782 RVA: 0x00506489 File Offset: 0x00504689
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

		// Token: 0x06024917 RID: 149783 RVA: 0x005064BD File Offset: 0x005046BD
		public static void StartIFoxJumpPositionOnThisEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024918 RID: 149784 RVA: 0x005064C6 File Offset: 0x005046C6
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024919 RID: 149785 RVA: 0x005064D1 File Offset: 0x005046D1
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602491A RID: 149786 RVA: 0x005064E1 File Offset: 0x005046E1
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x0602491B RID: 149787 RVA: 0x005064F1 File Offset: 0x005046F1
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0602491C RID: 149788 RVA: 0x005064FC File Offset: 0x005046FC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602491D RID: 149789 RVA: 0x00506507 File Offset: 0x00504707
		public static Offset<IFoxJumpPositionOnThisEntity> EndIFoxJumpPositionOnThisEntity(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpPositionOnThisEntity>(builder.EndTable());
		}

		// Token: 0x0602491E RID: 149790 RVA: 0x00506514 File Offset: 0x00504714
		public IFoxJumpPositionOnThisEntityT UnPack()
		{
			IFoxJumpPositionOnThisEntityT foxJumpPositionOnThisEntityT = new IFoxJumpPositionOnThisEntityT();
			this.UnPackTo(foxJumpPositionOnThisEntityT);
			return foxJumpPositionOnThisEntityT;
		}

		// Token: 0x0602491F RID: 149791 RVA: 0x00506530 File Offset: 0x00504730
		public void UnPackTo(IFoxJumpPositionOnThisEntityT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RaycastDestOffset = ((this.RaycastDestOffset != null) ? this.RaycastDestOffset.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024920 RID: 149792 RVA: 0x005065C0 File Offset: 0x005047C0
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

		// Token: 0x0400F06B RID: 61547
		private Table __p;
	}
}

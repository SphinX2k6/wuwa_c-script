using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582F RID: 22575
	public struct IFoxJumpInteractPointRelationType : IFlatbufferObject
	{
		// Token: 0x1700A36E RID: 41838
		// (get) Token: 0x060248B5 RID: 149685 RVA: 0x005055DF File Offset: 0x005037DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060248B6 RID: 149686 RVA: 0x005055EC File Offset: 0x005037EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060248B7 RID: 149687 RVA: 0x005055F4 File Offset: 0x005037F4
		public static IFoxJumpInteractPointRelationType GetRootAsIFoxJumpInteractPointRelationType(ByteBuffer _bb)
		{
			return IFoxJumpInteractPointRelationType.GetRootAsIFoxJumpInteractPointRelationType(_bb, default(IFoxJumpInteractPointRelationType));
		}

		// Token: 0x060248B8 RID: 149688 RVA: 0x00505610 File Offset: 0x00503810
		public static IFoxJumpInteractPointRelationType GetRootAsIFoxJumpInteractPointRelationType(ByteBuffer _bb, IFoxJumpInteractPointRelationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060248B9 RID: 149689 RVA: 0x0050562D File Offset: 0x0050382D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060248BA RID: 149690 RVA: 0x0050563C File Offset: 0x0050383C
		public IFoxJumpInteractPointRelationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A36F RID: 41839
		// (get) Token: 0x060248BB RID: 149691 RVA: 0x0050564C File Offset: 0x0050384C
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

		// Token: 0x1700A370 RID: 41840
		// (get) Token: 0x060248BC RID: 149692 RVA: 0x00505688 File Offset: 0x00503888
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

		// Token: 0x1700A371 RID: 41841
		// (get) Token: 0x060248BD RID: 149693 RVA: 0x005056E8 File Offset: 0x005038E8
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

		// Token: 0x060248BE RID: 149694 RVA: 0x00505745 File Offset: 0x00503945
		public static Offset<IFoxJumpInteractPointRelationType> CreateIFoxJumpInteractPointRelationType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType Type = EFoxJumpInteractPointRelationType.ThisEntity, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RaycastDestOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFoxJumpInteractPointRelationType.AddRaycastDestOffset(builder, RaycastDestOffsetOffset);
			IFoxJumpInteractPointRelationType.AddOffset(builder, OffsetOffset);
			IFoxJumpInteractPointRelationType.AddType(builder, Type);
			return IFoxJumpInteractPointRelationType.EndIFoxJumpInteractPointRelationType(builder);
		}

		// Token: 0x060248BF RID: 149695 RVA: 0x00505769 File Offset: 0x00503969
		public static void StartIFoxJumpInteractPointRelationType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060248C0 RID: 149696 RVA: 0x00505772 File Offset: 0x00503972
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060248C1 RID: 149697 RVA: 0x0050577D File Offset: 0x0050397D
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060248C2 RID: 149698 RVA: 0x0050578D File Offset: 0x0050398D
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x060248C3 RID: 149699 RVA: 0x0050579D File Offset: 0x0050399D
		public static Offset<IFoxJumpInteractPointRelationType> EndIFoxJumpInteractPointRelationType(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpInteractPointRelationType>(builder.EndTable());
		}

		// Token: 0x060248C4 RID: 149700 RVA: 0x005057AC File Offset: 0x005039AC
		public IFoxJumpInteractPointRelationTypeT UnPack()
		{
			IFoxJumpInteractPointRelationTypeT foxJumpInteractPointRelationTypeT = new IFoxJumpInteractPointRelationTypeT();
			this.UnPackTo(foxJumpInteractPointRelationTypeT);
			return foxJumpInteractPointRelationTypeT;
		}

		// Token: 0x060248C5 RID: 149701 RVA: 0x005057C8 File Offset: 0x005039C8
		public void UnPackTo(IFoxJumpInteractPointRelationTypeT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RaycastDestOffset = ((this.RaycastDestOffset != null) ? this.RaycastDestOffset.Value.UnPack() : null);
		}

		// Token: 0x060248C6 RID: 149702 RVA: 0x00505840 File Offset: 0x00503A40
		public static Offset<IFoxJumpInteractPointRelationType> Pack(FlatBufferBuilder builder, IFoxJumpInteractPointRelationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpInteractPointRelationType>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> raycastDestOffsetOffset = (_o.RaycastDestOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RaycastDestOffset);
			return IFoxJumpInteractPointRelationType.CreateIFoxJumpInteractPointRelationType(builder, _o.Type, offsetOffset, raycastDestOffsetOffset);
		}

		// Token: 0x0400F057 RID: 61527
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C4 RID: 21188
	public struct IFoxJumpInteractPointRelationType : IFlatbufferObject
	{
		// Token: 0x17009B65 RID: 39781
		// (get) Token: 0x060228F1 RID: 141553 RVA: 0x004CA4E3 File Offset: 0x004C86E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060228F2 RID: 141554 RVA: 0x004CA4F0 File Offset: 0x004C86F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060228F3 RID: 141555 RVA: 0x004CA4F8 File Offset: 0x004C86F8
		public static IFoxJumpInteractPointRelationType GetRootAsIFoxJumpInteractPointRelationType(ByteBuffer _bb)
		{
			return IFoxJumpInteractPointRelationType.GetRootAsIFoxJumpInteractPointRelationType(_bb, default(IFoxJumpInteractPointRelationType));
		}

		// Token: 0x060228F4 RID: 141556 RVA: 0x004CA514 File Offset: 0x004C8714
		public static IFoxJumpInteractPointRelationType GetRootAsIFoxJumpInteractPointRelationType(ByteBuffer _bb, IFoxJumpInteractPointRelationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060228F5 RID: 141557 RVA: 0x004CA531 File Offset: 0x004C8731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060228F6 RID: 141558 RVA: 0x004CA540 File Offset: 0x004C8740
		public IFoxJumpInteractPointRelationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B66 RID: 39782
		// (get) Token: 0x060228F7 RID: 141559 RVA: 0x004CA550 File Offset: 0x004C8750
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

		// Token: 0x17009B67 RID: 39783
		// (get) Token: 0x060228F8 RID: 141560 RVA: 0x004CA58C File Offset: 0x004C878C
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

		// Token: 0x17009B68 RID: 39784
		// (get) Token: 0x060228F9 RID: 141561 RVA: 0x004CA5EC File Offset: 0x004C87EC
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

		// Token: 0x060228FA RID: 141562 RVA: 0x004CA649 File Offset: 0x004C8849
		public static Offset<IFoxJumpInteractPointRelationType> CreateIFoxJumpInteractPointRelationType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType Type = EFoxJumpInteractPointRelationType.ThisEntity, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RaycastDestOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFoxJumpInteractPointRelationType.AddRaycastDestOffset(builder, RaycastDestOffsetOffset);
			IFoxJumpInteractPointRelationType.AddOffset(builder, OffsetOffset);
			IFoxJumpInteractPointRelationType.AddType(builder, Type);
			return IFoxJumpInteractPointRelationType.EndIFoxJumpInteractPointRelationType(builder);
		}

		// Token: 0x060228FB RID: 141563 RVA: 0x004CA66D File Offset: 0x004C886D
		public static void StartIFoxJumpInteractPointRelationType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x004CA676 File Offset: 0x004C8876
		public static void AddType(FlatBufferBuilder builder, EFoxJumpInteractPointRelationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060228FD RID: 141565 RVA: 0x004CA681 File Offset: 0x004C8881
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060228FE RID: 141566 RVA: 0x004CA691 File Offset: 0x004C8891
		public static void AddRaycastDestOffset(FlatBufferBuilder builder, Offset<IVectorInfo> raycastDestOffsetOffset)
		{
			builder.AddOffset(2, raycastDestOffsetOffset.Value, 0);
		}

		// Token: 0x060228FF RID: 141567 RVA: 0x004CA6A1 File Offset: 0x004C88A1
		public static Offset<IFoxJumpInteractPointRelationType> EndIFoxJumpInteractPointRelationType(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpInteractPointRelationType>(builder.EndTable());
		}

		// Token: 0x06022900 RID: 141568 RVA: 0x004CA6B0 File Offset: 0x004C88B0
		public IFoxJumpInteractPointRelationTypeT UnPack()
		{
			IFoxJumpInteractPointRelationTypeT foxJumpInteractPointRelationTypeT = new IFoxJumpInteractPointRelationTypeT();
			this.UnPackTo(foxJumpInteractPointRelationTypeT);
			return foxJumpInteractPointRelationTypeT;
		}

		// Token: 0x06022901 RID: 141569 RVA: 0x004CA6CC File Offset: 0x004C88CC
		public void UnPackTo(IFoxJumpInteractPointRelationTypeT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RaycastDestOffset = ((this.RaycastDestOffset != null) ? this.RaycastDestOffset.Value.UnPack() : null);
		}

		// Token: 0x06022902 RID: 141570 RVA: 0x004CA744 File Offset: 0x004C8944
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

		// Token: 0x0400E44A RID: 58442
		private Table __p;
	}
}

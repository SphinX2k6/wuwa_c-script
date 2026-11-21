using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E0 RID: 29152
	public struct IModifyActorMaterialParamBySplineProgressExitSpline : IFlatbufferObject
	{
		// Token: 0x1700D56F RID: 54639
		// (get) Token: 0x06032B64 RID: 207716 RVA: 0x006D9C0E File Offset: 0x006D7E0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B65 RID: 207717 RVA: 0x006D9C1B File Offset: 0x006D7E1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B66 RID: 207718 RVA: 0x006D9C24 File Offset: 0x006D7E24
		public static IModifyActorMaterialParamBySplineProgressExitSpline GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressExitSpline.GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(_bb, default(IModifyActorMaterialParamBySplineProgressExitSpline));
		}

		// Token: 0x06032B67 RID: 207719 RVA: 0x006D9C40 File Offset: 0x006D7E40
		public static IModifyActorMaterialParamBySplineProgressExitSpline GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressExitSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B68 RID: 207720 RVA: 0x006D9C5D File Offset: 0x006D7E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B69 RID: 207721 RVA: 0x006D9C6C File Offset: 0x006D7E6C
		public IModifyActorMaterialParamBySplineProgressExitSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D570 RID: 54640
		// (get) Token: 0x06032B6A RID: 207722 RVA: 0x006D9C7C File Offset: 0x006D7E7C
		public EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return (EModifyActorMaterialParamBySplineProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D571 RID: 54641
		// (get) Token: 0x06032B6B RID: 207723 RVA: 0x006D9CB8 File Offset: 0x006D7EB8
		public TModifyActorMaterialParamBySplineProgressTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TModifyActorMaterialParamBySplineProgressTarget.NONE;
				}
				return (TModifyActorMaterialParamBySplineProgressTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B6C RID: 207724 RVA: 0x006D9CF4 File Offset: 0x006D7EF4
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B6D RID: 207725 RVA: 0x006D9D38 File Offset: 0x006D7F38
		public IModifyActorMaterialParamByEntitySplineProgress MoveTargetAsIModifyActorMaterialParamByEntitySplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value;
		}

		// Token: 0x06032B6E RID: 207726 RVA: 0x006D9D54 File Offset: 0x006D7F54
		public IModifyActorMaterialParamByPlayerSplineProgress MoveTargetAsIModifyActorMaterialParamByPlayerSplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value;
		}

		// Token: 0x1700D572 RID: 54642
		// (get) Token: 0x06032B6F RID: 207727 RVA: 0x006D9D70 File Offset: 0x006D7F70
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

		// Token: 0x06032B70 RID: 207728 RVA: 0x006D9DAD File Offset: 0x006D7FAD
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> CreateIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, TModifyActorMaterialParamBySplineProgressTarget MoveTarget_type = TModifyActorMaterialParamBySplineProgressTarget.NONE, int MoveTargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddMoveTarget(builder, MoveTargetOffset);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddMoveTargetType(builder, MoveTarget_type);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressExitSpline.EndIModifyActorMaterialParamBySplineProgressExitSpline(builder);
		}

		// Token: 0x06032B71 RID: 207729 RVA: 0x006D9DD9 File Offset: 0x006D7FD9
		public static void StartIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032B72 RID: 207730 RVA: 0x006D9DE2 File Offset: 0x006D7FE2
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B73 RID: 207731 RVA: 0x006D9DED File Offset: 0x006D7FED
		public static void AddMoveTargetType(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressTarget moveTargetType)
		{
			builder.AddByte(1, (byte)moveTargetType, 0);
		}

		// Token: 0x06032B74 RID: 207732 RVA: 0x006D9DF8 File Offset: 0x006D7FF8
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(2, moveTargetOffset, 0);
		}

		// Token: 0x06032B75 RID: 207733 RVA: 0x006D9E03 File Offset: 0x006D8003
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06032B76 RID: 207734 RVA: 0x006D9E0E File Offset: 0x006D800E
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> EndIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressExitSpline>(builder.EndTable());
		}

		// Token: 0x06032B77 RID: 207735 RVA: 0x006D9E1C File Offset: 0x006D801C
		public IModifyActorMaterialParamBySplineProgressExitSplineT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressExitSplineT modifyActorMaterialParamBySplineProgressExitSplineT = new IModifyActorMaterialParamBySplineProgressExitSplineT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressExitSplineT);
			return modifyActorMaterialParamBySplineProgressExitSplineT;
		}

		// Token: 0x06032B78 RID: 207736 RVA: 0x006D9E38 File Offset: 0x006D8038
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressExitSplineT _o)
		{
			_o.Type = this.Type;
			_o.MoveTarget = new TModifyActorMaterialParamBySplineProgressTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			TModifyActorMaterialParamBySplineProgressTarget moveTargetType = this.MoveTargetType;
			if (moveTargetType != TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByEntitySplineProgress)
			{
				if (moveTargetType == TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByPlayerSplineProgress)
				{
					_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value.UnPack() : null);
			}
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x06032B79 RID: 207737 RVA: 0x006D9EF8 File Offset: 0x006D80F8
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressExitSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressExitSpline>);
			}
			TModifyActorMaterialParamBySplineProgressTarget moveTarget_type = (_o.MoveTarget == null) ? TModifyActorMaterialParamBySplineProgressTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TModifyActorMaterialParamBySplineProgressTargetUnion.Pack(builder, _o.MoveTarget);
			return IModifyActorMaterialParamBySplineProgressExitSpline.CreateIModifyActorMaterialParamBySplineProgressExitSpline(builder, _o.Type, moveTarget_type, moveTargetOffset, _o.SplineEntityId);
		}

		// Token: 0x040121F7 RID: 74231
		private Table __p;
	}
}

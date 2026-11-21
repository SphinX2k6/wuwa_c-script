using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E3 RID: 29155
	public struct IModifyActorMaterialParamBySplineProgressTarget : IFlatbufferObject
	{
		// Token: 0x1700D576 RID: 54646
		// (get) Token: 0x06032B82 RID: 207746 RVA: 0x006DA01C File Offset: 0x006D821C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B83 RID: 207747 RVA: 0x006DA029 File Offset: 0x006D8229
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B84 RID: 207748 RVA: 0x006DA030 File Offset: 0x006D8230
		public static IModifyActorMaterialParamBySplineProgressTarget GetRootAsIModifyActorMaterialParamBySplineProgressTarget(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressTarget.GetRootAsIModifyActorMaterialParamBySplineProgressTarget(_bb, default(IModifyActorMaterialParamBySplineProgressTarget));
		}

		// Token: 0x06032B85 RID: 207749 RVA: 0x006DA04C File Offset: 0x006D824C
		public static IModifyActorMaterialParamBySplineProgressTarget GetRootAsIModifyActorMaterialParamBySplineProgressTarget(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B86 RID: 207750 RVA: 0x006DA069 File Offset: 0x006D8269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B87 RID: 207751 RVA: 0x006DA078 File Offset: 0x006D8278
		public IModifyActorMaterialParamBySplineProgressTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D577 RID: 54647
		// (get) Token: 0x06032B88 RID: 207752 RVA: 0x006DA088 File Offset: 0x006D8288
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B89 RID: 207753 RVA: 0x006DA0C4 File Offset: 0x006D82C4
		public static Offset<IModifyActorMaterialParamBySplineProgressTarget> CreateIModifyActorMaterialParamBySplineProgressTarget(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			IModifyActorMaterialParamBySplineProgressTarget.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressTarget.EndIModifyActorMaterialParamBySplineProgressTarget(builder);
		}

		// Token: 0x06032B8A RID: 207754 RVA: 0x006DA0DA File Offset: 0x006D82DA
		public static void StartIModifyActorMaterialParamBySplineProgressTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032B8B RID: 207755 RVA: 0x006DA0E3 File Offset: 0x006D82E3
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B8C RID: 207756 RVA: 0x006DA0EE File Offset: 0x006D82EE
		public static Offset<IModifyActorMaterialParamBySplineProgressTarget> EndIModifyActorMaterialParamBySplineProgressTarget(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressTarget>(builder.EndTable());
		}

		// Token: 0x06032B8D RID: 207757 RVA: 0x006DA0FC File Offset: 0x006D82FC
		public IModifyActorMaterialParamBySplineProgressTargetT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressTargetT modifyActorMaterialParamBySplineProgressTargetT = new IModifyActorMaterialParamBySplineProgressTargetT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressTargetT);
			return modifyActorMaterialParamBySplineProgressTargetT;
		}

		// Token: 0x06032B8E RID: 207758 RVA: 0x006DA117 File Offset: 0x006D8317
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032B8F RID: 207759 RVA: 0x006DA128 File Offset: 0x006D8328
		public static Offset<IModifyActorMaterialParamBySplineProgressTarget> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressTarget>);
			}
			return IModifyActorMaterialParamBySplineProgressTarget.CreateIModifyActorMaterialParamBySplineProgressTarget(builder, _o.Type);
		}

		// Token: 0x040121FB RID: 74235
		private Table __p;
	}
}

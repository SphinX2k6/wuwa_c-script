using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D1 RID: 29137
	public struct IModifyActorMaterialParamByPlayerSplineProgress : IFlatbufferObject
	{
		// Token: 0x1700D557 RID: 54615
		// (get) Token: 0x06032AE8 RID: 207592 RVA: 0x006D8BFA File Offset: 0x006D6DFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AE9 RID: 207593 RVA: 0x006D8C07 File Offset: 0x006D6E07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AEA RID: 207594 RVA: 0x006D8C10 File Offset: 0x006D6E10
		public static IModifyActorMaterialParamByPlayerSplineProgress GetRootAsIModifyActorMaterialParamByPlayerSplineProgress(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamByPlayerSplineProgress.GetRootAsIModifyActorMaterialParamByPlayerSplineProgress(_bb, default(IModifyActorMaterialParamByPlayerSplineProgress));
		}

		// Token: 0x06032AEB RID: 207595 RVA: 0x006D8C2C File Offset: 0x006D6E2C
		public static IModifyActorMaterialParamByPlayerSplineProgress GetRootAsIModifyActorMaterialParamByPlayerSplineProgress(ByteBuffer _bb, IModifyActorMaterialParamByPlayerSplineProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AEC RID: 207596 RVA: 0x006D8C49 File Offset: 0x006D6E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AED RID: 207597 RVA: 0x006D8C58 File Offset: 0x006D6E58
		public IModifyActorMaterialParamByPlayerSplineProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D558 RID: 54616
		// (get) Token: 0x06032AEE RID: 207598 RVA: 0x006D8C68 File Offset: 0x006D6E68
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

		// Token: 0x06032AEF RID: 207599 RVA: 0x006D8CA4 File Offset: 0x006D6EA4
		public static Offset<IModifyActorMaterialParamByPlayerSplineProgress> CreateIModifyActorMaterialParamByPlayerSplineProgress(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			IModifyActorMaterialParamByPlayerSplineProgress.AddType(builder, Type);
			return IModifyActorMaterialParamByPlayerSplineProgress.EndIModifyActorMaterialParamByPlayerSplineProgress(builder);
		}

		// Token: 0x06032AF0 RID: 207600 RVA: 0x006D8CBA File Offset: 0x006D6EBA
		public static void StartIModifyActorMaterialParamByPlayerSplineProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032AF1 RID: 207601 RVA: 0x006D8CC3 File Offset: 0x006D6EC3
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032AF2 RID: 207602 RVA: 0x006D8CCE File Offset: 0x006D6ECE
		public static Offset<IModifyActorMaterialParamByPlayerSplineProgress> EndIModifyActorMaterialParamByPlayerSplineProgress(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamByPlayerSplineProgress>(builder.EndTable());
		}

		// Token: 0x06032AF3 RID: 207603 RVA: 0x006D8CDC File Offset: 0x006D6EDC
		public IModifyActorMaterialParamByPlayerSplineProgressT UnPack()
		{
			IModifyActorMaterialParamByPlayerSplineProgressT modifyActorMaterialParamByPlayerSplineProgressT = new IModifyActorMaterialParamByPlayerSplineProgressT();
			this.UnPackTo(modifyActorMaterialParamByPlayerSplineProgressT);
			return modifyActorMaterialParamByPlayerSplineProgressT;
		}

		// Token: 0x06032AF4 RID: 207604 RVA: 0x006D8CF7 File Offset: 0x006D6EF7
		public void UnPackTo(IModifyActorMaterialParamByPlayerSplineProgressT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032AF5 RID: 207605 RVA: 0x006D8D08 File Offset: 0x006D6F08
		public static Offset<IModifyActorMaterialParamByPlayerSplineProgress> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamByPlayerSplineProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamByPlayerSplineProgress>);
			}
			return IModifyActorMaterialParamByPlayerSplineProgress.CreateIModifyActorMaterialParamByPlayerSplineProgress(builder, _o.Type);
		}

		// Token: 0x040121E3 RID: 74211
		private Table __p;
	}
}

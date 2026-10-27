using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAC RID: 27308
	public struct IModifyActorMaterialParamBySplineProgressConfig : IFlatbufferObject
	{
		// Token: 0x1700CAA5 RID: 51877
		// (get) Token: 0x0602FDAC RID: 196012 RVA: 0x00682A31 File Offset: 0x00680C31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDAD RID: 196013 RVA: 0x00682A3E File Offset: 0x00680C3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDAE RID: 196014 RVA: 0x00682A48 File Offset: 0x00680C48
		public static IModifyActorMaterialParamBySplineProgressConfig GetRootAsIModifyActorMaterialParamBySplineProgressConfig(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressConfig.GetRootAsIModifyActorMaterialParamBySplineProgressConfig(_bb, default(IModifyActorMaterialParamBySplineProgressConfig));
		}

		// Token: 0x0602FDAF RID: 196015 RVA: 0x00682A64 File Offset: 0x00680C64
		public static IModifyActorMaterialParamBySplineProgressConfig GetRootAsIModifyActorMaterialParamBySplineProgressConfig(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDB0 RID: 196016 RVA: 0x00682A81 File Offset: 0x00680C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDB1 RID: 196017 RVA: 0x00682A90 File Offset: 0x00680C90
		public IModifyActorMaterialParamBySplineProgressConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAA6 RID: 51878
		// (get) Token: 0x0602FDB2 RID: 196018 RVA: 0x00682AA0 File Offset: 0x00680CA0
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

		// Token: 0x1700CAA7 RID: 51879
		// (get) Token: 0x0602FDB3 RID: 196019 RVA: 0x00682ADC File Offset: 0x00680CDC
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FDB4 RID: 196020 RVA: 0x00682B18 File Offset: 0x00680D18
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> CreateIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			IModifyActorMaterialParamBySplineProgressConfig.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressConfig.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressConfig.EndIModifyActorMaterialParamBySplineProgressConfig(builder);
		}

		// Token: 0x0602FDB5 RID: 196021 RVA: 0x00682B35 File Offset: 0x00680D35
		public static void StartIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FDB6 RID: 196022 RVA: 0x00682B3E File Offset: 0x00680D3E
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FDB7 RID: 196023 RVA: 0x00682B49 File Offset: 0x00680D49
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602FDB8 RID: 196024 RVA: 0x00682B54 File Offset: 0x00680D54
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> EndIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressConfig>(builder.EndTable());
		}

		// Token: 0x0602FDB9 RID: 196025 RVA: 0x00682B64 File Offset: 0x00680D64
		public IModifyActorMaterialParamBySplineProgressConfigT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressConfigT modifyActorMaterialParamBySplineProgressConfigT = new IModifyActorMaterialParamBySplineProgressConfigT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressConfigT);
			return modifyActorMaterialParamBySplineProgressConfigT;
		}

		// Token: 0x0602FDBA RID: 196026 RVA: 0x00682B7F File Offset: 0x00680D7F
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressConfigT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602FDBB RID: 196027 RVA: 0x00682B9C File Offset: 0x00680D9C
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressConfig>);
			}
			return IModifyActorMaterialParamBySplineProgressConfig.CreateIModifyActorMaterialParamBySplineProgressConfig(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x040112E7 RID: 70375
		private Table __p;
	}
}

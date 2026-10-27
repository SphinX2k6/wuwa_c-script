using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB5 RID: 27317
	public struct IModifyActorMaterialParamBySplineProgressExitSpline : IFlatbufferObject
	{
		// Token: 0x1700CAB3 RID: 51891
		// (get) Token: 0x0602FDF0 RID: 196080 RVA: 0x006831B3 File Offset: 0x006813B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDF1 RID: 196081 RVA: 0x006831C0 File Offset: 0x006813C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDF2 RID: 196082 RVA: 0x006831C8 File Offset: 0x006813C8
		public static IModifyActorMaterialParamBySplineProgressExitSpline GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressExitSpline.GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(_bb, default(IModifyActorMaterialParamBySplineProgressExitSpline));
		}

		// Token: 0x0602FDF3 RID: 196083 RVA: 0x006831E4 File Offset: 0x006813E4
		public static IModifyActorMaterialParamBySplineProgressExitSpline GetRootAsIModifyActorMaterialParamBySplineProgressExitSpline(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressExitSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDF4 RID: 196084 RVA: 0x00683201 File Offset: 0x00681401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDF5 RID: 196085 RVA: 0x00683210 File Offset: 0x00681410
		public IModifyActorMaterialParamBySplineProgressExitSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAB4 RID: 51892
		// (get) Token: 0x0602FDF6 RID: 196086 RVA: 0x00683220 File Offset: 0x00681420
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

		// Token: 0x1700CAB5 RID: 51893
		// (get) Token: 0x0602FDF7 RID: 196087 RVA: 0x0068325C File Offset: 0x0068145C
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

		// Token: 0x0602FDF8 RID: 196088 RVA: 0x00683298 File Offset: 0x00681498
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> CreateIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressExitSpline.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressExitSpline.EndIModifyActorMaterialParamBySplineProgressExitSpline(builder);
		}

		// Token: 0x0602FDF9 RID: 196089 RVA: 0x006832B5 File Offset: 0x006814B5
		public static void StartIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FDFA RID: 196090 RVA: 0x006832BE File Offset: 0x006814BE
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FDFB RID: 196091 RVA: 0x006832C9 File Offset: 0x006814C9
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602FDFC RID: 196092 RVA: 0x006832D4 File Offset: 0x006814D4
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> EndIModifyActorMaterialParamBySplineProgressExitSpline(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressExitSpline>(builder.EndTable());
		}

		// Token: 0x0602FDFD RID: 196093 RVA: 0x006832E4 File Offset: 0x006814E4
		public IModifyActorMaterialParamBySplineProgressExitSplineT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressExitSplineT modifyActorMaterialParamBySplineProgressExitSplineT = new IModifyActorMaterialParamBySplineProgressExitSplineT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressExitSplineT);
			return modifyActorMaterialParamBySplineProgressExitSplineT;
		}

		// Token: 0x0602FDFE RID: 196094 RVA: 0x006832FF File Offset: 0x006814FF
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressExitSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602FDFF RID: 196095 RVA: 0x0068331C File Offset: 0x0068151C
		public static Offset<IModifyActorMaterialParamBySplineProgressExitSpline> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressExitSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressExitSpline>);
			}
			return IModifyActorMaterialParamBySplineProgressExitSpline.CreateIModifyActorMaterialParamBySplineProgressExitSpline(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x040112F5 RID: 70389
		private Table __p;
	}
}

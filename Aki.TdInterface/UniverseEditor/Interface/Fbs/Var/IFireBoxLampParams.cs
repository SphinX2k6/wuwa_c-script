using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A96 RID: 14998
	public struct IFireBoxLampParams : IFlatbufferObject
	{
		// Token: 0x170066C0 RID: 26304
		// (get) Token: 0x0601459E RID: 83358 RVA: 0x002F8178 File Offset: 0x002F6378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601459F RID: 83359 RVA: 0x002F8185 File Offset: 0x002F6385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060145A0 RID: 83360 RVA: 0x002F818C File Offset: 0x002F638C
		public static IFireBoxLampParams GetRootAsIFireBoxLampParams(ByteBuffer _bb)
		{
			return IFireBoxLampParams.GetRootAsIFireBoxLampParams(_bb, default(IFireBoxLampParams));
		}

		// Token: 0x060145A1 RID: 83361 RVA: 0x002F81A8 File Offset: 0x002F63A8
		public static IFireBoxLampParams GetRootAsIFireBoxLampParams(ByteBuffer _bb, IFireBoxLampParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060145A2 RID: 83362 RVA: 0x002F81C5 File Offset: 0x002F63C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060145A3 RID: 83363 RVA: 0x002F81D4 File Offset: 0x002F63D4
		public IFireBoxLampParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x060145A4 RID: 83364 RVA: 0x002F81E4 File Offset: 0x002F63E4
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x060145A5 RID: 83365 RVA: 0x002F8220 File Offset: 0x002F6420
		public float RangeRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060145A6 RID: 83366 RVA: 0x002F8260 File Offset: 0x002F6460
		public static Offset<IFireBoxLampParams> CreateIFireBoxLampParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, float RangeRadius = 0f)
		{
			builder.StartTable(2);
			IFireBoxLampParams.AddRangeRadius(builder, RangeRadius);
			IFireBoxLampParams.AddType(builder, Type);
			return IFireBoxLampParams.EndIFireBoxLampParams(builder);
		}

		// Token: 0x060145A7 RID: 83367 RVA: 0x002F827D File Offset: 0x002F647D
		public static void StartIFireBoxLampParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060145A8 RID: 83368 RVA: 0x002F8286 File Offset: 0x002F6486
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x002F8291 File Offset: 0x002F6491
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x060145AA RID: 83370 RVA: 0x002F82A4 File Offset: 0x002F64A4
		public static Offset<IFireBoxLampParams> EndIFireBoxLampParams(FlatBufferBuilder builder)
		{
			return new Offset<IFireBoxLampParams>(builder.EndTable());
		}

		// Token: 0x060145AB RID: 83371 RVA: 0x002F82B4 File Offset: 0x002F64B4
		public IFireBoxLampParamsT UnPack()
		{
			IFireBoxLampParamsT fireBoxLampParamsT = new IFireBoxLampParamsT();
			this.UnPackTo(fireBoxLampParamsT);
			return fireBoxLampParamsT;
		}

		// Token: 0x060145AC RID: 83372 RVA: 0x002F82CF File Offset: 0x002F64CF
		public void UnPackTo(IFireBoxLampParamsT _o)
		{
			_o.Type = this.Type;
			_o.RangeRadius = this.RangeRadius;
		}

		// Token: 0x060145AD RID: 83373 RVA: 0x002F82EC File Offset: 0x002F64EC
		public static Offset<IFireBoxLampParams> Pack(FlatBufferBuilder builder, IFireBoxLampParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBoxLampParams>);
			}
			return IFireBoxLampParams.CreateIFireBoxLampParams(builder, _o.Type, _o.RangeRadius);
		}

		// Token: 0x0400AF16 RID: 44822
		private Table __p;
	}
}

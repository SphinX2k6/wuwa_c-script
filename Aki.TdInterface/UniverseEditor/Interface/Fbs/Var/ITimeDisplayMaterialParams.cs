using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AED RID: 15085
	public struct ITimeDisplayMaterialParams : IFlatbufferObject
	{
		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x060148D4 RID: 84180 RVA: 0x002FE1E8 File Offset: 0x002FC3E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060148D5 RID: 84181 RVA: 0x002FE1F5 File Offset: 0x002FC3F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060148D6 RID: 84182 RVA: 0x002FE1FC File Offset: 0x002FC3FC
		public static ITimeDisplayMaterialParams GetRootAsITimeDisplayMaterialParams(ByteBuffer _bb)
		{
			return ITimeDisplayMaterialParams.GetRootAsITimeDisplayMaterialParams(_bb, default(ITimeDisplayMaterialParams));
		}

		// Token: 0x060148D7 RID: 84183 RVA: 0x002FE218 File Offset: 0x002FC418
		public static ITimeDisplayMaterialParams GetRootAsITimeDisplayMaterialParams(ByteBuffer _bb, ITimeDisplayMaterialParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060148D8 RID: 84184 RVA: 0x002FE235 File Offset: 0x002FC435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060148D9 RID: 84185 RVA: 0x002FE244 File Offset: 0x002FC444
		public ITimeDisplayMaterialParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006776 RID: 26486
		// (get) Token: 0x060148DA RID: 84186 RVA: 0x002FE254 File Offset: 0x002FC454
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

		// Token: 0x17006777 RID: 26487
		// (get) Token: 0x060148DB RID: 84187 RVA: 0x002FE290 File Offset: 0x002FC490
		public TTimeDisplayParams TimeDisplayParamsType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTimeDisplayParams.NONE;
				}
				return (TTimeDisplayParams)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060148DC RID: 84188 RVA: 0x002FE2CC File Offset: 0x002FC4CC
		public TTable? TimeDisplayParams<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060148DD RID: 84189 RVA: 0x002FE310 File Offset: 0x002FC510
		public ITimeDisplayParamsConstant TimeDisplayParamsAsITimeDisplayParamsConstant()
		{
			return this.TimeDisplayParams<ITimeDisplayParamsConstant>().Value;
		}

		// Token: 0x060148DE RID: 84190 RVA: 0x002FE32C File Offset: 0x002FC52C
		public ITimeDisplayParamsVar TimeDisplayParamsAsITimeDisplayParamsVar()
		{
			return this.TimeDisplayParams<ITimeDisplayParamsVar>().Value;
		}

		// Token: 0x060148DF RID: 84191 RVA: 0x002FE347 File Offset: 0x002FC547
		public static Offset<ITimeDisplayMaterialParams> CreateITimeDisplayMaterialParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, TTimeDisplayParams TimeDisplayParams_type = TTimeDisplayParams.NONE, int TimeDisplayParamsOffset = 0)
		{
			builder.StartTable(3);
			ITimeDisplayMaterialParams.AddTimeDisplayParams(builder, TimeDisplayParamsOffset);
			ITimeDisplayMaterialParams.AddTimeDisplayParamsType(builder, TimeDisplayParams_type);
			ITimeDisplayMaterialParams.AddType(builder, Type);
			return ITimeDisplayMaterialParams.EndITimeDisplayMaterialParams(builder);
		}

		// Token: 0x060148E0 RID: 84192 RVA: 0x002FE36B File Offset: 0x002FC56B
		public static void StartITimeDisplayMaterialParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060148E1 RID: 84193 RVA: 0x002FE374 File Offset: 0x002FC574
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060148E2 RID: 84194 RVA: 0x002FE37F File Offset: 0x002FC57F
		public static void AddTimeDisplayParamsType(FlatBufferBuilder builder, TTimeDisplayParams timeDisplayParamsType)
		{
			builder.AddByte(1, (byte)timeDisplayParamsType, 0);
		}

		// Token: 0x060148E3 RID: 84195 RVA: 0x002FE38A File Offset: 0x002FC58A
		public static void AddTimeDisplayParams(FlatBufferBuilder builder, int timeDisplayParamsOffset)
		{
			builder.AddOffset(2, timeDisplayParamsOffset, 0);
		}

		// Token: 0x060148E4 RID: 84196 RVA: 0x002FE395 File Offset: 0x002FC595
		public static Offset<ITimeDisplayMaterialParams> EndITimeDisplayMaterialParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayMaterialParams>(builder.EndTable());
		}

		// Token: 0x060148E5 RID: 84197 RVA: 0x002FE3A4 File Offset: 0x002FC5A4
		public ITimeDisplayMaterialParamsT UnPack()
		{
			ITimeDisplayMaterialParamsT timeDisplayMaterialParamsT = new ITimeDisplayMaterialParamsT();
			this.UnPackTo(timeDisplayMaterialParamsT);
			return timeDisplayMaterialParamsT;
		}

		// Token: 0x060148E6 RID: 84198 RVA: 0x002FE3C0 File Offset: 0x002FC5C0
		public void UnPackTo(ITimeDisplayMaterialParamsT _o)
		{
			_o.Type = this.Type;
			_o.TimeDisplayParams = new TTimeDisplayParamsUnion();
			_o.TimeDisplayParams.Type = this.TimeDisplayParamsType;
			TTimeDisplayParams timeDisplayParamsType = this.TimeDisplayParamsType;
			if (timeDisplayParamsType == TTimeDisplayParams.ITimeDisplayParamsConstant)
			{
				_o.TimeDisplayParams.Value = ((this.TimeDisplayParams<ITimeDisplayParamsConstant>() != null) ? this.TimeDisplayParams<ITimeDisplayParamsConstant>().Value.UnPack() : null);
				return;
			}
			if (timeDisplayParamsType != TTimeDisplayParams.ITimeDisplayParamsVar)
			{
				return;
			}
			_o.TimeDisplayParams.Value = ((this.TimeDisplayParams<ITimeDisplayParamsVar>() != null) ? this.TimeDisplayParams<ITimeDisplayParamsVar>().Value.UnPack() : null);
		}

		// Token: 0x060148E7 RID: 84199 RVA: 0x002FE470 File Offset: 0x002FC670
		public static Offset<ITimeDisplayMaterialParams> Pack(FlatBufferBuilder builder, ITimeDisplayMaterialParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayMaterialParams>);
			}
			TTimeDisplayParams timeDisplayParams_type = (_o.TimeDisplayParams == null) ? TTimeDisplayParams.NONE : _o.TimeDisplayParams.Type;
			int timeDisplayParamsOffset = (_o.TimeDisplayParams == null) ? 0 : TTimeDisplayParamsUnion.Pack(builder, _o.TimeDisplayParams);
			return ITimeDisplayMaterialParams.CreateITimeDisplayMaterialParams(builder, _o.Type, timeDisplayParams_type, timeDisplayParamsOffset);
		}

		// Token: 0x0400AFB0 RID: 44976
		private Table __p;
	}
}

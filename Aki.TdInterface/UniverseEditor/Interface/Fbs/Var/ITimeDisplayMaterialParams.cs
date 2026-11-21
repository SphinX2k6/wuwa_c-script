using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EEF RID: 16111
	public struct ITimeDisplayMaterialParams : IFlatbufferObject
	{
		// Token: 0x17006D10 RID: 27920
		// (get) Token: 0x06015D7E RID: 89470 RVA: 0x00324478 File Offset: 0x00322678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D7F RID: 89471 RVA: 0x00324485 File Offset: 0x00322685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D80 RID: 89472 RVA: 0x0032448C File Offset: 0x0032268C
		public static ITimeDisplayMaterialParams GetRootAsITimeDisplayMaterialParams(ByteBuffer _bb)
		{
			return ITimeDisplayMaterialParams.GetRootAsITimeDisplayMaterialParams(_bb, default(ITimeDisplayMaterialParams));
		}

		// Token: 0x06015D81 RID: 89473 RVA: 0x003244A8 File Offset: 0x003226A8
		public static ITimeDisplayMaterialParams GetRootAsITimeDisplayMaterialParams(ByteBuffer _bb, ITimeDisplayMaterialParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D82 RID: 89474 RVA: 0x003244C5 File Offset: 0x003226C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D83 RID: 89475 RVA: 0x003244D4 File Offset: 0x003226D4
		public ITimeDisplayMaterialParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D11 RID: 27921
		// (get) Token: 0x06015D84 RID: 89476 RVA: 0x003244E4 File Offset: 0x003226E4
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

		// Token: 0x17006D12 RID: 27922
		// (get) Token: 0x06015D85 RID: 89477 RVA: 0x00324520 File Offset: 0x00322720
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

		// Token: 0x06015D86 RID: 89478 RVA: 0x0032455C File Offset: 0x0032275C
		public TTable? TimeDisplayParams<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015D87 RID: 89479 RVA: 0x003245A0 File Offset: 0x003227A0
		public ITimeDisplayParamsConstant TimeDisplayParamsAsITimeDisplayParamsConstant()
		{
			return this.TimeDisplayParams<ITimeDisplayParamsConstant>().Value;
		}

		// Token: 0x06015D88 RID: 89480 RVA: 0x003245BC File Offset: 0x003227BC
		public ITimeDisplayParamsVar TimeDisplayParamsAsITimeDisplayParamsVar()
		{
			return this.TimeDisplayParams<ITimeDisplayParamsVar>().Value;
		}

		// Token: 0x06015D89 RID: 89481 RVA: 0x003245D7 File Offset: 0x003227D7
		public static Offset<ITimeDisplayMaterialParams> CreateITimeDisplayMaterialParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, TTimeDisplayParams TimeDisplayParams_type = TTimeDisplayParams.NONE, int TimeDisplayParamsOffset = 0)
		{
			builder.StartTable(3);
			ITimeDisplayMaterialParams.AddTimeDisplayParams(builder, TimeDisplayParamsOffset);
			ITimeDisplayMaterialParams.AddTimeDisplayParamsType(builder, TimeDisplayParams_type);
			ITimeDisplayMaterialParams.AddType(builder, Type);
			return ITimeDisplayMaterialParams.EndITimeDisplayMaterialParams(builder);
		}

		// Token: 0x06015D8A RID: 89482 RVA: 0x003245FB File Offset: 0x003227FB
		public static void StartITimeDisplayMaterialParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015D8B RID: 89483 RVA: 0x00324604 File Offset: 0x00322804
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D8C RID: 89484 RVA: 0x0032460F File Offset: 0x0032280F
		public static void AddTimeDisplayParamsType(FlatBufferBuilder builder, TTimeDisplayParams timeDisplayParamsType)
		{
			builder.AddByte(1, (byte)timeDisplayParamsType, 0);
		}

		// Token: 0x06015D8D RID: 89485 RVA: 0x0032461A File Offset: 0x0032281A
		public static void AddTimeDisplayParams(FlatBufferBuilder builder, int timeDisplayParamsOffset)
		{
			builder.AddOffset(2, timeDisplayParamsOffset, 0);
		}

		// Token: 0x06015D8E RID: 89486 RVA: 0x00324625 File Offset: 0x00322825
		public static Offset<ITimeDisplayMaterialParams> EndITimeDisplayMaterialParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayMaterialParams>(builder.EndTable());
		}

		// Token: 0x06015D8F RID: 89487 RVA: 0x00324634 File Offset: 0x00322834
		public ITimeDisplayMaterialParamsT UnPack()
		{
			ITimeDisplayMaterialParamsT timeDisplayMaterialParamsT = new ITimeDisplayMaterialParamsT();
			this.UnPackTo(timeDisplayMaterialParamsT);
			return timeDisplayMaterialParamsT;
		}

		// Token: 0x06015D90 RID: 89488 RVA: 0x00324650 File Offset: 0x00322850
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

		// Token: 0x06015D91 RID: 89489 RVA: 0x00324700 File Offset: 0x00322900
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

		// Token: 0x0400B91D RID: 47389
		private Table __p;
	}
}

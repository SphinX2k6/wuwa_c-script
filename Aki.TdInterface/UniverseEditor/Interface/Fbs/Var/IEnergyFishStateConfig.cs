using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7D RID: 15997
	public struct IEnergyFishStateConfig : IFlatbufferObject
	{
		// Token: 0x17006C16 RID: 27670
		// (get) Token: 0x0601593E RID: 88382 RVA: 0x0031C34D File Offset: 0x0031A54D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x0031C35A File Offset: 0x0031A55A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015940 RID: 88384 RVA: 0x0031C364 File Offset: 0x0031A564
		public static IEnergyFishStateConfig GetRootAsIEnergyFishStateConfig(ByteBuffer _bb)
		{
			return IEnergyFishStateConfig.GetRootAsIEnergyFishStateConfig(_bb, default(IEnergyFishStateConfig));
		}

		// Token: 0x06015941 RID: 88385 RVA: 0x0031C380 File Offset: 0x0031A580
		public static IEnergyFishStateConfig GetRootAsIEnergyFishStateConfig(ByteBuffer _bb, IEnergyFishStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015942 RID: 88386 RVA: 0x0031C39D File Offset: 0x0031A59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015943 RID: 88387 RVA: 0x0031C3AC File Offset: 0x0031A5AC
		public IEnergyFishStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C17 RID: 27671
		// (get) Token: 0x06015944 RID: 88388 RVA: 0x0031C3BC File Offset: 0x0031A5BC
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015945 RID: 88389 RVA: 0x0031C3F3 File Offset: 0x0031A5F3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06015946 RID: 88390 RVA: 0x0031C402 File Offset: 0x0031A602
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006C18 RID: 27672
		// (get) Token: 0x06015947 RID: 88391 RVA: 0x0031C410 File Offset: 0x0031A610
		public TEnergyFishState ParamsType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TEnergyFishState.NONE;
				}
				return (TEnergyFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015948 RID: 88392 RVA: 0x0031C44C File Offset: 0x0031A64C
		public TTable? Params<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015949 RID: 88393 RVA: 0x0031C490 File Offset: 0x0031A690
		public IEnergyFishFollowState ParamsAsIEnergyFishFollowState()
		{
			return this.Params<IEnergyFishFollowState>().Value;
		}

		// Token: 0x0601594A RID: 88394 RVA: 0x0031C4AC File Offset: 0x0031A6AC
		public IEnergyFishSplineState ParamsAsIEnergyFishSplineState()
		{
			return this.Params<IEnergyFishSplineState>().Value;
		}

		// Token: 0x0601594B RID: 88395 RVA: 0x0031C4C7 File Offset: 0x0031A6C7
		public static Offset<IEnergyFishStateConfig> CreateIEnergyFishStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), TEnergyFishState Params_type = TEnergyFishState.NONE, int ParamsOffset = 0)
		{
			builder.StartTable(3);
			IEnergyFishStateConfig.AddParams(builder, ParamsOffset);
			IEnergyFishStateConfig.AddState(builder, StateOffset);
			IEnergyFishStateConfig.AddParamsType(builder, Params_type);
			return IEnergyFishStateConfig.EndIEnergyFishStateConfig(builder);
		}

		// Token: 0x0601594C RID: 88396 RVA: 0x0031C4EB File Offset: 0x0031A6EB
		public static void StartIEnergyFishStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601594D RID: 88397 RVA: 0x0031C4F4 File Offset: 0x0031A6F4
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0601594E RID: 88398 RVA: 0x0031C504 File Offset: 0x0031A704
		public static void AddParamsType(FlatBufferBuilder builder, TEnergyFishState paramsType)
		{
			builder.AddByte(1, (byte)paramsType, 0);
		}

		// Token: 0x0601594F RID: 88399 RVA: 0x0031C50F File Offset: 0x0031A70F
		public static void AddParams(FlatBufferBuilder builder, int paramsOffset)
		{
			builder.AddOffset(2, paramsOffset, 0);
		}

		// Token: 0x06015950 RID: 88400 RVA: 0x0031C51A File Offset: 0x0031A71A
		public static Offset<IEnergyFishStateConfig> EndIEnergyFishStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnergyFishStateConfig>(builder.EndTable());
		}

		// Token: 0x06015951 RID: 88401 RVA: 0x0031C528 File Offset: 0x0031A728
		public IEnergyFishStateConfigT UnPack()
		{
			IEnergyFishStateConfigT energyFishStateConfigT = new IEnergyFishStateConfigT();
			this.UnPackTo(energyFishStateConfigT);
			return energyFishStateConfigT;
		}

		// Token: 0x06015952 RID: 88402 RVA: 0x0031C544 File Offset: 0x0031A744
		public void UnPackTo(IEnergyFishStateConfigT _o)
		{
			_o.State = this.State;
			_o.Params = new TEnergyFishStateUnion();
			_o.Params.Type = this.ParamsType;
			TEnergyFishState paramsType = this.ParamsType;
			if (paramsType == TEnergyFishState.IEnergyFishFollowState)
			{
				_o.Params.Value = ((this.Params<IEnergyFishFollowState>() != null) ? this.Params<IEnergyFishFollowState>().Value.UnPack() : null);
				return;
			}
			if (paramsType != TEnergyFishState.IEnergyFishSplineState)
			{
				return;
			}
			_o.Params.Value = ((this.Params<IEnergyFishSplineState>() != null) ? this.Params<IEnergyFishSplineState>().Value.UnPack() : null);
		}

		// Token: 0x06015953 RID: 88403 RVA: 0x0031C5F4 File Offset: 0x0031A7F4
		public static Offset<IEnergyFishStateConfig> Pack(FlatBufferBuilder builder, IEnergyFishStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnergyFishStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			TEnergyFishState params_type = (_o.Params == null) ? TEnergyFishState.NONE : _o.Params.Type;
			int paramsOffset = (_o.Params == null) ? 0 : TEnergyFishStateUnion.Pack(builder, _o.Params);
			return IEnergyFishStateConfig.CreateIEnergyFishStateConfig(builder, stateOffset, params_type, paramsOffset);
		}

		// Token: 0x0400B84D RID: 47181
		private Table __p;
	}
}

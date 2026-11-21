using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D25 RID: 32037
	public struct IVehicleSetSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700EFD4 RID: 61396
		// (get) Token: 0x06039D61 RID: 236897 RVA: 0x007CD969 File Offset: 0x007CBB69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D62 RID: 236898 RVA: 0x007CD976 File Offset: 0x007CBB76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D63 RID: 236899 RVA: 0x007CD980 File Offset: 0x007CBB80
		public static IVehicleSetSpeedImmediately GetRootAsIVehicleSetSpeedImmediately(ByteBuffer _bb)
		{
			return IVehicleSetSpeedImmediately.GetRootAsIVehicleSetSpeedImmediately(_bb, default(IVehicleSetSpeedImmediately));
		}

		// Token: 0x06039D64 RID: 236900 RVA: 0x007CD99C File Offset: 0x007CBB9C
		public static IVehicleSetSpeedImmediately GetRootAsIVehicleSetSpeedImmediately(ByteBuffer _bb, IVehicleSetSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D65 RID: 236901 RVA: 0x007CD9B9 File Offset: 0x007CBBB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D66 RID: 236902 RVA: 0x007CD9C8 File Offset: 0x007CBBC8
		public IVehicleSetSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFD5 RID: 61397
		// (get) Token: 0x06039D67 RID: 236903 RVA: 0x007CD9D8 File Offset: 0x007CBBD8
		public TVehicleSetSpeedImmediately SetSpeedConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVehicleSetSpeedImmediately.NONE;
				}
				return (TVehicleSetSpeedImmediately)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039D68 RID: 236904 RVA: 0x007CDA14 File Offset: 0x007CBC14
		public TTable? SetSpeedConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039D69 RID: 236905 RVA: 0x007CDA58 File Offset: 0x007CBC58
		public ISetHorizontalVerticalSpeedImmediately SetSpeedConfigAsISetHorizontalVerticalSpeedImmediately()
		{
			return this.SetSpeedConfig<ISetHorizontalVerticalSpeedImmediately>().Value;
		}

		// Token: 0x06039D6A RID: 236906 RVA: 0x007CDA74 File Offset: 0x007CBC74
		public ISetTotalVehicleSpeedImmediately SetSpeedConfigAsISetTotalVehicleSpeedImmediately()
		{
			return this.SetSpeedConfig<ISetTotalVehicleSpeedImmediately>().Value;
		}

		// Token: 0x06039D6B RID: 236907 RVA: 0x007CDA8F File Offset: 0x007CBC8F
		public static Offset<IVehicleSetSpeedImmediately> CreateIVehicleSetSpeedImmediately(FlatBufferBuilder builder, TVehicleSetSpeedImmediately SetSpeedConfig_type = TVehicleSetSpeedImmediately.NONE, int SetSpeedConfigOffset = 0)
		{
			builder.StartTable(2);
			IVehicleSetSpeedImmediately.AddSetSpeedConfig(builder, SetSpeedConfigOffset);
			IVehicleSetSpeedImmediately.AddSetSpeedConfigType(builder, SetSpeedConfig_type);
			return IVehicleSetSpeedImmediately.EndIVehicleSetSpeedImmediately(builder);
		}

		// Token: 0x06039D6C RID: 236908 RVA: 0x007CDAAC File Offset: 0x007CBCAC
		public static void StartIVehicleSetSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039D6D RID: 236909 RVA: 0x007CDAB5 File Offset: 0x007CBCB5
		public static void AddSetSpeedConfigType(FlatBufferBuilder builder, TVehicleSetSpeedImmediately setSpeedConfigType)
		{
			builder.AddByte(0, (byte)setSpeedConfigType, 0);
		}

		// Token: 0x06039D6E RID: 236910 RVA: 0x007CDAC0 File Offset: 0x007CBCC0
		public static void AddSetSpeedConfig(FlatBufferBuilder builder, int setSpeedConfigOffset)
		{
			builder.AddOffset(1, setSpeedConfigOffset, 0);
		}

		// Token: 0x06039D6F RID: 236911 RVA: 0x007CDACB File Offset: 0x007CBCCB
		public static Offset<IVehicleSetSpeedImmediately> EndIVehicleSetSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleSetSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x06039D70 RID: 236912 RVA: 0x007CDAD8 File Offset: 0x007CBCD8
		public IVehicleSetSpeedImmediatelyT UnPack()
		{
			IVehicleSetSpeedImmediatelyT vehicleSetSpeedImmediatelyT = new IVehicleSetSpeedImmediatelyT();
			this.UnPackTo(vehicleSetSpeedImmediatelyT);
			return vehicleSetSpeedImmediatelyT;
		}

		// Token: 0x06039D71 RID: 236913 RVA: 0x007CDAF4 File Offset: 0x007CBCF4
		public void UnPackTo(IVehicleSetSpeedImmediatelyT _o)
		{
			_o.SetSpeedConfig = new TVehicleSetSpeedImmediatelyUnion();
			_o.SetSpeedConfig.Type = this.SetSpeedConfigType;
			TVehicleSetSpeedImmediately setSpeedConfigType = this.SetSpeedConfigType;
			if (setSpeedConfigType == TVehicleSetSpeedImmediately.ISetHorizontalVerticalSpeedImmediately)
			{
				_o.SetSpeedConfig.Value = ((this.SetSpeedConfig<ISetHorizontalVerticalSpeedImmediately>() != null) ? this.SetSpeedConfig<ISetHorizontalVerticalSpeedImmediately>().Value.UnPack() : null);
				return;
			}
			if (setSpeedConfigType != TVehicleSetSpeedImmediately.ISetTotalVehicleSpeedImmediately)
			{
				return;
			}
			_o.SetSpeedConfig.Value = ((this.SetSpeedConfig<ISetTotalVehicleSpeedImmediately>() != null) ? this.SetSpeedConfig<ISetTotalVehicleSpeedImmediately>().Value.UnPack() : null);
		}

		// Token: 0x06039D72 RID: 236914 RVA: 0x007CDB98 File Offset: 0x007CBD98
		public static Offset<IVehicleSetSpeedImmediately> Pack(FlatBufferBuilder builder, IVehicleSetSpeedImmediatelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleSetSpeedImmediately>);
			}
			TVehicleSetSpeedImmediately setSpeedConfig_type = (_o.SetSpeedConfig == null) ? TVehicleSetSpeedImmediately.NONE : _o.SetSpeedConfig.Type;
			int setSpeedConfigOffset = (_o.SetSpeedConfig == null) ? 0 : TVehicleSetSpeedImmediatelyUnion.Pack(builder, _o.SetSpeedConfig);
			return IVehicleSetSpeedImmediately.CreateIVehicleSetSpeedImmediately(builder, setSpeedConfig_type, setSpeedConfigOffset);
		}

		// Token: 0x04013455 RID: 78933
		private Table __p;
	}
}

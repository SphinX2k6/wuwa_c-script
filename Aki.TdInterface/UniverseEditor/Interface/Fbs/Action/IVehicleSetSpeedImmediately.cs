using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752F RID: 29999
	public struct IVehicleSetSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700E3AA RID: 58282
		// (get) Token: 0x0603694B RID: 223563 RVA: 0x0076A6C1 File Offset: 0x007688C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603694C RID: 223564 RVA: 0x0076A6CE File Offset: 0x007688CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603694D RID: 223565 RVA: 0x0076A6D8 File Offset: 0x007688D8
		public static IVehicleSetSpeedImmediately GetRootAsIVehicleSetSpeedImmediately(ByteBuffer _bb)
		{
			return IVehicleSetSpeedImmediately.GetRootAsIVehicleSetSpeedImmediately(_bb, default(IVehicleSetSpeedImmediately));
		}

		// Token: 0x0603694E RID: 223566 RVA: 0x0076A6F4 File Offset: 0x007688F4
		public static IVehicleSetSpeedImmediately GetRootAsIVehicleSetSpeedImmediately(ByteBuffer _bb, IVehicleSetSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603694F RID: 223567 RVA: 0x0076A711 File Offset: 0x00768911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036950 RID: 223568 RVA: 0x0076A720 File Offset: 0x00768920
		public IVehicleSetSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3AB RID: 58283
		// (get) Token: 0x06036951 RID: 223569 RVA: 0x0076A730 File Offset: 0x00768930
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

		// Token: 0x06036952 RID: 223570 RVA: 0x0076A76C File Offset: 0x0076896C
		public TTable? SetSpeedConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036953 RID: 223571 RVA: 0x0076A7B0 File Offset: 0x007689B0
		public ISetHorizontalVerticalSpeedImmediately SetSpeedConfigAsISetHorizontalVerticalSpeedImmediately()
		{
			return this.SetSpeedConfig<ISetHorizontalVerticalSpeedImmediately>().Value;
		}

		// Token: 0x06036954 RID: 223572 RVA: 0x0076A7CC File Offset: 0x007689CC
		public ISetTotalVehicleSpeedImmediately SetSpeedConfigAsISetTotalVehicleSpeedImmediately()
		{
			return this.SetSpeedConfig<ISetTotalVehicleSpeedImmediately>().Value;
		}

		// Token: 0x06036955 RID: 223573 RVA: 0x0076A7E7 File Offset: 0x007689E7
		public static Offset<IVehicleSetSpeedImmediately> CreateIVehicleSetSpeedImmediately(FlatBufferBuilder builder, TVehicleSetSpeedImmediately SetSpeedConfig_type = TVehicleSetSpeedImmediately.NONE, int SetSpeedConfigOffset = 0)
		{
			builder.StartTable(2);
			IVehicleSetSpeedImmediately.AddSetSpeedConfig(builder, SetSpeedConfigOffset);
			IVehicleSetSpeedImmediately.AddSetSpeedConfigType(builder, SetSpeedConfig_type);
			return IVehicleSetSpeedImmediately.EndIVehicleSetSpeedImmediately(builder);
		}

		// Token: 0x06036956 RID: 223574 RVA: 0x0076A804 File Offset: 0x00768A04
		public static void StartIVehicleSetSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036957 RID: 223575 RVA: 0x0076A80D File Offset: 0x00768A0D
		public static void AddSetSpeedConfigType(FlatBufferBuilder builder, TVehicleSetSpeedImmediately setSpeedConfigType)
		{
			builder.AddByte(0, (byte)setSpeedConfigType, 0);
		}

		// Token: 0x06036958 RID: 223576 RVA: 0x0076A818 File Offset: 0x00768A18
		public static void AddSetSpeedConfig(FlatBufferBuilder builder, int setSpeedConfigOffset)
		{
			builder.AddOffset(1, setSpeedConfigOffset, 0);
		}

		// Token: 0x06036959 RID: 223577 RVA: 0x0076A823 File Offset: 0x00768A23
		public static Offset<IVehicleSetSpeedImmediately> EndIVehicleSetSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleSetSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x0603695A RID: 223578 RVA: 0x0076A830 File Offset: 0x00768A30
		public IVehicleSetSpeedImmediatelyT UnPack()
		{
			IVehicleSetSpeedImmediatelyT vehicleSetSpeedImmediatelyT = new IVehicleSetSpeedImmediatelyT();
			this.UnPackTo(vehicleSetSpeedImmediatelyT);
			return vehicleSetSpeedImmediatelyT;
		}

		// Token: 0x0603695B RID: 223579 RVA: 0x0076A84C File Offset: 0x00768A4C
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

		// Token: 0x0603695C RID: 223580 RVA: 0x0076A8F0 File Offset: 0x00768AF0
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

		// Token: 0x04012424 RID: 74788
		private Table __p;
	}
}

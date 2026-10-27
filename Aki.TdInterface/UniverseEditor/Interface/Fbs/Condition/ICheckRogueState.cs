using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B14 RID: 19220
	public struct ICheckRogueState : IFlatbufferObject
	{
		// Token: 0x17008B6E RID: 35694
		// (get) Token: 0x0601E3AC RID: 123820 RVA: 0x0043CF26 File Offset: 0x0043B126
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3AD RID: 123821 RVA: 0x0043CF33 File Offset: 0x0043B133
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3AE RID: 123822 RVA: 0x0043CF3C File Offset: 0x0043B13C
		public static ICheckRogueState GetRootAsICheckRogueState(ByteBuffer _bb)
		{
			return ICheckRogueState.GetRootAsICheckRogueState(_bb, default(ICheckRogueState));
		}

		// Token: 0x0601E3AF RID: 123823 RVA: 0x0043CF58 File Offset: 0x0043B158
		public static ICheckRogueState GetRootAsICheckRogueState(ByteBuffer _bb, ICheckRogueState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E3B0 RID: 123824 RVA: 0x0043CF75 File Offset: 0x0043B175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E3B1 RID: 123825 RVA: 0x0043CF84 File Offset: 0x0043B184
		public ICheckRogueState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B6F RID: 35695
		// (get) Token: 0x0601E3B2 RID: 123826 RVA: 0x0043CF94 File Offset: 0x0043B194
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B70 RID: 35696
		// (get) Token: 0x0601E3B3 RID: 123827 RVA: 0x0043CFD0 File Offset: 0x0043B1D0
		public TRogueStateType ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRogueStateType.NONE;
				}
				return (TRogueStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E3B4 RID: 123828 RVA: 0x0043D00C File Offset: 0x0043B20C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E3B5 RID: 123829 RVA: 0x0043D050 File Offset: 0x0043B250
		public ICheckRogueMiracleCreation ConfigAsICheckRogueMiracleCreation()
		{
			return this.Config<ICheckRogueMiracleCreation>().Value;
		}

		// Token: 0x0601E3B6 RID: 123830 RVA: 0x0043D06C File Offset: 0x0043B26C
		public ICheckRogueTalent ConfigAsICheckRogueTalent()
		{
			return this.Config<ICheckRogueTalent>().Value;
		}

		// Token: 0x0601E3B7 RID: 123831 RVA: 0x0043D087 File Offset: 0x0043B287
		public static Offset<ICheckRogueState> CreateICheckRogueState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, TRogueStateType Config_type = TRogueStateType.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ICheckRogueState.AddConfig(builder, ConfigOffset);
			ICheckRogueState.AddConfigType(builder, Config_type);
			ICheckRogueState.AddType(builder, Type);
			return ICheckRogueState.EndICheckRogueState(builder);
		}

		// Token: 0x0601E3B8 RID: 123832 RVA: 0x0043D0AB File Offset: 0x0043B2AB
		public static void StartICheckRogueState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E3B9 RID: 123833 RVA: 0x0043D0B4 File Offset: 0x0043B2B4
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E3BA RID: 123834 RVA: 0x0043D0BF File Offset: 0x0043B2BF
		public static void AddConfigType(FlatBufferBuilder builder, TRogueStateType configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0601E3BB RID: 123835 RVA: 0x0043D0CA File Offset: 0x0043B2CA
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0601E3BC RID: 123836 RVA: 0x0043D0D5 File Offset: 0x0043B2D5
		public static Offset<ICheckRogueState> EndICheckRogueState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueState>(builder.EndTable());
		}

		// Token: 0x0601E3BD RID: 123837 RVA: 0x0043D0E4 File Offset: 0x0043B2E4
		public ICheckRogueStateT UnPack()
		{
			ICheckRogueStateT checkRogueStateT = new ICheckRogueStateT();
			this.UnPackTo(checkRogueStateT);
			return checkRogueStateT;
		}

		// Token: 0x0601E3BE RID: 123838 RVA: 0x0043D100 File Offset: 0x0043B300
		public void UnPackTo(ICheckRogueStateT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TRogueStateTypeUnion();
			_o.Config.Type = this.ConfigType;
			TRogueStateType configType = this.ConfigType;
			if (configType == TRogueStateType.ICheckRogueMiracleCreation)
			{
				_o.Config.Value = ((this.Config<ICheckRogueMiracleCreation>() != null) ? this.Config<ICheckRogueMiracleCreation>().Value.UnPack() : null);
				return;
			}
			if (configType != TRogueStateType.ICheckRogueTalent)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ICheckRogueTalent>() != null) ? this.Config<ICheckRogueTalent>().Value.UnPack() : null);
		}

		// Token: 0x0601E3BF RID: 123839 RVA: 0x0043D1B0 File Offset: 0x0043B3B0
		public static Offset<ICheckRogueState> Pack(FlatBufferBuilder builder, ICheckRogueStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueState>);
			}
			TRogueStateType config_type = (_o.Config == null) ? TRogueStateType.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TRogueStateTypeUnion.Pack(builder, _o.Config);
			return ICheckRogueState.CreateICheckRogueState(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x0400D3B1 RID: 54193
		private Table __p;
	}
}

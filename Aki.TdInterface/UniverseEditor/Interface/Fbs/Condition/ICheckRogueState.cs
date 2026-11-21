using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FFB RID: 20475
	public struct ICheckRogueState : IFlatbufferObject
	{
		// Token: 0x1700927E RID: 37502
		// (get) Token: 0x0601FF37 RID: 130871 RVA: 0x0046F6D2 File Offset: 0x0046D8D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF38 RID: 130872 RVA: 0x0046F6DF File Offset: 0x0046D8DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF39 RID: 130873 RVA: 0x0046F6E8 File Offset: 0x0046D8E8
		public static ICheckRogueState GetRootAsICheckRogueState(ByteBuffer _bb)
		{
			return ICheckRogueState.GetRootAsICheckRogueState(_bb, default(ICheckRogueState));
		}

		// Token: 0x0601FF3A RID: 130874 RVA: 0x0046F704 File Offset: 0x0046D904
		public static ICheckRogueState GetRootAsICheckRogueState(ByteBuffer _bb, ICheckRogueState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF3B RID: 130875 RVA: 0x0046F721 File Offset: 0x0046D921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF3C RID: 130876 RVA: 0x0046F730 File Offset: 0x0046D930
		public ICheckRogueState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700927F RID: 37503
		// (get) Token: 0x0601FF3D RID: 130877 RVA: 0x0046F740 File Offset: 0x0046D940
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

		// Token: 0x17009280 RID: 37504
		// (get) Token: 0x0601FF3E RID: 130878 RVA: 0x0046F77C File Offset: 0x0046D97C
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

		// Token: 0x0601FF3F RID: 130879 RVA: 0x0046F7B8 File Offset: 0x0046D9B8
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FF40 RID: 130880 RVA: 0x0046F7FC File Offset: 0x0046D9FC
		public ICheckRogueMiracleCreation ConfigAsICheckRogueMiracleCreation()
		{
			return this.Config<ICheckRogueMiracleCreation>().Value;
		}

		// Token: 0x0601FF41 RID: 130881 RVA: 0x0046F818 File Offset: 0x0046DA18
		public ICheckRogueTalent ConfigAsICheckRogueTalent()
		{
			return this.Config<ICheckRogueTalent>().Value;
		}

		// Token: 0x0601FF42 RID: 130882 RVA: 0x0046F833 File Offset: 0x0046DA33
		public static Offset<ICheckRogueState> CreateICheckRogueState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, TRogueStateType Config_type = TRogueStateType.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ICheckRogueState.AddConfig(builder, ConfigOffset);
			ICheckRogueState.AddConfigType(builder, Config_type);
			ICheckRogueState.AddType(builder, Type);
			return ICheckRogueState.EndICheckRogueState(builder);
		}

		// Token: 0x0601FF43 RID: 130883 RVA: 0x0046F857 File Offset: 0x0046DA57
		public static void StartICheckRogueState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FF44 RID: 130884 RVA: 0x0046F860 File Offset: 0x0046DA60
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF45 RID: 130885 RVA: 0x0046F86B File Offset: 0x0046DA6B
		public static void AddConfigType(FlatBufferBuilder builder, TRogueStateType configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0601FF46 RID: 130886 RVA: 0x0046F876 File Offset: 0x0046DA76
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0601FF47 RID: 130887 RVA: 0x0046F881 File Offset: 0x0046DA81
		public static Offset<ICheckRogueState> EndICheckRogueState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueState>(builder.EndTable());
		}

		// Token: 0x0601FF48 RID: 130888 RVA: 0x0046F890 File Offset: 0x0046DA90
		public ICheckRogueStateT UnPack()
		{
			ICheckRogueStateT checkRogueStateT = new ICheckRogueStateT();
			this.UnPackTo(checkRogueStateT);
			return checkRogueStateT;
		}

		// Token: 0x0601FF49 RID: 130889 RVA: 0x0046F8AC File Offset: 0x0046DAAC
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

		// Token: 0x0601FF4A RID: 130890 RVA: 0x0046F95C File Offset: 0x0046DB5C
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

		// Token: 0x0400DEB0 RID: 57008
		private Table __p;
	}
}

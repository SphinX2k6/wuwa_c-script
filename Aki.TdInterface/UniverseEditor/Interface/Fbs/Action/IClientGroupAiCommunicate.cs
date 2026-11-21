using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4A RID: 27210
	public struct IClientGroupAiCommunicate : IFlatbufferObject
	{
		// Token: 0x1700C7E9 RID: 51177
		// (get) Token: 0x0602EABE RID: 191166 RVA: 0x0065C9F5 File Offset: 0x0065ABF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EABF RID: 191167 RVA: 0x0065CA02 File Offset: 0x0065AC02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EAC0 RID: 191168 RVA: 0x0065CA0C File Offset: 0x0065AC0C
		public static IClientGroupAiCommunicate GetRootAsIClientGroupAiCommunicate(ByteBuffer _bb)
		{
			return IClientGroupAiCommunicate.GetRootAsIClientGroupAiCommunicate(_bb, default(IClientGroupAiCommunicate));
		}

		// Token: 0x0602EAC1 RID: 191169 RVA: 0x0065CA28 File Offset: 0x0065AC28
		public static IClientGroupAiCommunicate GetRootAsIClientGroupAiCommunicate(ByteBuffer _bb, IClientGroupAiCommunicate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EAC2 RID: 191170 RVA: 0x0065CA45 File Offset: 0x0065AC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EAC3 RID: 191171 RVA: 0x0065CA54 File Offset: 0x0065AC54
		public IClientGroupAiCommunicate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7EA RID: 51178
		// (get) Token: 0x0602EAC4 RID: 191172 RVA: 0x0065CA64 File Offset: 0x0065AC64
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7EB RID: 51179
		// (get) Token: 0x0602EAC5 RID: 191173 RVA: 0x0065CAA0 File Offset: 0x0065ACA0
		public int GroupEntityId
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

		// Token: 0x1700C7EC RID: 51180
		// (get) Token: 0x0602EAC6 RID: 191174 RVA: 0x0065CADC File Offset: 0x0065ACDC
		public TGroupAiCommunicateOption OptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TGroupAiCommunicateOption.NONE;
				}
				return (TGroupAiCommunicateOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EAC7 RID: 191175 RVA: 0x0065CB18 File Offset: 0x0065AD18
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EAC8 RID: 191176 RVA: 0x0065CB60 File Offset: 0x0065AD60
		public IGroupAiCommunicateAddTag OptionAsIGroupAiCommunicateAddTag()
		{
			return this.Option<IGroupAiCommunicateAddTag>().Value;
		}

		// Token: 0x0602EAC9 RID: 191177 RVA: 0x0065CB7C File Offset: 0x0065AD7C
		public IGroupAiCommunicateRemoveTag OptionAsIGroupAiCommunicateRemoveTag()
		{
			return this.Option<IGroupAiCommunicateRemoveTag>().Value;
		}

		// Token: 0x0602EACA RID: 191178 RVA: 0x0065CB97 File Offset: 0x0065AD97
		public static Offset<IClientGroupAiCommunicate> CreateIClientGroupAiCommunicate(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int GroupEntityId = 0, TGroupAiCommunicateOption Option_type = TGroupAiCommunicateOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(4);
			IClientGroupAiCommunicate.AddOption(builder, OptionOffset);
			IClientGroupAiCommunicate.AddGroupEntityId(builder, GroupEntityId);
			IClientGroupAiCommunicate.AddOptionType(builder, Option_type);
			IClientGroupAiCommunicate.AddType(builder, Type);
			return IClientGroupAiCommunicate.EndIClientGroupAiCommunicate(builder);
		}

		// Token: 0x0602EACB RID: 191179 RVA: 0x0065CBC3 File Offset: 0x0065ADC3
		public static void StartIClientGroupAiCommunicate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EACC RID: 191180 RVA: 0x0065CBCC File Offset: 0x0065ADCC
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EACD RID: 191181 RVA: 0x0065CBD7 File Offset: 0x0065ADD7
		public static void AddGroupEntityId(FlatBufferBuilder builder, int groupEntityId)
		{
			builder.AddInt(1, groupEntityId, 0);
		}

		// Token: 0x0602EACE RID: 191182 RVA: 0x0065CBE2 File Offset: 0x0065ADE2
		public static void AddOptionType(FlatBufferBuilder builder, TGroupAiCommunicateOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x0602EACF RID: 191183 RVA: 0x0065CBED File Offset: 0x0065ADED
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x0602EAD0 RID: 191184 RVA: 0x0065CBF8 File Offset: 0x0065ADF8
		public static Offset<IClientGroupAiCommunicate> EndIClientGroupAiCommunicate(FlatBufferBuilder builder)
		{
			return new Offset<IClientGroupAiCommunicate>(builder.EndTable());
		}

		// Token: 0x0602EAD1 RID: 191185 RVA: 0x0065CC08 File Offset: 0x0065AE08
		public IClientGroupAiCommunicateT UnPack()
		{
			IClientGroupAiCommunicateT clientGroupAiCommunicateT = new IClientGroupAiCommunicateT();
			this.UnPackTo(clientGroupAiCommunicateT);
			return clientGroupAiCommunicateT;
		}

		// Token: 0x0602EAD2 RID: 191186 RVA: 0x0065CC24 File Offset: 0x0065AE24
		public void UnPackTo(IClientGroupAiCommunicateT _o)
		{
			_o.Type = this.Type;
			_o.GroupEntityId = this.GroupEntityId;
			_o.Option = new TGroupAiCommunicateOptionUnion();
			_o.Option.Type = this.OptionType;
			TGroupAiCommunicateOption optionType = this.OptionType;
			if (optionType == TGroupAiCommunicateOption.IGroupAiCommunicateAddTag)
			{
				_o.Option.Value = ((this.Option<IGroupAiCommunicateAddTag>() != null) ? this.Option<IGroupAiCommunicateAddTag>().Value.UnPack() : null);
				return;
			}
			if (optionType != TGroupAiCommunicateOption.IGroupAiCommunicateRemoveTag)
			{
				return;
			}
			_o.Option.Value = ((this.Option<IGroupAiCommunicateRemoveTag>() != null) ? this.Option<IGroupAiCommunicateRemoveTag>().Value.UnPack() : null);
		}

		// Token: 0x0602EAD3 RID: 191187 RVA: 0x0065CCE0 File Offset: 0x0065AEE0
		public static Offset<IClientGroupAiCommunicate> Pack(FlatBufferBuilder builder, IClientGroupAiCommunicateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientGroupAiCommunicate>);
			}
			TGroupAiCommunicateOption option_type = (_o.Option == null) ? TGroupAiCommunicateOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TGroupAiCommunicateOptionUnion.Pack(builder, _o.Option);
			return IClientGroupAiCommunicate.CreateIClientGroupAiCommunicate(builder, _o.Type, _o.GroupEntityId, option_type, optionOffset);
		}

		// Token: 0x040117CA RID: 71626
		private Table __p;
	}
}

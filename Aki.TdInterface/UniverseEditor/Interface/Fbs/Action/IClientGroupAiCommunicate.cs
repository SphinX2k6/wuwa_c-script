using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CD RID: 25549
	public struct IClientGroupAiCommunicate : IFlatbufferObject
	{
		// Token: 0x1700BE58 RID: 48728
		// (get) Token: 0x0602C313 RID: 181011 RVA: 0x006112A9 File Offset: 0x0060F4A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C314 RID: 181012 RVA: 0x006112B6 File Offset: 0x0060F4B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C315 RID: 181013 RVA: 0x006112C0 File Offset: 0x0060F4C0
		public static IClientGroupAiCommunicate GetRootAsIClientGroupAiCommunicate(ByteBuffer _bb)
		{
			return IClientGroupAiCommunicate.GetRootAsIClientGroupAiCommunicate(_bb, default(IClientGroupAiCommunicate));
		}

		// Token: 0x0602C316 RID: 181014 RVA: 0x006112DC File Offset: 0x0060F4DC
		public static IClientGroupAiCommunicate GetRootAsIClientGroupAiCommunicate(ByteBuffer _bb, IClientGroupAiCommunicate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C317 RID: 181015 RVA: 0x006112F9 File Offset: 0x0060F4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C318 RID: 181016 RVA: 0x00611308 File Offset: 0x0060F508
		public IClientGroupAiCommunicate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE59 RID: 48729
		// (get) Token: 0x0602C319 RID: 181017 RVA: 0x00611318 File Offset: 0x0060F518
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

		// Token: 0x1700BE5A RID: 48730
		// (get) Token: 0x0602C31A RID: 181018 RVA: 0x00611354 File Offset: 0x0060F554
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

		// Token: 0x1700BE5B RID: 48731
		// (get) Token: 0x0602C31B RID: 181019 RVA: 0x00611390 File Offset: 0x0060F590
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

		// Token: 0x0602C31C RID: 181020 RVA: 0x006113CC File Offset: 0x0060F5CC
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C31D RID: 181021 RVA: 0x00611414 File Offset: 0x0060F614
		public IGroupAiCommunicateAddTag OptionAsIGroupAiCommunicateAddTag()
		{
			return this.Option<IGroupAiCommunicateAddTag>().Value;
		}

		// Token: 0x0602C31E RID: 181022 RVA: 0x00611430 File Offset: 0x0060F630
		public IGroupAiCommunicateRemoveTag OptionAsIGroupAiCommunicateRemoveTag()
		{
			return this.Option<IGroupAiCommunicateRemoveTag>().Value;
		}

		// Token: 0x0602C31F RID: 181023 RVA: 0x0061144B File Offset: 0x0060F64B
		public static Offset<IClientGroupAiCommunicate> CreateIClientGroupAiCommunicate(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int GroupEntityId = 0, TGroupAiCommunicateOption Option_type = TGroupAiCommunicateOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(4);
			IClientGroupAiCommunicate.AddOption(builder, OptionOffset);
			IClientGroupAiCommunicate.AddGroupEntityId(builder, GroupEntityId);
			IClientGroupAiCommunicate.AddOptionType(builder, Option_type);
			IClientGroupAiCommunicate.AddType(builder, Type);
			return IClientGroupAiCommunicate.EndIClientGroupAiCommunicate(builder);
		}

		// Token: 0x0602C320 RID: 181024 RVA: 0x00611477 File Offset: 0x0060F677
		public static void StartIClientGroupAiCommunicate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C321 RID: 181025 RVA: 0x00611480 File Offset: 0x0060F680
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C322 RID: 181026 RVA: 0x0061148B File Offset: 0x0060F68B
		public static void AddGroupEntityId(FlatBufferBuilder builder, int groupEntityId)
		{
			builder.AddInt(1, groupEntityId, 0);
		}

		// Token: 0x0602C323 RID: 181027 RVA: 0x00611496 File Offset: 0x0060F696
		public static void AddOptionType(FlatBufferBuilder builder, TGroupAiCommunicateOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x0602C324 RID: 181028 RVA: 0x006114A1 File Offset: 0x0060F6A1
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x0602C325 RID: 181029 RVA: 0x006114AC File Offset: 0x0060F6AC
		public static Offset<IClientGroupAiCommunicate> EndIClientGroupAiCommunicate(FlatBufferBuilder builder)
		{
			return new Offset<IClientGroupAiCommunicate>(builder.EndTable());
		}

		// Token: 0x0602C326 RID: 181030 RVA: 0x006114BC File Offset: 0x0060F6BC
		public IClientGroupAiCommunicateT UnPack()
		{
			IClientGroupAiCommunicateT clientGroupAiCommunicateT = new IClientGroupAiCommunicateT();
			this.UnPackTo(clientGroupAiCommunicateT);
			return clientGroupAiCommunicateT;
		}

		// Token: 0x0602C327 RID: 181031 RVA: 0x006114D8 File Offset: 0x0060F6D8
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

		// Token: 0x0602C328 RID: 181032 RVA: 0x00611594 File Offset: 0x0060F794
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

		// Token: 0x040109A9 RID: 68009
		private Table __p;
	}
}

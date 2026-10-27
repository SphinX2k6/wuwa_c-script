using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4A RID: 19274
	public struct ICheckTargetAttributeCondition : IFlatbufferObject
	{
		// Token: 0x17008BD0 RID: 35792
		// (get) Token: 0x0601E589 RID: 124297 RVA: 0x004406A4 File Offset: 0x0043E8A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E58A RID: 124298 RVA: 0x004406B1 File Offset: 0x0043E8B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E58B RID: 124299 RVA: 0x004406B8 File Offset: 0x0043E8B8
		public static ICheckTargetAttributeCondition GetRootAsICheckTargetAttributeCondition(ByteBuffer _bb)
		{
			return ICheckTargetAttributeCondition.GetRootAsICheckTargetAttributeCondition(_bb, default(ICheckTargetAttributeCondition));
		}

		// Token: 0x0601E58C RID: 124300 RVA: 0x004406D4 File Offset: 0x0043E8D4
		public static ICheckTargetAttributeCondition GetRootAsICheckTargetAttributeCondition(ByteBuffer _bb, ICheckTargetAttributeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E58D RID: 124301 RVA: 0x004406F1 File Offset: 0x0043E8F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E58E RID: 124302 RVA: 0x00440700 File Offset: 0x0043E900
		public ICheckTargetAttributeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BD1 RID: 35793
		// (get) Token: 0x0601E58F RID: 124303 RVA: 0x00440710 File Offset: 0x0043E910
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BD2 RID: 35794
		// (get) Token: 0x0601E590 RID: 124304 RVA: 0x0044074C File Offset: 0x0043E94C
		public IPlayerAttribute? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerAttribute?(default(IPlayerAttribute).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008BD3 RID: 35795
		// (get) Token: 0x0601E591 RID: 124305 RVA: 0x004407AC File Offset: 0x0043E9AC
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E592 RID: 124306 RVA: 0x004407E8 File Offset: 0x0043E9E8
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E593 RID: 124307 RVA: 0x00440830 File Offset: 0x0043EA30
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E594 RID: 124308 RVA: 0x0044084C File Offset: 0x0043EA4C
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E595 RID: 124309 RVA: 0x00440867 File Offset: 0x0043EA67
		public static Offset<ICheckTargetAttributeCondition> CreateICheckTargetAttributeCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IPlayerAttribute> OptionOffset = default(Offset<IPlayerAttribute>), TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckTargetAttributeCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckTargetAttributeCondition.AddOption(builder, OptionOffset);
			ICheckTargetAttributeCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckTargetAttributeCondition.AddType(builder, Type);
			return ICheckTargetAttributeCondition.EndICheckTargetAttributeCondition(builder);
		}

		// Token: 0x0601E596 RID: 124310 RVA: 0x00440893 File Offset: 0x0043EA93
		public static void StartICheckTargetAttributeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E597 RID: 124311 RVA: 0x0044089C File Offset: 0x0043EA9C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E598 RID: 124312 RVA: 0x004408A7 File Offset: 0x0043EAA7
		public static void AddOption(FlatBufferBuilder builder, Offset<IPlayerAttribute> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x0601E599 RID: 124313 RVA: 0x004408B7 File Offset: 0x0043EAB7
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E59A RID: 124314 RVA: 0x004408C2 File Offset: 0x0043EAC2
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E59B RID: 124315 RVA: 0x004408CD File Offset: 0x0043EACD
		public static Offset<ICheckTargetAttributeCondition> EndICheckTargetAttributeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetAttributeCondition>(builder.EndTable());
		}

		// Token: 0x0601E59C RID: 124316 RVA: 0x004408DC File Offset: 0x0043EADC
		public ICheckTargetAttributeConditionT UnPack()
		{
			ICheckTargetAttributeConditionT checkTargetAttributeConditionT = new ICheckTargetAttributeConditionT();
			this.UnPackTo(checkTargetAttributeConditionT);
			return checkTargetAttributeConditionT;
		}

		// Token: 0x0601E59D RID: 124317 RVA: 0x004408F8 File Offset: 0x0043EAF8
		public void UnPackTo(ICheckTargetAttributeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601E59E RID: 124318 RVA: 0x004409DC File Offset: 0x0043EBDC
		public static Offset<ICheckTargetAttributeCondition> Pack(FlatBufferBuilder builder, ICheckTargetAttributeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetAttributeCondition>);
			}
			Offset<IPlayerAttribute> optionOffset = (_o.Option == null) ? default(Offset<IPlayerAttribute>) : IPlayerAttribute.Pack(builder, _o.Option);
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckTargetAttributeCondition.CreateICheckTargetAttributeCondition(builder, _o.Type, optionOffset, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D405 RID: 54277
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005031 RID: 20529
	public struct ICheckTargetAttributeCondition : IFlatbufferObject
	{
		// Token: 0x170092E0 RID: 37600
		// (get) Token: 0x06020117 RID: 131351 RVA: 0x00472EED File Offset: 0x004710ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020118 RID: 131352 RVA: 0x00472EFA File Offset: 0x004710FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020119 RID: 131353 RVA: 0x00472F04 File Offset: 0x00471104
		public static ICheckTargetAttributeCondition GetRootAsICheckTargetAttributeCondition(ByteBuffer _bb)
		{
			return ICheckTargetAttributeCondition.GetRootAsICheckTargetAttributeCondition(_bb, default(ICheckTargetAttributeCondition));
		}

		// Token: 0x0602011A RID: 131354 RVA: 0x00472F20 File Offset: 0x00471120
		public static ICheckTargetAttributeCondition GetRootAsICheckTargetAttributeCondition(ByteBuffer _bb, ICheckTargetAttributeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602011B RID: 131355 RVA: 0x00472F3D File Offset: 0x0047113D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602011C RID: 131356 RVA: 0x00472F4C File Offset: 0x0047114C
		public ICheckTargetAttributeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092E1 RID: 37601
		// (get) Token: 0x0602011D RID: 131357 RVA: 0x00472F5C File Offset: 0x0047115C
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

		// Token: 0x170092E2 RID: 37602
		// (get) Token: 0x0602011E RID: 131358 RVA: 0x00472F98 File Offset: 0x00471198
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

		// Token: 0x170092E3 RID: 37603
		// (get) Token: 0x0602011F RID: 131359 RVA: 0x00472FF8 File Offset: 0x004711F8
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

		// Token: 0x06020120 RID: 131360 RVA: 0x00473034 File Offset: 0x00471234
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020121 RID: 131361 RVA: 0x0047307C File Offset: 0x0047127C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020122 RID: 131362 RVA: 0x00473098 File Offset: 0x00471298
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020123 RID: 131363 RVA: 0x004730B3 File Offset: 0x004712B3
		public static Offset<ICheckTargetAttributeCondition> CreateICheckTargetAttributeCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IPlayerAttribute> OptionOffset = default(Offset<IPlayerAttribute>), TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckTargetAttributeCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckTargetAttributeCondition.AddOption(builder, OptionOffset);
			ICheckTargetAttributeCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckTargetAttributeCondition.AddType(builder, Type);
			return ICheckTargetAttributeCondition.EndICheckTargetAttributeCondition(builder);
		}

		// Token: 0x06020124 RID: 131364 RVA: 0x004730DF File Offset: 0x004712DF
		public static void StartICheckTargetAttributeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020125 RID: 131365 RVA: 0x004730E8 File Offset: 0x004712E8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020126 RID: 131366 RVA: 0x004730F3 File Offset: 0x004712F3
		public static void AddOption(FlatBufferBuilder builder, Offset<IPlayerAttribute> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06020127 RID: 131367 RVA: 0x00473103 File Offset: 0x00471303
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020128 RID: 131368 RVA: 0x0047310E File Offset: 0x0047130E
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020129 RID: 131369 RVA: 0x00473119 File Offset: 0x00471319
		public static Offset<ICheckTargetAttributeCondition> EndICheckTargetAttributeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetAttributeCondition>(builder.EndTable());
		}

		// Token: 0x0602012A RID: 131370 RVA: 0x00473128 File Offset: 0x00471328
		public ICheckTargetAttributeConditionT UnPack()
		{
			ICheckTargetAttributeConditionT checkTargetAttributeConditionT = new ICheckTargetAttributeConditionT();
			this.UnPackTo(checkTargetAttributeConditionT);
			return checkTargetAttributeConditionT;
		}

		// Token: 0x0602012B RID: 131371 RVA: 0x00473144 File Offset: 0x00471344
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

		// Token: 0x0602012C RID: 131372 RVA: 0x00473228 File Offset: 0x00471428
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

		// Token: 0x0400DF05 RID: 57093
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005124 RID: 20772
	public struct IHasBuff : IFlatbufferObject
	{
		// Token: 0x170094D8 RID: 38104
		// (get) Token: 0x06020A89 RID: 133769 RVA: 0x00486B87 File Offset: 0x00484D87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020A8A RID: 133770 RVA: 0x00486B94 File Offset: 0x00484D94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020A8B RID: 133771 RVA: 0x00486B9C File Offset: 0x00484D9C
		public static IHasBuff GetRootAsIHasBuff(ByteBuffer _bb)
		{
			return IHasBuff.GetRootAsIHasBuff(_bb, default(IHasBuff));
		}

		// Token: 0x06020A8C RID: 133772 RVA: 0x00486BB8 File Offset: 0x00484DB8
		public static IHasBuff GetRootAsIHasBuff(ByteBuffer _bb, IHasBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020A8D RID: 133773 RVA: 0x00486BD5 File Offset: 0x00484DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020A8E RID: 133774 RVA: 0x00486BE4 File Offset: 0x00484DE4
		public IHasBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094D9 RID: 38105
		// (get) Token: 0x06020A8F RID: 133775 RVA: 0x00486BF4 File Offset: 0x00484DF4
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

		// Token: 0x170094DA RID: 38106
		// (get) Token: 0x06020A90 RID: 133776 RVA: 0x00486C30 File Offset: 0x00484E30
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094DB RID: 38107
		// (get) Token: 0x06020A91 RID: 133777 RVA: 0x00486C70 File Offset: 0x00484E70
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094DC RID: 38108
		// (get) Token: 0x06020A92 RID: 133778 RVA: 0x00486CAC File Offset: 0x00484EAC
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020A93 RID: 133779 RVA: 0x00486CEC File Offset: 0x00484EEC
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020A94 RID: 133780 RVA: 0x00486D34 File Offset: 0x00484F34
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020A95 RID: 133781 RVA: 0x00486D50 File Offset: 0x00484F50
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020A96 RID: 133782 RVA: 0x00486D6B File Offset: 0x00484F6B
		public static Offset<IHasBuff> CreateIHasBuff(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, long BuffId = 0L, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			IHasBuff.AddBuffId(builder, BuffId);
			IHasBuff.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IHasBuff.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IHasBuff.AddCompare(builder, Compare);
			IHasBuff.AddType(builder, Type);
			return IHasBuff.EndIHasBuff(builder);
		}

		// Token: 0x06020A97 RID: 133783 RVA: 0x00486D9F File Offset: 0x00484F9F
		public static void StartIHasBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020A98 RID: 133784 RVA: 0x00486DA8 File Offset: 0x00484FA8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020A99 RID: 133785 RVA: 0x00486DB3 File Offset: 0x00484FB3
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(1, buffId, 0L);
		}

		// Token: 0x06020A9A RID: 133786 RVA: 0x00486DBF File Offset: 0x00484FBF
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020A9B RID: 133787 RVA: 0x00486DCA File Offset: 0x00484FCA
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020A9C RID: 133788 RVA: 0x00486DD5 File Offset: 0x00484FD5
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020A9D RID: 133789 RVA: 0x00486DE0 File Offset: 0x00484FE0
		public static Offset<IHasBuff> EndIHasBuff(FlatBufferBuilder builder)
		{
			return new Offset<IHasBuff>(builder.EndTable());
		}

		// Token: 0x06020A9E RID: 133790 RVA: 0x00486DF0 File Offset: 0x00484FF0
		public IHasBuffT UnPack()
		{
			IHasBuffT hasBuffT = new IHasBuffT();
			this.UnPackTo(hasBuffT);
			return hasBuffT;
		}

		// Token: 0x06020A9F RID: 133791 RVA: 0x00486E0C File Offset: 0x0048500C
		public void UnPackTo(IHasBuffT _o)
		{
			_o.Type = this.Type;
			_o.BuffId = this.BuffId;
			_o.Compare = this.Compare;
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

		// Token: 0x06020AA0 RID: 133792 RVA: 0x00486ED4 File Offset: 0x004850D4
		public static Offset<IHasBuff> Pack(FlatBufferBuilder builder, IHasBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasBuff>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IHasBuff.CreateIHasBuff(builder, _o.Type, _o.BuffId, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400E0F2 RID: 57586
		private Table __p;
	}
}

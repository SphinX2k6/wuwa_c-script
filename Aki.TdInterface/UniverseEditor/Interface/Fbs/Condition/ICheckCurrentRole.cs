using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E6C RID: 20076
	public struct ICheckCurrentRole : IFlatbufferObject
	{
		// Token: 0x17008F2C RID: 36652
		// (get) Token: 0x0601F16F RID: 127343 RVA: 0x00456A08 File Offset: 0x00454C08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F170 RID: 127344 RVA: 0x00456A15 File Offset: 0x00454C15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F171 RID: 127345 RVA: 0x00456A1C File Offset: 0x00454C1C
		public static ICheckCurrentRole GetRootAsICheckCurrentRole(ByteBuffer _bb)
		{
			return ICheckCurrentRole.GetRootAsICheckCurrentRole(_bb, default(ICheckCurrentRole));
		}

		// Token: 0x0601F172 RID: 127346 RVA: 0x00456A38 File Offset: 0x00454C38
		public static ICheckCurrentRole GetRootAsICheckCurrentRole(ByteBuffer _bb, ICheckCurrentRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F173 RID: 127347 RVA: 0x00456A55 File Offset: 0x00454C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F174 RID: 127348 RVA: 0x00456A64 File Offset: 0x00454C64
		public ICheckCurrentRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F2D RID: 36653
		// (get) Token: 0x0601F175 RID: 127349 RVA: 0x00456A74 File Offset: 0x00454C74
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

		// Token: 0x17008F2E RID: 36654
		// (get) Token: 0x0601F176 RID: 127350 RVA: 0x00456AB0 File Offset: 0x00454CB0
		public int RoleId
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

		// Token: 0x17008F2F RID: 36655
		// (get) Token: 0x0601F177 RID: 127351 RVA: 0x00456AEC File Offset: 0x00454CEC
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

		// Token: 0x17008F30 RID: 36656
		// (get) Token: 0x0601F178 RID: 127352 RVA: 0x00456B28 File Offset: 0x00454D28
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

		// Token: 0x0601F179 RID: 127353 RVA: 0x00456B68 File Offset: 0x00454D68
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F17A RID: 127354 RVA: 0x00456BB0 File Offset: 0x00454DB0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F17B RID: 127355 RVA: 0x00456BCC File Offset: 0x00454DCC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F17C RID: 127356 RVA: 0x00456BE7 File Offset: 0x00454DE7
		public static Offset<ICheckCurrentRole> CreateICheckCurrentRole(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int RoleId = 0, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			ICheckCurrentRole.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckCurrentRole.AddRoleId(builder, RoleId);
			ICheckCurrentRole.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckCurrentRole.AddCompare(builder, Compare);
			ICheckCurrentRole.AddType(builder, Type);
			return ICheckCurrentRole.EndICheckCurrentRole(builder);
		}

		// Token: 0x0601F17D RID: 127357 RVA: 0x00456C1B File Offset: 0x00454E1B
		public static void StartICheckCurrentRole(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F17E RID: 127358 RVA: 0x00456C24 File Offset: 0x00454E24
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F17F RID: 127359 RVA: 0x00456C2F File Offset: 0x00454E2F
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0601F180 RID: 127360 RVA: 0x00456C3A File Offset: 0x00454E3A
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F181 RID: 127361 RVA: 0x00456C45 File Offset: 0x00454E45
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F182 RID: 127362 RVA: 0x00456C50 File Offset: 0x00454E50
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F183 RID: 127363 RVA: 0x00456C5B File Offset: 0x00454E5B
		public static Offset<ICheckCurrentRole> EndICheckCurrentRole(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCurrentRole>(builder.EndTable());
		}

		// Token: 0x0601F184 RID: 127364 RVA: 0x00456C68 File Offset: 0x00454E68
		public ICheckCurrentRoleT UnPack()
		{
			ICheckCurrentRoleT checkCurrentRoleT = new ICheckCurrentRoleT();
			this.UnPackTo(checkCurrentRoleT);
			return checkCurrentRoleT;
		}

		// Token: 0x0601F185 RID: 127365 RVA: 0x00456C84 File Offset: 0x00454E84
		public void UnPackTo(ICheckCurrentRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
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

		// Token: 0x0601F186 RID: 127366 RVA: 0x00456D4C File Offset: 0x00454F4C
		public static Offset<ICheckCurrentRole> Pack(FlatBufferBuilder builder, ICheckCurrentRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCurrentRole>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckCurrentRole.CreateICheckCurrentRole(builder, _o.Type, _o.RoleId, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400DCA2 RID: 56482
		private Table __p;
	}
}

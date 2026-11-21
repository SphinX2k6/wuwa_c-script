using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007806 RID: 30726
	public struct ISetNpcHuggingBearPerform : IFlatbufferObject
	{
		// Token: 0x1700E131 RID: 57649
		// (get) Token: 0x06035FB7 RID: 221111 RVA: 0x0073B137 File Offset: 0x00739337
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035FB8 RID: 221112 RVA: 0x0073B144 File Offset: 0x00739344
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035FB9 RID: 221113 RVA: 0x0073B14C File Offset: 0x0073934C
		public static ISetNpcHuggingBearPerform GetRootAsISetNpcHuggingBearPerform(ByteBuffer _bb)
		{
			return ISetNpcHuggingBearPerform.GetRootAsISetNpcHuggingBearPerform(_bb, default(ISetNpcHuggingBearPerform));
		}

		// Token: 0x06035FBA RID: 221114 RVA: 0x0073B168 File Offset: 0x00739368
		public static ISetNpcHuggingBearPerform GetRootAsISetNpcHuggingBearPerform(ByteBuffer _bb, ISetNpcHuggingBearPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035FBB RID: 221115 RVA: 0x0073B185 File Offset: 0x00739385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FBC RID: 221116 RVA: 0x0073B194 File Offset: 0x00739394
		public ISetNpcHuggingBearPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E132 RID: 57650
		// (get) Token: 0x06035FBD RID: 221117 RVA: 0x0073B1A4 File Offset: 0x007393A4
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E133 RID: 57651
		// (get) Token: 0x06035FBE RID: 221118 RVA: 0x0073B1E0 File Offset: 0x007393E0
		public IPlayerInitiator? Initiator
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerInitiator?(default(IPlayerInitiator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E134 RID: 57652
		// (get) Token: 0x06035FBF RID: 221119 RVA: 0x0073B240 File Offset: 0x00739440
		public int Target
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E135 RID: 57653
		// (get) Token: 0x06035FC0 RID: 221120 RVA: 0x0073B27C File Offset: 0x0073947C
		public ENpcGroupPerformNpcType NpcType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ENpcGroupPerformNpcType.LevelBCommonMale;
				}
				return (ENpcGroupPerformNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035FC1 RID: 221121 RVA: 0x0073B2B9 File Offset: 0x007394B9
		public static Offset<ISetNpcHuggingBearPerform> CreateISetNpcHuggingBearPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0, ENpcGroupPerformNpcType NpcType = ENpcGroupPerformNpcType.LevelBCommonMale)
		{
			builder.StartTable(4);
			ISetNpcHuggingBearPerform.AddTarget(builder, Target);
			ISetNpcHuggingBearPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHuggingBearPerform.AddNpcType(builder, NpcType);
			ISetNpcHuggingBearPerform.AddType(builder, Type);
			return ISetNpcHuggingBearPerform.EndISetNpcHuggingBearPerform(builder);
		}

		// Token: 0x06035FC2 RID: 221122 RVA: 0x0073B2E5 File Offset: 0x007394E5
		public static void StartISetNpcHuggingBearPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035FC3 RID: 221123 RVA: 0x0073B2EE File Offset: 0x007394EE
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035FC4 RID: 221124 RVA: 0x0073B2F9 File Offset: 0x007394F9
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06035FC5 RID: 221125 RVA: 0x0073B309 File Offset: 0x00739509
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06035FC6 RID: 221126 RVA: 0x0073B314 File Offset: 0x00739514
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(3, (byte)npcType, 0);
		}

		// Token: 0x06035FC7 RID: 221127 RVA: 0x0073B31F File Offset: 0x0073951F
		public static Offset<ISetNpcHuggingBearPerform> EndISetNpcHuggingBearPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHuggingBearPerform>(builder.EndTable());
		}

		// Token: 0x06035FC8 RID: 221128 RVA: 0x0073B32C File Offset: 0x0073952C
		public ISetNpcHuggingBearPerformT UnPack()
		{
			ISetNpcHuggingBearPerformT setNpcHuggingBearPerformT = new ISetNpcHuggingBearPerformT();
			this.UnPackTo(setNpcHuggingBearPerformT);
			return setNpcHuggingBearPerformT;
		}

		// Token: 0x06035FC9 RID: 221129 RVA: 0x0073B348 File Offset: 0x00739548
		public void UnPackTo(ISetNpcHuggingBearPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
			_o.NpcType = this.NpcType;
		}

		// Token: 0x06035FCA RID: 221130 RVA: 0x0073B3A8 File Offset: 0x007395A8
		public static Offset<ISetNpcHuggingBearPerform> Pack(FlatBufferBuilder builder, ISetNpcHuggingBearPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHuggingBearPerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHuggingBearPerform.CreateISetNpcHuggingBearPerform(builder, _o.Type, initiatorOffset, _o.Target, _o.NpcType);
		}

		// Token: 0x04012A5D RID: 76381
		private Table __p;
	}
}

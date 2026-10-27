using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703A RID: 28730
	public struct ISetNpcHighFivePerform : IFlatbufferObject
	{
		// Token: 0x1700D554 RID: 54612
		// (get) Token: 0x06032D30 RID: 208176 RVA: 0x006DB0BB File Offset: 0x006D92BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D31 RID: 208177 RVA: 0x006DB0C8 File Offset: 0x006D92C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D32 RID: 208178 RVA: 0x006DB0D0 File Offset: 0x006D92D0
		public static ISetNpcHighFivePerform GetRootAsISetNpcHighFivePerform(ByteBuffer _bb)
		{
			return ISetNpcHighFivePerform.GetRootAsISetNpcHighFivePerform(_bb, default(ISetNpcHighFivePerform));
		}

		// Token: 0x06032D33 RID: 208179 RVA: 0x006DB0EC File Offset: 0x006D92EC
		public static ISetNpcHighFivePerform GetRootAsISetNpcHighFivePerform(ByteBuffer _bb, ISetNpcHighFivePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D34 RID: 208180 RVA: 0x006DB109 File Offset: 0x006D9309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D35 RID: 208181 RVA: 0x006DB118 File Offset: 0x006D9318
		public ISetNpcHighFivePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D555 RID: 54613
		// (get) Token: 0x06032D36 RID: 208182 RVA: 0x006DB128 File Offset: 0x006D9328
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

		// Token: 0x1700D556 RID: 54614
		// (get) Token: 0x06032D37 RID: 208183 RVA: 0x006DB164 File Offset: 0x006D9364
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

		// Token: 0x1700D557 RID: 54615
		// (get) Token: 0x06032D38 RID: 208184 RVA: 0x006DB1C4 File Offset: 0x006D93C4
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

		// Token: 0x1700D558 RID: 54616
		// (get) Token: 0x06032D39 RID: 208185 RVA: 0x006DB200 File Offset: 0x006D9400
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

		// Token: 0x06032D3A RID: 208186 RVA: 0x006DB23D File Offset: 0x006D943D
		public static Offset<ISetNpcHighFivePerform> CreateISetNpcHighFivePerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0, ENpcGroupPerformNpcType NpcType = ENpcGroupPerformNpcType.LevelBCommonMale)
		{
			builder.StartTable(4);
			ISetNpcHighFivePerform.AddTarget(builder, Target);
			ISetNpcHighFivePerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHighFivePerform.AddNpcType(builder, NpcType);
			ISetNpcHighFivePerform.AddType(builder, Type);
			return ISetNpcHighFivePerform.EndISetNpcHighFivePerform(builder);
		}

		// Token: 0x06032D3B RID: 208187 RVA: 0x006DB269 File Offset: 0x006D9469
		public static void StartISetNpcHighFivePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032D3C RID: 208188 RVA: 0x006DB272 File Offset: 0x006D9472
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D3D RID: 208189 RVA: 0x006DB27D File Offset: 0x006D947D
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06032D3E RID: 208190 RVA: 0x006DB28D File Offset: 0x006D948D
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06032D3F RID: 208191 RVA: 0x006DB298 File Offset: 0x006D9498
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(3, (byte)npcType, 0);
		}

		// Token: 0x06032D40 RID: 208192 RVA: 0x006DB2A3 File Offset: 0x006D94A3
		public static Offset<ISetNpcHighFivePerform> EndISetNpcHighFivePerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHighFivePerform>(builder.EndTable());
		}

		// Token: 0x06032D41 RID: 208193 RVA: 0x006DB2B0 File Offset: 0x006D94B0
		public ISetNpcHighFivePerformT UnPack()
		{
			ISetNpcHighFivePerformT setNpcHighFivePerformT = new ISetNpcHighFivePerformT();
			this.UnPackTo(setNpcHighFivePerformT);
			return setNpcHighFivePerformT;
		}

		// Token: 0x06032D42 RID: 208194 RVA: 0x006DB2CC File Offset: 0x006D94CC
		public void UnPackTo(ISetNpcHighFivePerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
			_o.NpcType = this.NpcType;
		}

		// Token: 0x06032D43 RID: 208195 RVA: 0x006DB32C File Offset: 0x006D952C
		public static Offset<ISetNpcHighFivePerform> Pack(FlatBufferBuilder builder, ISetNpcHighFivePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHighFivePerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHighFivePerform.CreateISetNpcHighFivePerform(builder, _o.Type, initiatorOffset, _o.Target, _o.NpcType);
		}

		// Token: 0x04011A72 RID: 72306
		private Table __p;
	}
}

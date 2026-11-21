using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007803 RID: 30723
	public struct ISetNpcHighFivePerform : IFlatbufferObject
	{
		// Token: 0x1700E128 RID: 57640
		// (get) Token: 0x06035F99 RID: 221081 RVA: 0x0073AD97 File Offset: 0x00738F97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F9A RID: 221082 RVA: 0x0073ADA4 File Offset: 0x00738FA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F9B RID: 221083 RVA: 0x0073ADAC File Offset: 0x00738FAC
		public static ISetNpcHighFivePerform GetRootAsISetNpcHighFivePerform(ByteBuffer _bb)
		{
			return ISetNpcHighFivePerform.GetRootAsISetNpcHighFivePerform(_bb, default(ISetNpcHighFivePerform));
		}

		// Token: 0x06035F9C RID: 221084 RVA: 0x0073ADC8 File Offset: 0x00738FC8
		public static ISetNpcHighFivePerform GetRootAsISetNpcHighFivePerform(ByteBuffer _bb, ISetNpcHighFivePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F9D RID: 221085 RVA: 0x0073ADE5 File Offset: 0x00738FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F9E RID: 221086 RVA: 0x0073ADF4 File Offset: 0x00738FF4
		public ISetNpcHighFivePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E129 RID: 57641
		// (get) Token: 0x06035F9F RID: 221087 RVA: 0x0073AE04 File Offset: 0x00739004
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

		// Token: 0x1700E12A RID: 57642
		// (get) Token: 0x06035FA0 RID: 221088 RVA: 0x0073AE40 File Offset: 0x00739040
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

		// Token: 0x1700E12B RID: 57643
		// (get) Token: 0x06035FA1 RID: 221089 RVA: 0x0073AEA0 File Offset: 0x007390A0
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

		// Token: 0x1700E12C RID: 57644
		// (get) Token: 0x06035FA2 RID: 221090 RVA: 0x0073AEDC File Offset: 0x007390DC
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

		// Token: 0x06035FA3 RID: 221091 RVA: 0x0073AF19 File Offset: 0x00739119
		public static Offset<ISetNpcHighFivePerform> CreateISetNpcHighFivePerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0, ENpcGroupPerformNpcType NpcType = ENpcGroupPerformNpcType.LevelBCommonMale)
		{
			builder.StartTable(4);
			ISetNpcHighFivePerform.AddTarget(builder, Target);
			ISetNpcHighFivePerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHighFivePerform.AddNpcType(builder, NpcType);
			ISetNpcHighFivePerform.AddType(builder, Type);
			return ISetNpcHighFivePerform.EndISetNpcHighFivePerform(builder);
		}

		// Token: 0x06035FA4 RID: 221092 RVA: 0x0073AF45 File Offset: 0x00739145
		public static void StartISetNpcHighFivePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035FA5 RID: 221093 RVA: 0x0073AF4E File Offset: 0x0073914E
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035FA6 RID: 221094 RVA: 0x0073AF59 File Offset: 0x00739159
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06035FA7 RID: 221095 RVA: 0x0073AF69 File Offset: 0x00739169
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06035FA8 RID: 221096 RVA: 0x0073AF74 File Offset: 0x00739174
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(3, (byte)npcType, 0);
		}

		// Token: 0x06035FA9 RID: 221097 RVA: 0x0073AF7F File Offset: 0x0073917F
		public static Offset<ISetNpcHighFivePerform> EndISetNpcHighFivePerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHighFivePerform>(builder.EndTable());
		}

		// Token: 0x06035FAA RID: 221098 RVA: 0x0073AF8C File Offset: 0x0073918C
		public ISetNpcHighFivePerformT UnPack()
		{
			ISetNpcHighFivePerformT setNpcHighFivePerformT = new ISetNpcHighFivePerformT();
			this.UnPackTo(setNpcHighFivePerformT);
			return setNpcHighFivePerformT;
		}

		// Token: 0x06035FAB RID: 221099 RVA: 0x0073AFA8 File Offset: 0x007391A8
		public void UnPackTo(ISetNpcHighFivePerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
			_o.NpcType = this.NpcType;
		}

		// Token: 0x06035FAC RID: 221100 RVA: 0x0073B008 File Offset: 0x00739208
		public static Offset<ISetNpcHighFivePerform> Pack(FlatBufferBuilder builder, ISetNpcHighFivePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHighFivePerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHighFivePerform.CreateISetNpcHighFivePerform(builder, _o.Type, initiatorOffset, _o.Target, _o.NpcType);
		}

		// Token: 0x04012A58 RID: 76376
		private Table __p;
	}
}

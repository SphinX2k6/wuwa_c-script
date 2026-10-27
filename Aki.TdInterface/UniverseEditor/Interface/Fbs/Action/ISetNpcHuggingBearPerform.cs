using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703D RID: 28733
	public struct ISetNpcHuggingBearPerform : IFlatbufferObject
	{
		// Token: 0x1700D55D RID: 54621
		// (get) Token: 0x06032D4E RID: 208206 RVA: 0x006DB45B File Offset: 0x006D965B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D4F RID: 208207 RVA: 0x006DB468 File Offset: 0x006D9668
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D50 RID: 208208 RVA: 0x006DB470 File Offset: 0x006D9670
		public static ISetNpcHuggingBearPerform GetRootAsISetNpcHuggingBearPerform(ByteBuffer _bb)
		{
			return ISetNpcHuggingBearPerform.GetRootAsISetNpcHuggingBearPerform(_bb, default(ISetNpcHuggingBearPerform));
		}

		// Token: 0x06032D51 RID: 208209 RVA: 0x006DB48C File Offset: 0x006D968C
		public static ISetNpcHuggingBearPerform GetRootAsISetNpcHuggingBearPerform(ByteBuffer _bb, ISetNpcHuggingBearPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D52 RID: 208210 RVA: 0x006DB4A9 File Offset: 0x006D96A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D53 RID: 208211 RVA: 0x006DB4B8 File Offset: 0x006D96B8
		public ISetNpcHuggingBearPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D55E RID: 54622
		// (get) Token: 0x06032D54 RID: 208212 RVA: 0x006DB4C8 File Offset: 0x006D96C8
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

		// Token: 0x1700D55F RID: 54623
		// (get) Token: 0x06032D55 RID: 208213 RVA: 0x006DB504 File Offset: 0x006D9704
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

		// Token: 0x1700D560 RID: 54624
		// (get) Token: 0x06032D56 RID: 208214 RVA: 0x006DB564 File Offset: 0x006D9764
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

		// Token: 0x1700D561 RID: 54625
		// (get) Token: 0x06032D57 RID: 208215 RVA: 0x006DB5A0 File Offset: 0x006D97A0
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

		// Token: 0x06032D58 RID: 208216 RVA: 0x006DB5DD File Offset: 0x006D97DD
		public static Offset<ISetNpcHuggingBearPerform> CreateISetNpcHuggingBearPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0, ENpcGroupPerformNpcType NpcType = ENpcGroupPerformNpcType.LevelBCommonMale)
		{
			builder.StartTable(4);
			ISetNpcHuggingBearPerform.AddTarget(builder, Target);
			ISetNpcHuggingBearPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHuggingBearPerform.AddNpcType(builder, NpcType);
			ISetNpcHuggingBearPerform.AddType(builder, Type);
			return ISetNpcHuggingBearPerform.EndISetNpcHuggingBearPerform(builder);
		}

		// Token: 0x06032D59 RID: 208217 RVA: 0x006DB609 File Offset: 0x006D9809
		public static void StartISetNpcHuggingBearPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032D5A RID: 208218 RVA: 0x006DB612 File Offset: 0x006D9812
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D5B RID: 208219 RVA: 0x006DB61D File Offset: 0x006D981D
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06032D5C RID: 208220 RVA: 0x006DB62D File Offset: 0x006D982D
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06032D5D RID: 208221 RVA: 0x006DB638 File Offset: 0x006D9838
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(3, (byte)npcType, 0);
		}

		// Token: 0x06032D5E RID: 208222 RVA: 0x006DB643 File Offset: 0x006D9843
		public static Offset<ISetNpcHuggingBearPerform> EndISetNpcHuggingBearPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHuggingBearPerform>(builder.EndTable());
		}

		// Token: 0x06032D5F RID: 208223 RVA: 0x006DB650 File Offset: 0x006D9850
		public ISetNpcHuggingBearPerformT UnPack()
		{
			ISetNpcHuggingBearPerformT setNpcHuggingBearPerformT = new ISetNpcHuggingBearPerformT();
			this.UnPackTo(setNpcHuggingBearPerformT);
			return setNpcHuggingBearPerformT;
		}

		// Token: 0x06032D60 RID: 208224 RVA: 0x006DB66C File Offset: 0x006D986C
		public void UnPackTo(ISetNpcHuggingBearPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
			_o.NpcType = this.NpcType;
		}

		// Token: 0x06032D61 RID: 208225 RVA: 0x006DB6CC File Offset: 0x006D98CC
		public static Offset<ISetNpcHuggingBearPerform> Pack(FlatBufferBuilder builder, ISetNpcHuggingBearPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHuggingBearPerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHuggingBearPerform.CreateISetNpcHuggingBearPerform(builder, _o.Type, initiatorOffset, _o.Target, _o.NpcType);
		}

		// Token: 0x04011A77 RID: 72311
		private Table __p;
	}
}

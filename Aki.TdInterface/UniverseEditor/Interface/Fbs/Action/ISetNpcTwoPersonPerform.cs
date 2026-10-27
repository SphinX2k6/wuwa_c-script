using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007043 RID: 28739
	public struct ISetNpcTwoPersonPerform : IFlatbufferObject
	{
		// Token: 0x1700D56D RID: 54637
		// (get) Token: 0x06032D86 RID: 208262 RVA: 0x006DBB13 File Offset: 0x006D9D13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D87 RID: 208263 RVA: 0x006DBB20 File Offset: 0x006D9D20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D88 RID: 208264 RVA: 0x006DBB28 File Offset: 0x006D9D28
		public static ISetNpcTwoPersonPerform GetRootAsISetNpcTwoPersonPerform(ByteBuffer _bb)
		{
			return ISetNpcTwoPersonPerform.GetRootAsISetNpcTwoPersonPerform(_bb, default(ISetNpcTwoPersonPerform));
		}

		// Token: 0x06032D89 RID: 208265 RVA: 0x006DBB44 File Offset: 0x006D9D44
		public static ISetNpcTwoPersonPerform GetRootAsISetNpcTwoPersonPerform(ByteBuffer _bb, ISetNpcTwoPersonPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D8A RID: 208266 RVA: 0x006DBB61 File Offset: 0x006D9D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D8B RID: 208267 RVA: 0x006DBB70 File Offset: 0x006D9D70
		public ISetNpcTwoPersonPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D56E RID: 54638
		// (get) Token: 0x06032D8C RID: 208268 RVA: 0x006DBB80 File Offset: 0x006D9D80
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

		// Token: 0x1700D56F RID: 54639
		// (get) Token: 0x06032D8D RID: 208269 RVA: 0x006DBBBC File Offset: 0x006D9DBC
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

		// Token: 0x1700D570 RID: 54640
		// (get) Token: 0x06032D8E RID: 208270 RVA: 0x006DBC1C File Offset: 0x006D9E1C
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

		// Token: 0x1700D571 RID: 54641
		// (get) Token: 0x06032D8F RID: 208271 RVA: 0x006DBC58 File Offset: 0x006D9E58
		public string GroupPerformMark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D90 RID: 208272 RVA: 0x006DBC90 File Offset: 0x006D9E90
		public Span<byte> GetGroupPerformMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06032D91 RID: 208273 RVA: 0x006DBCA0 File Offset: 0x006D9EA0
		public byte[] GetGroupPerformMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D572 RID: 54642
		// (get) Token: 0x06032D92 RID: 208274 RVA: 0x006DBCB0 File Offset: 0x006D9EB0
		public ENpcGroupPerformNpcType NpcType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ENpcGroupPerformNpcType.LevelBCommonMale;
				}
				return (ENpcGroupPerformNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D573 RID: 54643
		// (get) Token: 0x06032D93 RID: 208275 RVA: 0x006DBCF0 File Offset: 0x006D9EF0
		public EWaitInteractNpcMontageWaitType WaitInteractNpcType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EWaitInteractNpcMontageWaitType.WaitForMontage;
				}
				return (EWaitInteractNpcMontageWaitType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D574 RID: 54644
		// (get) Token: 0x06032D94 RID: 208276 RVA: 0x006DBD30 File Offset: 0x006D9F30
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D95 RID: 208277 RVA: 0x006DBD70 File Offset: 0x006D9F70
		public static Offset<ISetNpcTwoPersonPerform> CreateISetNpcTwoPersonPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0, StringOffset GroupPerformMarkOffset = default(StringOffset), ENpcGroupPerformNpcType NpcType = ENpcGroupPerformNpcType.LevelBCommonMale, EWaitInteractNpcMontageWaitType WaitInteractNpcType = EWaitInteractNpcMontageWaitType.WaitForMontage, byte NullMask = 0)
		{
			builder.StartTable(7);
			ISetNpcTwoPersonPerform.AddGroupPerformMark(builder, GroupPerformMarkOffset);
			ISetNpcTwoPersonPerform.AddTarget(builder, Target);
			ISetNpcTwoPersonPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcTwoPersonPerform.AddNullMask(builder, NullMask);
			ISetNpcTwoPersonPerform.AddWaitInteractNpcType(builder, WaitInteractNpcType);
			ISetNpcTwoPersonPerform.AddNpcType(builder, NpcType);
			ISetNpcTwoPersonPerform.AddType(builder, Type);
			return ISetNpcTwoPersonPerform.EndISetNpcTwoPersonPerform(builder);
		}

		// Token: 0x06032D96 RID: 208278 RVA: 0x006DBDBF File Offset: 0x006D9FBF
		public static void StartISetNpcTwoPersonPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06032D97 RID: 208279 RVA: 0x006DBDC8 File Offset: 0x006D9FC8
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D98 RID: 208280 RVA: 0x006DBDD3 File Offset: 0x006D9FD3
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06032D99 RID: 208281 RVA: 0x006DBDE3 File Offset: 0x006D9FE3
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06032D9A RID: 208282 RVA: 0x006DBDEE File Offset: 0x006D9FEE
		public static void AddGroupPerformMark(FlatBufferBuilder builder, StringOffset groupPerformMarkOffset)
		{
			builder.AddOffset(3, groupPerformMarkOffset.Value, 0);
		}

		// Token: 0x06032D9B RID: 208283 RVA: 0x006DBDFE File Offset: 0x006D9FFE
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(4, (byte)npcType, 0);
		}

		// Token: 0x06032D9C RID: 208284 RVA: 0x006DBE09 File Offset: 0x006DA009
		public static void AddWaitInteractNpcType(FlatBufferBuilder builder, EWaitInteractNpcMontageWaitType waitInteractNpcType)
		{
			builder.AddByte(5, (byte)waitInteractNpcType, 0);
		}

		// Token: 0x06032D9D RID: 208285 RVA: 0x006DBE14 File Offset: 0x006DA014
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06032D9E RID: 208286 RVA: 0x006DBE1F File Offset: 0x006DA01F
		public static Offset<ISetNpcTwoPersonPerform> EndISetNpcTwoPersonPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcTwoPersonPerform>(builder.EndTable());
		}

		// Token: 0x06032D9F RID: 208287 RVA: 0x006DBE2C File Offset: 0x006DA02C
		public ISetNpcTwoPersonPerformT UnPack()
		{
			ISetNpcTwoPersonPerformT setNpcTwoPersonPerformT = new ISetNpcTwoPersonPerformT();
			this.UnPackTo(setNpcTwoPersonPerformT);
			return setNpcTwoPersonPerformT;
		}

		// Token: 0x06032DA0 RID: 208288 RVA: 0x006DBE48 File Offset: 0x006DA048
		public void UnPackTo(ISetNpcTwoPersonPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
			_o.GroupPerformMark = this.GroupPerformMark;
			_o.NpcType = this.NpcType;
			_o.WaitInteractNpcType = this.WaitInteractNpcType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032DA1 RID: 208289 RVA: 0x006DBECC File Offset: 0x006DA0CC
		public static Offset<ISetNpcTwoPersonPerform> Pack(FlatBufferBuilder builder, ISetNpcTwoPersonPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcTwoPersonPerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			StringOffset groupPerformMarkOffset = (_o.GroupPerformMark == null) ? default(StringOffset) : builder.CreateString(_o.GroupPerformMark);
			return ISetNpcTwoPersonPerform.CreateISetNpcTwoPersonPerform(builder, _o.Type, initiatorOffset, _o.Target, groupPerformMarkOffset, _o.NpcType, _o.WaitInteractNpcType, _o.NullMask);
		}

		// Token: 0x04011A80 RID: 72320
		private Table __p;
	}
}

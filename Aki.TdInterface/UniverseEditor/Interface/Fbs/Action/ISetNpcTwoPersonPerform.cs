using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780F RID: 30735
	public struct ISetNpcTwoPersonPerform : IFlatbufferObject
	{
		// Token: 0x1700E14E RID: 57678
		// (get) Token: 0x06036023 RID: 221219 RVA: 0x0073C03B File Offset: 0x0073A23B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036024 RID: 221220 RVA: 0x0073C048 File Offset: 0x0073A248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036025 RID: 221221 RVA: 0x0073C050 File Offset: 0x0073A250
		public static ISetNpcTwoPersonPerform GetRootAsISetNpcTwoPersonPerform(ByteBuffer _bb)
		{
			return ISetNpcTwoPersonPerform.GetRootAsISetNpcTwoPersonPerform(_bb, default(ISetNpcTwoPersonPerform));
		}

		// Token: 0x06036026 RID: 221222 RVA: 0x0073C06C File Offset: 0x0073A26C
		public static ISetNpcTwoPersonPerform GetRootAsISetNpcTwoPersonPerform(ByteBuffer _bb, ISetNpcTwoPersonPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036027 RID: 221223 RVA: 0x0073C089 File Offset: 0x0073A289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036028 RID: 221224 RVA: 0x0073C098 File Offset: 0x0073A298
		public ISetNpcTwoPersonPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E14F RID: 57679
		// (get) Token: 0x06036029 RID: 221225 RVA: 0x0073C0A8 File Offset: 0x0073A2A8
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

		// Token: 0x1700E150 RID: 57680
		// (get) Token: 0x0603602A RID: 221226 RVA: 0x0073C0E4 File Offset: 0x0073A2E4
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

		// Token: 0x1700E151 RID: 57681
		// (get) Token: 0x0603602B RID: 221227 RVA: 0x0073C144 File Offset: 0x0073A344
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

		// Token: 0x1700E152 RID: 57682
		// (get) Token: 0x0603602C RID: 221228 RVA: 0x0073C180 File Offset: 0x0073A380
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

		// Token: 0x0603602D RID: 221229 RVA: 0x0073C1B8 File Offset: 0x0073A3B8
		public Span<byte> GetGroupPerformMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603602E RID: 221230 RVA: 0x0073C1C8 File Offset: 0x0073A3C8
		public byte[] GetGroupPerformMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E153 RID: 57683
		// (get) Token: 0x0603602F RID: 221231 RVA: 0x0073C1D8 File Offset: 0x0073A3D8
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

		// Token: 0x1700E154 RID: 57684
		// (get) Token: 0x06036030 RID: 221232 RVA: 0x0073C218 File Offset: 0x0073A418
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

		// Token: 0x1700E155 RID: 57685
		// (get) Token: 0x06036031 RID: 221233 RVA: 0x0073C258 File Offset: 0x0073A458
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

		// Token: 0x06036032 RID: 221234 RVA: 0x0073C298 File Offset: 0x0073A498
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

		// Token: 0x06036033 RID: 221235 RVA: 0x0073C2E7 File Offset: 0x0073A4E7
		public static void StartISetNpcTwoPersonPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036034 RID: 221236 RVA: 0x0073C2F0 File Offset: 0x0073A4F0
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036035 RID: 221237 RVA: 0x0073C2FB File Offset: 0x0073A4FB
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06036036 RID: 221238 RVA: 0x0073C30B File Offset: 0x0073A50B
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06036037 RID: 221239 RVA: 0x0073C316 File Offset: 0x0073A516
		public static void AddGroupPerformMark(FlatBufferBuilder builder, StringOffset groupPerformMarkOffset)
		{
			builder.AddOffset(3, groupPerformMarkOffset.Value, 0);
		}

		// Token: 0x06036038 RID: 221240 RVA: 0x0073C326 File Offset: 0x0073A526
		public static void AddNpcType(FlatBufferBuilder builder, ENpcGroupPerformNpcType npcType)
		{
			builder.AddByte(4, (byte)npcType, 0);
		}

		// Token: 0x06036039 RID: 221241 RVA: 0x0073C331 File Offset: 0x0073A531
		public static void AddWaitInteractNpcType(FlatBufferBuilder builder, EWaitInteractNpcMontageWaitType waitInteractNpcType)
		{
			builder.AddByte(5, (byte)waitInteractNpcType, 0);
		}

		// Token: 0x0603603A RID: 221242 RVA: 0x0073C33C File Offset: 0x0073A53C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603603B RID: 221243 RVA: 0x0073C347 File Offset: 0x0073A547
		public static Offset<ISetNpcTwoPersonPerform> EndISetNpcTwoPersonPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcTwoPersonPerform>(builder.EndTable());
		}

		// Token: 0x0603603C RID: 221244 RVA: 0x0073C354 File Offset: 0x0073A554
		public ISetNpcTwoPersonPerformT UnPack()
		{
			ISetNpcTwoPersonPerformT setNpcTwoPersonPerformT = new ISetNpcTwoPersonPerformT();
			this.UnPackTo(setNpcTwoPersonPerformT);
			return setNpcTwoPersonPerformT;
		}

		// Token: 0x0603603D RID: 221245 RVA: 0x0073C370 File Offset: 0x0073A570
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

		// Token: 0x0603603E RID: 221246 RVA: 0x0073C3F4 File Offset: 0x0073A5F4
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

		// Token: 0x04012A6D RID: 76397
		private Table __p;
	}
}

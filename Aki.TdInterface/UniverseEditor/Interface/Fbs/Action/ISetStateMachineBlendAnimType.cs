using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007848 RID: 30792
	public struct ISetStateMachineBlendAnimType : IFlatbufferObject
	{
		// Token: 0x1700E1E0 RID: 57824
		// (get) Token: 0x0603625D RID: 221789 RVA: 0x00740E59 File Offset: 0x0073F059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603625E RID: 221790 RVA: 0x00740E66 File Offset: 0x0073F066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603625F RID: 221791 RVA: 0x00740E70 File Offset: 0x0073F070
		public static ISetStateMachineBlendAnimType GetRootAsISetStateMachineBlendAnimType(ByteBuffer _bb)
		{
			return ISetStateMachineBlendAnimType.GetRootAsISetStateMachineBlendAnimType(_bb, default(ISetStateMachineBlendAnimType));
		}

		// Token: 0x06036260 RID: 221792 RVA: 0x00740E8C File Offset: 0x0073F08C
		public static ISetStateMachineBlendAnimType GetRootAsISetStateMachineBlendAnimType(ByteBuffer _bb, ISetStateMachineBlendAnimType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036261 RID: 221793 RVA: 0x00740EA9 File Offset: 0x0073F0A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036262 RID: 221794 RVA: 0x00740EB8 File Offset: 0x0073F0B8
		public ISetStateMachineBlendAnimType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1E1 RID: 57825
		// (get) Token: 0x06036263 RID: 221795 RVA: 0x00740EC8 File Offset: 0x0073F0C8
		public EBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimType.StateMachine;
				}
				return (EBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1E2 RID: 57826
		// (get) Token: 0x06036264 RID: 221796 RVA: 0x00740F04 File Offset: 0x0073F104
		public EBlendAnimState State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EBlendAnimState.CombatIdle;
				}
				return (EBlendAnimState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036265 RID: 221797 RVA: 0x00740F40 File Offset: 0x0073F140
		public static Offset<ISetStateMachineBlendAnimType> CreateISetStateMachineBlendAnimType(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine, EBlendAnimState State = EBlendAnimState.CombatIdle)
		{
			builder.StartTable(2);
			ISetStateMachineBlendAnimType.AddState(builder, State);
			ISetStateMachineBlendAnimType.AddType(builder, Type);
			return ISetStateMachineBlendAnimType.EndISetStateMachineBlendAnimType(builder);
		}

		// Token: 0x06036266 RID: 221798 RVA: 0x00740F5D File Offset: 0x0073F15D
		public static void StartISetStateMachineBlendAnimType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036267 RID: 221799 RVA: 0x00740F66 File Offset: 0x0073F166
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036268 RID: 221800 RVA: 0x00740F71 File Offset: 0x0073F171
		public static void AddState(FlatBufferBuilder builder, EBlendAnimState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x06036269 RID: 221801 RVA: 0x00740F7C File Offset: 0x0073F17C
		public static Offset<ISetStateMachineBlendAnimType> EndISetStateMachineBlendAnimType(FlatBufferBuilder builder)
		{
			return new Offset<ISetStateMachineBlendAnimType>(builder.EndTable());
		}

		// Token: 0x0603626A RID: 221802 RVA: 0x00740F8C File Offset: 0x0073F18C
		public ISetStateMachineBlendAnimTypeT UnPack()
		{
			ISetStateMachineBlendAnimTypeT setStateMachineBlendAnimTypeT = new ISetStateMachineBlendAnimTypeT();
			this.UnPackTo(setStateMachineBlendAnimTypeT);
			return setStateMachineBlendAnimTypeT;
		}

		// Token: 0x0603626B RID: 221803 RVA: 0x00740FA7 File Offset: 0x0073F1A7
		public void UnPackTo(ISetStateMachineBlendAnimTypeT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0603626C RID: 221804 RVA: 0x00740FC4 File Offset: 0x0073F1C4
		public static Offset<ISetStateMachineBlendAnimType> Pack(FlatBufferBuilder builder, ISetStateMachineBlendAnimTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetStateMachineBlendAnimType>);
			}
			return ISetStateMachineBlendAnimType.CreateISetStateMachineBlendAnimType(builder, _o.Type, _o.State);
		}

		// Token: 0x04012ACF RID: 76495
		private Table __p;
	}
}

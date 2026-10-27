using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707C RID: 28796
	public struct ISetStateMachineBlendAnimType : IFlatbufferObject
	{
		// Token: 0x1700D5FD RID: 54781
		// (get) Token: 0x06032FBB RID: 208827 RVA: 0x006E084D File Offset: 0x006DEA4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FBC RID: 208828 RVA: 0x006E085A File Offset: 0x006DEA5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FBD RID: 208829 RVA: 0x006E0864 File Offset: 0x006DEA64
		public static ISetStateMachineBlendAnimType GetRootAsISetStateMachineBlendAnimType(ByteBuffer _bb)
		{
			return ISetStateMachineBlendAnimType.GetRootAsISetStateMachineBlendAnimType(_bb, default(ISetStateMachineBlendAnimType));
		}

		// Token: 0x06032FBE RID: 208830 RVA: 0x006E0880 File Offset: 0x006DEA80
		public static ISetStateMachineBlendAnimType GetRootAsISetStateMachineBlendAnimType(ByteBuffer _bb, ISetStateMachineBlendAnimType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FBF RID: 208831 RVA: 0x006E089D File Offset: 0x006DEA9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FC0 RID: 208832 RVA: 0x006E08AC File Offset: 0x006DEAAC
		public ISetStateMachineBlendAnimType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5FE RID: 54782
		// (get) Token: 0x06032FC1 RID: 208833 RVA: 0x006E08BC File Offset: 0x006DEABC
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

		// Token: 0x1700D5FF RID: 54783
		// (get) Token: 0x06032FC2 RID: 208834 RVA: 0x006E08F8 File Offset: 0x006DEAF8
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

		// Token: 0x06032FC3 RID: 208835 RVA: 0x006E0934 File Offset: 0x006DEB34
		public static Offset<ISetStateMachineBlendAnimType> CreateISetStateMachineBlendAnimType(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine, EBlendAnimState State = EBlendAnimState.CombatIdle)
		{
			builder.StartTable(2);
			ISetStateMachineBlendAnimType.AddState(builder, State);
			ISetStateMachineBlendAnimType.AddType(builder, Type);
			return ISetStateMachineBlendAnimType.EndISetStateMachineBlendAnimType(builder);
		}

		// Token: 0x06032FC4 RID: 208836 RVA: 0x006E0951 File Offset: 0x006DEB51
		public static void StartISetStateMachineBlendAnimType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032FC5 RID: 208837 RVA: 0x006E095A File Offset: 0x006DEB5A
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032FC6 RID: 208838 RVA: 0x006E0965 File Offset: 0x006DEB65
		public static void AddState(FlatBufferBuilder builder, EBlendAnimState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x06032FC7 RID: 208839 RVA: 0x006E0970 File Offset: 0x006DEB70
		public static Offset<ISetStateMachineBlendAnimType> EndISetStateMachineBlendAnimType(FlatBufferBuilder builder)
		{
			return new Offset<ISetStateMachineBlendAnimType>(builder.EndTable());
		}

		// Token: 0x06032FC8 RID: 208840 RVA: 0x006E0980 File Offset: 0x006DEB80
		public ISetStateMachineBlendAnimTypeT UnPack()
		{
			ISetStateMachineBlendAnimTypeT setStateMachineBlendAnimTypeT = new ISetStateMachineBlendAnimTypeT();
			this.UnPackTo(setStateMachineBlendAnimTypeT);
			return setStateMachineBlendAnimTypeT;
		}

		// Token: 0x06032FC9 RID: 208841 RVA: 0x006E099B File Offset: 0x006DEB9B
		public void UnPackTo(ISetStateMachineBlendAnimTypeT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06032FCA RID: 208842 RVA: 0x006E09B8 File Offset: 0x006DEBB8
		public static Offset<ISetStateMachineBlendAnimType> Pack(FlatBufferBuilder builder, ISetStateMachineBlendAnimTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetStateMachineBlendAnimType>);
			}
			return ISetStateMachineBlendAnimType.CreateISetStateMachineBlendAnimType(builder, _o.Type, _o.State);
		}

		// Token: 0x04011AE1 RID: 72417
		private Table __p;
	}
}

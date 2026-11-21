using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591E RID: 22814
	public struct IHitLogicChangeNextAndLockTargetState : IFlatbufferObject
	{
		// Token: 0x1700A576 RID: 42358
		// (get) Token: 0x0602516E RID: 151918 RVA: 0x00517281 File Offset: 0x00515481
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602516F RID: 151919 RVA: 0x0051728E File Offset: 0x0051548E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025170 RID: 151920 RVA: 0x00517298 File Offset: 0x00515498
		public static IHitLogicChangeNextAndLockTargetState GetRootAsIHitLogicChangeNextAndLockTargetState(ByteBuffer _bb)
		{
			return IHitLogicChangeNextAndLockTargetState.GetRootAsIHitLogicChangeNextAndLockTargetState(_bb, default(IHitLogicChangeNextAndLockTargetState));
		}

		// Token: 0x06025171 RID: 151921 RVA: 0x005172B4 File Offset: 0x005154B4
		public static IHitLogicChangeNextAndLockTargetState GetRootAsIHitLogicChangeNextAndLockTargetState(ByteBuffer _bb, IHitLogicChangeNextAndLockTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025172 RID: 151922 RVA: 0x005172D1 File Offset: 0x005154D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025173 RID: 151923 RVA: 0x005172E0 File Offset: 0x005154E0
		public IHitLogicChangeNextAndLockTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A577 RID: 42359
		// (get) Token: 0x06025174 RID: 151924 RVA: 0x005172F0 File Offset: 0x005154F0
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A578 RID: 42360
		// (get) Token: 0x06025175 RID: 151925 RVA: 0x0051732C File Offset: 0x0051552C
		public string TargetState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x00517363 File Offset: 0x00515563
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x00517372 File Offset: 0x00515572
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x00517380 File Offset: 0x00515580
		public static Offset<IHitLogicChangeNextAndLockTargetState> CreateIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, StringOffset TargetStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IHitLogicChangeNextAndLockTargetState.AddTargetState(builder, TargetStateOffset);
			IHitLogicChangeNextAndLockTargetState.AddType(builder, Type);
			return IHitLogicChangeNextAndLockTargetState.EndIHitLogicChangeNextAndLockTargetState(builder);
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x0051739D File Offset: 0x0051559D
		public static void StartIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602517A RID: 151930 RVA: 0x005173A6 File Offset: 0x005155A6
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602517B RID: 151931 RVA: 0x005173B1 File Offset: 0x005155B1
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(1, targetStateOffset.Value, 0);
		}

		// Token: 0x0602517C RID: 151932 RVA: 0x005173C1 File Offset: 0x005155C1
		public static Offset<IHitLogicChangeNextAndLockTargetState> EndIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeNextAndLockTargetState>(builder.EndTable());
		}

		// Token: 0x0602517D RID: 151933 RVA: 0x005173D0 File Offset: 0x005155D0
		public IHitLogicChangeNextAndLockTargetStateT UnPack()
		{
			IHitLogicChangeNextAndLockTargetStateT hitLogicChangeNextAndLockTargetStateT = new IHitLogicChangeNextAndLockTargetStateT();
			this.UnPackTo(hitLogicChangeNextAndLockTargetStateT);
			return hitLogicChangeNextAndLockTargetStateT;
		}

		// Token: 0x0602517E RID: 151934 RVA: 0x005173EB File Offset: 0x005155EB
		public void UnPackTo(IHitLogicChangeNextAndLockTargetStateT _o)
		{
			_o.Type = this.Type;
			_o.TargetState = this.TargetState;
		}

		// Token: 0x0602517F RID: 151935 RVA: 0x00517408 File Offset: 0x00515608
		public static Offset<IHitLogicChangeNextAndLockTargetState> Pack(FlatBufferBuilder builder, IHitLogicChangeNextAndLockTargetStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeNextAndLockTargetState>);
			}
			StringOffset targetStateOffset = (_o.TargetState == null) ? default(StringOffset) : builder.CreateString(_o.TargetState);
			return IHitLogicChangeNextAndLockTargetState.CreateIHitLogicChangeNextAndLockTargetState(builder, _o.Type, targetStateOffset);
		}

		// Token: 0x0400F1B2 RID: 61874
		private Table __p;
	}
}

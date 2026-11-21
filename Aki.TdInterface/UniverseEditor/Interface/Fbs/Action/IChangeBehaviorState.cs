using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006940 RID: 26944
	public struct IChangeBehaviorState : IFlatbufferObject
	{
		// Token: 0x1700C65D RID: 50781
		// (get) Token: 0x0602E2F6 RID: 189174 RVA: 0x0064F3A2 File Offset: 0x0064D5A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2F7 RID: 189175 RVA: 0x0064F3AF File Offset: 0x0064D5AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2F8 RID: 189176 RVA: 0x0064F3B8 File Offset: 0x0064D5B8
		public static IChangeBehaviorState GetRootAsIChangeBehaviorState(ByteBuffer _bb)
		{
			return IChangeBehaviorState.GetRootAsIChangeBehaviorState(_bb, default(IChangeBehaviorState));
		}

		// Token: 0x0602E2F9 RID: 189177 RVA: 0x0064F3D4 File Offset: 0x0064D5D4
		public static IChangeBehaviorState GetRootAsIChangeBehaviorState(ByteBuffer _bb, IChangeBehaviorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2FA RID: 189178 RVA: 0x0064F3F1 File Offset: 0x0064D5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2FB RID: 189179 RVA: 0x0064F400 File Offset: 0x0064D600
		public IChangeBehaviorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C65E RID: 50782
		// (get) Token: 0x0602E2FC RID: 189180 RVA: 0x0064F410 File Offset: 0x0064D610
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C65F RID: 50783
		// (get) Token: 0x0602E2FD RID: 189181 RVA: 0x0064F44C File Offset: 0x0064D64C
		public bool IsInstant
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602E2FE RID: 189182 RVA: 0x0064F48B File Offset: 0x0064D68B
		public static Offset<IChangeBehaviorState> CreateIChangeBehaviorState(FlatBufferBuilder builder, int StateId = 0, bool IsInstant = false)
		{
			builder.StartTable(2);
			IChangeBehaviorState.AddStateId(builder, StateId);
			IChangeBehaviorState.AddIsInstant(builder, IsInstant);
			return IChangeBehaviorState.EndIChangeBehaviorState(builder);
		}

		// Token: 0x0602E2FF RID: 189183 RVA: 0x0064F4A8 File Offset: 0x0064D6A8
		public static void StartIChangeBehaviorState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E300 RID: 189184 RVA: 0x0064F4B1 File Offset: 0x0064D6B1
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x0602E301 RID: 189185 RVA: 0x0064F4BC File Offset: 0x0064D6BC
		public static void AddIsInstant(FlatBufferBuilder builder, bool isInstant)
		{
			builder.AddBool(1, isInstant, false);
		}

		// Token: 0x0602E302 RID: 189186 RVA: 0x0064F4C7 File Offset: 0x0064D6C7
		public static Offset<IChangeBehaviorState> EndIChangeBehaviorState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeBehaviorState>(builder.EndTable());
		}

		// Token: 0x0602E303 RID: 189187 RVA: 0x0064F4D4 File Offset: 0x0064D6D4
		public IChangeBehaviorStateT UnPack()
		{
			IChangeBehaviorStateT changeBehaviorStateT = new IChangeBehaviorStateT();
			this.UnPackTo(changeBehaviorStateT);
			return changeBehaviorStateT;
		}

		// Token: 0x0602E304 RID: 189188 RVA: 0x0064F4EF File Offset: 0x0064D6EF
		public void UnPackTo(IChangeBehaviorStateT _o)
		{
			_o.StateId = this.StateId;
			_o.IsInstant = this.IsInstant;
		}

		// Token: 0x0602E305 RID: 189189 RVA: 0x0064F50C File Offset: 0x0064D70C
		public static Offset<IChangeBehaviorState> Pack(FlatBufferBuilder builder, IChangeBehaviorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeBehaviorState>);
			}
			return IChangeBehaviorState.CreateIChangeBehaviorState(builder, _o.StateId, _o.IsInstant);
		}

		// Token: 0x0401168D RID: 71309
		private Table __p;
	}
}

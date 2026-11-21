using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006982 RID: 27010
	public struct IChangeOtherState : IFlatbufferObject
	{
		// Token: 0x1700C6DC RID: 50908
		// (get) Token: 0x0602E52E RID: 189742 RVA: 0x00653101 File Offset: 0x00651301
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E52F RID: 189743 RVA: 0x0065310E File Offset: 0x0065130E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E530 RID: 189744 RVA: 0x00653118 File Offset: 0x00651318
		public static IChangeOtherState GetRootAsIChangeOtherState(ByteBuffer _bb)
		{
			return IChangeOtherState.GetRootAsIChangeOtherState(_bb, default(IChangeOtherState));
		}

		// Token: 0x0602E531 RID: 189745 RVA: 0x00653134 File Offset: 0x00651334
		public static IChangeOtherState GetRootAsIChangeOtherState(ByteBuffer _bb, IChangeOtherState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E532 RID: 189746 RVA: 0x00653151 File Offset: 0x00651351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E533 RID: 189747 RVA: 0x00653160 File Offset: 0x00651360
		public IChangeOtherState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6DD RID: 50909
		// (get) Token: 0x0602E534 RID: 189748 RVA: 0x00653170 File Offset: 0x00651370
		public int EntityId
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

		// Token: 0x1700C6DE RID: 50910
		// (get) Token: 0x0602E535 RID: 189749 RVA: 0x006531AC File Offset: 0x006513AC
		public IPlayFlow? State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E536 RID: 189750 RVA: 0x00653209 File Offset: 0x00651409
		public static Offset<IChangeOtherState> CreateIChangeOtherState(FlatBufferBuilder builder, int EntityId = 0, Offset<IPlayFlow> StateOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IChangeOtherState.AddState(builder, StateOffset);
			IChangeOtherState.AddEntityId(builder, EntityId);
			return IChangeOtherState.EndIChangeOtherState(builder);
		}

		// Token: 0x0602E537 RID: 189751 RVA: 0x00653226 File Offset: 0x00651426
		public static void StartIChangeOtherState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E538 RID: 189752 RVA: 0x0065322F File Offset: 0x0065142F
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602E539 RID: 189753 RVA: 0x0065323A File Offset: 0x0065143A
		public static void AddState(FlatBufferBuilder builder, Offset<IPlayFlow> stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602E53A RID: 189754 RVA: 0x0065324A File Offset: 0x0065144A
		public static Offset<IChangeOtherState> EndIChangeOtherState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeOtherState>(builder.EndTable());
		}

		// Token: 0x0602E53B RID: 189755 RVA: 0x00653258 File Offset: 0x00651458
		public IChangeOtherStateT UnPack()
		{
			IChangeOtherStateT changeOtherStateT = new IChangeOtherStateT();
			this.UnPackTo(changeOtherStateT);
			return changeOtherStateT;
		}

		// Token: 0x0602E53C RID: 189756 RVA: 0x00653274 File Offset: 0x00651474
		public void UnPackTo(IChangeOtherStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = ((this.State != null) ? this.State.Value.UnPack() : null);
		}

		// Token: 0x0602E53D RID: 189757 RVA: 0x006532BC File Offset: 0x006514BC
		public static Offset<IChangeOtherState> Pack(FlatBufferBuilder builder, IChangeOtherStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeOtherState>);
			}
			Offset<IPlayFlow> stateOffset = (_o.State == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.State);
			return IChangeOtherState.CreateIChangeOtherState(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x040116E9 RID: 71401
		private Table __p;
	}
}

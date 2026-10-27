using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006311 RID: 25361
	public struct IChangeOtherState : IFlatbufferObject
	{
		// Token: 0x1700BD52 RID: 48466
		// (get) Token: 0x0602BDC5 RID: 179653 RVA: 0x006080F5 File Offset: 0x006062F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BDC6 RID: 179654 RVA: 0x00608102 File Offset: 0x00606302
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BDC7 RID: 179655 RVA: 0x0060810C File Offset: 0x0060630C
		public static IChangeOtherState GetRootAsIChangeOtherState(ByteBuffer _bb)
		{
			return IChangeOtherState.GetRootAsIChangeOtherState(_bb, default(IChangeOtherState));
		}

		// Token: 0x0602BDC8 RID: 179656 RVA: 0x00608128 File Offset: 0x00606328
		public static IChangeOtherState GetRootAsIChangeOtherState(ByteBuffer _bb, IChangeOtherState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BDC9 RID: 179657 RVA: 0x00608145 File Offset: 0x00606345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BDCA RID: 179658 RVA: 0x00608154 File Offset: 0x00606354
		public IChangeOtherState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD53 RID: 48467
		// (get) Token: 0x0602BDCB RID: 179659 RVA: 0x00608164 File Offset: 0x00606364
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

		// Token: 0x1700BD54 RID: 48468
		// (get) Token: 0x0602BDCC RID: 179660 RVA: 0x006081A0 File Offset: 0x006063A0
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

		// Token: 0x0602BDCD RID: 179661 RVA: 0x006081FD File Offset: 0x006063FD
		public static Offset<IChangeOtherState> CreateIChangeOtherState(FlatBufferBuilder builder, int EntityId = 0, Offset<IPlayFlow> StateOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IChangeOtherState.AddState(builder, StateOffset);
			IChangeOtherState.AddEntityId(builder, EntityId);
			return IChangeOtherState.EndIChangeOtherState(builder);
		}

		// Token: 0x0602BDCE RID: 179662 RVA: 0x0060821A File Offset: 0x0060641A
		public static void StartIChangeOtherState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BDCF RID: 179663 RVA: 0x00608223 File Offset: 0x00606423
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602BDD0 RID: 179664 RVA: 0x0060822E File Offset: 0x0060642E
		public static void AddState(FlatBufferBuilder builder, Offset<IPlayFlow> stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602BDD1 RID: 179665 RVA: 0x0060823E File Offset: 0x0060643E
		public static Offset<IChangeOtherState> EndIChangeOtherState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeOtherState>(builder.EndTable());
		}

		// Token: 0x0602BDD2 RID: 179666 RVA: 0x0060824C File Offset: 0x0060644C
		public IChangeOtherStateT UnPack()
		{
			IChangeOtherStateT changeOtherStateT = new IChangeOtherStateT();
			this.UnPackTo(changeOtherStateT);
			return changeOtherStateT;
		}

		// Token: 0x0602BDD3 RID: 179667 RVA: 0x00608268 File Offset: 0x00606468
		public void UnPackTo(IChangeOtherStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = ((this.State != null) ? this.State.Value.UnPack() : null);
		}

		// Token: 0x0602BDD4 RID: 179668 RVA: 0x006082B0 File Offset: 0x006064B0
		public static Offset<IChangeOtherState> Pack(FlatBufferBuilder builder, IChangeOtherStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeOtherState>);
			}
			Offset<IPlayFlow> stateOffset = (_o.State == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.State);
			return IChangeOtherState.CreateIChangeOtherState(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x040108D3 RID: 67795
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539B RID: 21403
	public struct IHitLogicChangeNextState : IFlatbufferObject
	{
		// Token: 0x17009D43 RID: 40259
		// (get) Token: 0x060230D2 RID: 143570 RVA: 0x004DA5E1 File Offset: 0x004D87E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230D3 RID: 143571 RVA: 0x004DA5EE File Offset: 0x004D87EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230D4 RID: 143572 RVA: 0x004DA5F8 File Offset: 0x004D87F8
		public static IHitLogicChangeNextState GetRootAsIHitLogicChangeNextState(ByteBuffer _bb)
		{
			return IHitLogicChangeNextState.GetRootAsIHitLogicChangeNextState(_bb, default(IHitLogicChangeNextState));
		}

		// Token: 0x060230D5 RID: 143573 RVA: 0x004DA614 File Offset: 0x004D8814
		public static IHitLogicChangeNextState GetRootAsIHitLogicChangeNextState(ByteBuffer _bb, IHitLogicChangeNextState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230D6 RID: 143574 RVA: 0x004DA631 File Offset: 0x004D8831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230D7 RID: 143575 RVA: 0x004DA640 File Offset: 0x004D8840
		public IHitLogicChangeNextState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D44 RID: 40260
		// (get) Token: 0x060230D8 RID: 143576 RVA: 0x004DA650 File Offset: 0x004D8850
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

		// Token: 0x060230D9 RID: 143577 RVA: 0x004DA68C File Offset: 0x004D888C
		public static Offset<IHitLogicChangeNextState> CreateIHitLogicChangeNextState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeNextState.AddType(builder, Type);
			return IHitLogicChangeNextState.EndIHitLogicChangeNextState(builder);
		}

		// Token: 0x060230DA RID: 143578 RVA: 0x004DA6A2 File Offset: 0x004D88A2
		public static void StartIHitLogicChangeNextState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060230DB RID: 143579 RVA: 0x004DA6AB File Offset: 0x004D88AB
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230DC RID: 143580 RVA: 0x004DA6B6 File Offset: 0x004D88B6
		public static Offset<IHitLogicChangeNextState> EndIHitLogicChangeNextState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeNextState>(builder.EndTable());
		}

		// Token: 0x060230DD RID: 143581 RVA: 0x004DA6C4 File Offset: 0x004D88C4
		public IHitLogicChangeNextStateT UnPack()
		{
			IHitLogicChangeNextStateT hitLogicChangeNextStateT = new IHitLogicChangeNextStateT();
			this.UnPackTo(hitLogicChangeNextStateT);
			return hitLogicChangeNextStateT;
		}

		// Token: 0x060230DE RID: 143582 RVA: 0x004DA6DF File Offset: 0x004D88DF
		public void UnPackTo(IHitLogicChangeNextStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060230DF RID: 143583 RVA: 0x004DA6F0 File Offset: 0x004D88F0
		public static Offset<IHitLogicChangeNextState> Pack(FlatBufferBuilder builder, IHitLogicChangeNextStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeNextState>);
			}
			return IHitLogicChangeNextState.CreateIHitLogicChangeNextState(builder, _o.Type);
		}

		// Token: 0x0400E585 RID: 58757
		private Table __p;
	}
}

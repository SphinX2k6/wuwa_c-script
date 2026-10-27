using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005395 RID: 21397
	public struct IHitLogicChangeLockState : IFlatbufferObject
	{
		// Token: 0x17009D3B RID: 40251
		// (get) Token: 0x060230A8 RID: 143528 RVA: 0x004DA235 File Offset: 0x004D8435
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230A9 RID: 143529 RVA: 0x004DA242 File Offset: 0x004D8442
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230AA RID: 143530 RVA: 0x004DA24C File Offset: 0x004D844C
		public static IHitLogicChangeLockState GetRootAsIHitLogicChangeLockState(ByteBuffer _bb)
		{
			return IHitLogicChangeLockState.GetRootAsIHitLogicChangeLockState(_bb, default(IHitLogicChangeLockState));
		}

		// Token: 0x060230AB RID: 143531 RVA: 0x004DA268 File Offset: 0x004D8468
		public static IHitLogicChangeLockState GetRootAsIHitLogicChangeLockState(ByteBuffer _bb, IHitLogicChangeLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230AC RID: 143532 RVA: 0x004DA285 File Offset: 0x004D8485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230AD RID: 143533 RVA: 0x004DA294 File Offset: 0x004D8494
		public IHitLogicChangeLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D3C RID: 40252
		// (get) Token: 0x060230AE RID: 143534 RVA: 0x004DA2A4 File Offset: 0x004D84A4
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

		// Token: 0x060230AF RID: 143535 RVA: 0x004DA2E0 File Offset: 0x004D84E0
		public static Offset<IHitLogicChangeLockState> CreateIHitLogicChangeLockState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeLockState.AddType(builder, Type);
			return IHitLogicChangeLockState.EndIHitLogicChangeLockState(builder);
		}

		// Token: 0x060230B0 RID: 143536 RVA: 0x004DA2F6 File Offset: 0x004D84F6
		public static void StartIHitLogicChangeLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060230B1 RID: 143537 RVA: 0x004DA2FF File Offset: 0x004D84FF
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230B2 RID: 143538 RVA: 0x004DA30A File Offset: 0x004D850A
		public static Offset<IHitLogicChangeLockState> EndIHitLogicChangeLockState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeLockState>(builder.EndTable());
		}

		// Token: 0x060230B3 RID: 143539 RVA: 0x004DA318 File Offset: 0x004D8518
		public IHitLogicChangeLockStateT UnPack()
		{
			IHitLogicChangeLockStateT hitLogicChangeLockStateT = new IHitLogicChangeLockStateT();
			this.UnPackTo(hitLogicChangeLockStateT);
			return hitLogicChangeLockStateT;
		}

		// Token: 0x060230B4 RID: 143540 RVA: 0x004DA333 File Offset: 0x004D8533
		public void UnPackTo(IHitLogicChangeLockStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060230B5 RID: 143541 RVA: 0x004DA344 File Offset: 0x004D8544
		public static Offset<IHitLogicChangeLockState> Pack(FlatBufferBuilder builder, IHitLogicChangeLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeLockState>);
			}
			return IHitLogicChangeLockState.CreateIHitLogicChangeLockState(builder, _o.Type);
		}

		// Token: 0x0400E580 RID: 58752
		private Table __p;
	}
}

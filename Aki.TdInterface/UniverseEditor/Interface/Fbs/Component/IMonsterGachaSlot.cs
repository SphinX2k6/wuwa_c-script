using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1C RID: 23324
	public struct IMonsterGachaSlot : IFlatbufferObject
	{
		// Token: 0x1700AA4B RID: 43595
		// (get) Token: 0x060265C0 RID: 157120 RVA: 0x00541502 File Offset: 0x0053F702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265C1 RID: 157121 RVA: 0x0054150F File Offset: 0x0053F70F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265C2 RID: 157122 RVA: 0x00541518 File Offset: 0x0053F718
		public static IMonsterGachaSlot GetRootAsIMonsterGachaSlot(ByteBuffer _bb)
		{
			return IMonsterGachaSlot.GetRootAsIMonsterGachaSlot(_bb, default(IMonsterGachaSlot));
		}

		// Token: 0x060265C3 RID: 157123 RVA: 0x00541534 File Offset: 0x0053F734
		public static IMonsterGachaSlot GetRootAsIMonsterGachaSlot(ByteBuffer _bb, IMonsterGachaSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265C4 RID: 157124 RVA: 0x00541551 File Offset: 0x0053F751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265C5 RID: 157125 RVA: 0x00541560 File Offset: 0x0053F760
		public IMonsterGachaSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA4C RID: 43596
		// (get) Token: 0x060265C6 RID: 157126 RVA: 0x00541570 File Offset: 0x0053F770
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060265C7 RID: 157127 RVA: 0x005415CD File Offset: 0x0053F7CD
		public static Offset<IMonsterGachaSlot> CreateIMonsterGachaSlot(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IMonsterGachaSlot.AddPos(builder, PosOffset);
			return IMonsterGachaSlot.EndIMonsterGachaSlot(builder);
		}

		// Token: 0x060265C8 RID: 157128 RVA: 0x005415E3 File Offset: 0x0053F7E3
		public static void StartIMonsterGachaSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060265C9 RID: 157129 RVA: 0x005415EC File Offset: 0x0053F7EC
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060265CA RID: 157130 RVA: 0x005415FC File Offset: 0x0053F7FC
		public static Offset<IMonsterGachaSlot> EndIMonsterGachaSlot(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaSlot>(builder.EndTable());
		}

		// Token: 0x060265CB RID: 157131 RVA: 0x0054160C File Offset: 0x0053F80C
		public IMonsterGachaSlotT UnPack()
		{
			IMonsterGachaSlotT monsterGachaSlotT = new IMonsterGachaSlotT();
			this.UnPackTo(monsterGachaSlotT);
			return monsterGachaSlotT;
		}

		// Token: 0x060265CC RID: 157132 RVA: 0x00541628 File Offset: 0x0053F828
		public void UnPackTo(IMonsterGachaSlotT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x060265CD RID: 157133 RVA: 0x00541664 File Offset: 0x0053F864
		public static Offset<IMonsterGachaSlot> Pack(FlatBufferBuilder builder, IMonsterGachaSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterGachaSlot>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IMonsterGachaSlot.CreateIMonsterGachaSlot(builder, posOffset);
		}

		// Token: 0x0400F510 RID: 62736
		private Table __p;
	}
}

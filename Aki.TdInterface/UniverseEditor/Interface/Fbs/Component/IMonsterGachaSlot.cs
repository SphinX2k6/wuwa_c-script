using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557E RID: 21886
	public struct IMonsterGachaSlot : IFlatbufferObject
	{
		// Token: 0x1700A1C3 RID: 41411
		// (get) Token: 0x060243B3 RID: 148403 RVA: 0x00500F8A File Offset: 0x004FF18A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243B4 RID: 148404 RVA: 0x00500F97 File Offset: 0x004FF197
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243B5 RID: 148405 RVA: 0x00500FA0 File Offset: 0x004FF1A0
		public static IMonsterGachaSlot GetRootAsIMonsterGachaSlot(ByteBuffer _bb)
		{
			return IMonsterGachaSlot.GetRootAsIMonsterGachaSlot(_bb, default(IMonsterGachaSlot));
		}

		// Token: 0x060243B6 RID: 148406 RVA: 0x00500FBC File Offset: 0x004FF1BC
		public static IMonsterGachaSlot GetRootAsIMonsterGachaSlot(ByteBuffer _bb, IMonsterGachaSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243B7 RID: 148407 RVA: 0x00500FD9 File Offset: 0x004FF1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243B8 RID: 148408 RVA: 0x00500FE8 File Offset: 0x004FF1E8
		public IMonsterGachaSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1C4 RID: 41412
		// (get) Token: 0x060243B9 RID: 148409 RVA: 0x00500FF8 File Offset: 0x004FF1F8
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

		// Token: 0x060243BA RID: 148410 RVA: 0x00501055 File Offset: 0x004FF255
		public static Offset<IMonsterGachaSlot> CreateIMonsterGachaSlot(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IMonsterGachaSlot.AddPos(builder, PosOffset);
			return IMonsterGachaSlot.EndIMonsterGachaSlot(builder);
		}

		// Token: 0x060243BB RID: 148411 RVA: 0x0050106B File Offset: 0x004FF26B
		public static void StartIMonsterGachaSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060243BC RID: 148412 RVA: 0x00501074 File Offset: 0x004FF274
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060243BD RID: 148413 RVA: 0x00501084 File Offset: 0x004FF284
		public static Offset<IMonsterGachaSlot> EndIMonsterGachaSlot(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaSlot>(builder.EndTable());
		}

		// Token: 0x060243BE RID: 148414 RVA: 0x00501094 File Offset: 0x004FF294
		public IMonsterGachaSlotT UnPack()
		{
			IMonsterGachaSlotT monsterGachaSlotT = new IMonsterGachaSlotT();
			this.UnPackTo(monsterGachaSlotT);
			return monsterGachaSlotT;
		}

		// Token: 0x060243BF RID: 148415 RVA: 0x005010B0 File Offset: 0x004FF2B0
		public void UnPackTo(IMonsterGachaSlotT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x060243C0 RID: 148416 RVA: 0x005010EC File Offset: 0x004FF2EC
		public static Offset<IMonsterGachaSlot> Pack(FlatBufferBuilder builder, IMonsterGachaSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterGachaSlot>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IMonsterGachaSlot.CreateIMonsterGachaSlot(builder, posOffset);
		}

		// Token: 0x0400E8AE RID: 59566
		private Table __p;
	}
}

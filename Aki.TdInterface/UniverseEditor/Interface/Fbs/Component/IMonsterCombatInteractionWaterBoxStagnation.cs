using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0A RID: 23306
	public struct IMonsterCombatInteractionWaterBoxStagnation : IFlatbufferObject
	{
		// Token: 0x1700AA10 RID: 43536
		// (get) Token: 0x060264B8 RID: 156856 RVA: 0x0053EFBE File Offset: 0x0053D1BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264B9 RID: 156857 RVA: 0x0053EFCB File Offset: 0x0053D1CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264BA RID: 156858 RVA: 0x0053EFD4 File Offset: 0x0053D1D4
		public static IMonsterCombatInteractionWaterBoxStagnation GetRootAsIMonsterCombatInteractionWaterBoxStagnation(ByteBuffer _bb)
		{
			return IMonsterCombatInteractionWaterBoxStagnation.GetRootAsIMonsterCombatInteractionWaterBoxStagnation(_bb, default(IMonsterCombatInteractionWaterBoxStagnation));
		}

		// Token: 0x060264BB RID: 156859 RVA: 0x0053EFF0 File Offset: 0x0053D1F0
		public static IMonsterCombatInteractionWaterBoxStagnation GetRootAsIMonsterCombatInteractionWaterBoxStagnation(ByteBuffer _bb, IMonsterCombatInteractionWaterBoxStagnation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264BC RID: 156860 RVA: 0x0053F00D File Offset: 0x0053D20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264BD RID: 156861 RVA: 0x0053F01C File Offset: 0x0053D21C
		public IMonsterCombatInteractionWaterBoxStagnation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA11 RID: 43537
		// (get) Token: 0x060264BE RID: 156862 RVA: 0x0053F02C File Offset: 0x0053D22C
		public EMonsterCombatInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterCombatInteractionType.WaterBoxStagnation;
				}
				return (EMonsterCombatInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060264BF RID: 156863 RVA: 0x0053F068 File Offset: 0x0053D268
		public static Offset<IMonsterCombatInteractionWaterBoxStagnation> CreateIMonsterCombatInteractionWaterBoxStagnation(FlatBufferBuilder builder, EMonsterCombatInteractionType Type = EMonsterCombatInteractionType.WaterBoxStagnation)
		{
			builder.StartTable(1);
			IMonsterCombatInteractionWaterBoxStagnation.AddType(builder, Type);
			return IMonsterCombatInteractionWaterBoxStagnation.EndIMonsterCombatInteractionWaterBoxStagnation(builder);
		}

		// Token: 0x060264C0 RID: 156864 RVA: 0x0053F07E File Offset: 0x0053D27E
		public static void StartIMonsterCombatInteractionWaterBoxStagnation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060264C1 RID: 156865 RVA: 0x0053F087 File Offset: 0x0053D287
		public static void AddType(FlatBufferBuilder builder, EMonsterCombatInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060264C2 RID: 156866 RVA: 0x0053F092 File Offset: 0x0053D292
		public static Offset<IMonsterCombatInteractionWaterBoxStagnation> EndIMonsterCombatInteractionWaterBoxStagnation(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCombatInteractionWaterBoxStagnation>(builder.EndTable());
		}

		// Token: 0x060264C3 RID: 156867 RVA: 0x0053F0A0 File Offset: 0x0053D2A0
		public IMonsterCombatInteractionWaterBoxStagnationT UnPack()
		{
			IMonsterCombatInteractionWaterBoxStagnationT monsterCombatInteractionWaterBoxStagnationT = new IMonsterCombatInteractionWaterBoxStagnationT();
			this.UnPackTo(monsterCombatInteractionWaterBoxStagnationT);
			return monsterCombatInteractionWaterBoxStagnationT;
		}

		// Token: 0x060264C4 RID: 156868 RVA: 0x0053F0BB File Offset: 0x0053D2BB
		public void UnPackTo(IMonsterCombatInteractionWaterBoxStagnationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060264C5 RID: 156869 RVA: 0x0053F0CC File Offset: 0x0053D2CC
		public static Offset<IMonsterCombatInteractionWaterBoxStagnation> Pack(FlatBufferBuilder builder, IMonsterCombatInteractionWaterBoxStagnationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCombatInteractionWaterBoxStagnation>);
			}
			return IMonsterCombatInteractionWaterBoxStagnation.CreateIMonsterCombatInteractionWaterBoxStagnation(builder, _o.Type);
		}

		// Token: 0x0400F4F0 RID: 62704
		private Table __p;
	}
}

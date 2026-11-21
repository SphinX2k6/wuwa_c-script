using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BE RID: 21438
	public struct IAllKillCondition : IFlatbufferObject
	{
		// Token: 0x170097A4 RID: 38820
		// (get) Token: 0x06021773 RID: 137075 RVA: 0x0049DBB6 File Offset: 0x0049BDB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021774 RID: 137076 RVA: 0x0049DBC3 File Offset: 0x0049BDC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021775 RID: 137077 RVA: 0x0049DBCC File Offset: 0x0049BDCC
		public static IAllKillCondition GetRootAsIAllKillCondition(ByteBuffer _bb)
		{
			return IAllKillCondition.GetRootAsIAllKillCondition(_bb, default(IAllKillCondition));
		}

		// Token: 0x06021776 RID: 137078 RVA: 0x0049DBE8 File Offset: 0x0049BDE8
		public static IAllKillCondition GetRootAsIAllKillCondition(ByteBuffer _bb, IAllKillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021777 RID: 137079 RVA: 0x0049DC05 File Offset: 0x0049BE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021778 RID: 137080 RVA: 0x0049DC14 File Offset: 0x0049BE14
		public IAllKillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097A5 RID: 38821
		// (get) Token: 0x06021779 RID: 137081 RVA: 0x0049DC24 File Offset: 0x0049BE24
		public ESpawnMonsterCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return (ESpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602177A RID: 137082 RVA: 0x0049DC60 File Offset: 0x0049BE60
		public static Offset<IAllKillCondition> CreateIAllKillCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill)
		{
			builder.StartTable(1);
			IAllKillCondition.AddType(builder, Type);
			return IAllKillCondition.EndIAllKillCondition(builder);
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x0049DC76 File Offset: 0x0049BE76
		public static void StartIAllKillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602177C RID: 137084 RVA: 0x0049DC7F File Offset: 0x0049BE7F
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602177D RID: 137085 RVA: 0x0049DC8A File Offset: 0x0049BE8A
		public static Offset<IAllKillCondition> EndIAllKillCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAllKillCondition>(builder.EndTable());
		}

		// Token: 0x0602177E RID: 137086 RVA: 0x0049DC98 File Offset: 0x0049BE98
		public IAllKillConditionT UnPack()
		{
			IAllKillConditionT allKillConditionT = new IAllKillConditionT();
			this.UnPackTo(allKillConditionT);
			return allKillConditionT;
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x0049DCB3 File Offset: 0x0049BEB3
		public void UnPackTo(IAllKillConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021780 RID: 137088 RVA: 0x0049DCC4 File Offset: 0x0049BEC4
		public static Offset<IAllKillCondition> Pack(FlatBufferBuilder builder, IAllKillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllKillCondition>);
			}
			return IAllKillCondition.CreateIAllKillCondition(builder, _o.Type);
		}

		// Token: 0x0400E80A RID: 59402
		private Table __p;
	}
}

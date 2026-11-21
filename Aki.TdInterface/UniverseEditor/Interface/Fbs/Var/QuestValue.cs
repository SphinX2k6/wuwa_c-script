using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F43 RID: 16195
	public struct QuestValue : IFlatbufferObject
	{
		// Token: 0x17006DAB RID: 28075
		// (get) Token: 0x06016061 RID: 90209 RVA: 0x00329C6D File Offset: 0x00327E6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016062 RID: 90210 RVA: 0x00329C7A File Offset: 0x00327E7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016063 RID: 90211 RVA: 0x00329C84 File Offset: 0x00327E84
		public static QuestValue GetRootAsQuestValue(ByteBuffer _bb)
		{
			return QuestValue.GetRootAsQuestValue(_bb, default(QuestValue));
		}

		// Token: 0x06016064 RID: 90212 RVA: 0x00329CA0 File Offset: 0x00327EA0
		public static QuestValue GetRootAsQuestValue(ByteBuffer _bb, QuestValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016065 RID: 90213 RVA: 0x00329CBD File Offset: 0x00327EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016066 RID: 90214 RVA: 0x00329CCC File Offset: 0x00327ECC
		public QuestValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DAC RID: 28076
		// (get) Token: 0x06016067 RID: 90215 RVA: 0x00329CDC File Offset: 0x00327EDC
		public int Value
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

		// Token: 0x06016068 RID: 90216 RVA: 0x00329D18 File Offset: 0x00327F18
		public static Offset<QuestValue> CreateQuestValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			QuestValue.AddValue(builder, value);
			return QuestValue.EndQuestValue(builder);
		}

		// Token: 0x06016069 RID: 90217 RVA: 0x00329D2E File Offset: 0x00327F2E
		public static void StartQuestValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601606A RID: 90218 RVA: 0x00329D37 File Offset: 0x00327F37
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x0601606B RID: 90219 RVA: 0x00329D42 File Offset: 0x00327F42
		public static Offset<QuestValue> EndQuestValue(FlatBufferBuilder builder)
		{
			return new Offset<QuestValue>(builder.EndTable());
		}

		// Token: 0x0601606C RID: 90220 RVA: 0x00329D50 File Offset: 0x00327F50
		public QuestValueT UnPack()
		{
			QuestValueT questValueT = new QuestValueT();
			this.UnPackTo(questValueT);
			return questValueT;
		}

		// Token: 0x0601606D RID: 90221 RVA: 0x00329D6B File Offset: 0x00327F6B
		public void UnPackTo(QuestValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x0601606E RID: 90222 RVA: 0x00329D7C File Offset: 0x00327F7C
		public static Offset<QuestValue> Pack(FlatBufferBuilder builder, QuestValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<QuestValue>);
			}
			return QuestValue.CreateQuestValue(builder, _o.Value);
		}

		// Token: 0x0400B990 RID: 47504
		private Table __p;
	}
}

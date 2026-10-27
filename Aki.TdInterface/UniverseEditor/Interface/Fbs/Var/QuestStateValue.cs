using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B3E RID: 15166
	public struct QuestStateValue : IFlatbufferObject
	{
		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x06014BA5 RID: 84901 RVA: 0x00303865 File Offset: 0x00301A65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014BA6 RID: 84902 RVA: 0x00303872 File Offset: 0x00301A72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014BA7 RID: 84903 RVA: 0x0030387C File Offset: 0x00301A7C
		public static QuestStateValue GetRootAsQuestStateValue(ByteBuffer _bb)
		{
			return QuestStateValue.GetRootAsQuestStateValue(_bb, default(QuestStateValue));
		}

		// Token: 0x06014BA8 RID: 84904 RVA: 0x00303898 File Offset: 0x00301A98
		public static QuestStateValue GetRootAsQuestStateValue(ByteBuffer _bb, QuestStateValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014BA9 RID: 84905 RVA: 0x003038B5 File Offset: 0x00301AB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014BAA RID: 84906 RVA: 0x003038C4 File Offset: 0x00301AC4
		public QuestStateValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x06014BAB RID: 84907 RVA: 0x003038D4 File Offset: 0x00301AD4
		public EQuestState Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestState.InActive;
				}
				return (EQuestState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014BAC RID: 84908 RVA: 0x00303910 File Offset: 0x00301B10
		public static Offset<QuestStateValue> CreateQuestStateValue(FlatBufferBuilder builder, EQuestState value = EQuestState.InActive)
		{
			builder.StartTable(1);
			QuestStateValue.AddValue(builder, value);
			return QuestStateValue.EndQuestStateValue(builder);
		}

		// Token: 0x06014BAD RID: 84909 RVA: 0x00303926 File Offset: 0x00301B26
		public static void StartQuestStateValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014BAE RID: 84910 RVA: 0x0030392F File Offset: 0x00301B2F
		public static void AddValue(FlatBufferBuilder builder, EQuestState value)
		{
			builder.AddByte(0, (byte)value, 0);
		}

		// Token: 0x06014BAF RID: 84911 RVA: 0x0030393A File Offset: 0x00301B3A
		public static Offset<QuestStateValue> EndQuestStateValue(FlatBufferBuilder builder)
		{
			return new Offset<QuestStateValue>(builder.EndTable());
		}

		// Token: 0x06014BB0 RID: 84912 RVA: 0x00303948 File Offset: 0x00301B48
		public QuestStateValueT UnPack()
		{
			QuestStateValueT questStateValueT = new QuestStateValueT();
			this.UnPackTo(questStateValueT);
			return questStateValueT;
		}

		// Token: 0x06014BB1 RID: 84913 RVA: 0x00303963 File Offset: 0x00301B63
		public void UnPackTo(QuestStateValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014BB2 RID: 84914 RVA: 0x00303974 File Offset: 0x00301B74
		public static Offset<QuestStateValue> Pack(FlatBufferBuilder builder, QuestStateValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<QuestStateValue>);
			}
			return QuestStateValue.CreateQuestStateValue(builder, _o.Value);
		}

		// Token: 0x0400B021 RID: 45089
		private Table __p;
	}
}

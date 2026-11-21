using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F40 RID: 16192
	public struct QuestStateValue : IFlatbufferObject
	{
		// Token: 0x17006DA8 RID: 28072
		// (get) Token: 0x0601604F RID: 90191 RVA: 0x00329AF5 File Offset: 0x00327CF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016050 RID: 90192 RVA: 0x00329B02 File Offset: 0x00327D02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016051 RID: 90193 RVA: 0x00329B0C File Offset: 0x00327D0C
		public static QuestStateValue GetRootAsQuestStateValue(ByteBuffer _bb)
		{
			return QuestStateValue.GetRootAsQuestStateValue(_bb, default(QuestStateValue));
		}

		// Token: 0x06016052 RID: 90194 RVA: 0x00329B28 File Offset: 0x00327D28
		public static QuestStateValue GetRootAsQuestStateValue(ByteBuffer _bb, QuestStateValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016053 RID: 90195 RVA: 0x00329B45 File Offset: 0x00327D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016054 RID: 90196 RVA: 0x00329B54 File Offset: 0x00327D54
		public QuestStateValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DA9 RID: 28073
		// (get) Token: 0x06016055 RID: 90197 RVA: 0x00329B64 File Offset: 0x00327D64
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

		// Token: 0x06016056 RID: 90198 RVA: 0x00329BA0 File Offset: 0x00327DA0
		public static Offset<QuestStateValue> CreateQuestStateValue(FlatBufferBuilder builder, EQuestState value = EQuestState.InActive)
		{
			builder.StartTable(1);
			QuestStateValue.AddValue(builder, value);
			return QuestStateValue.EndQuestStateValue(builder);
		}

		// Token: 0x06016057 RID: 90199 RVA: 0x00329BB6 File Offset: 0x00327DB6
		public static void StartQuestStateValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016058 RID: 90200 RVA: 0x00329BBF File Offset: 0x00327DBF
		public static void AddValue(FlatBufferBuilder builder, EQuestState value)
		{
			builder.AddByte(0, (byte)value, 0);
		}

		// Token: 0x06016059 RID: 90201 RVA: 0x00329BCA File Offset: 0x00327DCA
		public static Offset<QuestStateValue> EndQuestStateValue(FlatBufferBuilder builder)
		{
			return new Offset<QuestStateValue>(builder.EndTable());
		}

		// Token: 0x0601605A RID: 90202 RVA: 0x00329BD8 File Offset: 0x00327DD8
		public QuestStateValueT UnPack()
		{
			QuestStateValueT questStateValueT = new QuestStateValueT();
			this.UnPackTo(questStateValueT);
			return questStateValueT;
		}

		// Token: 0x0601605B RID: 90203 RVA: 0x00329BF3 File Offset: 0x00327DF3
		public void UnPackTo(QuestStateValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x0601605C RID: 90204 RVA: 0x00329C04 File Offset: 0x00327E04
		public static Offset<QuestStateValue> Pack(FlatBufferBuilder builder, QuestStateValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<QuestStateValue>);
			}
			return QuestStateValue.CreateQuestStateValue(builder, _o.Value);
		}

		// Token: 0x0400B98E RID: 47502
		private Table __p;
	}
}

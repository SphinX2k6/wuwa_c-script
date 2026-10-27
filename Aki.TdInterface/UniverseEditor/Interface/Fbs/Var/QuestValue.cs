using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B41 RID: 15169
	public struct QuestValue : IFlatbufferObject
	{
		// Token: 0x17006810 RID: 26640
		// (get) Token: 0x06014BB7 RID: 84919 RVA: 0x003039DD File Offset: 0x00301BDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014BB8 RID: 84920 RVA: 0x003039EA File Offset: 0x00301BEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014BB9 RID: 84921 RVA: 0x003039F4 File Offset: 0x00301BF4
		public static QuestValue GetRootAsQuestValue(ByteBuffer _bb)
		{
			return QuestValue.GetRootAsQuestValue(_bb, default(QuestValue));
		}

		// Token: 0x06014BBA RID: 84922 RVA: 0x00303A10 File Offset: 0x00301C10
		public static QuestValue GetRootAsQuestValue(ByteBuffer _bb, QuestValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014BBB RID: 84923 RVA: 0x00303A2D File Offset: 0x00301C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014BBC RID: 84924 RVA: 0x00303A3C File Offset: 0x00301C3C
		public QuestValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006811 RID: 26641
		// (get) Token: 0x06014BBD RID: 84925 RVA: 0x00303A4C File Offset: 0x00301C4C
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

		// Token: 0x06014BBE RID: 84926 RVA: 0x00303A88 File Offset: 0x00301C88
		public static Offset<QuestValue> CreateQuestValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			QuestValue.AddValue(builder, value);
			return QuestValue.EndQuestValue(builder);
		}

		// Token: 0x06014BBF RID: 84927 RVA: 0x00303A9E File Offset: 0x00301C9E
		public static void StartQuestValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014BC0 RID: 84928 RVA: 0x00303AA7 File Offset: 0x00301CA7
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06014BC1 RID: 84929 RVA: 0x00303AB2 File Offset: 0x00301CB2
		public static Offset<QuestValue> EndQuestValue(FlatBufferBuilder builder)
		{
			return new Offset<QuestValue>(builder.EndTable());
		}

		// Token: 0x06014BC2 RID: 84930 RVA: 0x00303AC0 File Offset: 0x00301CC0
		public QuestValueT UnPack()
		{
			QuestValueT questValueT = new QuestValueT();
			this.UnPackTo(questValueT);
			return questValueT;
		}

		// Token: 0x06014BC3 RID: 84931 RVA: 0x00303ADB File Offset: 0x00301CDB
		public void UnPackTo(QuestValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014BC4 RID: 84932 RVA: 0x00303AEC File Offset: 0x00301CEC
		public static Offset<QuestValue> Pack(FlatBufferBuilder builder, QuestValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<QuestValue>);
			}
			return QuestValue.CreateQuestValue(builder, _o.Value);
		}

		// Token: 0x0400B023 RID: 45091
		private Table __p;
	}
}

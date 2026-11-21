using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B06 RID: 31494
	public struct ITalkOptionFirstSelect : IFlatbufferObject
	{
		// Token: 0x1700EBF7 RID: 60407
		// (get) Token: 0x06038B5F RID: 232287 RVA: 0x007ABFBE File Offset: 0x007AA1BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B60 RID: 232288 RVA: 0x007ABFCB File Offset: 0x007AA1CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B61 RID: 232289 RVA: 0x007ABFD4 File Offset: 0x007AA1D4
		public static ITalkOptionFirstSelect GetRootAsITalkOptionFirstSelect(ByteBuffer _bb)
		{
			return ITalkOptionFirstSelect.GetRootAsITalkOptionFirstSelect(_bb, default(ITalkOptionFirstSelect));
		}

		// Token: 0x06038B62 RID: 232290 RVA: 0x007ABFF0 File Offset: 0x007AA1F0
		public static ITalkOptionFirstSelect GetRootAsITalkOptionFirstSelect(ByteBuffer _bb, ITalkOptionFirstSelect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B63 RID: 232291 RVA: 0x007AC00D File Offset: 0x007AA20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038B64 RID: 232292 RVA: 0x007AC01C File Offset: 0x007AA21C
		public ITalkOptionFirstSelect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBF8 RID: 60408
		// (get) Token: 0x06038B65 RID: 232293 RVA: 0x007AC02C File Offset: 0x007AA22C
		public ETalkOptionPreConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return (ETalkOptionPreConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038B66 RID: 232294 RVA: 0x007AC068 File Offset: 0x007AA268
		public static Offset<ITalkOptionFirstSelect> CreateITalkOptionFirstSelect(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption)
		{
			builder.StartTable(1);
			ITalkOptionFirstSelect.AddType(builder, Type);
			return ITalkOptionFirstSelect.EndITalkOptionFirstSelect(builder);
		}

		// Token: 0x06038B67 RID: 232295 RVA: 0x007AC07E File Offset: 0x007AA27E
		public static void StartITalkOptionFirstSelect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038B68 RID: 232296 RVA: 0x007AC087 File Offset: 0x007AA287
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038B69 RID: 232297 RVA: 0x007AC092 File Offset: 0x007AA292
		public static Offset<ITalkOptionFirstSelect> EndITalkOptionFirstSelect(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionFirstSelect>(builder.EndTable());
		}

		// Token: 0x06038B6A RID: 232298 RVA: 0x007AC0A0 File Offset: 0x007AA2A0
		public ITalkOptionFirstSelectT UnPack()
		{
			ITalkOptionFirstSelectT talkOptionFirstSelectT = new ITalkOptionFirstSelectT();
			this.UnPackTo(talkOptionFirstSelectT);
			return talkOptionFirstSelectT;
		}

		// Token: 0x06038B6B RID: 232299 RVA: 0x007AC0BB File Offset: 0x007AA2BB
		public void UnPackTo(ITalkOptionFirstSelectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038B6C RID: 232300 RVA: 0x007AC0CC File Offset: 0x007AA2CC
		public static Offset<ITalkOptionFirstSelect> Pack(FlatBufferBuilder builder, ITalkOptionFirstSelectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionFirstSelect>);
			}
			return ITalkOptionFirstSelect.CreateITalkOptionFirstSelect(builder, _o.Type);
		}

		// Token: 0x04013122 RID: 78114
		private Table __p;
	}
}

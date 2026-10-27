using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732E RID: 29486
	public struct ITalkOptionFirstSelect : IFlatbufferObject
	{
		// Token: 0x1700DFFB RID: 57339
		// (get) Token: 0x0603582C RID: 219180 RVA: 0x0074A436 File Offset: 0x00748636
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603582D RID: 219181 RVA: 0x0074A443 File Offset: 0x00748643
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603582E RID: 219182 RVA: 0x0074A44C File Offset: 0x0074864C
		public static ITalkOptionFirstSelect GetRootAsITalkOptionFirstSelect(ByteBuffer _bb)
		{
			return ITalkOptionFirstSelect.GetRootAsITalkOptionFirstSelect(_bb, default(ITalkOptionFirstSelect));
		}

		// Token: 0x0603582F RID: 219183 RVA: 0x0074A468 File Offset: 0x00748668
		public static ITalkOptionFirstSelect GetRootAsITalkOptionFirstSelect(ByteBuffer _bb, ITalkOptionFirstSelect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035830 RID: 219184 RVA: 0x0074A485 File Offset: 0x00748685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035831 RID: 219185 RVA: 0x0074A494 File Offset: 0x00748694
		public ITalkOptionFirstSelect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFFC RID: 57340
		// (get) Token: 0x06035832 RID: 219186 RVA: 0x0074A4A4 File Offset: 0x007486A4
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

		// Token: 0x06035833 RID: 219187 RVA: 0x0074A4E0 File Offset: 0x007486E0
		public static Offset<ITalkOptionFirstSelect> CreateITalkOptionFirstSelect(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption)
		{
			builder.StartTable(1);
			ITalkOptionFirstSelect.AddType(builder, Type);
			return ITalkOptionFirstSelect.EndITalkOptionFirstSelect(builder);
		}

		// Token: 0x06035834 RID: 219188 RVA: 0x0074A4F6 File Offset: 0x007486F6
		public static void StartITalkOptionFirstSelect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035835 RID: 219189 RVA: 0x0074A4FF File Offset: 0x007486FF
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035836 RID: 219190 RVA: 0x0074A50A File Offset: 0x0074870A
		public static Offset<ITalkOptionFirstSelect> EndITalkOptionFirstSelect(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionFirstSelect>(builder.EndTable());
		}

		// Token: 0x06035837 RID: 219191 RVA: 0x0074A518 File Offset: 0x00748718
		public ITalkOptionFirstSelectT UnPack()
		{
			ITalkOptionFirstSelectT talkOptionFirstSelectT = new ITalkOptionFirstSelectT();
			this.UnPackTo(talkOptionFirstSelectT);
			return talkOptionFirstSelectT;
		}

		// Token: 0x06035838 RID: 219192 RVA: 0x0074A533 File Offset: 0x00748733
		public void UnPackTo(ITalkOptionFirstSelectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035839 RID: 219193 RVA: 0x0074A544 File Offset: 0x00748744
		public static Offset<ITalkOptionFirstSelect> Pack(FlatBufferBuilder builder, ITalkOptionFirstSelectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionFirstSelect>);
			}
			return ITalkOptionFirstSelect.CreateITalkOptionFirstSelect(builder, _o.Type);
		}

		// Token: 0x0401211C RID: 74012
		private Table __p;
	}
}

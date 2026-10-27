using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733A RID: 29498
	public struct ITalkOptionPreConditionBase : IFlatbufferObject
	{
		// Token: 0x1700E00A RID: 57354
		// (get) Token: 0x06035882 RID: 219266 RVA: 0x0074AC48 File Offset: 0x00748E48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035883 RID: 219267 RVA: 0x0074AC55 File Offset: 0x00748E55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035884 RID: 219268 RVA: 0x0074AC5C File Offset: 0x00748E5C
		public static ITalkOptionPreConditionBase GetRootAsITalkOptionPreConditionBase(ByteBuffer _bb)
		{
			return ITalkOptionPreConditionBase.GetRootAsITalkOptionPreConditionBase(_bb, default(ITalkOptionPreConditionBase));
		}

		// Token: 0x06035885 RID: 219269 RVA: 0x0074AC78 File Offset: 0x00748E78
		public static ITalkOptionPreConditionBase GetRootAsITalkOptionPreConditionBase(ByteBuffer _bb, ITalkOptionPreConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035886 RID: 219270 RVA: 0x0074AC95 File Offset: 0x00748E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035887 RID: 219271 RVA: 0x0074ACA4 File Offset: 0x00748EA4
		public ITalkOptionPreConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E00B RID: 57355
		// (get) Token: 0x06035888 RID: 219272 RVA: 0x0074ACB4 File Offset: 0x00748EB4
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

		// Token: 0x06035889 RID: 219273 RVA: 0x0074ACF0 File Offset: 0x00748EF0
		public static Offset<ITalkOptionPreConditionBase> CreateITalkOptionPreConditionBase(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption)
		{
			builder.StartTable(1);
			ITalkOptionPreConditionBase.AddType(builder, Type);
			return ITalkOptionPreConditionBase.EndITalkOptionPreConditionBase(builder);
		}

		// Token: 0x0603588A RID: 219274 RVA: 0x0074AD06 File Offset: 0x00748F06
		public static void StartITalkOptionPreConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603588B RID: 219275 RVA: 0x0074AD0F File Offset: 0x00748F0F
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603588C RID: 219276 RVA: 0x0074AD1A File Offset: 0x00748F1A
		public static Offset<ITalkOptionPreConditionBase> EndITalkOptionPreConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPreConditionBase>(builder.EndTable());
		}

		// Token: 0x0603588D RID: 219277 RVA: 0x0074AD28 File Offset: 0x00748F28
		public ITalkOptionPreConditionBaseT UnPack()
		{
			ITalkOptionPreConditionBaseT talkOptionPreConditionBaseT = new ITalkOptionPreConditionBaseT();
			this.UnPackTo(talkOptionPreConditionBaseT);
			return talkOptionPreConditionBaseT;
		}

		// Token: 0x0603588E RID: 219278 RVA: 0x0074AD43 File Offset: 0x00748F43
		public void UnPackTo(ITalkOptionPreConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603588F RID: 219279 RVA: 0x0074AD54 File Offset: 0x00748F54
		public static Offset<ITalkOptionPreConditionBase> Pack(FlatBufferBuilder builder, ITalkOptionPreConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionPreConditionBase>);
			}
			return ITalkOptionPreConditionBase.CreateITalkOptionPreConditionBase(builder, _o.Type);
		}

		// Token: 0x04012130 RID: 74032
		private Table __p;
	}
}

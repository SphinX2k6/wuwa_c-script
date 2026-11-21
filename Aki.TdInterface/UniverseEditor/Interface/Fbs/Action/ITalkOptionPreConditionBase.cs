using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B12 RID: 31506
	public struct ITalkOptionPreConditionBase : IFlatbufferObject
	{
		// Token: 0x1700EC06 RID: 60422
		// (get) Token: 0x06038BB5 RID: 232373 RVA: 0x007AC7D0 File Offset: 0x007AA9D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038BB6 RID: 232374 RVA: 0x007AC7DD File Offset: 0x007AA9DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038BB7 RID: 232375 RVA: 0x007AC7E4 File Offset: 0x007AA9E4
		public static ITalkOptionPreConditionBase GetRootAsITalkOptionPreConditionBase(ByteBuffer _bb)
		{
			return ITalkOptionPreConditionBase.GetRootAsITalkOptionPreConditionBase(_bb, default(ITalkOptionPreConditionBase));
		}

		// Token: 0x06038BB8 RID: 232376 RVA: 0x007AC800 File Offset: 0x007AAA00
		public static ITalkOptionPreConditionBase GetRootAsITalkOptionPreConditionBase(ByteBuffer _bb, ITalkOptionPreConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038BB9 RID: 232377 RVA: 0x007AC81D File Offset: 0x007AAA1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038BBA RID: 232378 RVA: 0x007AC82C File Offset: 0x007AAA2C
		public ITalkOptionPreConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC07 RID: 60423
		// (get) Token: 0x06038BBB RID: 232379 RVA: 0x007AC83C File Offset: 0x007AAA3C
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

		// Token: 0x06038BBC RID: 232380 RVA: 0x007AC878 File Offset: 0x007AAA78
		public static Offset<ITalkOptionPreConditionBase> CreateITalkOptionPreConditionBase(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption)
		{
			builder.StartTable(1);
			ITalkOptionPreConditionBase.AddType(builder, Type);
			return ITalkOptionPreConditionBase.EndITalkOptionPreConditionBase(builder);
		}

		// Token: 0x06038BBD RID: 232381 RVA: 0x007AC88E File Offset: 0x007AAA8E
		public static void StartITalkOptionPreConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038BBE RID: 232382 RVA: 0x007AC897 File Offset: 0x007AAA97
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038BBF RID: 232383 RVA: 0x007AC8A2 File Offset: 0x007AAAA2
		public static Offset<ITalkOptionPreConditionBase> EndITalkOptionPreConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPreConditionBase>(builder.EndTable());
		}

		// Token: 0x06038BC0 RID: 232384 RVA: 0x007AC8B0 File Offset: 0x007AAAB0
		public ITalkOptionPreConditionBaseT UnPack()
		{
			ITalkOptionPreConditionBaseT talkOptionPreConditionBaseT = new ITalkOptionPreConditionBaseT();
			this.UnPackTo(talkOptionPreConditionBaseT);
			return talkOptionPreConditionBaseT;
		}

		// Token: 0x06038BC1 RID: 232385 RVA: 0x007AC8CB File Offset: 0x007AAACB
		public void UnPackTo(ITalkOptionPreConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038BC2 RID: 232386 RVA: 0x007AC8DC File Offset: 0x007AAADC
		public static Offset<ITalkOptionPreConditionBase> Pack(FlatBufferBuilder builder, ITalkOptionPreConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionPreConditionBase>);
			}
			return ITalkOptionPreConditionBase.CreateITalkOptionPreConditionBase(builder, _o.Type);
		}

		// Token: 0x04013136 RID: 78134
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC3 RID: 27843
	public struct IPhotographicTip : IFlatbufferObject
	{
		// Token: 0x1700CF48 RID: 53064
		// (get) Token: 0x06031117 RID: 200983 RVA: 0x006A8C74 File Offset: 0x006A6E74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031118 RID: 200984 RVA: 0x006A8C81 File Offset: 0x006A6E81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031119 RID: 200985 RVA: 0x006A8C88 File Offset: 0x006A6E88
		public static IPhotographicTip GetRootAsIPhotographicTip(ByteBuffer _bb)
		{
			return IPhotographicTip.GetRootAsIPhotographicTip(_bb, default(IPhotographicTip));
		}

		// Token: 0x0603111A RID: 200986 RVA: 0x006A8CA4 File Offset: 0x006A6EA4
		public static IPhotographicTip GetRootAsIPhotographicTip(ByteBuffer _bb, IPhotographicTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603111B RID: 200987 RVA: 0x006A8CC1 File Offset: 0x006A6EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603111C RID: 200988 RVA: 0x006A8CD0 File Offset: 0x006A6ED0
		public IPhotographicTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF49 RID: 53065
		// (get) Token: 0x0603111D RID: 200989 RVA: 0x006A8CE0 File Offset: 0x006A6EE0
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF4A RID: 53066
		// (get) Token: 0x0603111E RID: 200990 RVA: 0x006A8D1C File Offset: 0x006A6F1C
		public string MainText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603111F RID: 200991 RVA: 0x006A8D53 File Offset: 0x006A6F53
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031120 RID: 200992 RVA: 0x006A8D62 File Offset: 0x006A6F62
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031121 RID: 200993 RVA: 0x006A8D70 File Offset: 0x006A6F70
		public static Offset<IPhotographicTip> CreateIPhotographicTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPhotographicTip.AddMainText(builder, MainTextOffset);
			IPhotographicTip.AddType(builder, Type);
			return IPhotographicTip.EndIPhotographicTip(builder);
		}

		// Token: 0x06031122 RID: 200994 RVA: 0x006A8D8D File Offset: 0x006A6F8D
		public static void StartIPhotographicTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031123 RID: 200995 RVA: 0x006A8D96 File Offset: 0x006A6F96
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031124 RID: 200996 RVA: 0x006A8DA1 File Offset: 0x006A6FA1
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x06031125 RID: 200997 RVA: 0x006A8DB1 File Offset: 0x006A6FB1
		public static Offset<IPhotographicTip> EndIPhotographicTip(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographicTip>(builder.EndTable());
		}

		// Token: 0x06031126 RID: 200998 RVA: 0x006A8DC0 File Offset: 0x006A6FC0
		public IPhotographicTipT UnPack()
		{
			IPhotographicTipT photographicTipT = new IPhotographicTipT();
			this.UnPackTo(photographicTipT);
			return photographicTipT;
		}

		// Token: 0x06031127 RID: 200999 RVA: 0x006A8DDB File Offset: 0x006A6FDB
		public void UnPackTo(IPhotographicTipT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
		}

		// Token: 0x06031128 RID: 201000 RVA: 0x006A8DF8 File Offset: 0x006A6FF8
		public static Offset<IPhotographicTip> Pack(FlatBufferBuilder builder, IPhotographicTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographicTip>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			return IPhotographicTip.CreateIPhotographicTip(builder, _o.Type, mainTextOffset);
		}

		// Token: 0x04011627 RID: 71207
		private Table __p;
	}
}

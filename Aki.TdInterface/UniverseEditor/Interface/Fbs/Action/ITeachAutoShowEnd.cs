using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B45 RID: 31557
	public struct ITeachAutoShowEnd : IFlatbufferObject
	{
		// Token: 0x1700EC55 RID: 60501
		// (get) Token: 0x06038D49 RID: 232777 RVA: 0x007AF4DE File Offset: 0x007AD6DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038D4A RID: 232778 RVA: 0x007AF4EB File Offset: 0x007AD6EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038D4B RID: 232779 RVA: 0x007AF4F4 File Offset: 0x007AD6F4
		public static ITeachAutoShowEnd GetRootAsITeachAutoShowEnd(ByteBuffer _bb)
		{
			return ITeachAutoShowEnd.GetRootAsITeachAutoShowEnd(_bb, default(ITeachAutoShowEnd));
		}

		// Token: 0x06038D4C RID: 232780 RVA: 0x007AF510 File Offset: 0x007AD710
		public static ITeachAutoShowEnd GetRootAsITeachAutoShowEnd(ByteBuffer _bb, ITeachAutoShowEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038D4D RID: 232781 RVA: 0x007AF52D File Offset: 0x007AD72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038D4E RID: 232782 RVA: 0x007AF53C File Offset: 0x007AD73C
		public ITeachAutoShowEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC56 RID: 60502
		// (get) Token: 0x06038D4F RID: 232783 RVA: 0x007AF54C File Offset: 0x007AD74C
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

		// Token: 0x1700EC57 RID: 60503
		// (get) Token: 0x06038D50 RID: 232784 RVA: 0x007AF588 File Offset: 0x007AD788
		public string TidMainText
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

		// Token: 0x06038D51 RID: 232785 RVA: 0x007AF5BF File Offset: 0x007AD7BF
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06038D52 RID: 232786 RVA: 0x007AF5CE File Offset: 0x007AD7CE
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06038D53 RID: 232787 RVA: 0x007AF5DC File Offset: 0x007AD7DC
		public static Offset<ITeachAutoShowEnd> CreateITeachAutoShowEnd(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeachAutoShowEnd.AddTidMainText(builder, TidMainTextOffset);
			ITeachAutoShowEnd.AddType(builder, Type);
			return ITeachAutoShowEnd.EndITeachAutoShowEnd(builder);
		}

		// Token: 0x06038D54 RID: 232788 RVA: 0x007AF5F9 File Offset: 0x007AD7F9
		public static void StartITeachAutoShowEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038D55 RID: 232789 RVA: 0x007AF602 File Offset: 0x007AD802
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038D56 RID: 232790 RVA: 0x007AF60D File Offset: 0x007AD80D
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06038D57 RID: 232791 RVA: 0x007AF61D File Offset: 0x007AD81D
		public static Offset<ITeachAutoShowEnd> EndITeachAutoShowEnd(FlatBufferBuilder builder)
		{
			return new Offset<ITeachAutoShowEnd>(builder.EndTable());
		}

		// Token: 0x06038D58 RID: 232792 RVA: 0x007AF62C File Offset: 0x007AD82C
		public ITeachAutoShowEndT UnPack()
		{
			ITeachAutoShowEndT teachAutoShowEndT = new ITeachAutoShowEndT();
			this.UnPackTo(teachAutoShowEndT);
			return teachAutoShowEndT;
		}

		// Token: 0x06038D59 RID: 232793 RVA: 0x007AF647 File Offset: 0x007AD847
		public void UnPackTo(ITeachAutoShowEndT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x06038D5A RID: 232794 RVA: 0x007AF664 File Offset: 0x007AD864
		public static Offset<ITeachAutoShowEnd> Pack(FlatBufferBuilder builder, ITeachAutoShowEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeachAutoShowEnd>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ITeachAutoShowEnd.CreateITeachAutoShowEnd(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04013180 RID: 78208
		private Table __p;
	}
}

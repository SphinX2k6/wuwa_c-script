using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B48 RID: 31560
	public struct ITeachAutoShowStart : IFlatbufferObject
	{
		// Token: 0x1700EC5A RID: 60506
		// (get) Token: 0x06038D61 RID: 232801 RVA: 0x007AF711 File Offset: 0x007AD911
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038D62 RID: 232802 RVA: 0x007AF71E File Offset: 0x007AD91E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038D63 RID: 232803 RVA: 0x007AF728 File Offset: 0x007AD928
		public static ITeachAutoShowStart GetRootAsITeachAutoShowStart(ByteBuffer _bb)
		{
			return ITeachAutoShowStart.GetRootAsITeachAutoShowStart(_bb, default(ITeachAutoShowStart));
		}

		// Token: 0x06038D64 RID: 232804 RVA: 0x007AF744 File Offset: 0x007AD944
		public static ITeachAutoShowStart GetRootAsITeachAutoShowStart(ByteBuffer _bb, ITeachAutoShowStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038D65 RID: 232805 RVA: 0x007AF761 File Offset: 0x007AD961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038D66 RID: 232806 RVA: 0x007AF770 File Offset: 0x007AD970
		public ITeachAutoShowStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC5B RID: 60507
		// (get) Token: 0x06038D67 RID: 232807 RVA: 0x007AF780 File Offset: 0x007AD980
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

		// Token: 0x1700EC5C RID: 60508
		// (get) Token: 0x06038D68 RID: 232808 RVA: 0x007AF7BC File Offset: 0x007AD9BC
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

		// Token: 0x06038D69 RID: 232809 RVA: 0x007AF7F3 File Offset: 0x007AD9F3
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06038D6A RID: 232810 RVA: 0x007AF802 File Offset: 0x007ADA02
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06038D6B RID: 232811 RVA: 0x007AF810 File Offset: 0x007ADA10
		public static Offset<ITeachAutoShowStart> CreateITeachAutoShowStart(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeachAutoShowStart.AddTidMainText(builder, TidMainTextOffset);
			ITeachAutoShowStart.AddType(builder, Type);
			return ITeachAutoShowStart.EndITeachAutoShowStart(builder);
		}

		// Token: 0x06038D6C RID: 232812 RVA: 0x007AF82D File Offset: 0x007ADA2D
		public static void StartITeachAutoShowStart(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038D6D RID: 232813 RVA: 0x007AF836 File Offset: 0x007ADA36
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038D6E RID: 232814 RVA: 0x007AF841 File Offset: 0x007ADA41
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06038D6F RID: 232815 RVA: 0x007AF851 File Offset: 0x007ADA51
		public static Offset<ITeachAutoShowStart> EndITeachAutoShowStart(FlatBufferBuilder builder)
		{
			return new Offset<ITeachAutoShowStart>(builder.EndTable());
		}

		// Token: 0x06038D70 RID: 232816 RVA: 0x007AF860 File Offset: 0x007ADA60
		public ITeachAutoShowStartT UnPack()
		{
			ITeachAutoShowStartT teachAutoShowStartT = new ITeachAutoShowStartT();
			this.UnPackTo(teachAutoShowStartT);
			return teachAutoShowStartT;
		}

		// Token: 0x06038D71 RID: 232817 RVA: 0x007AF87B File Offset: 0x007ADA7B
		public void UnPackTo(ITeachAutoShowStartT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x06038D72 RID: 232818 RVA: 0x007AF898 File Offset: 0x007ADA98
		public static Offset<ITeachAutoShowStart> Pack(FlatBufferBuilder builder, ITeachAutoShowStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeachAutoShowStart>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ITeachAutoShowStart.CreateITeachAutoShowStart(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04013183 RID: 78211
		private Table __p;
	}
}

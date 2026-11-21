using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007439 RID: 29753
	public struct IPhotographicTip : IFlatbufferObject
	{
		// Token: 0x1700DA85 RID: 55941
		// (get) Token: 0x060340EE RID: 213230 RVA: 0x00703EA8 File Offset: 0x007020A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340EF RID: 213231 RVA: 0x00703EB5 File Offset: 0x007020B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340F0 RID: 213232 RVA: 0x00703EBC File Offset: 0x007020BC
		public static IPhotographicTip GetRootAsIPhotographicTip(ByteBuffer _bb)
		{
			return IPhotographicTip.GetRootAsIPhotographicTip(_bb, default(IPhotographicTip));
		}

		// Token: 0x060340F1 RID: 213233 RVA: 0x00703ED8 File Offset: 0x007020D8
		public static IPhotographicTip GetRootAsIPhotographicTip(ByteBuffer _bb, IPhotographicTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340F2 RID: 213234 RVA: 0x00703EF5 File Offset: 0x007020F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340F3 RID: 213235 RVA: 0x00703F04 File Offset: 0x00702104
		public IPhotographicTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA86 RID: 55942
		// (get) Token: 0x060340F4 RID: 213236 RVA: 0x00703F14 File Offset: 0x00702114
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

		// Token: 0x1700DA87 RID: 55943
		// (get) Token: 0x060340F5 RID: 213237 RVA: 0x00703F50 File Offset: 0x00702150
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

		// Token: 0x060340F6 RID: 213238 RVA: 0x00703F87 File Offset: 0x00702187
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060340F7 RID: 213239 RVA: 0x00703F96 File Offset: 0x00702196
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060340F8 RID: 213240 RVA: 0x00703FA4 File Offset: 0x007021A4
		public static Offset<IPhotographicTip> CreateIPhotographicTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPhotographicTip.AddMainText(builder, MainTextOffset);
			IPhotographicTip.AddType(builder, Type);
			return IPhotographicTip.EndIPhotographicTip(builder);
		}

		// Token: 0x060340F9 RID: 213241 RVA: 0x00703FC1 File Offset: 0x007021C1
		public static void StartIPhotographicTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060340FA RID: 213242 RVA: 0x00703FCA File Offset: 0x007021CA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340FB RID: 213243 RVA: 0x00703FD5 File Offset: 0x007021D5
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x060340FC RID: 213244 RVA: 0x00703FE5 File Offset: 0x007021E5
		public static Offset<IPhotographicTip> EndIPhotographicTip(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographicTip>(builder.EndTable());
		}

		// Token: 0x060340FD RID: 213245 RVA: 0x00703FF4 File Offset: 0x007021F4
		public IPhotographicTipT UnPack()
		{
			IPhotographicTipT photographicTipT = new IPhotographicTipT();
			this.UnPackTo(photographicTipT);
			return photographicTipT;
		}

		// Token: 0x060340FE RID: 213246 RVA: 0x0070400F File Offset: 0x0070220F
		public void UnPackTo(IPhotographicTipT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
		}

		// Token: 0x060340FF RID: 213247 RVA: 0x0070402C File Offset: 0x0070222C
		public static Offset<IPhotographicTip> Pack(FlatBufferBuilder builder, IPhotographicTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographicTip>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			return IPhotographicTip.CreateIPhotographicTip(builder, _o.Type, mainTextOffset);
		}

		// Token: 0x04012597 RID: 75159
		private Table __p;
	}
}

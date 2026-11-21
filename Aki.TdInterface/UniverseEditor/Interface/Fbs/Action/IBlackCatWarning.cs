using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006874 RID: 26740
	public struct IBlackCatWarning : IFlatbufferObject
	{
		// Token: 0x1700C491 RID: 50321
		// (get) Token: 0x0602DB66 RID: 187238 RVA: 0x006403EA File Offset: 0x0063E5EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB67 RID: 187239 RVA: 0x006403F7 File Offset: 0x0063E5F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB68 RID: 187240 RVA: 0x00640400 File Offset: 0x0063E600
		public static IBlackCatWarning GetRootAsIBlackCatWarning(ByteBuffer _bb)
		{
			return IBlackCatWarning.GetRootAsIBlackCatWarning(_bb, default(IBlackCatWarning));
		}

		// Token: 0x0602DB69 RID: 187241 RVA: 0x0064041C File Offset: 0x0063E61C
		public static IBlackCatWarning GetRootAsIBlackCatWarning(ByteBuffer _bb, IBlackCatWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB6A RID: 187242 RVA: 0x00640439 File Offset: 0x0063E639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB6B RID: 187243 RVA: 0x00640448 File Offset: 0x0063E648
		public IBlackCatWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C492 RID: 50322
		// (get) Token: 0x0602DB6C RID: 187244 RVA: 0x00640458 File Offset: 0x0063E658
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

		// Token: 0x1700C493 RID: 50323
		// (get) Token: 0x0602DB6D RID: 187245 RVA: 0x00640494 File Offset: 0x0063E694
		public string WarningText
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

		// Token: 0x0602DB6E RID: 187246 RVA: 0x006404CB File Offset: 0x0063E6CB
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DB6F RID: 187247 RVA: 0x006404DA File Offset: 0x0063E6DA
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602DB70 RID: 187248 RVA: 0x006404E8 File Offset: 0x0063E6E8
		public static Offset<IBlackCatWarning> CreateIBlackCatWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBlackCatWarning.AddWarningText(builder, WarningTextOffset);
			IBlackCatWarning.AddType(builder, Type);
			return IBlackCatWarning.EndIBlackCatWarning(builder);
		}

		// Token: 0x0602DB71 RID: 187249 RVA: 0x00640505 File Offset: 0x0063E705
		public static void StartIBlackCatWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DB72 RID: 187250 RVA: 0x0064050E File Offset: 0x0063E70E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB73 RID: 187251 RVA: 0x00640519 File Offset: 0x0063E719
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602DB74 RID: 187252 RVA: 0x00640529 File Offset: 0x0063E729
		public static Offset<IBlackCatWarning> EndIBlackCatWarning(FlatBufferBuilder builder)
		{
			return new Offset<IBlackCatWarning>(builder.EndTable());
		}

		// Token: 0x0602DB75 RID: 187253 RVA: 0x00640538 File Offset: 0x0063E738
		public IBlackCatWarningT UnPack()
		{
			IBlackCatWarningT blackCatWarningT = new IBlackCatWarningT();
			this.UnPackTo(blackCatWarningT);
			return blackCatWarningT;
		}

		// Token: 0x0602DB76 RID: 187254 RVA: 0x00640553 File Offset: 0x0063E753
		public void UnPackTo(IBlackCatWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602DB77 RID: 187255 RVA: 0x00640570 File Offset: 0x0063E770
		public static Offset<IBlackCatWarning> Pack(FlatBufferBuilder builder, IBlackCatWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackCatWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IBlackCatWarning.CreateIBlackCatWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04011551 RID: 70993
		private Table __p;
	}
}

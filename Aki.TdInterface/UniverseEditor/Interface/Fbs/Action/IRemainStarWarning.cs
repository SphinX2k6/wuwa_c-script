using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B5 RID: 30133
	public struct IRemainStarWarning : IFlatbufferObject
	{
		// Token: 0x1700DD8D RID: 56717
		// (get) Token: 0x06034DB2 RID: 216498 RVA: 0x0071AD05 File Offset: 0x00718F05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034DB3 RID: 216499 RVA: 0x0071AD12 File Offset: 0x00718F12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034DB4 RID: 216500 RVA: 0x0071AD1C File Offset: 0x00718F1C
		public static IRemainStarWarning GetRootAsIRemainStarWarning(ByteBuffer _bb)
		{
			return IRemainStarWarning.GetRootAsIRemainStarWarning(_bb, default(IRemainStarWarning));
		}

		// Token: 0x06034DB5 RID: 216501 RVA: 0x0071AD38 File Offset: 0x00718F38
		public static IRemainStarWarning GetRootAsIRemainStarWarning(ByteBuffer _bb, IRemainStarWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034DB6 RID: 216502 RVA: 0x0071AD55 File Offset: 0x00718F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034DB7 RID: 216503 RVA: 0x0071AD64 File Offset: 0x00718F64
		public IRemainStarWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD8E RID: 56718
		// (get) Token: 0x06034DB8 RID: 216504 RVA: 0x0071AD74 File Offset: 0x00718F74
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

		// Token: 0x1700DD8F RID: 56719
		// (get) Token: 0x06034DB9 RID: 216505 RVA: 0x0071ADB0 File Offset: 0x00718FB0
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

		// Token: 0x06034DBA RID: 216506 RVA: 0x0071ADE7 File Offset: 0x00718FE7
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034DBB RID: 216507 RVA: 0x0071ADF6 File Offset: 0x00718FF6
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06034DBC RID: 216508 RVA: 0x0071AE04 File Offset: 0x00719004
		public static Offset<IRemainStarWarning> CreateIRemainStarWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemainStarWarning.AddWarningText(builder, WarningTextOffset);
			IRemainStarWarning.AddType(builder, Type);
			return IRemainStarWarning.EndIRemainStarWarning(builder);
		}

		// Token: 0x06034DBD RID: 216509 RVA: 0x0071AE21 File Offset: 0x00719021
		public static void StartIRemainStarWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034DBE RID: 216510 RVA: 0x0071AE2A File Offset: 0x0071902A
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034DBF RID: 216511 RVA: 0x0071AE35 File Offset: 0x00719035
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x06034DC0 RID: 216512 RVA: 0x0071AE45 File Offset: 0x00719045
		public static Offset<IRemainStarWarning> EndIRemainStarWarning(FlatBufferBuilder builder)
		{
			return new Offset<IRemainStarWarning>(builder.EndTable());
		}

		// Token: 0x06034DC1 RID: 216513 RVA: 0x0071AE54 File Offset: 0x00719054
		public IRemainStarWarningT UnPack()
		{
			IRemainStarWarningT remainStarWarningT = new IRemainStarWarningT();
			this.UnPackTo(remainStarWarningT);
			return remainStarWarningT;
		}

		// Token: 0x06034DC2 RID: 216514 RVA: 0x0071AE6F File Offset: 0x0071906F
		public void UnPackTo(IRemainStarWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x06034DC3 RID: 216515 RVA: 0x0071AE8C File Offset: 0x0071908C
		public static Offset<IRemainStarWarning> Pack(FlatBufferBuilder builder, IRemainStarWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainStarWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IRemainStarWarning.CreateIRemainStarWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x0401279B RID: 75675
		private Table __p;
	}
}

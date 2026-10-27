using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007139 RID: 28985
	public struct ISlashAndTowerTip : IFlatbufferObject
	{
		// Token: 0x1700D761 RID: 55137
		// (get) Token: 0x06033622 RID: 210466 RVA: 0x006ECD3E File Offset: 0x006EAF3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033623 RID: 210467 RVA: 0x006ECD4B File Offset: 0x006EAF4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033624 RID: 210468 RVA: 0x006ECD54 File Offset: 0x006EAF54
		public static ISlashAndTowerTip GetRootAsISlashAndTowerTip(ByteBuffer _bb)
		{
			return ISlashAndTowerTip.GetRootAsISlashAndTowerTip(_bb, default(ISlashAndTowerTip));
		}

		// Token: 0x06033625 RID: 210469 RVA: 0x006ECD70 File Offset: 0x006EAF70
		public static ISlashAndTowerTip GetRootAsISlashAndTowerTip(ByteBuffer _bb, ISlashAndTowerTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033626 RID: 210470 RVA: 0x006ECD8D File Offset: 0x006EAF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033627 RID: 210471 RVA: 0x006ECD9C File Offset: 0x006EAF9C
		public ISlashAndTowerTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D762 RID: 55138
		// (get) Token: 0x06033628 RID: 210472 RVA: 0x006ECDAC File Offset: 0x006EAFAC
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

		// Token: 0x1700D763 RID: 55139
		// (get) Token: 0x06033629 RID: 210473 RVA: 0x006ECDE8 File Offset: 0x006EAFE8
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

		// Token: 0x0603362A RID: 210474 RVA: 0x006ECE1F File Offset: 0x006EB01F
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603362B RID: 210475 RVA: 0x006ECE2E File Offset: 0x006EB02E
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603362C RID: 210476 RVA: 0x006ECE3C File Offset: 0x006EB03C
		public static Offset<ISlashAndTowerTip> CreateISlashAndTowerTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlashAndTowerTip.AddWarningText(builder, WarningTextOffset);
			ISlashAndTowerTip.AddType(builder, Type);
			return ISlashAndTowerTip.EndISlashAndTowerTip(builder);
		}

		// Token: 0x0603362D RID: 210477 RVA: 0x006ECE59 File Offset: 0x006EB059
		public static void StartISlashAndTowerTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603362E RID: 210478 RVA: 0x006ECE62 File Offset: 0x006EB062
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603362F RID: 210479 RVA: 0x006ECE6D File Offset: 0x006EB06D
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x06033630 RID: 210480 RVA: 0x006ECE7D File Offset: 0x006EB07D
		public static Offset<ISlashAndTowerTip> EndISlashAndTowerTip(FlatBufferBuilder builder)
		{
			return new Offset<ISlashAndTowerTip>(builder.EndTable());
		}

		// Token: 0x06033631 RID: 210481 RVA: 0x006ECE8C File Offset: 0x006EB08C
		public ISlashAndTowerTipT UnPack()
		{
			ISlashAndTowerTipT slashAndTowerTipT = new ISlashAndTowerTipT();
			this.UnPackTo(slashAndTowerTipT);
			return slashAndTowerTipT;
		}

		// Token: 0x06033632 RID: 210482 RVA: 0x006ECEA7 File Offset: 0x006EB0A7
		public void UnPackTo(ISlashAndTowerTipT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x06033633 RID: 210483 RVA: 0x006ECEC4 File Offset: 0x006EB0C4
		public static Offset<ISlashAndTowerTip> Pack(FlatBufferBuilder builder, ISlashAndTowerTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashAndTowerTip>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return ISlashAndTowerTip.CreateISlashAndTowerTip(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04011BD4 RID: 72660
		private Table __p;
	}
}

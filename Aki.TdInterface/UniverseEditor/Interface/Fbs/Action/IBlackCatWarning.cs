using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006203 RID: 25091
	public struct IBlackCatWarning : IFlatbufferObject
	{
		// Token: 0x1700BB0B RID: 47883
		// (get) Token: 0x0602B40D RID: 177165 RVA: 0x005F57FE File Offset: 0x005F39FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B40E RID: 177166 RVA: 0x005F580B File Offset: 0x005F3A0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B40F RID: 177167 RVA: 0x005F5814 File Offset: 0x005F3A14
		public static IBlackCatWarning GetRootAsIBlackCatWarning(ByteBuffer _bb)
		{
			return IBlackCatWarning.GetRootAsIBlackCatWarning(_bb, default(IBlackCatWarning));
		}

		// Token: 0x0602B410 RID: 177168 RVA: 0x005F5830 File Offset: 0x005F3A30
		public static IBlackCatWarning GetRootAsIBlackCatWarning(ByteBuffer _bb, IBlackCatWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B411 RID: 177169 RVA: 0x005F584D File Offset: 0x005F3A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B412 RID: 177170 RVA: 0x005F585C File Offset: 0x005F3A5C
		public IBlackCatWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB0C RID: 47884
		// (get) Token: 0x0602B413 RID: 177171 RVA: 0x005F586C File Offset: 0x005F3A6C
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

		// Token: 0x1700BB0D RID: 47885
		// (get) Token: 0x0602B414 RID: 177172 RVA: 0x005F58A8 File Offset: 0x005F3AA8
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

		// Token: 0x0602B415 RID: 177173 RVA: 0x005F58DF File Offset: 0x005F3ADF
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B416 RID: 177174 RVA: 0x005F58EE File Offset: 0x005F3AEE
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B417 RID: 177175 RVA: 0x005F58FC File Offset: 0x005F3AFC
		public static Offset<IBlackCatWarning> CreateIBlackCatWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBlackCatWarning.AddWarningText(builder, WarningTextOffset);
			IBlackCatWarning.AddType(builder, Type);
			return IBlackCatWarning.EndIBlackCatWarning(builder);
		}

		// Token: 0x0602B418 RID: 177176 RVA: 0x005F5919 File Offset: 0x005F3B19
		public static void StartIBlackCatWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B419 RID: 177177 RVA: 0x005F5922 File Offset: 0x005F3B22
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B41A RID: 177178 RVA: 0x005F592D File Offset: 0x005F3B2D
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602B41B RID: 177179 RVA: 0x005F593D File Offset: 0x005F3B3D
		public static Offset<IBlackCatWarning> EndIBlackCatWarning(FlatBufferBuilder builder)
		{
			return new Offset<IBlackCatWarning>(builder.EndTable());
		}

		// Token: 0x0602B41C RID: 177180 RVA: 0x005F594C File Offset: 0x005F3B4C
		public IBlackCatWarningT UnPack()
		{
			IBlackCatWarningT blackCatWarningT = new IBlackCatWarningT();
			this.UnPackTo(blackCatWarningT);
			return blackCatWarningT;
		}

		// Token: 0x0602B41D RID: 177181 RVA: 0x005F5967 File Offset: 0x005F3B67
		public void UnPackTo(IBlackCatWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602B41E RID: 177182 RVA: 0x005F5984 File Offset: 0x005F3B84
		public static Offset<IBlackCatWarning> Pack(FlatBufferBuilder builder, IBlackCatWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackCatWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IBlackCatWarning.CreateIBlackCatWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x0401073D RID: 67389
		private Table __p;
	}
}

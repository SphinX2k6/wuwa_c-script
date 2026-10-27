using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200649B RID: 25755
	public struct ICommonTipGeneralFloatingTip : IFlatbufferObject
	{
		// Token: 0x1700BFA8 RID: 49064
		// (get) Token: 0x0602CA2E RID: 182830 RVA: 0x00620E51 File Offset: 0x0061F051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA2F RID: 182831 RVA: 0x00620E5E File Offset: 0x0061F05E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA30 RID: 182832 RVA: 0x00620E68 File Offset: 0x0061F068
		public static ICommonTipGeneralFloatingTip GetRootAsICommonTipGeneralFloatingTip(ByteBuffer _bb)
		{
			return ICommonTipGeneralFloatingTip.GetRootAsICommonTipGeneralFloatingTip(_bb, default(ICommonTipGeneralFloatingTip));
		}

		// Token: 0x0602CA31 RID: 182833 RVA: 0x00620E84 File Offset: 0x0061F084
		public static ICommonTipGeneralFloatingTip GetRootAsICommonTipGeneralFloatingTip(ByteBuffer _bb, ICommonTipGeneralFloatingTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA32 RID: 182834 RVA: 0x00620EA1 File Offset: 0x0061F0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA33 RID: 182835 RVA: 0x00620EB0 File Offset: 0x0061F0B0
		public ICommonTipGeneralFloatingTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFA9 RID: 49065
		// (get) Token: 0x0602CA34 RID: 182836 RVA: 0x00620EC0 File Offset: 0x0061F0C0
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

		// Token: 0x1700BFAA RID: 49066
		// (get) Token: 0x0602CA35 RID: 182837 RVA: 0x00620EFC File Offset: 0x0061F0FC
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

		// Token: 0x0602CA36 RID: 182838 RVA: 0x00620F33 File Offset: 0x0061F133
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CA37 RID: 182839 RVA: 0x00620F42 File Offset: 0x0061F142
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CA38 RID: 182840 RVA: 0x00620F50 File Offset: 0x0061F150
		public static Offset<ICommonTipGeneralFloatingTip> CreateICommonTipGeneralFloatingTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipGeneralFloatingTip.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipGeneralFloatingTip.AddType(builder, Type);
			return ICommonTipGeneralFloatingTip.EndICommonTipGeneralFloatingTip(builder);
		}

		// Token: 0x0602CA39 RID: 182841 RVA: 0x00620F6D File Offset: 0x0061F16D
		public static void StartICommonTipGeneralFloatingTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CA3A RID: 182842 RVA: 0x00620F76 File Offset: 0x0061F176
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA3B RID: 182843 RVA: 0x00620F81 File Offset: 0x0061F181
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602CA3C RID: 182844 RVA: 0x00620F91 File Offset: 0x0061F191
		public static Offset<ICommonTipGeneralFloatingTip> EndICommonTipGeneralFloatingTip(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipGeneralFloatingTip>(builder.EndTable());
		}

		// Token: 0x0602CA3D RID: 182845 RVA: 0x00620FA0 File Offset: 0x0061F1A0
		public ICommonTipGeneralFloatingTipT UnPack()
		{
			ICommonTipGeneralFloatingTipT commonTipGeneralFloatingTipT = new ICommonTipGeneralFloatingTipT();
			this.UnPackTo(commonTipGeneralFloatingTipT);
			return commonTipGeneralFloatingTipT;
		}

		// Token: 0x0602CA3E RID: 182846 RVA: 0x00620FBB File Offset: 0x0061F1BB
		public void UnPackTo(ICommonTipGeneralFloatingTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x0602CA3F RID: 182847 RVA: 0x00620FD8 File Offset: 0x0061F1D8
		public static Offset<ICommonTipGeneralFloatingTip> Pack(FlatBufferBuilder builder, ICommonTipGeneralFloatingTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipGeneralFloatingTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return ICommonTipGeneralFloatingTip.CreateICommonTipGeneralFloatingTip(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04010AA8 RID: 68264
		private Table __p;
	}
}

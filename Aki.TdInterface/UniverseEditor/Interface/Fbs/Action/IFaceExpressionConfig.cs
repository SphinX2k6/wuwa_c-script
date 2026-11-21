using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC7 RID: 28103
	public struct IFaceExpressionConfig : IFlatbufferObject
	{
		// Token: 0x1700CDFE RID: 52734
		// (get) Token: 0x0603080B RID: 198667 RVA: 0x00696589 File Offset: 0x00694789
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603080C RID: 198668 RVA: 0x00696596 File Offset: 0x00694796
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603080D RID: 198669 RVA: 0x006965A0 File Offset: 0x006947A0
		public static IFaceExpressionConfig GetRootAsIFaceExpressionConfig(ByteBuffer _bb)
		{
			return IFaceExpressionConfig.GetRootAsIFaceExpressionConfig(_bb, default(IFaceExpressionConfig));
		}

		// Token: 0x0603080E RID: 198670 RVA: 0x006965BC File Offset: 0x006947BC
		public static IFaceExpressionConfig GetRootAsIFaceExpressionConfig(ByteBuffer _bb, IFaceExpressionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603080F RID: 198671 RVA: 0x006965D9 File Offset: 0x006947D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030810 RID: 198672 RVA: 0x006965E8 File Offset: 0x006947E8
		public IFaceExpressionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDFF RID: 52735
		// (get) Token: 0x06030811 RID: 198673 RVA: 0x006965F8 File Offset: 0x006947F8
		public EFaceExpressionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return (EFaceExpressionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030812 RID: 198674 RVA: 0x00696634 File Offset: 0x00694834
		public static Offset<IFaceExpressionConfig> CreateIFaceExpressionConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph)
		{
			builder.StartTable(1);
			IFaceExpressionConfig.AddType(builder, Type);
			return IFaceExpressionConfig.EndIFaceExpressionConfig(builder);
		}

		// Token: 0x06030813 RID: 198675 RVA: 0x0069664A File Offset: 0x0069484A
		public static void StartIFaceExpressionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030814 RID: 198676 RVA: 0x00696653 File Offset: 0x00694853
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030815 RID: 198677 RVA: 0x0069665E File Offset: 0x0069485E
		public static Offset<IFaceExpressionConfig> EndIFaceExpressionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionConfig>(builder.EndTable());
		}

		// Token: 0x06030816 RID: 198678 RVA: 0x0069666C File Offset: 0x0069486C
		public IFaceExpressionConfigT UnPack()
		{
			IFaceExpressionConfigT faceExpressionConfigT = new IFaceExpressionConfigT();
			this.UnPackTo(faceExpressionConfigT);
			return faceExpressionConfigT;
		}

		// Token: 0x06030817 RID: 198679 RVA: 0x00696687 File Offset: 0x00694887
		public void UnPackTo(IFaceExpressionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030818 RID: 198680 RVA: 0x00696698 File Offset: 0x00694898
		public static Offset<IFaceExpressionConfig> Pack(FlatBufferBuilder builder, IFaceExpressionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionConfig>);
			}
			return IFaceExpressionConfig.CreateIFaceExpressionConfig(builder, _o.Type);
		}

		// Token: 0x04011C63 RID: 72803
		private Table __p;
	}
}

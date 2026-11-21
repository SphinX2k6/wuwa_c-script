using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA7 RID: 19111
	public struct ICustomTextGm : IFlatbufferObject
	{
		// Token: 0x170085DA RID: 34266
		// (get) Token: 0x0601CB9E RID: 117662 RVA: 0x0040C911 File Offset: 0x0040AB11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB9F RID: 117663 RVA: 0x0040C91E File Offset: 0x0040AB1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBA0 RID: 117664 RVA: 0x0040C928 File Offset: 0x0040AB28
		public static ICustomTextGm GetRootAsICustomTextGm(ByteBuffer _bb)
		{
			return ICustomTextGm.GetRootAsICustomTextGm(_bb, default(ICustomTextGm));
		}

		// Token: 0x0601CBA1 RID: 117665 RVA: 0x0040C944 File Offset: 0x0040AB44
		public static ICustomTextGm GetRootAsICustomTextGm(ByteBuffer _bb, ICustomTextGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBA2 RID: 117666 RVA: 0x0040C961 File Offset: 0x0040AB61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBA3 RID: 117667 RVA: 0x0040C970 File Offset: 0x0040AB70
		public ICustomTextGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085DB RID: 34267
		// (get) Token: 0x0601CBA4 RID: 117668 RVA: 0x0040C980 File Offset: 0x0040AB80
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085DC RID: 34268
		// (get) Token: 0x0601CBA5 RID: 117669 RVA: 0x0040C9BC File Offset: 0x0040ABBC
		public string Text
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

		// Token: 0x0601CBA6 RID: 117670 RVA: 0x0040C9F3 File Offset: 0x0040ABF3
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CBA7 RID: 117671 RVA: 0x0040CA02 File Offset: 0x0040AC02
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601CBA8 RID: 117672 RVA: 0x0040CA10 File Offset: 0x0040AC10
		public static Offset<ICustomTextGm> CreateICustomTextGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset TextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomTextGm.AddText(builder, TextOffset);
			ICustomTextGm.AddType(builder, Type);
			return ICustomTextGm.EndICustomTextGm(builder);
		}

		// Token: 0x0601CBA9 RID: 117673 RVA: 0x0040CA2D File Offset: 0x0040AC2D
		public static void StartICustomTextGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CBAA RID: 117674 RVA: 0x0040CA36 File Offset: 0x0040AC36
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CBAB RID: 117675 RVA: 0x0040CA41 File Offset: 0x0040AC41
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(1, textOffset.Value, 0);
		}

		// Token: 0x0601CBAC RID: 117676 RVA: 0x0040CA51 File Offset: 0x0040AC51
		public static Offset<ICustomTextGm> EndICustomTextGm(FlatBufferBuilder builder)
		{
			return new Offset<ICustomTextGm>(builder.EndTable());
		}

		// Token: 0x0601CBAD RID: 117677 RVA: 0x0040CA60 File Offset: 0x0040AC60
		public ICustomTextGmT UnPack()
		{
			ICustomTextGmT customTextGmT = new ICustomTextGmT();
			this.UnPackTo(customTextGmT);
			return customTextGmT;
		}

		// Token: 0x0601CBAE RID: 117678 RVA: 0x0040CA7B File Offset: 0x0040AC7B
		public void UnPackTo(ICustomTextGmT _o)
		{
			_o.Type = this.Type;
			_o.Text = this.Text;
		}

		// Token: 0x0601CBAF RID: 117679 RVA: 0x0040CA98 File Offset: 0x0040AC98
		public static Offset<ICustomTextGm> Pack(FlatBufferBuilder builder, ICustomTextGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomTextGm>);
			}
			StringOffset textOffset = (_o.Text == null) ? default(StringOffset) : builder.CreateString(_o.Text);
			return ICustomTextGm.CreateICustomTextGm(builder, _o.Type, textOffset);
		}

		// Token: 0x0400D1E4 RID: 53732
		private Table __p;
	}
}

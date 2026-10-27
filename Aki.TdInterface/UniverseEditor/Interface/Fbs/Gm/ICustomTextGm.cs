using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200463F RID: 17983
	public struct ICustomTextGm : IFlatbufferObject
	{
		// Token: 0x17007F99 RID: 32665
		// (get) Token: 0x0601B3C9 RID: 111561 RVA: 0x003E0675 File Offset: 0x003DE875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3CA RID: 111562 RVA: 0x003E0682 File Offset: 0x003DE882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3CB RID: 111563 RVA: 0x003E068C File Offset: 0x003DE88C
		public static ICustomTextGm GetRootAsICustomTextGm(ByteBuffer _bb)
		{
			return ICustomTextGm.GetRootAsICustomTextGm(_bb, default(ICustomTextGm));
		}

		// Token: 0x0601B3CC RID: 111564 RVA: 0x003E06A8 File Offset: 0x003DE8A8
		public static ICustomTextGm GetRootAsICustomTextGm(ByteBuffer _bb, ICustomTextGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3CD RID: 111565 RVA: 0x003E06C5 File Offset: 0x003DE8C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3CE RID: 111566 RVA: 0x003E06D4 File Offset: 0x003DE8D4
		public ICustomTextGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F9A RID: 32666
		// (get) Token: 0x0601B3CF RID: 111567 RVA: 0x003E06E4 File Offset: 0x003DE8E4
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

		// Token: 0x17007F9B RID: 32667
		// (get) Token: 0x0601B3D0 RID: 111568 RVA: 0x003E0720 File Offset: 0x003DE920
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

		// Token: 0x0601B3D1 RID: 111569 RVA: 0x003E0757 File Offset: 0x003DE957
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x003E0766 File Offset: 0x003DE966
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x003E0774 File Offset: 0x003DE974
		public static Offset<ICustomTextGm> CreateICustomTextGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset TextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomTextGm.AddText(builder, TextOffset);
			ICustomTextGm.AddType(builder, Type);
			return ICustomTextGm.EndICustomTextGm(builder);
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x003E0791 File Offset: 0x003DE991
		public static void StartICustomTextGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x003E079A File Offset: 0x003DE99A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3D6 RID: 111574 RVA: 0x003E07A5 File Offset: 0x003DE9A5
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(1, textOffset.Value, 0);
		}

		// Token: 0x0601B3D7 RID: 111575 RVA: 0x003E07B5 File Offset: 0x003DE9B5
		public static Offset<ICustomTextGm> EndICustomTextGm(FlatBufferBuilder builder)
		{
			return new Offset<ICustomTextGm>(builder.EndTable());
		}

		// Token: 0x0601B3D8 RID: 111576 RVA: 0x003E07C4 File Offset: 0x003DE9C4
		public ICustomTextGmT UnPack()
		{
			ICustomTextGmT customTextGmT = new ICustomTextGmT();
			this.UnPackTo(customTextGmT);
			return customTextGmT;
		}

		// Token: 0x0601B3D9 RID: 111577 RVA: 0x003E07DF File Offset: 0x003DE9DF
		public void UnPackTo(ICustomTextGmT _o)
		{
			_o.Type = this.Type;
			_o.Text = this.Text;
		}

		// Token: 0x0601B3DA RID: 111578 RVA: 0x003E07FC File Offset: 0x003DE9FC
		public static Offset<ICustomTextGm> Pack(FlatBufferBuilder builder, ICustomTextGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomTextGm>);
			}
			StringOffset textOffset = (_o.Text == null) ? default(StringOffset) : builder.CreateString(_o.Text);
			return ICustomTextGm.CreateICustomTextGm(builder, _o.Type, textOffset);
		}

		// Token: 0x0400C7B5 RID: 51125
		private Table __p;
	}
}

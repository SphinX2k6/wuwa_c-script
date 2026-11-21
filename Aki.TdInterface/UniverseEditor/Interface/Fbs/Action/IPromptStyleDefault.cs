using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754C RID: 30028
	public struct IPromptStyleDefault : IFlatbufferObject
	{
		// Token: 0x1700DCDF RID: 56543
		// (get) Token: 0x06034A7D RID: 215677 RVA: 0x007156F1 File Offset: 0x007138F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A7E RID: 215678 RVA: 0x007156FE File Offset: 0x007138FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A7F RID: 215679 RVA: 0x00715708 File Offset: 0x00713908
		public static IPromptStyleDefault GetRootAsIPromptStyleDefault(ByteBuffer _bb)
		{
			return IPromptStyleDefault.GetRootAsIPromptStyleDefault(_bb, default(IPromptStyleDefault));
		}

		// Token: 0x06034A80 RID: 215680 RVA: 0x00715724 File Offset: 0x00713924
		public static IPromptStyleDefault GetRootAsIPromptStyleDefault(ByteBuffer _bb, IPromptStyleDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A81 RID: 215681 RVA: 0x00715741 File Offset: 0x00713941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A82 RID: 215682 RVA: 0x00715750 File Offset: 0x00713950
		public IPromptStyleDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCE0 RID: 56544
		// (get) Token: 0x06034A83 RID: 215683 RVA: 0x00715760 File Offset: 0x00713960
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A84 RID: 215684 RVA: 0x0071579C File Offset: 0x0071399C
		public static Offset<IPromptStyleDefault> CreateIPromptStyleDefault(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleDefault.AddType(builder, Type);
			return IPromptStyleDefault.EndIPromptStyleDefault(builder);
		}

		// Token: 0x06034A85 RID: 215685 RVA: 0x007157B2 File Offset: 0x007139B2
		public static void StartIPromptStyleDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A86 RID: 215686 RVA: 0x007157BB File Offset: 0x007139BB
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A87 RID: 215687 RVA: 0x007157C6 File Offset: 0x007139C6
		public static Offset<IPromptStyleDefault> EndIPromptStyleDefault(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleDefault>(builder.EndTable());
		}

		// Token: 0x06034A88 RID: 215688 RVA: 0x007157D4 File Offset: 0x007139D4
		public IPromptStyleDefaultT UnPack()
		{
			IPromptStyleDefaultT promptStyleDefaultT = new IPromptStyleDefaultT();
			this.UnPackTo(promptStyleDefaultT);
			return promptStyleDefaultT;
		}

		// Token: 0x06034A89 RID: 215689 RVA: 0x007157EF File Offset: 0x007139EF
		public void UnPackTo(IPromptStyleDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A8A RID: 215690 RVA: 0x00715800 File Offset: 0x00713A00
		public static Offset<IPromptStyleDefault> Pack(FlatBufferBuilder builder, IPromptStyleDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleDefault>);
			}
			return IPromptStyleDefault.CreateIPromptStyleDefault(builder, _o.Type);
		}

		// Token: 0x0401272E RID: 75566
		private Table __p;
	}
}

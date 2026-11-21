using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007549 RID: 30025
	public struct IPromptStyleBattle2 : IFlatbufferObject
	{
		// Token: 0x1700DCDC RID: 56540
		// (get) Token: 0x06034A6B RID: 215659 RVA: 0x00715579 File Offset: 0x00713779
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A6C RID: 215660 RVA: 0x00715586 File Offset: 0x00713786
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A6D RID: 215661 RVA: 0x00715590 File Offset: 0x00713790
		public static IPromptStyleBattle2 GetRootAsIPromptStyleBattle2(ByteBuffer _bb)
		{
			return IPromptStyleBattle2.GetRootAsIPromptStyleBattle2(_bb, default(IPromptStyleBattle2));
		}

		// Token: 0x06034A6E RID: 215662 RVA: 0x007155AC File Offset: 0x007137AC
		public static IPromptStyleBattle2 GetRootAsIPromptStyleBattle2(ByteBuffer _bb, IPromptStyleBattle2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A6F RID: 215663 RVA: 0x007155C9 File Offset: 0x007137C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A70 RID: 215664 RVA: 0x007155D8 File Offset: 0x007137D8
		public IPromptStyleBattle2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCDD RID: 56541
		// (get) Token: 0x06034A71 RID: 215665 RVA: 0x007155E8 File Offset: 0x007137E8
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

		// Token: 0x06034A72 RID: 215666 RVA: 0x00715624 File Offset: 0x00713824
		public static Offset<IPromptStyleBattle2> CreateIPromptStyleBattle2(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBattle2.AddType(builder, Type);
			return IPromptStyleBattle2.EndIPromptStyleBattle2(builder);
		}

		// Token: 0x06034A73 RID: 215667 RVA: 0x0071563A File Offset: 0x0071383A
		public static void StartIPromptStyleBattle2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A74 RID: 215668 RVA: 0x00715643 File Offset: 0x00713843
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A75 RID: 215669 RVA: 0x0071564E File Offset: 0x0071384E
		public static Offset<IPromptStyleBattle2> EndIPromptStyleBattle2(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBattle2>(builder.EndTable());
		}

		// Token: 0x06034A76 RID: 215670 RVA: 0x0071565C File Offset: 0x0071385C
		public IPromptStyleBattle2T UnPack()
		{
			IPromptStyleBattle2T promptStyleBattle2T = new IPromptStyleBattle2T();
			this.UnPackTo(promptStyleBattle2T);
			return promptStyleBattle2T;
		}

		// Token: 0x06034A77 RID: 215671 RVA: 0x00715677 File Offset: 0x00713877
		public void UnPackTo(IPromptStyleBattle2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A78 RID: 215672 RVA: 0x00715688 File Offset: 0x00713888
		public static Offset<IPromptStyleBattle2> Pack(FlatBufferBuilder builder, IPromptStyleBattle2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBattle2>);
			}
			return IPromptStyleBattle2.CreateIPromptStyleBattle2(builder, _o.Type);
		}

		// Token: 0x0401272C RID: 75564
		private Table __p;
	}
}

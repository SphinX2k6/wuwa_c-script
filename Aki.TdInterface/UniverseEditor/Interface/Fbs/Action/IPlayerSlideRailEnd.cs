using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0E RID: 27918
	public struct IPlayerSlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700CFE4 RID: 53220
		// (get) Token: 0x060313AC RID: 201644 RVA: 0x006AD82C File Offset: 0x006ABA2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313AD RID: 201645 RVA: 0x006AD839 File Offset: 0x006ABA39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313AE RID: 201646 RVA: 0x006AD840 File Offset: 0x006ABA40
		public static IPlayerSlideRailEnd GetRootAsIPlayerSlideRailEnd(ByteBuffer _bb)
		{
			return IPlayerSlideRailEnd.GetRootAsIPlayerSlideRailEnd(_bb, default(IPlayerSlideRailEnd));
		}

		// Token: 0x060313AF RID: 201647 RVA: 0x006AD85C File Offset: 0x006ABA5C
		public static IPlayerSlideRailEnd GetRootAsIPlayerSlideRailEnd(ByteBuffer _bb, IPlayerSlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313B0 RID: 201648 RVA: 0x006AD879 File Offset: 0x006ABA79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313B1 RID: 201649 RVA: 0x006AD888 File Offset: 0x006ABA88
		public IPlayerSlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFE5 RID: 53221
		// (get) Token: 0x060313B2 RID: 201650 RVA: 0x006AD898 File Offset: 0x006ABA98
		public ESlideRailEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlideRailEndType.Player;
				}
				return (ESlideRailEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060313B3 RID: 201651 RVA: 0x006AD8D4 File Offset: 0x006ABAD4
		public static Offset<IPlayerSlideRailEnd> CreateIPlayerSlideRailEnd(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player)
		{
			builder.StartTable(1);
			IPlayerSlideRailEnd.AddType(builder, Type);
			return IPlayerSlideRailEnd.EndIPlayerSlideRailEnd(builder);
		}

		// Token: 0x060313B4 RID: 201652 RVA: 0x006AD8EA File Offset: 0x006ABAEA
		public static void StartIPlayerSlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313B5 RID: 201653 RVA: 0x006AD8F3 File Offset: 0x006ABAF3
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313B6 RID: 201654 RVA: 0x006AD8FE File Offset: 0x006ABAFE
		public static Offset<IPlayerSlideRailEnd> EndIPlayerSlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerSlideRailEnd>(builder.EndTable());
		}

		// Token: 0x060313B7 RID: 201655 RVA: 0x006AD90C File Offset: 0x006ABB0C
		public IPlayerSlideRailEndT UnPack()
		{
			IPlayerSlideRailEndT playerSlideRailEndT = new IPlayerSlideRailEndT();
			this.UnPackTo(playerSlideRailEndT);
			return playerSlideRailEndT;
		}

		// Token: 0x060313B8 RID: 201656 RVA: 0x006AD927 File Offset: 0x006ABB27
		public void UnPackTo(IPlayerSlideRailEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313B9 RID: 201657 RVA: 0x006AD938 File Offset: 0x006ABB38
		public static Offset<IPlayerSlideRailEnd> Pack(FlatBufferBuilder builder, IPlayerSlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerSlideRailEnd>);
			}
			return IPlayerSlideRailEnd.CreateIPlayerSlideRailEnd(builder, _o.Type);
		}

		// Token: 0x0401168A RID: 71306
		private Table __p;
	}
}

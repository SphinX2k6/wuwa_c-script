using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064FB RID: 25851
	public struct ICustomScreenBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700C045 RID: 49221
		// (get) Token: 0x0602CD83 RID: 183683 RVA: 0x006292D0 File Offset: 0x006274D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD84 RID: 183684 RVA: 0x006292DD File Offset: 0x006274DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD85 RID: 183685 RVA: 0x006292E4 File Offset: 0x006274E4
		public static ICustomScreenBackgroundImage GetRootAsICustomScreenBackgroundImage(ByteBuffer _bb)
		{
			return ICustomScreenBackgroundImage.GetRootAsICustomScreenBackgroundImage(_bb, default(ICustomScreenBackgroundImage));
		}

		// Token: 0x0602CD86 RID: 183686 RVA: 0x00629300 File Offset: 0x00627500
		public static ICustomScreenBackgroundImage GetRootAsICustomScreenBackgroundImage(ByteBuffer _bb, ICustomScreenBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD87 RID: 183687 RVA: 0x0062931D File Offset: 0x0062751D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD88 RID: 183688 RVA: 0x0062932C File Offset: 0x0062752C
		public ICustomScreenBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C046 RID: 49222
		// (get) Token: 0x0602CD89 RID: 183689 RVA: 0x0062933C File Offset: 0x0062753C
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C047 RID: 49223
		// (get) Token: 0x0602CD8A RID: 183690 RVA: 0x00629378 File Offset: 0x00627578
		public string BackgroundImagePath
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

		// Token: 0x0602CD8B RID: 183691 RVA: 0x006293AF File Offset: 0x006275AF
		public Span<byte> GetBackgroundImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CD8C RID: 183692 RVA: 0x006293BE File Offset: 0x006275BE
		public byte[] GetBackgroundImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CD8D RID: 183693 RVA: 0x006293CC File Offset: 0x006275CC
		public static Offset<ICustomScreenBackgroundImage> CreateICustomScreenBackgroundImage(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, StringOffset BackgroundImagePathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomScreenBackgroundImage.AddBackgroundImagePath(builder, BackgroundImagePathOffset);
			ICustomScreenBackgroundImage.AddType(builder, Type);
			return ICustomScreenBackgroundImage.EndICustomScreenBackgroundImage(builder);
		}

		// Token: 0x0602CD8E RID: 183694 RVA: 0x006293E9 File Offset: 0x006275E9
		public static void StartICustomScreenBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD8F RID: 183695 RVA: 0x006293F2 File Offset: 0x006275F2
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD90 RID: 183696 RVA: 0x006293FD File Offset: 0x006275FD
		public static void AddBackgroundImagePath(FlatBufferBuilder builder, StringOffset backgroundImagePathOffset)
		{
			builder.AddOffset(1, backgroundImagePathOffset.Value, 0);
		}

		// Token: 0x0602CD91 RID: 183697 RVA: 0x0062940D File Offset: 0x0062760D
		public static Offset<ICustomScreenBackgroundImage> EndICustomScreenBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenBackgroundImage>(builder.EndTable());
		}

		// Token: 0x0602CD92 RID: 183698 RVA: 0x0062941C File Offset: 0x0062761C
		public ICustomScreenBackgroundImageT UnPack()
		{
			ICustomScreenBackgroundImageT customScreenBackgroundImageT = new ICustomScreenBackgroundImageT();
			this.UnPackTo(customScreenBackgroundImageT);
			return customScreenBackgroundImageT;
		}

		// Token: 0x0602CD93 RID: 183699 RVA: 0x00629437 File Offset: 0x00627637
		public void UnPackTo(ICustomScreenBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundImagePath = this.BackgroundImagePath;
		}

		// Token: 0x0602CD94 RID: 183700 RVA: 0x00629454 File Offset: 0x00627654
		public static Offset<ICustomScreenBackgroundImage> Pack(FlatBufferBuilder builder, ICustomScreenBackgroundImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenBackgroundImage>);
			}
			StringOffset backgroundImagePathOffset = (_o.BackgroundImagePath == null) ? default(StringOffset) : builder.CreateString(_o.BackgroundImagePath);
			return ICustomScreenBackgroundImage.CreateICustomScreenBackgroundImage(builder, _o.Type, backgroundImagePathOffset);
		}

		// Token: 0x04010B3E RID: 68414
		private Table __p;
	}
}

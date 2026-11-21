using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B69 RID: 27497
	public struct ICustomScreenBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700C9D5 RID: 51669
		// (get) Token: 0x0602F519 RID: 193817 RVA: 0x00675570 File Offset: 0x00673770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F51A RID: 193818 RVA: 0x0067557D File Offset: 0x0067377D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F51B RID: 193819 RVA: 0x00675584 File Offset: 0x00673784
		public static ICustomScreenBackgroundImage GetRootAsICustomScreenBackgroundImage(ByteBuffer _bb)
		{
			return ICustomScreenBackgroundImage.GetRootAsICustomScreenBackgroundImage(_bb, default(ICustomScreenBackgroundImage));
		}

		// Token: 0x0602F51C RID: 193820 RVA: 0x006755A0 File Offset: 0x006737A0
		public static ICustomScreenBackgroundImage GetRootAsICustomScreenBackgroundImage(ByteBuffer _bb, ICustomScreenBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F51D RID: 193821 RVA: 0x006755BD File Offset: 0x006737BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F51E RID: 193822 RVA: 0x006755CC File Offset: 0x006737CC
		public ICustomScreenBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9D6 RID: 51670
		// (get) Token: 0x0602F51F RID: 193823 RVA: 0x006755DC File Offset: 0x006737DC
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

		// Token: 0x1700C9D7 RID: 51671
		// (get) Token: 0x0602F520 RID: 193824 RVA: 0x00675618 File Offset: 0x00673818
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

		// Token: 0x0602F521 RID: 193825 RVA: 0x0067564F File Offset: 0x0067384F
		public Span<byte> GetBackgroundImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F522 RID: 193826 RVA: 0x0067565E File Offset: 0x0067385E
		public byte[] GetBackgroundImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F523 RID: 193827 RVA: 0x0067566C File Offset: 0x0067386C
		public static Offset<ICustomScreenBackgroundImage> CreateICustomScreenBackgroundImage(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, StringOffset BackgroundImagePathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomScreenBackgroundImage.AddBackgroundImagePath(builder, BackgroundImagePathOffset);
			ICustomScreenBackgroundImage.AddType(builder, Type);
			return ICustomScreenBackgroundImage.EndICustomScreenBackgroundImage(builder);
		}

		// Token: 0x0602F524 RID: 193828 RVA: 0x00675689 File Offset: 0x00673889
		public static void StartICustomScreenBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F525 RID: 193829 RVA: 0x00675692 File Offset: 0x00673892
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F526 RID: 193830 RVA: 0x0067569D File Offset: 0x0067389D
		public static void AddBackgroundImagePath(FlatBufferBuilder builder, StringOffset backgroundImagePathOffset)
		{
			builder.AddOffset(1, backgroundImagePathOffset.Value, 0);
		}

		// Token: 0x0602F527 RID: 193831 RVA: 0x006756AD File Offset: 0x006738AD
		public static Offset<ICustomScreenBackgroundImage> EndICustomScreenBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenBackgroundImage>(builder.EndTable());
		}

		// Token: 0x0602F528 RID: 193832 RVA: 0x006756BC File Offset: 0x006738BC
		public ICustomScreenBackgroundImageT UnPack()
		{
			ICustomScreenBackgroundImageT customScreenBackgroundImageT = new ICustomScreenBackgroundImageT();
			this.UnPackTo(customScreenBackgroundImageT);
			return customScreenBackgroundImageT;
		}

		// Token: 0x0602F529 RID: 193833 RVA: 0x006756D7 File Offset: 0x006738D7
		public void UnPackTo(ICustomScreenBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundImagePath = this.BackgroundImagePath;
		}

		// Token: 0x0602F52A RID: 193834 RVA: 0x006756F4 File Offset: 0x006738F4
		public static Offset<ICustomScreenBackgroundImage> Pack(FlatBufferBuilder builder, ICustomScreenBackgroundImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenBackgroundImage>);
			}
			StringOffset backgroundImagePathOffset = (_o.BackgroundImagePath == null) ? default(StringOffset) : builder.CreateString(_o.BackgroundImagePath);
			return ICustomScreenBackgroundImage.CreateICustomScreenBackgroundImage(builder, _o.Type, backgroundImagePathOffset);
		}

		// Token: 0x04011956 RID: 72022
		private Table __p;
	}
}

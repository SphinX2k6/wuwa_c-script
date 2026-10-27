using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D13 RID: 15635
	public struct IAssignLoadingBackground : IFlatbufferObject
	{
		// Token: 0x17006B42 RID: 27458
		// (get) Token: 0x06015923 RID: 88355 RVA: 0x0031D9A4 File Offset: 0x0031BBA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015924 RID: 88356 RVA: 0x0031D9B1 File Offset: 0x0031BBB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015925 RID: 88357 RVA: 0x0031D9B8 File Offset: 0x0031BBB8
		public static IAssignLoadingBackground GetRootAsIAssignLoadingBackground(ByteBuffer _bb)
		{
			return IAssignLoadingBackground.GetRootAsIAssignLoadingBackground(_bb, default(IAssignLoadingBackground));
		}

		// Token: 0x06015926 RID: 88358 RVA: 0x0031D9D4 File Offset: 0x0031BBD4
		public static IAssignLoadingBackground GetRootAsIAssignLoadingBackground(ByteBuffer _bb, IAssignLoadingBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015927 RID: 88359 RVA: 0x0031D9F1 File Offset: 0x0031BBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015928 RID: 88360 RVA: 0x0031DA00 File Offset: 0x0031BC00
		public IAssignLoadingBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x06015929 RID: 88361 RVA: 0x0031DA10 File Offset: 0x0031BC10
		public EOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOperation.DisableHLOD;
				}
				return (EOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x0601592A RID: 88362 RVA: 0x0031DA4C File Offset: 0x0031BC4C
		public string ImagePath
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

		// Token: 0x0601592B RID: 88363 RVA: 0x0031DA83 File Offset: 0x0031BC83
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601592C RID: 88364 RVA: 0x0031DA92 File Offset: 0x0031BC92
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601592D RID: 88365 RVA: 0x0031DAA0 File Offset: 0x0031BCA0
		public static Offset<IAssignLoadingBackground> CreateIAssignLoadingBackground(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD, StringOffset ImagePathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAssignLoadingBackground.AddImagePath(builder, ImagePathOffset);
			IAssignLoadingBackground.AddType(builder, Type);
			return IAssignLoadingBackground.EndIAssignLoadingBackground(builder);
		}

		// Token: 0x0601592E RID: 88366 RVA: 0x0031DABD File Offset: 0x0031BCBD
		public static void StartIAssignLoadingBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601592F RID: 88367 RVA: 0x0031DAC6 File Offset: 0x0031BCC6
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x0031DAD1 File Offset: 0x0031BCD1
		public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset)
		{
			builder.AddOffset(1, imagePathOffset.Value, 0);
		}

		// Token: 0x06015931 RID: 88369 RVA: 0x0031DAE1 File Offset: 0x0031BCE1
		public static Offset<IAssignLoadingBackground> EndIAssignLoadingBackground(FlatBufferBuilder builder)
		{
			return new Offset<IAssignLoadingBackground>(builder.EndTable());
		}

		// Token: 0x06015932 RID: 88370 RVA: 0x0031DAF0 File Offset: 0x0031BCF0
		public IAssignLoadingBackgroundT UnPack()
		{
			IAssignLoadingBackgroundT assignLoadingBackgroundT = new IAssignLoadingBackgroundT();
			this.UnPackTo(assignLoadingBackgroundT);
			return assignLoadingBackgroundT;
		}

		// Token: 0x06015933 RID: 88371 RVA: 0x0031DB0B File Offset: 0x0031BD0B
		public void UnPackTo(IAssignLoadingBackgroundT _o)
		{
			_o.Type = this.Type;
			_o.ImagePath = this.ImagePath;
		}

		// Token: 0x06015934 RID: 88372 RVA: 0x0031DB28 File Offset: 0x0031BD28
		public static Offset<IAssignLoadingBackground> Pack(FlatBufferBuilder builder, IAssignLoadingBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssignLoadingBackground>);
			}
			StringOffset imagePathOffset = (_o.ImagePath == null) ? default(StringOffset) : builder.CreateString(_o.ImagePath);
			return IAssignLoadingBackground.CreateIAssignLoadingBackground(builder, _o.Type, imagePathOffset);
		}

		// Token: 0x0400B5C7 RID: 46535
		private Table __p;
	}
}

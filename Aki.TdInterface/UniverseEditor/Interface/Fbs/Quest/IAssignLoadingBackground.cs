using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412A RID: 16682
	public struct IAssignLoadingBackground : IFlatbufferObject
	{
		// Token: 0x170070FC RID: 28924
		// (get) Token: 0x06016E5B RID: 93787 RVA: 0x00344C1C File Offset: 0x00342E1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E5C RID: 93788 RVA: 0x00344C29 File Offset: 0x00342E29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E5D RID: 93789 RVA: 0x00344C30 File Offset: 0x00342E30
		public static IAssignLoadingBackground GetRootAsIAssignLoadingBackground(ByteBuffer _bb)
		{
			return IAssignLoadingBackground.GetRootAsIAssignLoadingBackground(_bb, default(IAssignLoadingBackground));
		}

		// Token: 0x06016E5E RID: 93790 RVA: 0x00344C4C File Offset: 0x00342E4C
		public static IAssignLoadingBackground GetRootAsIAssignLoadingBackground(ByteBuffer _bb, IAssignLoadingBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E5F RID: 93791 RVA: 0x00344C69 File Offset: 0x00342E69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E60 RID: 93792 RVA: 0x00344C78 File Offset: 0x00342E78
		public IAssignLoadingBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070FD RID: 28925
		// (get) Token: 0x06016E61 RID: 93793 RVA: 0x00344C88 File Offset: 0x00342E88
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

		// Token: 0x170070FE RID: 28926
		// (get) Token: 0x06016E62 RID: 93794 RVA: 0x00344CC4 File Offset: 0x00342EC4
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

		// Token: 0x06016E63 RID: 93795 RVA: 0x00344CFB File Offset: 0x00342EFB
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016E64 RID: 93796 RVA: 0x00344D0A File Offset: 0x00342F0A
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06016E65 RID: 93797 RVA: 0x00344D18 File Offset: 0x00342F18
		public static Offset<IAssignLoadingBackground> CreateIAssignLoadingBackground(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD, StringOffset ImagePathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAssignLoadingBackground.AddImagePath(builder, ImagePathOffset);
			IAssignLoadingBackground.AddType(builder, Type);
			return IAssignLoadingBackground.EndIAssignLoadingBackground(builder);
		}

		// Token: 0x06016E66 RID: 93798 RVA: 0x00344D35 File Offset: 0x00342F35
		public static void StartIAssignLoadingBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016E67 RID: 93799 RVA: 0x00344D3E File Offset: 0x00342F3E
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E68 RID: 93800 RVA: 0x00344D49 File Offset: 0x00342F49
		public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset)
		{
			builder.AddOffset(1, imagePathOffset.Value, 0);
		}

		// Token: 0x06016E69 RID: 93801 RVA: 0x00344D59 File Offset: 0x00342F59
		public static Offset<IAssignLoadingBackground> EndIAssignLoadingBackground(FlatBufferBuilder builder)
		{
			return new Offset<IAssignLoadingBackground>(builder.EndTable());
		}

		// Token: 0x06016E6A RID: 93802 RVA: 0x00344D68 File Offset: 0x00342F68
		public IAssignLoadingBackgroundT UnPack()
		{
			IAssignLoadingBackgroundT assignLoadingBackgroundT = new IAssignLoadingBackgroundT();
			this.UnPackTo(assignLoadingBackgroundT);
			return assignLoadingBackgroundT;
		}

		// Token: 0x06016E6B RID: 93803 RVA: 0x00344D83 File Offset: 0x00342F83
		public void UnPackTo(IAssignLoadingBackgroundT _o)
		{
			_o.Type = this.Type;
			_o.ImagePath = this.ImagePath;
		}

		// Token: 0x06016E6C RID: 93804 RVA: 0x00344DA0 File Offset: 0x00342FA0
		public static Offset<IAssignLoadingBackground> Pack(FlatBufferBuilder builder, IAssignLoadingBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssignLoadingBackground>);
			}
			StringOffset imagePathOffset = (_o.ImagePath == null) ? default(StringOffset) : builder.CreateString(_o.ImagePath);
			return IAssignLoadingBackground.CreateIAssignLoadingBackground(builder, _o.Type, imagePathOffset);
		}

		// Token: 0x0400BF74 RID: 49012
		private Table __p;
	}
}

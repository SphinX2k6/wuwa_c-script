using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD1 RID: 31953
	public struct IUnlockPhotoMemoryCollectSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF28 RID: 61224
		// (get) Token: 0x06039A36 RID: 236086 RVA: 0x007C6B12 File Offset: 0x007C4D12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A37 RID: 236087 RVA: 0x007C6B1F File Offset: 0x007C4D1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A38 RID: 236088 RVA: 0x007C6B28 File Offset: 0x007C4D28
		public static IUnlockPhotoMemoryCollectSystemItem GetRootAsIUnlockPhotoMemoryCollectSystemItem(ByteBuffer _bb)
		{
			return IUnlockPhotoMemoryCollectSystemItem.GetRootAsIUnlockPhotoMemoryCollectSystemItem(_bb, default(IUnlockPhotoMemoryCollectSystemItem));
		}

		// Token: 0x06039A39 RID: 236089 RVA: 0x007C6B44 File Offset: 0x007C4D44
		public static IUnlockPhotoMemoryCollectSystemItem GetRootAsIUnlockPhotoMemoryCollectSystemItem(ByteBuffer _bb, IUnlockPhotoMemoryCollectSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A3A RID: 236090 RVA: 0x007C6B61 File Offset: 0x007C4D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A3B RID: 236091 RVA: 0x007C6B70 File Offset: 0x007C4D70
		public IUnlockPhotoMemoryCollectSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF29 RID: 61225
		// (get) Token: 0x06039A3C RID: 236092 RVA: 0x007C6B80 File Offset: 0x007C4D80
		public EUnlockSystemItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return (EUnlockSystemItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF2A RID: 61226
		// (get) Token: 0x06039A3D RID: 236093 RVA: 0x007C6BBC File Offset: 0x007C4DBC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039A3E RID: 236094 RVA: 0x007C6BF8 File Offset: 0x007C4DF8
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> CreateIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPhotoMemoryCollectSystemItem.AddId(builder, Id);
			IUnlockPhotoMemoryCollectSystemItem.AddType(builder, Type);
			return IUnlockPhotoMemoryCollectSystemItem.EndIUnlockPhotoMemoryCollectSystemItem(builder);
		}

		// Token: 0x06039A3F RID: 236095 RVA: 0x007C6C15 File Offset: 0x007C4E15
		public static void StartIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039A40 RID: 236096 RVA: 0x007C6C1E File Offset: 0x007C4E1E
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039A41 RID: 236097 RVA: 0x007C6C29 File Offset: 0x007C4E29
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06039A42 RID: 236098 RVA: 0x007C6C34 File Offset: 0x007C4E34
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> EndIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPhotoMemoryCollectSystemItem>(builder.EndTable());
		}

		// Token: 0x06039A43 RID: 236099 RVA: 0x007C6C44 File Offset: 0x007C4E44
		public IUnlockPhotoMemoryCollectSystemItemT UnPack()
		{
			IUnlockPhotoMemoryCollectSystemItemT unlockPhotoMemoryCollectSystemItemT = new IUnlockPhotoMemoryCollectSystemItemT();
			this.UnPackTo(unlockPhotoMemoryCollectSystemItemT);
			return unlockPhotoMemoryCollectSystemItemT;
		}

		// Token: 0x06039A44 RID: 236100 RVA: 0x007C6C5F File Offset: 0x007C4E5F
		public void UnPackTo(IUnlockPhotoMemoryCollectSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06039A45 RID: 236101 RVA: 0x007C6C7C File Offset: 0x007C4E7C
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> Pack(FlatBufferBuilder builder, IUnlockPhotoMemoryCollectSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPhotoMemoryCollectSystemItem>);
			}
			return IUnlockPhotoMemoryCollectSystemItem.CreateIUnlockPhotoMemoryCollectSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x040133D4 RID: 78804
		private Table __p;
	}
}

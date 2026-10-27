using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DB RID: 29915
	public struct IUnlockPhotoMemoryCollectSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E2FE RID: 58110
		// (get) Token: 0x06036621 RID: 222753 RVA: 0x007638C2 File Offset: 0x00761AC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036622 RID: 222754 RVA: 0x007638CF File Offset: 0x00761ACF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036623 RID: 222755 RVA: 0x007638D8 File Offset: 0x00761AD8
		public static IUnlockPhotoMemoryCollectSystemItem GetRootAsIUnlockPhotoMemoryCollectSystemItem(ByteBuffer _bb)
		{
			return IUnlockPhotoMemoryCollectSystemItem.GetRootAsIUnlockPhotoMemoryCollectSystemItem(_bb, default(IUnlockPhotoMemoryCollectSystemItem));
		}

		// Token: 0x06036624 RID: 222756 RVA: 0x007638F4 File Offset: 0x00761AF4
		public static IUnlockPhotoMemoryCollectSystemItem GetRootAsIUnlockPhotoMemoryCollectSystemItem(ByteBuffer _bb, IUnlockPhotoMemoryCollectSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036625 RID: 222757 RVA: 0x00763911 File Offset: 0x00761B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036626 RID: 222758 RVA: 0x00763920 File Offset: 0x00761B20
		public IUnlockPhotoMemoryCollectSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2FF RID: 58111
		// (get) Token: 0x06036627 RID: 222759 RVA: 0x00763930 File Offset: 0x00761B30
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

		// Token: 0x1700E300 RID: 58112
		// (get) Token: 0x06036628 RID: 222760 RVA: 0x0076396C File Offset: 0x00761B6C
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

		// Token: 0x06036629 RID: 222761 RVA: 0x007639A8 File Offset: 0x00761BA8
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> CreateIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPhotoMemoryCollectSystemItem.AddId(builder, Id);
			IUnlockPhotoMemoryCollectSystemItem.AddType(builder, Type);
			return IUnlockPhotoMemoryCollectSystemItem.EndIUnlockPhotoMemoryCollectSystemItem(builder);
		}

		// Token: 0x0603662A RID: 222762 RVA: 0x007639C5 File Offset: 0x00761BC5
		public static void StartIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603662B RID: 222763 RVA: 0x007639CE File Offset: 0x00761BCE
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603662C RID: 222764 RVA: 0x007639D9 File Offset: 0x00761BD9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603662D RID: 222765 RVA: 0x007639E4 File Offset: 0x00761BE4
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> EndIUnlockPhotoMemoryCollectSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPhotoMemoryCollectSystemItem>(builder.EndTable());
		}

		// Token: 0x0603662E RID: 222766 RVA: 0x007639F4 File Offset: 0x00761BF4
		public IUnlockPhotoMemoryCollectSystemItemT UnPack()
		{
			IUnlockPhotoMemoryCollectSystemItemT unlockPhotoMemoryCollectSystemItemT = new IUnlockPhotoMemoryCollectSystemItemT();
			this.UnPackTo(unlockPhotoMemoryCollectSystemItemT);
			return unlockPhotoMemoryCollectSystemItemT;
		}

		// Token: 0x0603662F RID: 222767 RVA: 0x00763A0F File Offset: 0x00761C0F
		public void UnPackTo(IUnlockPhotoMemoryCollectSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06036630 RID: 222768 RVA: 0x00763A2C File Offset: 0x00761C2C
		public static Offset<IUnlockPhotoMemoryCollectSystemItem> Pack(FlatBufferBuilder builder, IUnlockPhotoMemoryCollectSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPhotoMemoryCollectSystemItem>);
			}
			return IUnlockPhotoMemoryCollectSystemItem.CreateIUnlockPhotoMemoryCollectSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x040123A3 RID: 74659
		private Table __p;
	}
}

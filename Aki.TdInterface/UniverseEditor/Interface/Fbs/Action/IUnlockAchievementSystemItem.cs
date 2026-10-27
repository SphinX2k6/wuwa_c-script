using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C0 RID: 29888
	public struct IUnlockAchievementSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E2DA RID: 58074
		// (get) Token: 0x06036563 RID: 222563 RVA: 0x00762572 File Offset: 0x00760772
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036564 RID: 222564 RVA: 0x0076257F File Offset: 0x0076077F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036565 RID: 222565 RVA: 0x00762588 File Offset: 0x00760788
		public static IUnlockAchievementSystemItem GetRootAsIUnlockAchievementSystemItem(ByteBuffer _bb)
		{
			return IUnlockAchievementSystemItem.GetRootAsIUnlockAchievementSystemItem(_bb, default(IUnlockAchievementSystemItem));
		}

		// Token: 0x06036566 RID: 222566 RVA: 0x007625A4 File Offset: 0x007607A4
		public static IUnlockAchievementSystemItem GetRootAsIUnlockAchievementSystemItem(ByteBuffer _bb, IUnlockAchievementSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036567 RID: 222567 RVA: 0x007625C1 File Offset: 0x007607C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036568 RID: 222568 RVA: 0x007625D0 File Offset: 0x007607D0
		public IUnlockAchievementSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2DB RID: 58075
		// (get) Token: 0x06036569 RID: 222569 RVA: 0x007625E0 File Offset: 0x007607E0
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

		// Token: 0x1700E2DC RID: 58076
		// (get) Token: 0x0603656A RID: 222570 RVA: 0x0076261C File Offset: 0x0076081C
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

		// Token: 0x0603656B RID: 222571 RVA: 0x00762658 File Offset: 0x00760858
		public static Offset<IUnlockAchievementSystemItem> CreateIUnlockAchievementSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockAchievementSystemItem.AddId(builder, Id);
			IUnlockAchievementSystemItem.AddType(builder, Type);
			return IUnlockAchievementSystemItem.EndIUnlockAchievementSystemItem(builder);
		}

		// Token: 0x0603656C RID: 222572 RVA: 0x00762675 File Offset: 0x00760875
		public static void StartIUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603656D RID: 222573 RVA: 0x0076267E File Offset: 0x0076087E
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603656E RID: 222574 RVA: 0x00762689 File Offset: 0x00760889
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603656F RID: 222575 RVA: 0x00762694 File Offset: 0x00760894
		public static Offset<IUnlockAchievementSystemItem> EndIUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAchievementSystemItem>(builder.EndTable());
		}

		// Token: 0x06036570 RID: 222576 RVA: 0x007626A4 File Offset: 0x007608A4
		public IUnlockAchievementSystemItemT UnPack()
		{
			IUnlockAchievementSystemItemT unlockAchievementSystemItemT = new IUnlockAchievementSystemItemT();
			this.UnPackTo(unlockAchievementSystemItemT);
			return unlockAchievementSystemItemT;
		}

		// Token: 0x06036571 RID: 222577 RVA: 0x007626BF File Offset: 0x007608BF
		public void UnPackTo(IUnlockAchievementSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06036572 RID: 222578 RVA: 0x007626DC File Offset: 0x007608DC
		public static Offset<IUnlockAchievementSystemItem> Pack(FlatBufferBuilder builder, IUnlockAchievementSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAchievementSystemItem>);
			}
			return IUnlockAchievementSystemItem.CreateIUnlockAchievementSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x04012388 RID: 74632
		private Table __p;
	}
}

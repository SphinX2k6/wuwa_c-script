using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB6 RID: 31926
	public struct IUnlockAchievementSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF04 RID: 61188
		// (get) Token: 0x06039978 RID: 235896 RVA: 0x007C57C2 File Offset: 0x007C39C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039979 RID: 235897 RVA: 0x007C57CF File Offset: 0x007C39CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603997A RID: 235898 RVA: 0x007C57D8 File Offset: 0x007C39D8
		public static IUnlockAchievementSystemItem GetRootAsIUnlockAchievementSystemItem(ByteBuffer _bb)
		{
			return IUnlockAchievementSystemItem.GetRootAsIUnlockAchievementSystemItem(_bb, default(IUnlockAchievementSystemItem));
		}

		// Token: 0x0603997B RID: 235899 RVA: 0x007C57F4 File Offset: 0x007C39F4
		public static IUnlockAchievementSystemItem GetRootAsIUnlockAchievementSystemItem(ByteBuffer _bb, IUnlockAchievementSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603997C RID: 235900 RVA: 0x007C5811 File Offset: 0x007C3A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603997D RID: 235901 RVA: 0x007C5820 File Offset: 0x007C3A20
		public IUnlockAchievementSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF05 RID: 61189
		// (get) Token: 0x0603997E RID: 235902 RVA: 0x007C5830 File Offset: 0x007C3A30
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

		// Token: 0x1700EF06 RID: 61190
		// (get) Token: 0x0603997F RID: 235903 RVA: 0x007C586C File Offset: 0x007C3A6C
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

		// Token: 0x06039980 RID: 235904 RVA: 0x007C58A8 File Offset: 0x007C3AA8
		public static Offset<IUnlockAchievementSystemItem> CreateIUnlockAchievementSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockAchievementSystemItem.AddId(builder, Id);
			IUnlockAchievementSystemItem.AddType(builder, Type);
			return IUnlockAchievementSystemItem.EndIUnlockAchievementSystemItem(builder);
		}

		// Token: 0x06039981 RID: 235905 RVA: 0x007C58C5 File Offset: 0x007C3AC5
		public static void StartIUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039982 RID: 235906 RVA: 0x007C58CE File Offset: 0x007C3ACE
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039983 RID: 235907 RVA: 0x007C58D9 File Offset: 0x007C3AD9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06039984 RID: 235908 RVA: 0x007C58E4 File Offset: 0x007C3AE4
		public static Offset<IUnlockAchievementSystemItem> EndIUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAchievementSystemItem>(builder.EndTable());
		}

		// Token: 0x06039985 RID: 235909 RVA: 0x007C58F4 File Offset: 0x007C3AF4
		public IUnlockAchievementSystemItemT UnPack()
		{
			IUnlockAchievementSystemItemT unlockAchievementSystemItemT = new IUnlockAchievementSystemItemT();
			this.UnPackTo(unlockAchievementSystemItemT);
			return unlockAchievementSystemItemT;
		}

		// Token: 0x06039986 RID: 235910 RVA: 0x007C590F File Offset: 0x007C3B0F
		public void UnPackTo(IUnlockAchievementSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06039987 RID: 235911 RVA: 0x007C592C File Offset: 0x007C3B2C
		public static Offset<IUnlockAchievementSystemItem> Pack(FlatBufferBuilder builder, IUnlockAchievementSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAchievementSystemItem>);
			}
			return IUnlockAchievementSystemItem.CreateIUnlockAchievementSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x040133B9 RID: 78777
		private Table __p;
	}
}

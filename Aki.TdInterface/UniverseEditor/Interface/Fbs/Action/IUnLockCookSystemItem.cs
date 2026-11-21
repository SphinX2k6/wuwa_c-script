using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CBF RID: 31935
	public struct IUnLockCookSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF13 RID: 61203
		// (get) Token: 0x060399C0 RID: 235968 RVA: 0x007C5FF6 File Offset: 0x007C41F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060399C1 RID: 235969 RVA: 0x007C6003 File Offset: 0x007C4203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060399C2 RID: 235970 RVA: 0x007C600C File Offset: 0x007C420C
		public static IUnLockCookSystemItem GetRootAsIUnLockCookSystemItem(ByteBuffer _bb)
		{
			return IUnLockCookSystemItem.GetRootAsIUnLockCookSystemItem(_bb, default(IUnLockCookSystemItem));
		}

		// Token: 0x060399C3 RID: 235971 RVA: 0x007C6028 File Offset: 0x007C4228
		public static IUnLockCookSystemItem GetRootAsIUnLockCookSystemItem(ByteBuffer _bb, IUnLockCookSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060399C4 RID: 235972 RVA: 0x007C6045 File Offset: 0x007C4245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060399C5 RID: 235973 RVA: 0x007C6054 File Offset: 0x007C4254
		public IUnLockCookSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF14 RID: 61204
		// (get) Token: 0x060399C6 RID: 235974 RVA: 0x007C6064 File Offset: 0x007C4264
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

		// Token: 0x1700EF15 RID: 61205
		// (get) Token: 0x060399C7 RID: 235975 RVA: 0x007C60A0 File Offset: 0x007C42A0
		public IUnlockCookSystemCookBook? UnlockOption
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IUnlockCookSystemCookBook?(default(IUnlockCookSystemCookBook).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060399C8 RID: 235976 RVA: 0x007C60FD File Offset: 0x007C42FD
		public static Offset<IUnLockCookSystemItem> CreateIUnLockCookSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, Offset<IUnlockCookSystemCookBook> UnlockOptionOffset = default(Offset<IUnlockCookSystemCookBook>))
		{
			builder.StartTable(2);
			IUnLockCookSystemItem.AddUnlockOption(builder, UnlockOptionOffset);
			IUnLockCookSystemItem.AddType(builder, Type);
			return IUnLockCookSystemItem.EndIUnLockCookSystemItem(builder);
		}

		// Token: 0x060399C9 RID: 235977 RVA: 0x007C611A File Offset: 0x007C431A
		public static void StartIUnLockCookSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060399CA RID: 235978 RVA: 0x007C6123 File Offset: 0x007C4323
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060399CB RID: 235979 RVA: 0x007C612E File Offset: 0x007C432E
		public static void AddUnlockOption(FlatBufferBuilder builder, Offset<IUnlockCookSystemCookBook> unlockOptionOffset)
		{
			builder.AddOffset(1, unlockOptionOffset.Value, 0);
		}

		// Token: 0x060399CC RID: 235980 RVA: 0x007C613E File Offset: 0x007C433E
		public static Offset<IUnLockCookSystemItem> EndIUnLockCookSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnLockCookSystemItem>(builder.EndTable());
		}

		// Token: 0x060399CD RID: 235981 RVA: 0x007C614C File Offset: 0x007C434C
		public IUnLockCookSystemItemT UnPack()
		{
			IUnLockCookSystemItemT unLockCookSystemItemT = new IUnLockCookSystemItemT();
			this.UnPackTo(unLockCookSystemItemT);
			return unLockCookSystemItemT;
		}

		// Token: 0x060399CE RID: 235982 RVA: 0x007C6168 File Offset: 0x007C4368
		public void UnPackTo(IUnLockCookSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.UnlockOption = ((this.UnlockOption != null) ? this.UnlockOption.Value.UnPack() : null);
		}

		// Token: 0x060399CF RID: 235983 RVA: 0x007C61B0 File Offset: 0x007C43B0
		public static Offset<IUnLockCookSystemItem> Pack(FlatBufferBuilder builder, IUnLockCookSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLockCookSystemItem>);
			}
			Offset<IUnlockCookSystemCookBook> unlockOptionOffset = (_o.UnlockOption == null) ? default(Offset<IUnlockCookSystemCookBook>) : IUnlockCookSystemCookBook.Pack(builder, _o.UnlockOption);
			return IUnLockCookSystemItem.CreateIUnLockCookSystemItem(builder, _o.Type, unlockOptionOffset);
		}

		// Token: 0x040133C2 RID: 78786
		private Table __p;
	}
}

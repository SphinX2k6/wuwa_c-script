using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C9 RID: 29897
	public struct IUnLockCookSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E2E9 RID: 58089
		// (get) Token: 0x060365AB RID: 222635 RVA: 0x00762DA6 File Offset: 0x00760FA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365AC RID: 222636 RVA: 0x00762DB3 File Offset: 0x00760FB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365AD RID: 222637 RVA: 0x00762DBC File Offset: 0x00760FBC
		public static IUnLockCookSystemItem GetRootAsIUnLockCookSystemItem(ByteBuffer _bb)
		{
			return IUnLockCookSystemItem.GetRootAsIUnLockCookSystemItem(_bb, default(IUnLockCookSystemItem));
		}

		// Token: 0x060365AE RID: 222638 RVA: 0x00762DD8 File Offset: 0x00760FD8
		public static IUnLockCookSystemItem GetRootAsIUnLockCookSystemItem(ByteBuffer _bb, IUnLockCookSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365AF RID: 222639 RVA: 0x00762DF5 File Offset: 0x00760FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365B0 RID: 222640 RVA: 0x00762E04 File Offset: 0x00761004
		public IUnLockCookSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2EA RID: 58090
		// (get) Token: 0x060365B1 RID: 222641 RVA: 0x00762E14 File Offset: 0x00761014
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

		// Token: 0x1700E2EB RID: 58091
		// (get) Token: 0x060365B2 RID: 222642 RVA: 0x00762E50 File Offset: 0x00761050
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

		// Token: 0x060365B3 RID: 222643 RVA: 0x00762EAD File Offset: 0x007610AD
		public static Offset<IUnLockCookSystemItem> CreateIUnLockCookSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, Offset<IUnlockCookSystemCookBook> UnlockOptionOffset = default(Offset<IUnlockCookSystemCookBook>))
		{
			builder.StartTable(2);
			IUnLockCookSystemItem.AddUnlockOption(builder, UnlockOptionOffset);
			IUnLockCookSystemItem.AddType(builder, Type);
			return IUnLockCookSystemItem.EndIUnLockCookSystemItem(builder);
		}

		// Token: 0x060365B4 RID: 222644 RVA: 0x00762ECA File Offset: 0x007610CA
		public static void StartIUnLockCookSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060365B5 RID: 222645 RVA: 0x00762ED3 File Offset: 0x007610D3
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365B6 RID: 222646 RVA: 0x00762EDE File Offset: 0x007610DE
		public static void AddUnlockOption(FlatBufferBuilder builder, Offset<IUnlockCookSystemCookBook> unlockOptionOffset)
		{
			builder.AddOffset(1, unlockOptionOffset.Value, 0);
		}

		// Token: 0x060365B7 RID: 222647 RVA: 0x00762EEE File Offset: 0x007610EE
		public static Offset<IUnLockCookSystemItem> EndIUnLockCookSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnLockCookSystemItem>(builder.EndTable());
		}

		// Token: 0x060365B8 RID: 222648 RVA: 0x00762EFC File Offset: 0x007610FC
		public IUnLockCookSystemItemT UnPack()
		{
			IUnLockCookSystemItemT unLockCookSystemItemT = new IUnLockCookSystemItemT();
			this.UnPackTo(unLockCookSystemItemT);
			return unLockCookSystemItemT;
		}

		// Token: 0x060365B9 RID: 222649 RVA: 0x00762F18 File Offset: 0x00761118
		public void UnPackTo(IUnLockCookSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.UnlockOption = ((this.UnlockOption != null) ? this.UnlockOption.Value.UnPack() : null);
		}

		// Token: 0x060365BA RID: 222650 RVA: 0x00762F60 File Offset: 0x00761160
		public static Offset<IUnLockCookSystemItem> Pack(FlatBufferBuilder builder, IUnLockCookSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLockCookSystemItem>);
			}
			Offset<IUnlockCookSystemCookBook> unlockOptionOffset = (_o.UnlockOption == null) ? default(Offset<IUnlockCookSystemCookBook>) : IUnlockCookSystemCookBook.Pack(builder, _o.UnlockOption);
			return IUnLockCookSystemItem.CreateIUnLockCookSystemItem(builder, _o.Type, unlockOptionOffset);
		}

		// Token: 0x04012391 RID: 74641
		private Table __p;
	}
}

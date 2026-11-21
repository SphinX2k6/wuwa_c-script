using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC8 RID: 31944
	public struct IUnLockDangoCollectSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF1D RID: 61213
		// (get) Token: 0x060399F4 RID: 236020 RVA: 0x007C64F6 File Offset: 0x007C46F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060399F5 RID: 236021 RVA: 0x007C6503 File Offset: 0x007C4703
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060399F6 RID: 236022 RVA: 0x007C650C File Offset: 0x007C470C
		public static IUnLockDangoCollectSystemItem GetRootAsIUnLockDangoCollectSystemItem(ByteBuffer _bb)
		{
			return IUnLockDangoCollectSystemItem.GetRootAsIUnLockDangoCollectSystemItem(_bb, default(IUnLockDangoCollectSystemItem));
		}

		// Token: 0x060399F7 RID: 236023 RVA: 0x007C6528 File Offset: 0x007C4728
		public static IUnLockDangoCollectSystemItem GetRootAsIUnLockDangoCollectSystemItem(ByteBuffer _bb, IUnLockDangoCollectSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060399F8 RID: 236024 RVA: 0x007C6545 File Offset: 0x007C4745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060399F9 RID: 236025 RVA: 0x007C6554 File Offset: 0x007C4754
		public IUnLockDangoCollectSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF1E RID: 61214
		// (get) Token: 0x060399FA RID: 236026 RVA: 0x007C6564 File Offset: 0x007C4764
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

		// Token: 0x1700EF1F RID: 61215
		// (get) Token: 0x060399FB RID: 236027 RVA: 0x007C65A0 File Offset: 0x007C47A0
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

		// Token: 0x060399FC RID: 236028 RVA: 0x007C65DC File Offset: 0x007C47DC
		public static Offset<IUnLockDangoCollectSystemItem> CreateIUnLockDangoCollectSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnLockDangoCollectSystemItem.AddId(builder, Id);
			IUnLockDangoCollectSystemItem.AddType(builder, Type);
			return IUnLockDangoCollectSystemItem.EndIUnLockDangoCollectSystemItem(builder);
		}

		// Token: 0x060399FD RID: 236029 RVA: 0x007C65F9 File Offset: 0x007C47F9
		public static void StartIUnLockDangoCollectSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060399FE RID: 236030 RVA: 0x007C6602 File Offset: 0x007C4802
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060399FF RID: 236031 RVA: 0x007C660D File Offset: 0x007C480D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06039A00 RID: 236032 RVA: 0x007C6618 File Offset: 0x007C4818
		public static Offset<IUnLockDangoCollectSystemItem> EndIUnLockDangoCollectSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnLockDangoCollectSystemItem>(builder.EndTable());
		}

		// Token: 0x06039A01 RID: 236033 RVA: 0x007C6628 File Offset: 0x007C4828
		public IUnLockDangoCollectSystemItemT UnPack()
		{
			IUnLockDangoCollectSystemItemT unLockDangoCollectSystemItemT = new IUnLockDangoCollectSystemItemT();
			this.UnPackTo(unLockDangoCollectSystemItemT);
			return unLockDangoCollectSystemItemT;
		}

		// Token: 0x06039A02 RID: 236034 RVA: 0x007C6643 File Offset: 0x007C4843
		public void UnPackTo(IUnLockDangoCollectSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06039A03 RID: 236035 RVA: 0x007C6660 File Offset: 0x007C4860
		public static Offset<IUnLockDangoCollectSystemItem> Pack(FlatBufferBuilder builder, IUnLockDangoCollectSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLockDangoCollectSystemItem>);
			}
			return IUnLockDangoCollectSystemItem.CreateIUnLockDangoCollectSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x040133CD RID: 78797
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D2 RID: 29906
	public struct IUnLockDangoCollectSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E2F3 RID: 58099
		// (get) Token: 0x060365DF RID: 222687 RVA: 0x007632A6 File Offset: 0x007614A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365E0 RID: 222688 RVA: 0x007632B3 File Offset: 0x007614B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365E1 RID: 222689 RVA: 0x007632BC File Offset: 0x007614BC
		public static IUnLockDangoCollectSystemItem GetRootAsIUnLockDangoCollectSystemItem(ByteBuffer _bb)
		{
			return IUnLockDangoCollectSystemItem.GetRootAsIUnLockDangoCollectSystemItem(_bb, default(IUnLockDangoCollectSystemItem));
		}

		// Token: 0x060365E2 RID: 222690 RVA: 0x007632D8 File Offset: 0x007614D8
		public static IUnLockDangoCollectSystemItem GetRootAsIUnLockDangoCollectSystemItem(ByteBuffer _bb, IUnLockDangoCollectSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365E3 RID: 222691 RVA: 0x007632F5 File Offset: 0x007614F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365E4 RID: 222692 RVA: 0x00763304 File Offset: 0x00761504
		public IUnLockDangoCollectSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2F4 RID: 58100
		// (get) Token: 0x060365E5 RID: 222693 RVA: 0x00763314 File Offset: 0x00761514
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

		// Token: 0x1700E2F5 RID: 58101
		// (get) Token: 0x060365E6 RID: 222694 RVA: 0x00763350 File Offset: 0x00761550
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

		// Token: 0x060365E7 RID: 222695 RVA: 0x0076338C File Offset: 0x0076158C
		public static Offset<IUnLockDangoCollectSystemItem> CreateIUnLockDangoCollectSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, int Id = 0)
		{
			builder.StartTable(2);
			IUnLockDangoCollectSystemItem.AddId(builder, Id);
			IUnLockDangoCollectSystemItem.AddType(builder, Type);
			return IUnLockDangoCollectSystemItem.EndIUnLockDangoCollectSystemItem(builder);
		}

		// Token: 0x060365E8 RID: 222696 RVA: 0x007633A9 File Offset: 0x007615A9
		public static void StartIUnLockDangoCollectSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060365E9 RID: 222697 RVA: 0x007633B2 File Offset: 0x007615B2
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365EA RID: 222698 RVA: 0x007633BD File Offset: 0x007615BD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060365EB RID: 222699 RVA: 0x007633C8 File Offset: 0x007615C8
		public static Offset<IUnLockDangoCollectSystemItem> EndIUnLockDangoCollectSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnLockDangoCollectSystemItem>(builder.EndTable());
		}

		// Token: 0x060365EC RID: 222700 RVA: 0x007633D8 File Offset: 0x007615D8
		public IUnLockDangoCollectSystemItemT UnPack()
		{
			IUnLockDangoCollectSystemItemT unLockDangoCollectSystemItemT = new IUnLockDangoCollectSystemItemT();
			this.UnPackTo(unLockDangoCollectSystemItemT);
			return unLockDangoCollectSystemItemT;
		}

		// Token: 0x060365ED RID: 222701 RVA: 0x007633F3 File Offset: 0x007615F3
		public void UnPackTo(IUnLockDangoCollectSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060365EE RID: 222702 RVA: 0x00763410 File Offset: 0x00761610
		public static Offset<IUnLockDangoCollectSystemItem> Pack(FlatBufferBuilder builder, IUnLockDangoCollectSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLockDangoCollectSystemItem>);
			}
			return IUnLockDangoCollectSystemItem.CreateIUnLockDangoCollectSystemItem(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401239C RID: 74652
		private Table __p;
	}
}

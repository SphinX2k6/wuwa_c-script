using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A5A RID: 19034
	public struct ICheckHonamiStoryGetItem : IFlatbufferObject
	{
		// Token: 0x170089CC RID: 35276
		// (get) Token: 0x0601DCFA RID: 122106 RVA: 0x00430990 File Offset: 0x0042EB90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCFB RID: 122107 RVA: 0x0043099D File Offset: 0x0042EB9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCFC RID: 122108 RVA: 0x004309A4 File Offset: 0x0042EBA4
		public static ICheckHonamiStoryGetItem GetRootAsICheckHonamiStoryGetItem(ByteBuffer _bb)
		{
			return ICheckHonamiStoryGetItem.GetRootAsICheckHonamiStoryGetItem(_bb, default(ICheckHonamiStoryGetItem));
		}

		// Token: 0x0601DCFD RID: 122109 RVA: 0x004309C0 File Offset: 0x0042EBC0
		public static ICheckHonamiStoryGetItem GetRootAsICheckHonamiStoryGetItem(ByteBuffer _bb, ICheckHonamiStoryGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCFE RID: 122110 RVA: 0x004309DD File Offset: 0x0042EBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCFF RID: 122111 RVA: 0x004309EC File Offset: 0x0042EBEC
		public ICheckHonamiStoryGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089CD RID: 35277
		// (get) Token: 0x0601DD00 RID: 122112 RVA: 0x004309FC File Offset: 0x0042EBFC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089CE RID: 35278
		// (get) Token: 0x0601DD01 RID: 122113 RVA: 0x00430A38 File Offset: 0x0042EC38
		public int ItemId
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

		// Token: 0x0601DD02 RID: 122114 RVA: 0x00430A74 File Offset: 0x0042EC74
		public static Offset<ICheckHonamiStoryGetItem> CreateICheckHonamiStoryGetItem(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ItemId = 0)
		{
			builder.StartTable(2);
			ICheckHonamiStoryGetItem.AddItemId(builder, ItemId);
			ICheckHonamiStoryGetItem.AddType(builder, Type);
			return ICheckHonamiStoryGetItem.EndICheckHonamiStoryGetItem(builder);
		}

		// Token: 0x0601DD03 RID: 122115 RVA: 0x00430A91 File Offset: 0x0042EC91
		public static void StartICheckHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DD04 RID: 122116 RVA: 0x00430A9A File Offset: 0x0042EC9A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD05 RID: 122117 RVA: 0x00430AA5 File Offset: 0x0042ECA5
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601DD06 RID: 122118 RVA: 0x00430AB0 File Offset: 0x0042ECB0
		public static Offset<ICheckHonamiStoryGetItem> EndICheckHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryGetItem>(builder.EndTable());
		}

		// Token: 0x0601DD07 RID: 122119 RVA: 0x00430AC0 File Offset: 0x0042ECC0
		public ICheckHonamiStoryGetItemT UnPack()
		{
			ICheckHonamiStoryGetItemT checkHonamiStoryGetItemT = new ICheckHonamiStoryGetItemT();
			this.UnPackTo(checkHonamiStoryGetItemT);
			return checkHonamiStoryGetItemT;
		}

		// Token: 0x0601DD08 RID: 122120 RVA: 0x00430ADB File Offset: 0x0042ECDB
		public void UnPackTo(ICheckHonamiStoryGetItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0601DD09 RID: 122121 RVA: 0x00430AF8 File Offset: 0x0042ECF8
		public static Offset<ICheckHonamiStoryGetItem> Pack(FlatBufferBuilder builder, ICheckHonamiStoryGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryGetItem>);
			}
			return ICheckHonamiStoryGetItem.CreateICheckHonamiStoryGetItem(builder, _o.Type, _o.ItemId);
		}

		// Token: 0x0400D2B8 RID: 53944
		private Table __p;
	}
}

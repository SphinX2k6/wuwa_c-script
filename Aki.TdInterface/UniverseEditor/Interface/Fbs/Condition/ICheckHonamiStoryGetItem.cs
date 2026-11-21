using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F20 RID: 20256
	public struct ICheckHonamiStoryGetItem : IFlatbufferObject
	{
		// Token: 0x170090A8 RID: 37032
		// (get) Token: 0x0601F79D RID: 128925 RVA: 0x00461B1C File Offset: 0x0045FD1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F79E RID: 128926 RVA: 0x00461B29 File Offset: 0x0045FD29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F79F RID: 128927 RVA: 0x00461B30 File Offset: 0x0045FD30
		public static ICheckHonamiStoryGetItem GetRootAsICheckHonamiStoryGetItem(ByteBuffer _bb)
		{
			return ICheckHonamiStoryGetItem.GetRootAsICheckHonamiStoryGetItem(_bb, default(ICheckHonamiStoryGetItem));
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x00461B4C File Offset: 0x0045FD4C
		public static ICheckHonamiStoryGetItem GetRootAsICheckHonamiStoryGetItem(ByteBuffer _bb, ICheckHonamiStoryGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7A1 RID: 128929 RVA: 0x00461B69 File Offset: 0x0045FD69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7A2 RID: 128930 RVA: 0x00461B78 File Offset: 0x0045FD78
		public ICheckHonamiStoryGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090A9 RID: 37033
		// (get) Token: 0x0601F7A3 RID: 128931 RVA: 0x00461B88 File Offset: 0x0045FD88
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

		// Token: 0x170090AA RID: 37034
		// (get) Token: 0x0601F7A4 RID: 128932 RVA: 0x00461BC4 File Offset: 0x0045FDC4
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

		// Token: 0x0601F7A5 RID: 128933 RVA: 0x00461C00 File Offset: 0x0045FE00
		public static Offset<ICheckHonamiStoryGetItem> CreateICheckHonamiStoryGetItem(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ItemId = 0)
		{
			builder.StartTable(2);
			ICheckHonamiStoryGetItem.AddItemId(builder, ItemId);
			ICheckHonamiStoryGetItem.AddType(builder, Type);
			return ICheckHonamiStoryGetItem.EndICheckHonamiStoryGetItem(builder);
		}

		// Token: 0x0601F7A6 RID: 128934 RVA: 0x00461C1D File Offset: 0x0045FE1D
		public static void StartICheckHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F7A7 RID: 128935 RVA: 0x00461C26 File Offset: 0x0045FE26
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7A8 RID: 128936 RVA: 0x00461C31 File Offset: 0x0045FE31
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601F7A9 RID: 128937 RVA: 0x00461C3C File Offset: 0x0045FE3C
		public static Offset<ICheckHonamiStoryGetItem> EndICheckHonamiStoryGetItem(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryGetItem>(builder.EndTable());
		}

		// Token: 0x0601F7AA RID: 128938 RVA: 0x00461C4C File Offset: 0x0045FE4C
		public ICheckHonamiStoryGetItemT UnPack()
		{
			ICheckHonamiStoryGetItemT checkHonamiStoryGetItemT = new ICheckHonamiStoryGetItemT();
			this.UnPackTo(checkHonamiStoryGetItemT);
			return checkHonamiStoryGetItemT;
		}

		// Token: 0x0601F7AB RID: 128939 RVA: 0x00461C67 File Offset: 0x0045FE67
		public void UnPackTo(ICheckHonamiStoryGetItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0601F7AC RID: 128940 RVA: 0x00461C84 File Offset: 0x0045FE84
		public static Offset<ICheckHonamiStoryGetItem> Pack(FlatBufferBuilder builder, ICheckHonamiStoryGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryGetItem>);
			}
			return ICheckHonamiStoryGetItem.CreateICheckHonamiStoryGetItem(builder, _o.Type, _o.ItemId);
		}

		// Token: 0x0400DD93 RID: 56723
		private Table __p;
	}
}

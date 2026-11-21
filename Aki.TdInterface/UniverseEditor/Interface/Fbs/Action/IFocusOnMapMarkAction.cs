using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECC RID: 28364
	public struct IFocusOnMapMarkAction : IFlatbufferObject
	{
		// Token: 0x1700D00F RID: 53263
		// (get) Token: 0x06031135 RID: 201013 RVA: 0x006A796D File Offset: 0x006A5B6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031136 RID: 201014 RVA: 0x006A797A File Offset: 0x006A5B7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031137 RID: 201015 RVA: 0x006A7984 File Offset: 0x006A5B84
		public static IFocusOnMapMarkAction GetRootAsIFocusOnMapMarkAction(ByteBuffer _bb)
		{
			return IFocusOnMapMarkAction.GetRootAsIFocusOnMapMarkAction(_bb, default(IFocusOnMapMarkAction));
		}

		// Token: 0x06031138 RID: 201016 RVA: 0x006A79A0 File Offset: 0x006A5BA0
		public static IFocusOnMapMarkAction GetRootAsIFocusOnMapMarkAction(ByteBuffer _bb, IFocusOnMapMarkAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031139 RID: 201017 RVA: 0x006A79BD File Offset: 0x006A5BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603113A RID: 201018 RVA: 0x006A79CC File Offset: 0x006A5BCC
		public IFocusOnMapMarkAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D010 RID: 53264
		// (get) Token: 0x0603113B RID: 201019 RVA: 0x006A79DC File Offset: 0x006A5BDC
		public TFocusOnMapMarkTypeConfig MapMarkTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TFocusOnMapMarkTypeConfig.NONE;
				}
				return (TFocusOnMapMarkTypeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603113C RID: 201020 RVA: 0x006A7A18 File Offset: 0x006A5C18
		public TTable? MapMarkType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603113D RID: 201021 RVA: 0x006A7A5C File Offset: 0x006A5C5C
		public IFocusOnCustomMapMark MapMarkTypeAsIFocusOnCustomMapMark()
		{
			return this.MapMarkType<IFocusOnCustomMapMark>().Value;
		}

		// Token: 0x0603113E RID: 201022 RVA: 0x006A7A78 File Offset: 0x006A5C78
		public IFocusOnQuestMapMark MapMarkTypeAsIFocusOnQuestMapMark()
		{
			return this.MapMarkType<IFocusOnQuestMapMark>().Value;
		}

		// Token: 0x0603113F RID: 201023 RVA: 0x006A7A93 File Offset: 0x006A5C93
		public static Offset<IFocusOnMapMarkAction> CreateIFocusOnMapMarkAction(FlatBufferBuilder builder, TFocusOnMapMarkTypeConfig MapMarkType_type = TFocusOnMapMarkTypeConfig.NONE, int MapMarkTypeOffset = 0)
		{
			builder.StartTable(2);
			IFocusOnMapMarkAction.AddMapMarkType(builder, MapMarkTypeOffset);
			IFocusOnMapMarkAction.AddMapMarkTypeType(builder, MapMarkType_type);
			return IFocusOnMapMarkAction.EndIFocusOnMapMarkAction(builder);
		}

		// Token: 0x06031140 RID: 201024 RVA: 0x006A7AB0 File Offset: 0x006A5CB0
		public static void StartIFocusOnMapMarkAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031141 RID: 201025 RVA: 0x006A7AB9 File Offset: 0x006A5CB9
		public static void AddMapMarkTypeType(FlatBufferBuilder builder, TFocusOnMapMarkTypeConfig mapMarkTypeType)
		{
			builder.AddByte(0, (byte)mapMarkTypeType, 0);
		}

		// Token: 0x06031142 RID: 201026 RVA: 0x006A7AC4 File Offset: 0x006A5CC4
		public static void AddMapMarkType(FlatBufferBuilder builder, int mapMarkTypeOffset)
		{
			builder.AddOffset(1, mapMarkTypeOffset, 0);
		}

		// Token: 0x06031143 RID: 201027 RVA: 0x006A7ACF File Offset: 0x006A5CCF
		public static Offset<IFocusOnMapMarkAction> EndIFocusOnMapMarkAction(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnMapMarkAction>(builder.EndTable());
		}

		// Token: 0x06031144 RID: 201028 RVA: 0x006A7ADC File Offset: 0x006A5CDC
		public IFocusOnMapMarkActionT UnPack()
		{
			IFocusOnMapMarkActionT focusOnMapMarkActionT = new IFocusOnMapMarkActionT();
			this.UnPackTo(focusOnMapMarkActionT);
			return focusOnMapMarkActionT;
		}

		// Token: 0x06031145 RID: 201029 RVA: 0x006A7AF8 File Offset: 0x006A5CF8
		public void UnPackTo(IFocusOnMapMarkActionT _o)
		{
			_o.MapMarkType = new TFocusOnMapMarkTypeConfigUnion();
			_o.MapMarkType.Type = this.MapMarkTypeType;
			TFocusOnMapMarkTypeConfig mapMarkTypeType = this.MapMarkTypeType;
			if (mapMarkTypeType == TFocusOnMapMarkTypeConfig.IFocusOnCustomMapMark)
			{
				_o.MapMarkType.Value = ((this.MapMarkType<IFocusOnCustomMapMark>() != null) ? this.MapMarkType<IFocusOnCustomMapMark>().Value.UnPack() : null);
				return;
			}
			if (mapMarkTypeType != TFocusOnMapMarkTypeConfig.IFocusOnQuestMapMark)
			{
				return;
			}
			_o.MapMarkType.Value = ((this.MapMarkType<IFocusOnQuestMapMark>() != null) ? this.MapMarkType<IFocusOnQuestMapMark>().Value.UnPack() : null);
		}

		// Token: 0x06031146 RID: 201030 RVA: 0x006A7B9C File Offset: 0x006A5D9C
		public static Offset<IFocusOnMapMarkAction> Pack(FlatBufferBuilder builder, IFocusOnMapMarkActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnMapMarkAction>);
			}
			TFocusOnMapMarkTypeConfig mapMarkType_type = (_o.MapMarkType == null) ? TFocusOnMapMarkTypeConfig.NONE : _o.MapMarkType.Type;
			int mapMarkTypeOffset = (_o.MapMarkType == null) ? 0 : TFocusOnMapMarkTypeConfigUnion.Pack(builder, _o.MapMarkType);
			return IFocusOnMapMarkAction.CreateIFocusOnMapMarkAction(builder, mapMarkType_type, mapMarkTypeOffset);
		}

		// Token: 0x04011DC8 RID: 73160
		private Table __p;
	}
}

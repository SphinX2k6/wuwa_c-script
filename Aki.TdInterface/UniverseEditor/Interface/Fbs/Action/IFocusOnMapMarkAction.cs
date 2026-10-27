using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006846 RID: 26694
	public struct IFocusOnMapMarkAction : IFlatbufferObject
	{
		// Token: 0x1700C64B RID: 50763
		// (get) Token: 0x0602E8AD RID: 190637 RVA: 0x00659A2D File Offset: 0x00657C2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8AE RID: 190638 RVA: 0x00659A3A File Offset: 0x00657C3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8AF RID: 190639 RVA: 0x00659A44 File Offset: 0x00657C44
		public static IFocusOnMapMarkAction GetRootAsIFocusOnMapMarkAction(ByteBuffer _bb)
		{
			return IFocusOnMapMarkAction.GetRootAsIFocusOnMapMarkAction(_bb, default(IFocusOnMapMarkAction));
		}

		// Token: 0x0602E8B0 RID: 190640 RVA: 0x00659A60 File Offset: 0x00657C60
		public static IFocusOnMapMarkAction GetRootAsIFocusOnMapMarkAction(ByteBuffer _bb, IFocusOnMapMarkAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8B1 RID: 190641 RVA: 0x00659A7D File Offset: 0x00657C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8B2 RID: 190642 RVA: 0x00659A8C File Offset: 0x00657C8C
		public IFocusOnMapMarkAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C64C RID: 50764
		// (get) Token: 0x0602E8B3 RID: 190643 RVA: 0x00659A9C File Offset: 0x00657C9C
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

		// Token: 0x0602E8B4 RID: 190644 RVA: 0x00659AD8 File Offset: 0x00657CD8
		public TTable? MapMarkType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8B5 RID: 190645 RVA: 0x00659B1C File Offset: 0x00657D1C
		public IFocusOnCustomMapMark MapMarkTypeAsIFocusOnCustomMapMark()
		{
			return this.MapMarkType<IFocusOnCustomMapMark>().Value;
		}

		// Token: 0x0602E8B6 RID: 190646 RVA: 0x00659B38 File Offset: 0x00657D38
		public IFocusOnQuestMapMark MapMarkTypeAsIFocusOnQuestMapMark()
		{
			return this.MapMarkType<IFocusOnQuestMapMark>().Value;
		}

		// Token: 0x0602E8B7 RID: 190647 RVA: 0x00659B53 File Offset: 0x00657D53
		public static Offset<IFocusOnMapMarkAction> CreateIFocusOnMapMarkAction(FlatBufferBuilder builder, TFocusOnMapMarkTypeConfig MapMarkType_type = TFocusOnMapMarkTypeConfig.NONE, int MapMarkTypeOffset = 0)
		{
			builder.StartTable(2);
			IFocusOnMapMarkAction.AddMapMarkType(builder, MapMarkTypeOffset);
			IFocusOnMapMarkAction.AddMapMarkTypeType(builder, MapMarkType_type);
			return IFocusOnMapMarkAction.EndIFocusOnMapMarkAction(builder);
		}

		// Token: 0x0602E8B8 RID: 190648 RVA: 0x00659B70 File Offset: 0x00657D70
		public static void StartIFocusOnMapMarkAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E8B9 RID: 190649 RVA: 0x00659B79 File Offset: 0x00657D79
		public static void AddMapMarkTypeType(FlatBufferBuilder builder, TFocusOnMapMarkTypeConfig mapMarkTypeType)
		{
			builder.AddByte(0, (byte)mapMarkTypeType, 0);
		}

		// Token: 0x0602E8BA RID: 190650 RVA: 0x00659B84 File Offset: 0x00657D84
		public static void AddMapMarkType(FlatBufferBuilder builder, int mapMarkTypeOffset)
		{
			builder.AddOffset(1, mapMarkTypeOffset, 0);
		}

		// Token: 0x0602E8BB RID: 190651 RVA: 0x00659B8F File Offset: 0x00657D8F
		public static Offset<IFocusOnMapMarkAction> EndIFocusOnMapMarkAction(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnMapMarkAction>(builder.EndTable());
		}

		// Token: 0x0602E8BC RID: 190652 RVA: 0x00659B9C File Offset: 0x00657D9C
		public IFocusOnMapMarkActionT UnPack()
		{
			IFocusOnMapMarkActionT focusOnMapMarkActionT = new IFocusOnMapMarkActionT();
			this.UnPackTo(focusOnMapMarkActionT);
			return focusOnMapMarkActionT;
		}

		// Token: 0x0602E8BD RID: 190653 RVA: 0x00659BB8 File Offset: 0x00657DB8
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

		// Token: 0x0602E8BE RID: 190654 RVA: 0x00659C5C File Offset: 0x00657E5C
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

		// Token: 0x04010F8E RID: 69518
		private Table __p;
	}
}

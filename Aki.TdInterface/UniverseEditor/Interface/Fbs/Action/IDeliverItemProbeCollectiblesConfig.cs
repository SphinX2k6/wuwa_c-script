using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656D RID: 25965
	public struct IDeliverItemProbeCollectiblesConfig : IFlatbufferObject
	{
		// Token: 0x1700C0F0 RID: 49392
		// (get) Token: 0x0602D0BE RID: 184510 RVA: 0x0062E5E6 File Offset: 0x0062C7E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D0BF RID: 184511 RVA: 0x0062E5F3 File Offset: 0x0062C7F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D0C0 RID: 184512 RVA: 0x0062E5FC File Offset: 0x0062C7FC
		public static IDeliverItemProbeCollectiblesConfig GetRootAsIDeliverItemProbeCollectiblesConfig(ByteBuffer _bb)
		{
			return IDeliverItemProbeCollectiblesConfig.GetRootAsIDeliverItemProbeCollectiblesConfig(_bb, default(IDeliverItemProbeCollectiblesConfig));
		}

		// Token: 0x0602D0C1 RID: 184513 RVA: 0x0062E618 File Offset: 0x0062C818
		public static IDeliverItemProbeCollectiblesConfig GetRootAsIDeliverItemProbeCollectiblesConfig(ByteBuffer _bb, IDeliverItemProbeCollectiblesConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D0C2 RID: 184514 RVA: 0x0062E635 File Offset: 0x0062C835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D0C3 RID: 184515 RVA: 0x0062E644 File Offset: 0x0062C844
		public IDeliverItemProbeCollectiblesConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0F1 RID: 49393
		// (get) Token: 0x0602D0C4 RID: 184516 RVA: 0x0062E654 File Offset: 0x0062C854
		public IHandInItemViewStyle? ViewStyle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IHandInItemViewStyle?(default(IHandInItemViewStyle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C0F2 RID: 49394
		// (get) Token: 0x0602D0C5 RID: 184517 RVA: 0x0062E6B4 File Offset: 0x0062C8B4
		public IItemCellIndependentDeliverType? DeliverType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IItemCellIndependentDeliverType?(default(IItemCellIndependentDeliverType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C0F3 RID: 49395
		// (get) Token: 0x0602D0C6 RID: 184518 RVA: 0x0062E714 File Offset: 0x0062C914
		public IPlaceholderCollectibleMarkerType? MarkerType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPlaceholderCollectibleMarkerType?(default(IPlaceholderCollectibleMarkerType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602D0C7 RID: 184519 RVA: 0x0062E771 File Offset: 0x0062C971
		public static Offset<IDeliverItemProbeCollectiblesConfig> CreateIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder, Offset<IHandInItemViewStyle> ViewStyleOffset = default(Offset<IHandInItemViewStyle>), Offset<IItemCellIndependentDeliverType> DeliverTypeOffset = default(Offset<IItemCellIndependentDeliverType>), Offset<IPlaceholderCollectibleMarkerType> MarkerTypeOffset = default(Offset<IPlaceholderCollectibleMarkerType>))
		{
			builder.StartTable(3);
			IDeliverItemProbeCollectiblesConfig.AddMarkerType(builder, MarkerTypeOffset);
			IDeliverItemProbeCollectiblesConfig.AddDeliverType(builder, DeliverTypeOffset);
			IDeliverItemProbeCollectiblesConfig.AddViewStyle(builder, ViewStyleOffset);
			return IDeliverItemProbeCollectiblesConfig.EndIDeliverItemProbeCollectiblesConfig(builder);
		}

		// Token: 0x0602D0C8 RID: 184520 RVA: 0x0062E795 File Offset: 0x0062C995
		public static void StartIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D0C9 RID: 184521 RVA: 0x0062E79E File Offset: 0x0062C99E
		public static void AddViewStyle(FlatBufferBuilder builder, Offset<IHandInItemViewStyle> viewStyleOffset)
		{
			builder.AddOffset(0, viewStyleOffset.Value, 0);
		}

		// Token: 0x0602D0CA RID: 184522 RVA: 0x0062E7AE File Offset: 0x0062C9AE
		public static void AddDeliverType(FlatBufferBuilder builder, Offset<IItemCellIndependentDeliverType> deliverTypeOffset)
		{
			builder.AddOffset(1, deliverTypeOffset.Value, 0);
		}

		// Token: 0x0602D0CB RID: 184523 RVA: 0x0062E7BE File Offset: 0x0062C9BE
		public static void AddMarkerType(FlatBufferBuilder builder, Offset<IPlaceholderCollectibleMarkerType> markerTypeOffset)
		{
			builder.AddOffset(2, markerTypeOffset.Value, 0);
		}

		// Token: 0x0602D0CC RID: 184524 RVA: 0x0062E7CE File Offset: 0x0062C9CE
		public static Offset<IDeliverItemProbeCollectiblesConfig> EndIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverItemProbeCollectiblesConfig>(builder.EndTable());
		}

		// Token: 0x0602D0CD RID: 184525 RVA: 0x0062E7DC File Offset: 0x0062C9DC
		public IDeliverItemProbeCollectiblesConfigT UnPack()
		{
			IDeliverItemProbeCollectiblesConfigT deliverItemProbeCollectiblesConfigT = new IDeliverItemProbeCollectiblesConfigT();
			this.UnPackTo(deliverItemProbeCollectiblesConfigT);
			return deliverItemProbeCollectiblesConfigT;
		}

		// Token: 0x0602D0CE RID: 184526 RVA: 0x0062E7F8 File Offset: 0x0062C9F8
		public void UnPackTo(IDeliverItemProbeCollectiblesConfigT _o)
		{
			_o.ViewStyle = ((this.ViewStyle != null) ? this.ViewStyle.Value.UnPack() : null);
			_o.DeliverType = ((this.DeliverType != null) ? this.DeliverType.Value.UnPack() : null);
			_o.MarkerType = ((this.MarkerType != null) ? this.MarkerType.Value.UnPack() : null);
		}

		// Token: 0x0602D0CF RID: 184527 RVA: 0x0062E898 File Offset: 0x0062CA98
		public static Offset<IDeliverItemProbeCollectiblesConfig> Pack(FlatBufferBuilder builder, IDeliverItemProbeCollectiblesConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverItemProbeCollectiblesConfig>);
			}
			Offset<IHandInItemViewStyle> viewStyleOffset = (_o.ViewStyle == null) ? default(Offset<IHandInItemViewStyle>) : IHandInItemViewStyle.Pack(builder, _o.ViewStyle);
			Offset<IItemCellIndependentDeliverType> deliverTypeOffset = (_o.DeliverType == null) ? default(Offset<IItemCellIndependentDeliverType>) : IItemCellIndependentDeliverType.Pack(builder, _o.DeliverType);
			Offset<IPlaceholderCollectibleMarkerType> markerTypeOffset = (_o.MarkerType == null) ? default(Offset<IPlaceholderCollectibleMarkerType>) : IPlaceholderCollectibleMarkerType.Pack(builder, _o.MarkerType);
			return IDeliverItemProbeCollectiblesConfig.CreateIDeliverItemProbeCollectiblesConfig(builder, viewStyleOffset, deliverTypeOffset, markerTypeOffset);
		}

		// Token: 0x04010BC2 RID: 68546
		private Table __p;
	}
}

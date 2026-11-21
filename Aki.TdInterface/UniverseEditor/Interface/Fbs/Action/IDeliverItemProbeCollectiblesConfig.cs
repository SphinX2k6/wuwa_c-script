using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDB RID: 27611
	public struct IDeliverItemProbeCollectiblesConfig : IFlatbufferObject
	{
		// Token: 0x1700CA86 RID: 51846
		// (get) Token: 0x0602F864 RID: 194660 RVA: 0x0067ABAC File Offset: 0x00678DAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F865 RID: 194661 RVA: 0x0067ABB9 File Offset: 0x00678DB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F866 RID: 194662 RVA: 0x0067ABC0 File Offset: 0x00678DC0
		public static IDeliverItemProbeCollectiblesConfig GetRootAsIDeliverItemProbeCollectiblesConfig(ByteBuffer _bb)
		{
			return IDeliverItemProbeCollectiblesConfig.GetRootAsIDeliverItemProbeCollectiblesConfig(_bb, default(IDeliverItemProbeCollectiblesConfig));
		}

		// Token: 0x0602F867 RID: 194663 RVA: 0x0067ABDC File Offset: 0x00678DDC
		public static IDeliverItemProbeCollectiblesConfig GetRootAsIDeliverItemProbeCollectiblesConfig(ByteBuffer _bb, IDeliverItemProbeCollectiblesConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F868 RID: 194664 RVA: 0x0067ABF9 File Offset: 0x00678DF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F869 RID: 194665 RVA: 0x0067AC08 File Offset: 0x00678E08
		public IDeliverItemProbeCollectiblesConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA87 RID: 51847
		// (get) Token: 0x0602F86A RID: 194666 RVA: 0x0067AC18 File Offset: 0x00678E18
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

		// Token: 0x1700CA88 RID: 51848
		// (get) Token: 0x0602F86B RID: 194667 RVA: 0x0067AC78 File Offset: 0x00678E78
		public int CollectiblesDetectionId
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

		// Token: 0x0602F86C RID: 194668 RVA: 0x0067ACB4 File Offset: 0x00678EB4
		public static Offset<IDeliverItemProbeCollectiblesConfig> CreateIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder, Offset<IHandInItemViewStyle> ViewStyleOffset = default(Offset<IHandInItemViewStyle>), int CollectiblesDetectionId = 0)
		{
			builder.StartTable(2);
			IDeliverItemProbeCollectiblesConfig.AddCollectiblesDetectionId(builder, CollectiblesDetectionId);
			IDeliverItemProbeCollectiblesConfig.AddViewStyle(builder, ViewStyleOffset);
			return IDeliverItemProbeCollectiblesConfig.EndIDeliverItemProbeCollectiblesConfig(builder);
		}

		// Token: 0x0602F86D RID: 194669 RVA: 0x0067ACD1 File Offset: 0x00678ED1
		public static void StartIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F86E RID: 194670 RVA: 0x0067ACDA File Offset: 0x00678EDA
		public static void AddViewStyle(FlatBufferBuilder builder, Offset<IHandInItemViewStyle> viewStyleOffset)
		{
			builder.AddOffset(0, viewStyleOffset.Value, 0);
		}

		// Token: 0x0602F86F RID: 194671 RVA: 0x0067ACEA File Offset: 0x00678EEA
		public static void AddCollectiblesDetectionId(FlatBufferBuilder builder, int collectiblesDetectionId)
		{
			builder.AddInt(1, collectiblesDetectionId, 0);
		}

		// Token: 0x0602F870 RID: 194672 RVA: 0x0067ACF5 File Offset: 0x00678EF5
		public static Offset<IDeliverItemProbeCollectiblesConfig> EndIDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverItemProbeCollectiblesConfig>(builder.EndTable());
		}

		// Token: 0x0602F871 RID: 194673 RVA: 0x0067AD04 File Offset: 0x00678F04
		public IDeliverItemProbeCollectiblesConfigT UnPack()
		{
			IDeliverItemProbeCollectiblesConfigT deliverItemProbeCollectiblesConfigT = new IDeliverItemProbeCollectiblesConfigT();
			this.UnPackTo(deliverItemProbeCollectiblesConfigT);
			return deliverItemProbeCollectiblesConfigT;
		}

		// Token: 0x0602F872 RID: 194674 RVA: 0x0067AD20 File Offset: 0x00678F20
		public void UnPackTo(IDeliverItemProbeCollectiblesConfigT _o)
		{
			_o.ViewStyle = ((this.ViewStyle != null) ? this.ViewStyle.Value.UnPack() : null);
			_o.CollectiblesDetectionId = this.CollectiblesDetectionId;
		}

		// Token: 0x0602F873 RID: 194675 RVA: 0x0067AD68 File Offset: 0x00678F68
		public static Offset<IDeliverItemProbeCollectiblesConfig> Pack(FlatBufferBuilder builder, IDeliverItemProbeCollectiblesConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverItemProbeCollectiblesConfig>);
			}
			Offset<IHandInItemViewStyle> viewStyleOffset = (_o.ViewStyle == null) ? default(Offset<IHandInItemViewStyle>) : IHandInItemViewStyle.Pack(builder, _o.ViewStyle);
			return IDeliverItemProbeCollectiblesConfig.CreateIDeliverItemProbeCollectiblesConfig(builder, viewStyleOffset, _o.CollectiblesDetectionId);
		}

		// Token: 0x040119DD RID: 72157
		private Table __p;
	}
}

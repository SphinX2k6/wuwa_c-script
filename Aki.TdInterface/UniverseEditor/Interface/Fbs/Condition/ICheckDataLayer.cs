using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C1 RID: 18881
	public struct ICheckDataLayer : IFlatbufferObject
	{
		// Token: 0x17008882 RID: 34946
		// (get) Token: 0x0601D79C RID: 120732 RVA: 0x00426E56 File Offset: 0x00425056
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D79D RID: 120733 RVA: 0x00426E63 File Offset: 0x00425063
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D79E RID: 120734 RVA: 0x00426E6C File Offset: 0x0042506C
		public static ICheckDataLayer GetRootAsICheckDataLayer(ByteBuffer _bb)
		{
			return ICheckDataLayer.GetRootAsICheckDataLayer(_bb, default(ICheckDataLayer));
		}

		// Token: 0x0601D79F RID: 120735 RVA: 0x00426E88 File Offset: 0x00425088
		public static ICheckDataLayer GetRootAsICheckDataLayer(ByteBuffer _bb, ICheckDataLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7A0 RID: 120736 RVA: 0x00426EA5 File Offset: 0x004250A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7A1 RID: 120737 RVA: 0x00426EB4 File Offset: 0x004250B4
		public ICheckDataLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008883 RID: 34947
		// (get) Token: 0x0601D7A2 RID: 120738 RVA: 0x00426EC4 File Offset: 0x004250C4
		public int DataLayerId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008884 RID: 34948
		// (get) Token: 0x0601D7A3 RID: 120739 RVA: 0x00426F00 File Offset: 0x00425100
		public bool IsLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D7A4 RID: 120740 RVA: 0x00426F3F File Offset: 0x0042513F
		public static Offset<ICheckDataLayer> CreateICheckDataLayer(FlatBufferBuilder builder, int DataLayerId = 0, bool IsLoad = false)
		{
			builder.StartTable(2);
			ICheckDataLayer.AddDataLayerId(builder, DataLayerId);
			ICheckDataLayer.AddIsLoad(builder, IsLoad);
			return ICheckDataLayer.EndICheckDataLayer(builder);
		}

		// Token: 0x0601D7A5 RID: 120741 RVA: 0x00426F5C File Offset: 0x0042515C
		public static void StartICheckDataLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D7A6 RID: 120742 RVA: 0x00426F65 File Offset: 0x00425165
		public static void AddDataLayerId(FlatBufferBuilder builder, int dataLayerId)
		{
			builder.AddInt(0, dataLayerId, 0);
		}

		// Token: 0x0601D7A7 RID: 120743 RVA: 0x00426F70 File Offset: 0x00425170
		public static void AddIsLoad(FlatBufferBuilder builder, bool isLoad)
		{
			builder.AddBool(1, isLoad, false);
		}

		// Token: 0x0601D7A8 RID: 120744 RVA: 0x00426F7B File Offset: 0x0042517B
		public static Offset<ICheckDataLayer> EndICheckDataLayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDataLayer>(builder.EndTable());
		}

		// Token: 0x0601D7A9 RID: 120745 RVA: 0x00426F88 File Offset: 0x00425188
		public ICheckDataLayerT UnPack()
		{
			ICheckDataLayerT checkDataLayerT = new ICheckDataLayerT();
			this.UnPackTo(checkDataLayerT);
			return checkDataLayerT;
		}

		// Token: 0x0601D7AA RID: 120746 RVA: 0x00426FA3 File Offset: 0x004251A3
		public void UnPackTo(ICheckDataLayerT _o)
		{
			_o.DataLayerId = this.DataLayerId;
			_o.IsLoad = this.IsLoad;
		}

		// Token: 0x0601D7AB RID: 120747 RVA: 0x00426FC0 File Offset: 0x004251C0
		public static Offset<ICheckDataLayer> Pack(FlatBufferBuilder builder, ICheckDataLayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDataLayer>);
			}
			return ICheckDataLayer.CreateICheckDataLayer(builder, _o.DataLayerId, _o.IsLoad);
		}

		// Token: 0x0400D1E9 RID: 53737
		private Table __p;
	}
}

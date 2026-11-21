using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E7E RID: 20094
	public struct ICheckDataLayer : IFlatbufferObject
	{
		// Token: 0x17008F4B RID: 36683
		// (get) Token: 0x0601F1F5 RID: 127477 RVA: 0x00457834 File Offset: 0x00455A34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1F6 RID: 127478 RVA: 0x00457841 File Offset: 0x00455A41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1F7 RID: 127479 RVA: 0x00457848 File Offset: 0x00455A48
		public static ICheckDataLayer GetRootAsICheckDataLayer(ByteBuffer _bb)
		{
			return ICheckDataLayer.GetRootAsICheckDataLayer(_bb, default(ICheckDataLayer));
		}

		// Token: 0x0601F1F8 RID: 127480 RVA: 0x00457864 File Offset: 0x00455A64
		public static ICheckDataLayer GetRootAsICheckDataLayer(ByteBuffer _bb, ICheckDataLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1F9 RID: 127481 RVA: 0x00457881 File Offset: 0x00455A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1FA RID: 127482 RVA: 0x00457890 File Offset: 0x00455A90
		public ICheckDataLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F4C RID: 36684
		// (get) Token: 0x0601F1FB RID: 127483 RVA: 0x004578A0 File Offset: 0x00455AA0
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

		// Token: 0x17008F4D RID: 36685
		// (get) Token: 0x0601F1FC RID: 127484 RVA: 0x004578DC File Offset: 0x00455ADC
		public bool IsLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F1FD RID: 127485 RVA: 0x0045791B File Offset: 0x00455B1B
		public static Offset<ICheckDataLayer> CreateICheckDataLayer(FlatBufferBuilder builder, int DataLayerId = 0, bool IsLoad = false)
		{
			builder.StartTable(2);
			ICheckDataLayer.AddDataLayerId(builder, DataLayerId);
			ICheckDataLayer.AddIsLoad(builder, IsLoad);
			return ICheckDataLayer.EndICheckDataLayer(builder);
		}

		// Token: 0x0601F1FE RID: 127486 RVA: 0x00457938 File Offset: 0x00455B38
		public static void StartICheckDataLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F1FF RID: 127487 RVA: 0x00457941 File Offset: 0x00455B41
		public static void AddDataLayerId(FlatBufferBuilder builder, int dataLayerId)
		{
			builder.AddInt(0, dataLayerId, 0);
		}

		// Token: 0x0601F200 RID: 127488 RVA: 0x0045794C File Offset: 0x00455B4C
		public static void AddIsLoad(FlatBufferBuilder builder, bool isLoad)
		{
			builder.AddBool(1, isLoad, false);
		}

		// Token: 0x0601F201 RID: 127489 RVA: 0x00457957 File Offset: 0x00455B57
		public static Offset<ICheckDataLayer> EndICheckDataLayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDataLayer>(builder.EndTable());
		}

		// Token: 0x0601F202 RID: 127490 RVA: 0x00457964 File Offset: 0x00455B64
		public ICheckDataLayerT UnPack()
		{
			ICheckDataLayerT checkDataLayerT = new ICheckDataLayerT();
			this.UnPackTo(checkDataLayerT);
			return checkDataLayerT;
		}

		// Token: 0x0601F203 RID: 127491 RVA: 0x0045797F File Offset: 0x00455B7F
		public void UnPackTo(ICheckDataLayerT _o)
		{
			_o.DataLayerId = this.DataLayerId;
			_o.IsLoad = this.IsLoad;
		}

		// Token: 0x0601F204 RID: 127492 RVA: 0x0045799C File Offset: 0x00455B9C
		public static Offset<ICheckDataLayer> Pack(FlatBufferBuilder builder, ICheckDataLayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDataLayer>);
			}
			return ICheckDataLayer.CreateICheckDataLayer(builder, _o.DataLayerId, _o.IsLoad);
		}

		// Token: 0x0400DCB9 RID: 56505
		private Table __p;
	}
}

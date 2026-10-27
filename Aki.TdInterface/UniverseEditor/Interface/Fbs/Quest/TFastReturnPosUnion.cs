using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D3 RID: 17107
	public class TFastReturnPosUnion
	{
		// Token: 0x17007944 RID: 31044
		// (get) Token: 0x060195FD RID: 103933 RVA: 0x003A3F4A File Offset: 0x003A214A
		// (set) Token: 0x060195FE RID: 103934 RVA: 0x003A3F52 File Offset: 0x003A2152
		public TFastReturnPos Type { get; set; }

		// Token: 0x17007945 RID: 31045
		// (get) Token: 0x060195FF RID: 103935 RVA: 0x003A3F5B File Offset: 0x003A215B
		// (set) Token: 0x06019600 RID: 103936 RVA: 0x003A3F63 File Offset: 0x003A2163
		public object Value { get; set; }

		// Token: 0x06019601 RID: 103937 RVA: 0x003A3F6C File Offset: 0x003A216C
		public TFastReturnPosUnion()
		{
			this.Type = TFastReturnPos.NONE;
			this.Value = null;
		}

		// Token: 0x06019602 RID: 103938 RVA: 0x003A3F82 File Offset: 0x003A2182
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019603 RID: 103939 RVA: 0x003A3F94 File Offset: 0x003A2194
		public IFastReturnEntityPosT AsIFastReturnEntityPos()
		{
			return this.As<IFastReturnEntityPosT>();
		}

		// Token: 0x06019604 RID: 103940 RVA: 0x003A3F9C File Offset: 0x003A219C
		public static TFastReturnPosUnion FromIFastReturnEntityPos(IFastReturnEntityPosT _ifastreturnentitypos)
		{
			return new TFastReturnPosUnion
			{
				Type = TFastReturnPos.IFastReturnEntityPos,
				Value = _ifastreturnentitypos
			};
		}

		// Token: 0x06019605 RID: 103941 RVA: 0x003A3FB1 File Offset: 0x003A21B1
		public IFastReturnGravityEntityPosT AsIFastReturnGravityEntityPos()
		{
			return this.As<IFastReturnGravityEntityPosT>();
		}

		// Token: 0x06019606 RID: 103942 RVA: 0x003A3FB9 File Offset: 0x003A21B9
		public static TFastReturnPosUnion FromIFastReturnGravityEntityPos(IFastReturnGravityEntityPosT _ifastreturngravityentitypos)
		{
			return new TFastReturnPosUnion
			{
				Type = TFastReturnPos.IFastReturnGravityEntityPos,
				Value = _ifastreturngravityentitypos
			};
		}

		// Token: 0x06019607 RID: 103943 RVA: 0x003A3FD0 File Offset: 0x003A21D0
		public static int Pack(FlatBufferBuilder builder, TFastReturnPosUnion _o)
		{
			TFastReturnPos type = _o.Type;
			if (type == TFastReturnPos.IFastReturnEntityPos)
			{
				return IFastReturnEntityPos.Pack(builder, _o.AsIFastReturnEntityPos()).Value;
			}
			if (type != TFastReturnPos.IFastReturnGravityEntityPos)
			{
				return 0;
			}
			return IFastReturnGravityEntityPos.Pack(builder, _o.AsIFastReturnGravityEntityPos()).Value;
		}
	}
}

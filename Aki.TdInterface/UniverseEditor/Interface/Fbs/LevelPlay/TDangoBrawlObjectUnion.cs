using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A62 RID: 19042
	public class TDangoBrawlObjectUnion
	{
		// Token: 0x1700859C RID: 34204
		// (get) Token: 0x0601CA08 RID: 117256 RVA: 0x0040A2C0 File Offset: 0x004084C0
		// (set) Token: 0x0601CA09 RID: 117257 RVA: 0x0040A2C8 File Offset: 0x004084C8
		public TDangoBrawlObject Type { get; set; }

		// Token: 0x1700859D RID: 34205
		// (get) Token: 0x0601CA0A RID: 117258 RVA: 0x0040A2D1 File Offset: 0x004084D1
		// (set) Token: 0x0601CA0B RID: 117259 RVA: 0x0040A2D9 File Offset: 0x004084D9
		public object Value { get; set; }

		// Token: 0x0601CA0C RID: 117260 RVA: 0x0040A2E2 File Offset: 0x004084E2
		public TDangoBrawlObjectUnion()
		{
			this.Type = TDangoBrawlObject.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA0D RID: 117261 RVA: 0x0040A2F8 File Offset: 0x004084F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA0E RID: 117262 RVA: 0x0040A30A File Offset: 0x0040850A
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601CA0F RID: 117263 RVA: 0x0040A312 File Offset: 0x00408512
		public static TDangoBrawlObjectUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new TDangoBrawlObjectUnion
			{
				Type = TDangoBrawlObject.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601CA10 RID: 117264 RVA: 0x0040A327 File Offset: 0x00408527
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601CA11 RID: 117265 RVA: 0x0040A32F File Offset: 0x0040852F
		public static TDangoBrawlObjectUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new TDangoBrawlObjectUnion
			{
				Type = TDangoBrawlObject.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601CA12 RID: 117266 RVA: 0x0040A344 File Offset: 0x00408544
		public static int Pack(FlatBufferBuilder builder, TDangoBrawlObjectUnion _o)
		{
			TDangoBrawlObject type = _o.Type;
			if (type == TDangoBrawlObject.IDangoBrawlBag)
			{
				return IDangoBrawlBag.Pack(builder, _o.AsIDangoBrawlBag()).Value;
			}
			if (type != TDangoBrawlObject.IDangoBrawlItem)
			{
				return 0;
			}
			return IDangoBrawlItem.Pack(builder, _o.AsIDangoBrawlItem()).Value;
		}
	}
}

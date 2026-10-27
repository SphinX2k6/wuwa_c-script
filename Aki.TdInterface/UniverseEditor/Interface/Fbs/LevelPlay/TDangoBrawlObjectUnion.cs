using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045FA RID: 17914
	public class TDangoBrawlObjectUnion
	{
		// Token: 0x17007F5B RID: 32603
		// (get) Token: 0x0601B233 RID: 111155 RVA: 0x003DE024 File Offset: 0x003DC224
		// (set) Token: 0x0601B234 RID: 111156 RVA: 0x003DE02C File Offset: 0x003DC22C
		public TDangoBrawlObject Type { get; set; }

		// Token: 0x17007F5C RID: 32604
		// (get) Token: 0x0601B235 RID: 111157 RVA: 0x003DE035 File Offset: 0x003DC235
		// (set) Token: 0x0601B236 RID: 111158 RVA: 0x003DE03D File Offset: 0x003DC23D
		public object Value { get; set; }

		// Token: 0x0601B237 RID: 111159 RVA: 0x003DE046 File Offset: 0x003DC246
		public TDangoBrawlObjectUnion()
		{
			this.Type = TDangoBrawlObject.NONE;
			this.Value = null;
		}

		// Token: 0x0601B238 RID: 111160 RVA: 0x003DE05C File Offset: 0x003DC25C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B239 RID: 111161 RVA: 0x003DE06E File Offset: 0x003DC26E
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601B23A RID: 111162 RVA: 0x003DE076 File Offset: 0x003DC276
		public static TDangoBrawlObjectUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new TDangoBrawlObjectUnion
			{
				Type = TDangoBrawlObject.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601B23B RID: 111163 RVA: 0x003DE08B File Offset: 0x003DC28B
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601B23C RID: 111164 RVA: 0x003DE093 File Offset: 0x003DC293
		public static TDangoBrawlObjectUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new TDangoBrawlObjectUnion
			{
				Type = TDangoBrawlObject.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601B23D RID: 111165 RVA: 0x003DE0A8 File Offset: 0x003DC2A8
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

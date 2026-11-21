using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C2 RID: 25794
	public class TGiantAnimDataUnion
	{
		// Token: 0x1700BE3C RID: 48700
		// (get) Token: 0x0602BDA8 RID: 179624 RVA: 0x005F6C32 File Offset: 0x005F4E32
		// (set) Token: 0x0602BDA9 RID: 179625 RVA: 0x005F6C3A File Offset: 0x005F4E3A
		public TGiantAnimData Type { get; set; }

		// Token: 0x1700BE3D RID: 48701
		// (get) Token: 0x0602BDAA RID: 179626 RVA: 0x005F6C43 File Offset: 0x005F4E43
		// (set) Token: 0x0602BDAB RID: 179627 RVA: 0x005F6C4B File Offset: 0x005F4E4B
		public object Value { get; set; }

		// Token: 0x0602BDAC RID: 179628 RVA: 0x005F6C54 File Offset: 0x005F4E54
		public TGiantAnimDataUnion()
		{
			this.Type = TGiantAnimData.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDAD RID: 179629 RVA: 0x005F6C6A File Offset: 0x005F4E6A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDAE RID: 179630 RVA: 0x005F6C7C File Offset: 0x005F4E7C
		public IGiantIdleAnimDataT AsIGiantIdleAnimData()
		{
			return this.As<IGiantIdleAnimDataT>();
		}

		// Token: 0x0602BDAF RID: 179631 RVA: 0x005F6C84 File Offset: 0x005F4E84
		public static TGiantAnimDataUnion FromIGiantIdleAnimData(IGiantIdleAnimDataT _igiantidleanimdata)
		{
			return new TGiantAnimDataUnion
			{
				Type = TGiantAnimData.IGiantIdleAnimData,
				Value = _igiantidleanimdata
			};
		}

		// Token: 0x0602BDB0 RID: 179632 RVA: 0x005F6C99 File Offset: 0x005F4E99
		public IGiantSpecialAnimDataT AsIGiantSpecialAnimData()
		{
			return this.As<IGiantSpecialAnimDataT>();
		}

		// Token: 0x0602BDB1 RID: 179633 RVA: 0x005F6CA1 File Offset: 0x005F4EA1
		public static TGiantAnimDataUnion FromIGiantSpecialAnimData(IGiantSpecialAnimDataT _igiantspecialanimdata)
		{
			return new TGiantAnimDataUnion
			{
				Type = TGiantAnimData.IGiantSpecialAnimData,
				Value = _igiantspecialanimdata
			};
		}

		// Token: 0x0602BDB2 RID: 179634 RVA: 0x005F6CB8 File Offset: 0x005F4EB8
		public static int Pack(FlatBufferBuilder builder, TGiantAnimDataUnion _o)
		{
			TGiantAnimData type = _o.Type;
			if (type == TGiantAnimData.IGiantIdleAnimData)
			{
				return IGiantIdleAnimData.Pack(builder, _o.AsIGiantIdleAnimData()).Value;
			}
			if (type != TGiantAnimData.IGiantSpecialAnimData)
			{
				return 0;
			}
			return IGiantSpecialAnimData.Pack(builder, _o.AsIGiantSpecialAnimData()).Value;
		}
	}
}

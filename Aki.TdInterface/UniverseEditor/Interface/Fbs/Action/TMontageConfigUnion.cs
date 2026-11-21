using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F43 RID: 32579
	public class TMontageConfigUnion
	{
		// Token: 0x1700F2A5 RID: 62117
		// (get) Token: 0x0603AC05 RID: 240645 RVA: 0x007E6416 File Offset: 0x007E4616
		// (set) Token: 0x0603AC06 RID: 240646 RVA: 0x007E641E File Offset: 0x007E461E
		public TMontageConfig Type { get; set; }

		// Token: 0x1700F2A6 RID: 62118
		// (get) Token: 0x0603AC07 RID: 240647 RVA: 0x007E6427 File Offset: 0x007E4627
		// (set) Token: 0x0603AC08 RID: 240648 RVA: 0x007E642F File Offset: 0x007E462F
		public object Value { get; set; }

		// Token: 0x0603AC09 RID: 240649 RVA: 0x007E6438 File Offset: 0x007E4638
		public TMontageConfigUnion()
		{
			this.Type = TMontageConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC0A RID: 240650 RVA: 0x007E644E File Offset: 0x007E464E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC0B RID: 240651 RVA: 0x007E6460 File Offset: 0x007E4660
		public IMontageAssetT AsIMontageAsset()
		{
			return this.As<IMontageAssetT>();
		}

		// Token: 0x0603AC0C RID: 240652 RVA: 0x007E6468 File Offset: 0x007E4668
		public static TMontageConfigUnion FromIMontageAsset(IMontageAssetT _imontageasset)
		{
			return new TMontageConfigUnion
			{
				Type = TMontageConfig.IMontageAsset,
				Value = _imontageasset
			};
		}

		// Token: 0x0603AC0D RID: 240653 RVA: 0x007E647D File Offset: 0x007E467D
		public IMontageRegisteredT AsIMontageRegistered()
		{
			return this.As<IMontageRegisteredT>();
		}

		// Token: 0x0603AC0E RID: 240654 RVA: 0x007E6485 File Offset: 0x007E4685
		public static TMontageConfigUnion FromIMontageRegistered(IMontageRegisteredT _imontageregistered)
		{
			return new TMontageConfigUnion
			{
				Type = TMontageConfig.IMontageRegistered,
				Value = _imontageregistered
			};
		}

		// Token: 0x0603AC0F RID: 240655 RVA: 0x007E649C File Offset: 0x007E469C
		public static int Pack(FlatBufferBuilder builder, TMontageConfigUnion _o)
		{
			TMontageConfig type = _o.Type;
			if (type == TMontageConfig.IMontageAsset)
			{
				return IMontageAsset.Pack(builder, _o.AsIMontageAsset()).Value;
			}
			if (type != TMontageConfig.IMontageRegistered)
			{
				return 0;
			}
			return IMontageRegistered.Pack(builder, _o.AsIMontageRegistered()).Value;
		}
	}
}

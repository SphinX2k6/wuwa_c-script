using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771D RID: 30493
	public class TMontageConfigUnion
	{
		// Token: 0x1700E657 RID: 58967
		// (get) Token: 0x060376DC RID: 227036 RVA: 0x00781662 File Offset: 0x0077F862
		// (set) Token: 0x060376DD RID: 227037 RVA: 0x0078166A File Offset: 0x0077F86A
		public TMontageConfig Type { get; set; }

		// Token: 0x1700E658 RID: 58968
		// (get) Token: 0x060376DE RID: 227038 RVA: 0x00781673 File Offset: 0x0077F873
		// (set) Token: 0x060376DF RID: 227039 RVA: 0x0078167B File Offset: 0x0077F87B
		public object Value { get; set; }

		// Token: 0x060376E0 RID: 227040 RVA: 0x00781684 File Offset: 0x0077F884
		public TMontageConfigUnion()
		{
			this.Type = TMontageConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060376E1 RID: 227041 RVA: 0x0078169A File Offset: 0x0077F89A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376E2 RID: 227042 RVA: 0x007816AC File Offset: 0x0077F8AC
		public IMontageAssetT AsIMontageAsset()
		{
			return this.As<IMontageAssetT>();
		}

		// Token: 0x060376E3 RID: 227043 RVA: 0x007816B4 File Offset: 0x0077F8B4
		public static TMontageConfigUnion FromIMontageAsset(IMontageAssetT _imontageasset)
		{
			return new TMontageConfigUnion
			{
				Type = TMontageConfig.IMontageAsset,
				Value = _imontageasset
			};
		}

		// Token: 0x060376E4 RID: 227044 RVA: 0x007816C9 File Offset: 0x0077F8C9
		public IMontageRegisteredT AsIMontageRegistered()
		{
			return this.As<IMontageRegisteredT>();
		}

		// Token: 0x060376E5 RID: 227045 RVA: 0x007816D1 File Offset: 0x0077F8D1
		public static TMontageConfigUnion FromIMontageRegistered(IMontageRegisteredT _imontageregistered)
		{
			return new TMontageConfigUnion
			{
				Type = TMontageConfig.IMontageRegistered,
				Value = _imontageregistered
			};
		}

		// Token: 0x060376E6 RID: 227046 RVA: 0x007816E8 File Offset: 0x0077F8E8
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

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D72 RID: 7538
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongExploration3 : ILeisureInteractType
	{
		// Token: 0x0600A199 RID: 41369 RVA: 0x0016FFC4 File Offset: 0x0016E1C4
		private IQiuyuanQinggongExploration3_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration3 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration3_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration3_SetValue());
			}
			return result;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0016FFFC File Offset: 0x0016E1FC
		public static IQiuyuanQinggongExploration3 Create([Nullable(2)] IQiuyuanQinggongExploration3 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration3
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x0017000F File Offset: 0x0016E20F
		public static IQiuyuanQinggongExploration3 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration3_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration3
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x00170022 File Offset: 0x0016E222
		public new IQiuyuanQinggongExploration3_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration3_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A19D RID: 41373 RVA: 0x00170035 File Offset: 0x0016E235
		// (set) Token: 0x0600A19E RID: 41374 RVA: 0x00170060 File Offset: 0x0016E260
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006133 RID: 24883
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration3 FbInstance;

		// Token: 0x04006134 RID: 24884
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration3_SetValue PocoInterface;
	}
}

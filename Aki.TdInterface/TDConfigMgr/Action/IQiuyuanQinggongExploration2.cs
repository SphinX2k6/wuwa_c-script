using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D70 RID: 7536
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongExploration2 : ILeisureInteractType
	{
		// Token: 0x0600A191 RID: 41361 RVA: 0x0016FF08 File Offset: 0x0016E108
		private IQiuyuanQinggongExploration2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration2_SetValue());
			}
			return result;
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x0016FF40 File Offset: 0x0016E140
		public static IQiuyuanQinggongExploration2 Create([Nullable(2)] IQiuyuanQinggongExploration2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x0016FF53 File Offset: 0x0016E153
		public static IQiuyuanQinggongExploration2 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x0016FF66 File Offset: 0x0016E166
		public new IQiuyuanQinggongExploration2_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x0016FF79 File Offset: 0x0016E179
		// (set) Token: 0x0600A196 RID: 41366 RVA: 0x0016FFA4 File Offset: 0x0016E1A4
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

		// Token: 0x04006130 RID: 24880
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration2 FbInstance;

		// Token: 0x04006131 RID: 24881
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration2_SetValue PocoInterface;
	}
}

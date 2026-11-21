using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F83 RID: 8067
	public class IQiuyuanQinggongExploration3 : ILeisureInteractType
	{
		// Token: 0x0600AB85 RID: 43909 RVA: 0x001843E8 File Offset: 0x001825E8
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

		// Token: 0x0600AB86 RID: 43910 RVA: 0x00184420 File Offset: 0x00182620
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

		// Token: 0x0600AB87 RID: 43911 RVA: 0x00184433 File Offset: 0x00182633
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

		// Token: 0x0600AB88 RID: 43912 RVA: 0x00184446 File Offset: 0x00182646
		public new IQiuyuanQinggongExploration3_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration3_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x00184459 File Offset: 0x00182659
		// (set) Token: 0x0600AB8A RID: 43914 RVA: 0x00184484 File Offset: 0x00182684
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

		// Token: 0x040066AF RID: 26287
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration3 FbInstance;

		// Token: 0x040066B0 RID: 26288
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration3_SetValue PocoInterface;
	}
}

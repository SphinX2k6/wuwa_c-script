using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7F RID: 8063
	public class IQiuyuanQinggongExploration1 : ILeisureInteractType
	{
		// Token: 0x0600AB75 RID: 43893 RVA: 0x00184270 File Offset: 0x00182470
		private IQiuyuanQinggongExploration1_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration1 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration1_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration1_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x001842A8 File Offset: 0x001824A8
		public static IQiuyuanQinggongExploration1 Create([Nullable(2)] IQiuyuanQinggongExploration1 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB77 RID: 43895 RVA: 0x001842BB File Offset: 0x001824BB
		public static IQiuyuanQinggongExploration1 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration1_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x001842CE File Offset: 0x001824CE
		public new IQiuyuanQinggongExploration1_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration1_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x001842E1 File Offset: 0x001824E1
		// (set) Token: 0x0600AB7A RID: 43898 RVA: 0x0018430C File Offset: 0x0018250C
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

		// Token: 0x040066A9 RID: 26281
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration1 FbInstance;

		// Token: 0x040066AA RID: 26282
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration1_SetValue PocoInterface;
	}
}

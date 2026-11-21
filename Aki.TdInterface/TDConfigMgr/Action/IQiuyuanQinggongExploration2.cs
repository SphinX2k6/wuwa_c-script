using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F81 RID: 8065
	public class IQiuyuanQinggongExploration2 : ILeisureInteractType
	{
		// Token: 0x0600AB7D RID: 43901 RVA: 0x0018432C File Offset: 0x0018252C
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

		// Token: 0x0600AB7E RID: 43902 RVA: 0x00184364 File Offset: 0x00182564
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

		// Token: 0x0600AB7F RID: 43903 RVA: 0x00184377 File Offset: 0x00182577
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

		// Token: 0x0600AB80 RID: 43904 RVA: 0x0018438A File Offset: 0x0018258A
		public new IQiuyuanQinggongExploration2_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600AB81 RID: 43905 RVA: 0x0018439D File Offset: 0x0018259D
		// (set) Token: 0x0600AB82 RID: 43906 RVA: 0x001843C8 File Offset: 0x001825C8
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

		// Token: 0x040066AC RID: 26284
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration2 FbInstance;

		// Token: 0x040066AD RID: 26285
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration2_SetValue PocoInterface;
	}
}

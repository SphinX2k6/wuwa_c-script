using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F85 RID: 8069
	public class IQiuyuanQinggongExploration4 : ILeisureInteractType
	{
		// Token: 0x0600AB8D RID: 43917 RVA: 0x001844A4 File Offset: 0x001826A4
		private IQiuyuanQinggongExploration4_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration4 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration4_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration4_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x001844DC File Offset: 0x001826DC
		public static IQiuyuanQinggongExploration4 Create([Nullable(2)] IQiuyuanQinggongExploration4 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x001844EF File Offset: 0x001826EF
		public static IQiuyuanQinggongExploration4 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration4_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x00184502 File Offset: 0x00182702
		public new IQiuyuanQinggongExploration4_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration4_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600AB91 RID: 43921 RVA: 0x00184515 File Offset: 0x00182715
		// (set) Token: 0x0600AB92 RID: 43922 RVA: 0x00184540 File Offset: 0x00182740
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

		// Token: 0x040066B2 RID: 26290
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration4 FbInstance;

		// Token: 0x040066B3 RID: 26291
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration4_SetValue PocoInterface;
	}
}

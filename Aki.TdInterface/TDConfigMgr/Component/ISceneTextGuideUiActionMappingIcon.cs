using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074F RID: 1871
	public class ISceneTextGuideUiActionMappingIcon
	{
		// Token: 0x060027C6 RID: 10182 RVA: 0x0006A340 File Offset: 0x00068540
		private ISceneTextGuideUiActionMappingIcon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextGuideUiActionMappingIcon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextGuideUiActionMappingIcon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextGuideUiActionMappingIcon_SetValue());
			}
			return result;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0006A378 File Offset: 0x00068578
		public static ISceneTextGuideUiActionMappingIcon Create([Nullable(2)] ISceneTextGuideUiActionMappingIcon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiActionMappingIcon
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0006A38B File Offset: 0x0006858B
		public static ISceneTextGuideUiActionMappingIcon CreateFromSetValue([Nullable(2)] ISceneTextGuideUiActionMappingIcon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextGuideUiActionMappingIcon
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0006A39E File Offset: 0x0006859E
		public ISceneTextGuideUiActionMappingIcon_SetValue ToSetValue()
		{
			return new ISceneTextGuideUiActionMappingIcon_SetValue
			{
				Id = this.Id,
				ActionName = this.ActionName
			};
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0006A3BD File Offset: 0x000685BD
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0006A3E8 File Offset: 0x000685E8
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0006A3F6 File Offset: 0x000685F6
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x0006A421 File Offset: 0x00068621
		public virtual string ActionName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActionName;
			}
			set
			{
				this.GetOrCreatePoco().ActionName = value;
			}
		}

		// Token: 0x04001B24 RID: 6948
		[Nullable(2)]
		protected ISceneTextGuideUiActionMappingIcon FbInstance;

		// Token: 0x04001B25 RID: 6949
		[Nullable(2)]
		protected ISceneTextGuideUiActionMappingIcon_SetValue PocoInterface;
	}
}

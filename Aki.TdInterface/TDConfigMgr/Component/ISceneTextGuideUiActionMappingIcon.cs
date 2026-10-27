using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006AE RID: 1710
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUiActionMappingIcon
	{
		// Token: 0x060024AA RID: 9386 RVA: 0x00063378 File Offset: 0x00061578
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

		// Token: 0x060024AB RID: 9387 RVA: 0x000633B0 File Offset: 0x000615B0
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

		// Token: 0x060024AC RID: 9388 RVA: 0x000633C3 File Offset: 0x000615C3
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

		// Token: 0x060024AD RID: 9389 RVA: 0x000633D6 File Offset: 0x000615D6
		public ISceneTextGuideUiActionMappingIcon_SetValue ToSetValue()
		{
			return new ISceneTextGuideUiActionMappingIcon_SetValue
			{
				Id = this.Id,
				ActionName = this.ActionName
			};
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000633F5 File Offset: 0x000615F5
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x00063420 File Offset: 0x00061620
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0006342E File Offset: 0x0006162E
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x00063459 File Offset: 0x00061659
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

		// Token: 0x04001927 RID: 6439
		[Nullable(2)]
		protected ISceneTextGuideUiActionMappingIcon FbInstance;

		// Token: 0x04001928 RID: 6440
		[Nullable(2)]
		protected ISceneTextGuideUiActionMappingIcon_SetValue PocoInterface;
	}
}

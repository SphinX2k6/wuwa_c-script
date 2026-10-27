using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000750 RID: 1872
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetGearGroupSuccessContdion
	{
		// Token: 0x0600286D RID: 10349 RVA: 0x0006B1CC File Offset: 0x000693CC
		private ITargetGearGroupSuccessContdion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetGearGroupSuccessContdion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetGearGroupSuccessContdion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetGearGroupSuccessContdion_SetValue());
			}
			return result;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0006B204 File Offset: 0x00069404
		public static ITargetGearGroupSuccessContdion Create([Nullable(2)] ITargetGearGroupSuccessContdion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupSuccessContdion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0006B217 File Offset: 0x00069417
		public static ITargetGearGroupSuccessContdion CreateFromSetValue([Nullable(2)] ITargetGearGroupSuccessContdion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetGearGroupSuccessContdion
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0006B22A File Offset: 0x0006942A
		public ITargetGearGroupSuccessContdion_SetValue ToSetValue()
		{
			return new ITargetGearGroupSuccessContdion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x0006B23D File Offset: 0x0006943D
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x0006B268 File Offset: 0x00069468
		public virtual ETargetGearGroupSuccessCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001B34 RID: 6964
		[Nullable(2)]
		protected ITargetGearGroupSuccessContdion FbInstance;

		// Token: 0x04001B35 RID: 6965
		[Nullable(2)]
		protected ITargetGearGroupSuccessContdion_SetValue PocoInterface;
	}
}

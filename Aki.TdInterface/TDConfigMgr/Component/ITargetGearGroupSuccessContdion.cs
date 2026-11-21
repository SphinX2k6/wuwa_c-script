using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F1 RID: 2033
	public class ITargetGearGroupSuccessContdion
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x00072374 File Offset: 0x00070574
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

		// Token: 0x06002B92 RID: 11154 RVA: 0x000723AC File Offset: 0x000705AC
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

		// Token: 0x06002B93 RID: 11155 RVA: 0x000723BF File Offset: 0x000705BF
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

		// Token: 0x06002B94 RID: 11156 RVA: 0x000723D2 File Offset: 0x000705D2
		public ITargetGearGroupSuccessContdion_SetValue ToSetValue()
		{
			return new ITargetGearGroupSuccessContdion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000723E5 File Offset: 0x000705E5
		// (set) Token: 0x06002B96 RID: 11158 RVA: 0x00072410 File Offset: 0x00070610
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

		// Token: 0x04001D39 RID: 7481
		[Nullable(2)]
		protected ITargetGearGroupSuccessContdion FbInstance;

		// Token: 0x04001D3A RID: 7482
		[Nullable(2)]
		protected ITargetGearGroupSuccessContdion_SetValue PocoInterface;
	}
}

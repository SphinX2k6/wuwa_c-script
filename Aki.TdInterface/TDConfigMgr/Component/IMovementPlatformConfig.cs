using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200059F RID: 1439
	public class IMovementPlatformConfig
	{
		// Token: 0x06001D48 RID: 7496 RVA: 0x00053E58 File Offset: 0x00052058
		private IMovementPlatformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementPlatformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementPlatformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementPlatformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00053E90 File Offset: 0x00052090
		public static IMovementPlatformConfig Create([Nullable(2)] IMovementPlatformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPlatformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00053EA3 File Offset: 0x000520A3
		public static IMovementPlatformConfig CreateFromSetValue([Nullable(2)] IMovementPlatformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementPlatformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00053EB6 File Offset: 0x000520B6
		public IMovementPlatformConfig_SetValue ToSetValue()
		{
			return new IMovementPlatformConfig_SetValue
			{
				PlayerAttachTags = this.PlayerAttachTags,
				SafePointId = this.SafePointId
			};
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00053ED5 File Offset: 0x000520D5
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00053EFC File Offset: 0x000520FC
		[Nullable(2)]
		public virtual List<int> PlayerAttachTags
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerAttachTags;
				}
				IMovementPlatformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerAttachTags;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PlayerAttachTags = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00053F0C File Offset: 0x0005210C
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x00053F46 File Offset: 0x00052146
		public virtual int? SafePointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SafePointId;
				}
				IMovementPlatformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SafePointId;
			}
			set
			{
				this.GetOrCreatePoco().SafePointId = value;
			}
		}

		// Token: 0x04001517 RID: 5399
		[Nullable(2)]
		protected IMovementPlatformConfig FbInstance;

		// Token: 0x04001518 RID: 5400
		[Nullable(2)]
		protected IMovementPlatformConfig_SetValue PocoInterface;
	}
}

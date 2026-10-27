using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200201B RID: 8219
	[NullableContext(1)]
	[Nullable(0)]
	public class IUniversalTone
	{
		// Token: 0x0600B4B8 RID: 46264 RVA: 0x001A41B8 File Offset: 0x001A23B8
		private IUniversalTone_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUniversalTone 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUniversalTone_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUniversalTone_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x001A41F0 File Offset: 0x001A23F0
		public static IUniversalTone Create([Nullable(2)] IUniversalTone instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x001A4203 File Offset: 0x001A2403
		public static IUniversalTone CreateFromSetValue([Nullable(2)] IUniversalTone_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x001A4216 File Offset: 0x001A2416
		public IUniversalTone_SetValue ToSetValue()
		{
			return new IUniversalTone_SetValue
			{
				UniversalToneId = this.UniversalToneId,
				TimberId = this.TimberId
			};
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x001A4235 File Offset: 0x001A2435
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x001A4260 File Offset: 0x001A2460
		public virtual int UniversalToneId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UniversalToneId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.UniversalToneId;
			}
			set
			{
				this.GetOrCreatePoco().UniversalToneId = value;
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x001A4270 File Offset: 0x001A2470
		// (set) Token: 0x0600B4BF RID: 46271 RVA: 0x001A42AA File Offset: 0x001A24AA
		public virtual int? TimberId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimberId;
				}
				IUniversalTone_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimberId;
			}
			set
			{
				this.GetOrCreatePoco().TimberId = value;
			}
		}

		// Token: 0x04006CDF RID: 27871
		[Nullable(2)]
		protected IUniversalTone FbInstance;

		// Token: 0x04006CE0 RID: 27872
		[Nullable(2)]
		protected IUniversalTone_SetValue PocoInterface;
	}
}

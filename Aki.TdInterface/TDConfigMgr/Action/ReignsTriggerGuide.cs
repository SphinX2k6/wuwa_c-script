using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002142 RID: 8514
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsTriggerGuide : ActionParams
	{
		// Token: 0x0600BB72 RID: 47986 RVA: 0x001B0CCC File Offset: 0x001AEECC
		private ReignsTriggerGuide_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsTriggerGuide 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsTriggerGuide_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsTriggerGuide_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x001B0D04 File Offset: 0x001AEF04
		public static ReignsTriggerGuide Create([Nullable(2)] ReignsTriggerGuide instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x001B0D17 File Offset: 0x001AEF17
		public static ReignsTriggerGuide CreateFromSetValue([Nullable(2)] ReignsTriggerGuide_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x001B0D2A File Offset: 0x001AEF2A
		public ReignsTriggerGuide_SetValue ToSetValue()
		{
			return new ReignsTriggerGuide_SetValue
			{
				GuideId = this.GuideId
			};
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x001B0D3D File Offset: 0x001AEF3D
		// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x001B0D68 File Offset: 0x001AEF68
		public virtual int GuideId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GuideId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GuideId;
			}
			set
			{
				this.GetOrCreatePoco().GuideId = value;
			}
		}

		// Token: 0x04007017 RID: 28695
		[Nullable(2)]
		protected new ReignsTriggerGuide FbInstance;

		// Token: 0x04007018 RID: 28696
		[Nullable(2)]
		protected ReignsTriggerGuide_SetValue PocoInterface;
	}
}

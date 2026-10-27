using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200149B RID: 5275
	[NullableContext(1)]
	[Nullable(0)]
	public class AdjustPlayerCamera : ActionParams
	{
		// Token: 0x06007822 RID: 30754 RVA: 0x00120358 File Offset: 0x0011E558
		private AdjustPlayerCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdjustPlayerCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdjustPlayerCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdjustPlayerCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00120390 File Offset: 0x0011E590
		public static AdjustPlayerCamera Create([Nullable(2)] AdjustPlayerCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x001203A3 File Offset: 0x0011E5A3
		public static AdjustPlayerCamera CreateFromSetValue([Nullable(2)] AdjustPlayerCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x001203B6 File Offset: 0x0011E5B6
		public AdjustPlayerCamera_SetValue ToSetValue()
		{
			return new AdjustPlayerCamera_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x001203C9 File Offset: 0x0011E5C9
		// (set) Token: 0x06007827 RID: 30759 RVA: 0x001203F0 File Offset: 0x0011E5F0
		public virtual IAdjustPlayerCameraType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				AdjustPlayerCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x040045DA RID: 17882
		[Nullable(2)]
		protected new AdjustPlayerCamera FbInstance;

		// Token: 0x040045DB RID: 17883
		[Nullable(2)]
		protected AdjustPlayerCamera_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FE RID: 1790
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineType
	{
		// Token: 0x0600268C RID: 9868 RVA: 0x00067080 File Offset: 0x00065280
		private ISplineType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineType_SetValue());
			}
			return result;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000670B8 File Offset: 0x000652B8
		public static ISplineType Create([Nullable(2)] ISplineType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000670CB File Offset: 0x000652CB
		public static ISplineType CreateFromSetValue([Nullable(2)] ISplineType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000670DE File Offset: 0x000652DE
		public ISplineType_SetValue ToSetValue()
		{
			return new ISplineType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x000670F1 File Offset: 0x000652F1
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0006711C File Offset: 0x0006531C
		public virtual ESplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A22 RID: 6690
		[Nullable(2)]
		protected ISplineType FbInstance;

		// Token: 0x04001A23 RID: 6691
		[Nullable(2)]
		protected ISplineType_SetValue PocoInterface;
	}
}

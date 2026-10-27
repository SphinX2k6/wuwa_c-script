using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD2 RID: 7634
	[NullableContext(1)]
	[Nullable(0)]
	public class IScaleMapData
	{
		// Token: 0x0600A377 RID: 41847 RVA: 0x00173284 File Offset: 0x00171484
		private IScaleMapData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IScaleMapData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IScaleMapData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IScaleMapData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x001732BC File Offset: 0x001714BC
		public static IScaleMapData Create([Nullable(2)] IScaleMapData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScaleMapData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x001732CF File Offset: 0x001714CF
		public static IScaleMapData CreateFromSetValue([Nullable(2)] IScaleMapData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IScaleMapData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x001732E2 File Offset: 0x001714E2
		public IScaleMapData_SetValue ToSetValue()
		{
			return new IScaleMapData_SetValue
			{
				Key = this.Key,
				Scale = this.Scale
			};
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A37B RID: 41851 RVA: 0x00173301 File Offset: 0x00171501
		// (set) Token: 0x0600A37C RID: 41852 RVA: 0x0017332C File Offset: 0x0017152C
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A37D RID: 41853 RVA: 0x0017333A File Offset: 0x0017153A
		// (set) Token: 0x0600A37E RID: 41854 RVA: 0x00173369 File Offset: 0x00171569
		public virtual float Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x04006200 RID: 25088
		[Nullable(2)]
		protected IScaleMapData FbInstance;

		// Token: 0x04006201 RID: 25089
		[Nullable(2)]
		protected IScaleMapData_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FEB RID: 8171
	public class IScaleMapData
	{
		// Token: 0x0600AD8D RID: 44429 RVA: 0x00187ADC File Offset: 0x00185CDC
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

		// Token: 0x0600AD8E RID: 44430 RVA: 0x00187B14 File Offset: 0x00185D14
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

		// Token: 0x0600AD8F RID: 44431 RVA: 0x00187B27 File Offset: 0x00185D27
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

		// Token: 0x0600AD90 RID: 44432 RVA: 0x00187B3A File Offset: 0x00185D3A
		public IScaleMapData_SetValue ToSetValue()
		{
			return new IScaleMapData_SetValue
			{
				Key = this.Key,
				Scale = this.Scale
			};
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600AD91 RID: 44433 RVA: 0x00187B59 File Offset: 0x00185D59
		// (set) Token: 0x0600AD92 RID: 44434 RVA: 0x00187B84 File Offset: 0x00185D84
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

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600AD93 RID: 44435 RVA: 0x00187B92 File Offset: 0x00185D92
		// (set) Token: 0x0600AD94 RID: 44436 RVA: 0x00187BC1 File Offset: 0x00185DC1
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

		// Token: 0x0400678D RID: 26509
		[Nullable(2)]
		protected IScaleMapData FbInstance;

		// Token: 0x0400678E RID: 26510
		[Nullable(2)]
		protected IScaleMapData_SetValue PocoInterface;
	}
}

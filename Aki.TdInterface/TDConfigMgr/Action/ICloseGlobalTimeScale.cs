using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A69 RID: 6761
	public class ICloseGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x06008FAB RID: 36779 RVA: 0x001525F8 File Offset: 0x001507F8
		private ICloseGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x06008FAC RID: 36780 RVA: 0x00152630 File Offset: 0x00150830
		public static ICloseGlobalTimeScale Create([Nullable(2)] ICloseGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x00152643 File Offset: 0x00150843
		public static ICloseGlobalTimeScale CreateFromSetValue([Nullable(2)] ICloseGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x00152656 File Offset: 0x00150856
		public new ICloseGlobalTimeScale_SetValue ToSetValue()
		{
			return new ICloseGlobalTimeScale_SetValue
			{
				Type = this.Type,
				TimeScaleCloseSource = this.TimeScaleCloseSource
			};
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x06008FAF RID: 36783 RVA: 0x00152675 File Offset: 0x00150875
		// (set) Token: 0x06008FB0 RID: 36784 RVA: 0x001526A0 File Offset: 0x001508A0
		public override ESetTimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTimeScaleType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x06008FB1 RID: 36785 RVA: 0x001526B0 File Offset: 0x001508B0
		// (set) Token: 0x06008FB2 RID: 36786 RVA: 0x001526EA File Offset: 0x001508EA
		public virtual ETimeScaleCloseSource? TimeScaleCloseSource
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScaleCloseSource;
				}
				ICloseGlobalTimeScale_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimeScaleCloseSource;
			}
			set
			{
				this.GetOrCreatePoco().TimeScaleCloseSource = value;
			}
		}

		// Token: 0x04005A03 RID: 23043
		[Nullable(2)]
		protected new ICloseGlobalTimeScale FbInstance;

		// Token: 0x04005A04 RID: 23044
		[Nullable(2)]
		protected new ICloseGlobalTimeScale_SetValue PocoInterface;
	}
}

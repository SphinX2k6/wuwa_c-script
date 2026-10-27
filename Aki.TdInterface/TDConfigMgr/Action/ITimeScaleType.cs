using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC6 RID: 8134
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScaleType
	{
		// Token: 0x0600B2EE RID: 45806 RVA: 0x001A0CD8 File Offset: 0x0019EED8
		private ITimeScaleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScaleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScaleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScaleType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x001A0D10 File Offset: 0x0019EF10
		public static ITimeScaleType Create([Nullable(2)] ITimeScaleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x001A0D23 File Offset: 0x0019EF23
		public static ITimeScaleType CreateFromSetValue([Nullable(2)] ITimeScaleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x001A0D36 File Offset: 0x0019EF36
		public ITimeScaleType_SetValue ToSetValue()
		{
			return new ITimeScaleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x001A0D49 File Offset: 0x0019EF49
		// (set) Token: 0x0600B2F3 RID: 45811 RVA: 0x001A0D74 File Offset: 0x0019EF74
		public virtual ETimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScaleType.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C03 RID: 27651
		[Nullable(2)]
		protected ITimeScaleType FbInstance;

		// Token: 0x04006C04 RID: 27652
		[Nullable(2)]
		protected ITimeScaleType_SetValue PocoInterface;
	}
}

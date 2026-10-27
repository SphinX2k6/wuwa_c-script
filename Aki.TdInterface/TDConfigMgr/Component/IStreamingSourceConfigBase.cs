using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072B RID: 1835
	[NullableContext(1)]
	[Nullable(0)]
	public class IStreamingSourceConfigBase
	{
		// Token: 0x060027A1 RID: 10145 RVA: 0x00069614 File Offset: 0x00067814
		private IStreamingSourceConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingSourceConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingSourceConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingSourceConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0006964C File Offset: 0x0006784C
		public static IStreamingSourceConfigBase Create([Nullable(2)] IStreamingSourceConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0006965F File Offset: 0x0006785F
		public static IStreamingSourceConfigBase CreateFromSetValue([Nullable(2)] IStreamingSourceConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00069672 File Offset: 0x00067872
		public IStreamingSourceConfigBase_SetValue ToSetValue()
		{
			return new IStreamingSourceConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00069685 File Offset: 0x00067885
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x000696B0 File Offset: 0x000678B0
		public virtual EStreamingSourceMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStreamingSourceMode.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001ABC RID: 6844
		[Nullable(2)]
		protected IStreamingSourceConfigBase FbInstance;

		// Token: 0x04001ABD RID: 6845
		[Nullable(2)]
		protected IStreamingSourceConfigBase_SetValue PocoInterface;
	}
}

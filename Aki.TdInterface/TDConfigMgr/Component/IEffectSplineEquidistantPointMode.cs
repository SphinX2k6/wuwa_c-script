using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033E RID: 830
	public class IEffectSplineEquidistantPointMode : IEffectSplineCreationMode
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x00037AEC File Offset: 0x00035CEC
		private IEffectSplineEquidistantPointMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSplineEquidistantPointMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSplineEquidistantPointMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSplineEquidistantPointMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00037B24 File Offset: 0x00035D24
		public static IEffectSplineEquidistantPointMode Create([Nullable(2)] IEffectSplineEquidistantPointMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineEquidistantPointMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00037B37 File Offset: 0x00035D37
		public static IEffectSplineEquidistantPointMode CreateFromSetValue([Nullable(2)] IEffectSplineEquidistantPointMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSplineEquidistantPointMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00037B4A File Offset: 0x00035D4A
		public new IEffectSplineEquidistantPointMode_SetValue ToSetValue()
		{
			return new IEffectSplineEquidistantPointMode_SetValue
			{
				Type = this.Type,
				Space = this.Space
			};
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00037B69 File Offset: 0x00035D69
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00037B94 File Offset: 0x00035D94
		public override EEffectSplineCreateMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00037BA2 File Offset: 0x00035DA2
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00037BCD File Offset: 0x00035DCD
		public virtual int Space
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Space;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Space;
			}
			set
			{
				this.GetOrCreatePoco().Space = value;
			}
		}

		// Token: 0x04000DCC RID: 3532
		[Nullable(2)]
		protected new IEffectSplineEquidistantPointMode FbInstance;

		// Token: 0x04000DCD RID: 3533
		[Nullable(2)]
		protected new IEffectSplineEquidistantPointMode_SetValue PocoInterface;
	}
}

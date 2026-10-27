using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001810 RID: 6160
	[NullableContext(2)]
	[Nullable(0)]
	public class IBlendFunction
	{
		// Token: 0x06008435 RID: 33845 RVA: 0x0013B194 File Offset: 0x00139394
		[NullableContext(1)]
		private IBlendFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBlendFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBlendFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBlendFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x0013B1CC File Offset: 0x001393CC
		[NullableContext(1)]
		public static IBlendFunction Create([Nullable(2)] IBlendFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x0013B1DF File Offset: 0x001393DF
		[NullableContext(1)]
		public static IBlendFunction CreateFromSetValue([Nullable(2)] IBlendFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBlendFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x0013B1F2 File Offset: 0x001393F2
		[NullableContext(1)]
		public IBlendFunction_SetValue ToSetValue()
		{
			return new IBlendFunction_SetValue
			{
				Type = this.Type,
				BlendExp = this.BlendExp,
				CurveAsset = this.CurveAsset
			};
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x0013B21D File Offset: 0x0013941D
		// (set) Token: 0x0600843A RID: 33850 RVA: 0x0013B248 File Offset: 0x00139448
		public virtual EViewTargetBlendFunction Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewTargetBlendFunction.Linear;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x0013B256 File Offset: 0x00139456
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x0013B285 File Offset: 0x00139485
		public virtual float BlendExp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendExp;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BlendExp;
			}
			set
			{
				this.GetOrCreatePoco().BlendExp = value;
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x0013B293 File Offset: 0x00139493
		// (set) Token: 0x0600843E RID: 33854 RVA: 0x0013B2BA File Offset: 0x001394BA
		public virtual string CurveAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CurveAsset;
				}
				IBlendFunction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CurveAsset;
			}
			set
			{
				this.GetOrCreatePoco().CurveAsset = value;
			}
		}

		// Token: 0x040053B6 RID: 21430
		protected IBlendFunction FbInstance;

		// Token: 0x040053B7 RID: 21431
		protected IBlendFunction_SetValue PocoInterface;
	}
}

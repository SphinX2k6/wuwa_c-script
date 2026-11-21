using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199B RID: 6555
	public class IBlendFunction
	{
		// Token: 0x06008B59 RID: 35673 RVA: 0x0014A938 File Offset: 0x00148B38
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

		// Token: 0x06008B5A RID: 35674 RVA: 0x0014A970 File Offset: 0x00148B70
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

		// Token: 0x06008B5B RID: 35675 RVA: 0x0014A983 File Offset: 0x00148B83
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

		// Token: 0x06008B5C RID: 35676 RVA: 0x0014A996 File Offset: 0x00148B96
		public IBlendFunction_SetValue ToSetValue()
		{
			return new IBlendFunction_SetValue
			{
				Type = this.Type,
				BlendExp = this.BlendExp,
				CurveAsset = this.CurveAsset
			};
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x06008B5D RID: 35677 RVA: 0x0014A9C1 File Offset: 0x00148BC1
		// (set) Token: 0x06008B5E RID: 35678 RVA: 0x0014A9EC File Offset: 0x00148BEC
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

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x06008B5F RID: 35679 RVA: 0x0014A9FA File Offset: 0x00148BFA
		// (set) Token: 0x06008B60 RID: 35680 RVA: 0x0014AA29 File Offset: 0x00148C29
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

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x06008B61 RID: 35681 RVA: 0x0014AA37 File Offset: 0x00148C37
		// (set) Token: 0x06008B62 RID: 35682 RVA: 0x0014AA5E File Offset: 0x00148C5E
		[Nullable(2)]
		public virtual string CurveAsset
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CurveAsset = value;
			}
		}

		// Token: 0x04005801 RID: 22529
		[Nullable(2)]
		protected IBlendFunction FbInstance;

		// Token: 0x04005802 RID: 22530
		[Nullable(2)]
		protected IBlendFunction_SetValue PocoInterface;
	}
}

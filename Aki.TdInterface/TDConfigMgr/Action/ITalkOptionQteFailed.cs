using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B5 RID: 8629
	public class ITalkOptionQteFailed : ITalkOptionParamType
	{
		// Token: 0x0600BC24 RID: 48164 RVA: 0x001B3C80 File Offset: 0x001B1E80
		private ITalkOptionQteFailed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteFailed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteFailed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteFailed_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x001B3CB8 File Offset: 0x001B1EB8
		public static ITalkOptionQteFailed Create([Nullable(2)] ITalkOptionQteFailed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x001B3CCB File Offset: 0x001B1ECB
		public static ITalkOptionQteFailed CreateFromSetValue([Nullable(2)] ITalkOptionQteFailed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x001B3CDE File Offset: 0x001B1EDE
		public new ITalkOptionQteFailed_SetValue ToSetValue()
		{
			return new ITalkOptionQteFailed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x001B3CF1 File Offset: 0x001B1EF1
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x001B3D1C File Offset: 0x001B1F1C
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007125 RID: 28965
		[Nullable(2)]
		protected new ITalkOptionQteFailed FbInstance;

		// Token: 0x04007126 RID: 28966
		[Nullable(2)]
		protected new ITalkOptionQteFailed_SetValue PocoInterface;
	}
}

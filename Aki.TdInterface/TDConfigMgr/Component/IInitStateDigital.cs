using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C3 RID: 1219
	public class IInitStateDigital : IInitState
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x00049A58 File Offset: 0x00047C58
		private IInitStateDigital_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateDigital 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateDigital_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateDigital_SetValue());
			}
			return result;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00049A90 File Offset: 0x00047C90
		public static IInitStateDigital Create([Nullable(2)] IInitStateDigital instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00049AA3 File Offset: 0x00047CA3
		public static IInitStateDigital CreateFromSetValue([Nullable(2)] IInitStateDigital_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00049AB6 File Offset: 0x00047CB6
		public new IInitStateDigital_SetValue ToSetValue()
		{
			return new IInitStateDigital_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00049AC9 File Offset: 0x00047CC9
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x00049AF4 File Offset: 0x00047CF4
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001266 RID: 4710
		[Nullable(2)]
		protected new IInitStateDigital FbInstance;

		// Token: 0x04001267 RID: 4711
		[Nullable(2)]
		protected new IInitStateDigital_SetValue PocoInterface;
	}
}

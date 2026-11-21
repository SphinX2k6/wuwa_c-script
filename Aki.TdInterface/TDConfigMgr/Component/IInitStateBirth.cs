using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C1 RID: 1217
	public class IInitStateBirth : IInitState
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x00049958 File Offset: 0x00047B58
		private IInitStateBirth_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateBirth 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateBirth_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateBirth_SetValue());
			}
			return result;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00049990 File Offset: 0x00047B90
		public static IInitStateBirth Create([Nullable(2)] IInitStateBirth instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000499A3 File Offset: 0x00047BA3
		public static IInitStateBirth CreateFromSetValue([Nullable(2)] IInitStateBirth_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000499B6 File Offset: 0x00047BB6
		public new IInitStateBirth_SetValue ToSetValue()
		{
			return new IInitStateBirth_SetValue
			{
				Type = this.Type,
				BirthTag = this.BirthTag
			};
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x000499D5 File Offset: 0x00047BD5
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x00049A00 File Offset: 0x00047C00
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00049A0E File Offset: 0x00047C0E
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x00049A39 File Offset: 0x00047C39
		public virtual string BirthTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BirthTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BirthTag;
			}
			set
			{
				this.GetOrCreatePoco().BirthTag = value;
			}
		}

		// Token: 0x04001262 RID: 4706
		[Nullable(2)]
		protected new IInitStateBirth FbInstance;

		// Token: 0x04001263 RID: 4707
		[Nullable(2)]
		protected new IInitStateBirth_SetValue PocoInterface;
	}
}

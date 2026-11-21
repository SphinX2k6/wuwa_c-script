using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFF RID: 7935
	public class IPhotographPlayerPerform
	{
		// Token: 0x0600A8DB RID: 43227 RVA: 0x0017F860 File Offset: 0x0017DA60
		private IPhotographPlayerPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographPlayerPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographPlayerPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographPlayerPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x0017F898 File Offset: 0x0017DA98
		public static IPhotographPlayerPerform Create([Nullable(2)] IPhotographPlayerPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographPlayerPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x0017F8AB File Offset: 0x0017DAAB
		public static IPhotographPlayerPerform CreateFromSetValue([Nullable(2)] IPhotographPlayerPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographPlayerPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x0017F8BE File Offset: 0x0017DABE
		public IPhotographPlayerPerform_SetValue ToSetValue()
		{
			return new IPhotographPlayerPerform_SetValue
			{
				MontageId = this.MontageId,
				FaceId = this.FaceId
			};
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x0017F8E0 File Offset: 0x0017DAE0
		// (set) Token: 0x0600A8E0 RID: 43232 RVA: 0x0017F91A File Offset: 0x0017DB1A
		public virtual int? MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				IPhotographPlayerPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x0017F928 File Offset: 0x0017DB28
		// (set) Token: 0x0600A8E2 RID: 43234 RVA: 0x0017F962 File Offset: 0x0017DB62
		public virtual int? FaceId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceId;
				}
				IPhotographPlayerPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceId;
			}
			set
			{
				this.GetOrCreatePoco().FaceId = value;
			}
		}

		// Token: 0x04006578 RID: 25976
		[Nullable(2)]
		protected IPhotographPlayerPerform FbInstance;

		// Token: 0x04006579 RID: 25977
		[Nullable(2)]
		protected IPhotographPlayerPerform_SetValue PocoInterface;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014FF RID: 5375
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientModifyTargetTag : ActionParams
	{
		// Token: 0x06007A30 RID: 31280 RVA: 0x00123E6C File Offset: 0x0012206C
		private ClientModifyTargetTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientModifyTargetTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientModifyTargetTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientModifyTargetTag_SetValue());
			}
			return result;
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x00123EA4 File Offset: 0x001220A4
		public static ClientModifyTargetTag Create([Nullable(2)] ClientModifyTargetTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientModifyTargetTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x00123EB7 File Offset: 0x001220B7
		public static ClientModifyTargetTag CreateFromSetValue([Nullable(2)] ClientModifyTargetTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientModifyTargetTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x00123ECA File Offset: 0x001220CA
		public ClientModifyTargetTag_SetValue ToSetValue()
		{
			return new ClientModifyTargetTag_SetValue
			{
				IsAddTag = this.IsAddTag,
				Target = this.Target,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x00123EF5 File Offset: 0x001220F5
		// (set) Token: 0x06007A35 RID: 31285 RVA: 0x00123F20 File Offset: 0x00122120
		public virtual bool IsAddTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAddTag;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAddTag;
			}
			set
			{
				this.GetOrCreatePoco().IsAddTag = value;
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06007A36 RID: 31286 RVA: 0x00123F2E File Offset: 0x0012212E
		// (set) Token: 0x06007A37 RID: 31287 RVA: 0x00123F55 File Offset: 0x00122155
		public virtual IClientModifyTarget Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ClientModifyTargetTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x06007A38 RID: 31288 RVA: 0x00123F63 File Offset: 0x00122163
		// (set) Token: 0x06007A39 RID: 31289 RVA: 0x00123F8A File Offset: 0x0012218A
		public virtual List<string> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				ClientModifyTargetTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformanceTag;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceTag = value;
			}
		}

		// Token: 0x040046CD RID: 18125
		[Nullable(2)]
		protected new ClientModifyTargetTag FbInstance;

		// Token: 0x040046CE RID: 18126
		[Nullable(2)]
		protected ClientModifyTargetTag_SetValue PocoInterface;
	}
}

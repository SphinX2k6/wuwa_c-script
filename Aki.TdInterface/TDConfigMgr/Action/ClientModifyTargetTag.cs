using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165A RID: 5722
	public class ClientModifyTargetTag : ActionParams
	{
		// Token: 0x06008103 RID: 33027 RVA: 0x00132B4C File Offset: 0x00130D4C
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

		// Token: 0x06008104 RID: 33028 RVA: 0x00132B84 File Offset: 0x00130D84
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

		// Token: 0x06008105 RID: 33029 RVA: 0x00132B97 File Offset: 0x00130D97
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

		// Token: 0x06008106 RID: 33030 RVA: 0x00132BAA File Offset: 0x00130DAA
		public ClientModifyTargetTag_SetValue ToSetValue()
		{
			return new ClientModifyTargetTag_SetValue
			{
				IsAddTag = this.IsAddTag,
				Target = this.Target,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x06008107 RID: 33031 RVA: 0x00132BD5 File Offset: 0x00130DD5
		// (set) Token: 0x06008108 RID: 33032 RVA: 0x00132C00 File Offset: 0x00130E00
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

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x06008109 RID: 33033 RVA: 0x00132C0E File Offset: 0x00130E0E
		// (set) Token: 0x0600810A RID: 33034 RVA: 0x00132C35 File Offset: 0x00130E35
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

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x00132C43 File Offset: 0x00130E43
		// (set) Token: 0x0600810C RID: 33036 RVA: 0x00132C6A File Offset: 0x00130E6A
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

		// Token: 0x04004A6C RID: 19052
		[Nullable(2)]
		protected new ClientModifyTargetTag FbInstance;

		// Token: 0x04004A6D RID: 19053
		[Nullable(2)]
		protected ClientModifyTargetTag_SetValue PocoInterface;
	}
}

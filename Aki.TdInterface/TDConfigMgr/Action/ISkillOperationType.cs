using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B4 RID: 8372
	[JsonConverter(typeof(ISkillOperationTypeConverter))]
	public class ISkillOperationType
	{
		// Token: 0x0600B1C8 RID: 45512 RVA: 0x0018F9E0 File Offset: 0x0018DBE0
		private ISkillOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkillOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkillOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkillOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x0018FA18 File Offset: 0x0018DC18
		public static ISkillOperationType Create([Nullable(2)] ISkillOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x0018FA2B File Offset: 0x0018DC2B
		public static ISkillOperationType CreateFromSetValue([Nullable(2)] ISkillOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkillOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x0018FA3E File Offset: 0x0018DC3E
		public ISkillOperationType_SetValue ToSetValue()
		{
			return new ISkillOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600B1CC RID: 45516 RVA: 0x0018FA51 File Offset: 0x0018DC51
		// (set) Token: 0x0600B1CD RID: 45517 RVA: 0x0018FA7C File Offset: 0x0018DC7C
		public virtual ESkillOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkillOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400699C RID: 27036
		[Nullable(2)]
		protected ISkillOperationType FbInstance;

		// Token: 0x0400699D RID: 27037
		[Nullable(2)]
		protected ISkillOperationType_SetValue PocoInterface;
	}
}

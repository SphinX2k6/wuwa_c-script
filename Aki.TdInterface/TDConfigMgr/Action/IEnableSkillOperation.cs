using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B83 RID: 7043
	[JsonConverter(typeof(IEnableSkillOperationConverter))]
	public class IEnableSkillOperation : ISkillOperationType
	{
		// Token: 0x060095A9 RID: 38313 RVA: 0x0015CD18 File Offset: 0x0015AF18
		private IEnableSkillOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSkillOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSkillOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSkillOperation_SetValue());
			}
			return result;
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x0015CD50 File Offset: 0x0015AF50
		public static IEnableSkillOperation Create([Nullable(2)] IEnableSkillOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSkillOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x0015CD63 File Offset: 0x0015AF63
		public static IEnableSkillOperation CreateFromSetValue([Nullable(2)] IEnableSkillOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSkillOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x0015CD76 File Offset: 0x0015AF76
		public new IEnableSkillOperation_SetValue ToSetValue()
		{
			return new IEnableSkillOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x0015CD89 File Offset: 0x0015AF89
		// (set) Token: 0x060095AE RID: 38318 RVA: 0x0015CDB4 File Offset: 0x0015AFB4
		public override ESkillOperationType Type
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

		// Token: 0x04005C9D RID: 23709
		[Nullable(2)]
		protected new IEnableSkillOperation FbInstance;

		// Token: 0x04005C9E RID: 23710
		[Nullable(2)]
		protected new IEnableSkillOperation_SetValue PocoInterface;
	}
}

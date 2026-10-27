using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E7F RID: 7807
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ISkillOperationTypeConverter))]
	public class ISkillOperationType
	{
		// Token: 0x0600A710 RID: 42768 RVA: 0x00179CE0 File Offset: 0x00177EE0
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

		// Token: 0x0600A711 RID: 42769 RVA: 0x00179D18 File Offset: 0x00177F18
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

		// Token: 0x0600A712 RID: 42770 RVA: 0x00179D2B File Offset: 0x00177F2B
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

		// Token: 0x0600A713 RID: 42771 RVA: 0x00179D3E File Offset: 0x00177F3E
		public ISkillOperationType_SetValue ToSetValue()
		{
			return new ISkillOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A714 RID: 42772 RVA: 0x00179D51 File Offset: 0x00177F51
		// (set) Token: 0x0600A715 RID: 42773 RVA: 0x00179D7C File Offset: 0x00177F7C
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

		// Token: 0x040063B8 RID: 25528
		[Nullable(2)]
		protected ISkillOperationType FbInstance;

		// Token: 0x040063B9 RID: 25529
		[Nullable(2)]
		protected ISkillOperationType_SetValue PocoInterface;
	}
}

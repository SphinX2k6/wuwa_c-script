using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F0 RID: 6640
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableSkillOperationConverter))]
	public class IEnableSkillOperation : ISkillOperationType
	{
		// Token: 0x06008E47 RID: 36423 RVA: 0x0014CEA8 File Offset: 0x0014B0A8
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

		// Token: 0x06008E48 RID: 36424 RVA: 0x0014CEE0 File Offset: 0x0014B0E0
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

		// Token: 0x06008E49 RID: 36425 RVA: 0x0014CEF3 File Offset: 0x0014B0F3
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

		// Token: 0x06008E4A RID: 36426 RVA: 0x0014CF06 File Offset: 0x0014B106
		public new IEnableSkillOperation_SetValue ToSetValue()
		{
			return new IEnableSkillOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x0014CF19 File Offset: 0x0014B119
		// (set) Token: 0x06008E4C RID: 36428 RVA: 0x0014CF44 File Offset: 0x0014B144
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

		// Token: 0x0400583B RID: 22587
		[Nullable(2)]
		protected new IEnableSkillOperation FbInstance;

		// Token: 0x0400583C RID: 22588
		[Nullable(2)]
		protected new IEnableSkillOperation_SetValue PocoInterface;
	}
}

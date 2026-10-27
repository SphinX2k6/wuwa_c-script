using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D60 RID: 7520
	[NullableContext(1)]
	[Nullable(0)]
	public class IPromptStyleBattle : IPromptStyleBase
	{
		// Token: 0x0600A14B RID: 41291 RVA: 0x0016F84C File Offset: 0x0016DA4C
		private IPromptStyleBattle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStyleBattle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStyleBattle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStyleBattle_SetValue());
			}
			return result;
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x0016F884 File Offset: 0x0016DA84
		public static IPromptStyleBattle Create([Nullable(2)] IPromptStyleBattle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x0016F897 File Offset: 0x0016DA97
		public static IPromptStyleBattle CreateFromSetValue([Nullable(2)] IPromptStyleBattle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStyleBattle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x0016F8AA File Offset: 0x0016DAAA
		public new IPromptStyleBattle_SetValue ToSetValue()
		{
			return new IPromptStyleBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x0016F8BD File Offset: 0x0016DABD
		// (set) Token: 0x0600A150 RID: 41296 RVA: 0x0016F8E8 File Offset: 0x0016DAE8
		public override EPromptStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPromptStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006115 RID: 24853
		[Nullable(2)]
		protected new IPromptStyleBattle FbInstance;

		// Token: 0x04006116 RID: 24854
		[Nullable(2)]
		protected new IPromptStyleBattle_SetValue PocoInterface;
	}
}

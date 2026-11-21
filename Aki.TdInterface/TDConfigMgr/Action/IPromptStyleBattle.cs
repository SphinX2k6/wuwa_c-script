using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F71 RID: 8049
	public class IPromptStyleBattle : IPromptStyleBase
	{
		// Token: 0x0600AB37 RID: 43831 RVA: 0x00183C70 File Offset: 0x00181E70
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

		// Token: 0x0600AB38 RID: 43832 RVA: 0x00183CA8 File Offset: 0x00181EA8
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

		// Token: 0x0600AB39 RID: 43833 RVA: 0x00183CBB File Offset: 0x00181EBB
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

		// Token: 0x0600AB3A RID: 43834 RVA: 0x00183CCE File Offset: 0x00181ECE
		public new IPromptStyleBattle_SetValue ToSetValue()
		{
			return new IPromptStyleBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x00183CE1 File Offset: 0x00181EE1
		// (set) Token: 0x0600AB3C RID: 43836 RVA: 0x00183D0C File Offset: 0x00181F0C
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

		// Token: 0x04006691 RID: 26257
		[Nullable(2)]
		protected new IPromptStyleBattle FbInstance;

		// Token: 0x04006692 RID: 26258
		[Nullable(2)]
		protected new IPromptStyleBattle_SetValue PocoInterface;
	}
}

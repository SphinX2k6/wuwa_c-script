using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D62 RID: 7522
	[NullableContext(1)]
	[Nullable(0)]
	public class IPromptStyleBattle2 : IPromptStyleBase
	{
		// Token: 0x0600A153 RID: 41299 RVA: 0x0016F908 File Offset: 0x0016DB08
		private IPromptStyleBattle2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStyleBattle2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStyleBattle2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStyleBattle2_SetValue());
			}
			return result;
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x0016F940 File Offset: 0x0016DB40
		public static IPromptStyleBattle2 Create([Nullable(2)] IPromptStyleBattle2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x0016F953 File Offset: 0x0016DB53
		public static IPromptStyleBattle2 CreateFromSetValue([Nullable(2)] IPromptStyleBattle2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x0016F966 File Offset: 0x0016DB66
		public new IPromptStyleBattle2_SetValue ToSetValue()
		{
			return new IPromptStyleBattle2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x0016F979 File Offset: 0x0016DB79
		// (set) Token: 0x0600A158 RID: 41304 RVA: 0x0016F9A4 File Offset: 0x0016DBA4
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

		// Token: 0x04006118 RID: 24856
		[Nullable(2)]
		protected new IPromptStyleBattle2 FbInstance;

		// Token: 0x04006119 RID: 24857
		[Nullable(2)]
		protected new IPromptStyleBattle2_SetValue PocoInterface;
	}
}

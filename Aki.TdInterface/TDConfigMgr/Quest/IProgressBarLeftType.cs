using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001063 RID: 4195
	[NullableContext(1)]
	[Nullable(0)]
	public class IProgressBarLeftType
	{
		// Token: 0x06005DFC RID: 24060 RVA: 0x000E3594 File Offset: 0x000E1794
		private IProgressBarLeftType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgressBarLeftType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgressBarLeftType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgressBarLeftType_SetValue());
			}
			return result;
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x000E35CC File Offset: 0x000E17CC
		public static IProgressBarLeftType Create([Nullable(2)] IProgressBarLeftType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x000E35DF File Offset: 0x000E17DF
		public static IProgressBarLeftType CreateFromSetValue([Nullable(2)] IProgressBarLeftType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x000E35F2 File Offset: 0x000E17F2
		public IProgressBarLeftType_SetValue ToSetValue()
		{
			return new IProgressBarLeftType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06005E00 RID: 24064 RVA: 0x000E3605 File Offset: 0x000E1805
		// (set) Token: 0x06005E01 RID: 24065 RVA: 0x000E3630 File Offset: 0x000E1830
		public virtual EProgressBarLeftType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarLeftType.UseCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003896 RID: 14486
		[Nullable(2)]
		protected IProgressBarLeftType FbInstance;

		// Token: 0x04003897 RID: 14487
		[Nullable(2)]
		protected IProgressBarLeftType_SetValue PocoInterface;
	}
}

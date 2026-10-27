using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001192 RID: 4498
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisPlayModeBase
	{
		// Token: 0x06006626 RID: 26150 RVA: 0x000F4F4C File Offset: 0x000F314C
		private ITetrisPlayModeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x000F4F84 File Offset: 0x000F3184
		public static ITetrisPlayModeBase Create([Nullable(2)] ITetrisPlayModeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x000F4F97 File Offset: 0x000F3197
		public static ITetrisPlayModeBase CreateFromSetValue([Nullable(2)] ITetrisPlayModeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x000F4FAA File Offset: 0x000F31AA
		public ITetrisPlayModeBase_SetValue ToSetValue()
		{
			return new ITetrisPlayModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x000F4FBD File Offset: 0x000F31BD
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x000F4FE8 File Offset: 0x000F31E8
		public virtual ETetrisPlayMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisPlayMode.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003D52 RID: 15698
		[Nullable(2)]
		protected ITetrisPlayModeBase FbInstance;

		// Token: 0x04003D53 RID: 15699
		[Nullable(2)]
		protected ITetrisPlayModeBase_SetValue PocoInterface;
	}
}

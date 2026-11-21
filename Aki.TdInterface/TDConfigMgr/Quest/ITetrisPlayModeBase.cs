using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012CC RID: 4812
	public class ITetrisPlayModeBase
	{
		// Token: 0x06006C5D RID: 27741 RVA: 0x00102718 File Offset: 0x00100918
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

		// Token: 0x06006C5E RID: 27742 RVA: 0x00102750 File Offset: 0x00100950
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

		// Token: 0x06006C5F RID: 27743 RVA: 0x00102763 File Offset: 0x00100963
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

		// Token: 0x06006C60 RID: 27744 RVA: 0x00102776 File Offset: 0x00100976
		public ITetrisPlayModeBase_SetValue ToSetValue()
		{
			return new ITetrisPlayModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06006C61 RID: 27745 RVA: 0x00102789 File Offset: 0x00100989
		// (set) Token: 0x06006C62 RID: 27746 RVA: 0x001027B4 File Offset: 0x001009B4
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

		// Token: 0x040040BA RID: 16570
		[Nullable(2)]
		protected ITetrisPlayModeBase FbInstance;

		// Token: 0x040040BB RID: 16571
		[Nullable(2)]
		protected ITetrisPlayModeBase_SetValue PocoInterface;
	}
}

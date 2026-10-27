using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001198 RID: 4504
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisPlayModeNormal : ITetrisPlayModeBase
	{
		// Token: 0x06006646 RID: 26182 RVA: 0x000F52B0 File Offset: 0x000F34B0
		private ITetrisPlayModeNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeNormal_SetValue());
			}
			return result;
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x000F52E8 File Offset: 0x000F34E8
		public static ITetrisPlayModeNormal Create([Nullable(2)] ITetrisPlayModeNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x000F52FB File Offset: 0x000F34FB
		public static ITetrisPlayModeNormal CreateFromSetValue([Nullable(2)] ITetrisPlayModeNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x000F530E File Offset: 0x000F350E
		public new ITetrisPlayModeNormal_SetValue ToSetValue()
		{
			return new ITetrisPlayModeNormal_SetValue
			{
				Type = this.Type,
				Time = this.Time
			};
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x000F532D File Offset: 0x000F352D
		// (set) Token: 0x0600664B RID: 26187 RVA: 0x000F5358 File Offset: 0x000F3558
		public override ETetrisPlayMode Type
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

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x000F5366 File Offset: 0x000F3566
		// (set) Token: 0x0600664D RID: 26189 RVA: 0x000F5391 File Offset: 0x000F3591
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x04003D5F RID: 15711
		[Nullable(2)]
		protected new ITetrisPlayModeNormal FbInstance;

		// Token: 0x04003D60 RID: 15712
		[Nullable(2)]
		protected new ITetrisPlayModeNormal_SetValue PocoInterface;
	}
}

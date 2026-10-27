using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213B RID: 8507
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsChangeBackground : ActionParams
	{
		// Token: 0x0600BB54 RID: 47956 RVA: 0x001B09F4 File Offset: 0x001AEBF4
		private ReignsChangeBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsChangeBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsChangeBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsChangeBackground_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x001B0A2C File Offset: 0x001AEC2C
		public static ReignsChangeBackground Create([Nullable(2)] ReignsChangeBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x001B0A3F File Offset: 0x001AEC3F
		public static ReignsChangeBackground CreateFromSetValue([Nullable(2)] ReignsChangeBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x001B0A52 File Offset: 0x001AEC52
		public ReignsChangeBackground_SetValue ToSetValue()
		{
			return new ReignsChangeBackground_SetValue
			{
				Background = this.Background,
				ChangeMode = this.ChangeMode
			};
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x001B0A71 File Offset: 0x001AEC71
		// (set) Token: 0x0600BB59 RID: 47961 RVA: 0x001B0A9C File Offset: 0x001AEC9C
		public virtual string Background
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Background;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Background;
			}
			set
			{
				this.GetOrCreatePoco().Background = value;
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x001B0AAA File Offset: 0x001AECAA
		// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x001B0AD5 File Offset: 0x001AECD5
		public virtual EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeMode;
				}
				if (this.PocoInterface == null)
				{
					return EReignsBackgroundChangeMode.Instant;
				}
				return this.PocoInterface.ChangeMode;
			}
			set
			{
				this.GetOrCreatePoco().ChangeMode = value;
			}
		}

		// Token: 0x0400700B RID: 28683
		[Nullable(2)]
		protected new ReignsChangeBackground FbInstance;

		// Token: 0x0400700C RID: 28684
		[Nullable(2)]
		protected ReignsChangeBackground_SetValue PocoInterface;
	}
}

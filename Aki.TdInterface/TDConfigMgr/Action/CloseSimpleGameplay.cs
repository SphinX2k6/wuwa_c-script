using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200150F RID: 5391
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseSimpleGameplay : ActionParams
	{
		// Token: 0x06007A84 RID: 31364 RVA: 0x001247F8 File Offset: 0x001229F8
		private CloseSimpleGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CloseSimpleGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CloseSimpleGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CloseSimpleGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00124830 File Offset: 0x00122A30
		public static CloseSimpleGameplay Create([Nullable(2)] CloseSimpleGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseSimpleGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00124843 File Offset: 0x00122A43
		public static CloseSimpleGameplay CreateFromSetValue([Nullable(2)] CloseSimpleGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CloseSimpleGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x00124856 File Offset: 0x00122A56
		public CloseSimpleGameplay_SetValue ToSetValue()
		{
			return new CloseSimpleGameplay_SetValue
			{
				GameplayConfig = this.GameplayConfig
			};
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x00124869 File Offset: 0x00122A69
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x00124890 File Offset: 0x00122A90
		public virtual ICloseUiGame GameplayConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayConfig;
				}
				CloseSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GameplayConfig;
			}
			set
			{
				this.GetOrCreatePoco().GameplayConfig = value;
			}
		}

		// Token: 0x040046F7 RID: 18167
		[Nullable(2)]
		protected new CloseSimpleGameplay FbInstance;

		// Token: 0x040046F8 RID: 18168
		[Nullable(2)]
		protected CloseSimpleGameplay_SetValue PocoInterface;
	}
}

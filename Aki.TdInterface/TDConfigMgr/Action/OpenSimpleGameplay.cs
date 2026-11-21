using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234F RID: 9039
	public class OpenSimpleGameplay : ActionParams
	{
		// Token: 0x0600C4D2 RID: 50386 RVA: 0x001C36E0 File Offset: 0x001C18E0
		private OpenSimpleGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenSimpleGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenSimpleGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenSimpleGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x001C3718 File Offset: 0x001C1918
		public static OpenSimpleGameplay Create([Nullable(2)] OpenSimpleGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSimpleGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x001C372B File Offset: 0x001C192B
		public static OpenSimpleGameplay CreateFromSetValue([Nullable(2)] OpenSimpleGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenSimpleGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x001C373E File Offset: 0x001C193E
		public OpenSimpleGameplay_SetValue ToSetValue()
		{
			return new OpenSimpleGameplay_SetValue
			{
				GameplayConfig = this.GameplayConfig,
				FinishSendSelfEvent = this.FinishSendSelfEvent,
				FailSendSelfEvent = this.FailSendSelfEvent
			};
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x001C3769 File Offset: 0x001C1969
		// (set) Token: 0x0600C4D7 RID: 50391 RVA: 0x001C3790 File Offset: 0x001C1990
		public virtual IUiGame GameplayConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayConfig;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600C4D8 RID: 50392 RVA: 0x001C379E File Offset: 0x001C199E
		// (set) Token: 0x0600C4D9 RID: 50393 RVA: 0x001C37C5 File Offset: 0x001C19C5
		[Nullable(2)]
		public virtual string FinishSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishSendSelfEvent;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishSendSelfEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FinishSendSelfEvent = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600C4DA RID: 50394 RVA: 0x001C37D3 File Offset: 0x001C19D3
		// (set) Token: 0x0600C4DB RID: 50395 RVA: 0x001C37FA File Offset: 0x001C19FA
		[Nullable(2)]
		public virtual string FailSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FailSendSelfEvent;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FailSendSelfEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FailSendSelfEvent = value;
			}
		}

		// Token: 0x04007527 RID: 29991
		[Nullable(2)]
		protected new OpenSimpleGameplay FbInstance;

		// Token: 0x04007528 RID: 29992
		[Nullable(2)]
		protected OpenSimpleGameplay_SetValue PocoInterface;
	}
}

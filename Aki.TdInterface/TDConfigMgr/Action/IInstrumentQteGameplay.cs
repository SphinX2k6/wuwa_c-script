using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B42 RID: 6978
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteGameplay : IUiGame
	{
		// Token: 0x06009555 RID: 38229 RVA: 0x00159498 File Offset: 0x00157698
		private IInstrumentQteGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentQteGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentQteGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentQteGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x001594D0 File Offset: 0x001576D0
		public static IInstrumentQteGameplay Create([Nullable(2)] IInstrumentQteGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x001594E3 File Offset: 0x001576E3
		public static IInstrumentQteGameplay CreateFromSetValue([Nullable(2)] IInstrumentQteGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x001594F6 File Offset: 0x001576F6
		public new IInstrumentQteGameplay_SetValue ToSetValue()
		{
			return new IInstrumentQteGameplay_SetValue
			{
				Type = this.Type,
				InstrumentType = this.InstrumentType,
				Id = this.Id
			};
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x00159521 File Offset: 0x00157721
		// (set) Token: 0x0600955A RID: 38234 RVA: 0x0015954C File Offset: 0x0015774C
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x0015955A File Offset: 0x0015775A
		// (set) Token: 0x0600955C RID: 38236 RVA: 0x00159585 File Offset: 0x00157785
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InstrumentType;
				}
				if (this.PocoInterface == null)
				{
					return EInstrumentType.ChineseZither;
				}
				return this.PocoInterface.InstrumentType;
			}
			set
			{
				this.GetOrCreatePoco().InstrumentType = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00159593 File Offset: 0x00157793
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x001595BE File Offset: 0x001577BE
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005B65 RID: 23397
		[Nullable(2)]
		protected new IInstrumentQteGameplay FbInstance;

		// Token: 0x04005B66 RID: 23398
		[Nullable(2)]
		protected new IInstrumentQteGameplay_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C62 RID: 7266
	public class IFrequencyDetectionTip : ICommonTipType
	{
		// Token: 0x06009A86 RID: 39558 RVA: 0x00165900 File Offset: 0x00163B00
		private IFrequencyDetectionTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyDetectionTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyDetectionTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyDetectionTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x00165938 File Offset: 0x00163B38
		public static IFrequencyDetectionTip Create([Nullable(2)] IFrequencyDetectionTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyDetectionTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x0016594B File Offset: 0x00163B4B
		public static IFrequencyDetectionTip CreateFromSetValue([Nullable(2)] IFrequencyDetectionTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyDetectionTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x0016595E File Offset: 0x00163B5E
		public new IFrequencyDetectionTip_SetValue ToSetValue()
		{
			return new IFrequencyDetectionTip_SetValue
			{
				Type = this.Type,
				Content = this.Content
			};
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x0016597D File Offset: 0x00163B7D
		// (set) Token: 0x06009A8B RID: 39563 RVA: 0x001659A8 File Offset: 0x00163BA8
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06009A8C RID: 39564 RVA: 0x001659B8 File Offset: 0x00163BB8
		// (set) Token: 0x06009A8D RID: 39565 RVA: 0x00165A19 File Offset: 0x00163C19
		public virtual ICommonTalkMessage Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				if (this.FbInstance != null)
				{
					this._ContentCache = ICommonTalkMessage.Create(this.FbInstance.Content);
				}
				else
				{
					IFrequencyDetectionTip_SetValue pocoInterface = this.PocoInterface;
					this._ContentCache = ((pocoInterface != null) ? pocoInterface.Content : null);
				}
				return this._ContentCache;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
				this._ContentInited = false;
			}
		}

		// Token: 0x04005EDC RID: 24284
		[Nullable(2)]
		protected new IFrequencyDetectionTip FbInstance;

		// Token: 0x04005EDD RID: 24285
		[Nullable(2)]
		protected new IFrequencyDetectionTip_SetValue PocoInterface;

		// Token: 0x04005EDE RID: 24286
		private ICommonTalkMessage _ContentCache;

		// Token: 0x04005EDF RID: 24287
		private bool _ContentInited;
	}
}

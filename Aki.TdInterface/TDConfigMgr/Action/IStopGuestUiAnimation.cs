using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EBF RID: 7871
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600A882 RID: 43138 RVA: 0x0017C770 File Offset: 0x0017A970
		private IStopGuestUiAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopGuestUiAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopGuestUiAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopGuestUiAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x0017C7A8 File Offset: 0x0017A9A8
		public static IStopGuestUiAnimation Create([Nullable(2)] IStopGuestUiAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x0017C7BB File Offset: 0x0017A9BB
		public static IStopGuestUiAnimation CreateFromSetValue([Nullable(2)] IStopGuestUiAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopGuestUiAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x0017C7CE File Offset: 0x0017A9CE
		public new IStopGuestUiAnimation_SetValue ToSetValue()
		{
			return new IStopGuestUiAnimation_SetValue
			{
				Type = this.Type,
				StopGuestUiAnimation = this.StopGuestUiAnimation
			};
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x0017C7ED File Offset: 0x0017A9ED
		// (set) Token: 0x0600A887 RID: 43143 RVA: 0x0017C818 File Offset: 0x0017AA18
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGuestOperateUiAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x0017C828 File Offset: 0x0017AA28
		// (set) Token: 0x0600A889 RID: 43145 RVA: 0x0017C889 File Offset: 0x0017AA89
		public virtual IStopGuestCartethyia StopGuestUiAnimation
		{
			get
			{
				if (this._StopGuestUiAnimationInited)
				{
					return this._StopGuestUiAnimationCache;
				}
				this._StopGuestUiAnimationInited = true;
				if (this.FbInstance != null)
				{
					this._StopGuestUiAnimationCache = IStopGuestCartethyia.Create(this.FbInstance.StopGuestUiAnimation);
				}
				else
				{
					IStopGuestUiAnimation_SetValue pocoInterface = this.PocoInterface;
					this._StopGuestUiAnimationCache = ((pocoInterface != null) ? pocoInterface.StopGuestUiAnimation : null);
				}
				return this._StopGuestUiAnimationCache;
			}
			set
			{
				this.GetOrCreatePoco().StopGuestUiAnimation = value;
				this._StopGuestUiAnimationInited = false;
			}
		}

		// Token: 0x04006463 RID: 25699
		[Nullable(2)]
		protected new IStopGuestUiAnimation FbInstance;

		// Token: 0x04006464 RID: 25700
		[Nullable(2)]
		protected new IStopGuestUiAnimation_SetValue PocoInterface;

		// Token: 0x04006465 RID: 25701
		private IStopGuestCartethyia _StopGuestUiAnimationCache;

		// Token: 0x04006466 RID: 25702
		private bool _StopGuestUiAnimationInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A3 RID: 8611
	[NullableContext(1)]
	[Nullable(0)]
	public class SetBlendAnim : ActionParams
	{
		// Token: 0x0600BD16 RID: 48406 RVA: 0x001B3908 File Offset: 0x001B1B08
		private SetBlendAnim_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetBlendAnim 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetBlendAnim_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetBlendAnim_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x001B3940 File Offset: 0x001B1B40
		public static SetBlendAnim Create([Nullable(2)] SetBlendAnim instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBlendAnim
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x001B3953 File Offset: 0x001B1B53
		public static SetBlendAnim CreateFromSetValue([Nullable(2)] SetBlendAnim_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetBlendAnim
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x001B3966 File Offset: 0x001B1B66
		public SetBlendAnim_SetValue ToSetValue()
		{
			return new SetBlendAnim_SetValue
			{
				Target = this.Target,
				BlendType = this.BlendType
			};
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600BD1A RID: 48410 RVA: 0x001B3988 File Offset: 0x001B1B88
		// (set) Token: 0x0600BD1B RID: 48411 RVA: 0x001B39E9 File Offset: 0x001B1BE9
		public virtual IPlayerBlendAnimTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCache = IPlayerBlendAnimTarget.Create(this.FbInstance.Target);
				}
				else
				{
					SetBlendAnim_SetValue pocoInterface = this.PocoInterface;
					this._TargetCache = ((pocoInterface != null) ? pocoInterface.Target : null);
				}
				return this._TargetCache;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
				this._TargetInited = false;
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600BD1C RID: 48412 RVA: 0x001B39FE File Offset: 0x001B1BFE
		// (set) Token: 0x0600BD1D RID: 48413 RVA: 0x001B3A25 File Offset: 0x001B1C25
		public virtual IBlendAnimTypeBase BlendType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendType;
				}
				SetBlendAnim_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlendType;
			}
			set
			{
				this.GetOrCreatePoco().BlendType = value;
			}
		}

		// Token: 0x040070D8 RID: 28888
		[Nullable(2)]
		protected new SetBlendAnim FbInstance;

		// Token: 0x040070D9 RID: 28889
		[Nullable(2)]
		protected SetBlendAnim_SetValue PocoInterface;

		// Token: 0x040070DA RID: 28890
		private IPlayerBlendAnimTarget _TargetCache;

		// Token: 0x040070DB RID: 28891
		private bool _TargetInited;
	}
}

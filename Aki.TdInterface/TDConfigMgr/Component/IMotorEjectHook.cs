using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000522 RID: 1314
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorEjectHook : IHookInteractType
	{
		// Token: 0x06001A9C RID: 6812 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		[NullableContext(1)]
		private IMotorEjectHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorEjectHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorEjectHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorEjectHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0004D528 File Offset: 0x0004B728
		[NullableContext(1)]
		public static IMotorEjectHook Create([Nullable(2)] IMotorEjectHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorEjectHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0004D53B File Offset: 0x0004B73B
		[NullableContext(1)]
		public static IMotorEjectHook CreateFromSetValue([Nullable(2)] IMotorEjectHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorEjectHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0004D550 File Offset: 0x0004B750
		[NullableContext(1)]
		public new IMotorEjectHook_SetValue ToSetValue()
		{
			return new IMotorEjectHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				MinPitchAngle = this.MinPitchAngle,
				DefaultPitchAngle = this.DefaultPitchAngle,
				MaxPitchAngle = this.MaxPitchAngle,
				MaxYawAngleDelta = this.MaxYawAngleDelta,
				MaxEjectDistance = this.MaxEjectDistance,
				InterpSpeed = this.InterpSpeed,
				AutoEjectConfig = this.AutoEjectConfig
			};
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0004D5F2 File Offset: 0x0004B7F2
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0004D61D File Offset: 0x0004B81D
		public override EHookInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookInteractType.FixedPointHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0004D62C File Offset: 0x0004B82C
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0004D6BF File Offset: 0x0004B8BF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._HookActionsInited)
				{
					return this._HookActionsCache;
				}
				this._HookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> hookActions = this.FbInstance.HookActions;
					if (hookActions != null)
					{
						this._HookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(hookActions.Count);
						for (int i = 0; i < hookActions.Count; i++)
						{
							this._HookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(hookActions[i]));
						}
					}
				}
				else
				{
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
					this._HookActionsCache = ((pocoInterface != null) ? pocoInterface.HookActions : null);
				}
				return this._HookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().HookActions = value;
				this._HookActionsInited = false;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0004D767 File Offset: 0x0004B967
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ExitHookActionsInited)
				{
					return this._ExitHookActionsCache;
				}
				this._ExitHookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> exitHookActions = this.FbInstance.ExitHookActions;
					if (exitHookActions != null)
					{
						this._ExitHookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(exitHookActions.Count);
						for (int i = 0; i < exitHookActions.Count; i++)
						{
							this._ExitHookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(exitHookActions[i]));
						}
					}
				}
				else
				{
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
					this._ExitHookActionsCache = ((pocoInterface != null) ? pocoInterface.ExitHookActions : null);
				}
				return this._ExitHookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExitHookActions = value;
				this._ExitHookActionsInited = false;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0004D77C File Offset: 0x0004B97C
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0004D80F File Offset: 0x0004BA0F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._FinishActionsInited)
				{
					return this._FinishActionsCache;
				}
				this._FinishActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> finishActions = this.FbInstance.FinishActions;
					if (finishActions != null)
					{
						this._FinishActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(finishActions.Count);
						for (int i = 0; i < finishActions.Count; i++)
						{
							this._FinishActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(finishActions[i]));
						}
					}
				}
				else
				{
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
					this._FinishActionsCache = ((pocoInterface != null) ? pocoInterface.FinishActions : null);
				}
				return this._FinishActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().FinishActions = value;
				this._FinishActionsInited = false;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0004D824 File Offset: 0x0004BA24
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0004D885 File Offset: 0x0004BA85
		public override IClientHookActionConfig ClientHookActionConfig
		{
			get
			{
				if (this._ClientHookActionConfigInited)
				{
					return this._ClientHookActionConfigCache;
				}
				this._ClientHookActionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.FbInstance.ClientHookActionConfig);
				}
				else
				{
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
					this._ClientHookActionConfigCache = ((pocoInterface != null) ? pocoInterface.ClientHookActionConfig : null);
				}
				return this._ClientHookActionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ClientHookActionConfig = value;
				this._ClientHookActionConfigInited = false;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0004D89A File Offset: 0x0004BA9A
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0004D8C9 File Offset: 0x0004BAC9
		public virtual float MinPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().MinPitchAngle = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0004D8D7 File Offset: 0x0004BAD7
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0004D906 File Offset: 0x0004BB06
		public virtual float DefaultPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DefaultPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().DefaultPitchAngle = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0004D914 File Offset: 0x0004BB14
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0004D943 File Offset: 0x0004BB43
		public virtual float MaxPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().MaxPitchAngle = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0004D951 File Offset: 0x0004BB51
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0004D980 File Offset: 0x0004BB80
		public virtual float MaxYawAngleDelta
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxYawAngleDelta;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxYawAngleDelta;
			}
			set
			{
				this.GetOrCreatePoco().MaxYawAngleDelta = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0004D98E File Offset: 0x0004BB8E
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0004D9BD File Offset: 0x0004BBBD
		public virtual float MaxEjectDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxEjectDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxEjectDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxEjectDistance = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0004D9CB File Offset: 0x0004BBCB
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0004D9FA File Offset: 0x0004BBFA
		public virtual float InterpSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InterpSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InterpSpeed;
			}
			set
			{
				this.GetOrCreatePoco().InterpSpeed = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0004DA08 File Offset: 0x0004BC08
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0004DA2F File Offset: 0x0004BC2F
		public virtual IMotorAutoEjectConfigBase AutoEjectConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoEjectConfig;
				}
				IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoEjectConfig;
			}
			set
			{
				this.GetOrCreatePoco().AutoEjectConfig = value;
			}
		}

		// Token: 0x04001338 RID: 4920
		protected new IMotorEjectHook FbInstance;

		// Token: 0x04001339 RID: 4921
		protected new IMotorEjectHook_SetValue PocoInterface;

		// Token: 0x0400133A RID: 4922
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x0400133B RID: 4923
		private bool _HookActionsInited;

		// Token: 0x0400133C RID: 4924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400133D RID: 4925
		private bool _ExitHookActionsInited;

		// Token: 0x0400133E RID: 4926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x0400133F RID: 4927
		private bool _FinishActionsInited;

		// Token: 0x04001340 RID: 4928
		[Nullable(1)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001341 RID: 4929
		private bool _ClientHookActionConfigInited;
	}
}

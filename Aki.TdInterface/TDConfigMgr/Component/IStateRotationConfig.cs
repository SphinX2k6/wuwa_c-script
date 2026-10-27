using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200071B RID: 1819
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRotationConfig
	{
		// Token: 0x0600271D RID: 10013 RVA: 0x00068204 File Offset: 0x00066404
		private IStateRotationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRotationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRotationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRotationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0006823C File Offset: 0x0006643C
		public static IStateRotationConfig Create([Nullable(2)] IStateRotationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRotationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0006824F File Offset: 0x0006644F
		public static IStateRotationConfig CreateFromSetValue([Nullable(2)] IStateRotationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRotationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00068264 File Offset: 0x00066464
		public IStateRotationConfig_SetValue ToSetValue()
		{
			return new IStateRotationConfig_SetValue
			{
				State = this.State,
				IsLoop = this.IsLoop,
				StartRotationConfig = this.StartRotationConfig,
				RotatePoint = this.RotatePoint,
				RotationConfig = this.RotationConfig,
				KeyRotatorConfig = this.KeyRotatorConfig,
				KeepLastRotation = this.KeepLastRotation
			};
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000682CA File Offset: 0x000664CA
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x000682F5 File Offset: 0x000664F5
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x00068303 File Offset: 0x00066503
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x0006832E File Offset: 0x0006652E
		public virtual bool IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x0006833C File Offset: 0x0006653C
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x0006839D File Offset: 0x0006659D
		[Nullable(2)]
		public virtual IStartRotationConfig StartRotationConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._StartRotationConfigInited)
				{
					return this._StartRotationConfigCache;
				}
				this._StartRotationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StartRotationConfigCache = IStartRotationConfig.Create(this.FbInstance.StartRotationConfig);
				}
				else
				{
					IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
					this._StartRotationConfigCache = ((pocoInterface != null) ? pocoInterface.StartRotationConfig : null);
				}
				return this._StartRotationConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StartRotationConfig = value;
				this._StartRotationConfigInited = false;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000683B2 File Offset: 0x000665B2
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000683D9 File Offset: 0x000665D9
		[Nullable(2)]
		public virtual string RotatePoint
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotatePoint;
				}
				IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RotatePoint;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RotatePoint = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000683E8 File Offset: 0x000665E8
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x0006847B File Offset: 0x0006667B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IRotationConfig> RotationConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._RotationConfigInited)
				{
					return this._RotationConfigCache;
				}
				this._RotationConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IRotationConfig> rotationConfig = this.FbInstance.RotationConfig;
					if (rotationConfig != null)
					{
						this._RotationConfigCache = new List<IRotationConfig>(rotationConfig.Count);
						for (int i = 0; i < rotationConfig.Count; i++)
						{
							this._RotationConfigCache.Add(IRotationConfig.Create(rotationConfig[i]));
						}
					}
				}
				else
				{
					IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
					this._RotationConfigCache = ((pocoInterface != null) ? pocoInterface.RotationConfig : null);
				}
				return this._RotationConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().RotationConfig = value;
				this._RotationConfigInited = false;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x00068490 File Offset: 0x00066690
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x00068523 File Offset: 0x00066723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IKeyRotatorConfig> KeyRotatorConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._KeyRotatorConfigInited)
				{
					return this._KeyRotatorConfigCache;
				}
				this._KeyRotatorConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IKeyRotatorConfig> keyRotatorConfig = this.FbInstance.KeyRotatorConfig;
					if (keyRotatorConfig != null)
					{
						this._KeyRotatorConfigCache = new List<IKeyRotatorConfig>(keyRotatorConfig.Count);
						for (int i = 0; i < keyRotatorConfig.Count; i++)
						{
							this._KeyRotatorConfigCache.Add(IKeyRotatorConfig.Create(keyRotatorConfig[i]));
						}
					}
				}
				else
				{
					IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
					this._KeyRotatorConfigCache = ((pocoInterface != null) ? pocoInterface.KeyRotatorConfig : null);
				}
				return this._KeyRotatorConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().KeyRotatorConfig = value;
				this._KeyRotatorConfigInited = false;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00068538 File Offset: 0x00066738
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x00068572 File Offset: 0x00066772
		public virtual bool? KeepLastRotation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepLastRotation;
				}
				IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepLastRotation;
			}
			set
			{
				this.GetOrCreatePoco().KeepLastRotation = value;
			}
		}

		// Token: 0x04001A64 RID: 6756
		[Nullable(2)]
		protected IStateRotationConfig FbInstance;

		// Token: 0x04001A65 RID: 6757
		[Nullable(2)]
		protected IStateRotationConfig_SetValue PocoInterface;

		// Token: 0x04001A66 RID: 6758
		private IStartRotationConfig _StartRotationConfigCache;

		// Token: 0x04001A67 RID: 6759
		private bool _StartRotationConfigInited;

		// Token: 0x04001A68 RID: 6760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRotationConfig> _RotationConfigCache;

		// Token: 0x04001A69 RID: 6761
		private bool _RotationConfigInited;

		// Token: 0x04001A6A RID: 6762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKeyRotatorConfig> _KeyRotatorConfigCache;

		// Token: 0x04001A6B RID: 6763
		private bool _KeyRotatorConfigInited;
	}
}

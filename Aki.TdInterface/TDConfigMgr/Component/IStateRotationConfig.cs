using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BC RID: 1980
	public class IStateRotationConfig
	{
		// Token: 0x06002A3D RID: 10813 RVA: 0x0006F274 File Offset: 0x0006D474
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

		// Token: 0x06002A3E RID: 10814 RVA: 0x0006F2AC File Offset: 0x0006D4AC
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

		// Token: 0x06002A3F RID: 10815 RVA: 0x0006F2BF File Offset: 0x0006D4BF
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

		// Token: 0x06002A40 RID: 10816 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
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
				AxisAngleMethodConfig = this.AxisAngleMethodConfig,
				KeepLastRotation = this.KeepLastRotation
			};
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x0006F346 File Offset: 0x0006D546
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x0006F371 File Offset: 0x0006D571
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

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x0006F37F File Offset: 0x0006D57F
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x0006F3AA File Offset: 0x0006D5AA
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

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x0006F419 File Offset: 0x0006D619
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

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x0006F42E File Offset: 0x0006D62E
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x0006F455 File Offset: 0x0006D655
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

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x0006F464 File Offset: 0x0006D664
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x0006F4F7 File Offset: 0x0006D6F7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IRotationConfig> RotationConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().RotationConfig = value;
				this._RotationConfigInited = false;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0006F50C File Offset: 0x0006D70C
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x0006F59F File Offset: 0x0006D79F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IKeyRotatorConfig> KeyRotatorConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().KeyRotatorConfig = value;
				this._KeyRotatorConfigInited = false;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0006F5B4 File Offset: 0x0006D7B4
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0006F647 File Offset: 0x0006D847
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IAxisAngleMethodConfig> AxisAngleMethodConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._AxisAngleMethodConfigInited)
				{
					return this._AxisAngleMethodConfigCache;
				}
				this._AxisAngleMethodConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IAxisAngleMethodConfig> axisAngleMethodConfig = this.FbInstance.AxisAngleMethodConfig;
					if (axisAngleMethodConfig != null)
					{
						this._AxisAngleMethodConfigCache = new List<IAxisAngleMethodConfig>(axisAngleMethodConfig.Count);
						for (int i = 0; i < axisAngleMethodConfig.Count; i++)
						{
							this._AxisAngleMethodConfigCache.Add(IAxisAngleMethodConfig.Create(axisAngleMethodConfig[i]));
						}
					}
				}
				else
				{
					IStateRotationConfig_SetValue pocoInterface = this.PocoInterface;
					this._AxisAngleMethodConfigCache = ((pocoInterface != null) ? pocoInterface.AxisAngleMethodConfig : null);
				}
				return this._AxisAngleMethodConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().AxisAngleMethodConfig = value;
				this._AxisAngleMethodConfigInited = false;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x0006F65C File Offset: 0x0006D85C
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0006F696 File Offset: 0x0006D896
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

		// Token: 0x04001C63 RID: 7267
		[Nullable(2)]
		protected IStateRotationConfig FbInstance;

		// Token: 0x04001C64 RID: 7268
		[Nullable(2)]
		protected IStateRotationConfig_SetValue PocoInterface;

		// Token: 0x04001C65 RID: 7269
		private IStartRotationConfig _StartRotationConfigCache;

		// Token: 0x04001C66 RID: 7270
		private bool _StartRotationConfigInited;

		// Token: 0x04001C67 RID: 7271
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IRotationConfig> _RotationConfigCache;

		// Token: 0x04001C68 RID: 7272
		private bool _RotationConfigInited;

		// Token: 0x04001C69 RID: 7273
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IKeyRotatorConfig> _KeyRotatorConfigCache;

		// Token: 0x04001C6A RID: 7274
		private bool _KeyRotatorConfigInited;

		// Token: 0x04001C6B RID: 7275
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAxisAngleMethodConfig> _AxisAngleMethodConfigCache;

		// Token: 0x04001C6C RID: 7276
		private bool _AxisAngleMethodConfigInited;
	}
}

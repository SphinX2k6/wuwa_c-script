using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B31 RID: 2865
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateRotationConfig
	{
		// Token: 0x06004186 RID: 16774 RVA: 0x000A6E4C File Offset: 0x000A504C
		[NullableContext(0)]
		public static IStateRotationConfig Create(IStateRotationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRotationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x000A6E6B File Offset: 0x000A506B
		[Nullable(0)]
		public virtual string State
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x000A6E78 File Offset: 0x000A5078
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x000A6E85 File Offset: 0x000A5085
		public virtual IStartRotationConfig StartRotationConfig
		{
			get
			{
				if (this._StartRotationConfigInited)
				{
					return this._StartRotationConfigCache;
				}
				this._StartRotationConfigInited = true;
				this._StartRotationConfigCache = IStartRotationConfig.Create(this.Instance.StartRotationConfig);
				return this._StartRotationConfigCache;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x000A6EB9 File Offset: 0x000A50B9
		public virtual string RotatePoint
		{
			get
			{
				return this.Instance.RotatePoint;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x000A6EC8 File Offset: 0x000A50C8
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int rotationConfigLength = this.Instance.RotationConfigLength;
				this._RotationConfigCache = new List<IRotationConfig>(rotationConfigLength);
				for (int i = 0; i < rotationConfigLength; i++)
				{
					this._RotationConfigCache.Add(IRotationConfig.Create(this.Instance.RotationConfig(i)));
				}
				return this._RotationConfigCache;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x000A6F44 File Offset: 0x000A5144
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int keyRotatorConfigLength = this.Instance.KeyRotatorConfigLength;
				this._KeyRotatorConfigCache = new List<IKeyRotatorConfig>(keyRotatorConfigLength);
				for (int i = 0; i < keyRotatorConfigLength; i++)
				{
					this._KeyRotatorConfigCache.Add(IKeyRotatorConfig.Create(this.Instance.KeyRotatorConfig(i)));
				}
				return this._KeyRotatorConfigCache;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x000A6FC0 File Offset: 0x000A51C0
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
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int axisAngleMethodConfigLength = this.Instance.AxisAngleMethodConfigLength;
				this._AxisAngleMethodConfigCache = new List<IAxisAngleMethodConfig>(axisAngleMethodConfigLength);
				for (int i = 0; i < axisAngleMethodConfigLength; i++)
				{
					this._AxisAngleMethodConfigCache.Add(IAxisAngleMethodConfig.Create(this.Instance.AxisAngleMethodConfig(i)));
				}
				return this._AxisAngleMethodConfigCache;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x000A703C File Offset: 0x000A523C
		public virtual bool? KeepLastRotation
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepLastRotation);
			}
		}

		// Token: 0x04002448 RID: 9288
		private IStateRotationConfig Instance;

		// Token: 0x04002449 RID: 9289
		private IStartRotationConfig _StartRotationConfigCache;

		// Token: 0x0400244A RID: 9290
		private bool _StartRotationConfigInited;

		// Token: 0x0400244B RID: 9291
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IRotationConfig> _RotationConfigCache;

		// Token: 0x0400244C RID: 9292
		private bool _RotationConfigInited;

		// Token: 0x0400244D RID: 9293
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IKeyRotatorConfig> _KeyRotatorConfigCache;

		// Token: 0x0400244E RID: 9294
		private bool _KeyRotatorConfigInited;

		// Token: 0x0400244F RID: 9295
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAxisAngleMethodConfig> _AxisAngleMethodConfigCache;

		// Token: 0x04002450 RID: 9296
		private bool _AxisAngleMethodConfigInited;
	}
}

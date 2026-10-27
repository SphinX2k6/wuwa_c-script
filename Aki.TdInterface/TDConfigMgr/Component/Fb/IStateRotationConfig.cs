using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A67 RID: 2663
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateRotationConfig
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x0009D90F File Offset: 0x0009BB0F
		[NullableContext(1)]
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

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x0009D92E File Offset: 0x0009BB2E
		[Nullable(1)]
		public virtual string State
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x0009D93B File Offset: 0x0009BB3B
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x0009D948 File Offset: 0x0009BB48
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

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x0009D97C File Offset: 0x0009BB7C
		public virtual string RotatePoint
		{
			get
			{
				return this.Instance.RotatePoint;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x0009D98C File Offset: 0x0009BB8C
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x0009DA08 File Offset: 0x0009BC08
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

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x0009DA84 File Offset: 0x0009BC84
		public virtual bool? KeepLastRotation
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepLastRotation);
			}
		}

		// Token: 0x0400222E RID: 8750
		private IStateRotationConfig Instance;

		// Token: 0x0400222F RID: 8751
		private IStartRotationConfig _StartRotationConfigCache;

		// Token: 0x04002230 RID: 8752
		private bool _StartRotationConfigInited;

		// Token: 0x04002231 RID: 8753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRotationConfig> _RotationConfigCache;

		// Token: 0x04002232 RID: 8754
		private bool _RotationConfigInited;

		// Token: 0x04002233 RID: 8755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKeyRotatorConfig> _KeyRotatorConfigCache;

		// Token: 0x04002234 RID: 8756
		private bool _KeyRotatorConfigInited;
	}
}

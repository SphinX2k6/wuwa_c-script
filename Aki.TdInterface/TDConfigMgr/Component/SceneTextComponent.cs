using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000895 RID: 2197
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneTextComponent : IComponentBase
	{
		// Token: 0x06003103 RID: 12547 RVA: 0x0007E078 File Offset: 0x0007C278
		private SceneTextComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneTextComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneTextComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneTextComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0007E0B0 File Offset: 0x0007C2B0
		public static SceneTextComponent Create([Nullable(2)] SceneTextComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneTextComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0007E0C3 File Offset: 0x0007C2C3
		public static SceneTextComponent CreateFromSetValue([Nullable(2)] SceneTextComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneTextComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0007E0D8 File Offset: 0x0007C2D8
		public new SceneTextComponent_SetValue ToSetValue()
		{
			return new SceneTextComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DisplayState = this.DisplayState,
				RelativeTransform = this.RelativeTransform,
				TextConfig = this.TextConfig
			};
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x0007E128 File Offset: 0x0007C328
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x0007E162 File Offset: 0x0007C362
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneTextComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x0007E170 File Offset: 0x0007C370
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x0007E19A File Offset: 0x0007C39A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x0007E1A8 File Offset: 0x0007C3A8
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x0007E1D3 File Offset: 0x0007C3D3
		public virtual string DisplayState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DisplayState;
			}
			set
			{
				this.GetOrCreatePoco().DisplayState = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x0007E1E4 File Offset: 0x0007C3E4
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x0007E245 File Offset: 0x0007C445
		[Nullable(2)]
		public virtual PosAndRot RelativeTransform
		{
			[NullableContext(2)]
			get
			{
				if (this._RelativeTransformInited)
				{
					return this._RelativeTransformCache;
				}
				this._RelativeTransformInited = true;
				if (this.FbInstance != null)
				{
					this._RelativeTransformCache = PosAndRot.Create(this.FbInstance.RelativeTransform);
				}
				else
				{
					SceneTextComponent_SetValue pocoInterface = this.PocoInterface;
					this._RelativeTransformCache = ((pocoInterface != null) ? pocoInterface.RelativeTransform : null);
				}
				return this._RelativeTransformCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RelativeTransform = value;
				this._RelativeTransformInited = false;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x0007E25A File Offset: 0x0007C45A
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x0007E281 File Offset: 0x0007C481
		public virtual ISceneTextTypeBase TextConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextConfig;
				}
				SceneTextComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextConfig;
			}
			set
			{
				this.GetOrCreatePoco().TextConfig = value;
			}
		}

		// Token: 0x0400203D RID: 8253
		[Nullable(2)]
		protected new SceneTextComponent FbInstance;

		// Token: 0x0400203E RID: 8254
		[Nullable(2)]
		protected new SceneTextComponent_SetValue PocoInterface;

		// Token: 0x0400203F RID: 8255
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002040 RID: 8256
		private bool _RelativeTransformInited;
	}
}

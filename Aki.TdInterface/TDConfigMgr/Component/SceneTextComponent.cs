using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000938 RID: 2360
	public class SceneTextComponent : IComponentBase
	{
		// Token: 0x0600343F RID: 13375 RVA: 0x00085560 File Offset: 0x00083760
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

		// Token: 0x06003440 RID: 13376 RVA: 0x00085598 File Offset: 0x00083798
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

		// Token: 0x06003441 RID: 13377 RVA: 0x000855AB File Offset: 0x000837AB
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

		// Token: 0x06003442 RID: 13378 RVA: 0x000855C0 File Offset: 0x000837C0
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

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00085610 File Offset: 0x00083810
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x0008564A File Offset: 0x0008384A
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x00085658 File Offset: 0x00083858
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x00085682 File Offset: 0x00083882
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

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00085690 File Offset: 0x00083890
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x000856BB File Offset: 0x000838BB
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

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x000856CC File Offset: 0x000838CC
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x0008572D File Offset: 0x0008392D
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

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00085742 File Offset: 0x00083942
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00085769 File Offset: 0x00083969
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

		// Token: 0x0400224F RID: 8783
		[Nullable(2)]
		protected new SceneTextComponent FbInstance;

		// Token: 0x04002250 RID: 8784
		[Nullable(2)]
		protected new SceneTextComponent_SetValue PocoInterface;

		// Token: 0x04002251 RID: 8785
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002252 RID: 8786
		private bool _RelativeTransformInited;
	}
}

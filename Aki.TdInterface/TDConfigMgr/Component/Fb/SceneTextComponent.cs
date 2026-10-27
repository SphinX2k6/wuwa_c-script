using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D25 RID: 3365
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneTextComponent : IComponentBase
	{
		// Token: 0x06004CCC RID: 19660 RVA: 0x000BF27F File Offset: 0x000BD47F
		public static SceneTextComponent Create(ISceneTextComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneTextComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x000BF2A0 File Offset: 0x000BD4A0
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x000BF2D8 File Offset: 0x000BD4D8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x000BF2EE File Offset: 0x000BD4EE
		public virtual string DisplayState
		{
			get
			{
				return this.Instance.DisplayState;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x000BF2FB File Offset: 0x000BD4FB
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
				this._RelativeTransformCache = PosAndRot.Create(this.Instance.RelativeTransform);
				return this._RelativeTransformCache;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x000BF32F File Offset: 0x000BD52F
		public virtual ISceneTextTypeBase TextConfig
		{
			get
			{
				if (this._TextConfigInited)
				{
					return this._TextConfigCache;
				}
				this._TextConfigInited = true;
				this._TextConfigCache = ComponentReadHelper.ReadSceneTextComponent_TextConfig(this.Instance);
				return this._TextConfigCache;
			}
		}

		// Token: 0x04002BF4 RID: 11252
		private ISceneTextComponent Instance;

		// Token: 0x04002BF5 RID: 11253
		[Nullable(2)]
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002BF6 RID: 11254
		private bool _RelativeTransformInited;

		// Token: 0x04002BF7 RID: 11255
		private ISceneTextTypeBase _TextConfigCache;

		// Token: 0x04002BF8 RID: 11256
		private bool _TextConfigInited;
	}
}

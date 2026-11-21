using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1F RID: 3615
	public class SceneTextComponent : IComponentBase
	{
		// Token: 0x060051E8 RID: 20968 RVA: 0x000CA9C3 File Offset: 0x000C8BC3
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x000CA9E4 File Offset: 0x000C8BE4
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

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x000CAA1C File Offset: 0x000C8C1C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x000CAA32 File Offset: 0x000C8C32
		public virtual string DisplayState
		{
			get
			{
				return this.Instance.DisplayState;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x000CAA3F File Offset: 0x000C8C3F
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x000CAA73 File Offset: 0x000C8C73
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

		// Token: 0x04002EB4 RID: 11956
		private ISceneTextComponent Instance;

		// Token: 0x04002EB5 RID: 11957
		[Nullable(2)]
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002EB6 RID: 11958
		private bool _RelativeTransformInited;

		// Token: 0x04002EB7 RID: 11959
		private ISceneTextTypeBase _TextConfigCache;

		// Token: 0x04002EB8 RID: 11960
		private bool _TextConfigInited;
	}
}

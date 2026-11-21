using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287F RID: 10367
	public class ISceneUiSubtitlePosition : ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600E710 RID: 59152 RVA: 0x00222F92 File Offset: 0x00221192
		public static ISceneUiSubtitlePosition Create(ISceneUiSubtitlePosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0600E711 RID: 59153 RVA: 0x00222FB1 File Offset: 0x002211B1
		public override ESceneUiSubtitlePositionType Type
		{
			get
			{
				return (ESceneUiSubtitlePositionType)this.Instance.Type;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0600E712 RID: 59154 RVA: 0x00222FBE File Offset: 0x002211BE
		public virtual PosAndRot Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				this._PosCache = PosAndRot.Create(this.Instance.Pos);
				return this._PosCache;
			}
		}

		// Token: 0x04007F37 RID: 32567
		private ISceneUiSubtitlePosition Instance;

		// Token: 0x04007F38 RID: 32568
		[Nullable(2)]
		private PosAndRot _PosCache;

		// Token: 0x04007F39 RID: 32569
		private bool _PosInited;
	}
}

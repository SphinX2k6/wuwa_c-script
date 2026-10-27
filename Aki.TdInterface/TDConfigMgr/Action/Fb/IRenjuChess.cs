using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285F RID: 10335
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenjuChess : IUiGame
	{
		// Token: 0x0600E511 RID: 58641 RVA: 0x0021B272 File Offset: 0x00219472
		public static IRenjuChess Create(IRenjuChess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenjuChess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x0021B291 File Offset: 0x00219491
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x0021B29E File Offset: 0x0021949E
		public virtual int Chessboard
		{
			get
			{
				return this.Instance.Chessboard;
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x0021B2AB File Offset: 0x002194AB
		public virtual IAdjustPlayerCameraType CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = ActionReadHelper.ReadIRenjuChess_CameraConfig(this.Instance);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x04007EB7 RID: 32439
		private IRenjuChess Instance;

		// Token: 0x04007EB8 RID: 32440
		private IAdjustPlayerCameraType _CameraConfigCache;

		// Token: 0x04007EB9 RID: 32441
		private bool _CameraConfigInited;
	}
}

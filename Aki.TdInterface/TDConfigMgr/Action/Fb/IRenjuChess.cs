using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B32 RID: 11058
	public class IRenjuChess : IUiGame
	{
		// Token: 0x0600F336 RID: 62262 RVA: 0x002380D6 File Offset: 0x002362D6
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

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x0600F337 RID: 62263 RVA: 0x002380F5 File Offset: 0x002362F5
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x0600F338 RID: 62264 RVA: 0x00238102 File Offset: 0x00236302
		public virtual int Chessboard
		{
			get
			{
				return this.Instance.Chessboard;
			}
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x0600F339 RID: 62265 RVA: 0x0023810F File Offset: 0x0023630F
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

		// Token: 0x04008574 RID: 34164
		private IRenjuChess Instance;

		// Token: 0x04008575 RID: 34165
		private IAdjustPlayerCameraType _CameraConfigCache;

		// Token: 0x04008576 RID: 34166
		private bool _CameraConfigInited;
	}
}

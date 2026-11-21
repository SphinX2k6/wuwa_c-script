using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200D RID: 8205
	public class ISceneUiSubtitlePosition : ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600AE3B RID: 44603 RVA: 0x00188F58 File Offset: 0x00187158
		private ISceneUiSubtitlePosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitlePosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitlePosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitlePosition_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x00188F90 File Offset: 0x00187190
		public static ISceneUiSubtitlePosition Create([Nullable(2)] ISceneUiSubtitlePosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x00188FA3 File Offset: 0x001871A3
		public static ISceneUiSubtitlePosition CreateFromSetValue([Nullable(2)] ISceneUiSubtitlePosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x00188FB6 File Offset: 0x001871B6
		public new ISceneUiSubtitlePosition_SetValue ToSetValue()
		{
			return new ISceneUiSubtitlePosition_SetValue
			{
				Type = this.Type,
				Pos = this.Pos
			};
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600AE3F RID: 44607 RVA: 0x00188FD5 File Offset: 0x001871D5
		// (set) Token: 0x0600AE40 RID: 44608 RVA: 0x00189000 File Offset: 0x00187200
		public override ESceneUiSubtitlePositionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitlePositionType.Position;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x00189010 File Offset: 0x00187210
		// (set) Token: 0x0600AE42 RID: 44610 RVA: 0x00189071 File Offset: 0x00187271
		public virtual PosAndRot Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				if (this.FbInstance != null)
				{
					this._PosCache = PosAndRot.Create(this.FbInstance.Pos);
				}
				else
				{
					ISceneUiSubtitlePosition_SetValue pocoInterface = this.PocoInterface;
					this._PosCache = ((pocoInterface != null) ? pocoInterface.Pos : null);
				}
				return this._PosCache;
			}
			set
			{
				this.GetOrCreatePoco().Pos = value;
				this._PosInited = false;
			}
		}

		// Token: 0x040067E3 RID: 26595
		[Nullable(2)]
		protected new ISceneUiSubtitlePosition FbInstance;

		// Token: 0x040067E4 RID: 26596
		[Nullable(2)]
		protected new ISceneUiSubtitlePosition_SetValue PocoInterface;

		// Token: 0x040067E5 RID: 26597
		private PosAndRot _PosCache;

		// Token: 0x040067E6 RID: 26598
		private bool _PosInited;
	}
}

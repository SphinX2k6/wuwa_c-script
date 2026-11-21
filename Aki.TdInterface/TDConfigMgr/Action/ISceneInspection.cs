using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF5 RID: 8181
	public class ISceneInspection : IUiGame
	{
		// Token: 0x0600ADBB RID: 44475 RVA: 0x00187FD8 File Offset: 0x001861D8
		private ISceneInspection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneInspection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneInspection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneInspection_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x00188010 File Offset: 0x00186210
		public static ISceneInspection Create([Nullable(2)] ISceneInspection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInspection
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x00188023 File Offset: 0x00186223
		public static ISceneInspection CreateFromSetValue([Nullable(2)] ISceneInspection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneInspection
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x00188036 File Offset: 0x00186236
		public new ISceneInspection_SetValue ToSetValue()
		{
			return new ISceneInspection_SetValue
			{
				Type = this.Type,
				SaveVarName = this.SaveVarName,
				InteractPoints = this.InteractPoints
			};
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x00188061 File Offset: 0x00186261
		// (set) Token: 0x0600ADC0 RID: 44480 RVA: 0x0018808C File Offset: 0x0018628C
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x0018809A File Offset: 0x0018629A
		// (set) Token: 0x0600ADC2 RID: 44482 RVA: 0x001880C5 File Offset: 0x001862C5
		public virtual string SaveVarName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SaveVarName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SaveVarName;
			}
			set
			{
				this.GetOrCreatePoco().SaveVarName = value;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600ADC3 RID: 44483 RVA: 0x001880D4 File Offset: 0x001862D4
		// (set) Token: 0x0600ADC4 RID: 44484 RVA: 0x00188167 File Offset: 0x00186367
		public virtual List<ISceneInspectionPoint> InteractPoints
		{
			get
			{
				if (this._InteractPointsInited)
				{
					return this._InteractPointsCache;
				}
				this._InteractPointsInited = true;
				if (this.FbInstance != null)
				{
					List<ISceneInspectionPoint> interactPoints = this.FbInstance.InteractPoints;
					if (interactPoints != null)
					{
						this._InteractPointsCache = new List<ISceneInspectionPoint>(interactPoints.Count);
						for (int i = 0; i < interactPoints.Count; i++)
						{
							this._InteractPointsCache.Add(ISceneInspectionPoint.Create(interactPoints[i]));
						}
					}
				}
				else
				{
					ISceneInspection_SetValue pocoInterface = this.PocoInterface;
					this._InteractPointsCache = ((pocoInterface != null) ? pocoInterface.InteractPoints : null);
				}
				return this._InteractPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().InteractPoints = value;
				this._InteractPointsInited = false;
			}
		}

		// Token: 0x040067A3 RID: 26531
		[Nullable(2)]
		protected new ISceneInspection FbInstance;

		// Token: 0x040067A4 RID: 26532
		[Nullable(2)]
		protected new ISceneInspection_SetValue PocoInterface;

		// Token: 0x040067A5 RID: 26533
		private List<ISceneInspectionPoint> _InteractPointsCache;

		// Token: 0x040067A6 RID: 26534
		private bool _InteractPointsInited;
	}
}

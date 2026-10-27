using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDC RID: 7644
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneInspection : IUiGame
	{
		// Token: 0x0600A3A5 RID: 41893 RVA: 0x00173780 File Offset: 0x00171980
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

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x001737B8 File Offset: 0x001719B8
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

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x001737CB File Offset: 0x001719CB
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

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x001737DE File Offset: 0x001719DE
		public new ISceneInspection_SetValue ToSetValue()
		{
			return new ISceneInspection_SetValue
			{
				Type = this.Type,
				SaveVarName = this.SaveVarName,
				InteractPoints = this.InteractPoints
			};
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A3A9 RID: 41897 RVA: 0x00173809 File Offset: 0x00171A09
		// (set) Token: 0x0600A3AA RID: 41898 RVA: 0x00173834 File Offset: 0x00171A34
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

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A3AB RID: 41899 RVA: 0x00173842 File Offset: 0x00171A42
		// (set) Token: 0x0600A3AC RID: 41900 RVA: 0x0017386D File Offset: 0x00171A6D
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

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A3AD RID: 41901 RVA: 0x0017387C File Offset: 0x00171A7C
		// (set) Token: 0x0600A3AE RID: 41902 RVA: 0x0017390F File Offset: 0x00171B0F
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

		// Token: 0x04006216 RID: 25110
		[Nullable(2)]
		protected new ISceneInspection FbInstance;

		// Token: 0x04006217 RID: 25111
		[Nullable(2)]
		protected new ISceneInspection_SetValue PocoInterface;

		// Token: 0x04006218 RID: 25112
		private List<ISceneInspectionPoint> _InteractPointsCache;

		// Token: 0x04006219 RID: 25113
		private bool _InteractPointsInited;
	}
}

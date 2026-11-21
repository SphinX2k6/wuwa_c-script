using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D4 RID: 1236
	public class IInteractEntityPartModelBind : IInteractEntityPartBindBase
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x0004A340 File Offset: 0x00048540
		private IInteractEntityPartModelBind_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartModelBind 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartModelBind_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartModelBind_SetValue());
			}
			return result;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0004A378 File Offset: 0x00048578
		public static IInteractEntityPartModelBind Create([Nullable(2)] IInteractEntityPartModelBind instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartModelBind
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0004A38B File Offset: 0x0004858B
		public static IInteractEntityPartModelBind CreateFromSetValue([Nullable(2)] IInteractEntityPartModelBind_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartModelBind
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0004A39E File Offset: 0x0004859E
		public new IInteractEntityPartModelBind_SetValue ToSetValue()
		{
			return new IInteractEntityPartModelBind_SetValue
			{
				Type = this.Type,
				OptionPoints = this.OptionPoints
			};
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0004A3BD File Offset: 0x000485BD
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0004A3E8 File Offset: 0x000485E8
		public override EInteractEntityPartBindType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0004A3F8 File Offset: 0x000485F8
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0004A48B File Offset: 0x0004868B
		public virtual List<IInteractEntityPartModelOptionPoint> OptionPoints
		{
			get
			{
				if (this._OptionPointsInited)
				{
					return this._OptionPointsCache;
				}
				this._OptionPointsInited = true;
				if (this.FbInstance != null)
				{
					List<IInteractEntityPartModelOptionPoint> optionPoints = this.FbInstance.OptionPoints;
					if (optionPoints != null)
					{
						this._OptionPointsCache = new List<IInteractEntityPartModelOptionPoint>(optionPoints.Count);
						for (int i = 0; i < optionPoints.Count; i++)
						{
							this._OptionPointsCache.Add(IInteractEntityPartModelOptionPoint.Create(optionPoints[i]));
						}
					}
				}
				else
				{
					IInteractEntityPartModelBind_SetValue pocoInterface = this.PocoInterface;
					this._OptionPointsCache = ((pocoInterface != null) ? pocoInterface.OptionPoints : null);
				}
				return this._OptionPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().OptionPoints = value;
				this._OptionPointsInited = false;
			}
		}

		// Token: 0x04001288 RID: 4744
		[Nullable(2)]
		protected new IInteractEntityPartModelBind FbInstance;

		// Token: 0x04001289 RID: 4745
		[Nullable(2)]
		protected new IInteractEntityPartModelBind_SetValue PocoInterface;

		// Token: 0x0400128A RID: 4746
		private List<IInteractEntityPartModelOptionPoint> _OptionPointsCache;

		// Token: 0x0400128B RID: 4747
		private bool _OptionPointsInited;
	}
}

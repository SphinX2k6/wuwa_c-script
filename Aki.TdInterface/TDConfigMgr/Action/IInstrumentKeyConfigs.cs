using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEC RID: 7404
	public class IInstrumentKeyConfigs
	{
		// Token: 0x06009D22 RID: 40226 RVA: 0x00169CF8 File Offset: 0x00167EF8
		private IInstrumentKeyConfigs_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentKeyConfigs 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentKeyConfigs_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentKeyConfigs_SetValue());
			}
			return result;
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x00169D30 File Offset: 0x00167F30
		public static IInstrumentKeyConfigs Create([Nullable(2)] IInstrumentKeyConfigs instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentKeyConfigs
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x00169D43 File Offset: 0x00167F43
		public static IInstrumentKeyConfigs CreateFromSetValue([Nullable(2)] IInstrumentKeyConfigs_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentKeyConfigs
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x00169D56 File Offset: 0x00167F56
		public IInstrumentKeyConfigs_SetValue ToSetValue()
		{
			return new IInstrumentKeyConfigs_SetValue
			{
				Grids = this.Grids,
				BoardSize = this.BoardSize
			};
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06009D26 RID: 40230 RVA: 0x00169D78 File Offset: 0x00167F78
		// (set) Token: 0x06009D27 RID: 40231 RVA: 0x00169E0B File Offset: 0x0016800B
		public virtual List<IInstrumentKeyAttribute> Grids
		{
			get
			{
				if (this._GridsInited)
				{
					return this._GridsCache;
				}
				this._GridsInited = true;
				if (this.FbInstance != null)
				{
					List<IInstrumentKeyAttribute> grids = this.FbInstance.Grids;
					if (grids != null)
					{
						this._GridsCache = new List<IInstrumentKeyAttribute>(grids.Count);
						for (int i = 0; i < grids.Count; i++)
						{
							this._GridsCache.Add(IInstrumentKeyAttribute.Create(grids[i]));
						}
					}
				}
				else
				{
					IInstrumentKeyConfigs_SetValue pocoInterface = this.PocoInterface;
					this._GridsCache = ((pocoInterface != null) ? pocoInterface.Grids : null);
				}
				return this._GridsCache;
			}
			set
			{
				this.GetOrCreatePoco().Grids = value;
				this._GridsInited = false;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06009D28 RID: 40232 RVA: 0x00169E20 File Offset: 0x00168020
		// (set) Token: 0x06009D29 RID: 40233 RVA: 0x00169E81 File Offset: 0x00168081
		public virtual IInstrumentBoardSize BoardSize
		{
			get
			{
				if (this._BoardSizeInited)
				{
					return this._BoardSizeCache;
				}
				this._BoardSizeInited = true;
				if (this.FbInstance != null)
				{
					this._BoardSizeCache = IInstrumentBoardSize.Create(this.FbInstance.BoardSize);
				}
				else
				{
					IInstrumentKeyConfigs_SetValue pocoInterface = this.PocoInterface;
					this._BoardSizeCache = ((pocoInterface != null) ? pocoInterface.BoardSize : null);
				}
				return this._BoardSizeCache;
			}
			set
			{
				this.GetOrCreatePoco().BoardSize = value;
				this._BoardSizeInited = false;
			}
		}

		// Token: 0x04005FF1 RID: 24561
		[Nullable(2)]
		protected IInstrumentKeyConfigs FbInstance;

		// Token: 0x04005FF2 RID: 24562
		[Nullable(2)]
		protected IInstrumentKeyConfigs_SetValue PocoInterface;

		// Token: 0x04005FF3 RID: 24563
		private List<IInstrumentKeyAttribute> _GridsCache;

		// Token: 0x04005FF4 RID: 24564
		private bool _GridsInited;

		// Token: 0x04005FF5 RID: 24565
		private IInstrumentBoardSize _BoardSizeCache;

		// Token: 0x04005FF6 RID: 24566
		private bool _BoardSizeInited;
	}
}

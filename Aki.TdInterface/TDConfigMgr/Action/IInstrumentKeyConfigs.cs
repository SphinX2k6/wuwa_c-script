using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3D RID: 6973
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentKeyConfigs
	{
		// Token: 0x06009538 RID: 38200 RVA: 0x0015901C File Offset: 0x0015721C
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

		// Token: 0x06009539 RID: 38201 RVA: 0x00159054 File Offset: 0x00157254
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

		// Token: 0x0600953A RID: 38202 RVA: 0x00159067 File Offset: 0x00157267
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

		// Token: 0x0600953B RID: 38203 RVA: 0x0015907A File Offset: 0x0015727A
		public IInstrumentKeyConfigs_SetValue ToSetValue()
		{
			return new IInstrumentKeyConfigs_SetValue
			{
				Grids = this.Grids,
				BoardSize = this.BoardSize
			};
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600953C RID: 38204 RVA: 0x0015909C File Offset: 0x0015729C
		// (set) Token: 0x0600953D RID: 38205 RVA: 0x0015912F File Offset: 0x0015732F
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

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600953E RID: 38206 RVA: 0x00159144 File Offset: 0x00157344
		// (set) Token: 0x0600953F RID: 38207 RVA: 0x001591A5 File Offset: 0x001573A5
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

		// Token: 0x04005B53 RID: 23379
		[Nullable(2)]
		protected IInstrumentKeyConfigs FbInstance;

		// Token: 0x04005B54 RID: 23380
		[Nullable(2)]
		protected IInstrumentKeyConfigs_SetValue PocoInterface;

		// Token: 0x04005B55 RID: 23381
		private List<IInstrumentKeyAttribute> _GridsCache;

		// Token: 0x04005B56 RID: 23382
		private bool _GridsInited;

		// Token: 0x04005B57 RID: 23383
		private IInstrumentBoardSize _BoardSizeCache;

		// Token: 0x04005B58 RID: 23384
		private bool _BoardSizeInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEE RID: 7406
	public class IInstrumentQteConfig
	{
		// Token: 0x06009D2C RID: 40236 RVA: 0x00169EA8 File Offset: 0x001680A8
		private IInstrumentQteConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentQteConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentQteConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentQteConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x00169EE0 File Offset: 0x001680E0
		public static IInstrumentQteConfig Create([Nullable(2)] IInstrumentQteConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x00169EF3 File Offset: 0x001680F3
		public static IInstrumentQteConfig CreateFromSetValue([Nullable(2)] IInstrumentQteConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentQteConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x00169F08 File Offset: 0x00168108
		public IInstrumentQteConfig_SetValue ToSetValue()
		{
			return new IInstrumentQteConfig_SetValue
			{
				Id = this.Id,
				InstrumentType = this.InstrumentType,
				Description = this.Description,
				QteSequence = this.QteSequence,
				PreludeAsset = this.PreludeAsset
			};
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06009D30 RID: 40240 RVA: 0x00169F56 File Offset: 0x00168156
		// (set) Token: 0x06009D31 RID: 40241 RVA: 0x00169F81 File Offset: 0x00168181
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06009D32 RID: 40242 RVA: 0x00169F8F File Offset: 0x0016818F
		// (set) Token: 0x06009D33 RID: 40243 RVA: 0x00169FBA File Offset: 0x001681BA
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InstrumentType;
				}
				if (this.PocoInterface == null)
				{
					return EInstrumentType.ChineseZither;
				}
				return this.PocoInterface.InstrumentType;
			}
			set
			{
				this.GetOrCreatePoco().InstrumentType = value;
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06009D34 RID: 40244 RVA: 0x00169FC8 File Offset: 0x001681C8
		// (set) Token: 0x06009D35 RID: 40245 RVA: 0x00169FF3 File Offset: 0x001681F3
		public virtual string Description
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Description;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Description;
			}
			set
			{
				this.GetOrCreatePoco().Description = value;
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06009D36 RID: 40246 RVA: 0x0016A004 File Offset: 0x00168204
		// (set) Token: 0x06009D37 RID: 40247 RVA: 0x0016A0EC File Offset: 0x001682EC
		public virtual List<List<int>> QteSequence
		{
			get
			{
				if (this._QteSequenceInited)
				{
					return this._QteSequenceCache;
				}
				this._QteSequenceInited = true;
				if (this.FbInstance != null)
				{
					List<IInstrumentQteConfig_QteSequenceRow> qteSequence = this.FbInstance.QteSequence;
					if (qteSequence != null)
					{
						this._QteSequenceCache = new List<List<int>>(qteSequence.Count);
						for (int i = 0; i < qteSequence.Count; i++)
						{
							List<int> items = qteSequence[i].Items;
							List<int> list = new List<int>(items.Count);
							foreach (int item in items)
							{
								list.Add(item);
							}
							this._QteSequenceCache.Add(list);
						}
					}
				}
				else
				{
					IInstrumentQteConfig_SetValue pocoInterface = this.PocoInterface;
					this._QteSequenceCache = ((pocoInterface != null) ? pocoInterface.QteSequence : null);
				}
				return this._QteSequenceCache;
			}
			set
			{
				this.GetOrCreatePoco().QteSequence = value;
				this._QteSequenceInited = false;
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06009D38 RID: 40248 RVA: 0x0016A101 File Offset: 0x00168301
		// (set) Token: 0x06009D39 RID: 40249 RVA: 0x0016A12C File Offset: 0x0016832C
		public virtual string PreludeAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreludeAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PreludeAsset;
			}
			set
			{
				this.GetOrCreatePoco().PreludeAsset = value;
			}
		}

		// Token: 0x04005FF9 RID: 24569
		[Nullable(2)]
		protected IInstrumentQteConfig FbInstance;

		// Token: 0x04005FFA RID: 24570
		[Nullable(2)]
		protected IInstrumentQteConfig_SetValue PocoInterface;

		// Token: 0x04005FFB RID: 24571
		private List<List<int>> _QteSequenceCache;

		// Token: 0x04005FFC RID: 24572
		private bool _QteSequenceInited;
	}
}

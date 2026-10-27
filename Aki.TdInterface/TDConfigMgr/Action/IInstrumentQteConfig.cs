using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3F RID: 6975
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteConfig
	{
		// Token: 0x06009542 RID: 38210 RVA: 0x001591CC File Offset: 0x001573CC
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

		// Token: 0x06009543 RID: 38211 RVA: 0x00159204 File Offset: 0x00157404
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

		// Token: 0x06009544 RID: 38212 RVA: 0x00159217 File Offset: 0x00157417
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

		// Token: 0x06009545 RID: 38213 RVA: 0x0015922C File Offset: 0x0015742C
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

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x0015927A File Offset: 0x0015747A
		// (set) Token: 0x06009547 RID: 38215 RVA: 0x001592A5 File Offset: 0x001574A5
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

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x001592B3 File Offset: 0x001574B3
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x001592DE File Offset: 0x001574DE
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

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600954A RID: 38218 RVA: 0x001592EC File Offset: 0x001574EC
		// (set) Token: 0x0600954B RID: 38219 RVA: 0x00159317 File Offset: 0x00157517
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

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600954C RID: 38220 RVA: 0x00159328 File Offset: 0x00157528
		// (set) Token: 0x0600954D RID: 38221 RVA: 0x00159410 File Offset: 0x00157610
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

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600954E RID: 38222 RVA: 0x00159425 File Offset: 0x00157625
		// (set) Token: 0x0600954F RID: 38223 RVA: 0x00159450 File Offset: 0x00157650
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

		// Token: 0x04005B5B RID: 23387
		[Nullable(2)]
		protected IInstrumentQteConfig FbInstance;

		// Token: 0x04005B5C RID: 23388
		[Nullable(2)]
		protected IInstrumentQteConfig_SetValue PocoInterface;

		// Token: 0x04005B5D RID: 23389
		private List<List<int>> _QteSequenceCache;

		// Token: 0x04005B5E RID: 23390
		private bool _QteSequenceInited;
	}
}

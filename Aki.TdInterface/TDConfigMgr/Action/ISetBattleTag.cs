using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E12 RID: 7698
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTag : ISendBattleStateType
	{
		// Token: 0x0600A4AF RID: 42159 RVA: 0x00175624 File Offset: 0x00173824
		private ISetBattleTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x0017565C File Offset: 0x0017385C
		public static ISetBattleTag Create([Nullable(2)] ISetBattleTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x0017566F File Offset: 0x0017386F
		public static ISetBattleTag CreateFromSetValue([Nullable(2)] ISetBattleTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x00175682 File Offset: 0x00173882
		public new ISetBattleTag_SetValue ToSetValue()
		{
			return new ISetBattleTag_SetValue
			{
				Type = this.Type,
				SetTags = this.SetTags
			};
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A4B3 RID: 42163 RVA: 0x001756A1 File Offset: 0x001738A1
		// (set) Token: 0x0600A4B4 RID: 42164 RVA: 0x001756CC File Offset: 0x001738CC
		public override ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A4B5 RID: 42165 RVA: 0x001756DC File Offset: 0x001738DC
		// (set) Token: 0x0600A4B6 RID: 42166 RVA: 0x0017576F File Offset: 0x0017396F
		public virtual List<ISetEntityTag> SetTags
		{
			get
			{
				if (this._SetTagsInited)
				{
					return this._SetTagsCache;
				}
				this._SetTagsInited = true;
				if (this.FbInstance != null)
				{
					List<ISetEntityTag> setTags = this.FbInstance.SetTags;
					if (setTags != null)
					{
						this._SetTagsCache = new List<ISetEntityTag>(setTags.Count);
						for (int i = 0; i < setTags.Count; i++)
						{
							this._SetTagsCache.Add(ISetEntityTag.Create(setTags[i]));
						}
					}
				}
				else
				{
					ISetBattleTag_SetValue pocoInterface = this.PocoInterface;
					this._SetTagsCache = ((pocoInterface != null) ? pocoInterface.SetTags : null);
				}
				return this._SetTagsCache;
			}
			set
			{
				this.GetOrCreatePoco().SetTags = value;
				this._SetTagsInited = false;
			}
		}

		// Token: 0x04006294 RID: 25236
		[Nullable(2)]
		protected new ISetBattleTag FbInstance;

		// Token: 0x04006295 RID: 25237
		[Nullable(2)]
		protected new ISetBattleTag_SetValue PocoInterface;

		// Token: 0x04006296 RID: 25238
		private List<ISetEntityTag> _SetTagsCache;

		// Token: 0x04006297 RID: 25239
		private bool _SetTagsInited;
	}
}

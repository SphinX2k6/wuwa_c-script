using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002045 RID: 8261
	public class ISetBattleTag : ISendBattleStateType
	{
		// Token: 0x0600AF57 RID: 44887 RVA: 0x0018B02C File Offset: 0x0018922C
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

		// Token: 0x0600AF58 RID: 44888 RVA: 0x0018B064 File Offset: 0x00189264
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

		// Token: 0x0600AF59 RID: 44889 RVA: 0x0018B077 File Offset: 0x00189277
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

		// Token: 0x0600AF5A RID: 44890 RVA: 0x0018B08A File Offset: 0x0018928A
		public new ISetBattleTag_SetValue ToSetValue()
		{
			return new ISetBattleTag_SetValue
			{
				Type = this.Type,
				SetTags = this.SetTags
			};
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600AF5B RID: 44891 RVA: 0x0018B0A9 File Offset: 0x001892A9
		// (set) Token: 0x0600AF5C RID: 44892 RVA: 0x0018B0D4 File Offset: 0x001892D4
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

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x0018B0E4 File Offset: 0x001892E4
		// (set) Token: 0x0600AF5E RID: 44894 RVA: 0x0018B177 File Offset: 0x00189377
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

		// Token: 0x0400686B RID: 26731
		[Nullable(2)]
		protected new ISetBattleTag FbInstance;

		// Token: 0x0400686C RID: 26732
		[Nullable(2)]
		protected new ISetBattleTag_SetValue PocoInterface;

		// Token: 0x0400686D RID: 26733
		private List<ISetEntityTag> _SetTagsCache;

		// Token: 0x0400686E RID: 26734
		private bool _SetTagsInited;
	}
}

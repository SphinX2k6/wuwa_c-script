using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E89 RID: 7817
	public class InterludeActions : ActionParams
	{
		// Token: 0x0600A62D RID: 42541 RVA: 0x0017AA68 File Offset: 0x00178C68
		private InterludeActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InterludeActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InterludeActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InterludeActions_SetValue());
			}
			return result;
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x0017AAA0 File Offset: 0x00178CA0
		public static InterludeActions Create([Nullable(2)] InterludeActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InterludeActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x0017AAB3 File Offset: 0x00178CB3
		public static InterludeActions CreateFromSetValue([Nullable(2)] InterludeActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InterludeActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x0017AAC6 File Offset: 0x00178CC6
		public InterludeActions_SetValue ToSetValue()
		{
			return new InterludeActions_SetValue
			{
				InterludeActionList = this.InterludeActionList,
				DestroyEntityIds = this.DestroyEntityIds,
				IsFadeIn = this.IsFadeIn,
				IsFadeOut = this.IsFadeOut
			};
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A631 RID: 42545 RVA: 0x0017AB00 File Offset: 0x00178D00
		// (set) Token: 0x0600A632 RID: 42546 RVA: 0x0017AB93 File Offset: 0x00178D93
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> InterludeActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._InterludeActionListInited)
				{
					return this._InterludeActionListCache;
				}
				this._InterludeActionListInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> interludeActionList = this.FbInstance.InterludeActionList;
					if (interludeActionList != null)
					{
						this._InterludeActionListCache = new List<ActionInfo>(interludeActionList.Count);
						for (int i = 0; i < interludeActionList.Count; i++)
						{
							this._InterludeActionListCache.Add(ActionInfo.Create(interludeActionList[i]));
						}
					}
				}
				else
				{
					InterludeActions_SetValue pocoInterface = this.PocoInterface;
					this._InterludeActionListCache = ((pocoInterface != null) ? pocoInterface.InterludeActionList : null);
				}
				return this._InterludeActionListCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().InterludeActionList = value;
				this._InterludeActionListInited = false;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A633 RID: 42547 RVA: 0x0017ABA8 File Offset: 0x00178DA8
		// (set) Token: 0x0600A634 RID: 42548 RVA: 0x0017ABCF File Offset: 0x00178DCF
		[Nullable(2)]
		public virtual List<int> DestroyEntityIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyEntityIds;
				}
				InterludeActions_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyEntityIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DestroyEntityIds = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A635 RID: 42549 RVA: 0x0017ABDD File Offset: 0x00178DDD
		// (set) Token: 0x0600A636 RID: 42550 RVA: 0x0017AC08 File Offset: 0x00178E08
		public virtual bool IsFadeIn
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFadeIn;
				}
				return this.PocoInterface != null && this.PocoInterface.IsFadeIn;
			}
			set
			{
				this.GetOrCreatePoco().IsFadeIn = value;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A637 RID: 42551 RVA: 0x0017AC16 File Offset: 0x00178E16
		// (set) Token: 0x0600A638 RID: 42552 RVA: 0x0017AC41 File Offset: 0x00178E41
		public virtual bool IsFadeOut
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFadeOut;
				}
				return this.PocoInterface != null && this.PocoInterface.IsFadeOut;
			}
			set
			{
				this.GetOrCreatePoco().IsFadeOut = value;
			}
		}

		// Token: 0x0400643E RID: 25662
		[Nullable(2)]
		protected new InterludeActions FbInstance;

		// Token: 0x0400643F RID: 25663
		[Nullable(2)]
		protected InterludeActions_SetValue PocoInterface;

		// Token: 0x04006440 RID: 25664
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _InterludeActionListCache;

		// Token: 0x04006441 RID: 25665
		private bool _InterludeActionListInited;
	}
}

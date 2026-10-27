using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C84 RID: 7300
	[NullableContext(2)]
	[Nullable(0)]
	public class InterludeActions : ActionParams
	{
		// Token: 0x06009C93 RID: 40083 RVA: 0x00167074 File Offset: 0x00165274
		[NullableContext(1)]
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

		// Token: 0x06009C94 RID: 40084 RVA: 0x001670AC File Offset: 0x001652AC
		[NullableContext(1)]
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

		// Token: 0x06009C95 RID: 40085 RVA: 0x001670BF File Offset: 0x001652BF
		[NullableContext(1)]
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

		// Token: 0x06009C96 RID: 40086 RVA: 0x001670D2 File Offset: 0x001652D2
		[NullableContext(1)]
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

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009C97 RID: 40087 RVA: 0x0016710C File Offset: 0x0016530C
		// (set) Token: 0x06009C98 RID: 40088 RVA: 0x0016719F File Offset: 0x0016539F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> InterludeActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().InterludeActionList = value;
				this._InterludeActionListInited = false;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009C99 RID: 40089 RVA: 0x001671B4 File Offset: 0x001653B4
		// (set) Token: 0x06009C9A RID: 40090 RVA: 0x001671DB File Offset: 0x001653DB
		public virtual List<int> DestroyEntityIds
		{
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
			set
			{
				this.GetOrCreatePoco().DestroyEntityIds = value;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009C9B RID: 40091 RVA: 0x001671E9 File Offset: 0x001653E9
		// (set) Token: 0x06009C9C RID: 40092 RVA: 0x00167214 File Offset: 0x00165414
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

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009C9D RID: 40093 RVA: 0x00167222 File Offset: 0x00165422
		// (set) Token: 0x06009C9E RID: 40094 RVA: 0x0016724D File Offset: 0x0016544D
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

		// Token: 0x04005EEB RID: 24299
		protected new InterludeActions FbInstance;

		// Token: 0x04005EEC RID: 24300
		protected InterludeActions_SetValue PocoInterface;

		// Token: 0x04005EED RID: 24301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _InterludeActionListCache;

		// Token: 0x04005EEE RID: 24302
		private bool _InterludeActionListInited;
	}
}

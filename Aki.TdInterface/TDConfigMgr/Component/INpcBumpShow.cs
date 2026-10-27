using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000558 RID: 1368
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcBumpShow
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x00050744 File Offset: 0x0004E944
		private INpcBumpShow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcBumpShow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcBumpShow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcBumpShow_SetValue());
			}
			return result;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0005077C File Offset: 0x0004E97C
		public static INpcBumpShow Create([Nullable(2)] INpcBumpShow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcBumpShow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0005078F File Offset: 0x0004E98F
		public static INpcBumpShow CreateFromSetValue([Nullable(2)] INpcBumpShow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcBumpShow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000507A2 File Offset: 0x0004E9A2
		public INpcBumpShow_SetValue ToSetValue()
		{
			return new INpcBumpShow_SetValue
			{
				BumpBubble = this.BumpBubble
			};
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000507B8 File Offset: 0x0004E9B8
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x00050819 File Offset: 0x0004EA19
		[Nullable(2)]
		public virtual INpcPerformBubble BumpBubble
		{
			[NullableContext(2)]
			get
			{
				if (this._BumpBubbleInited)
				{
					return this._BumpBubbleCache;
				}
				this._BumpBubbleInited = true;
				if (this.FbInstance != null)
				{
					this._BumpBubbleCache = INpcPerformBubble.Create(this.FbInstance.BumpBubble);
				}
				else
				{
					INpcBumpShow_SetValue pocoInterface = this.PocoInterface;
					this._BumpBubbleCache = ((pocoInterface != null) ? pocoInterface.BumpBubble : null);
				}
				return this._BumpBubbleCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BumpBubble = value;
				this._BumpBubbleInited = false;
			}
		}

		// Token: 0x0400140E RID: 5134
		[Nullable(2)]
		protected INpcBumpShow FbInstance;

		// Token: 0x0400140F RID: 5135
		[Nullable(2)]
		protected INpcBumpShow_SetValue PocoInterface;

		// Token: 0x04001410 RID: 5136
		private INpcPerformBubble _BumpBubbleCache;

		// Token: 0x04001411 RID: 5137
		private bool _BumpBubbleInited;
	}
}

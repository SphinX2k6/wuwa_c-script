using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A9 RID: 5289
	[NullableContext(1)]
	[Nullable(0)]
	public class AwakeEntity : ActionParams
	{
		// Token: 0x0600786C RID: 30828 RVA: 0x00120BA8 File Offset: 0x0011EDA8
		private AwakeEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AwakeEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AwakeEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AwakeEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00120BE0 File Offset: 0x0011EDE0
		public static AwakeEntity Create([Nullable(2)] AwakeEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AwakeEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00120BF3 File Offset: 0x0011EDF3
		public static AwakeEntity CreateFromSetValue([Nullable(2)] AwakeEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AwakeEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x00120C06 File Offset: 0x0011EE06
		public AwakeEntity_SetValue ToSetValue()
		{
			return new AwakeEntity_SetValue
			{
				Position = this.Position,
				IsSnap = this.IsSnap,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x00120C34 File Offset: 0x0011EE34
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x00120C95 File Offset: 0x0011EE95
		[Nullable(2)]
		public virtual IAwakeWithTransformVar Position
		{
			[NullableContext(2)]
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				if (this.FbInstance != null)
				{
					this._PositionCache = IAwakeWithTransformVar.Create(this.FbInstance.Position);
				}
				else
				{
					AwakeEntity_SetValue pocoInterface = this.PocoInterface;
					this._PositionCache = ((pocoInterface != null) ? pocoInterface.Position : null);
				}
				return this._PositionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Position = value;
				this._PositionInited = false;
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x00120CAC File Offset: 0x0011EEAC
		// (set) Token: 0x06007873 RID: 30835 RVA: 0x00120CE6 File Offset: 0x0011EEE6
		public virtual bool? IsSnap
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSnap;
				}
				AwakeEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSnap;
			}
			set
			{
				this.GetOrCreatePoco().IsSnap = value;
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x00120CF4 File Offset: 0x0011EEF4
		// (set) Token: 0x06007875 RID: 30837 RVA: 0x00120D1B File Offset: 0x0011EF1B
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				AwakeEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x040045FC RID: 17916
		[Nullable(2)]
		protected new AwakeEntity FbInstance;

		// Token: 0x040045FD RID: 17917
		[Nullable(2)]
		protected AwakeEntity_SetValue PocoInterface;

		// Token: 0x040045FE RID: 17918
		private IAwakeWithTransformVar _PositionCache;

		// Token: 0x040045FF RID: 17919
		private bool _PositionInited;
	}
}

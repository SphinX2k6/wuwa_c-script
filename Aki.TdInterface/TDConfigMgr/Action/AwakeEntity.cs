using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001602 RID: 5634
	public class AwakeEntity : ActionParams
	{
		// Token: 0x06007F39 RID: 32569 RVA: 0x0012F7F4 File Offset: 0x0012D9F4
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

		// Token: 0x06007F3A RID: 32570 RVA: 0x0012F82C File Offset: 0x0012DA2C
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

		// Token: 0x06007F3B RID: 32571 RVA: 0x0012F83F File Offset: 0x0012DA3F
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

		// Token: 0x06007F3C RID: 32572 RVA: 0x0012F852 File Offset: 0x0012DA52
		public AwakeEntity_SetValue ToSetValue()
		{
			return new AwakeEntity_SetValue
			{
				Position = this.Position,
				IsSnap = this.IsSnap,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x06007F3D RID: 32573 RVA: 0x0012F880 File Offset: 0x0012DA80
		// (set) Token: 0x06007F3E RID: 32574 RVA: 0x0012F8E1 File Offset: 0x0012DAE1
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

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x0012F8F8 File Offset: 0x0012DAF8
		// (set) Token: 0x06007F40 RID: 32576 RVA: 0x0012F932 File Offset: 0x0012DB32
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

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x06007F41 RID: 32577 RVA: 0x0012F940 File Offset: 0x0012DB40
		// (set) Token: 0x06007F42 RID: 32578 RVA: 0x0012F967 File Offset: 0x0012DB67
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

		// Token: 0x04004997 RID: 18839
		[Nullable(2)]
		protected new AwakeEntity FbInstance;

		// Token: 0x04004998 RID: 18840
		[Nullable(2)]
		protected AwakeEntity_SetValue PocoInterface;

		// Token: 0x04004999 RID: 18841
		private IAwakeWithTransformVar _PositionCache;

		// Token: 0x0400499A RID: 18842
		private bool _PositionInited;
	}
}

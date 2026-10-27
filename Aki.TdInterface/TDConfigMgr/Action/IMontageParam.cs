using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C08 RID: 7176
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageParam
	{
		// Token: 0x060099CB RID: 39371 RVA: 0x00161E5C File Offset: 0x0016005C
		private IMontageParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageParam_SetValue());
			}
			return result;
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x00161E94 File Offset: 0x00160094
		public static IMontageParam Create([Nullable(2)] IMontageParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00161EA7 File Offset: 0x001600A7
		public static IMontageParam CreateFromSetValue([Nullable(2)] IMontageParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00161EBA File Offset: 0x001600BA
		public IMontageParam_SetValue ToSetValue()
		{
			return new IMontageParam_SetValue
			{
				MontageId = this.MontageId,
				IsLoop = this.IsLoop,
				KeepPose = this.KeepPose,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x060099CF RID: 39375 RVA: 0x00161EF4 File Offset: 0x001600F4
		// (set) Token: 0x060099D0 RID: 39376 RVA: 0x00161F55 File Offset: 0x00160155
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IMontageParam_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x060099D1 RID: 39377 RVA: 0x00161F6C File Offset: 0x0016016C
		// (set) Token: 0x060099D2 RID: 39378 RVA: 0x00161FA6 File Offset: 0x001601A6
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x060099D3 RID: 39379 RVA: 0x00161FB4 File Offset: 0x001601B4
		// (set) Token: 0x060099D4 RID: 39380 RVA: 0x00161FEE File Offset: 0x001601EE
		public virtual bool? KeepPose
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPose;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPose;
			}
			set
			{
				this.GetOrCreatePoco().KeepPose = value;
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x00161FFC File Offset: 0x001601FC
		// (set) Token: 0x060099D6 RID: 39382 RVA: 0x00162036 File Offset: 0x00160236
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04005D9B RID: 23963
		[Nullable(2)]
		protected IMontageParam FbInstance;

		// Token: 0x04005D9C RID: 23964
		[Nullable(2)]
		protected IMontageParam_SetValue PocoInterface;

		// Token: 0x04005D9D RID: 23965
		private IMontageId _MontageIdCache;

		// Token: 0x04005D9E RID: 23966
		private bool _MontageIdInited;
	}
}

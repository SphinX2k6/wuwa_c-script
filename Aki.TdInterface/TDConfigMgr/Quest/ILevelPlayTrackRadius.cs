using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF7 RID: 4087
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayTrackRadius
	{
		// Token: 0x06005AEE RID: 23278 RVA: 0x000DCA50 File Offset: 0x000DAC50
		private ILevelPlayTrackRadius_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayTrackRadius 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayTrackRadius_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayTrackRadius_SetValue());
			}
			return result;
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x000DCA88 File Offset: 0x000DAC88
		public static ILevelPlayTrackRadius Create([Nullable(2)] ILevelPlayTrackRadius instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayTrackRadius
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x000DCA9B File Offset: 0x000DAC9B
		public static ILevelPlayTrackRadius CreateFromSetValue([Nullable(2)] ILevelPlayTrackRadius_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayTrackRadius
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x000DCAAE File Offset: 0x000DACAE
		public ILevelPlayTrackRadius_SetValue ToSetValue()
		{
			return new ILevelPlayTrackRadius_SetValue
			{
				TrackRadius = this.TrackRadius
			};
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x000DCAC1 File Offset: 0x000DACC1
		// (set) Token: 0x06005AF3 RID: 23283 RVA: 0x000DCAEC File Offset: 0x000DACEC
		public virtual int TrackRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrackRadius;
			}
			set
			{
				this.GetOrCreatePoco().TrackRadius = value;
			}
		}

		// Token: 0x040036B7 RID: 14007
		[Nullable(2)]
		protected ILevelPlayTrackRadius FbInstance;

		// Token: 0x040036B8 RID: 14008
		[Nullable(2)]
		protected ILevelPlayTrackRadius_SetValue PocoInterface;
	}
}

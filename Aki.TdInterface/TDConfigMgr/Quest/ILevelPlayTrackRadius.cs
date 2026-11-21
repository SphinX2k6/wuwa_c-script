using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001123 RID: 4387
	public class ILevelPlayTrackRadius
	{
		// Token: 0x060060CE RID: 24782 RVA: 0x000E9690 File Offset: 0x000E7890
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

		// Token: 0x060060CF RID: 24783 RVA: 0x000E96C8 File Offset: 0x000E78C8
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

		// Token: 0x060060D0 RID: 24784 RVA: 0x000E96DB File Offset: 0x000E78DB
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

		// Token: 0x060060D1 RID: 24785 RVA: 0x000E96EE File Offset: 0x000E78EE
		public ILevelPlayTrackRadius_SetValue ToSetValue()
		{
			return new ILevelPlayTrackRadius_SetValue
			{
				TrackRadius = this.TrackRadius
			};
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x060060D2 RID: 24786 RVA: 0x000E9701 File Offset: 0x000E7901
		// (set) Token: 0x060060D3 RID: 24787 RVA: 0x000E972C File Offset: 0x000E792C
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

		// Token: 0x040039EF RID: 14831
		[Nullable(2)]
		protected ILevelPlayTrackRadius FbInstance;

		// Token: 0x040039F0 RID: 14832
		[Nullable(2)]
		protected ILevelPlayTrackRadius_SetValue PocoInterface;
	}
}

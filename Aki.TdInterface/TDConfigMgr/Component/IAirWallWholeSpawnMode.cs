using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DA RID: 474
	public class IAirWallWholeSpawnMode : IAirWallSpawnMode
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x0002523C File Offset: 0x0002343C
		private IAirWallWholeSpawnMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallWholeSpawnMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallWholeSpawnMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallWholeSpawnMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00025274 File Offset: 0x00023474
		public static IAirWallWholeSpawnMode Create([Nullable(2)] IAirWallWholeSpawnMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallWholeSpawnMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00025287 File Offset: 0x00023487
		public static IAirWallWholeSpawnMode CreateFromSetValue([Nullable(2)] IAirWallWholeSpawnMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallWholeSpawnMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0002529C File Offset: 0x0002349C
		public new IAirWallWholeSpawnMode_SetValue ToSetValue()
		{
			return new IAirWallWholeSpawnMode_SetValue
			{
				Type = this.Type,
				SpawnStyle = this.SpawnStyle,
				Thickness = this.Thickness,
				Height = this.Height,
				Depth = this.Depth
			};
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x000252EA File Offset: 0x000234EA
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00025315 File Offset: 0x00023515
		public override EAirWallSpawnMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallSpawnMode.Whole;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00025323 File Offset: 0x00023523
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0002534A File Offset: 0x0002354A
		public virtual IAirWallSpawnStyle SpawnStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpawnStyle;
				}
				IAirWallWholeSpawnMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpawnStyle;
			}
			set
			{
				this.GetOrCreatePoco().SpawnStyle = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00025358 File Offset: 0x00023558
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00025387 File Offset: 0x00023587
		public virtual float Thickness
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Thickness;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Thickness;
			}
			set
			{
				this.GetOrCreatePoco().Thickness = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00025395 File Offset: 0x00023595
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000253C4 File Offset: 0x000235C4
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000253D2 File Offset: 0x000235D2
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00025401 File Offset: 0x00023601
		public virtual float Depth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Depth;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Depth;
			}
			set
			{
				this.GetOrCreatePoco().Depth = value;
			}
		}

		// Token: 0x040008D1 RID: 2257
		[Nullable(2)]
		protected new IAirWallWholeSpawnMode FbInstance;

		// Token: 0x040008D2 RID: 2258
		[Nullable(2)]
		protected new IAirWallWholeSpawnMode_SetValue PocoInterface;
	}
}

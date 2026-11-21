using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EE RID: 8942
	public class IVisualNovelPortraitPosPreset
	{
		// Token: 0x0600C2E6 RID: 49894 RVA: 0x001C0150 File Offset: 0x001BE350
		private IVisualNovelPortraitPosPreset_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPortraitPosPreset 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPortraitPosPreset_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPortraitPosPreset_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x001C0188 File Offset: 0x001BE388
		public static IVisualNovelPortraitPosPreset Create([Nullable(2)] IVisualNovelPortraitPosPreset instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPortraitPosPreset
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x001C019B File Offset: 0x001BE39B
		public static IVisualNovelPortraitPosPreset CreateFromSetValue([Nullable(2)] IVisualNovelPortraitPosPreset_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPortraitPosPreset
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x001C01AE File Offset: 0x001BE3AE
		public IVisualNovelPortraitPosPreset_SetValue ToSetValue()
		{
			return new IVisualNovelPortraitPosPreset_SetValue
			{
				Name = this.Name,
				PosX = this.PosX,
				PosY = this.PosY
			};
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600C2EA RID: 49898 RVA: 0x001C01D9 File Offset: 0x001BE3D9
		// (set) Token: 0x0600C2EB RID: 49899 RVA: 0x001C0204 File Offset: 0x001BE404
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600C2EC RID: 49900 RVA: 0x001C0212 File Offset: 0x001BE412
		// (set) Token: 0x0600C2ED RID: 49901 RVA: 0x001C023D File Offset: 0x001BE43D
		public virtual int PosX
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosX;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PosX;
			}
			set
			{
				this.GetOrCreatePoco().PosX = value;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600C2EE RID: 49902 RVA: 0x001C024B File Offset: 0x001BE44B
		// (set) Token: 0x0600C2EF RID: 49903 RVA: 0x001C0276 File Offset: 0x001BE476
		public virtual int PosY
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosY;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PosY;
			}
			set
			{
				this.GetOrCreatePoco().PosY = value;
			}
		}

		// Token: 0x0400744D RID: 29773
		[Nullable(2)]
		protected IVisualNovelPortraitPosPreset FbInstance;

		// Token: 0x0400744E RID: 29774
		[Nullable(2)]
		protected IVisualNovelPortraitPosPreset_SetValue PocoInterface;
	}
}

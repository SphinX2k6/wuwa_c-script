using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209D RID: 8349
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPortraitPosPreset
	{
		// Token: 0x0600B7A2 RID: 47010 RVA: 0x001A9724 File Offset: 0x001A7924
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

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x001A975C File Offset: 0x001A795C
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

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x001A976F File Offset: 0x001A796F
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

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x001A9782 File Offset: 0x001A7982
		public IVisualNovelPortraitPosPreset_SetValue ToSetValue()
		{
			return new IVisualNovelPortraitPosPreset_SetValue
			{
				Name = this.Name,
				PosX = this.PosX,
				PosY = this.PosY
			};
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x001A97AD File Offset: 0x001A79AD
		// (set) Token: 0x0600B7A7 RID: 47015 RVA: 0x001A97D8 File Offset: 0x001A79D8
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

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x001A97E6 File Offset: 0x001A79E6
		// (set) Token: 0x0600B7A9 RID: 47017 RVA: 0x001A9811 File Offset: 0x001A7A11
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

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B7AA RID: 47018 RVA: 0x001A981F File Offset: 0x001A7A1F
		// (set) Token: 0x0600B7AB RID: 47019 RVA: 0x001A984A File Offset: 0x001A7A4A
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

		// Token: 0x04006E37 RID: 28215
		[Nullable(2)]
		protected IVisualNovelPortraitPosPreset FbInstance;

		// Token: 0x04006E38 RID: 28216
		[Nullable(2)]
		protected IVisualNovelPortraitPosPreset_SetValue PocoInterface;
	}
}

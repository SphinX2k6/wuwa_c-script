using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D9 RID: 8409
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifySceneItemAttributeTag : ActionParams
	{
		// Token: 0x0600B8C0 RID: 47296 RVA: 0x001AB4D4 File Offset: 0x001A96D4
		private ModifySceneItemAttributeTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ModifySceneItemAttributeTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ModifySceneItemAttributeTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ModifySceneItemAttributeTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x001AB50C File Offset: 0x001A970C
		public static ModifySceneItemAttributeTag Create([Nullable(2)] ModifySceneItemAttributeTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifySceneItemAttributeTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x001AB51F File Offset: 0x001A971F
		public static ModifySceneItemAttributeTag CreateFromSetValue([Nullable(2)] ModifySceneItemAttributeTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ModifySceneItemAttributeTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x001AB532 File Offset: 0x001A9732
		public ModifySceneItemAttributeTag_SetValue ToSetValue()
		{
			return new ModifySceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x001AB55D File Offset: 0x001A975D
		// (set) Token: 0x0600B8C5 RID: 47301 RVA: 0x001AB588 File Offset: 0x001A9788
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x001AB596 File Offset: 0x001A9796
		// (set) Token: 0x0600B8C7 RID: 47303 RVA: 0x001AB5C1 File Offset: 0x001A97C1
		public virtual bool IsAddTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAddTag;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAddTag;
			}
			set
			{
				this.GetOrCreatePoco().IsAddTag = value;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x001AB5CF File Offset: 0x001A97CF
		// (set) Token: 0x0600B8C9 RID: 47305 RVA: 0x001AB5F6 File Offset: 0x001A97F6
		public virtual List<int> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				ModifySceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformanceTag;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceTag = value;
			}
		}

		// Token: 0x04006EAE RID: 28334
		[Nullable(2)]
		protected new ModifySceneItemAttributeTag FbInstance;

		// Token: 0x04006EAF RID: 28335
		[Nullable(2)]
		protected ModifySceneItemAttributeTag_SetValue PocoInterface;
	}
}

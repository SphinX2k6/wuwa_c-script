using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002338 RID: 9016
	public class ModifySceneItemAttributeTag : ActionParams
	{
		// Token: 0x0600C442 RID: 50242 RVA: 0x001C24F8 File Offset: 0x001C06F8
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

		// Token: 0x0600C443 RID: 50243 RVA: 0x001C2530 File Offset: 0x001C0730
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

		// Token: 0x0600C444 RID: 50244 RVA: 0x001C2543 File Offset: 0x001C0743
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

		// Token: 0x0600C445 RID: 50245 RVA: 0x001C2556 File Offset: 0x001C0756
		public ModifySceneItemAttributeTag_SetValue ToSetValue()
		{
			return new ModifySceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600C446 RID: 50246 RVA: 0x001C2581 File Offset: 0x001C0781
		// (set) Token: 0x0600C447 RID: 50247 RVA: 0x001C25AC File Offset: 0x001C07AC
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

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600C448 RID: 50248 RVA: 0x001C25BA File Offset: 0x001C07BA
		// (set) Token: 0x0600C449 RID: 50249 RVA: 0x001C25E5 File Offset: 0x001C07E5
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

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600C44A RID: 50250 RVA: 0x001C25F3 File Offset: 0x001C07F3
		// (set) Token: 0x0600C44B RID: 50251 RVA: 0x001C261A File Offset: 0x001C081A
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

		// Token: 0x040074DC RID: 29916
		[Nullable(2)]
		protected new ModifySceneItemAttributeTag FbInstance;

		// Token: 0x040074DD RID: 29917
		[Nullable(2)]
		protected ModifySceneItemAttributeTag_SetValue PocoInterface;
	}
}

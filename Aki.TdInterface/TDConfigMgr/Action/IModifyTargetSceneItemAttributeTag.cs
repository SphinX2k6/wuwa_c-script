using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDD RID: 7645
	public class IModifyTargetSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600A24B RID: 41547 RVA: 0x00173734 File Offset: 0x00171934
		private IModifyTargetSceneItemAttributeTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyTargetSceneItemAttributeTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyTargetSceneItemAttributeTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyTargetSceneItemAttributeTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x0017376C File Offset: 0x0017196C
		public static IModifyTargetSceneItemAttributeTag Create([Nullable(2)] IModifyTargetSceneItemAttributeTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTargetSceneItemAttributeTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x0017377F File Offset: 0x0017197F
		public static IModifyTargetSceneItemAttributeTag CreateFromSetValue([Nullable(2)] IModifyTargetSceneItemAttributeTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyTargetSceneItemAttributeTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x00173792 File Offset: 0x00171992
		public new IModifyTargetSceneItemAttributeTag_SetValue ToSetValue()
		{
			return new IModifyTargetSceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A24F RID: 41551 RVA: 0x001737C9 File Offset: 0x001719C9
		// (set) Token: 0x0600A250 RID: 41552 RVA: 0x001737F4 File Offset: 0x001719F4
		public override EChangeEntityPrefabPerformanceType Type
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

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x00173802 File Offset: 0x00171A02
		// (set) Token: 0x0600A252 RID: 41554 RVA: 0x0017382D File Offset: 0x00171A2D
		public override bool IsAddTag
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

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x0017383B File Offset: 0x00171A3B
		// (set) Token: 0x0600A254 RID: 41556 RVA: 0x00173862 File Offset: 0x00171A62
		public override List<int> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				IModifyTargetSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A255 RID: 41557 RVA: 0x00173870 File Offset: 0x00171A70
		// (set) Token: 0x0600A256 RID: 41558 RVA: 0x00173897 File Offset: 0x00171A97
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IModifyTargetSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400626B RID: 25195
		[Nullable(2)]
		protected new IModifyTargetSceneItemAttributeTag FbInstance;

		// Token: 0x0400626C RID: 25196
		[Nullable(2)]
		protected new IModifyTargetSceneItemAttributeTag_SetValue PocoInterface;
	}
}

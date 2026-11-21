using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDB RID: 7643
	public class IModifySelfSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600A23F RID: 41535 RVA: 0x001735F4 File Offset: 0x001717F4
		private IModifySelfSceneItemAttributeTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifySelfSceneItemAttributeTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifySelfSceneItemAttributeTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifySelfSceneItemAttributeTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x0017362C File Offset: 0x0017182C
		public static IModifySelfSceneItemAttributeTag Create([Nullable(2)] IModifySelfSceneItemAttributeTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0017363F File Offset: 0x0017183F
		public static IModifySelfSceneItemAttributeTag CreateFromSetValue([Nullable(2)] IModifySelfSceneItemAttributeTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x00173652 File Offset: 0x00171852
		public new IModifySelfSceneItemAttributeTag_SetValue ToSetValue()
		{
			return new IModifySelfSceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A243 RID: 41539 RVA: 0x0017367D File Offset: 0x0017187D
		// (set) Token: 0x0600A244 RID: 41540 RVA: 0x001736A8 File Offset: 0x001718A8
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

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x001736B6 File Offset: 0x001718B6
		// (set) Token: 0x0600A246 RID: 41542 RVA: 0x001736E1 File Offset: 0x001718E1
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

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A247 RID: 41543 RVA: 0x001736EF File Offset: 0x001718EF
		// (set) Token: 0x0600A248 RID: 41544 RVA: 0x00173716 File Offset: 0x00171916
		public override List<int> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				IModifySelfSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006266 RID: 25190
		[Nullable(2)]
		protected new IModifySelfSceneItemAttributeTag FbInstance;

		// Token: 0x04006267 RID: 25191
		[Nullable(2)]
		protected new IModifySelfSceneItemAttributeTag_SetValue PocoInterface;
	}
}

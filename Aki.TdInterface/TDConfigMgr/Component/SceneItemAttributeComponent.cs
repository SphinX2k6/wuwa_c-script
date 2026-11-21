using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000930 RID: 2352
	public class SceneItemAttributeComponent : IComponentBase
	{
		// Token: 0x06003409 RID: 13321 RVA: 0x00084DD4 File Offset: 0x00082FD4
		private SceneItemAttributeComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneItemAttributeComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneItemAttributeComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneItemAttributeComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00084E0C File Offset: 0x0008300C
		public static SceneItemAttributeComponent Create([Nullable(2)] SceneItemAttributeComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemAttributeComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00084E1F File Offset: 0x0008301F
		public static SceneItemAttributeComponent CreateFromSetValue([Nullable(2)] SceneItemAttributeComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneItemAttributeComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00084E32 File Offset: 0x00083032
		public new SceneItemAttributeComponent_SetValue ToSetValue()
		{
			return new SceneItemAttributeComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AttributeType = this.AttributeType,
				DefaultTags = this.DefaultTags
			};
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x00084E6C File Offset: 0x0008306C
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x00084EA6 File Offset: 0x000830A6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneItemAttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x00084EB4 File Offset: 0x000830B4
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x00084EDE File Offset: 0x000830DE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x00084EEC File Offset: 0x000830EC
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x00084F17 File Offset: 0x00083117
		public virtual string AttributeType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttributeType;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AttributeType;
			}
			set
			{
				this.GetOrCreatePoco().AttributeType = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x00084F25 File Offset: 0x00083125
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x00084F4C File Offset: 0x0008314C
		[Nullable(2)]
		public virtual List<int> DefaultTags
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultTags;
				}
				SceneItemAttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DefaultTags;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DefaultTags = value;
			}
		}

		// Token: 0x0400222E RID: 8750
		[Nullable(2)]
		protected new SceneItemAttributeComponent FbInstance;

		// Token: 0x0400222F RID: 8751
		[Nullable(2)]
		protected new SceneItemAttributeComponent_SetValue PocoInterface;
	}
}

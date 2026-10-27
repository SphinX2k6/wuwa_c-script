using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088D RID: 2189
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAttributeComponent : IComponentBase
	{
		// Token: 0x060030CD RID: 12493 RVA: 0x0007D8EC File Offset: 0x0007BAEC
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

		// Token: 0x060030CE RID: 12494 RVA: 0x0007D924 File Offset: 0x0007BB24
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

		// Token: 0x060030CF RID: 12495 RVA: 0x0007D937 File Offset: 0x0007BB37
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

		// Token: 0x060030D0 RID: 12496 RVA: 0x0007D94A File Offset: 0x0007BB4A
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0007D984 File Offset: 0x0007BB84
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x0007D9BE File Offset: 0x0007BBBE
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x0007D9F6 File Offset: 0x0007BBF6
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

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0007DA04 File Offset: 0x0007BC04
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x0007DA2F File Offset: 0x0007BC2F
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

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0007DA3D File Offset: 0x0007BC3D
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x0007DA64 File Offset: 0x0007BC64
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

		// Token: 0x0400201C RID: 8220
		[Nullable(2)]
		protected new SceneItemAttributeComponent FbInstance;

		// Token: 0x0400201D RID: 8221
		[Nullable(2)]
		protected new SceneItemAttributeComponent_SetValue PocoInterface;
	}
}

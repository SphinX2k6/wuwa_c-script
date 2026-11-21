using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002007 RID: 8199
	public class ISceneUiSubtitleLanguageOverride
	{
		// Token: 0x0600AE1F RID: 44575 RVA: 0x00188C20 File Offset: 0x00186E20
		private ISceneUiSubtitleLanguageOverride_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleLanguageOverride 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleLanguageOverride_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleLanguageOverride_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x00188C58 File Offset: 0x00186E58
		public static ISceneUiSubtitleLanguageOverride Create([Nullable(2)] ISceneUiSubtitleLanguageOverride instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLanguageOverride
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x00188C6B File Offset: 0x00186E6B
		public static ISceneUiSubtitleLanguageOverride CreateFromSetValue([Nullable(2)] ISceneUiSubtitleLanguageOverride_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLanguageOverride
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x00188C7E File Offset: 0x00186E7E
		public ISceneUiSubtitleLanguageOverride_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleLanguageOverride_SetValue
			{
				Language = this.Language,
				Position = this.Position,
				Scale = this.Scale
			};
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600AE23 RID: 44579 RVA: 0x00188CA9 File Offset: 0x00186EA9
		// (set) Token: 0x0600AE24 RID: 44580 RVA: 0x00188CD4 File Offset: 0x00186ED4
		public virtual string Language
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Language;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Language;
			}
			set
			{
				this.GetOrCreatePoco().Language = value;
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600AE25 RID: 44581 RVA: 0x00188CE2 File Offset: 0x00186EE2
		// (set) Token: 0x0600AE26 RID: 44582 RVA: 0x00188D09 File Offset: 0x00186F09
		[Nullable(2)]
		public virtual ISceneUiSubtitlePositionBase Position
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Position;
				}
				ISceneUiSubtitleLanguageOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Position;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Position = value;
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600AE27 RID: 44583 RVA: 0x00188D18 File Offset: 0x00186F18
		// (set) Token: 0x0600AE28 RID: 44584 RVA: 0x00188D52 File Offset: 0x00186F52
		public virtual float? Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				ISceneUiSubtitleLanguageOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x040067D6 RID: 26582
		[Nullable(2)]
		protected ISceneUiSubtitleLanguageOverride FbInstance;

		// Token: 0x040067D7 RID: 26583
		[Nullable(2)]
		protected ISceneUiSubtitleLanguageOverride_SetValue PocoInterface;
	}
}

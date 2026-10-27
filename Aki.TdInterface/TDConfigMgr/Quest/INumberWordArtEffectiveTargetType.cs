using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200102D RID: 4141
	[NullableContext(1)]
	[Nullable(0)]
	public class INumberWordArtEffectiveTargetType : IWordArtEffectiveTargetType
	{
		// Token: 0x06005C5E RID: 23646 RVA: 0x000DFBB0 File Offset: 0x000DDDB0
		private INumberWordArtEffectiveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INumberWordArtEffectiveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INumberWordArtEffectiveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INumberWordArtEffectiveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x000DFBE8 File Offset: 0x000DDDE8
		public static INumberWordArtEffectiveTargetType Create([Nullable(2)] INumberWordArtEffectiveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x000DFBFB File Offset: 0x000DDDFB
		public static INumberWordArtEffectiveTargetType CreateFromSetValue([Nullable(2)] INumberWordArtEffectiveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x000DFC0E File Offset: 0x000DDE0E
		public new INumberWordArtEffectiveTargetType_SetValue ToSetValue()
		{
			return new INumberWordArtEffectiveTargetType_SetValue
			{
				Type = this.Type,
				ShowUiMotion = this.ShowUiMotion
			};
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x000DFC2D File Offset: 0x000DDE2D
		// (set) Token: 0x06005C63 RID: 23651 RVA: 0x000DFC58 File Offset: 0x000DDE58
		public override EWordArtEffectiveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWordArtEffectiveTargetType.Number;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x000DFC68 File Offset: 0x000DDE68
		// (set) Token: 0x06005C65 RID: 23653 RVA: 0x000DFCA2 File Offset: 0x000DDEA2
		public virtual bool? ShowUiMotion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowUiMotion;
				}
				INumberWordArtEffectiveTargetType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowUiMotion;
			}
			set
			{
				this.GetOrCreatePoco().ShowUiMotion = value;
			}
		}

		// Token: 0x04003790 RID: 14224
		[Nullable(2)]
		protected new INumberWordArtEffectiveTargetType FbInstance;

		// Token: 0x04003791 RID: 14225
		[Nullable(2)]
		protected new INumberWordArtEffectiveTargetType_SetValue PocoInterface;
	}
}

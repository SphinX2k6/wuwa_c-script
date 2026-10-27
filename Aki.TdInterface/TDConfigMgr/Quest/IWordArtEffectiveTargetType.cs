using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001216 RID: 4630
	[NullableContext(1)]
	[Nullable(0)]
	public class IWordArtEffectiveTargetType
	{
		// Token: 0x06006906 RID: 26886 RVA: 0x000FA6DC File Offset: 0x000F88DC
		private IWordArtEffectiveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtEffectiveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtEffectiveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtEffectiveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x000FA714 File Offset: 0x000F8914
		public static IWordArtEffectiveTargetType Create([Nullable(2)] IWordArtEffectiveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtEffectiveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x000FA727 File Offset: 0x000F8927
		public static IWordArtEffectiveTargetType CreateFromSetValue([Nullable(2)] IWordArtEffectiveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtEffectiveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x000FA73A File Offset: 0x000F893A
		public IWordArtEffectiveTargetType_SetValue ToSetValue()
		{
			return new IWordArtEffectiveTargetType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x000FA74D File Offset: 0x000F894D
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x000FA778 File Offset: 0x000F8978
		public virtual EWordArtEffectiveTargetType Type
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

		// Token: 0x04003ED0 RID: 16080
		[Nullable(2)]
		protected IWordArtEffectiveTargetType FbInstance;

		// Token: 0x04003ED1 RID: 16081
		[Nullable(2)]
		protected IWordArtEffectiveTargetType_SetValue PocoInterface;
	}
}

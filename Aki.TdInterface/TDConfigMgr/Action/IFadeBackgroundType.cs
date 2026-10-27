using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A53 RID: 6739
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundTypeConverter))]
	public class IFadeBackgroundType
	{
		// Token: 0x06009046 RID: 36934 RVA: 0x00150674 File Offset: 0x0014E874
		private IFadeBackgroundType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundType_SetValue());
			}
			return result;
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x001506AC File Offset: 0x0014E8AC
		public static IFadeBackgroundType Create([Nullable(2)] IFadeBackgroundType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x001506BF File Offset: 0x0014E8BF
		public static IFadeBackgroundType CreateFromSetValue([Nullable(2)] IFadeBackgroundType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x001506D2 File Offset: 0x0014E8D2
		public IFadeBackgroundType_SetValue ToSetValue()
		{
			return new IFadeBackgroundType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600904A RID: 36938 RVA: 0x001506E5 File Offset: 0x0014E8E5
		// (set) Token: 0x0600904B RID: 36939 RVA: 0x00150710 File Offset: 0x0014E910
		public virtual EFadeBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400591F RID: 22815
		[Nullable(2)]
		protected IFadeBackgroundType FbInstance;

		// Token: 0x04005920 RID: 22816
		[Nullable(2)]
		protected IFadeBackgroundType_SetValue PocoInterface;
	}
}

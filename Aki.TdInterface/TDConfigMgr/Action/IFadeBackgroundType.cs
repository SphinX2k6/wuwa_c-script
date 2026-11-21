using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE8 RID: 7144
	[JsonConverter(typeof(IFadeBackgroundTypeConverter))]
	public class IFadeBackgroundType
	{
		// Token: 0x060097B0 RID: 38832 RVA: 0x001605A0 File Offset: 0x0015E7A0
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

		// Token: 0x060097B1 RID: 38833 RVA: 0x001605D8 File Offset: 0x0015E7D8
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

		// Token: 0x060097B2 RID: 38834 RVA: 0x001605EB File Offset: 0x0015E7EB
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

		// Token: 0x060097B3 RID: 38835 RVA: 0x001605FE File Offset: 0x0015E7FE
		public IFadeBackgroundType_SetValue ToSetValue()
		{
			return new IFadeBackgroundType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x060097B4 RID: 38836 RVA: 0x00160611 File Offset: 0x0015E811
		// (set) Token: 0x060097B5 RID: 38837 RVA: 0x0016063C File Offset: 0x0015E83C
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

		// Token: 0x04005D84 RID: 23940
		[Nullable(2)]
		protected IFadeBackgroundType FbInstance;

		// Token: 0x04005D85 RID: 23941
		[Nullable(2)]
		protected IFadeBackgroundType_SetValue PocoInterface;
	}
}

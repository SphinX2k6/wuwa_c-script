using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F7 RID: 759
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSplineEquidistantPointMode : IEffectSplineCreationMode
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x00034BB8 File Offset: 0x00032DB8
		private IEffectSplineEquidistantPointMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSplineEquidistantPointMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSplineEquidistantPointMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSplineEquidistantPointMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00034BF0 File Offset: 0x00032DF0
		public static IEffectSplineEquidistantPointMode Create([Nullable(2)] IEffectSplineEquidistantPointMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineEquidistantPointMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00034C03 File Offset: 0x00032E03
		public static IEffectSplineEquidistantPointMode CreateFromSetValue([Nullable(2)] IEffectSplineEquidistantPointMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSplineEquidistantPointMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00034C16 File Offset: 0x00032E16
		public new IEffectSplineEquidistantPointMode_SetValue ToSetValue()
		{
			return new IEffectSplineEquidistantPointMode_SetValue
			{
				Type = this.Type,
				Space = this.Space
			};
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00034C35 File Offset: 0x00032E35
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00034C60 File Offset: 0x00032E60
		public override EEffectSplineCreateMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00034C6E File Offset: 0x00032E6E
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00034C99 File Offset: 0x00032E99
		public virtual int Space
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Space;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Space;
			}
			set
			{
				this.GetOrCreatePoco().Space = value;
			}
		}

		// Token: 0x04000CE2 RID: 3298
		[Nullable(2)]
		protected new IEffectSplineEquidistantPointMode FbInstance;

		// Token: 0x04000CE3 RID: 3299
		[Nullable(2)]
		protected new IEffectSplineEquidistantPointMode_SetValue PocoInterface;
	}
}

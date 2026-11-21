using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCE RID: 7118
	public class IFaceExpressionMorphConfig : IFaceExpressionConfig
	{
		// Token: 0x06009724 RID: 38692 RVA: 0x0015F614 File Offset: 0x0015D814
		private IFaceExpressionMorphConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionMorphConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionMorphConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionMorphConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x0015F64C File Offset: 0x0015D84C
		public static IFaceExpressionMorphConfig Create([Nullable(2)] IFaceExpressionMorphConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionMorphConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x0015F65F File Offset: 0x0015D85F
		public static IFaceExpressionMorphConfig CreateFromSetValue([Nullable(2)] IFaceExpressionMorphConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionMorphConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0015F672 File Offset: 0x0015D872
		public new IFaceExpressionMorphConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionMorphConfig_SetValue
			{
				Type = this.Type,
				MorphData = this.MorphData
			};
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x06009728 RID: 38696 RVA: 0x0015F691 File Offset: 0x0015D891
		// (set) Token: 0x06009729 RID: 38697 RVA: 0x0015F6BC File Offset: 0x0015D8BC
		public override EFaceExpressionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600972A RID: 38698 RVA: 0x0015F6CA File Offset: 0x0015D8CA
		// (set) Token: 0x0600972B RID: 38699 RVA: 0x0015F6F5 File Offset: 0x0015D8F5
		public virtual string MorphData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MorphData;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MorphData;
			}
			set
			{
				this.GetOrCreatePoco().MorphData = value;
			}
		}

		// Token: 0x04005D43 RID: 23875
		[Nullable(2)]
		protected new IFaceExpressionMorphConfig FbInstance;

		// Token: 0x04005D44 RID: 23876
		[Nullable(2)]
		protected new IFaceExpressionMorphConfig_SetValue PocoInterface;
	}
}

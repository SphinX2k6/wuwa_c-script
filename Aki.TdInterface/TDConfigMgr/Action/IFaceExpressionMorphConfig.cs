using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A39 RID: 6713
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionMorphConfig : IFaceExpressionConfig
	{
		// Token: 0x06008FBA RID: 36794 RVA: 0x0014F6E8 File Offset: 0x0014D8E8
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

		// Token: 0x06008FBB RID: 36795 RVA: 0x0014F720 File Offset: 0x0014D920
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

		// Token: 0x06008FBC RID: 36796 RVA: 0x0014F733 File Offset: 0x0014D933
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

		// Token: 0x06008FBD RID: 36797 RVA: 0x0014F746 File Offset: 0x0014D946
		public new IFaceExpressionMorphConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionMorphConfig_SetValue
			{
				Type = this.Type,
				MorphData = this.MorphData
			};
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x0014F765 File Offset: 0x0014D965
		// (set) Token: 0x06008FBF RID: 36799 RVA: 0x0014F790 File Offset: 0x0014D990
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

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x0014F79E File Offset: 0x0014D99E
		// (set) Token: 0x06008FC1 RID: 36801 RVA: 0x0014F7C9 File Offset: 0x0014D9C9
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

		// Token: 0x040058DE RID: 22750
		[Nullable(2)]
		protected new IFaceExpressionMorphConfig FbInstance;

		// Token: 0x040058DF RID: 22751
		[Nullable(2)]
		protected new IFaceExpressionMorphConfig_SetValue PocoInterface;
	}
}

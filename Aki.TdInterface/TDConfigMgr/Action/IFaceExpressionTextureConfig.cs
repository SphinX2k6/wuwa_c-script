using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3B RID: 6715
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionTextureConfig : IFaceExpressionConfig
	{
		// Token: 0x06008FC4 RID: 36804 RVA: 0x0014F7E8 File Offset: 0x0014D9E8
		private IFaceExpressionTextureConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionTextureConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionTextureConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionTextureConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0014F820 File Offset: 0x0014DA20
		public static IFaceExpressionTextureConfig Create([Nullable(2)] IFaceExpressionTextureConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionTextureConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0014F833 File Offset: 0x0014DA33
		public static IFaceExpressionTextureConfig CreateFromSetValue([Nullable(2)] IFaceExpressionTextureConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionTextureConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x0014F846 File Offset: 0x0014DA46
		public new IFaceExpressionTextureConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionTextureConfig_SetValue
			{
				Type = this.Type,
				FaceIndex = this.FaceIndex
			};
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x0014F865 File Offset: 0x0014DA65
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x0014F890 File Offset: 0x0014DA90
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

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0014F89E File Offset: 0x0014DA9E
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x0014F8C9 File Offset: 0x0014DAC9
		public virtual int FaceIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FaceIndex;
			}
			set
			{
				this.GetOrCreatePoco().FaceIndex = value;
			}
		}

		// Token: 0x040058E2 RID: 22754
		[Nullable(2)]
		protected new IFaceExpressionTextureConfig FbInstance;

		// Token: 0x040058E3 RID: 22755
		[Nullable(2)]
		protected new IFaceExpressionTextureConfig_SetValue PocoInterface;
	}
}

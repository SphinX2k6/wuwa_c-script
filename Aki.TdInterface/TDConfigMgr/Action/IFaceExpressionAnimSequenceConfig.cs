using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A33 RID: 6707
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionAnimSequenceConfig : IFaceExpressionConfig
	{
		// Token: 0x06008F9A RID: 36762 RVA: 0x0014F39C File Offset: 0x0014D59C
		private IFaceExpressionAnimSequenceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionAnimSequenceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionAnimSequenceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionAnimSequenceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x0014F3D4 File Offset: 0x0014D5D4
		public static IFaceExpressionAnimSequenceConfig Create([Nullable(2)] IFaceExpressionAnimSequenceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionAnimSequenceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0014F3E7 File Offset: 0x0014D5E7
		public static IFaceExpressionAnimSequenceConfig CreateFromSetValue([Nullable(2)] IFaceExpressionAnimSequenceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionAnimSequenceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x0014F3FA File Offset: 0x0014D5FA
		public new IFaceExpressionAnimSequenceConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionAnimSequenceConfig_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x06008F9E RID: 36766 RVA: 0x0014F419 File Offset: 0x0014D619
		// (set) Token: 0x06008F9F RID: 36767 RVA: 0x0014F444 File Offset: 0x0014D644
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

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x06008FA0 RID: 36768 RVA: 0x0014F452 File Offset: 0x0014D652
		// (set) Token: 0x06008FA1 RID: 36769 RVA: 0x0014F47D File Offset: 0x0014D67D
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x040058D1 RID: 22737
		[Nullable(2)]
		protected new IFaceExpressionAnimSequenceConfig FbInstance;

		// Token: 0x040058D2 RID: 22738
		[Nullable(2)]
		protected new IFaceExpressionAnimSequenceConfig_SetValue PocoInterface;
	}
}

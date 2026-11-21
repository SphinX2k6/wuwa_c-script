using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC8 RID: 7112
	public class IFaceExpressionAnimSequenceConfig : IFaceExpressionConfig
	{
		// Token: 0x06009704 RID: 38660 RVA: 0x0015F2C8 File Offset: 0x0015D4C8
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

		// Token: 0x06009705 RID: 38661 RVA: 0x0015F300 File Offset: 0x0015D500
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

		// Token: 0x06009706 RID: 38662 RVA: 0x0015F313 File Offset: 0x0015D513
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

		// Token: 0x06009707 RID: 38663 RVA: 0x0015F326 File Offset: 0x0015D526
		public new IFaceExpressionAnimSequenceConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionAnimSequenceConfig_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x06009708 RID: 38664 RVA: 0x0015F345 File Offset: 0x0015D545
		// (set) Token: 0x06009709 RID: 38665 RVA: 0x0015F370 File Offset: 0x0015D570
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x0015F37E File Offset: 0x0015D57E
		// (set) Token: 0x0600970B RID: 38667 RVA: 0x0015F3A9 File Offset: 0x0015D5A9
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

		// Token: 0x04005D36 RID: 23862
		[Nullable(2)]
		protected new IFaceExpressionAnimSequenceConfig FbInstance;

		// Token: 0x04005D37 RID: 23863
		[Nullable(2)]
		protected new IFaceExpressionAnimSequenceConfig_SetValue PocoInterface;
	}
}

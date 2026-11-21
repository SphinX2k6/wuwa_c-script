using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD0 RID: 7120
	public class IFaceExpressionTextureConfig : IFaceExpressionConfig
	{
		// Token: 0x0600972E RID: 38702 RVA: 0x0015F714 File Offset: 0x0015D914
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

		// Token: 0x0600972F RID: 38703 RVA: 0x0015F74C File Offset: 0x0015D94C
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

		// Token: 0x06009730 RID: 38704 RVA: 0x0015F75F File Offset: 0x0015D95F
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

		// Token: 0x06009731 RID: 38705 RVA: 0x0015F772 File Offset: 0x0015D972
		public new IFaceExpressionTextureConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionTextureConfig_SetValue
			{
				Type = this.Type,
				FaceIndex = this.FaceIndex
			};
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x06009732 RID: 38706 RVA: 0x0015F791 File Offset: 0x0015D991
		// (set) Token: 0x06009733 RID: 38707 RVA: 0x0015F7BC File Offset: 0x0015D9BC
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

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x06009734 RID: 38708 RVA: 0x0015F7CA File Offset: 0x0015D9CA
		// (set) Token: 0x06009735 RID: 38709 RVA: 0x0015F7F5 File Offset: 0x0015D9F5
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

		// Token: 0x04005D47 RID: 23879
		[Nullable(2)]
		protected new IFaceExpressionTextureConfig FbInstance;

		// Token: 0x04005D48 RID: 23880
		[Nullable(2)]
		protected new IFaceExpressionTextureConfig_SetValue PocoInterface;
	}
}

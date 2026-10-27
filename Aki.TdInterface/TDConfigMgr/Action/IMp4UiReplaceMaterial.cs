using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C50 RID: 7248
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4UiReplaceMaterial : IProgramSpecialConfigBase
	{
		// Token: 0x06009B7D RID: 39805 RVA: 0x00165240 File Offset: 0x00163440
		private IMp4UiReplaceMaterial_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4UiReplaceMaterial 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4UiReplaceMaterial_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4UiReplaceMaterial_SetValue());
			}
			return result;
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x00165278 File Offset: 0x00163478
		public static IMp4UiReplaceMaterial Create([Nullable(2)] IMp4UiReplaceMaterial instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x0016528B File Offset: 0x0016348B
		public static IMp4UiReplaceMaterial CreateFromSetValue([Nullable(2)] IMp4UiReplaceMaterial_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x0016529E File Offset: 0x0016349E
		public new IMp4UiReplaceMaterial_SetValue ToSetValue()
		{
			return new IMp4UiReplaceMaterial_SetValue
			{
				Type = this.Type,
				Mp4UiReplaceMaterial = this.Mp4UiReplaceMaterial
			};
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x001652BD File Offset: 0x001634BD
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x001652E8 File Offset: 0x001634E8
		public override EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x001652F6 File Offset: 0x001634F6
		// (set) Token: 0x06009B84 RID: 39812 RVA: 0x00165321 File Offset: 0x00163521
		public virtual string Mp4UiReplaceMaterial
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4UiReplaceMaterial;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mp4UiReplaceMaterial;
			}
			set
			{
				this.GetOrCreatePoco().Mp4UiReplaceMaterial = value;
			}
		}

		// Token: 0x04005E70 RID: 24176
		[Nullable(2)]
		protected new IMp4UiReplaceMaterial FbInstance;

		// Token: 0x04005E71 RID: 24177
		[Nullable(2)]
		protected new IMp4UiReplaceMaterial_SetValue PocoInterface;
	}
}

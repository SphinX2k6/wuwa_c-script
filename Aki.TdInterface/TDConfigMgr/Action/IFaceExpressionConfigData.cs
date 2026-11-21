using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCC RID: 7116
	public class IFaceExpressionConfigData
	{
		// Token: 0x06009716 RID: 38678 RVA: 0x0015F484 File Offset: 0x0015D684
		private IFaceExpressionConfigData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionConfigData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionConfigData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionConfigData_SetValue());
			}
			return result;
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x0015F4BC File Offset: 0x0015D6BC
		public static IFaceExpressionConfigData Create([Nullable(2)] IFaceExpressionConfigData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionConfigData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x0015F4CF File Offset: 0x0015D6CF
		public static IFaceExpressionConfigData CreateFromSetValue([Nullable(2)] IFaceExpressionConfigData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionConfigData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x0015F4E2 File Offset: 0x0015D6E2
		public IFaceExpressionConfigData_SetValue ToSetValue()
		{
			return new IFaceExpressionConfigData_SetValue
			{
				Id = this.Id,
				FaceExpression = this.FaceExpression,
				MaleVariant = this.MaleVariant,
				CloseAutoBlink = this.CloseAutoBlink
			};
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x0015F519 File Offset: 0x0015D719
		// (set) Token: 0x0600971B RID: 38683 RVA: 0x0015F544 File Offset: 0x0015D744
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600971C RID: 38684 RVA: 0x0015F552 File Offset: 0x0015D752
		// (set) Token: 0x0600971D RID: 38685 RVA: 0x0015F579 File Offset: 0x0015D779
		public virtual IFaceExpressionConfig FaceExpression
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpression;
				}
				IFaceExpressionConfigData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpression;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpression = value;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600971E RID: 38686 RVA: 0x0015F587 File Offset: 0x0015D787
		// (set) Token: 0x0600971F RID: 38687 RVA: 0x0015F5AE File Offset: 0x0015D7AE
		[Nullable(2)]
		public virtual IFaceExpressionConfig MaleVariant
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaleVariant;
				}
				IFaceExpressionConfigData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaleVariant;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MaleVariant = value;
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x06009720 RID: 38688 RVA: 0x0015F5BC File Offset: 0x0015D7BC
		// (set) Token: 0x06009721 RID: 38689 RVA: 0x0015F5F6 File Offset: 0x0015D7F6
		public virtual bool? CloseAutoBlink
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CloseAutoBlink;
				}
				IFaceExpressionConfigData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CloseAutoBlink;
			}
			set
			{
				this.GetOrCreatePoco().CloseAutoBlink = value;
			}
		}

		// Token: 0x04005D3D RID: 23869
		[Nullable(2)]
		protected IFaceExpressionConfigData FbInstance;

		// Token: 0x04005D3E RID: 23870
		[Nullable(2)]
		protected IFaceExpressionConfigData_SetValue PocoInterface;
	}
}

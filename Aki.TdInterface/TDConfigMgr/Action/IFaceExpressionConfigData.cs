using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A37 RID: 6711
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionConfigData
	{
		// Token: 0x06008FAC RID: 36780 RVA: 0x0014F558 File Offset: 0x0014D758
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

		// Token: 0x06008FAD RID: 36781 RVA: 0x0014F590 File Offset: 0x0014D790
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

		// Token: 0x06008FAE RID: 36782 RVA: 0x0014F5A3 File Offset: 0x0014D7A3
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

		// Token: 0x06008FAF RID: 36783 RVA: 0x0014F5B6 File Offset: 0x0014D7B6
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

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x0014F5ED File Offset: 0x0014D7ED
		// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x0014F618 File Offset: 0x0014D818
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

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x0014F626 File Offset: 0x0014D826
		// (set) Token: 0x06008FB3 RID: 36787 RVA: 0x0014F64D File Offset: 0x0014D84D
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

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x06008FB4 RID: 36788 RVA: 0x0014F65B File Offset: 0x0014D85B
		// (set) Token: 0x06008FB5 RID: 36789 RVA: 0x0014F682 File Offset: 0x0014D882
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

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x0014F690 File Offset: 0x0014D890
		// (set) Token: 0x06008FB7 RID: 36791 RVA: 0x0014F6CA File Offset: 0x0014D8CA
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

		// Token: 0x040058D8 RID: 22744
		[Nullable(2)]
		protected IFaceExpressionConfigData FbInstance;

		// Token: 0x040058D9 RID: 22745
		[Nullable(2)]
		protected IFaceExpressionConfigData_SetValue PocoInterface;
	}
}

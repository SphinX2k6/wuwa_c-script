using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABF RID: 6847
	public class IControlElementalBoxReturn : IControlElementalBoxTypeBase
	{
		// Token: 0x0600918F RID: 37263 RVA: 0x00155A28 File Offset: 0x00153C28
		private IControlElementalBoxReturn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxReturn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxReturn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxReturn_SetValue());
			}
			return result;
		}

		// Token: 0x06009190 RID: 37264 RVA: 0x00155A60 File Offset: 0x00153C60
		public static IControlElementalBoxReturn Create([Nullable(2)] IControlElementalBoxReturn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxReturn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x00155A73 File Offset: 0x00153C73
		public static IControlElementalBoxReturn CreateFromSetValue([Nullable(2)] IControlElementalBoxReturn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxReturn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x00155A86 File Offset: 0x00153C86
		public new IControlElementalBoxReturn_SetValue ToSetValue()
		{
			return new IControlElementalBoxReturn_SetValue
			{
				Type = this.Type,
				ReturnBeforeMoveSeq = this.ReturnBeforeMoveSeq
			};
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x00155AA5 File Offset: 0x00153CA5
		// (set) Token: 0x06009194 RID: 37268 RVA: 0x00155AD0 File Offset: 0x00153CD0
		public override EControlElementalBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlElementalBoxType.Capture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x06009195 RID: 37269 RVA: 0x00155ADE File Offset: 0x00153CDE
		// (set) Token: 0x06009196 RID: 37270 RVA: 0x00155B05 File Offset: 0x00153D05
		[Nullable(2)]
		public virtual string ReturnBeforeMoveSeq
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReturnBeforeMoveSeq;
				}
				IControlElementalBoxReturn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReturnBeforeMoveSeq;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ReturnBeforeMoveSeq = value;
			}
		}

		// Token: 0x04005AD6 RID: 23254
		[Nullable(2)]
		protected new IControlElementalBoxReturn FbInstance;

		// Token: 0x04005AD7 RID: 23255
		[Nullable(2)]
		protected new IControlElementalBoxReturn_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABD RID: 6845
	public class IControlElementalBoxCapture : IControlElementalBoxTypeBase
	{
		// Token: 0x06009185 RID: 37253 RVA: 0x0015592C File Offset: 0x00153B2C
		private IControlElementalBoxCapture_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxCapture 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxCapture_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxCapture_SetValue());
			}
			return result;
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00155964 File Offset: 0x00153B64
		public static IControlElementalBoxCapture Create([Nullable(2)] IControlElementalBoxCapture instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxCapture
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x00155977 File Offset: 0x00153B77
		public static IControlElementalBoxCapture CreateFromSetValue([Nullable(2)] IControlElementalBoxCapture_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxCapture
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x0015598A File Offset: 0x00153B8A
		public new IControlElementalBoxCapture_SetValue ToSetValue()
		{
			return new IControlElementalBoxCapture_SetValue
			{
				Type = this.Type,
				CaptureCompleteSeq = this.CaptureCompleteSeq
			};
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x001559A9 File Offset: 0x00153BA9
		// (set) Token: 0x0600918A RID: 37258 RVA: 0x001559D4 File Offset: 0x00153BD4
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

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x001559E2 File Offset: 0x00153BE2
		// (set) Token: 0x0600918C RID: 37260 RVA: 0x00155A09 File Offset: 0x00153C09
		[Nullable(2)]
		public virtual string CaptureCompleteSeq
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CaptureCompleteSeq;
				}
				IControlElementalBoxCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CaptureCompleteSeq;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CaptureCompleteSeq = value;
			}
		}

		// Token: 0x04005AD2 RID: 23250
		[Nullable(2)]
		protected new IControlElementalBoxCapture FbInstance;

		// Token: 0x04005AD3 RID: 23251
		[Nullable(2)]
		protected new IControlElementalBoxCapture_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF0 RID: 7408
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographPlayerPerform
	{
		// Token: 0x06009EFB RID: 40699 RVA: 0x0016B600 File Offset: 0x00169800
		private IPhotographPlayerPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographPlayerPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographPlayerPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographPlayerPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x0016B638 File Offset: 0x00169838
		public static IPhotographPlayerPerform Create([Nullable(2)] IPhotographPlayerPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographPlayerPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x0016B64B File Offset: 0x0016984B
		public static IPhotographPlayerPerform CreateFromSetValue([Nullable(2)] IPhotographPlayerPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographPlayerPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x0016B65E File Offset: 0x0016985E
		public IPhotographPlayerPerform_SetValue ToSetValue()
		{
			return new IPhotographPlayerPerform_SetValue
			{
				MontageId = this.MontageId,
				FaceId = this.FaceId
			};
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x0016B680 File Offset: 0x00169880
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x0016B6BA File Offset: 0x001698BA
		public virtual int? MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				IPhotographPlayerPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x0016B6C8 File Offset: 0x001698C8
		// (set) Token: 0x06009F02 RID: 40706 RVA: 0x0016B702 File Offset: 0x00169902
		public virtual int? FaceId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceId;
				}
				IPhotographPlayerPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceId;
			}
			set
			{
				this.GetOrCreatePoco().FaceId = value;
			}
		}

		// Token: 0x04006005 RID: 24581
		[Nullable(2)]
		protected IPhotographPlayerPerform FbInstance;

		// Token: 0x04006006 RID: 24582
		[Nullable(2)]
		protected IPhotographPlayerPerform_SetValue PocoInterface;
	}
}

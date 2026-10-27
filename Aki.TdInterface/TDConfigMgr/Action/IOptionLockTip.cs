using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB8 RID: 7352
	[NullableContext(2)]
	[Nullable(0)]
	public class IOptionLockTip
	{
		// Token: 0x06009DD5 RID: 40405 RVA: 0x001694B8 File Offset: 0x001676B8
		[NullableContext(1)]
		private IOptionLockTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOptionLockTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOptionLockTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOptionLockTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x001694F0 File Offset: 0x001676F0
		[NullableContext(1)]
		public static IOptionLockTip Create([Nullable(2)] IOptionLockTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x00169503 File Offset: 0x00167703
		[NullableContext(1)]
		public static IOptionLockTip CreateFromSetValue([Nullable(2)] IOptionLockTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x00169518 File Offset: 0x00167718
		[NullableContext(1)]
		public IOptionLockTip_SetValue ToSetValue()
		{
			return new IOptionLockTip_SetValue
			{
				TidAppendText = this.TidAppendText,
				TidHintText = this.TidHintText,
				AppendTextId = this.AppendTextId,
				HintTextId = this.HintTextId,
				EdTidAppendText = this.EdTidAppendText,
				EdTidHintText = this.EdTidHintText
			};
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06009DD9 RID: 40409 RVA: 0x00169572 File Offset: 0x00167772
		// (set) Token: 0x06009DDA RID: 40410 RVA: 0x00169599 File Offset: 0x00167799
		public virtual string TidAppendText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidAppendText;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidAppendText;
			}
			set
			{
				this.GetOrCreatePoco().TidAppendText = value;
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x001695A7 File Offset: 0x001677A7
		// (set) Token: 0x06009DDC RID: 40412 RVA: 0x001695CE File Offset: 0x001677CE
		public virtual string TidHintText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidHintText;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidHintText;
			}
			set
			{
				this.GetOrCreatePoco().TidHintText = value;
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06009DDD RID: 40413 RVA: 0x001695DC File Offset: 0x001677DC
		// (set) Token: 0x06009DDE RID: 40414 RVA: 0x00169616 File Offset: 0x00167816
		public virtual int? AppendTextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendTextId;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendTextId;
			}
			set
			{
				this.GetOrCreatePoco().AppendTextId = value;
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06009DDF RID: 40415 RVA: 0x00169624 File Offset: 0x00167824
		// (set) Token: 0x06009DE0 RID: 40416 RVA: 0x0016965E File Offset: 0x0016785E
		public virtual int? HintTextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintTextId;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HintTextId;
			}
			set
			{
				this.GetOrCreatePoco().HintTextId = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x0016966C File Offset: 0x0016786C
		// (set) Token: 0x06009DE2 RID: 40418 RVA: 0x00169683 File Offset: 0x00167883
		public virtual string EdTidAppendText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidAppendText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidAppendText = value;
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x00169691 File Offset: 0x00167891
		// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x001696A8 File Offset: 0x001678A8
		public virtual string EdTidHintText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidHintText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidHintText = value;
			}
		}

		// Token: 0x04005F7E RID: 24446
		protected IOptionLockTip FbInstance;

		// Token: 0x04005F7F RID: 24447
		protected IOptionLockTip_SetValue PocoInterface;
	}
}

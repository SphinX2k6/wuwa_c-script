using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6A RID: 7274
	[NullableContext(2)]
	[Nullable(0)]
	public class IGamePadInteractVibration
	{
		// Token: 0x06009AAC RID: 39596 RVA: 0x00165D70 File Offset: 0x00163F70
		[NullableContext(0)]
		private IGamePadInteractVibration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGamePadInteractVibration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGamePadInteractVibration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGamePadInteractVibration_SetValue());
			}
			return result;
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x00165DA8 File Offset: 0x00163FA8
		[NullableContext(0)]
		public static IGamePadInteractVibration Create([Nullable(2)] IGamePadInteractVibration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamePadInteractVibration
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00165DBB File Offset: 0x00163FBB
		[NullableContext(0)]
		public static IGamePadInteractVibration CreateFromSetValue([Nullable(2)] IGamePadInteractVibration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGamePadInteractVibration
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x00165DCE File Offset: 0x00163FCE
		[NullableContext(0)]
		public IGamePadInteractVibration_SetValue ToSetValue()
		{
			return new IGamePadInteractVibration_SetValue
			{
				LongPressingEffect = this.LongPressingEffect,
				LongPressFinishedEffect = this.LongPressFinishedEffect
			};
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x00165DED File Offset: 0x00163FED
		// (set) Token: 0x06009AB1 RID: 39601 RVA: 0x00165E14 File Offset: 0x00164014
		public virtual string LongPressingEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressingEffect;
				}
				IGamePadInteractVibration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressingEffect;
			}
			set
			{
				this.GetOrCreatePoco().LongPressingEffect = value;
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06009AB2 RID: 39602 RVA: 0x00165E22 File Offset: 0x00164022
		// (set) Token: 0x06009AB3 RID: 39603 RVA: 0x00165E49 File Offset: 0x00164049
		public virtual string LongPressFinishedEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressFinishedEffect;
				}
				IGamePadInteractVibration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressFinishedEffect;
			}
			set
			{
				this.GetOrCreatePoco().LongPressFinishedEffect = value;
			}
		}

		// Token: 0x04005EEF RID: 24303
		protected IGamePadInteractVibration FbInstance;

		// Token: 0x04005EF0 RID: 24304
		protected IGamePadInteractVibration_SetValue PocoInterface;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E2 RID: 6114
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig : ITextUiConfig
	{
		// Token: 0x06008341 RID: 33601 RVA: 0x00139830 File Offset: 0x00137A30
		[NullableContext(1)]
		private IAstrologyTextUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAstrologyTextUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAstrologyTextUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAstrologyTextUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x00139868 File Offset: 0x00137A68
		[NullableContext(1)]
		public static IAstrologyTextUiConfig Create([Nullable(2)] IAstrologyTextUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAstrologyTextUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0013987B File Offset: 0x00137A7B
		[NullableContext(1)]
		public static IAstrologyTextUiConfig CreateFromSetValue([Nullable(2)] IAstrologyTextUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAstrologyTextUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x00139890 File Offset: 0x00137A90
		[NullableContext(1)]
		public new IAstrologyTextUiConfig_SetValue ToSetValue()
		{
			return new IAstrologyTextUiConfig_SetValue
			{
				Type = this.Type,
				InitTipText = this.InitTipText,
				ProgressTipText = this.ProgressTipText,
				SkipText = this.SkipText,
				FinishText = this.FinishText,
				InitDialogues = this.InitDialogues,
				SkipConfirmBoxId = this.SkipConfirmBoxId,
				LoopAudioEvent = this.LoopAudioEvent
			};
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x06008345 RID: 33605 RVA: 0x00139902 File Offset: 0x00137B02
		// (set) Token: 0x06008346 RID: 33606 RVA: 0x0013992D File Offset: 0x00137B2D
		public override ETextUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETextUiType.Astrology;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x06008347 RID: 33607 RVA: 0x0013993B File Offset: 0x00137B3B
		// (set) Token: 0x06008348 RID: 33608 RVA: 0x00139962 File Offset: 0x00137B62
		public override string InitTipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitTipText;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitTipText;
			}
			set
			{
				this.GetOrCreatePoco().InitTipText = value;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x00139970 File Offset: 0x00137B70
		// (set) Token: 0x0600834A RID: 33610 RVA: 0x00139997 File Offset: 0x00137B97
		public override string ProgressTipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressTipText;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressTipText;
			}
			set
			{
				this.GetOrCreatePoco().ProgressTipText = value;
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x001399A5 File Offset: 0x00137BA5
		// (set) Token: 0x0600834C RID: 33612 RVA: 0x001399CC File Offset: 0x00137BCC
		public override string SkipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipText;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipText;
			}
			set
			{
				this.GetOrCreatePoco().SkipText = value;
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x001399DA File Offset: 0x00137BDA
		// (set) Token: 0x0600834E RID: 33614 RVA: 0x00139A01 File Offset: 0x00137C01
		public override string FinishText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishText;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishText;
			}
			set
			{
				this.GetOrCreatePoco().FinishText = value;
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600834F RID: 33615 RVA: 0x00139A0F File Offset: 0x00137C0F
		// (set) Token: 0x06008350 RID: 33616 RVA: 0x00139A36 File Offset: 0x00137C36
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitDialogues;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitDialogues;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().InitDialogues = value;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x00139A44 File Offset: 0x00137C44
		// (set) Token: 0x06008352 RID: 33618 RVA: 0x00139A7E File Offset: 0x00137C7E
		public override int? SkipConfirmBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipConfirmBoxId;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipConfirmBoxId;
			}
			set
			{
				this.GetOrCreatePoco().SkipConfirmBoxId = value;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06008353 RID: 33619 RVA: 0x00139A8C File Offset: 0x00137C8C
		// (set) Token: 0x06008354 RID: 33620 RVA: 0x00139AB3 File Offset: 0x00137CB3
		public override string LoopAudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopAudioEvent;
				}
				IAstrologyTextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopAudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().LoopAudioEvent = value;
			}
		}

		// Token: 0x04005353 RID: 21331
		protected new IAstrologyTextUiConfig FbInstance;

		// Token: 0x04005354 RID: 21332
		protected new IAstrologyTextUiConfig_SetValue PocoInterface;
	}
}

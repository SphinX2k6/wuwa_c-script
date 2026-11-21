using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196B RID: 6507
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig : ITextUiConfig
	{
		// Token: 0x06008A5D RID: 35421 RVA: 0x00148F18 File Offset: 0x00147118
		[NullableContext(0)]
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

		// Token: 0x06008A5E RID: 35422 RVA: 0x00148F50 File Offset: 0x00147150
		[NullableContext(0)]
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

		// Token: 0x06008A5F RID: 35423 RVA: 0x00148F63 File Offset: 0x00147163
		[NullableContext(0)]
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

		// Token: 0x06008A60 RID: 35424 RVA: 0x00148F78 File Offset: 0x00147178
		[NullableContext(0)]
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

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06008A61 RID: 35425 RVA: 0x00148FEA File Offset: 0x001471EA
		// (set) Token: 0x06008A62 RID: 35426 RVA: 0x00149015 File Offset: 0x00147215
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

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x00149023 File Offset: 0x00147223
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x0014904A File Offset: 0x0014724A
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

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x00149058 File Offset: 0x00147258
		// (set) Token: 0x06008A66 RID: 35430 RVA: 0x0014907F File Offset: 0x0014727F
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

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x0014908D File Offset: 0x0014728D
		// (set) Token: 0x06008A68 RID: 35432 RVA: 0x001490B4 File Offset: 0x001472B4
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

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x001490C2 File Offset: 0x001472C2
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x001490E9 File Offset: 0x001472E9
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

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x001490F7 File Offset: 0x001472F7
		// (set) Token: 0x06008A6C RID: 35436 RVA: 0x0014911E File Offset: 0x0014731E
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitDialogues = value;
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06008A6D RID: 35437 RVA: 0x0014912C File Offset: 0x0014732C
		// (set) Token: 0x06008A6E RID: 35438 RVA: 0x00149166 File Offset: 0x00147366
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

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x00149174 File Offset: 0x00147374
		// (set) Token: 0x06008A70 RID: 35440 RVA: 0x0014919B File Offset: 0x0014739B
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

		// Token: 0x0400579B RID: 22427
		protected new IAstrologyTextUiConfig FbInstance;

		// Token: 0x0400579C RID: 22428
		protected new IAstrologyTextUiConfig_SetValue PocoInterface;
	}
}

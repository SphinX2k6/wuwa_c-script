using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFD RID: 7933
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchDataLayersTransitionWithSequence : ISwitchDataLayersTransitionType
	{
		// Token: 0x0600A9A2 RID: 43426 RVA: 0x0017E5B4 File Offset: 0x0017C7B4
		private ISwitchDataLayersTransitionWithSequence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchDataLayersTransitionWithSequence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchDataLayersTransitionWithSequence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchDataLayersTransitionWithSequence_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x0017E5EC File Offset: 0x0017C7EC
		public static ISwitchDataLayersTransitionWithSequence Create([Nullable(2)] ISwitchDataLayersTransitionWithSequence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionWithSequence
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x0017E5FF File Offset: 0x0017C7FF
		public static ISwitchDataLayersTransitionWithSequence CreateFromSetValue([Nullable(2)] ISwitchDataLayersTransitionWithSequence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionWithSequence
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x0017E612 File Offset: 0x0017C812
		public new ISwitchDataLayersTransitionWithSequence_SetValue ToSetValue()
		{
			return new ISwitchDataLayersTransitionWithSequence_SetValue
			{
				Type = this.Type,
				SequencePath = this.SequencePath,
				SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMat
			};
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600A9A6 RID: 43430 RVA: 0x0017E63D File Offset: 0x0017C83D
		// (set) Token: 0x0600A9A7 RID: 43431 RVA: 0x0017E668 File Offset: 0x0017C868
		public override ESwitchDataLayersTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600A9A8 RID: 43432 RVA: 0x0017E676 File Offset: 0x0017C876
		// (set) Token: 0x0600A9A9 RID: 43433 RVA: 0x0017E6A1 File Offset: 0x0017C8A1
		public virtual string SequencePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequencePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SequencePath;
			}
			set
			{
				this.GetOrCreatePoco().SequencePath = value;
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600A9AA RID: 43434 RVA: 0x0017E6AF File Offset: 0x0017C8AF
		// (set) Token: 0x0600A9AB RID: 43435 RVA: 0x0017E6D6 File Offset: 0x0017C8D6
		[Nullable(2)]
		public virtual string SeqMarkBeforeModifyMat
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqMarkBeforeModifyMat;
				}
				ISwitchDataLayersTransitionWithSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SeqMarkBeforeModifyMat;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SeqMarkBeforeModifyMat = value;
			}
		}

		// Token: 0x040064E2 RID: 25826
		[Nullable(2)]
		protected new ISwitchDataLayersTransitionWithSequence FbInstance;

		// Token: 0x040064E3 RID: 25827
		[Nullable(2)]
		protected new ISwitchDataLayersTransitionWithSequence_SetValue PocoInterface;
	}
}

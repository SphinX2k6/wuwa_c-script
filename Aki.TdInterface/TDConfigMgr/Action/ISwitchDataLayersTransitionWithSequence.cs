using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002136 RID: 8502
	public class ISwitchDataLayersTransitionWithSequence : ISwitchDataLayersTransitionType
	{
		// Token: 0x0600B474 RID: 46196 RVA: 0x001945AC File Offset: 0x001927AC
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

		// Token: 0x0600B475 RID: 46197 RVA: 0x001945E4 File Offset: 0x001927E4
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

		// Token: 0x0600B476 RID: 46198 RVA: 0x001945F7 File Offset: 0x001927F7
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

		// Token: 0x0600B477 RID: 46199 RVA: 0x0019460A File Offset: 0x0019280A
		public new ISwitchDataLayersTransitionWithSequence_SetValue ToSetValue()
		{
			return new ISwitchDataLayersTransitionWithSequence_SetValue
			{
				Type = this.Type,
				SequencePath = this.SequencePath,
				SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMat
			};
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x00194635 File Offset: 0x00192835
		// (set) Token: 0x0600B479 RID: 46201 RVA: 0x00194660 File Offset: 0x00192860
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

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600B47A RID: 46202 RVA: 0x0019466E File Offset: 0x0019286E
		// (set) Token: 0x0600B47B RID: 46203 RVA: 0x00194699 File Offset: 0x00192899
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

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600B47C RID: 46204 RVA: 0x001946A7 File Offset: 0x001928A7
		// (set) Token: 0x0600B47D RID: 46205 RVA: 0x001946CE File Offset: 0x001928CE
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

		// Token: 0x04006AD1 RID: 27345
		[Nullable(2)]
		protected new ISwitchDataLayersTransitionWithSequence FbInstance;

		// Token: 0x04006AD2 RID: 27346
		[Nullable(2)]
		protected new ISwitchDataLayersTransitionWithSequence_SetValue PocoInterface;
	}
}

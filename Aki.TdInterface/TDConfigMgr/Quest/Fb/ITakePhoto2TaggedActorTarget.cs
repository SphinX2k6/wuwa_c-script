using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150B RID: 5387
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TaggedActorTarget : ITakePhoto2Target
	{
		// Token: 0x060079F9 RID: 31225 RVA: 0x001234A3 File Offset: 0x001216A3
		[NullableContext(0)]
		public static ITakePhoto2TaggedActorTarget Create(ITakePhoto2TaggedActorTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TaggedActorTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x001234C2 File Offset: 0x001216C2
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x001234D0 File Offset: 0x001216D0
		public override bool? IsOptionalTarget
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOptionalTarget);
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x060079FC RID: 31228 RVA: 0x00123506 File Offset: 0x00121706
		public override ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
			get
			{
				if (this._TargetCameraDistanceConditionInited)
				{
					return this._TargetCameraDistanceConditionCache;
				}
				this._TargetCameraDistanceConditionInited = true;
				this._TargetCameraDistanceConditionCache = ITakePhoto2TargetCameraDistanceCondition.Create(this.Instance.TargetCameraDistanceCondition);
				return this._TargetCameraDistanceConditionCache;
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x0012353A File Offset: 0x0012173A
		[Nullable(0)]
		public virtual string Tag
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x060079FE RID: 31230 RVA: 0x00123547 File Offset: 0x00121747
		public virtual ITakePhoto2TargetPosByRangeCondition TargetPosCondition
		{
			get
			{
				if (this._TargetPosConditionInited)
				{
					return this._TargetPosConditionCache;
				}
				this._TargetPosConditionInited = true;
				this._TargetPosConditionCache = ITakePhoto2TargetPosByRangeCondition.Create(this.Instance.TargetPosCondition);
				return this._TargetPosConditionCache;
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x060079FF RID: 31231 RVA: 0x0012357B File Offset: 0x0012177B
		public virtual int TargetSatisfiedCount
		{
			get
			{
				return this.Instance.TargetSatisfiedCount;
			}
		}

		// Token: 0x0400463B RID: 17979
		private ITakePhoto2TaggedActorTarget Instance;

		// Token: 0x0400463C RID: 17980
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400463D RID: 17981
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x0400463E RID: 17982
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x0400463F RID: 17983
		private bool _TargetPosConditionInited;
	}
}

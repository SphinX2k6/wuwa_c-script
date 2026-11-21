using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001508 RID: 5384
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget : ITakePhoto2Target
	{
		// Token: 0x060079DE RID: 31198 RVA: 0x001230CA File Offset: 0x001212CA
		[NullableContext(0)]
		public static ITakePhoto2EntityTarget Create(ITakePhoto2EntityTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2EntityTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x001230E9 File Offset: 0x001212E9
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x001230F8 File Offset: 0x001212F8
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

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x0012312E File Offset: 0x0012132E
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

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x00123162 File Offset: 0x00121362
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x0012316F File Offset: 0x0012136F
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

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x001231A3 File Offset: 0x001213A3
		public virtual ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition
		{
			get
			{
				if (this._TargetPlayMontageConditionInited)
				{
					return this._TargetPlayMontageConditionCache;
				}
				this._TargetPlayMontageConditionInited = true;
				this._TargetPlayMontageConditionCache = ITakePhoto2TargetPlayMontageCondition.Create(this.Instance.TargetPlayMontageCondition);
				return this._TargetPlayMontageConditionCache;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x001231D7 File Offset: 0x001213D7
		public virtual ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition
		{
			get
			{
				if (this._TargetAnsTagConditionInited)
				{
					return this._TargetAnsTagConditionCache;
				}
				this._TargetAnsTagConditionInited = true;
				this._TargetAnsTagConditionCache = ITakePhoto2TargetAnsTagCondition.Create(this.Instance.TargetAnsTagCondition);
				return this._TargetAnsTagConditionCache;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x0012320B File Offset: 0x0012140B
		public virtual ITakePhoto2TargetPartCondition TargetPartCondition
		{
			get
			{
				if (this._TargetPartConditionInited)
				{
					return this._TargetPartConditionCache;
				}
				this._TargetPartConditionInited = true;
				this._TargetPartConditionCache = ITakePhoto2TargetPartCondition.Create(this.Instance.TargetPartCondition);
				return this._TargetPartConditionCache;
			}
		}

		// Token: 0x04004620 RID: 17952
		private ITakePhoto2EntityTarget Instance;

		// Token: 0x04004621 RID: 17953
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04004622 RID: 17954
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04004623 RID: 17955
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04004624 RID: 17956
		private bool _TargetPosConditionInited;

		// Token: 0x04004625 RID: 17957
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04004626 RID: 17958
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04004627 RID: 17959
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x04004628 RID: 17960
		private bool _TargetAnsTagConditionInited;

		// Token: 0x04004629 RID: 17961
		private ITakePhoto2TargetPartCondition _TargetPartConditionCache;

		// Token: 0x0400462A RID: 17962
		private bool _TargetPartConditionInited;
	}
}

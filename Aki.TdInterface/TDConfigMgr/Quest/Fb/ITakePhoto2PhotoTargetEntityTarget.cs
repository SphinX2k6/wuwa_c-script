using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001509 RID: 5385
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget : ITakePhoto2Target
	{
		// Token: 0x060079E8 RID: 31208 RVA: 0x00123247 File Offset: 0x00121447
		[NullableContext(0)]
		public static ITakePhoto2PhotoTargetEntityTarget Create(ITakePhoto2PhotoTargetEntityTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2PhotoTargetEntityTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x00123266 File Offset: 0x00121466
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x00123274 File Offset: 0x00121474
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

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x001232AA File Offset: 0x001214AA
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

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x060079EC RID: 31212 RVA: 0x001232DE File Offset: 0x001214DE
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x001232EB File Offset: 0x001214EB
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

		// Token: 0x0400462B RID: 17963
		private ITakePhoto2PhotoTargetEntityTarget Instance;

		// Token: 0x0400462C RID: 17964
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400462D RID: 17965
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x0400462E RID: 17966
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x0400462F RID: 17967
		private bool _TargetPosConditionInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B7 RID: 5047
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget : ITakePhoto2Target
	{
		// Token: 0x06007337 RID: 29495 RVA: 0x00114A0E File Offset: 0x00112C0E
		[NullableContext(1)]
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

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06007338 RID: 29496 RVA: 0x00114A2D File Offset: 0x00112C2D
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x00114A3C File Offset: 0x00112C3C
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

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x00114A72 File Offset: 0x00112C72
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

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x00114AA6 File Offset: 0x00112CA6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600733C RID: 29500 RVA: 0x00114AB3 File Offset: 0x00112CB3
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

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x00114AE7 File Offset: 0x00112CE7
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

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600733E RID: 29502 RVA: 0x00114B1B File Offset: 0x00112D1B
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

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x00114B4F File Offset: 0x00112D4F
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

		// Token: 0x0400429F RID: 17055
		private ITakePhoto2EntityTarget Instance;

		// Token: 0x040042A0 RID: 17056
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x040042A1 RID: 17057
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x040042A2 RID: 17058
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x040042A3 RID: 17059
		private bool _TargetPosConditionInited;

		// Token: 0x040042A4 RID: 17060
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x040042A5 RID: 17061
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x040042A6 RID: 17062
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x040042A7 RID: 17063
		private bool _TargetAnsTagConditionInited;

		// Token: 0x040042A8 RID: 17064
		private ITakePhoto2TargetPartCondition _TargetPartConditionCache;

		// Token: 0x040042A9 RID: 17065
		private bool _TargetPartConditionInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B8 RID: 5048
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget : ITakePhoto2Target
	{
		// Token: 0x06007341 RID: 29505 RVA: 0x00114B8B File Offset: 0x00112D8B
		[NullableContext(1)]
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

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06007342 RID: 29506 RVA: 0x00114BAA File Offset: 0x00112DAA
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x00114BB8 File Offset: 0x00112DB8
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

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x00114BEE File Offset: 0x00112DEE
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

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06007345 RID: 29509 RVA: 0x00114C22 File Offset: 0x00112E22
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x00114C2F File Offset: 0x00112E2F
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

		// Token: 0x040042AA RID: 17066
		private ITakePhoto2PhotoTargetEntityTarget Instance;

		// Token: 0x040042AB RID: 17067
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x040042AC RID: 17068
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x040042AD RID: 17069
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x040042AE RID: 17070
		private bool _TargetPosConditionInited;
	}
}

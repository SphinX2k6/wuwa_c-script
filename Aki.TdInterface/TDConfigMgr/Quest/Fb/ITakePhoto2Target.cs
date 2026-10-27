using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B6 RID: 5046
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2Target
	{
		// Token: 0x06007332 RID: 29490 RVA: 0x00114970 File Offset: 0x00112B70
		[NullableContext(1)]
		public static ITakePhoto2Target Create(ITakePhoto2Target? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2Target
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x0011498F File Offset: 0x00112B8F
		public virtual ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06007334 RID: 29492 RVA: 0x0011499C File Offset: 0x00112B9C
		public virtual bool? IsOptionalTarget
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

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06007335 RID: 29493 RVA: 0x001149D2 File Offset: 0x00112BD2
		public virtual ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
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

		// Token: 0x0400429C RID: 17052
		private ITakePhoto2Target Instance;

		// Token: 0x0400429D RID: 17053
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400429E RID: 17054
		private bool _TargetCameraDistanceConditionInited;
	}
}

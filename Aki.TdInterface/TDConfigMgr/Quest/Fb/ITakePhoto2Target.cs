using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001507 RID: 5383
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2Target
	{
		// Token: 0x060079D9 RID: 31193 RVA: 0x0012302C File Offset: 0x0012122C
		[NullableContext(0)]
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

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x0012304B File Offset: 0x0012124B
		public virtual ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x00123058 File Offset: 0x00121258
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

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x0012308E File Offset: 0x0012128E
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

		// Token: 0x0400461D RID: 17949
		private ITakePhoto2Target Instance;

		// Token: 0x0400461E RID: 17950
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400461F RID: 17951
		private bool _TargetCameraDistanceConditionInited;
	}
}

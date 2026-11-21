using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C42 RID: 19522
	[NullableContext(1)]
	[Nullable(0)]
	public class PassiveSkillCdInfo
	{
		// Token: 0x06030BCE RID: 199630 RVA: 0x00D97998 File Offset: 0x00D95B98
		public double GetCurRemainingCd(int entityId)
		{
			double valueOrDefault = this.SkillCdFinishStampMap.GetValueOrDefault(entityId, 0.0);
			if (valueOrDefault != 0.0)
			{
				return (valueOrDefault - Time.Instance.FlowTime) * TimeUtil.Instance.Millisecond;
			}
			return 0.0;
		}

		// Token: 0x06030BCF RID: 199631 RVA: 0x00D979E8 File Offset: 0x00D95BE8
		public bool IsInCd(int entityId)
		{
			return this.GetCurRemainingCd(entityId) > (double)Math.Max(this.Threshold, 0f);
		}

		// Token: 0x06030BD0 RID: 199632 RVA: 0x00D97A04 File Offset: 0x00D95C04
		private unsafe void RemoveInvalidCd()
		{
			List<int> list = new List<int>();
			foreach (int num in this.SkillCdFinishStampMap.Keys)
			{
				if (this.IsInCd(num))
				{
					break;
				}
				list.Add(num);
			}
			foreach (int key in list)
			{
				this.SkillCdFinishStampMap.Remove(key);
			}
			if (this.SkillCdFinishStampMap.Count >= 20)
			{
				int? num2 = null;
				if (this.EntityIds.Count > 0)
				{
					HashSet<int>.Enumerator enumerator3 = this.EntityIds.GetEnumerator();
					if (enumerator3.MoveNext())
					{
						num2 = new int?(enumerator3.Current);
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "被动技能CD数量超上限,移除最先的entityCD";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", this.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("firstEntityId", num2);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				if (num2 != null)
				{
					this.SkillCdFinishStampMap.Remove(num2.Value);
				}
			}
		}

		// Token: 0x06030BD1 RID: 199633 RVA: 0x00D97B80 File Offset: 0x00D95D80
		public bool StartCd(long skillId, int entityId, float cdTime = -1f)
		{
			if (this.IsInCd(entityId))
			{
				return false;
			}
			float num = cdTime;
			if (num == -1f)
			{
				num = this.SkillCd;
			}
			if (num <= 0f)
			{
				return true;
			}
			this.CurMaxCd = num;
			double valueOrDefault = this.SkillCdFinishStampMap.GetValueOrDefault(entityId, 0.0);
			double value = ((Time.Instance.FlowTime > valueOrDefault) ? Time.Instance.FlowTime : valueOrDefault) + (double)(num * (float)TimeUtil.Instance.InverseMillisecond);
			this.RemoveInvalidCd();
			this.SkillCdFinishStampMap.Remove(entityId);
			this.SkillCdFinishStampMap.Add(entityId, value);
			return true;
		}

		// Token: 0x06030BD2 RID: 199634 RVA: 0x00D97C1B File Offset: 0x00D95E1B
		public void ResetAllCd()
		{
			this.SkillCdFinishStampMap.Clear();
		}

		// Token: 0x04019CC5 RID: 105669
		private const int MAX_CD_COUNT = 20;

		// Token: 0x04019CC6 RID: 105670
		public long SkillId;

		// Token: 0x04019CC7 RID: 105671
		public float SkillCd;

		// Token: 0x04019CC8 RID: 105672
		public float Threshold;

		// Token: 0x04019CC9 RID: 105673
		public bool IsShareAllCdSkill;

		// Token: 0x04019CCA RID: 105674
		public readonly HashSet<int> EntityIds = new HashSet<int>();

		// Token: 0x04019CCB RID: 105675
		public float CurMaxCd;

		// Token: 0x04019CCC RID: 105676
		public readonly OrderedDictionary<int, double> SkillCdFinishStampMap = new OrderedDictionary<int, double>();
	}
}

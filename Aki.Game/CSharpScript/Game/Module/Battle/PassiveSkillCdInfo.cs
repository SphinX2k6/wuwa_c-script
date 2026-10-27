using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C62 RID: 23650
	[NullableContext(1)]
	[Nullable(0)]
	public class PassiveSkillCdInfo
	{
		// Token: 0x0603BC83 RID: 244867 RVA: 0x00E475B8 File Offset: 0x00E457B8
		public double GetCurRemainingCd(int entityId)
		{
			double valueOrDefault = this.SkillCdFinishStampMap.GetValueOrDefault(entityId, 0.0);
			if (valueOrDefault != 0.0)
			{
				return (valueOrDefault - Time.Instance.FlowTime) * TimeUtil.Instance.Millisecond;
			}
			return 0.0;
		}

		// Token: 0x0603BC84 RID: 244868 RVA: 0x00E47608 File Offset: 0x00E45808
		public bool IsInCd(int entityId)
		{
			return this.GetCurRemainingCd(entityId) > (double)Math.Max(this.Threshold, 0f);
		}

		// Token: 0x0603BC85 RID: 244869 RVA: 0x00E47624 File Offset: 0x00E45824
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

		// Token: 0x0603BC86 RID: 244870 RVA: 0x00E477A0 File Offset: 0x00E459A0
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

		// Token: 0x0603BC87 RID: 244871 RVA: 0x00E4783B File Offset: 0x00E45A3B
		public void ResetAllCd()
		{
			this.SkillCdFinishStampMap.Clear();
		}

		// Token: 0x0401F214 RID: 127508
		private const int MAX_CD_COUNT = 20;

		// Token: 0x0401F215 RID: 127509
		public long SkillId;

		// Token: 0x0401F216 RID: 127510
		public float SkillCd;

		// Token: 0x0401F217 RID: 127511
		public float Threshold;

		// Token: 0x0401F218 RID: 127512
		public bool IsShareAllCdSkill;

		// Token: 0x0401F219 RID: 127513
		public readonly HashSet<int> EntityIds = new HashSet<int>();

		// Token: 0x0401F21A RID: 127514
		public float CurMaxCd;

		// Token: 0x0401F21B RID: 127515
		public readonly OrderedDictionary<int, double> SkillCdFinishStampMap = new OrderedDictionary<int, double>();
	}
}

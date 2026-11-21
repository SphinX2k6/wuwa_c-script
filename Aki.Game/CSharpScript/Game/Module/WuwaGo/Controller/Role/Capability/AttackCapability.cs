using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003692 RID: 13970
	[NullableContext(1)]
	[Nullable(0)]
	public class AttackCapability : CapabilityBase
	{
		// Token: 0x0602441F RID: 148511 RVA: 0x00A41011 File Offset: 0x00A3F211
		public AttackCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x06024420 RID: 148512 RVA: 0x00A4101C File Offset: 0x00A3F21C
		public IAttackSession Attack()
		{
			AttackCapability.<>c__DisplayClass4_0 CS$<>8__locals1 = new AttackCapability.<>c__DisplayClass4_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.hitPromise = new CustomPromise<UniTaskVoid>();
			CS$<>8__locals1.hitResolved = false;
			this.Role.RegisterAttackHitListener(new Action(CS$<>8__locals1.<Attack>g__ResolveHit|0));
			UniTask finished = CS$<>8__locals1.<Attack>g__FinishedAsync|1();
			return new AttackSession
			{
				HitOrFinished = CS$<>8__locals1.hitPromise.Promise,
				Finished = finished
			};
		}

		// Token: 0x06024421 RID: 148513 RVA: 0x00A41088 File Offset: 0x00A3F288
		private UniTask PerformAttackAnim()
		{
			AttackCapability.<PerformAttackAnim>d__5 <PerformAttackAnim>d__;
			<PerformAttackAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformAttackAnim>d__.<>4__this = this;
			<PerformAttackAnim>d__.<>1__state = -1;
			<PerformAttackAnim>d__.<>t__builder.Start<AttackCapability.<PerformAttackAnim>d__5>(ref <PerformAttackAnim>d__);
			return <PerformAttackAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06024422 RID: 148514 RVA: 0x00A410CC File Offset: 0x00A3F2CC
		private unsafe float ComputeRootMotionScale(UAnimMontage montage)
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			if (setting == null || !setting.IsValid())
			{
				return 1f;
			}
			float num = (float)setting.SingleGridSize / 2f;
			int num2 = 700;
			float num3 = num / (float)num2;
			if (num3 < 0.1f || num3 > 5f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "攻击 RM scale 超出安全区间，已 clamp";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", montage);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("raw", num3);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return Math.Min(5f, Math.Max(0.1f, num3));
		}

		// Token: 0x04014306 RID: 82694
		private const int DEFAULT_ATTACK_MONTAGE_ORIGINAL_FORWARD_CM = 700;

		// Token: 0x04014307 RID: 82695
		private const float ATTACK_RM_SCALE_MIN = 0.1f;

		// Token: 0x04014308 RID: 82696
		private const int ATTACK_RM_SCALE_MAX = 5;
	}
}

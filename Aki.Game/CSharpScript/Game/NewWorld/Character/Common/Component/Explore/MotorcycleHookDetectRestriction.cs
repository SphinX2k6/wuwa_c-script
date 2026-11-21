using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006352 RID: 25426
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleHookDetectRestriction : IStaticVariableResetter
	{
		// Token: 0x0603D9C9 RID: 252361 RVA: 0x011D84B7 File Offset: 0x011D66B7
		static MotorcycleHookDetectRestriction()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleHookDetectRestriction.CreateStaticDefaultValue), new Action(MotorcycleHookDetectRestriction.ResetStaticDefaultValue));
		}

		// Token: 0x0603D9CA RID: 252362 RVA: 0x011D84D8 File Offset: 0x011D66D8
		public static void CreateStaticDefaultValue()
		{
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIds = new HashSet<int>
			{
				10001027,
				10001028,
				10001029,
				10001006,
				10002001,
				10001035
			};
			Dictionary<int, EHookInteractType> dictionary = new Dictionary<int, EHookInteractType>();
			dictionary[10001027] = EHookInteractType.FixedPointHook;
			dictionary[10001028] = EHookInteractType.CableWay;
			dictionary[10001029] = EHookInteractType.PilotThrow;
			dictionary[10001006] = EHookInteractType.MotorPullInteract;
			dictionary[10002001] = EHookInteractType.MotorEject;
			dictionary[10001035] = EHookInteractType.KiteHook;
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType = dictionary;
		}

		// Token: 0x0603D9CB RID: 252363 RVA: 0x011D858D File Offset: 0x011D678D
		public static void ResetStaticDefaultValue()
		{
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIds = null;
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType = null;
		}

		// Token: 0x0603D9CC RID: 252364 RVA: 0x011D859C File Offset: 0x011D679C
		public MotorcycleHookDetectRestriction([Nullable(new byte[]
		{
			1,
			2
		})] Func<MotorcycleExploreComponent> getExploreComponent)
		{
			HashSet<EHookInteractType> hashSet = new HashSet<EHookInteractType>();
			foreach (EHookInteractType item in MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType.Values)
			{
				hashSet.Add(item);
			}
			this.EnabledTypes = hashSet;
			base..ctor();
			this.GetExploreComponent = getExploreComponent;
		}

		// Token: 0x0603D9CD RID: 252365 RVA: 0x011D861C File Offset: 0x011D681C
		public unsafe bool SetDisabled(bool disabled, string reason)
		{
			if (this.Disabled == disabled)
			{
				return false;
			}
			this.Disabled = disabled;
			if (disabled)
			{
				this.ClearActiveTarget(reason);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[MotorcycleHookDetectRestriction] 设置钩锁探测禁用状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Disabled", disabled);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x0603D9CE RID: 252366 RVA: 0x011D869E File Offset: 0x011D689E
		public bool IsDisabled()
		{
			return this.Disabled || this.AreAllSkillIdsDisabled();
		}

		// Token: 0x0603D9CF RID: 252367 RVA: 0x011D86B0 File Offset: 0x011D68B0
		public bool CanHandleSkillId(int skillId)
		{
			return MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType.ContainsKey(skillId);
		}

		// Token: 0x0603D9D0 RID: 252368 RVA: 0x011D86C0 File Offset: 0x011D68C0
		public unsafe bool SetDisabledBySkillId(int skillId, bool disabled, string reason)
		{
			EHookInteractType ehookInteractType;
			if (!MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType.TryGetValue(skillId, out ehookInteractType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[MotorcycleHookDetectRestriction] 设置技能钩锁探测禁用状态失败, 技能Id未映射钩锁类型";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Disabled", disabled);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			if (this.DisabledSkillIds.Contains(skillId) == disabled)
			{
				return false;
			}
			if (disabled)
			{
				this.DisabledSkillIds.Add(skillId);
				this.EnabledTypes.Remove(ehookInteractType);
				if (this.IsDisabled())
				{
					this.ClearActiveTarget(reason);
				}
				else
				{
					this.ClearTargetByType(ehookInteractType, reason);
				}
			}
			else
			{
				this.DisabledSkillIds.Remove(skillId);
				this.EnabledTypes.Add(ehookInteractType);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[MotorcycleHookDetectRestriction] 设置技能钩锁探测禁用状态";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SkillId", skillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HookType", ehookInteractType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Disabled", disabled);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("AllDisabled", this.AreAllSkillIdsDisabled());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			return true;
		}

		// Token: 0x0603D9D1 RID: 252369 RVA: 0x011D886C File Offset: 0x011D6A6C
		public bool ClearSkillIdRestrictions(string reason)
		{
			if (this.DisabledSkillIds.Count == 0)
			{
				return false;
			}
			this.DisabledSkillIds.Clear();
			foreach (EHookInteractType item in MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType.Values)
			{
				this.EnabledTypes.Add(item);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[MotorcycleHookDetectRestriction] 清空局部钩锁探测屏蔽";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x0603D9D2 RID: 252370 RVA: 0x011D890C File Offset: 0x011D6B0C
		public HashSet<EHookInteractType> GetEnabledTypes()
		{
			return this.EnabledTypes;
		}

		// Token: 0x0603D9D3 RID: 252371 RVA: 0x011D8914 File Offset: 0x011D6B14
		public bool IsTypeDisabled(EHookInteractType hookType)
		{
			return !this.EnabledTypes.Contains(hookType);
		}

		// Token: 0x0603D9D4 RID: 252372 RVA: 0x011D8928 File Offset: 0x011D6B28
		private bool AreAllSkillIdsDisabled()
		{
			foreach (int item in MotorcycleHookDetectRestriction.MotorcycleHookSkillIds)
			{
				if (!this.DisabledSkillIds.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603D9D5 RID: 252373 RVA: 0x011D8988 File Offset: 0x011D6B88
		private void ClearActiveTarget(string reason)
		{
			MotorcycleExploreComponent motorcycleExploreComponent = this.GetExploreComponent();
			if (motorcycleExploreComponent == null)
			{
				return;
			}
			motorcycleExploreComponent.ClearDetectedTarget(reason);
		}

		// Token: 0x0603D9D6 RID: 252374 RVA: 0x011D89A0 File Offset: 0x011D6BA0
		private void ClearTargetByType(EHookInteractType hookType, string reason)
		{
			MotorcycleExploreComponent motorcycleExploreComponent = this.GetExploreComponent();
			GrapplingHookPointComponent grapplingHookPointComponent = (motorcycleExploreComponent != null) ? motorcycleExploreComponent.FocusTarget : null;
			bool flag;
			if (grapplingHookPointComponent == null)
			{
				flag = true;
			}
			else
			{
				EHookInteractType? hookInteractType = grapplingHookPointComponent.GetHookInteractType();
				flag = !(hookInteractType.GetValueOrDefault() == hookType & hookInteractType != null);
			}
			if (flag)
			{
				return;
			}
			if (motorcycleExploreComponent != null)
			{
				motorcycleExploreComponent.ClearDetectedTarget(reason);
			}
		}

		// Token: 0x04020AE7 RID: 133863
		[Nullable(2)]
		public static HashSet<int> MotorcycleHookSkillIds;

		// Token: 0x04020AE8 RID: 133864
		[Nullable(2)]
		private static Dictionary<int, EHookInteractType> MotorcycleHookSkillIdToType;

		// Token: 0x04020AE9 RID: 133865
		private bool Disabled;

		// Token: 0x04020AEA RID: 133866
		private readonly HashSet<int> DisabledSkillIds = new HashSet<int>();

		// Token: 0x04020AEB RID: 133867
		private readonly HashSet<EHookInteractType> EnabledTypes;

		// Token: 0x04020AEC RID: 133868
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Func<MotorcycleExploreComponent> GetExploreComponent;
	}
}

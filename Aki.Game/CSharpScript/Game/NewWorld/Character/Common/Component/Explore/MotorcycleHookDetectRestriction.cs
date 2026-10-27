using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007124 RID: 28964
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleHookDetectRestriction : IStaticVariableResetter
	{
		// Token: 0x06046B7E RID: 289662 RVA: 0x011CF867 File Offset: 0x011CDA67
		static MotorcycleHookDetectRestriction()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleHookDetectRestriction.CreateStaticDefaultValue), new Action(MotorcycleHookDetectRestriction.ResetStaticDefaultValue));
		}

		// Token: 0x06046B7F RID: 289663 RVA: 0x011CF888 File Offset: 0x011CDA88
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

		// Token: 0x06046B80 RID: 289664 RVA: 0x011CF93D File Offset: 0x011CDB3D
		public static void ResetStaticDefaultValue()
		{
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIds = null;
			MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType = null;
		}

		// Token: 0x06046B81 RID: 289665 RVA: 0x011CF94C File Offset: 0x011CDB4C
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

		// Token: 0x06046B82 RID: 289666 RVA: 0x011CF9CC File Offset: 0x011CDBCC
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

		// Token: 0x06046B83 RID: 289667 RVA: 0x011CFA4E File Offset: 0x011CDC4E
		public bool IsDisabled()
		{
			return this.Disabled || this.AreAllSkillIdsDisabled();
		}

		// Token: 0x06046B84 RID: 289668 RVA: 0x011CFA60 File Offset: 0x011CDC60
		public bool CanHandleSkillId(int skillId)
		{
			return MotorcycleHookDetectRestriction.MotorcycleHookSkillIdToType.ContainsKey(skillId);
		}

		// Token: 0x06046B85 RID: 289669 RVA: 0x011CFA70 File Offset: 0x011CDC70
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

		// Token: 0x06046B86 RID: 289670 RVA: 0x011CFC1C File Offset: 0x011CDE1C
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

		// Token: 0x06046B87 RID: 289671 RVA: 0x011CFCBC File Offset: 0x011CDEBC
		public HashSet<EHookInteractType> GetEnabledTypes()
		{
			return this.EnabledTypes;
		}

		// Token: 0x06046B88 RID: 289672 RVA: 0x011CFCC4 File Offset: 0x011CDEC4
		public bool IsTypeDisabled(EHookInteractType hookType)
		{
			return !this.EnabledTypes.Contains(hookType);
		}

		// Token: 0x06046B89 RID: 289673 RVA: 0x011CFCD8 File Offset: 0x011CDED8
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

		// Token: 0x06046B8A RID: 289674 RVA: 0x011CFD38 File Offset: 0x011CDF38
		private void ClearActiveTarget(string reason)
		{
			MotorcycleExploreComponent motorcycleExploreComponent = this.GetExploreComponent();
			if (motorcycleExploreComponent == null)
			{
				return;
			}
			motorcycleExploreComponent.ClearDetectedTarget(reason);
		}

		// Token: 0x06046B8B RID: 289675 RVA: 0x011CFD50 File Offset: 0x011CDF50
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

		// Token: 0x04025207 RID: 152071
		[Nullable(2)]
		public static HashSet<int> MotorcycleHookSkillIds;

		// Token: 0x04025208 RID: 152072
		[Nullable(2)]
		private static Dictionary<int, EHookInteractType> MotorcycleHookSkillIdToType;

		// Token: 0x04025209 RID: 152073
		private bool Disabled;

		// Token: 0x0402520A RID: 152074
		private readonly HashSet<int> DisabledSkillIds = new HashSet<int>();

		// Token: 0x0402520B RID: 152075
		private readonly HashSet<EHookInteractType> EnabledTypes;

		// Token: 0x0402520C RID: 152076
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Func<MotorcycleExploreComponent> GetExploreComponent;
	}
}

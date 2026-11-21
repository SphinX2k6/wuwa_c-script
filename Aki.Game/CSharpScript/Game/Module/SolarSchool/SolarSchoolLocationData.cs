using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D3 RID: 22739
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolLocationData
	{
		// Token: 0x06037FE4 RID: 229348 RVA: 0x00FA6B8E File Offset: 0x00FA4D8E
		public SolarSchoolLocationData(int locationId)
		{
			this.LocationId = locationId;
		}

		// Token: 0x17006B68 RID: 27496
		// (get) Token: 0x06037FE5 RID: 229349 RVA: 0x00FA6BA8 File Offset: 0x00FA4DA8
		public int LocationId { get; }

		// Token: 0x17006B69 RID: 27497
		// (get) Token: 0x06037FE6 RID: 229350 RVA: 0x00FA6BB0 File Offset: 0x00FA4DB0
		public bool IsUnlocked
		{
			get
			{
				SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(this.LocationId);
				return location != null && (location.Value.ConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(location.Value.ConditionGroupId));
			}
		}

		// Token: 0x17006B6A RID: 27498
		// (get) Token: 0x06037FE7 RID: 229351 RVA: 0x00FA6C08 File Offset: 0x00FA4E08
		public bool IsShowEnable
		{
			get
			{
				SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(this.LocationId);
				return location != null && (location.Value.ShowConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(location.Value.ShowConditionGroupId));
			}
		}

		// Token: 0x06037FE8 RID: 229352 RVA: 0x00FA6C60 File Offset: 0x00FA4E60
		public unsafe void WatchUnlock()
		{
			ActivityConditionBase activityConditionBase;
			if (ActivityConditionCenter.Instance.TryGetCondition(this.UnlockHandleId, out activityConditionBase))
			{
				return;
			}
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(this.LocationId);
			if (location == null || location.Value.ConditionGroupId == 0 || this.IsUnlocked)
			{
				return;
			}
			long num = ActivityConditionCenter.Instance.RegisterGroup(location.Value.ConditionGroupId, new Action(this.OnUnlockConditionReached));
			if (num == 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 地点注册解锁监听失败，请检查条件是否可监听及条件构建日志";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", this.LocationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionGroupId", location.Value.ConditionGroupId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.UnlockHandleId = num;
		}

		// Token: 0x06037FE9 RID: 229353 RVA: 0x00FA6D5D File Offset: 0x00FA4F5D
		public void UnwatchUnlock()
		{
			if (this.UnlockHandleId == 0L)
			{
				return;
			}
			ActivityConditionCenter.Instance.Unregister(this.UnlockHandleId);
			this.UnlockHandleId = 0L;
		}

		// Token: 0x06037FEA RID: 229354 RVA: 0x00FA6D80 File Offset: 0x00FA4F80
		private void OnUnlockConditionReached()
		{
			this.UnlockHandleId = 0L;
			SolarSchoolGamePlayModel.Instance.MapData.NotifyLocationUnlocked(this.LocationId);
		}

		// Token: 0x17006B6B RID: 27499
		// (get) Token: 0x06037FEB RID: 229355 RVA: 0x00FA6D9F File Offset: 0x00FA4F9F
		public SolarSchoolLocationRole Role
		{
			get
			{
				return this.RoleSlot;
			}
		}

		// Token: 0x06037FEC RID: 229356 RVA: 0x00FA6DA7 File Offset: 0x00FA4FA7
		public void SetRole(int roleId, bool isResident)
		{
			this.RoleSlot.RoleId = roleId;
			this.RoleSlot.IsResident = isResident;
		}

		// Token: 0x06037FED RID: 229357 RVA: 0x00FA6DC1 File Offset: 0x00FA4FC1
		public void ClearRole()
		{
			this.RoleSlot = default(SolarSchoolLocationRole);
		}

		// Token: 0x06037FEE RID: 229358 RVA: 0x00FA6DCF File Offset: 0x00FA4FCF
		[NullableContext(2)]
		public void SetOptionRows(List<SolarSchoolOptions> rows)
		{
			this.OptionRows.Clear();
			if (rows != null)
			{
				this.OptionRows.AddRange(rows);
			}
		}

		// Token: 0x06037FEF RID: 229359 RVA: 0x00FA6DEB File Offset: 0x00FA4FEB
		public List<SolarSchoolOptionInfo> GetOptions()
		{
			return SolarSchoolUtils.CheckOptions(this.OptionRows);
		}

		// Token: 0x06037FF0 RID: 229360 RVA: 0x00FA6DF8 File Offset: 0x00FA4FF8
		public void ClearDaily()
		{
			this.ClearRole();
			this.OptionRows.Clear();
		}

		// Token: 0x0401D87B RID: 120955
		private SolarSchoolLocationRole RoleSlot;

		// Token: 0x0401D87C RID: 120956
		private readonly List<SolarSchoolOptions> OptionRows = new List<SolarSchoolOptions>();

		// Token: 0x0401D87D RID: 120957
		private long UnlockHandleId;
	}
}

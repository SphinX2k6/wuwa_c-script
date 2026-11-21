using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BC RID: 22716
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolMapUnlockAction : SolarSchoolActionBase
	{
		// Token: 0x06037F15 RID: 229141 RVA: 0x00FA2F2C File Offset: 0x00FA112C
		protected unsafe override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.LocationIds.Clear();
			string text = ActivityActionBase.GetParamString(parameters, "SolarSchoolLocationIds", "").Trim();
			foreach (string text2 in text.Split('|', StringSplitOptions.None))
			{
				int num;
				if (!int.TryParse(text2.Trim(), out num) || num <= 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "[SolarSchool] MapUnlockAction 地点列表参数格式错误";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("locationIds", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("invalidLocationId", text2);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					this.LocationIds.Clear();
					return;
				}
				this.LocationIds.Add(num);
			}
		}

		// Token: 0x06037F16 RID: 229142 RVA: 0x00FA3028 File Offset: 0x00FA1228
		protected unsafe override void OnStart()
		{
			if (this.LocationIds.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] MapUnlockAction 地点列表为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", base.ActionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			foreach (int num in this.LocationIds)
			{
				if (SolarSchoolConfig.Instance.GetLocation(num) == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.YYZ;
					string message2 = "[SolarSchool] MapUnlockAction 地点配置不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("locationId", num);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					base.MarkFailed();
					return;
				}
			}
			SolarSchoolGamePlayModel instance3 = SolarSchoolGamePlayModel.Instance;
			if (!instance3.HasRootView())
			{
				Log instance4 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.YYZ;
				string message3 = "[SolarSchool] MapUnlockAction RootView 不存在，无法打开地图";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("locationIds", string.Join<int>(",", this.LocationIds));
				instance4.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				base.MarkFailed();
				return;
			}
			this.AcceptUnlockResult = true;
			this.UnlockStarted = false;
			this.OpenMapAsync(instance3).Forget();
		}

		// Token: 0x06037F17 RID: 229143 RVA: 0x00FA31EC File Offset: 0x00FA13EC
		private UniTask OpenMapAsync(SolarSchoolGamePlayModel model)
		{
			SolarSchoolMapUnlockAction.<OpenMapAsync>d__6 <OpenMapAsync>d__;
			<OpenMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenMapAsync>d__.<>4__this = this;
			<OpenMapAsync>d__.model = model;
			<OpenMapAsync>d__.<>1__state = -1;
			<OpenMapAsync>d__.<>t__builder.Start<SolarSchoolMapUnlockAction.<OpenMapAsync>d__6>(ref <OpenMapAsync>d__);
			return <OpenMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037F18 RID: 229144 RVA: 0x00FA3237 File Offset: 0x00FA1437
		private void OnUnlockStarted()
		{
			this.UnlockStarted = true;
		}

		// Token: 0x06037F19 RID: 229145 RVA: 0x00FA3240 File Offset: 0x00FA1440
		private void OnUnlockFinished(bool success)
		{
			if (!this.AcceptUnlockResult || base.IsDone())
			{
				return;
			}
			this.AcceptUnlockResult = false;
			if (success)
			{
				base.MarkDone();
				return;
			}
			base.MarkFailed();
		}

		// Token: 0x06037F1A RID: 229146 RVA: 0x00FA326A File Offset: 0x00FA146A
		protected override void OnDelete()
		{
			this.AcceptUnlockResult = false;
		}

		// Token: 0x0401D821 RID: 120865
		public const string ParamKeyLocationIds = "SolarSchoolLocationIds";

		// Token: 0x0401D822 RID: 120866
		private readonly List<int> LocationIds = new List<int>();

		// Token: 0x0401D823 RID: 120867
		private bool AcceptUnlockResult;

		// Token: 0x0401D824 RID: 120868
		private bool UnlockStarted;
	}
}

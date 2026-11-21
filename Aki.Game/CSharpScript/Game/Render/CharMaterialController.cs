using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Components;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D7 RID: 13527
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialController : CharRenderBase
	{
		// Token: 0x0602271D RID: 141085 RVA: 0x009C478C File Offset: 0x009C298C
		public unsafe void PrintCurrentInfo()
		{
			string text = string.Empty;
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				text = text + "[" + charMaterialControlRuntimeData.DataCache.Data.GetName() + "]   ";
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.ZJF;
			string empty = string.Empty;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前存在的角色特效DA", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.OwnerActorName);
			instance.Info(module, author, empty, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602271E RID: 141086 RVA: 0x009C485C File Offset: 0x009C2A5C
		public override void Start()
		{
			base.Start();
			this.TempRemoveList.Clear();
			this.RuntimeDataIdGenerator = 0;
			this.EnableDebug = false;
			this.DebugInfo = new PD_MaterialDebug_C();
			this.AllMaterialControlRuntimeDataMap = new Dictionary<int, CharMaterialControlRuntimeData>();
			this.OwnerActorName = base.GetRenderingComponent().GetOwner().GetName();
			CharRenderBase component = this.RenderComponent.GetComponent(1);
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "材质控制器初始化失败，不存在CharMaterialContainer";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.MaterialContainer = (CharMaterialContainer)component;
			CharRenderBase component2 = this.RenderComponent.GetComponent(12);
			this.ExtraMesh = (CharExtraMesh)component2;
			string name = "Render_CharMaterialControllerTick_" + this.OwnerActorName;
			this.StatMaterialControllerTick = Stat.CreateNoFlameGraph(name, "", "");
			base.OnInitSuccess();
		}

		// Token: 0x0602271F RID: 141087 RVA: 0x009C4944 File Offset: 0x009C2B44
		public bool GetRuntimeMaterialControllerValid(int id)
		{
			return this.AllMaterialControlRuntimeDataMap.ContainsKey(id);
		}

		// Token: 0x06022720 RID: 141088 RVA: 0x009C4954 File Offset: 0x009C2B54
		public unsafe override void Update()
		{
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				LogicalTimeDilationOut outVal = new LogicalTimeDilationOut
				{
					LogicalTimeDilation = 1f
				};
				float timeDilation = base.GetRenderingComponent().GetTimeDilation(outVal);
				double delta = Time.Instance.NowSeconds - charMaterialControlRuntimeData.LastUpdateTime;
				charMaterialControlRuntimeData.LastUpdateTime = Time.Instance.NowSeconds;
				charMaterialControlRuntimeData.UpdateState(delta, timeDilation);
				charMaterialControlRuntimeData.UpdateEffect(this.MaterialContainer);
				if (charMaterialControlRuntimeData.IsDead)
				{
					this.TempRemoveList.Add(charMaterialControlRuntimeData.Id);
				}
			}
			if (this.EnableDebug && this.DebugInfo != null)
			{
				this.DebugInfo.MaterialControllerList.Empty(0);
				foreach (KeyValuePair<int, CharMaterialControlRuntimeData> keyValuePair in this.AllMaterialControlRuntimeDataMap)
				{
					this.DebugInfo.MaterialControllerList.Add(keyValuePair.Key, keyValuePair.Value.DataCache.DataName);
				}
			}
			if (this.TempRemoveList.Count > 0)
			{
				foreach (int num in this.TempRemoveList)
				{
					CharMaterialControlRuntimeData charMaterialControlRuntimeData2;
					if (!this.AllMaterialControlRuntimeDataMap.TryGetValue(num, out charMaterialControlRuntimeData2))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.RenderCharacter;
						ELogAuthor author = ELogAuthor.LSY;
						string message = "材质控制器句柄重复移除";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.OwnerActorName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", num);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						charMaterialControlRuntimeData2.Destroy();
						this.AllMaterialControlRuntimeDataMap.Remove(num);
						EventSystem.Instance.EmitWithTarget<int>(this.RenderComponent, EEventName.OnRemoveMaterialController, num);
					}
				}
				this.TempRemoveList.Clear();
				this.UpdateRuntimeDataEffectState();
			}
		}

		// Token: 0x06022721 RID: 141089 RVA: 0x009C4BA4 File Offset: 0x009C2DA4
		public void SetEffectProgress(float progress, int handleId)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (this.AllMaterialControlRuntimeDataMap.TryGetValue(handleId, out charMaterialControlRuntimeData))
			{
				charMaterialControlRuntimeData.SetProgress(progress);
			}
		}

		// Token: 0x06022722 RID: 141090 RVA: 0x009C4BC8 File Offset: 0x009C2DC8
		public override void Destroy()
		{
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				charMaterialControlRuntimeData.Destroy();
			}
			this.AllMaterialControlRuntimeDataMap = new Dictionary<int, CharMaterialControlRuntimeData>();
		}

		// Token: 0x06022723 RID: 141091 RVA: 0x009C4C28 File Offset: 0x009C2E28
		public unsafe void RemoveSkeletalMeshMaterialControllerData(string skelName)
		{
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				if (charMaterialControlRuntimeData.SpecifiedMaterialIndexMap != null)
				{
					charMaterialControlRuntimeData.SpecifiedMaterialIndexMap.Remove(skelName);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "移除材质控制器部件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkelName", skelName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handleId", charMaterialControlRuntimeData.Id);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06022724 RID: 141092 RVA: 0x009C4CF0 File Offset: 0x009C2EF0
		public override void OnResetRenderState()
		{
			if (this.AllMaterialControlRuntimeDataMap.Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.ZJF;
				string message = "移除全部材质控制器";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", base.GetRenderingComponent().GetOwner());
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				charMaterialControlRuntimeData.IsDead = true;
				charMaterialControlRuntimeData.UpdateEffect(this.MaterialContainer);
				charMaterialControlRuntimeData.Destroy();
			}
			this.AllMaterialControlRuntimeDataMap.Clear();
		}

		// Token: 0x06022725 RID: 141093 RVA: 0x009C4DA4 File Offset: 0x009C2FA4
		public bool RemoveMaterialControllerData(int handle)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (!this.AllMaterialControlRuntimeDataMap.TryGetValue(handle, out charMaterialControlRuntimeData))
			{
				return false;
			}
			base.GetRenderingComponent().GetOwner().GetName();
			charMaterialControlRuntimeData.IsDead = true;
			charMaterialControlRuntimeData.UpdateEffect(this.MaterialContainer);
			charMaterialControlRuntimeData.Destroy();
			this.AllMaterialControlRuntimeDataMap.Remove(handle);
			this.UpdateRuntimeDataEffectState();
			return true;
		}

		// Token: 0x06022726 RID: 141094 RVA: 0x009C4E04 File Offset: 0x009C3004
		public bool RemoveMaterialControllerDataWithEnding(int handle)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (!this.AllMaterialControlRuntimeDataMap.TryGetValue(handle, out charMaterialControlRuntimeData))
			{
				return false;
			}
			base.GetRenderingComponent().GetOwner().GetName();
			charMaterialControlRuntimeData.SetReadyToDie();
			return true;
		}

		// Token: 0x06022727 RID: 141095 RVA: 0x009C4E3C File Offset: 0x009C303C
		[NullableContext(2)]
		public unsafe int AddMaterialControllerData(PD_CharacterControllerData_C data, UObject userData = null)
		{
			if (data == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "添加的材质控制器数据为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", base.GetRenderingComponent().GetOwner());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			if (this.AllMaterialControlRuntimeDataMap.Keys.Count > 20)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "材质控制器添加失败，超过单个角色的材质控制器队列数量，检查是否进行了材质控制器移除和材质控制器特效的持续时间";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", base.GetRenderingComponent().GetOwner());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("添加的材质控制器名称", data);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.RuntimeDataIdGenerator++;
			int runtimeDataIdGenerator = this.RuntimeDataIdGenerator;
			if (!this.DealWithExtraMesh(data, runtimeDataIdGenerator))
			{
				return -1;
			}
			CharMaterialControlRuntimeData charMaterialControlRuntimeData = new CharMaterialControlRuntimeData();
			charMaterialControlRuntimeData.Init(runtimeDataIdGenerator, data, userData);
			charMaterialControlRuntimeData.SetSpecifiedMaterialIndex(this.MaterialContainer);
			this.AllMaterialControlRuntimeDataMap.Add(runtimeDataIdGenerator, charMaterialControlRuntimeData);
			this.UpdateRuntimeDataEffectState();
			this.MaterialContainer.MarkForceUpdateThisFrame();
			return runtimeDataIdGenerator;
		}

		// Token: 0x06022728 RID: 141096 RVA: 0x009C4F4C File Offset: 0x009C314C
		private void UpdateRuntimeDataEffectState()
		{
			List<CharMaterialControlRuntimeData> list = new List<CharMaterialControlRuntimeData>(this.AllMaterialControlRuntimeDataMap.Values);
			bool flag = false;
			list.Reverse();
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in list)
			{
				if (flag)
				{
					charMaterialControlRuntimeData.RequestEffectStateRevert();
				}
				else
				{
					charMaterialControlRuntimeData.RequestEffectStateEnter();
				}
				if (charMaterialControlRuntimeData.DataCache.MaskOriginEffect)
				{
					flag = true;
				}
			}
		}

		// Token: 0x06022729 RID: 141097 RVA: 0x009C4FCC File Offset: 0x009C31CC
		public bool AddMaterialControllerDataDestroyCallback(int handle, Action<int> callback)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (!this.AllMaterialControlRuntimeDataMap.TryGetValue(handle, out charMaterialControlRuntimeData))
			{
				return false;
			}
			base.GetRenderingComponent().GetOwner();
			return charMaterialControlRuntimeData.AddDestroyCallback(callback);
		}

		// Token: 0x0602272A RID: 141098 RVA: 0x009C5000 File Offset: 0x009C3200
		public bool RemoveMaterialControllerDataDestroyCallback(int handle, Action<int> callback)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (!this.AllMaterialControlRuntimeDataMap.TryGetValue(handle, out charMaterialControlRuntimeData))
			{
				return false;
			}
			base.GetRenderingComponent().GetOwner().GetName();
			return charMaterialControlRuntimeData.RemoveDestroyCallback(callback);
		}

		// Token: 0x0602272B RID: 141099 RVA: 0x009C5038 File Offset: 0x009C3238
		protected unsafe bool DealWithExtraMesh(PD_CharacterControllerData_C data, int handle)
		{
			if (data.SpecifiedBodyType != ECharacterBodySpecifiedType.ExtraBody)
			{
				return true;
			}
			if (this.ExtraMesh == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "材质控制器添加失败，ExtraMesh不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", base.GetRenderingComponent().GetOwner());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("添加的材质控制器名称", data);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (data.MaterialModifyType != ECharacterControllerApplyType.ReplaceMaterial)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.LSY;
				string message2 = "材质控制器添加失败，ExtraMesh只支持材质替换";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", base.GetRenderingComponent().GetOwner());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("添加的材质控制器名称", data);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			if (data.SpecifiedBodyType == ECharacterBodySpecifiedType.ExtraBody)
			{
				string[] bodyNamesByBodyType = RenderConfig.GetBodyNamesByBodyType(ECharacterBodySpecifiedType.Body);
				string bodyName = bodyNamesByBodyType[0];
				this.ExtraMesh.EnsureExtraMesh(bodyName);
				this.ExtraMesh.AddExtraSkeletalMeshUsage(bodyName);
				this.AddMaterialControllerDataDestroyCallback(handle, delegate(int _)
				{
					CharExtraMesh extraMesh = this.ExtraMesh;
					if (extraMesh == null)
					{
						return;
					}
					extraMesh.RemoveExtraSkeletalMeshUsage(bodyName);
				});
				return true;
			}
			return false;
		}

		// Token: 0x0602272C RID: 141100 RVA: 0x009C5199 File Offset: 0x009C3399
		public override int GetComponentId()
		{
			return 2;
		}

		// Token: 0x0602272D RID: 141101 RVA: 0x009C519C File Offset: 0x009C339C
		public override string GetStatName()
		{
			return "CharMaterialController";
		}

		// Token: 0x04012F42 RID: 77634
		[Nullable(2)]
		public CharMaterialContainer MaterialContainer;

		// Token: 0x04012F43 RID: 77635
		[Nullable(2)]
		public CharExtraMesh ExtraMesh;

		// Token: 0x04012F44 RID: 77636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, CharMaterialControlRuntimeData> AllMaterialControlRuntimeDataMap;

		// Token: 0x04012F45 RID: 77637
		private int RuntimeDataIdGenerator;

		// Token: 0x04012F46 RID: 77638
		private readonly List<int> TempRemoveList = new List<int>();

		// Token: 0x04012F47 RID: 77639
		private string OwnerActorName = string.Empty;

		// Token: 0x04012F48 RID: 77640
		public bool EnableDebug;

		// Token: 0x04012F49 RID: 77641
		[Nullable(2)]
		public PD_MaterialDebug_C DebugInfo;

		// Token: 0x04012F4A RID: 77642
		[Nullable(2)]
		private Stat StatMaterialControllerTick;
	}
}

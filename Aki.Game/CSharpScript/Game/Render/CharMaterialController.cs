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
	// Token: 0x020045AF RID: 17839
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialController : CharRenderBase
	{
		// Token: 0x0602E033 RID: 188467 RVA: 0x00A9856C File Offset: 0x00A9676C
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

		// Token: 0x0602E034 RID: 188468 RVA: 0x00A9863C File Offset: 0x00A9683C
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

		// Token: 0x0602E035 RID: 188469 RVA: 0x00A98724 File Offset: 0x00A96924
		public bool GetRuntimeMaterialControllerValid(int id)
		{
			return this.AllMaterialControlRuntimeDataMap.ContainsKey(id);
		}

		// Token: 0x0602E036 RID: 188470 RVA: 0x00A98734 File Offset: 0x00A96934
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

		// Token: 0x0602E037 RID: 188471 RVA: 0x00A98984 File Offset: 0x00A96B84
		public void SetEffectProgress(float progress, int handleId)
		{
			CharMaterialControlRuntimeData charMaterialControlRuntimeData;
			if (this.AllMaterialControlRuntimeDataMap.TryGetValue(handleId, out charMaterialControlRuntimeData))
			{
				charMaterialControlRuntimeData.SetProgress(progress);
			}
		}

		// Token: 0x0602E038 RID: 188472 RVA: 0x00A989A8 File Offset: 0x00A96BA8
		public override void Destroy()
		{
			foreach (CharMaterialControlRuntimeData charMaterialControlRuntimeData in this.AllMaterialControlRuntimeDataMap.Values)
			{
				charMaterialControlRuntimeData.Destroy();
			}
			this.AllMaterialControlRuntimeDataMap = new Dictionary<int, CharMaterialControlRuntimeData>();
		}

		// Token: 0x0602E039 RID: 188473 RVA: 0x00A98A08 File Offset: 0x00A96C08
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

		// Token: 0x0602E03A RID: 188474 RVA: 0x00A98AD0 File Offset: 0x00A96CD0
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

		// Token: 0x0602E03B RID: 188475 RVA: 0x00A98B84 File Offset: 0x00A96D84
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

		// Token: 0x0602E03C RID: 188476 RVA: 0x00A98BE4 File Offset: 0x00A96DE4
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

		// Token: 0x0602E03D RID: 188477 RVA: 0x00A98C1C File Offset: 0x00A96E1C
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

		// Token: 0x0602E03E RID: 188478 RVA: 0x00A98D2C File Offset: 0x00A96F2C
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

		// Token: 0x0602E03F RID: 188479 RVA: 0x00A98DAC File Offset: 0x00A96FAC
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

		// Token: 0x0602E040 RID: 188480 RVA: 0x00A98DE0 File Offset: 0x00A96FE0
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

		// Token: 0x0602E041 RID: 188481 RVA: 0x00A98E18 File Offset: 0x00A97018
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

		// Token: 0x0602E042 RID: 188482 RVA: 0x00A98F79 File Offset: 0x00A97179
		public override int GetComponentId()
		{
			return 2;
		}

		// Token: 0x0602E043 RID: 188483 RVA: 0x00A98F7C File Offset: 0x00A9717C
		public override string GetStatName()
		{
			return "CharMaterialController";
		}

		// Token: 0x04018907 RID: 100615
		[Nullable(2)]
		public CharMaterialContainer MaterialContainer;

		// Token: 0x04018908 RID: 100616
		[Nullable(2)]
		public CharExtraMesh ExtraMesh;

		// Token: 0x04018909 RID: 100617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, CharMaterialControlRuntimeData> AllMaterialControlRuntimeDataMap;

		// Token: 0x0401890A RID: 100618
		private int RuntimeDataIdGenerator;

		// Token: 0x0401890B RID: 100619
		private readonly List<int> TempRemoveList = new List<int>();

		// Token: 0x0401890C RID: 100620
		private string OwnerActorName = string.Empty;

		// Token: 0x0401890D RID: 100621
		public bool EnableDebug;

		// Token: 0x0401890E RID: 100622
		[Nullable(2)]
		public PD_MaterialDebug_C DebugInfo;

		// Token: 0x0401890F RID: 100623
		[Nullable(2)]
		private Stat StatMaterialControllerTick;
	}
}

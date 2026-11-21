using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D8 RID: 13528
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlRuntimeDataGroup
	{
		// Token: 0x0602272F RID: 141103 RVA: 0x009C51C4 File Offset: 0x009C33C4
		[NullableContext(1)]
		public void Init(CharRenderingComponent charRenderingComponent, PD_CharacterControllerDataGroup_C dataGroup, [Nullable(2)] USkeletalMeshComponent animObject = null)
		{
			this.CharRenderingComponent = charRenderingComponent;
			this.DataGroup = dataGroup;
			this.DataMap = new Dictionary<PD_CharacterControllerData_C, float>();
			this.TempRemoveList = new List<PD_CharacterControllerData_C>();
			this.MaterialHandles = new List<int>();
			this.TempMaterialHandles = new List<int>();
			this.IsDead = false;
			this.AnimObject = animObject;
			this.WholeSpawnTime = 0f;
			this.HaveRuntimeData = false;
			MapUtils.ForEach<PD_CharacterControllerData_C, float>(this.DataGroup.DataMap, delegate(PD_CharacterControllerData_C key, float value)
			{
				if (this.WholeSpawnTime < value)
				{
					this.WholeSpawnTime = value;
				}
				this.HaveRuntimeData = (this.HaveRuntimeData || key.DataType == ECharacterControllerType.Runtime);
				if (value > 0f)
				{
					this.DataMap.Add(key, value);
					return;
				}
				this.MaterialHandles.Add((int)charRenderingComponent.AddMaterialControllerDataWithAnimObject(key, this.AnimObject, null));
			});
		}

		// Token: 0x06022730 RID: 141104 RVA: 0x009C5260 File Offset: 0x009C3460
		public void BeforeUpdateState(float deltaTime, float timeDilation)
		{
			if (!this.IgnoreTimeDilation)
			{
				this.IgnoreTimeDilation = this.DataGroup.IgnoreTimeDilation;
			}
			float num = deltaTime;
			if (!this.IgnoreTimeDilation && RenderModuleController.Instance.IsGamePaused)
			{
				return;
			}
			if (!this.IgnoreTimeDilation)
			{
				num = deltaTime * timeDilation;
			}
			this.WholeSpawnTime -= num;
			List<PD_CharacterControllerData_C> list = new List<PD_CharacterControllerData_C>();
			foreach (KeyValuePair<PD_CharacterControllerData_C, float> keyValuePair in this.DataMap)
			{
				PD_CharacterControllerData_C key = keyValuePair.Key;
				float num2 = keyValuePair.Value - num;
				if (num2 <= 0f)
				{
					this.MaterialHandles.Add((int)this.CharRenderingComponent.AddMaterialControllerDataWithAnimObject(key, this.AnimObject, null));
					list.Add(key);
				}
				else
				{
					this.DataMap[key] = num2;
				}
			}
			if (list.Count > 0)
			{
				foreach (PD_CharacterControllerData_C key2 in list)
				{
					this.DataMap.Remove(key2);
				}
			}
			this.TempRemoveList = new List<PD_CharacterControllerData_C>();
		}

		// Token: 0x06022731 RID: 141105 RVA: 0x009C53AC File Offset: 0x009C35AC
		public void AfterUpdateState(float deltaTime)
		{
			if (!this.HaveRuntimeData && this.WholeSpawnTime <= 0f)
			{
				this.TempMaterialHandles = new List<int>();
				for (int i = 0; i < this.MaterialHandles.Count; i++)
				{
					if (this.CharRenderingComponent.IsMaterialControllerDataValid(this.MaterialHandles[i]))
					{
						this.TempMaterialHandles.Add(this.MaterialHandles[i]);
					}
				}
				this.MaterialHandles = this.TempMaterialHandles;
				this.IsDead = (this.MaterialHandles.Count == 0 && this.DataMap.Count == 0);
			}
		}

		// Token: 0x06022732 RID: 141106 RVA: 0x009C5458 File Offset: 0x009C3658
		public void EndState()
		{
			this.TempRemoveList = new List<PD_CharacterControllerData_C>();
			this.DataMap.Clear();
			foreach (int handle in this.MaterialHandles)
			{
				this.CharRenderingComponent.RemoveMaterialControllerData(handle);
			}
			this.IsDead = true;
		}

		// Token: 0x06022733 RID: 141107 RVA: 0x009C54D0 File Offset: 0x009C36D0
		public void EndStateWithEnding()
		{
			this.TempRemoveList = new List<PD_CharacterControllerData_C>();
			this.DataMap.Clear();
			foreach (int handle in this.MaterialHandles)
			{
				this.CharRenderingComponent.RemoveMaterialControllerDataWithEnding(handle);
			}
			this.IsDead = true;
		}

		// Token: 0x06022734 RID: 141108 RVA: 0x009C5548 File Offset: 0x009C3748
		public void SetEffectProgress(float progress)
		{
			foreach (int handleId in this.MaterialHandles)
			{
				this.CharRenderingComponent.SetEffectProgress(progress, handleId);
			}
		}

		// Token: 0x04012F4B RID: 77643
		public CharRenderingComponent CharRenderingComponent;

		// Token: 0x04012F4C RID: 77644
		public PD_CharacterControllerDataGroup_C DataGroup;

		// Token: 0x04012F4D RID: 77645
		public USkeletalMeshComponent AnimObject;

		// Token: 0x04012F4E RID: 77646
		public bool IsDead;

		// Token: 0x04012F4F RID: 77647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<PD_CharacterControllerData_C, float> DataMap;

		// Token: 0x04012F50 RID: 77648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<PD_CharacterControllerData_C> TempRemoveList;

		// Token: 0x04012F51 RID: 77649
		private List<int> MaterialHandles;

		// Token: 0x04012F52 RID: 77650
		private List<int> TempMaterialHandles;

		// Token: 0x04012F53 RID: 77651
		private float WholeSpawnTime;

		// Token: 0x04012F54 RID: 77652
		private bool HaveRuntimeData;

		// Token: 0x04012F55 RID: 77653
		private bool IgnoreTimeDilation;
	}
}

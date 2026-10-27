using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B0 RID: 17840
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlRuntimeDataGroup
	{
		// Token: 0x0602E045 RID: 188485 RVA: 0x00A98FA4 File Offset: 0x00A971A4
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

		// Token: 0x0602E046 RID: 188486 RVA: 0x00A99040 File Offset: 0x00A97240
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

		// Token: 0x0602E047 RID: 188487 RVA: 0x00A9918C File Offset: 0x00A9738C
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

		// Token: 0x0602E048 RID: 188488 RVA: 0x00A99238 File Offset: 0x00A97438
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

		// Token: 0x0602E049 RID: 188489 RVA: 0x00A992B0 File Offset: 0x00A974B0
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

		// Token: 0x0602E04A RID: 188490 RVA: 0x00A99328 File Offset: 0x00A97528
		public void SetEffectProgress(float progress)
		{
			foreach (int handleId in this.MaterialHandles)
			{
				this.CharRenderingComponent.SetEffectProgress(progress, handleId);
			}
		}

		// Token: 0x04018910 RID: 100624
		public CharRenderingComponent CharRenderingComponent;

		// Token: 0x04018911 RID: 100625
		public PD_CharacterControllerDataGroup_C DataGroup;

		// Token: 0x04018912 RID: 100626
		public USkeletalMeshComponent AnimObject;

		// Token: 0x04018913 RID: 100627
		public bool IsDead;

		// Token: 0x04018914 RID: 100628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<PD_CharacterControllerData_C, float> DataMap;

		// Token: 0x04018915 RID: 100629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<PD_CharacterControllerData_C> TempRemoveList;

		// Token: 0x04018916 RID: 100630
		private List<int> MaterialHandles;

		// Token: 0x04018917 RID: 100631
		private List<int> TempMaterialHandles;

		// Token: 0x04018918 RID: 100632
		private float WholeSpawnTime;

		// Token: 0x04018919 RID: 100633
		private bool HaveRuntimeData;

		// Token: 0x0401891A RID: 100634
		private bool IgnoreTimeDilation;
	}
}

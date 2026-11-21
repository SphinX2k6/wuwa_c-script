using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D6 RID: 13526
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialSlot
	{
		// Token: 0x0602270D RID: 141069 RVA: 0x009C40FC File Offset: 0x009C22FC
		public void Init(int materialIndex, string slotName, [Nullable(2)] UMaterialInstanceDynamic dynamicMaterial)
		{
			this.SlotName = slotName;
			this.MaterialIndex = materialIndex;
			this.SectionIndex = 99999;
			this.FloatParamDirty = false;
			this.VectorParamDirty = false;
			this.TextureParamDirty = false;
			this.IsStarScar = (slotName == "MI_Star");
			this.SlotType = RenderConfig.GetMaterialSlotType(slotName);
			this.MaterialPartType = RenderConfig.GetMaterialPartType(slotName);
			this.SetDynamicMaterial(dynamicMaterial);
			this.ReplaceMaterialArray = new List<UMaterialInstanceDynamic>();
		}

		// Token: 0x0602270E RID: 141070 RVA: 0x009C4172 File Offset: 0x009C2372
		[NullableContext(2)]
		public void SetDynamicMaterial(UMaterialInstanceDynamic dynamicMaterial)
		{
			this.DynamicMaterial = dynamicMaterial;
			if (dynamicMaterial != null)
			{
				this.FloatParamMap = new Dictionary<string, float[]>();
				this.VectorParamMap = new Dictionary<string, ColorTempContainer[]>();
				this.TextureParamMap = new Dictionary<string, UTexture[]>();
			}
			this.MaterialDirty = true;
		}

		// Token: 0x0602270F RID: 141071 RVA: 0x009C41A8 File Offset: 0x009C23A8
		public void SetSkeletalMeshMaterial(USkeletalMeshComponent skeletalComp)
		{
			if (this.MaterialDirty)
			{
				this.MaterialDirty = false;
				int count = this.ReplaceMaterialArray.Count;
				if (count > 0)
				{
					skeletalComp.SetMaterial(this.MaterialIndex, this.ReplaceMaterialArray[count - 1]);
					return;
				}
				skeletalComp.SetMaterial(this.MaterialIndex, this.DynamicMaterial ?? RenderDataManager.Instance.GetEmptyMaterial());
			}
		}

		// Token: 0x06022710 RID: 141072 RVA: 0x009C4210 File Offset: 0x009C2410
		public int UpdateMaterialParam()
		{
			if (!this.IsDynamicMaterialValid())
			{
				return 0;
			}
			UMaterialInstanceDynamic dynamicMaterial = this.DynamicMaterial;
			int num = 0;
			if (this.FloatParamDirty)
			{
				this.FloatParamDirty = false;
				foreach (KeyValuePair<string, float[]> keyValuePair in this.FloatParamMap)
				{
					string key = keyValuePair.Key;
					float[] value = keyValuePair.Value;
					if (value[1] != value[2])
					{
						value[1] = value[2];
						dynamicMaterial.SetScalarParameterValue(FNameUtil.GetDynamicFName(key).Value, value[2]);
						num++;
					}
				}
			}
			if (this.VectorParamDirty)
			{
				this.VectorParamDirty = false;
				foreach (KeyValuePair<string, ColorTempContainer[]> keyValuePair2 in this.VectorParamMap)
				{
					string key2 = keyValuePair2.Key;
					ColorTempContainer[] value2 = keyValuePair2.Value;
					if (value2[1] != value2[2])
					{
						value2[1] = value2[2];
						ColorTempContainer colorTempContainer = value2[2];
						FLinearColor value3 = new FLinearColor(colorTempContainer.ColorR, colorTempContainer.ColorG, colorTempContainer.ColorB, colorTempContainer.ColorA);
						dynamicMaterial.SetVectorParameterValue(FNameUtil.GetDynamicFName(key2).Value, value3);
						num++;
					}
				}
			}
			if (this.TextureParamDirty)
			{
				this.TextureParamDirty = false;
				foreach (KeyValuePair<string, UTexture[]> keyValuePair3 in this.TextureParamMap)
				{
					string key3 = keyValuePair3.Key;
					UTexture[] value4 = keyValuePair3.Value;
					UTexture utexture = value4[2];
					if (utexture != null && value4[1] != utexture)
					{
						value4[1] = utexture;
						dynamicMaterial.SetTextureParameterValue(FNameUtil.GetDynamicFName(key3).Value, utexture);
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06022711 RID: 141073 RVA: 0x009C440C File Offset: 0x009C260C
		public void SetReplaceMaterial(UMaterialInstanceDynamic replaceMaterial)
		{
			this.ReplaceMaterialArray.Add(replaceMaterial);
			this.MaterialDirty = true;
		}

		// Token: 0x06022712 RID: 141074 RVA: 0x009C4424 File Offset: 0x009C2624
		public bool RevertReplaceMaterial(UMaterialInstanceDynamic replaceMaterial)
		{
			List<UMaterialInstanceDynamic> list = new List<UMaterialInstanceDynamic>();
			bool result = false;
			for (int i = 0; i < this.ReplaceMaterialArray.Count; i++)
			{
				if (this.ReplaceMaterialArray[i] != replaceMaterial)
				{
					list.Add(this.ReplaceMaterialArray[i]);
				}
				else
				{
					result = true;
				}
			}
			this.ReplaceMaterialArray = list;
			this.MaterialDirty = true;
			return result;
		}

		// Token: 0x06022713 RID: 141075 RVA: 0x009C4484 File Offset: 0x009C2684
		public void SetFloat(FName property, float value)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			string key = property.ToString();
			this.FloatParamDirty = true;
			if (!this.FloatParamMap.ContainsKey(key))
			{
				this.FloatParamMap[key] = new float[]
				{
					this.DynamicMaterial.K2_GetScalarParameterValue(property),
					value + 1f,
					value
				};
				return;
			}
			this.FloatParamMap[key][2] = value;
		}

		// Token: 0x06022714 RID: 141076 RVA: 0x009C44FC File Offset: 0x009C26FC
		public void RevertFloat(string propertyStr)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			if (this.FloatParamMap.ContainsKey(propertyStr))
			{
				this.FloatParamDirty = true;
				float[] array = this.FloatParamMap[propertyStr];
				array[2] = array[0];
			}
		}

		// Token: 0x06022715 RID: 141077 RVA: 0x009C453C File Offset: 0x009C273C
		public void SetColor(FName property, FLinearColor value)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			string key = property.ToString();
			this.VectorParamDirty = true;
			ColorTempContainer colorTempContainer = new ColorTempContainer
			{
				ColorR = value.R,
				ColorG = value.G,
				ColorB = value.B,
				ColorA = value.A
			};
			if (!this.VectorParamMap.ContainsKey(key))
			{
				FLinearColor flinearColor = this.DynamicMaterial.K2_GetVectorParameterValue(property);
				ColorTempContainer colorTempContainer2 = new ColorTempContainer
				{
					ColorR = flinearColor.R,
					ColorG = flinearColor.G,
					ColorB = flinearColor.B,
					ColorA = flinearColor.A
				};
				this.VectorParamMap[key] = new ColorTempContainer[]
				{
					colorTempContainer2,
					null,
					colorTempContainer
				};
				return;
			}
			this.VectorParamMap[key][2] = colorTempContainer;
		}

		// Token: 0x06022716 RID: 141078 RVA: 0x009C4618 File Offset: 0x009C2818
		public void RevertColor(string propertyStr)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			if (this.VectorParamMap.ContainsKey(propertyStr))
			{
				this.VectorParamDirty = true;
				ColorTempContainer[] array = this.VectorParamMap[propertyStr];
				array[2] = array[0];
			}
		}

		// Token: 0x06022717 RID: 141079 RVA: 0x009C4658 File Offset: 0x009C2858
		public void SetTexture(FName property, UTexture value)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			string key = property.ToString();
			this.TextureParamDirty = true;
			if (!this.TextureParamMap.ContainsKey(key))
			{
				this.TextureParamMap[key] = new UTexture[]
				{
					this.DynamicMaterial.K2_GetTextureParameterValue(property),
					null,
					value
				};
				return;
			}
			this.TextureParamMap[key][2] = value;
		}

		// Token: 0x06022718 RID: 141080 RVA: 0x009C46C8 File Offset: 0x009C28C8
		public void RevertTexture(string propertyStr)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			if (this.TextureParamMap.ContainsKey(propertyStr))
			{
				this.TextureParamDirty = true;
				UTexture[] array = this.TextureParamMap[propertyStr];
				array[2] = array[0];
			}
		}

		// Token: 0x06022719 RID: 141081 RVA: 0x009C4708 File Offset: 0x009C2908
		public void RevertProperty(FName property)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			string propertyStr = property.ToString();
			this.RevertColor(propertyStr);
			this.RevertFloat(propertyStr);
			this.RevertTexture(propertyStr);
		}

		// Token: 0x0602271A RID: 141082 RVA: 0x009C4741 File Offset: 0x009C2941
		public void SetStarScarEnergy(float energy)
		{
			if (!this.IsDynamicMaterialValid())
			{
				return;
			}
			if (this.IsStarScar)
			{
				this.SetFloat(RenderConfig.StarScarEnergyControl, energy);
			}
		}

		// Token: 0x0602271B RID: 141083 RVA: 0x009C4760 File Offset: 0x009C2960
		public bool IsDynamicMaterialValid()
		{
			return this.DynamicMaterial != null && this.DynamicMaterial.IsValid();
		}

		// Token: 0x04012F2F RID: 77615
		[Nullable(2)]
		public UMaterialInstanceDynamic DynamicMaterial;

		// Token: 0x04012F30 RID: 77616
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, float[]> FloatParamMap;

		// Token: 0x04012F31 RID: 77617
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			2
		})]
		public Dictionary<string, ColorTempContainer[]> VectorParamMap;

		// Token: 0x04012F32 RID: 77618
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			2
		})]
		public Dictionary<string, UTexture[]> TextureParamMap;

		// Token: 0x04012F33 RID: 77619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UMaterialInstanceDynamic> ReplaceMaterialArray;

		// Token: 0x04012F34 RID: 77620
		public string SlotName = string.Empty;

		// Token: 0x04012F35 RID: 77621
		public int MaterialIndex;

		// Token: 0x04012F36 RID: 77622
		public int SectionIndex;

		// Token: 0x04012F37 RID: 77623
		public bool IsStarScar;

		// Token: 0x04012F38 RID: 77624
		public ECharacterMeshPart MaterialPartType;

		// Token: 0x04012F39 RID: 77625
		public ECharacterSlotType SlotType;

		// Token: 0x04012F3A RID: 77626
		public bool MaterialDirty;

		// Token: 0x04012F3B RID: 77627
		private bool FloatParamDirty;

		// Token: 0x04012F3C RID: 77628
		private bool VectorParamDirty;

		// Token: 0x04012F3D RID: 77629
		private bool TextureParamDirty;

		// Token: 0x04012F3E RID: 77630
		private const string STAR_SCAR_SLOT_NAME = "MI_Star";

		// Token: 0x04012F3F RID: 77631
		private const int ORIGINAL_INDEX = 0;

		// Token: 0x04012F40 RID: 77632
		private const int CACHE_INDEX = 1;

		// Token: 0x04012F41 RID: 77633
		private const int TARGET_INDEX = 2;
	}
}

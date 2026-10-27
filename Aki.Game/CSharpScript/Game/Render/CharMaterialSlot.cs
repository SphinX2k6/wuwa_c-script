using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045AE RID: 17838
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialSlot
	{
		// Token: 0x0602E023 RID: 188451 RVA: 0x00A97EDC File Offset: 0x00A960DC
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

		// Token: 0x0602E024 RID: 188452 RVA: 0x00A97F52 File Offset: 0x00A96152
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

		// Token: 0x0602E025 RID: 188453 RVA: 0x00A97F88 File Offset: 0x00A96188
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

		// Token: 0x0602E026 RID: 188454 RVA: 0x00A97FF0 File Offset: 0x00A961F0
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

		// Token: 0x0602E027 RID: 188455 RVA: 0x00A981EC File Offset: 0x00A963EC
		public void SetReplaceMaterial(UMaterialInstanceDynamic replaceMaterial)
		{
			this.ReplaceMaterialArray.Add(replaceMaterial);
			this.MaterialDirty = true;
		}

		// Token: 0x0602E028 RID: 188456 RVA: 0x00A98204 File Offset: 0x00A96404
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

		// Token: 0x0602E029 RID: 188457 RVA: 0x00A98264 File Offset: 0x00A96464
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

		// Token: 0x0602E02A RID: 188458 RVA: 0x00A982DC File Offset: 0x00A964DC
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

		// Token: 0x0602E02B RID: 188459 RVA: 0x00A9831C File Offset: 0x00A9651C
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

		// Token: 0x0602E02C RID: 188460 RVA: 0x00A983F8 File Offset: 0x00A965F8
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

		// Token: 0x0602E02D RID: 188461 RVA: 0x00A98438 File Offset: 0x00A96638
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

		// Token: 0x0602E02E RID: 188462 RVA: 0x00A984A8 File Offset: 0x00A966A8
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

		// Token: 0x0602E02F RID: 188463 RVA: 0x00A984E8 File Offset: 0x00A966E8
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

		// Token: 0x0602E030 RID: 188464 RVA: 0x00A98521 File Offset: 0x00A96721
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

		// Token: 0x0602E031 RID: 188465 RVA: 0x00A98540 File Offset: 0x00A96740
		public bool IsDynamicMaterialValid()
		{
			return this.DynamicMaterial != null && this.DynamicMaterial.IsValid();
		}

		// Token: 0x040188F4 RID: 100596
		[Nullable(2)]
		public UMaterialInstanceDynamic DynamicMaterial;

		// Token: 0x040188F5 RID: 100597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, float[]> FloatParamMap;

		// Token: 0x040188F6 RID: 100598
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			2
		})]
		public Dictionary<string, ColorTempContainer[]> VectorParamMap;

		// Token: 0x040188F7 RID: 100599
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			2
		})]
		public Dictionary<string, UTexture[]> TextureParamMap;

		// Token: 0x040188F8 RID: 100600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UMaterialInstanceDynamic> ReplaceMaterialArray;

		// Token: 0x040188F9 RID: 100601
		public string SlotName = string.Empty;

		// Token: 0x040188FA RID: 100602
		public int MaterialIndex;

		// Token: 0x040188FB RID: 100603
		public int SectionIndex;

		// Token: 0x040188FC RID: 100604
		public bool IsStarScar;

		// Token: 0x040188FD RID: 100605
		public ECharacterMeshPart MaterialPartType;

		// Token: 0x040188FE RID: 100606
		public ECharacterSlotType SlotType;

		// Token: 0x040188FF RID: 100607
		public bool MaterialDirty;

		// Token: 0x04018900 RID: 100608
		private bool FloatParamDirty;

		// Token: 0x04018901 RID: 100609
		private bool VectorParamDirty;

		// Token: 0x04018902 RID: 100610
		private bool TextureParamDirty;

		// Token: 0x04018903 RID: 100611
		private const string STAR_SCAR_SLOT_NAME = "MI_Star";

		// Token: 0x04018904 RID: 100612
		private const int ORIGINAL_INDEX = 0;

		// Token: 0x04018905 RID: 100613
		private const int CACHE_INDEX = 1;

		// Token: 0x04018906 RID: 100614
		private const int TARGET_INDEX = 2;
	}
}

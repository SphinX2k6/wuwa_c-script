using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F57 RID: 28503
	public class BigStuffedRingBgItem : BigStuffedRingSubItem<ESubItemType>
	{
		// Token: 0x06045579 RID: 284025 RVA: 0x0112895F File Offset: 0x01126B5F
		[NullableContext(1)]
		public BigStuffedRingBgItem(int ringId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> config, BigStuffedRingInfo ringInfo) : base(ringId, config)
		{
			this.Type = ESubItemType.Bg;
			this.RingInfo = ringInfo;
		}

		// Token: 0x0604557A RID: 284026 RVA: 0x01128977 File Offset: 0x01126B77
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUITexture)));
		}

		// Token: 0x0604557B RID: 284027 RVA: 0x011289B8 File Offset: 0x01126BB8
		protected override void OnStart()
		{
			base.OnStart();
			this.TextureRing.SetTextureType(UITextureType.Filled);
			this.TextureRing.SetFillMethod(UISpriteFillMethod.Radial360);
			this.TextureRing.SetFillOrigin(2);
			this.TextureRing.SetFillDirectionFlip(true);
			base.GetItem(2).SetUIActive(false);
			this.SpawnBgByHideArea(this.TextureRing);
		}

		// Token: 0x0604557C RID: 284028 RVA: 0x01128A14 File Offset: 0x01126C14
		[NullableContext(1)]
		private void SpawnBgByHideArea(UUITexture texture)
		{
			List<Area> validAreas = this.RingInfo.GetValidAreas();
			this.RingInfo.ClearValidAreas();
			List<List<int>> list = null;
			if (this.RingConfig.IsT1)
			{
				list = new List<List<int>>(this.RingConfig.AsT1.InvalidBoxLength);
				for (int i = 0; i < this.RingConfig.AsT1.InvalidBoxLength; i++)
				{
					List<int> list2 = new List<int>();
					IntArray? intArray = this.RingConfig.AsT1.InvalidBox(i);
					for (int j = 0; j < intArray.Value.ArrayIntLength; j++)
					{
						list2.Add(intArray.Value.ArrayInt(j));
					}
					list.Add(list2);
				}
			}
			else if (this.RingConfig.IsT2)
			{
				list = this.RingConfig.AsT2.InvalidBox;
			}
			List<List<int>> list3 = list;
			UUITexture uuitexture = base.GetTexture(3);
			if (list3.Count == 0)
			{
				texture.SetFillAmount(1f);
				uuitexture.SetFillAmount(1f);
				this.RingInfo.AddValidArea(1, 36);
				return;
			}
			List<int[]> list4 = new List<int[]>();
			foreach (List<int> list5 in list3)
			{
				list4.Add(new int[]
				{
					list5[0],
					list5[1]
				});
			}
			list4.Sort((int[] a, int[] b) => a[0] - b[0]);
			int num = 1;
			int num2 = -1;
			foreach (int[] array in list4)
			{
				int num3 = array[0];
				int num4 = array[1];
				if (num < num3)
				{
					this.RingInfo.AddValidArea(num, num3 - 1);
					if (num == 1)
					{
						num2 = validAreas.Count - 1;
					}
				}
				num = Math.Max(num, num4 + 1);
			}
			if (num <= 36)
			{
				if (num2 != -1)
				{
					Area area = validAreas[num2];
					validAreas.RemoveAt(num2);
					this.RingInfo.AddValidArea(num, area.EndCellIndex);
					validAreas.Sort((Area a, Area b) => a.StartCellIndex - b.StartCellIndex);
				}
				else
				{
					this.RingInfo.AddValidArea(num, 36);
				}
			}
			UUITexture uuitexture2 = base.GetTexture(1);
			UUIItem item = base.GetItem(2);
			for (int k = 0; k < validAreas.Count; k++)
			{
				int startCellIndex = validAreas[k].StartCellIndex;
				int endCellIndex = validAreas[k].EndCellIndex;
				if (k != 0)
				{
					uuitexture2 = (LguiUtil.Instance.DuplicateActor(uuitexture2.GetOwner(), this.RootItem).GetComponentByClass(UUITexture.StaticClass()) as UUITexture);
					uuitexture = (LguiUtil.Instance.DuplicateActor(uuitexture.GetOwner(), this.RootItem).GetComponentByClass(UUITexture.StaticClass()) as UUITexture);
				}
				float num5 = (float)Math.Max(startCellIndex - 1, 0) * 10f;
				FRotator frotator = Rotator.Create(0f, -num5, 0f).ToUeRotator();
				uuitexture2.SetUIRelativeRotation(frotator);
				int num6 = BigStuffedDefine.calculateCellSize(startCellIndex, endCellIndex) / 36;
				uuitexture2.SetFillAmount((float)num6);
				uuitexture.SetUIRelativeRotation(frotator);
				uuitexture.SetFillAmount((float)num6);
				if (list3.Count != 0)
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, this.RootItem);
					FRotator frotator2 = Rotator.Create(0f, -num5 + 0.5f, 0f).ToUeRotator();
					uuiitem.SetUIRelativeRotation(frotator2);
					uuiitem.SetUIActive(true);
					uuiitem.SetAsLastHierarchy();
				}
				if (list3.Count != 0)
				{
					UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(item, this.RootItem);
					float num7 = (float)endCellIndex * 10f;
					FRotator frotator2 = Rotator.Create(0f, -num7 - 0.5f, 0f).ToUeRotator();
					uuiitem2.SetUIRelativeRotation(frotator2);
					uuiitem2.SetUIActive(true);
					uuiitem2.SetAsLastHierarchy();
				}
			}
		}

		// Token: 0x040242B0 RID: 148144
		[Nullable(2)]
		private readonly BigStuffedRingInfo RingInfo;

		// Token: 0x0200CD8E RID: 52622
		private class ERingBgItemComponent
		{
			// Token: 0x0403DEFF RID: 253695
			public const int TextureRingLine = 2;

			// Token: 0x0403DF00 RID: 253696
			public const int TextureRedBg = 3;
		}
	}
}

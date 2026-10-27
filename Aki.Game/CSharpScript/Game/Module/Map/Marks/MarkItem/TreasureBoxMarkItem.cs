using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054FF RID: 21759
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxMarkItem : ServerMarkItem
	{
		// Token: 0x1700859A RID: 34202
		// (get) Token: 0x06037974 RID: 227700 RVA: 0x00D32DCB File Offset: 0x00D30FCB
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TreasureBox;
			}
		}

		// Token: 0x1700859B RID: 34203
		// (get) Token: 0x06037975 RID: 227701 RVA: 0x00D32DCF File Offset: 0x00D30FCF
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x06037976 RID: 227702 RVA: 0x00D32DD7 File Offset: 0x00D30FD7
		public TreasureBoxMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x06037977 RID: 227703 RVA: 0x00D32DE4 File Offset: 0x00D30FE4
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x06037978 RID: 227704 RVA: 0x00D32E1C File Offset: 0x00D3101C
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TreasureBoxMarkItemView;
		}

		// Token: 0x06037979 RID: 227705 RVA: 0x00D32E20 File Offset: 0x00D31020
		[PreserveBaseOverrides]
		protected new virtual TreasureBoxMarkItemView CreateView()
		{
			return new TreasureBoxMarkItemView(this);
		}

		// Token: 0x0603797A RID: 227706 RVA: 0x00D32E28 File Offset: 0x00D31028
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0603797B RID: 227707 RVA: 0x00D32E40 File Offset: 0x00D31040
		public void OnSetConfigId(int configId)
		{
			TreasureBoxMark? treasureBoxMarkConfig = MapConfig.Instance.GetTreasureBoxMarkConfig(configId);
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = treasureBoxMarkConfig.Value.MarkPic,
				Scale = new float?(treasureBoxMarkConfig.Value.Scale),
				ShowPriority = new int?(treasureBoxMarkConfig.Value.ShowPriority),
				ShowRange = treasureBoxMarkConfig.Value.ShowRange()
			});
		}

		// Token: 0x0603797C RID: 227708 RVA: 0x00D32EC2 File Offset: 0x00D310C2
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0603797D RID: 227709 RVA: 0x00D32ECC File Offset: 0x00D310CC
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0603797E RID: 227710 RVA: 0x00D32F00 File Offset: 0x00D31100
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x0603797F RID: 227711 RVA: 0x00D32F33 File Offset: 0x00D31133
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0401D402 RID: 119810
		public int DetectorId;

		// Token: 0x0401D403 RID: 119811
		private bool IsNew;
	}
}

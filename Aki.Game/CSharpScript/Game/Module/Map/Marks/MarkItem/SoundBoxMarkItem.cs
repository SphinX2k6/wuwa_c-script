using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044CB RID: 17611
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundBoxMarkItem : ServerMarkItem
	{
		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x0602C7D8 RID: 182232 RVA: 0x00C7F1B4 File Offset: 0x00C7D3B4
		public override EMarkType MarkType
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				if (serverMarkInfo == null)
				{
					return EMarkType.SoundBox;
				}
				return serverMarkInfo.MarkType;
			}
		}

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x0602C7D9 RID: 182233 RVA: 0x00C7F1C8 File Offset: 0x00C7D3C8
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0602C7DA RID: 182234 RVA: 0x00C7F1D0 File Offset: 0x00C7D3D0
		public SoundBoxMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C7DB RID: 182235 RVA: 0x00C7F1E0 File Offset: 0x00C7D3E0
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C7DC RID: 182236 RVA: 0x00C7F218 File Offset: 0x00C7D418
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SoundBoxMarkItemView;
		}

		// Token: 0x0602C7DD RID: 182237 RVA: 0x00C7F21C File Offset: 0x00C7D41C
		[PreserveBaseOverrides]
		protected new virtual SoundBoxMarkItemView CreateView()
		{
			return new SoundBoxMarkItemView(this);
		}

		// Token: 0x0602C7DE RID: 182238 RVA: 0x00C7F224 File Offset: 0x00C7D424
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C7DF RID: 182239 RVA: 0x00C7F23C File Offset: 0x00C7D43C
		public void OnSetConfigId(int configId)
		{
			SoundBoxMark? soundBoxMarkConfig = MapConfig.Instance.GetSoundBoxMarkConfig(configId);
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = ((soundBoxMarkConfig != null) ? soundBoxMarkConfig.GetValueOrDefault().MarkPic : null),
				Scale = ((soundBoxMarkConfig != null) ? new float?(soundBoxMarkConfig.GetValueOrDefault().Scale) : null),
				ShowPriority = ((soundBoxMarkConfig != null) ? new int?(soundBoxMarkConfig.GetValueOrDefault().ShowPriority) : null),
				ShowRange = ((soundBoxMarkConfig != null) ? soundBoxMarkConfig.GetValueOrDefault().ShowRange() : null)
			});
		}

		// Token: 0x0602C7E0 RID: 182240 RVA: 0x00C7F2FE File Offset: 0x00C7D4FE
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0602C7E1 RID: 182241 RVA: 0x00C7F308 File Offset: 0x00C7D508
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetSoundBoxMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0602C7E2 RID: 182242 RVA: 0x00C7F33C File Offset: 0x00C7D53C
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetSoundBoxMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x0602C7E3 RID: 182243 RVA: 0x00C7F370 File Offset: 0x00C7D570
		public int? GetSoundBoxEntityId()
		{
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			if (serverMarkInfo == null)
			{
				return null;
			}
			return serverMarkInfo.EntityConfigId;
		}

		// Token: 0x0602C7E4 RID: 182244 RVA: 0x00C7F396 File Offset: 0x00C7D596
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x04017E5F RID: 97887
		public int DetectorId;

		// Token: 0x04017E60 RID: 97888
		private bool IsNew;
	}
}

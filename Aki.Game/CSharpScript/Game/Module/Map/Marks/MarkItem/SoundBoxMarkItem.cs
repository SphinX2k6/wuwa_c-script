using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054F8 RID: 21752
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundBoxMarkItem : ServerMarkItem
	{
		// Token: 0x1700857F RID: 34175
		// (get) Token: 0x0603790A RID: 227594 RVA: 0x00D31290 File Offset: 0x00D2F490
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

		// Token: 0x17008580 RID: 34176
		// (get) Token: 0x0603790B RID: 227595 RVA: 0x00D312A4 File Offset: 0x00D2F4A4
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0603790C RID: 227596 RVA: 0x00D312AC File Offset: 0x00D2F4AC
		public SoundBoxMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0603790D RID: 227597 RVA: 0x00D312BC File Offset: 0x00D2F4BC
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0603790E RID: 227598 RVA: 0x00D312F4 File Offset: 0x00D2F4F4
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SoundBoxMarkItemView;
		}

		// Token: 0x0603790F RID: 227599 RVA: 0x00D312F8 File Offset: 0x00D2F4F8
		[PreserveBaseOverrides]
		protected new virtual SoundBoxMarkItemView CreateView()
		{
			return new SoundBoxMarkItemView(this);
		}

		// Token: 0x06037910 RID: 227600 RVA: 0x00D31300 File Offset: 0x00D2F500
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x06037911 RID: 227601 RVA: 0x00D31318 File Offset: 0x00D2F518
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

		// Token: 0x06037912 RID: 227602 RVA: 0x00D313DA File Offset: 0x00D2F5DA
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x06037913 RID: 227603 RVA: 0x00D313E4 File Offset: 0x00D2F5E4
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetSoundBoxMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x06037914 RID: 227604 RVA: 0x00D31418 File Offset: 0x00D2F618
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetSoundBoxMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x06037915 RID: 227605 RVA: 0x00D3144C File Offset: 0x00D2F64C
		public int? GetSoundBoxEntityId()
		{
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			if (serverMarkInfo == null)
			{
				return null;
			}
			return serverMarkInfo.EntityConfigId;
		}

		// Token: 0x06037916 RID: 227606 RVA: 0x00D31472 File Offset: 0x00D2F672
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0401D3D8 RID: 119768
		public int DetectorId;

		// Token: 0x0401D3D9 RID: 119769
		private bool IsNew;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D97 RID: 19863
	[NullableContext(1)]
	[Nullable(0)]
	public class ScanTrackedMarksView : BattleChildView
	{
		// Token: 0x06031E55 RID: 204373 RVA: 0x00DF4929 File Offset: 0x00DF2B29
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.BindEvents();
		}

		// Token: 0x06031E56 RID: 204374 RVA: 0x00DF4938 File Offset: 0x00DF2B38
		public override void Reset()
		{
			base.Reset();
			this.UnbindEvents();
			this.TrackedMarks.Clear();
		}

		// Token: 0x06031E57 RID: 204375 RVA: 0x00DF4954 File Offset: 0x00DF2B54
		public void Update()
		{
			foreach (ScanTrackedMarks scanTrackedMarks in this.TrackedMarks.Values)
			{
				scanTrackedMarks.Update();
			}
		}

		// Token: 0x06031E58 RID: 204376 RVA: 0x00DF49AC File Offset: 0x00DF2BAC
		[NullableContext(2)]
		private void ScanTrackedStart(int entityId, IScanCompositeResult scanComposite)
		{
			ScanTrackedMarksView.<>c__DisplayClass5_0 CS$<>8__locals1 = new ScanTrackedMarksView.<>c__DisplayClass5_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.entityId = entityId;
			if (scanComposite == null || scanComposite.ScanInfos.Count <= 0)
			{
				return;
			}
			CS$<>8__locals1.entity = EntitySystem.Instance.Get(CS$<>8__locals1.entityId);
			if (CS$<>8__locals1.entity == null)
			{
				return;
			}
			this.TrackedMarksLoaded.Add(CS$<>8__locals1.entityId);
			ScanTrackedMarksView.<>c__DisplayClass5_0 CS$<>8__locals2 = CS$<>8__locals1;
			BaseActorComponent component = CS$<>8__locals1.entity.GetComponent<BaseActorComponent>();
			CS$<>8__locals2.actor = ((component != null) ? component.Owner : null);
			CS$<>8__locals1.showDistance = scanComposite.ScanCompositeConfig.ShowDistance;
			CS$<>8__locals1.needClampToEllipse = scanComposite.ScanCompositeConfig.ClampToEllipse;
			using (List<GamePlayScan>.Enumerator enumerator = scanComposite.ScanInfos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GamePlayScan scanInfoConfig = enumerator.Current;
					int level = scanInfoConfig.Color;
					if (scanInfoConfig.IconPath.Length != 0)
					{
						ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(scanInfoConfig.IconPath, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
						{
							if (sprite == null || !sprite.IsValid())
							{
								return;
							}
							if (CS$<>8__locals1.actor == null)
							{
								return;
							}
							if (!CS$<>8__locals1.<>4__this.TrackedMarksLoaded.Contains(CS$<>8__locals1.entityId))
							{
								return;
							}
							global::Vector vector = global::Vector.Create(scanInfoConfig.Offset);
							BaseActorComponent component2 = CS$<>8__locals1.entity.GetComponent<BaseActorComponent>();
							GravityUtils.Instance.RotatedVectorByActorInitGravity(component2, vector);
							CS$<>8__locals1.<>4__this.InnerAddTrackMark(CS$<>8__locals1.entityId, sprite, 0f, string.Empty, null, CS$<>8__locals1.actor, global::Vector.Create(vector), new int?(level), new bool?(CS$<>8__locals1.showDistance), new bool?(CS$<>8__locals1.needClampToEllipse));
						}, 100, "js_undefined");
						break;
					}
				}
			}
		}

		// Token: 0x06031E59 RID: 204377 RVA: 0x00DF4AF4 File Offset: 0x00DF2CF4
		private void ScanTrackedEnd(int entityId)
		{
			this.TrackedMarksLoaded.Remove(entityId);
			ScanTrackedMarks scanTrackedMarks;
			if (this.TrackedMarks.Remove(entityId, out scanTrackedMarks))
			{
				scanTrackedMarks.ToClose();
			}
		}

		// Token: 0x06031E5A RID: 204378 RVA: 0x00DF4B24 File Offset: 0x00DF2D24
		private void InnerAddTrackMark(int id, ULGUISpriteData_BaseObject markIconSprite, float markHideDis, string effectPath, FVectorDouble? originPosition = null, [Nullable(2)] AActor trackActor = null, [Nullable(2)] global::Vector offset = null, int? level = null, bool? showDistance = null, bool? needClampToEllipse = null)
		{
			if (!this.TrackedMarks.ContainsKey(id))
			{
				ScanTrackedMarks value = new ScanTrackedMarks(this.RootItem, markIconSprite, markHideDis, effectPath, originPosition, trackActor, offset, level, showDistance, needClampToEllipse);
				this.TrackedMarks[id] = value;
			}
		}

		// Token: 0x06031E5B RID: 204379 RVA: 0x00DF4B68 File Offset: 0x00DF2D68
		private void BindEvents()
		{
			EventSystem.Instance.Add<int, IScanCompositeResult>(EEventName.ScanTrackedStart, new Action<int, IScanCompositeResult>(this.ScanTrackedStart));
			EventSystem.Instance.Add<int>(EEventName.ScanTrackedEnd, new Action<int>(this.ScanTrackedEnd));
		}

		// Token: 0x06031E5C RID: 204380 RVA: 0x00DF4BA2 File Offset: 0x00DF2DA2
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.ScanTrackedStart, new Action<int, IScanCompositeResult>(this.ScanTrackedStart));
			EventSystem.Instance.Remove(EEventName.ScanTrackedEnd, new Action<int>(this.ScanTrackedEnd));
		}

		// Token: 0x06031E5D RID: 204381 RVA: 0x00DF4BDC File Offset: 0x00DF2DDC
		protected override bool DestroyOverride()
		{
			return true;
		}

		// Token: 0x0401A67A RID: 108154
		private readonly Dictionary<int, ScanTrackedMarks> TrackedMarks = new Dictionary<int, ScanTrackedMarks>();

		// Token: 0x0401A67B RID: 108155
		private readonly HashSet<int> TrackedMarksLoaded = new HashSet<int>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Capability.Editor
{
	// Token: 0x02006422 RID: 25634
	[NullableContext(1)]
	[Nullable(0)]
	public class CapabilityTimelineDebugger : IStaticVariableResetter
	{
		// Token: 0x0603E3B9 RID: 254905 RVA: 0x01212830 File Offset: 0x01210A30
		static CapabilityTimelineDebugger()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CapabilityTimelineDebugger.CreateStaticDefaultValue), new Action(CapabilityTimelineDebugger.ResetStaticDefaultValue));
		}

		// Token: 0x0603E3BA RID: 254906 RVA: 0x012128DC File Offset: 0x01210ADC
		public CapabilityTimelineDebugger(CapabilityDebugger Debugger)
		{
			this.Debugger = Debugger;
		}

		// Token: 0x0603E3BB RID: 254907 RVA: 0x01212990 File Offset: 0x01210B90
		private static void ApplyFontConfig(UTextBlock tb, FontConfig cfg)
		{
			tb.Font.Size = cfg.Size;
			if (cfg.Typeface.Length > 0)
			{
				tb.Font.TypefaceFontName = FNameUtil.GetDynamicFName(cfg.Typeface).Value;
			}
			tb.Font.LetterSpacing = cfg.LetterSpacing;
			tb.SetColorAndOpacity(new FSlateColor
			{
				SpecifiedColor = cfg.Color,
				ColorUseRule = ESlateColorStylingMode.UseColor_Specified
			});
		}

		// Token: 0x0603E3BC RID: 254908 RVA: 0x01212A10 File Offset: 0x01210C10
		public void Show()
		{
			if (this.RootWidget != null)
			{
				return;
			}
			this.RootWidget = this.BuildWidget();
			if (this.RootWidget == null)
			{
				return;
			}
			APlayerController playerController = UGameplayStatics.GetPlayerController(GlobalData.World, 0);
			if (playerController != null)
			{
				this.RootWidget.SetOwningPlayer(playerController);
			}
			this.RootWidget.AddToViewport(1000);
			this.TickHandle = TimerSystem.Instance.Forever(delegate(float _)
			{
				this.Redraw();
			}, 100f, 1f, null, "CapabilityTimelineDebugger.Redraw", true);
		}

		// Token: 0x0603E3BD RID: 254909 RVA: 0x01212A94 File Offset: 0x01210C94
		public void Hide()
		{
			if (this.TickHandle != null)
			{
				this.TickHandle.Remove();
				this.TickHandle = null;
			}
			if (this.RootWidget != null)
			{
				this.RootWidget.RemoveFromParent();
				this.RootWidget = null;
				this.WidgetTree = null;
				this.Canvas = null;
				this.CursorSlot = null;
				this.NowLabel = null;
				this.NowLabelText = "";
				this.CursorTimeLabel = null;
				this.CursorTimeLabelSlot = null;
				this.CursorTimeLabelText = "";
			}
			this.Rows.Clear();
			this.SpanBuckets.Clear();
			this.EventBuckets.Clear();
			this.IdToRowIndex.Clear();
			this.RowIds.Clear();
			this.Ticks.Clear();
			this.TickSlots.Clear();
			this.TickLabels.Clear();
			this.TickLabelSlots.Clear();
			this.TickLabelTexts.Clear();
			this.UsedTicks = 0;
			this.UsedTickLabels = 0;
		}

		// Token: 0x0603E3BE RID: 254910 RVA: 0x01212B92 File Offset: 0x01210D92
		public bool IsVisible()
		{
			return this.RootWidget != null;
		}

		// Token: 0x0603E3BF RID: 254911 RVA: 0x01212B9D File Offset: 0x01210D9D
		public void SetZoom(float zoom)
		{
			if ((double)zoom > 0.05 && zoom < 50f)
			{
				this.Zoom = zoom;
			}
		}

		// Token: 0x0603E3C0 RID: 254912 RVA: 0x01212BBB File Offset: 0x01210DBB
		public void SetWindowSeconds(float s)
		{
			if (s >= 1f && s <= 600f)
			{
				this.WindowSeconds = s;
			}
		}

		// Token: 0x0603E3C1 RID: 254913 RVA: 0x01212BD4 File Offset: 0x01210DD4
		[NullableContext(2)]
		private UUserWidget BuildWidget()
		{
			return null;
		}

		// Token: 0x0603E3C2 RID: 254914 RVA: 0x01212BD8 File Offset: 0x01210DD8
		private void BuildLegend(UCanvasPanel canvas)
		{
			UWidgetTree widgetTree = this.WidgetTree;
			int num = 28;
			for (int i = 0; i < CapabilityTimelineDebugger.legendEntries.Count; i++)
			{
				ValueTuple<FLinearColor, string> valueTuple = CapabilityTimelineDebugger.legendEntries[i];
				FLinearColor item = valueTuple.Item1;
				string item2 = valueTuple.Item2;
				int num2 = 8 + i * 110;
				UImage uimage = new UImage(widgetTree, null, EObjectFlags.RF_NoFlags);
				uimage.SetColorAndOpacity(item);
				UCanvasPanelSlot ucanvasPanelSlot = canvas.AddChildToCanvas(uimage);
				if (ucanvasPanelSlot != null)
				{
					ucanvasPanelSlot.SetPosition(new FVector2D((float)num2, (float)(num + 4)));
					ucanvasPanelSlot.SetSize(new FVector2D(12f, 10f));
				}
				UTextBlock utextBlock = new UTextBlock(widgetTree, null, EObjectFlags.RF_NoFlags);
				utextBlock.SetText(item2);
				CapabilityTimelineDebugger.ApplyFontConfig(utextBlock, CapabilityTimelineDebugger.legendFontConfig);
				UCanvasPanelSlot ucanvasPanelSlot2 = canvas.AddChildToCanvas(utextBlock);
				if (ucanvasPanelSlot2 != null)
				{
					ucanvasPanelSlot2.SetPosition(new FVector2D((float)(num2 + 12 + 4), (float)num));
					ucanvasPanelSlot2.SetSize(new FVector2D(92f, 18f));
				}
			}
		}

		// Token: 0x0603E3C3 RID: 254915 RVA: 0x01212CD4 File Offset: 0x01210ED4
		private void Redraw()
		{
			if (this.Canvas == null)
			{
				return;
			}
			try
			{
				CapabilityDebugger debugger = this.Debugger;
				double nowSeconds = Time.Instance.NowSeconds;
				double num = Math.Max(0.0, nowSeconds - (double)this.WindowSeconds);
				double endTime = nowSeconds;
				float num2 = 80f * this.Zoom;
				List<string> list = debugger.CollectAllCapabilityIds();
				int num3 = Math.Min(list.Count, 64);
				this.BucketizeByRow(list, num3, num, endTime, debugger);
				for (int i = 0; i < num3; i++)
				{
					string text = list[i];
					int y = 62 + i * 22;
					try
					{
						RowPool pool = this.EnsureRow(i);
						this.UpdateLabel(pool, text, 8, y);
						this.LayoutRow(pool, this.SpanBuckets[i], this.EventBuckets[i], num, num2, y, nowSeconds);
					}
					finally
					{
					}
				}
				for (int j = num3; j < this.Rows.Count; j++)
				{
					this.HideRow(this.Rows[j]);
				}
				this.UpdateNowLabel(nowSeconds);
				this.LayoutTimeAxis(num, endTime, num2);
				if (this.CursorSlot != null)
				{
					double num4 = 240.0 + (nowSeconds - num) * (double)num2;
					int num5 = Math.Max(36, 14 + num3 * 22);
					this.CursorSlot.SetPosition(new FVector2D((float)num4, 48f));
					this.CursorSlot.SetSize(new FVector2D(1f, (float)num5));
					if (this.CursorTimeLabelSlot != null && this.CursorTimeLabel != null)
					{
						this.CursorTimeLabelSlot.SetPosition(new FVector2D((float)(num4 + 2.0), 48f));
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
						defaultInterpolatedStringHandler.AppendFormatted<double>(nowSeconds, "F2");
						defaultInterpolatedStringHandler.AppendLiteral("s");
						string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (this.CursorTimeLabelText != text2)
						{
							this.CursorTimeLabel.SetText(text2);
							this.CursorTimeLabelText = text2;
						}
					}
				}
			}
			finally
			{
			}
		}

		// Token: 0x0603E3C4 RID: 254916 RVA: 0x01212F10 File Offset: 0x01211110
		private void UpdateNowLabel(double now)
		{
			if (this.NowLabel == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Now: ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(now, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("s   Window: ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.WindowSeconds);
			defaultInterpolatedStringHandler.AppendLiteral("s   Zoom: x");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Zoom, "F2");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.NowLabelText != text)
			{
				this.NowLabel.SetText(text);
				this.NowLabelText = text;
			}
		}

		// Token: 0x0603E3C5 RID: 254917 RVA: 0x01212FB0 File Offset: 0x012111B0
		private void LayoutTimeAxis(double startTime, double endTime, float pps)
		{
			UCanvasPanel canvas = this.Canvas;
			UWidgetTree widgetTree = this.WidgetTree;
			try
			{
				int num = 48;
				double num2 = Math.Ceiling(startTime / 1.0) * 1.0;
				int num3 = 0;
				int num4 = 0;
				double num5 = num2;
				while (num5 <= endTime + 0.001 && num3 < 256)
				{
					double num6 = 240.0 + (num5 - startTime) * (double)pps;
					bool flag = Math.Abs(num5 / 5.0 - Math.Round(num5 / 5.0)) < 0.001;
					int num7 = flag ? 14 : ((int)Math.Floor(7.0));
					UImage uimage = this.Ticks[num3];
					UCanvasPanelSlot ucanvasPanelSlot = this.TickSlots[num3];
					if (uimage == null)
					{
						uimage = new UImage(widgetTree, null, EObjectFlags.RF_NoFlags);
						uimage.SetColorAndOpacity(CapabilityTimelineDebugger.tickColor);
						ucanvasPanelSlot = canvas.AddChildToCanvas(uimage);
						this.Ticks[num3] = uimage;
						this.TickSlots[num3] = ucanvasPanelSlot;
					}
					if (ucanvasPanelSlot != null)
					{
						ucanvasPanelSlot.SetPosition(new FVector2D((float)num6, (float)(num + (14 - num7))));
						ucanvasPanelSlot.SetSize(new FVector2D(1f, (float)num7));
					}
					uimage.SetVisibility(ESlateVisibility.HitTestInvisible);
					num3++;
					if (flag)
					{
						UTextBlock utextBlock = this.TickLabels[num4];
						UCanvasPanelSlot ucanvasPanelSlot2 = this.TickLabelSlots[num4];
						if (utextBlock == null)
						{
							utextBlock = new UTextBlock(widgetTree, null, EObjectFlags.RF_NoFlags);
							CapabilityTimelineDebugger.ApplyFontConfig(utextBlock, CapabilityTimelineDebugger.tickLabelFontConfig);
							ucanvasPanelSlot2 = canvas.AddChildToCanvas(utextBlock);
							this.TickLabels[num4] = utextBlock;
							this.TickLabelSlots[num4] = ucanvasPanelSlot2;
							this.TickLabelTexts[num4] = "";
						}
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
						defaultInterpolatedStringHandler.AppendFormatted<double>(num5, "F0");
						defaultInterpolatedStringHandler.AppendLiteral("s");
						string text = defaultInterpolatedStringHandler.ToStringAndClear();
						if (this.TickLabelTexts[num4] != text)
						{
							utextBlock.SetText(text);
							this.TickLabelTexts[num4] = text;
						}
						if (ucanvasPanelSlot2 != null)
						{
							ucanvasPanelSlot2.SetPosition(new FVector2D((float)(num6 + 2.0), (float)num));
							ucanvasPanelSlot2.SetSize(new FVector2D(40f, 14f));
						}
						utextBlock.SetVisibility(ESlateVisibility.HitTestInvisible);
						num4++;
					}
					num5 += 1.0;
				}
				for (int i = num3; i < this.UsedTicks; i++)
				{
					this.Ticks[i].SetVisibility(ESlateVisibility.Collapsed);
				}
				this.UsedTicks = num3;
				for (int j = num4; j < this.UsedTickLabels; j++)
				{
					this.TickLabels[j].SetVisibility(ESlateVisibility.Collapsed);
				}
				this.UsedTickLabels = num4;
			}
			finally
			{
			}
		}

		// Token: 0x0603E3C6 RID: 254918 RVA: 0x012132A8 File Offset: 0x012114A8
		private void BucketizeByRow(List<string> ids, int rowCount, double startTime, double endTime, CapabilityDebugger capabilityDebugger)
		{
			try
			{
				this.IdToRowIndex.Clear();
				this.RowIds.Clear();
				for (int i = 0; i < rowCount; i++)
				{
					this.IdToRowIndex[ids[i]] = i;
					this.RowIds.Add(ids[i]);
				}
				for (int j = 0; j < rowCount; j++)
				{
					if (this.SpanBuckets[j] == null)
					{
						this.SpanBuckets[j] = new List<ICapabilityDebugActiveSpan>();
					}
					else
					{
						this.SpanBuckets[j].Clear();
					}
					if (this.EventBuckets[j] == null)
					{
						this.EventBuckets[j] = new List<ICapabilityDebugRecord>();
					}
					else
					{
						this.EventBuckets[j].Clear();
					}
				}
				foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan in capabilityDebugger.GetClosedSpans())
				{
					int index;
					if (capabilityDebugActiveSpan.EndTime >= startTime && capabilityDebugActiveSpan.StartTime <= endTime && this.IdToRowIndex.TryGetValue(capabilityDebugActiveSpan.CapabilityId, out index))
					{
						List<ICapabilityDebugActiveSpan> list = this.SpanBuckets[index];
						if (list.Count < 64)
						{
							list.Add(capabilityDebugActiveSpan);
						}
					}
				}
				foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan2 in capabilityDebugger.GetOpenSpans())
				{
					int index2;
					if (capabilityDebugActiveSpan2.StartTime <= endTime && this.IdToRowIndex.TryGetValue(capabilityDebugActiveSpan2.CapabilityId, out index2))
					{
						List<ICapabilityDebugActiveSpan> list2 = this.SpanBuckets[index2];
						if (list2.Count < 64)
						{
							list2.Add(capabilityDebugActiveSpan2);
						}
					}
				}
				foreach (ICapabilityDebugRecord capabilityDebugRecord in capabilityDebugger.GetRecords())
				{
					int index3;
					if (capabilityDebugRecord.Time >= startTime && capabilityDebugRecord.Time <= endTime && CapabilityTimelineDebugger.IsImportantEvent(capabilityDebugRecord.Event) && this.IdToRowIndex.TryGetValue(capabilityDebugRecord.CapabilityId, out index3))
					{
						List<ICapabilityDebugRecord> list3 = this.EventBuckets[index3];
						if (list3.Count < 64)
						{
							list3.Add(capabilityDebugRecord);
						}
					}
				}
			}
			finally
			{
			}
		}

		// Token: 0x0603E3C7 RID: 254919 RVA: 0x01213540 File Offset: 0x01211740
		private static bool IsImportantEvent(CapabilityCommonDefine.ECapabilityDebugEvent e)
		{
			return e == CapabilityCommonDefine.ECapabilityDebugEvent.OnActivated || e == CapabilityCommonDefine.ECapabilityDebugEvent.OnDeactivated || e == CapabilityCommonDefine.ECapabilityDebugEvent.Interrupted || e == CapabilityCommonDefine.ECapabilityDebugEvent.Blocked || e == CapabilityCommonDefine.ECapabilityDebugEvent.Unblocked;
		}

		// Token: 0x0603E3C8 RID: 254920 RVA: 0x0121355C File Offset: 0x0121175C
		private RowPool EnsureRow(int rowIndex)
		{
			RowPool rowPool = this.Rows[rowIndex];
			if (rowPool != null)
			{
				return rowPool;
			}
			RowPool result;
			try
			{
				UCanvasPanel canvas = this.Canvas;
				UTextBlock utextBlock = new UTextBlock(this.WidgetTree, null, EObjectFlags.RF_NoFlags);
				CapabilityTimelineDebugger.ApplyFontConfig(utextBlock, CapabilityTimelineDebugger.labelFontConfig);
				UCanvasPanelSlot labelSlot = canvas.AddChildToCanvas(utextBlock);
				rowPool = new RowPool
				{
					Label = utextBlock,
					LabelSlot = labelSlot,
					LabelText = "",
					Spans = new List<UImage>(),
					SpanSlots = new List<UCanvasPanelSlot>(),
					Events = new List<UImage>(),
					EventSlots = new List<UCanvasPanelSlot>(),
					UsedSpans = 0,
					UsedEvents = 0
				};
				this.Rows[rowIndex] = rowPool;
				result = rowPool;
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x0603E3C9 RID: 254921 RVA: 0x01213620 File Offset: 0x01211820
		private void UpdateLabel(RowPool pool, string text, int x, int y)
		{
			if (pool.LabelText != text)
			{
				pool.Label.SetText(text);
				pool.LabelText = text;
			}
			UCanvasPanelSlot labelSlot = pool.LabelSlot;
			if (labelSlot != null)
			{
				labelSlot.SetPosition(new FVector2D((float)x, (float)(y + 4)));
				labelSlot.SetSize(new FVector2D(236f, 18f));
			}
			pool.Label.SetVisibility(ESlateVisibility.HitTestInvisible);
		}

		// Token: 0x0603E3CA RID: 254922 RVA: 0x01213690 File Offset: 0x01211890
		private void LayoutRow(RowPool pool, List<ICapabilityDebugActiveSpan> spans, List<ICapabilityDebugRecord> events, double startTime, float pps, int y, double now)
		{
			UCanvasPanel canvas = this.Canvas;
			UWidgetTree widgetTree = this.WidgetTree;
			int count = spans.Count;
			for (int i = 0; i < count; i++)
			{
				ICapabilityDebugActiveSpan capabilityDebugActiveSpan = spans[i];
				double num = 240.0 + Math.Max(0.0, capabilityDebugActiveSpan.StartTime - startTime) * (double)pps;
				double num2 = (capabilityDebugActiveSpan.EndTime < 0.0) ? now : capabilityDebugActiveSpan.EndTime;
				double num3 = 240.0 + (num2 - startTime) * (double)pps;
				double num4 = Math.Max(1.0, num3 - num);
				UImage uimage = pool.Spans[i];
				UCanvasPanelSlot ucanvasPanelSlot = pool.SpanSlots[i];
				if (uimage == null)
				{
					uimage = new UImage(widgetTree, null, EObjectFlags.RF_NoFlags);
					uimage.SetColorAndOpacity(CapabilityTimelineDebugger.spanColor);
					ucanvasPanelSlot = canvas.AddChildToCanvas(uimage);
					pool.Spans[i] = uimage;
					pool.SpanSlots[i] = ucanvasPanelSlot;
				}
				if (ucanvasPanelSlot != null)
				{
					ucanvasPanelSlot.SetPosition(new FVector2D((float)num, (float)(y + 2)));
					ucanvasPanelSlot.SetSize(new FVector2D((float)num4, 18f));
				}
				uimage.SetVisibility(ESlateVisibility.HitTestInvisible);
			}
			for (int j = count; j < pool.UsedSpans; j++)
			{
				pool.Spans[j].SetVisibility(ESlateVisibility.Collapsed);
			}
			pool.UsedSpans = count;
			int count2 = events.Count;
			for (int k = 0; k < count2; k++)
			{
				ICapabilityDebugRecord capabilityDebugRecord = events[k];
				double num5 = 240.0 + Math.Max(0.0, capabilityDebugRecord.Time - startTime) * (double)pps;
				FLinearColor colorAndOpacity = CapabilityTimelineDebugger.eventColor[capabilityDebugRecord.Event];
				UImage uimage2 = pool.Events[k];
				UCanvasPanelSlot ucanvasPanelSlot2 = pool.EventSlots[k];
				if (uimage2 == null)
				{
					uimage2 = new UImage(widgetTree, null, EObjectFlags.RF_NoFlags);
					ucanvasPanelSlot2 = canvas.AddChildToCanvas(uimage2);
					pool.Events[k] = uimage2;
					pool.EventSlots[k] = ucanvasPanelSlot2;
				}
				uimage2.SetColorAndOpacity(colorAndOpacity);
				if (ucanvasPanelSlot2 != null)
				{
					ucanvasPanelSlot2.SetPosition(new FVector2D((float)num5 - 2f, (float)y));
					ucanvasPanelSlot2.SetSize(new FVector2D(4f, 22f));
				}
				uimage2.SetVisibility(ESlateVisibility.HitTestInvisible);
			}
			for (int l = count2; l < pool.UsedEvents; l++)
			{
				pool.Events[l].SetVisibility(ESlateVisibility.Collapsed);
			}
			pool.UsedEvents = count2;
		}

		// Token: 0x0603E3CB RID: 254923 RVA: 0x01213930 File Offset: 0x01211B30
		private void HideRow(RowPool pool)
		{
			pool.Label.SetVisibility(ESlateVisibility.Collapsed);
			for (int i = 0; i < pool.UsedSpans; i++)
			{
				pool.Spans[i].SetVisibility(ESlateVisibility.Collapsed);
			}
			for (int j = 0; j < pool.UsedEvents; j++)
			{
				pool.Events[j].SetVisibility(ESlateVisibility.Collapsed);
			}
			pool.UsedSpans = 0;
			pool.UsedEvents = 0;
		}

		// Token: 0x0603E3CC RID: 254924 RVA: 0x012139A0 File Offset: 0x01211BA0
		public string DumpToString()
		{
			CapabilityDebugger debugger = this.Debugger;
			List<string> list = new List<string>();
			list.Add("=== Capability Timeline Snapshot ===");
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("World time: ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Time.Instance.NowSeconds, "F3");
			defaultInterpolatedStringHandler.AppendLiteral("s");
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			list.Add("");
			using (List<string>.Enumerator enumerator = debugger.CollectAllCapabilityIds().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string id = enumerator.Current;
					List<ICapabilityDebugActiveSpan> list3 = new List<ICapabilityDebugActiveSpan>(debugger.GetClosedSpans()).FindAll((ICapabilityDebugActiveSpan s) => s.CapabilityId == id);
					List<ICapabilityDebugActiveSpan> list4 = new List<ICapabilityDebugActiveSpan>(debugger.GetOpenSpans()).FindAll((ICapabilityDebugActiveSpan s) => s.CapabilityId == id);
					List<string> list5 = new List<string>();
					foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan in list3)
					{
						List<string> list6 = list5;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
						defaultInterpolatedStringHandler.AppendLiteral("[");
						defaultInterpolatedStringHandler.AppendFormatted<double>(capabilityDebugActiveSpan.StartTime, "F2");
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted<double>(capabilityDebugActiveSpan.EndTime, "F2");
						defaultInterpolatedStringHandler.AppendLiteral("]");
						list6.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan2 in list4)
					{
						List<string> list7 = list5;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral("[");
						defaultInterpolatedStringHandler.AppendFormatted<double>(capabilityDebugActiveSpan2.StartTime, "F2");
						defaultInterpolatedStringHandler.AppendLiteral("-...]");
						list7.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					list.Add(id + "\n  active: " + string.Join(" ", list5));
				}
			}
			list.Add("");
			list.Add("--- Recent Events ---");
			IReadOnlyList<ICapabilityDebugRecord> records = debugger.GetRecords();
			for (int i = Math.Max(0, records.Count - 30); i < records.Count; i++)
			{
				ICapabilityDebugRecord capabilityDebugRecord = records[i];
				List<string> list8 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 3);
				defaultInterpolatedStringHandler.AppendLiteral("  ");
				defaultInterpolatedStringHandler.AppendFormatted<double>(capabilityDebugRecord.Time, "F3");
				defaultInterpolatedStringHandler.AppendLiteral("s  ");
				defaultInterpolatedStringHandler.AppendFormatted<CapabilityCommonDefine.ECapabilityDebugEvent>(capabilityDebugRecord.Event);
				defaultInterpolatedStringHandler.AppendLiteral("  ");
				defaultInterpolatedStringHandler.AppendFormatted(capabilityDebugRecord.CapabilityId);
				string str = defaultInterpolatedStringHandler.ToStringAndClear();
				string str2 = (capabilityDebugRecord.Detail != null) ? (" (" + capabilityDebugRecord.Detail + ")") : "";
				string str3;
				if (capabilityDebugRecord.DurationMs == null)
				{
					str3 = "";
				}
				else
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted<double>(capabilityDebugRecord.DurationMs.Value, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("ms");
					str3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				list8.Add(str + str2 + str3);
			}
			return string.Join("\n", list);
		}

		// Token: 0x0603E3CD RID: 254925 RVA: 0x01213D54 File Offset: 0x01211F54
		public unsafe static void CreateStaticDefaultValue()
		{
			Dictionary<CapabilityCommonDefine.ECapabilityDebugEvent, FLinearColor> dictionary = new Dictionary<CapabilityCommonDefine.ECapabilityDebugEvent, FLinearColor>();
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.Setup] = new FLinearColor(0.6f, 0.6f, 0.6f, 1f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.PreTick] = new FLinearColor(0.4f, 0.4f, 0.4f, 0.5f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.ShouldActivate] = new FLinearColor(0.5f, 0.7f, 0.9f, 0.8f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.ShouldDeactivate] = new FLinearColor(0.9f, 0.6f, 0.4f, 0.8f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.OnActivated] = new FLinearColor(0.2f, 0.9f, 0.2f, 1f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.OnDeactivated] = new FLinearColor(0.9f, 0.2f, 0.2f, 1f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.TickActive] = new FLinearColor(0.3f, 0.6f, 1f, 0.6f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.Blocked] = new FLinearColor(0.7f, 0.7f, 0f, 1f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.Unblocked] = new FLinearColor(0.5f, 0.7f, 0f, 1f);
			dictionary[CapabilityCommonDefine.ECapabilityDebugEvent.Interrupted] = new FLinearColor(1f, 0f, 0.6f, 1f);
			CapabilityTimelineDebugger.eventColor = dictionary;
			int num = 7;
			List<ValueTuple<FLinearColor, string>> list = new List<ValueTuple<FLinearColor, string>>(num);
			CollectionsMarshal.SetCount<ValueTuple<FLinearColor, string>>(list, num);
			Span<ValueTuple<FLinearColor, string>> span = CollectionsMarshal.AsSpan<ValueTuple<FLinearColor, string>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.spanColor, "Active Span");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.eventColor[CapabilityCommonDefine.ECapabilityDebugEvent.OnActivated], "OnActivated");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.eventColor[CapabilityCommonDefine.ECapabilityDebugEvent.OnDeactivated], "OnDeactivated");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.eventColor[CapabilityCommonDefine.ECapabilityDebugEvent.Blocked], "Blocked");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.eventColor[CapabilityCommonDefine.ECapabilityDebugEvent.Unblocked], "Unblocked");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.eventColor[CapabilityCommonDefine.ECapabilityDebugEvent.Interrupted], "Interrupted");
			num2++;
			*span[num2] = new ValueTuple<FLinearColor, string>(CapabilityTimelineDebugger.cursorColor, "Now");
			CapabilityTimelineDebugger.legendEntries = list;
			CapabilityTimelineDebugger.headerFontConfig = new FontConfig
			{
				Size = 12,
				Typeface = "Bold",
				LetterSpacing = 0,
				Color = CapabilityTimelineDebugger.textColor
			};
			CapabilityTimelineDebugger.labelFontConfig = new FontConfig
			{
				Size = 9,
				Typeface = "Light",
				LetterSpacing = -20,
				Color = CapabilityTimelineDebugger.textColor
			};
			CapabilityTimelineDebugger.legendFontConfig = new FontConfig
			{
				Size = 9,
				Typeface = "Regular",
				LetterSpacing = 0,
				Color = CapabilityTimelineDebugger.textColor
			};
			CapabilityTimelineDebugger.tickLabelFontConfig = new FontConfig
			{
				Size = 9,
				Typeface = "Light",
				LetterSpacing = 0,
				Color = CapabilityTimelineDebugger.tickLabelColor
			};
			CapabilityTimelineDebugger.statRedraw = Stat.Create("CapabilityTimelineDebugger.Redraw", "", "");
			CapabilityTimelineDebugger.statBucketize = Stat.Create("CapabilityTimelineDebugger.Bucketize", "", "");
			CapabilityTimelineDebugger.statLayoutRow = Stat.Create("CapabilityTimelineDebugger.LayoutRow", "", "");
			CapabilityTimelineDebugger.statEnsureRow = Stat.Create("CapabilityTimelineDebugger.EnsureRow", "", "");
			CapabilityTimelineDebugger.statTimeAxis = Stat.Create("CapabilityTimelineDebugger.TimeAxis", "", "");
		}

		// Token: 0x0603E3CE RID: 254926 RVA: 0x01214100 File Offset: 0x01212300
		public static void ResetStaticDefaultValue()
		{
			CapabilityTimelineDebugger.legendEntries = null;
			CapabilityTimelineDebugger.eventColor = null;
			CapabilityTimelineDebugger.headerFontConfig = null;
			CapabilityTimelineDebugger.labelFontConfig = null;
			CapabilityTimelineDebugger.legendFontConfig = null;
			CapabilityTimelineDebugger.tickLabelFontConfig = null;
			CapabilityTimelineDebugger.statRedraw = null;
			CapabilityTimelineDebugger.statBucketize = null;
			CapabilityTimelineDebugger.statLayoutRow = null;
			CapabilityTimelineDebugger.statEnsureRow = null;
			CapabilityTimelineDebugger.statTimeAxis = null;
		}

		// Token: 0x040211DE RID: 135646
		private static Dictionary<CapabilityCommonDefine.ECapabilityDebugEvent, FLinearColor> eventColor;

		// Token: 0x040211DF RID: 135647
		private static readonly FLinearColor spanColor = new FLinearColor(0.3f, 0.6f, 1f, 0.8f);

		// Token: 0x040211E0 RID: 135648
		private static readonly FLinearColor cursorColor = ColorUtils.LinearWhiteOpaque;

		// Token: 0x040211E1 RID: 135649
		private static readonly FLinearColor textColor = new FLinearColor(0.85f, 0.85f, 0.85f, 0.85f);

		// Token: 0x040211E2 RID: 135650
		private static readonly FLinearColor tickColor = new FLinearColor(1f, 1f, 1f, 0.15f);

		// Token: 0x040211E3 RID: 135651
		private static readonly FLinearColor tickLabelColor = new FLinearColor(0.7f, 0.7f, 0.7f, 0.6f);

		// Token: 0x040211E4 RID: 135652
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private static List<ValueTuple<FLinearColor, string>> legendEntries;

		// Token: 0x040211E5 RID: 135653
		private const int ROW_HEIGHT = 22;

		// Token: 0x040211E6 RID: 135654
		private const int LABEL_COL_WIDTH = 240;

		// Token: 0x040211E7 RID: 135655
		private const int PIXELS_PER_SECOND_BASE = 80;

		// Token: 0x040211E8 RID: 135656
		private const int REDRAW_INTERVAL_MS = 100;

		// Token: 0x040211E9 RID: 135657
		private const int MAX_SPANS_PER_ROW = 64;

		// Token: 0x040211EA RID: 135658
		private const int MAX_EVENTS_PER_ROW = 64;

		// Token: 0x040211EB RID: 135659
		private const int MAX_ROWS = 64;

		// Token: 0x040211EC RID: 135660
		private static FontConfig headerFontConfig;

		// Token: 0x040211ED RID: 135661
		private static FontConfig labelFontConfig;

		// Token: 0x040211EE RID: 135662
		private static FontConfig legendFontConfig;

		// Token: 0x040211EF RID: 135663
		private static FontConfig tickLabelFontConfig;

		// Token: 0x040211F0 RID: 135664
		private const int LEGEND_HEIGHT = 18;

		// Token: 0x040211F1 RID: 135665
		private const int LEGEND_SWATCH_W = 12;

		// Token: 0x040211F2 RID: 135666
		private const int LEGEND_SWATCH_H = 10;

		// Token: 0x040211F3 RID: 135667
		private const int LEGEND_ITEM_WIDTH = 110;

		// Token: 0x040211F4 RID: 135668
		private const int TIME_AXIS_HEIGHT = 14;

		// Token: 0x040211F5 RID: 135669
		private const int ROW_Y_OFFSET = 62;

		// Token: 0x040211F6 RID: 135670
		private const int CURSOR_MIN_HEIGHT = 36;

		// Token: 0x040211F7 RID: 135671
		private const int TICK_MINOR_INTERVAL_SEC = 1;

		// Token: 0x040211F8 RID: 135672
		private const int TICK_MAJOR_INTERVAL_SEC = 5;

		// Token: 0x040211F9 RID: 135673
		private const int MAX_TIME_TICKS = 256;

		// Token: 0x040211FA RID: 135674
		private static Stat statRedraw;

		// Token: 0x040211FB RID: 135675
		private static Stat statBucketize;

		// Token: 0x040211FC RID: 135676
		private static Stat statLayoutRow;

		// Token: 0x040211FD RID: 135677
		private static Stat statEnsureRow;

		// Token: 0x040211FE RID: 135678
		private static Stat statTimeAxis;

		// Token: 0x040211FF RID: 135679
		private float Zoom = 1f;

		// Token: 0x04021200 RID: 135680
		private float WindowSeconds = 30f;

		// Token: 0x04021201 RID: 135681
		[Nullable(2)]
		private UUserWidget RootWidget;

		// Token: 0x04021202 RID: 135682
		[Nullable(2)]
		private UWidgetTree WidgetTree;

		// Token: 0x04021203 RID: 135683
		[Nullable(2)]
		private UCanvasPanel Canvas;

		// Token: 0x04021204 RID: 135684
		[Nullable(2)]
		private UCanvasPanelSlot CursorSlot;

		// Token: 0x04021205 RID: 135685
		[Nullable(2)]
		private UTextBlock NowLabel;

		// Token: 0x04021206 RID: 135686
		private string NowLabelText = "";

		// Token: 0x04021207 RID: 135687
		[Nullable(2)]
		private UTextBlock CursorTimeLabel;

		// Token: 0x04021208 RID: 135688
		[Nullable(2)]
		private UCanvasPanelSlot CursorTimeLabelSlot;

		// Token: 0x04021209 RID: 135689
		private string CursorTimeLabelText = "";

		// Token: 0x0402120A RID: 135690
		private readonly List<UImage> Ticks = new List<UImage>();

		// Token: 0x0402120B RID: 135691
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UCanvasPanelSlot> TickSlots = new List<UCanvasPanelSlot>();

		// Token: 0x0402120C RID: 135692
		private int UsedTicks;

		// Token: 0x0402120D RID: 135693
		private readonly List<UTextBlock> TickLabels = new List<UTextBlock>();

		// Token: 0x0402120E RID: 135694
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UCanvasPanelSlot> TickLabelSlots = new List<UCanvasPanelSlot>();

		// Token: 0x0402120F RID: 135695
		private readonly List<string> TickLabelTexts = new List<string>();

		// Token: 0x04021210 RID: 135696
		private int UsedTickLabels;

		// Token: 0x04021211 RID: 135697
		private readonly List<RowPool> Rows = new List<RowPool>();

		// Token: 0x04021212 RID: 135698
		private readonly List<List<ICapabilityDebugActiveSpan>> SpanBuckets = new List<List<ICapabilityDebugActiveSpan>>();

		// Token: 0x04021213 RID: 135699
		private readonly List<List<ICapabilityDebugRecord>> EventBuckets = new List<List<ICapabilityDebugRecord>>();

		// Token: 0x04021214 RID: 135700
		private readonly Dictionary<string, int> IdToRowIndex = new Dictionary<string, int>();

		// Token: 0x04021215 RID: 135701
		private readonly List<string> RowIds = new List<string>();

		// Token: 0x04021216 RID: 135702
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x04021217 RID: 135703
		public CapabilityDebugger Debugger;
	}
}

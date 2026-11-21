using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x0200428F RID: 17039
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardTweenLogic
	{
		// Token: 0x0602B1F1 RID: 176625 RVA: 0x00C1F354 File Offset: 0x00C1D554
		private void CreateTween()
		{
			this.LocationXTween = new LguiFloatTween();
			this.LocationXTween.BindUpdateTween(delegate(float value)
			{
				this.CardWorldPos.X = (double)value;
				UUIItem cardItem = this.CardItem;
				FVector fvector = this.CardWorldPos.ToUeVectorOld();
				cardItem.SetUIWorldLocation(fvector);
			});
			this.LocationXTween.BindCompleteTween(delegate
			{
				this.CardWorldPos.X = this.ToPos.X;
				UUIItem cardItem = this.CardItem;
				FVector fvector = this.CardWorldPos.ToUeVectorOld();
				cardItem.SetUIWorldLocation(fvector);
				this.HandleCompleteTween();
			});
			this.LocationYTween = new LguiFloatTween();
			this.LocationYTween.BindUpdateTween(delegate(float value)
			{
				this.CardWorldPos.Z = (double)value;
				UUIItem cardItem = this.CardItem;
				FVector fvector = this.CardWorldPos.ToUeVectorOld();
				cardItem.SetUIWorldLocation(fvector);
			});
			this.LocationYTween.BindCompleteTween(delegate
			{
				this.CardWorldPos.Z = this.ToPos.Z;
				UUIItem cardItem = this.CardItem;
				FVector fvector = this.CardWorldPos.ToUeVectorOld();
				cardItem.SetUIWorldLocation(fvector);
				this.HandleCompleteTween();
			});
		}

		// Token: 0x0602B1F2 RID: 176626 RVA: 0x00C1F3D3 File Offset: 0x00C1D5D3
		private void HandleCompleteTween()
		{
			if (this.LocationXTween.IsFinished && this.LocationYTween.IsFinished)
			{
				Action completeCallback = this.CompleteCallback;
				if (completeCallback == null)
				{
					return;
				}
				completeCallback();
			}
		}

		// Token: 0x0602B1F3 RID: 176627 RVA: 0x00C1F3FF File Offset: 0x00C1D5FF
		public void Init(UUIItem cardItem)
		{
			this.CardItem = cardItem;
			this.CreateTween();
		}

		// Token: 0x0602B1F4 RID: 176628 RVA: 0x00C1F40E File Offset: 0x00C1D60E
		public void Destroy()
		{
			this.LocationXTween.Destroy();
			this.LocationYTween.Destroy();
		}

		// Token: 0x0602B1F5 RID: 176629 RVA: 0x00C1F428 File Offset: 0x00C1D628
		public void PlayLocationByItem(UUIItem fromItem, UUIItem toItem, [Nullable(2)] PhantomArenaTweenLogic data = null)
		{
			Vector fromPos = this.FromPos;
			FVectorDouble fvectorDouble = fromItem.D_K2_GetComponentLocation();
			fromPos.DeepCopy(fvectorDouble);
			Vector toPos = this.ToPos;
			fvectorDouble = toItem.D_K2_GetComponentLocation();
			toPos.DeepCopy(fvectorDouble);
			this.CardWorldPos.DeepCopy(this.FromPos);
			UUIItem cardItem = this.CardItem;
			FVector fvector = this.CardWorldPos.ToUeVectorOld();
			cardItem.SetUIWorldLocation(fvector);
			this.LocationXTween.BindStartTween((data != null) ? data.StartCallback : null);
			this.CompleteCallback = ((data != null) ? data.CompleteCallback : null);
			float valueOrDefault = ((data != null) ? data.DurationTime : null).GetValueOrDefault(0.5f);
			this.LocationXTween.PlayTween((float)this.FromPos.X, (float)this.ToPos.X, valueOrDefault, (data != null) ? data.LocationCurveX : null);
			this.LocationYTween.PlayTween((float)this.FromPos.Z, (float)this.ToPos.Z, valueOrDefault, (data != null) ? data.LocationCurveY : null);
		}

		// Token: 0x040174D8 RID: 95448
		private UUIItem CardItem;

		// Token: 0x040174D9 RID: 95449
		protected Vector FromPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x040174DA RID: 95450
		protected Vector ToPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x040174DB RID: 95451
		protected Vector CardWorldPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x040174DC RID: 95452
		protected LguiFloatTween LocationXTween;

		// Token: 0x040174DD RID: 95453
		protected LguiFloatTween LocationYTween;

		// Token: 0x040174DE RID: 95454
		private Action CompleteCallback;
	}
}

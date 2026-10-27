using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x020052BF RID: 21183
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardTweenLogic
	{
		// Token: 0x060362F6 RID: 221942 RVA: 0x00CD1C2C File Offset: 0x00CCFE2C
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

		// Token: 0x060362F7 RID: 221943 RVA: 0x00CD1CAB File Offset: 0x00CCFEAB
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

		// Token: 0x060362F8 RID: 221944 RVA: 0x00CD1CD7 File Offset: 0x00CCFED7
		public void Init(UUIItem cardItem)
		{
			this.CardItem = cardItem;
			this.CreateTween();
		}

		// Token: 0x060362F9 RID: 221945 RVA: 0x00CD1CE6 File Offset: 0x00CCFEE6
		public void Destroy()
		{
			this.LocationXTween.Destroy();
			this.LocationYTween.Destroy();
		}

		// Token: 0x060362FA RID: 221946 RVA: 0x00CD1D00 File Offset: 0x00CCFF00
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

		// Token: 0x0401CAA3 RID: 117411
		private UUIItem CardItem;

		// Token: 0x0401CAA4 RID: 117412
		protected Vector FromPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401CAA5 RID: 117413
		protected Vector ToPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401CAA6 RID: 117414
		protected Vector CardWorldPos = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401CAA7 RID: 117415
		protected LguiFloatTween LocationXTween;

		// Token: 0x0401CAA8 RID: 117416
		protected LguiFloatTween LocationYTween;

		// Token: 0x0401CAA9 RID: 117417
		private Action CompleteCallback;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02005C4C RID: 23628
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPickInteractItem : IStaticVariableResetter
	{
		// Token: 0x0603A085 RID: 237701 RVA: 0x01054036 File Offset: 0x01052236
		static LevelPickInteractItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelPickInteractItem.CreateStaticDefaultValue), new Action(LevelPickInteractItem.ResetStaticDefaultValue));
		}

		// Token: 0x17006E7F RID: 28287
		// (get) Token: 0x0603A086 RID: 237702 RVA: 0x01054055 File Offset: 0x01052255
		public bool IsValid
		{
			get
			{
				return !this.ScreenBoundingBoxMin.Equals(this.ScreenBoundingBoxMax, 9.999999747378752E-05);
			}
		}

		// Token: 0x0603A087 RID: 237703 RVA: 0x01054074 File Offset: 0x01052274
		public void Init(AActor actor, Action<AActor> onClick, [Nullable(new byte[]
		{
			2,
			1
		})] Action<AActor> onPick = null)
		{
			this.RefreshBox(actor);
			this.OnClickCallback = onClick;
			this.OnPickCallback = onPick;
		}

		// Token: 0x0603A088 RID: 237704 RVA: 0x0105408C File Offset: 0x0105228C
		public void RefreshBox(AActor actor)
		{
			if (UKuroLevelPlayLibrary.GetActorScreenBoundingBox(Global.CharacterController, actor, ref LevelPickInteractItem.ScreenMinRef, ref LevelPickInteractItem.ScreenMaxRef))
			{
				this.ScreenBoundingBoxMin.X = (double)LevelPickInteractItem.ScreenMinRef.X;
				this.ScreenBoundingBoxMin.Y = (double)LevelPickInteractItem.ScreenMinRef.Y;
				this.ScreenBoundingBoxMax.X = (double)LevelPickInteractItem.ScreenMaxRef.X;
				this.ScreenBoundingBoxMax.Y = (double)LevelPickInteractItem.ScreenMaxRef.Y;
				this.Owner = actor;
				return;
			}
			this.ScreenBoundingBoxMin.X = 0.0;
			this.ScreenBoundingBoxMin.Y = 0.0;
			this.ScreenBoundingBoxMax.X = 0.0;
			this.ScreenBoundingBoxMax.Y = 0.0;
		}

		// Token: 0x0603A089 RID: 237705 RVA: 0x01054160 File Offset: 0x01052360
		public bool CheckInside(Vector2D mousePosition)
		{
			return mousePosition.X > this.ScreenBoundingBoxMin.X && mousePosition.Y > this.ScreenBoundingBoxMin.Y && mousePosition.X < this.ScreenBoundingBoxMax.X && mousePosition.Y < this.ScreenBoundingBoxMax.Y;
		}

		// Token: 0x0603A08A RID: 237706 RVA: 0x010541BC File Offset: 0x010523BC
		public void OnPick()
		{
			if (this.Owner == null)
			{
				Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WLJ, "[LevelPick]Owner is undefined when pick", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "Pick Item";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actorName", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.OnPickCallback != null)
			{
				this.OnPickCallback(this.Owner);
			}
		}

		// Token: 0x0603A08B RID: 237707 RVA: 0x0105423C File Offset: 0x0105243C
		public void OnClick()
		{
			if (this.Owner == null)
			{
				Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WLJ, "[LevelPick]Owner is undefined when click", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "Click Item";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actorName", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.OnClickCallback != null)
			{
				this.OnClickCallback(this.Owner);
			}
		}

		// Token: 0x0603A08C RID: 237708 RVA: 0x010542B9 File Offset: 0x010524B9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A08D RID: 237709 RVA: 0x010542BB File Offset: 0x010524BB
		public static void ResetStaticDefaultValue()
		{
			LevelPickInteractItem.ScreenMinRef = default(FVector2D);
			LevelPickInteractItem.ScreenMaxRef = default(FVector2D);
		}

		// Token: 0x0401EAF1 RID: 125681
		private static FVector2D ScreenMinRef;

		// Token: 0x0401EAF2 RID: 125682
		private static FVector2D ScreenMaxRef;

		// Token: 0x0401EAF3 RID: 125683
		private readonly Vector2D ScreenBoundingBoxMin = Vector2D.Create();

		// Token: 0x0401EAF4 RID: 125684
		private readonly Vector2D ScreenBoundingBoxMax = Vector2D.Create();

		// Token: 0x0401EAF5 RID: 125685
		[Nullable(2)]
		private AActor Owner;

		// Token: 0x0401EAF6 RID: 125686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> OnClickCallback;

		// Token: 0x0401EAF7 RID: 125687
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> OnPickCallback;
	}
}

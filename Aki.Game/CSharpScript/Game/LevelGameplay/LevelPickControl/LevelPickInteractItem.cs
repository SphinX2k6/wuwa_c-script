using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02006AD4 RID: 27348
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPickInteractItem : IStaticVariableResetter
	{
		// Token: 0x06043F3C RID: 278332 RVA: 0x010AA986 File Offset: 0x010A8B86
		static LevelPickInteractItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelPickInteractItem.CreateStaticDefaultValue), new Action(LevelPickInteractItem.ResetStaticDefaultValue));
		}

		// Token: 0x1700997C RID: 39292
		// (get) Token: 0x06043F3D RID: 278333 RVA: 0x010AA9A5 File Offset: 0x010A8BA5
		public bool IsValid
		{
			get
			{
				return !this.ScreenBoundingBoxMin.Equals(this.ScreenBoundingBoxMax, 9.999999747378752E-05);
			}
		}

		// Token: 0x06043F3E RID: 278334 RVA: 0x010AA9C4 File Offset: 0x010A8BC4
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

		// Token: 0x06043F3F RID: 278335 RVA: 0x010AA9DC File Offset: 0x010A8BDC
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

		// Token: 0x06043F40 RID: 278336 RVA: 0x010AAAB0 File Offset: 0x010A8CB0
		public bool CheckInside(Vector2D mousePosition)
		{
			return mousePosition.X > this.ScreenBoundingBoxMin.X && mousePosition.Y > this.ScreenBoundingBoxMin.Y && mousePosition.X < this.ScreenBoundingBoxMax.X && mousePosition.Y < this.ScreenBoundingBoxMax.Y;
		}

		// Token: 0x06043F41 RID: 278337 RVA: 0x010AAB0C File Offset: 0x010A8D0C
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

		// Token: 0x06043F42 RID: 278338 RVA: 0x010AAB8C File Offset: 0x010A8D8C
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

		// Token: 0x06043F43 RID: 278339 RVA: 0x010AAC09 File Offset: 0x010A8E09
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043F44 RID: 278340 RVA: 0x010AAC0B File Offset: 0x010A8E0B
		public static void ResetStaticDefaultValue()
		{
			LevelPickInteractItem.ScreenMinRef = default(FVector2D);
			LevelPickInteractItem.ScreenMaxRef = default(FVector2D);
		}

		// Token: 0x04023851 RID: 145489
		private static FVector2D ScreenMinRef;

		// Token: 0x04023852 RID: 145490
		private static FVector2D ScreenMaxRef;

		// Token: 0x04023853 RID: 145491
		private readonly Vector2D ScreenBoundingBoxMin = Vector2D.Create();

		// Token: 0x04023854 RID: 145492
		private readonly Vector2D ScreenBoundingBoxMax = Vector2D.Create();

		// Token: 0x04023855 RID: 145493
		[Nullable(2)]
		private AActor Owner;

		// Token: 0x04023856 RID: 145494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> OnClickCallback;

		// Token: 0x04023857 RID: 145495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> OnPickCallback;
	}
}

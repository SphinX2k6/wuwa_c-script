using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TempActorManager
{
	// Token: 0x02005B47 RID: 23367
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TempActorController : ControllerBase
	{
		// Token: 0x06039774 RID: 235380 RVA: 0x01020324 File Offset: 0x0101E524
		[NullableContext(2)]
		public unsafe bool Create(int playerId, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> actorClass, FTransformDouble? transform = null, AActor owner = null)
		{
			if (!GlobalData.IsPlayInEditor)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "[TempActor] not IsPlayInEditor";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playerId", playerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actorClass", actorClass.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("transform", transform);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.Destroy(playerId);
			UObject world = GlobalData.World;
			TSubclassOf<AActor> actorClass2 = actorClass;
			FTransformDouble ftransformDouble = transform ?? MathUtils.Instance.DefaultTransformDouble;
			AActor aactor = UKuroActorManager.D_SpawnActor(world, actorClass2, ftransformDouble, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, owner, null, false);
			if (aactor == null || !aactor.IsValid())
			{
				Log.Instance.Error(ELogModule.Test, ELogAuthor.LCZ, "[TempActor] 创建临时Actor Failed", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.Actors[playerId] = aactor;
			return true;
		}

		// Token: 0x06039775 RID: 235381 RVA: 0x01020425 File Offset: 0x0101E625
		[NullableContext(2)]
		public AActor Get(int playerId)
		{
			return this.Actors.GetValueOrDefault(playerId);
		}

		// Token: 0x06039776 RID: 235382 RVA: 0x01020434 File Offset: 0x0101E634
		public bool Destroy(int playerId)
		{
			AActor aactor;
			if (this.Actors.TryGetValue(playerId, out aactor))
			{
				aactor.K2_DestroyActor();
				this.Actors.Remove(playerId);
				return true;
			}
			return false;
		}

		// Token: 0x06039777 RID: 235383 RVA: 0x01020468 File Offset: 0x0101E668
		public void DestroyAll()
		{
			foreach (AActor aactor in this.Actors.Values)
			{
				aactor.K2_DestroyActor();
			}
			this.Actors.Clear();
		}

		// Token: 0x06039778 RID: 235384 RVA: 0x010204C8 File Offset: 0x0101E6C8
		protected override bool OnLeaveLevel()
		{
			this.DestroyAll();
			return true;
		}

		// Token: 0x06039779 RID: 235385 RVA: 0x010204D1 File Offset: 0x0101E6D1
		protected override bool OnClear()
		{
			this.DestroyAll();
			return true;
		}

		// Token: 0x17006D63 RID: 28003
		// (get) Token: 0x0603977A RID: 235386 RVA: 0x010204DA File Offset: 0x0101E6DA
		public static TempActorController Instance
		{
			get
			{
				return TempActorController._Instance;
			}
		}

		// Token: 0x0603977B RID: 235387 RVA: 0x010204E1 File Offset: 0x0101E6E1
		public static TempActorController GetOrCreateInstance()
		{
			if (TempActorController._Instance == null)
			{
				TempActorController.CreateInstance();
			}
			return TempActorController._Instance;
		}

		// Token: 0x0603977C RID: 235388 RVA: 0x010204F5 File Offset: 0x0101E6F5
		public static bool CreateInstance()
		{
			if (TempActorController._Instance != null)
			{
				return true;
			}
			TempActorController._Instance = new TempActorController();
			return true;
		}

		// Token: 0x0603977D RID: 235389 RVA: 0x0102050B File Offset: 0x0101E70B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603977E RID: 235390 RVA: 0x0102050D File Offset: 0x0101E70D
		public static void ResetStaticDefaultValue()
		{
			TempActorController._Instance = null;
		}

		// Token: 0x0603977F RID: 235391 RVA: 0x01020515 File Offset: 0x0101E715
		static TempActorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TempActorController.CreateStaticDefaultValue), new Action(TempActorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E522 RID: 124194
		private readonly Dictionary<int, AActor> Actors = new Dictionary<int, AActor>();

		// Token: 0x0401E523 RID: 124195
		[Nullable(2)]
		private static TempActorController _Instance;
	}
}

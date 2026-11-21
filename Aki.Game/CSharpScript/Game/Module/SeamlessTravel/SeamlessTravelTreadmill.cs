using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C41 RID: 15425
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelTreadmill
	{
		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x0602783D RID: 161853 RVA: 0x00B15797 File Offset: 0x00B13997
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x0602783E RID: 161854 RVA: 0x00B1579F File Offset: 0x00B1399F
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x0602783F RID: 161855 RVA: 0x00B157A8 File Offset: 0x00B139A8
		public void Init(SeamlessTravelContext config, Action<bool> callback)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.ActorComp = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[万向跑步机]初始化失败，无效的ActorComp";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsActiveInternal = false;
			this.Context = config;
			if (this.IsInit)
			{
				callback(true);
				return;
			}
			this.LoadFloor(callback);
		}

		// Token: 0x06027840 RID: 161856 RVA: 0x00B15828 File Offset: 0x00B13A28
		public void Tick(float delta)
		{
			if (!this.IsInit)
			{
				return;
			}
			AStaticMeshActor floor = this.Floor;
			if (floor == null || !floor.IsValid())
			{
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Valid)
			{
				return;
			}
			if (!this.IsActive)
			{
				return;
			}
			this.ActorComp.ActorLocationProxy.Subtraction(this.LockOnLocation, this.LocationDelta);
			this.UpdateFloorMatUV(this.LocationDelta);
			this.LockActorMove();
			SeamlessTravelTreadmill.FloorMaterialParams floorMatParams = this.FloorMatParams;
			if (floorMatParams == null)
			{
				return;
			}
			floorMatParams.Update(delta);
		}

		// Token: 0x06027841 RID: 161857 RVA: 0x00B158B8 File Offset: 0x00B13AB8
		public void Destroy()
		{
			AStaticMeshActor floor = this.Floor;
			if (floor != null && floor.IsValid())
			{
				ActorSystem.Instance.Put("SeamlessTravelTreadmill.Destroy", this.Floor, null);
			}
			this.ActorComp = null;
			this.Context = null;
			this.Floor = null;
			this.FloorExtend.Reset();
			this.FloorMatParams = null;
			this.IsLockMove = false;
			this.IsActiveInternal = false;
			this.LockOnLocation.Reset();
			this.LocationDelta.Reset();
			this.TmpVector.Reset();
			this.TmpTransform.Reset();
			this.TmpQuat.Reset();
			this.TmpRotator.Reset();
		}

		// Token: 0x06027842 RID: 161858 RVA: 0x00B15968 File Offset: 0x00B13B68
		public void Reset()
		{
			this.ActorComp = null;
			this.IsLockMove = false;
			this.IsActiveInternal = false;
			if (this.FloorMatParams != null)
			{
				this.FloorMatParams.Reset();
			}
			this.LockOnLocation.Reset();
			this.LocationDelta.Reset();
			this.TmpVector.Reset();
			this.TmpTransform.Reset();
			this.TmpQuat.Reset();
			this.TmpRotator.Reset();
		}

		// Token: 0x06027843 RID: 161859 RVA: 0x00B159E0 File Offset: 0x00B13BE0
		protected void GetInitFloorTransform(Transform outTransform)
		{
			this.LockOnGravityDirect.Multiply((double)this.ActorComp.ScaledHalfHeight + this.FloorExtend.Z, this.TmpVector);
			this.TmpVector.AdditionEqual(this.LockOnLocation);
			outTransform.SetLocation(this.TmpVector);
			this.TmpVector.Set(100.0, 100.0, 1.0);
			SeamlessTravelFloorParams floorParams = this.Context.FloorParams;
			if (((floorParams != null) ? floorParams.FloorScale : null) != null)
			{
				Vector tmpVector = this.TmpVector;
				SeamlessTravelFloorParams floorParams2 = this.Context.FloorParams;
				tmpVector.DeepCopy((floorParams2 != null) ? floorParams2.FloorScale : null);
			}
			outTransform.SetScale3D(this.TmpVector);
			Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			Quat.FindBetween(Vector.DownVectorProxy, this.LockOnGravityDirect, this.TmpQuat);
			this.TmpQuat.Multiply(Rotator.ZeroRotatorProxy.Quaternion(null), quat);
			outTransform.SetRotation(quat);
		}

		// Token: 0x06027844 RID: 161860 RVA: 0x00B15B00 File Offset: 0x00B13D00
		protected void HandleFalseInit(Action<bool> callback)
		{
			callback(false);
			this.IsInitInternal = true;
		}

		// Token: 0x06027845 RID: 161861 RVA: 0x00B15B10 File Offset: 0x00B13D10
		protected unsafe void LoadFloor(Action<bool> callback)
		{
			SeamlessTravelTreadmill.<>c__DisplayClass35_0 CS$<>8__locals1 = new SeamlessTravelTreadmill.<>c__DisplayClass35_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			SeamlessTravelTreadmill.<>c__DisplayClass35_0 CS$<>8__locals2 = CS$<>8__locals1;
			SeamlessTravelFloorParams floorParams = this.Context.FloorParams;
			CS$<>8__locals2.meshPath = (((floorParams != null) ? floorParams.FloorMeshPath : null) ?? "/Engine/BasicShapes/Plane.Plane");
			ResourceSystem.Instance.LoadAsync<UStaticMesh>(CS$<>8__locals1.meshPath, delegate([Nullable(2)] UStaticMesh result, string _)
			{
				if (result == null || !result.IsValid())
				{
					CS$<>8__locals1.<>4__this.HandleFalseInit(CS$<>8__locals1.callback);
					return;
				}
				CharacterActorComponent actorComp = CS$<>8__locals1.<>4__this.ActorComp;
				bool flag;
				if (actorComp == null)
				{
					flag = true;
				}
				else
				{
					TsBaseCharacter actor = actorComp.Actor;
					flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
				}
				if (flag)
				{
					CS$<>8__locals1.<>4__this.HandleFalseInit(CS$<>8__locals1.callback);
					return;
				}
				CS$<>8__locals1.<>4__this.GetInitFloorTransform(CS$<>8__locals1.<>4__this.TmpTransform);
				CS$<>8__locals1.<>4__this.Floor = (ActorSystem.Instance.Get(AStaticMeshActor.StaticClass(), CS$<>8__locals1.<>4__this.TmpTransform.ToUeTransform(), CS$<>8__locals1.<>4__this.ActorComp.Actor, true) as AStaticMeshActor);
				AStaticMeshActor floor = CS$<>8__locals1.<>4__this.Floor;
				if (floor == null || !floor.IsValid())
				{
					CS$<>8__locals1.<>4__this.HandleFalseInit(CS$<>8__locals1.callback);
					return;
				}
				Vector scale3D = CS$<>8__locals1.<>4__this.TmpTransform.GetScale3D();
				FBoxSphereBounds bounds = result.GetBounds();
				CS$<>8__locals1.<>4__this.FloorExtend.X = (double)bounds.BoxExtent.X * scale3D.X;
				CS$<>8__locals1.<>4__this.FloorExtend.Y = (double)bounds.BoxExtent.Y * scale3D.Y;
				CS$<>8__locals1.<>4__this.FloorExtend.Z = (double)bounds.BoxExtent.Z;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[万向跑步机]加载地板Mesh";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Bound", CS$<>8__locals1.<>4__this.FloorExtend);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", CS$<>8__locals1.meshPath);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				CS$<>8__locals1.<>4__this.Floor.StaticMeshComponent.SetMobility(EComponentMobility.Movable);
				CS$<>8__locals1.<>4__this.Floor.StaticMeshComponent.SetStaticMesh(result);
				CS$<>8__locals1.<>4__this.Floor.StaticMeshComponent.SetEnableGravity(false);
				CS$<>8__locals1.<>4__this.LoadFloorMaterial(CS$<>8__locals1.callback);
				if (CS$<>8__locals1.<>4__this.Context.FloorParams == null)
				{
					CS$<>8__locals1.<>4__this.Floor.SetActorHiddenInGame(true);
				}
			}, ResourceSystem.EResourceLoadPriority.Default, "SeamlessTravel");
		}

		// Token: 0x06027846 RID: 161862 RVA: 0x00B15B7C File Offset: 0x00B13D7C
		protected void LoadFloorMaterial(Action<bool> callback)
		{
			SeamlessTravelFloorParams floorParams = this.Context.FloorParams;
			if (string.IsNullOrEmpty((floorParams != null) ? floorParams.FloorMaterialPath : null))
			{
				this.HandleFalseInit(callback);
				Log.Instance.Info(ELogModule.Character, ELogAuthor.YJX, "[万向跑步机]没有配置材质，不加载", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.FloorMatParams = new SeamlessTravelTreadmill.FloorMaterialParams(this);
			string matPath = this.Context.FloorParams.FloorMaterialPath;
			ResourceSystem.Instance.LoadAsync<UMaterialInstance>(matPath, delegate([Nullable(2)] UMaterialInstance result, string _)
			{
				if (result == null || !result.IsValid())
				{
					this.HandleFalseInit(callback);
					return;
				}
				AStaticMeshActor floor = this.Floor;
				if (floor == null || !floor.IsValid())
				{
					this.HandleFalseInit(callback);
					return;
				}
				this.Floor.StaticMeshComponent.SetMaterial(0, result);
				UMaterialInstanceDynamic umaterialInstanceDynamic = this.Floor.StaticMeshComponent.CreateDynamicMaterialInstance(0, result, default(FName));
				if (umaterialInstanceDynamic == null || !umaterialInstanceDynamic.IsValid())
				{
					this.HandleFalseInit(callback);
					return;
				}
				callback(true);
				this.IsInitInternal = true;
				this.FloorMatParams.Bind(umaterialInstanceDynamic);
				this.Floor.StaticMeshComponent.SetMaterial(0, umaterialInstanceDynamic);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[万向跑步机]加载地板材质";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", matPath);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}, ResourceSystem.EResourceLoadPriority.Default, "SeamlessTravel.Treadmill");
		}

		// Token: 0x06027847 RID: 161863 RVA: 0x00B15C2C File Offset: 0x00B13E2C
		protected void UpdateFloorMatUV(Vector moveDelta)
		{
			if (!this.IsLockMove)
			{
				return;
			}
			if (this.FloorMatParams == null)
			{
				return;
			}
			double num = 2.0 * this.FloorExtend.X;
			double num2 = 2.0 * this.FloorExtend.Y;
			this.GetInitFloorTransform(this.TmpTransform);
			this.TmpTransform.GetRotation().Inverse(this.TmpQuat);
			this.TmpQuat.RotateVector(moveDelta, this.TmpVector);
			SeamlessTravelTreadmill.FloorMaterialParams floorMatParams = this.FloorMatParams;
			floorMatParams.Offset.R = floorMatParams.Offset.R + (float)(this.TmpVector.X % num / num);
			SeamlessTravelTreadmill.FloorMaterialParams floorMatParams2 = this.FloorMatParams;
			floorMatParams2.Offset.G = floorMatParams2.Offset.G + (float)(this.TmpVector.Y % num2 / num2);
		}

		// Token: 0x06027848 RID: 161864 RVA: 0x00B15CF4 File Offset: 0x00B13EF4
		protected void LockActorMove()
		{
			if (this.ActorComp == null)
			{
				return;
			}
			if (!this.IsLockMove)
			{
				return;
			}
			BaseGravityComponent component = this.ActorComp.Entity.GetComponent<BaseGravityComponent>();
			if (component != null)
			{
				component.SetGravityByPriority(0, this.LockOnGravityDirect, true, -1f, true);
			}
			this.ActorComp.ActorLocationProxy.Subtraction(this.LockOnLocation, this.TmpVector);
			double inB = Vector.DotProduct(this.TmpVector, this.LockOnGravityDirect);
			this.LockOnGravityDirect.Multiply(inB, this.TmpVector);
			this.TmpVector.AdditionEqual(this.LockOnLocation);
			this.ActorComp.SetActorLocation(this.TmpVector.ToUeVector(false), "万向跑步机锁定位置", true);
		}

		// Token: 0x06027849 RID: 161865 RVA: 0x00B15DB0 File Offset: 0x00B13FB0
		public void AppearEffect(Action callback)
		{
			if (this.FloorMatParams == null)
			{
				callback();
				return;
			}
			double alphaDelta = 0.5;
			SeamlessTravelFloorParams floorParams = this.Context.FloorParams;
			if (floorParams != null && floorParams.FloorAppearTime > 0f)
			{
				alphaDelta = 1.0 / (double)this.Context.FloorParams.FloorAppearTime;
			}
			this.FloorMatParams.OnAppearEndHandle = callback;
			this.FloorMatParams.AlphaDelta = alphaDelta;
			this.IsActiveInternal = true;
		}

		// Token: 0x0602784A RID: 161866 RVA: 0x00B15E34 File Offset: 0x00B14034
		public void DisappearEffect(Action callback)
		{
			if (this.FloorMatParams == null)
			{
				callback();
				return;
			}
			Action onDisappearEndHandle = delegate()
			{
				callback();
				this.IsActiveInternal = false;
			};
			double num = 0.5;
			SeamlessTravelFloorParams floorParams = this.Context.FloorParams;
			if (floorParams != null && floorParams.FloorDisappearTime > 0f)
			{
				num = 1.0 / (double)this.Context.FloorParams.FloorDisappearTime;
			}
			this.FloorMatParams.OnDisappearEndHandle = onDisappearEndHandle;
			this.FloorMatParams.AlphaDelta = -num;
		}

		// Token: 0x0602784B RID: 161867 RVA: 0x00B15ED5 File Offset: 0x00B140D5
		public void EnableLockMove(bool enable)
		{
			this.IsLockMove = enable;
		}

		// Token: 0x0602784C RID: 161868 RVA: 0x00B15EE0 File Offset: 0x00B140E0
		[NullableContext(2)]
		public unsafe void ResetLockOnLocation(Vector targetLocation = null, Vector gravityDirect = null)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			if (targetLocation != null)
			{
				this.LockOnLocation.DeepCopy(targetLocation);
			}
			else
			{
				this.LockOnLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			if (gravityDirect != null)
			{
				this.LockOnGravityDirect.DeepCopy(gravityDirect);
			}
			else
			{
				this.LockOnGravityDirect.DeepCopy(this.ActorComp.ActorGravityDirectProxy);
			}
			AStaticMeshActor floor = this.Floor;
			if (floor != null && floor.IsValid())
			{
				this.GetInitFloorTransform(this.TmpTransform);
				AActor floor2 = this.Floor;
				FTransformDouble ftransformDouble = this.TmpTransform.ToUeTransform();
				floor2.D_K2_SetActorTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[万向跑步机]重置Lock位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LockLocation", this.LockOnLocation);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "FloorMeshLocation";
			AStaticMeshActor floor3 = this.Floor;
			ptr = new ValueTuple<string, object>(item, (floor3 != null) ? new FVectorDouble?(floor3.D_K2_GetActorLocation()) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602784D RID: 161869 RVA: 0x00B16000 File Offset: 0x00B14200
		public void GetLockOnLocation(Vector outVec)
		{
			outVec.DeepCopy(this.LockOnLocation);
		}

		// Token: 0x0602784E RID: 161870 RVA: 0x00B1600E File Offset: 0x00B1420E
		[NullableContext(2)]
		public AActor GetFloorActor()
		{
			AStaticMeshActor floor = this.Floor;
			if (floor == null || !floor.IsValid())
			{
				return null;
			}
			return this.Floor;
		}

		// Token: 0x040158C4 RID: 88260
		private const string DEFAULT_FLOOR_MESH_PATH = "/Engine/BasicShapes/Plane.Plane";

		// Token: 0x040158C5 RID: 88261
		private static readonly FName floorMeshMaterialOffsetParam = new FName("Offset");

		// Token: 0x040158C6 RID: 88262
		private static readonly FName floorMeshMaterialAlphaParam = new FName("Alpha");

		// Token: 0x040158C7 RID: 88263
		private const float DEFAULT_APPEAR_ALPHA_DELTA = 0.5f;

		// Token: 0x040158C8 RID: 88264
		private const float DEFAULT_DISAPPEAR_ALPHA_DELTA = 0.5f;

		// Token: 0x040158C9 RID: 88265
		private const int DEFAULT_FLOOR_SCALE_X = 100;

		// Token: 0x040158CA RID: 88266
		private const int DEFAULT_FLOOR_SCALE_Y = 100;

		// Token: 0x040158CB RID: 88267
		private const int DEFAULT_FLOOR_SCALE_Z = 1;

		// Token: 0x040158CC RID: 88268
		public const int DEFAULT_SEAMLESS_TRANSITION_HEIGHT = 2000000;

		// Token: 0x040158CD RID: 88269
		[Nullable(2)]
		protected CharacterActorComponent ActorComp;

		// Token: 0x040158CE RID: 88270
		[Nullable(2)]
		protected SeamlessTravelContext Context;

		// Token: 0x040158CF RID: 88271
		[Nullable(2)]
		protected AStaticMeshActor Floor;

		// Token: 0x040158D0 RID: 88272
		protected Vector FloorExtend = Vector.Create();

		// Token: 0x040158D1 RID: 88273
		[Nullable(2)]
		protected SeamlessTravelTreadmill.FloorMaterialParams FloorMatParams;

		// Token: 0x040158D2 RID: 88274
		protected bool IsInitInternal;

		// Token: 0x040158D3 RID: 88275
		protected bool IsLockMove;

		// Token: 0x040158D4 RID: 88276
		protected bool IsActiveInternal;

		// Token: 0x040158D5 RID: 88277
		protected Vector LockOnLocation = Vector.Create();

		// Token: 0x040158D6 RID: 88278
		protected Vector LockOnGravityDirect = Vector.Create();

		// Token: 0x040158D7 RID: 88279
		protected Vector LocationDelta = Vector.Create();

		// Token: 0x040158D8 RID: 88280
		protected Vector TmpVector = Vector.Create();

		// Token: 0x040158D9 RID: 88281
		protected Transform TmpTransform = Transform.Create();

		// Token: 0x040158DA RID: 88282
		protected Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040158DB RID: 88283
		protected Rotator TmpRotator = Rotator.Create();

		// Token: 0x02009860 RID: 39008
		[NullableContext(2)]
		[Nullable(0)]
		protected class FloorMaterialParams
		{
			// Token: 0x060445A4 RID: 279972 RVA: 0x0145D974 File Offset: 0x0145BB74
			[NullableContext(1)]
			public FloorMaterialParams(SeamlessTravelTreadmill owner)
			{
				this.Owner = owner;
			}

			// Token: 0x060445A5 RID: 279973 RVA: 0x0145D9A2 File Offset: 0x0145BBA2
			[NullableContext(1)]
			public void Bind(UMaterialInstanceDynamic mat)
			{
				if (!mat.IsValid())
				{
					return;
				}
				if (this.Material != null)
				{
					return;
				}
				this.Material = mat;
			}

			// Token: 0x060445A6 RID: 279974 RVA: 0x0145D9C0 File Offset: 0x0145BBC0
			public void Reset()
			{
				this.Offset.R = 0f;
				this.Offset.G = 0f;
				this.Alpha = 0f;
				this.AlphaDelta = 0.0;
				this.OnAppearStartHandle = null;
				this.OnAppearEndHandle = null;
				this.OnDisappearStartHandle = null;
				this.OnDisappearEndHandle = null;
			}

			// Token: 0x060445A7 RID: 279975 RVA: 0x0145DA24 File Offset: 0x0145BC24
			public void Update(float deltaTime)
			{
				if (!this.Owner.IsInit)
				{
					return;
				}
				if (this.AlphaDelta != 0.0)
				{
					if (this.OnAppearStartHandle != null && this.Alpha == 0f && this.AlphaDelta > 0.0)
					{
						this.OnAppearStartHandle();
					}
					else if (this.OnDisappearStartHandle != null && this.Alpha == 1f && this.AlphaDelta < 0.0)
					{
						this.OnDisappearStartHandle();
					}
					double num = this.AlphaDelta * (double)deltaTime * 0.0010000000474974513;
					this.Alpha = (float)MathUtils.Instance.Clamp((double)this.Alpha + num, 0.0, 1.0);
					UMaterialInstanceDynamic material = this.Material;
					if (material != null)
					{
						material.SetScalarParameterValue(SeamlessTravelTreadmill.floorMeshMaterialAlphaParam, this.Alpha);
					}
					if (this.Alpha <= 0f || this.Alpha >= 1f)
					{
						if (this.OnAppearEndHandle != null && this.Alpha == 1f && this.AlphaDelta > 0.0)
						{
							this.OnAppearEndHandle();
						}
						else if (this.OnDisappearEndHandle != null && this.Alpha == 0f && this.AlphaDelta < 0.0)
						{
							this.OnDisappearEndHandle();
						}
						this.AlphaDelta = 0.0;
					}
				}
				if (this.IsVisible())
				{
					UMaterialInstanceDynamic material2 = this.Material;
					if (material2 == null)
					{
						return;
					}
					material2.SetVectorParameterValue(SeamlessTravelTreadmill.floorMeshMaterialOffsetParam, this.Offset);
				}
			}

			// Token: 0x060445A8 RID: 279976 RVA: 0x0145DBC3 File Offset: 0x0145BDC3
			public bool IsVisible()
			{
				return this.Alpha > 0f;
			}

			// Token: 0x0402F853 RID: 194643
			public FLinearColor Offset = new FLinearColor(0f, 0f, 0f, 0f);

			// Token: 0x0402F854 RID: 194644
			public float Alpha;

			// Token: 0x0402F855 RID: 194645
			public double AlphaDelta;

			// Token: 0x0402F856 RID: 194646
			[Nullable(1)]
			private readonly SeamlessTravelTreadmill Owner;

			// Token: 0x0402F857 RID: 194647
			private UMaterialInstanceDynamic Material;

			// Token: 0x0402F858 RID: 194648
			public Action OnAppearStartHandle;

			// Token: 0x0402F859 RID: 194649
			public Action OnAppearEndHandle;

			// Token: 0x0402F85A RID: 194650
			public Action OnDisappearStartHandle;

			// Token: 0x0402F85B RID: 194651
			public Action OnDisappearEndHandle;
		}
	}
}

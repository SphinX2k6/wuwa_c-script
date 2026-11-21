using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02003669 RID: 13929
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGrid : WuWaGoBaseUnit
	{
		// Token: 0x06024215 RID: 147989 RVA: 0x00A3AE34 File Offset: 0x00A39034
		public WuWaGoGrid(Vector coordinate, Rotator rotator, EGridShape gridShape, IWuWaGoGridLinkData gridLinkConfig, [Nullable(2)] IWuWaGoGridLinkData gearLinkConfig = null, [Nullable(2)] Vector attachedCubeCoordinate = null) : base(coordinate, rotator)
		{
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x06024216 RID: 147990 RVA: 0x00A3AEB5 File Offset: 0x00A390B5
		public override bool Actionable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x06024217 RID: 147991 RVA: 0x00A3AEB8 File Offset: 0x00A390B8
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x06024218 RID: 147992 RVA: 0x00A3AEBB File Offset: 0x00A390BB
		// (set) Token: 0x06024219 RID: 147993 RVA: 0x00A3AEC3 File Offset: 0x00A390C3
		[Nullable(2)]
		public AActor Applique { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602421A RID: 147994 RVA: 0x00A3AECC File Offset: 0x00A390CC
		[NullableContext(2)]
		protected override AActor GetActorRaw()
		{
			return CharacterController.Instance.GetActor(this.EntityHandle);
		}

		// Token: 0x0602421B RID: 147995 RVA: 0x00A3AEDE File Offset: 0x00A390DE
		public override IRollbackCapture CaptureRollback()
		{
			return new GridRollbackCapture(this);
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x0602421C RID: 147996 RVA: 0x00A3AEE6 File Offset: 0x00A390E6
		[Nullable(2)]
		public EntityHandle EntityHandle
		{
			[NullableContext(2)]
			get
			{
				return CreatureModel.Instance.GetEntityByPbDataId(this.EntityPbDataIdValue);
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x0602421D RID: 147997 RVA: 0x00A3AEF8 File Offset: 0x00A390F8
		[Nullable(2)]
		public SceneItemMoveComponent SceneItemMoveComponent
		{
			[NullableContext(2)]
			get
			{
				EntityHandle entityHandle = this.EntityHandle;
				if (entityHandle == null)
				{
					return null;
				}
				WorldEntity entity = entityHandle.Entity;
				if (entity == null)
				{
					return null;
				}
				return entity.GetComponent<SceneItemMoveComponent>();
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x0602421E RID: 147998 RVA: 0x00A3AF16 File Offset: 0x00A39116
		public bool IsOccupied
		{
			get
			{
				return this.OccupiedUnit != 0;
			}
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x0602421F RID: 147999 RVA: 0x00A3AF21 File Offset: 0x00A39121
		public int OccupiedUnitId
		{
			get
			{
				return this.OccupiedUnit;
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x06024220 RID: 148000 RVA: 0x00A3AF29 File Offset: 0x00A39129
		public bool IsEntityGrid
		{
			get
			{
				return this.EntityPbDataIdValue != 0;
			}
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x06024221 RID: 148001 RVA: 0x00A3AF34 File Offset: 0x00A39134
		public int EntityPbDataId
		{
			get
			{
				return this.EntityPbDataIdValue;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x06024222 RID: 148002 RVA: 0x00A3AF3C File Offset: 0x00A3913C
		public EWuWaGoEntityType? EntityType
		{
			get
			{
				return this.EntityTypeValue;
			}
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x06024223 RID: 148003 RVA: 0x00A3AF44 File Offset: 0x00A39144
		public bool HasAttachedGameplayEntity
		{
			get
			{
				return this.AttachedGameplayEntityPbDataIdsValue.Count > 0;
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x06024224 RID: 148004 RVA: 0x00A3AF54 File Offset: 0x00A39154
		public IReadOnlyList<int> AttachedGameplayEntityPbDataIds
		{
			get
			{
				return this.AttachedGameplayEntityPbDataIdsValue;
			}
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x06024225 RID: 148005 RVA: 0x00A3AF5C File Offset: 0x00A3915C
		public bool IsEndPoint
		{
			get
			{
				return this.EntityTypeValue.GetValueOrDefault() == EWuWaGoEntityType.EndGrid;
			}
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x06024226 RID: 148006 RVA: 0x00A3AF6C File Offset: 0x00A3916C
		public IReadOnlyList<Vector> LinkedDirections
		{
			get
			{
				return this.LinkDirections;
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x06024227 RID: 148007 RVA: 0x00A3AF74 File Offset: 0x00A39174
		public IReadOnlyList<Vector> GearLinkDirections
		{
			get
			{
				return this.GearLinkDirectionsInternal;
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x06024228 RID: 148008 RVA: 0x00A3AF7C File Offset: 0x00A3917C
		public bool HasGearPath
		{
			get
			{
				return this.HasGearPathInternal;
			}
		}

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x06024229 RID: 148009 RVA: 0x00A3AF84 File Offset: 0x00A39184
		[Nullable(2)]
		public IWallFrame WallFrame
		{
			[NullableContext(2)]
			get
			{
				return this.WallFrameInfo;
			}
		}

		// Token: 0x0602422A RID: 148010 RVA: 0x00A3AF8C File Offset: 0x00A3918C
		public bool IsBidirectionalLinkedTo(WuWaGoGrid other)
		{
			double num = other.Coordinate.X - base.Coordinate.X;
			double num2 = other.Coordinate.Y - base.Coordinate.Y;
			double num3 = other.Coordinate.Z - base.Coordinate.Z;
			bool flag = false;
			for (int i = 0; i < this.LinkDirections.Count; i++)
			{
				Vector vector = this.LinkDirections[i];
				if (vector.X.Equals(num) && vector.Y.Equals(num2) && vector.Z.Equals(num3))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			for (int j = 0; j < other.LinkDirections.Count; j++)
			{
				Vector vector2 = other.LinkDirections[j];
				if (vector2.X.Equals(-num) && vector2.Y.Equals(-num2) && vector2.Z.Equals(-num3))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602422B RID: 148011 RVA: 0x00A3B0A0 File Offset: 0x00A392A0
		public void InitOpeningDirections()
		{
			this.InitRotatedOpeningDirections(this.GridLinkConfig.GridLinkType, this.OpeningDirections);
			IWuWaGoGridLinkData gearLinkConfig = this.GearLinkConfig;
			this.HasGearPathInternal = this.InitBaseOpeningDirections((gearLinkConfig != null) ? new EWuWaGoGridLinkType?(gearLinkConfig.GridLinkType) : null, this.GearOpeningDirections);
		}

		// Token: 0x0602422C RID: 148012 RVA: 0x00A3B0F8 File Offset: 0x00A392F8
		private void InitRotatedOpeningDirections(EWuWaGoGridLinkType linkType, List<Vector> targetDirections)
		{
			targetDirections.Clear();
			IReadOnlyList<Vector> readOnlyList;
			if (!WuWaGoGrid.BaseOpeningPatterns.TryGetValue(linkType, out readOnlyList) || readOnlyList.Count == 0)
			{
				return;
			}
			Quat quat = this.GetLinkRotator().Quaternion(null);
			foreach (Vector inV in readOnlyList)
			{
				Vector vector = Vector.Create();
				quat.RotateVector(inV, vector);
				vector.Set((double)((float)Math.Round(vector.X)), (double)((float)Math.Round(vector.Y)), (double)((float)Math.Round(vector.Z)));
				targetDirections.Add(vector);
			}
		}

		// Token: 0x0602422D RID: 148013 RVA: 0x00A3B1B0 File Offset: 0x00A393B0
		private bool InitBaseOpeningDirections(EWuWaGoGridLinkType? linkType, List<Vector> targetDirections)
		{
			targetDirections.Clear();
			if (linkType == null)
			{
				return false;
			}
			IReadOnlyList<Vector> readOnlyList;
			if (!WuWaGoGrid.BaseOpeningPatterns.TryGetValue(linkType.Value, out readOnlyList) || readOnlyList.Count == 0)
			{
				return false;
			}
			Quat quat = base.Rotator.Quaternion(null);
			foreach (Vector inV in readOnlyList)
			{
				Vector vector = Vector.Create();
				quat.RotateVector(inV, vector);
				vector.Set((double)((float)Math.Round(vector.X)), (double)((float)Math.Round(vector.Y)), (double)((float)Math.Round(vector.Z)));
				targetDirections.Add(vector);
			}
			return true;
		}

		// Token: 0x0602422E RID: 148014 RVA: 0x00A3B278 File Offset: 0x00A39478
		[NullableContext(0)]
		public UniTask<bool> Create()
		{
			WuWaGoGrid.<Create>d__62 <Create>d__;
			<Create>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<WuWaGoGrid.<Create>d__62>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x0602422F RID: 148015 RVA: 0x00A3B2BC File Offset: 0x00A394BC
		public void Destroy()
		{
			AActor applique = this.Applique;
			if (applique != null && applique.IsValid())
			{
				WuWaGoFactory.DestroyApplique(this.Applique);
			}
			this.LinkDirections.Clear();
			this.GearLinkDirectionsInternal.Clear();
			this.OccupiedUnitChangedListeners.Clear();
			this.MoveParticipants.Clear();
			this.OccupiedUnit = 0;
			this.OpeningDirections.Clear();
			this.GearOpeningDirections.Clear();
			this.HasGearPathInternal = false;
			this.WallFrameInfo = null;
			AActor applique2 = this.Applique;
			if (applique2 != null && applique2.IsValid())
			{
				WuWaGoFactory.DestroyApplique(this.Applique);
			}
			this.Applique = null;
			this.EntityPbDataIdValue = 0;
			this.EntityTypeValue = null;
			this.AttachedGameplayEntityPbDataIdsValue.Clear();
		}

		// Token: 0x06024230 RID: 148016 RVA: 0x00A3B388 File Offset: 0x00A39588
		[NullableContext(0)]
		private UniTask<bool> CreateAppliqueActor()
		{
			WuWaGoGrid.<CreateAppliqueActor>d__64 <CreateAppliqueActor>d__;
			<CreateAppliqueActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CreateAppliqueActor>d__.<>4__this = this;
			<CreateAppliqueActor>d__.<>1__state = -1;
			<CreateAppliqueActor>d__.<>t__builder.Start<WuWaGoGrid.<CreateAppliqueActor>d__64>(ref <CreateAppliqueActor>d__);
			return <CreateAppliqueActor>d__.<>t__builder.Task;
		}

		// Token: 0x06024231 RID: 148017 RVA: 0x00A3B3CC File Offset: 0x00A395CC
		public unsafe void BuildLinks(WuWaGoModel model)
		{
			this.LinkDirections.Clear();
			this.GearLinkDirectionsInternal.Clear();
			this.WallFrameInfo = null;
			if (this.OpeningDirections.Count == 0 && this.GearOpeningDirections.Count == 0)
			{
				return;
			}
			EGridShape gridShape = this.GridShape;
			if (gridShape != EGridShape.Vertical)
			{
				if (gridShape == EGridShape.Horizontal)
				{
					this.BuildLinksForHorizontal(model, this.OpeningDirections, this.LinkDirections, false);
					this.BuildLinksForHorizontal(model, this.GearOpeningDirections, this.GearLinkDirectionsInternal, true);
					return;
				}
			}
			else
			{
				this.WallFrameInfo = this.GetVerticalGridWallFrame(model, base.Coordinate);
				if (this.WallFrameInfo == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WuWaGo;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "VerticalGrid 坐标非法或两侧均无归属cube,放弃构建link";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", this.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("coordinate", base.Coordinate.ToString());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.BuildLinksForVertical(model, this.OpeningDirections, this.LinkDirections, false);
				this.BuildLinksForVertical(model, this.GearOpeningDirections, this.GearLinkDirectionsInternal, true);
			}
		}

		// Token: 0x06024232 RID: 148018 RVA: 0x00A3B4FC File Offset: 0x00A396FC
		private void BuildLinksForHorizontal(WuWaGoModel model, IReadOnlyList<Vector> openingDirections, List<Vector> targetDirections, bool requireGearPathOnNeighbor = false)
		{
			if (openingDirections.Count == 0)
			{
				return;
			}
			Vector vector = Vector.Create();
			foreach (Vector vector2 in openingDirections)
			{
				base.Coordinate.Addition(vector2, vector);
				WuWaGoGrid grid = model.GetGrid(vector);
				if (grid != null && grid.GridShape == EGridShape.Horizontal)
				{
					if (!requireGearPathOnNeighbor || grid.HasGearPath)
					{
						Vector vector3 = Vector.Create();
						vector3.DeepCopy(vector2);
						targetDirections.Add(vector3);
					}
				}
				else
				{
					Vector vector4 = Vector.Create(vector2.X * 0.5, vector2.Y * 0.5, 0.5);
					base.Coordinate.Addition(vector4, vector);
					WuWaGoGrid grid2 = model.GetGrid(vector);
					if (grid2 != null && grid2.GridShape == EGridShape.Vertical)
					{
						if (!requireGearPathOnNeighbor || grid2.HasGearPath)
						{
							targetDirections.Add(vector4);
						}
					}
					else
					{
						Vector vector5 = Vector.Create(vector2.X * 0.5, vector2.Y * 0.5, -0.5);
						base.Coordinate.Addition(vector5, vector);
						WuWaGoGrid grid3 = model.GetGrid(vector);
						if (grid3 != null && grid3.GridShape == EGridShape.Vertical && (!requireGearPathOnNeighbor || grid3.HasGearPath))
						{
							targetDirections.Add(vector5);
						}
					}
				}
			}
		}

		// Token: 0x06024233 RID: 148019 RVA: 0x00A3B684 File Offset: 0x00A39884
		private void BuildLinksForVertical(WuWaGoModel model, IReadOnlyList<Vector> openingDirections, List<Vector> targetDirections, bool requireGearPathOnNeighbor = false)
		{
			if (openingDirections.Count == 0)
			{
				return;
			}
			if (this.WallFrameInfo == null)
			{
				return;
			}
			float ownerOffsetX = this.WallFrameInfo.OwnerOffsetX;
			float ownerOffsetY = this.WallFrameInfo.OwnerOffsetY;
			int wallTangentX = this.WallFrameInfo.WallTangentX;
			int wallTangentY = this.WallFrameInfo.WallTangentY;
			foreach (Vector vector in openingDirections)
			{
				if (vector.Z != 0.0)
				{
					double z = vector.Z;
					if (!this.TryAddNeighborLink(model, (double)ownerOffsetX * z, (double)ownerOffsetY * z, z * 0.5, EGridShape.Horizontal, targetDirections, requireGearPathOnNeighbor))
					{
						this.TryAddNeighborLink(model, 0.0, 0.0, z, EGridShape.Vertical, targetDirections, requireGearPathOnNeighbor);
					}
				}
				else
				{
					double num = vector.X * (double)wallTangentX + vector.Y * (double)wallTangentY;
					if (num != 0.0)
					{
						double num2 = (double)wallTangentX * num;
						double num3 = (double)wallTangentY * num;
						if (!this.TryAddNeighborLink(model, num2 * 0.5 + (double)ownerOffsetX, num3 * 0.5 + (double)ownerOffsetY, 0.0, EGridShape.Vertical, targetDirections, requireGearPathOnNeighbor))
						{
							this.TryAddNeighborLink(model, num2, num3, 0.0, EGridShape.Vertical, targetDirections, requireGearPathOnNeighbor);
						}
					}
				}
			}
		}

		// Token: 0x06024234 RID: 148020 RVA: 0x00A3B7F8 File Offset: 0x00A399F8
		[return: Nullable(2)]
		private IWallFrame GetVerticalGridWallFrame(WuWaGoModel model, Vector coordinate)
		{
			if (this.AttachedCubeCoordinate != null)
			{
				IWallFrame wallFrame = this.BuildWallFrameFromAttachedCube(coordinate, this.AttachedCubeCoordinate);
				if (wallFrame != null)
				{
					return wallFrame;
				}
			}
			if (this.IsEntityGrid)
			{
				IWallFrame wallFrame2 = this.TryGetVerticalGridWallFrameByEntityRotator(coordinate);
				if (wallFrame2 != null)
				{
					return wallFrame2;
				}
			}
			return this.GetVerticalGridWallFrameByGeometry(model, coordinate);
		}

		// Token: 0x06024235 RID: 148021 RVA: 0x00A3B840 File Offset: 0x00A39A40
		[return: Nullable(2)]
		private IWallFrame BuildWallFrameFromAttachedCube(Vector coordinate, Vector cubeCoordinate)
		{
			double num = cubeCoordinate.X - coordinate.X;
			double num2 = cubeCoordinate.Y - coordinate.Y;
			bool flag = Math.Abs(num) <= 9.999999747378752E-05;
			bool flag2 = Math.Abs(num2) <= 9.999999747378752E-05;
			bool flag3 = !flag && flag2;
			bool flag4 = !flag2 && flag;
			if (flag3 == flag4)
			{
				return null;
			}
			int num3 = ((flag3 ? num : num2) > 0.0) ? 1 : -1;
			int num4 = (flag3 > false) ? 1 : 0;
			int num5 = (!flag3) ? 1 : 0;
			int wallTangentX = (!flag3) ? 1 : 0;
			int wallTangentY = (flag3 > false) ? 1 : 0;
			float ownerOffsetX = (float)num4 * 0.5f * (float)num3;
			float ownerOffsetY = (float)num5 * 0.5f * (float)num3;
			return new WallFrame
			{
				WallNormalX = num4,
				WallNormalY = num5,
				WallTangentX = wallTangentX,
				WallTangentY = wallTangentY,
				OwnerSign = num3,
				OwnerOffsetX = ownerOffsetX,
				OwnerOffsetY = ownerOffsetY
			};
		}

		// Token: 0x06024236 RID: 148022 RVA: 0x00A3B93C File Offset: 0x00A39B3C
		[return: Nullable(2)]
		private IWallFrame TryGetVerticalGridWallFrameByEntityRotator(Vector coordinate)
		{
			double num = coordinate.X - Math.Floor(coordinate.X);
			double num2 = coordinate.Y - Math.Floor(coordinate.Y);
			bool flag = num.Equals(0.5);
			bool flag2 = num2.Equals(0.5);
			if (flag == flag2)
			{
				return null;
			}
			Vector vector = Vector.Create();
			base.Rotator.Quaternion(null).GetAxisZ(vector);
			double num3 = flag ? vector.X : vector.Y;
			int num4 = (num3 > 0.0) ? -1 : ((num3 < 0.0) ? 1 : 0);
			if (num4 == 0)
			{
				return null;
			}
			int num5 = (flag > false) ? 1 : 0;
			int num6 = (!flag) ? 1 : 0;
			int wallTangentX = (!flag) ? 1 : 0;
			int wallTangentY = (flag > false) ? 1 : 0;
			float ownerOffsetX = (float)num5 * 0.5f * (float)num4;
			float ownerOffsetY = (float)num6 * 0.5f * (float)num4;
			return new WallFrame
			{
				WallNormalX = num5,
				WallNormalY = num6,
				WallTangentX = wallTangentX,
				WallTangentY = wallTangentY,
				OwnerSign = num4,
				OwnerOffsetX = ownerOffsetX,
				OwnerOffsetY = ownerOffsetY
			};
		}

		// Token: 0x06024237 RID: 148023 RVA: 0x00A3BA60 File Offset: 0x00A39C60
		[return: Nullable(2)]
		private IWallFrame GetVerticalGridWallFrameByGeometry(WuWaGoModel model, Vector coordinate)
		{
			double num = coordinate.X - Math.Floor(coordinate.X);
			double num2 = coordinate.Y - Math.Floor(coordinate.Y);
			bool flag = num.Equals(0.5);
			bool flag2 = num2.Equals(0.5);
			if (flag == flag2)
			{
				return null;
			}
			int num3 = (flag > false) ? 1 : 0;
			int num4 = (!flag) ? 1 : 0;
			int wallTangentX = (!flag) ? 1 : 0;
			int wallTangentY = (flag > false) ? 1 : 0;
			for (int i = 0; i < 16; i++)
			{
				double inZ = coordinate.Z + 0.5 + (double)i;
				foreach (int num5 in new int[]
				{
					1,
					-1
				})
				{
					double inX = coordinate.X + (double)((float)num3 * 0.5f * (float)num5);
					double inY = coordinate.Y + (double)((float)num4 * 0.5f * (float)num5);
					WuWaGoGrid.ProbeBufferTemp.Set(inX, inY, inZ);
					WuWaGoGrid grid = model.GetGrid(WuWaGoGrid.ProbeBufferTemp);
					if (grid != null && grid.GridShape == EGridShape.Horizontal)
					{
						return new WallFrame
						{
							WallNormalX = num3,
							WallNormalY = num4,
							WallTangentX = wallTangentX,
							WallTangentY = wallTangentY,
							OwnerSign = num5,
							OwnerOffsetX = (float)num3 * 0.5f * (float)num5,
							OwnerOffsetY = (float)num4 * 0.5f * (float)num5
						};
					}
				}
			}
			return null;
		}

		// Token: 0x06024238 RID: 148024 RVA: 0x00A3BBE0 File Offset: 0x00A39DE0
		private bool TryAddNeighborLink(WuWaGoModel model, double dx, double dy, double dz, EGridShape expectedShape, List<Vector> targetDirections, bool requireGearPathOnNeighbor = false)
		{
			WuWaGoGrid.ProbeBufferTemp.Set(base.Coordinate.X + dx, base.Coordinate.Y + dy, base.Coordinate.Z + dz);
			WuWaGoGrid grid = model.GetGrid(WuWaGoGrid.ProbeBufferTemp);
			if (grid == null || grid.GridShape != expectedShape)
			{
				return false;
			}
			if (!requireGearPathOnNeighbor || grid.HasGearPath)
			{
				targetDirections.Add(Vector.Create(dx, dy, dz));
			}
			return true;
		}

		// Token: 0x06024239 RID: 148025 RVA: 0x00A3BC58 File Offset: 0x00A39E58
		public Rotator GetLinkRotator()
		{
			float yaw = WuWaGoGrid.RotationTypeToAngle[this.GridLinkConfig.RotationType];
			Rotator rotator = Rotator.Create(0f, yaw, 0f);
			Quat quat = base.Rotator.Quaternion(null);
			Quat inQ = rotator.Quaternion(null);
			Quat quat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
			quat.Multiply(inQ, quat2);
			return quat2.Rotator(null);
		}

		// Token: 0x0602423A RID: 148026 RVA: 0x00A3BCD8 File Offset: 0x00A39ED8
		public void AddOccupiedUnitChangedListener(WuWaGoGridOccupiedUnitChangedListener listener)
		{
			this.OccupiedUnitChangedListeners.Add(listener);
		}

		// Token: 0x0602423B RID: 148027 RVA: 0x00A3BCE7 File Offset: 0x00A39EE7
		public void RemoveOccupiedUnitChangedListener(WuWaGoGridOccupiedUnitChangedListener listener)
		{
			this.OccupiedUnitChangedListeners.Remove(listener);
		}

		// Token: 0x0602423C RID: 148028 RVA: 0x00A3BCF8 File Offset: 0x00A39EF8
		public void SetOccupiedUnit(int? unitId = null)
		{
			int valueOrDefault = unitId.GetValueOrDefault();
			if (this.OccupiedUnit == valueOrDefault)
			{
				return;
			}
			int occupiedUnit = this.OccupiedUnit;
			this.OccupiedUnit = valueOrDefault;
			if (WuWaGoRollbackPreStates.IsSuppressed())
			{
				return;
			}
			foreach (WuWaGoGridOccupiedUnitChangedListener wuWaGoGridOccupiedUnitChangedListener in this.OccupiedUnitChangedListeners)
			{
				wuWaGoGridOccupiedUnitChangedListener(this, occupiedUnit, valueOrDefault);
			}
		}

		// Token: 0x0602423D RID: 148029 RVA: 0x00A3BD74 File Offset: 0x00A39F74
		public void RegisterMoveParticipant(IWuWaGoGridMoveParticipant participant)
		{
			this.MoveParticipants.Add(participant);
		}

		// Token: 0x0602423E RID: 148030 RVA: 0x00A3BD83 File Offset: 0x00A39F83
		public void UnregisterMoveParticipant(IWuWaGoGridMoveParticipant participant)
		{
			this.MoveParticipants.Remove(participant);
		}

		// Token: 0x0602423F RID: 148031 RVA: 0x00A3BD92 File Offset: 0x00A39F92
		public IReadOnlyList<IWuWaGoGridMoveParticipant> SnapshotMoveParticipants()
		{
			return new List<IWuWaGoGridMoveParticipant>(this.MoveParticipants);
		}

		// Token: 0x06024240 RID: 148032 RVA: 0x00A3BD9F File Offset: 0x00A39F9F
		public void SetEntity(int pbDataId, EWuWaGoEntityType type)
		{
			this.EntityPbDataIdValue = pbDataId;
			this.EntityTypeValue = new EWuWaGoEntityType?(type);
		}

		// Token: 0x06024241 RID: 148033 RVA: 0x00A3BDB4 File Offset: 0x00A39FB4
		public void AttachGameplayEntity(int pbDataId)
		{
			if (this.AttachedGameplayEntityPbDataIdsValue.Contains(pbDataId))
			{
				return;
			}
			this.AttachedGameplayEntityPbDataIdsValue.Add(pbDataId);
		}

		// Token: 0x04014257 RID: 82519
		private readonly List<Vector> OpeningDirections = new List<Vector>();

		// Token: 0x04014258 RID: 82520
		private readonly List<Vector> GearOpeningDirections = new List<Vector>();

		// Token: 0x04014259 RID: 82521
		private readonly List<Vector> LinkDirections = new List<Vector>();

		// Token: 0x0401425A RID: 82522
		private readonly List<Vector> GearLinkDirectionsInternal = new List<Vector>();

		// Token: 0x0401425B RID: 82523
		private bool HasGearPathInternal;

		// Token: 0x0401425C RID: 82524
		[Nullable(2)]
		private IWallFrame WallFrameInfo;

		// Token: 0x0401425D RID: 82525
		[StaticVariableRuleIgnore]
		private static readonly Vector ProbeBufferTemp = Vector.Create();

		// Token: 0x0401425E RID: 82526
		private const int MAX_CUBE_STACK_PROBE = 16;

		// Token: 0x0401425F RID: 82527
		private const float GRID_COORDINATE_EPSILON = 0.0001f;

		// Token: 0x04014260 RID: 82528
		private int OccupiedUnit;

		// Token: 0x04014261 RID: 82529
		private readonly HashSet<WuWaGoGridOccupiedUnitChangedListener> OccupiedUnitChangedListeners = new HashSet<WuWaGoGridOccupiedUnitChangedListener>();

		// Token: 0x04014262 RID: 82530
		private readonly HashSet<IWuWaGoGridMoveParticipant> MoveParticipants = new HashSet<IWuWaGoGridMoveParticipant>();

		// Token: 0x04014263 RID: 82531
		private int EntityPbDataIdValue;

		// Token: 0x04014264 RID: 82532
		private EWuWaGoEntityType? EntityTypeValue;

		// Token: 0x04014265 RID: 82533
		private readonly List<int> AttachedGameplayEntityPbDataIdsValue = new List<int>();

		// Token: 0x04014267 RID: 82535
		public EGridShape GridShape = gridShape;

		// Token: 0x04014268 RID: 82536
		public IWuWaGoGridLinkData GridLinkConfig = gridLinkConfig;

		// Token: 0x04014269 RID: 82537
		[Nullable(2)]
		public IWuWaGoGridLinkData GearLinkConfig = gearLinkConfig;

		// Token: 0x0401426A RID: 82538
		[Nullable(2)]
		public Vector AttachedCubeCoordinate = attachedCubeCoordinate;

		// Token: 0x0401426B RID: 82539
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EWuWaGoGridRotationType, float> RotationTypeToAngle = new Dictionary<EWuWaGoGridRotationType, float>
		{
			{
				EWuWaGoGridRotationType.Front,
				0f
			},
			{
				EWuWaGoGridRotationType.Right,
				90f
			},
			{
				EWuWaGoGridRotationType.Behind,
				180f
			},
			{
				EWuWaGoGridRotationType.Left,
				270f
			}
		};

		// Token: 0x0401426C RID: 82540
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EWuWaGoGridLinkType, IReadOnlyList<Vector>> BaseOpeningPatterns = new Dictionary<EWuWaGoGridLinkType, IReadOnlyList<Vector>>
		{
			{
				EWuWaGoGridLinkType.EmptyGrid,
				new List<Vector>()
			},
			{
				EWuWaGoGridLinkType.SingleLinkGrid,
				new List<Vector>
				{
					Vector.ForwardVectorProxy
				}
			},
			{
				EWuWaGoGridLinkType.RightAngleLinkGrid,
				new List<Vector>
				{
					Vector.ForwardVectorProxy,
					Vector.RightVectorProxy
				}
			},
			{
				EWuWaGoGridLinkType.StraightLinkGrid,
				new List<Vector>
				{
					Vector.ForwardVectorProxy,
					Vector.BackwardVectorProxy
				}
			},
			{
				EWuWaGoGridLinkType.ThreeLinkGrid,
				new List<Vector>
				{
					Vector.ForwardVectorProxy,
					Vector.RightVectorProxy,
					Vector.BackwardVectorProxy
				}
			},
			{
				EWuWaGoGridLinkType.AllLinkGrid,
				new List<Vector>
				{
					Vector.ForwardVectorProxy,
					Vector.RightVectorProxy,
					Vector.BackwardVectorProxy,
					Vector.LeftVectorProxy
				}
			}
		};
	}
}

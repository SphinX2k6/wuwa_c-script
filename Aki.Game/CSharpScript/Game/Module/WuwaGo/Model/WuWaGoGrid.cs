using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004738 RID: 18232
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGrid : WuWaGoBaseUnit
	{
		// Token: 0x0602FA4B RID: 195147 RVA: 0x00B0AEE0 File Offset: 0x00B090E0
		public WuWaGoGrid(Vector coordinate, Rotator rotator, EGridShape gridShape, IWuWaGoGridLinkData gridLinkConfig, [Nullable(2)] IWuWaGoGridLinkData gearLinkConfig = null, [Nullable(2)] Vector attachedCubeCoordinate = null) : base(coordinate, rotator)
		{
		}

		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x0602FA4C RID: 195148 RVA: 0x00B0AF61 File Offset: 0x00B09161
		public override bool Actionable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x0602FA4D RID: 195149 RVA: 0x00B0AF64 File Offset: 0x00B09164
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x0602FA4E RID: 195150 RVA: 0x00B0AF67 File Offset: 0x00B09167
		// (set) Token: 0x0602FA4F RID: 195151 RVA: 0x00B0AF6F File Offset: 0x00B0916F
		[Nullable(2)]
		public AActor Applique { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602FA50 RID: 195152 RVA: 0x00B0AF78 File Offset: 0x00B09178
		[NullableContext(2)]
		protected override AActor GetActorRaw()
		{
			return CharacterController.Instance.GetActor(this.EntityHandle);
		}

		// Token: 0x0602FA51 RID: 195153 RVA: 0x00B0AF8A File Offset: 0x00B0918A
		public override IRollbackCapture CaptureRollback()
		{
			return new GridRollbackCapture(this);
		}

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x0602FA52 RID: 195154 RVA: 0x00B0AF92 File Offset: 0x00B09192
		[Nullable(2)]
		public EntityHandle EntityHandle
		{
			[NullableContext(2)]
			get
			{
				return CreatureModel.Instance.GetEntityByPbDataId(this.EntityPbDataIdValue);
			}
		}

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x0602FA53 RID: 195155 RVA: 0x00B0AFA4 File Offset: 0x00B091A4
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

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x0602FA54 RID: 195156 RVA: 0x00B0AFC2 File Offset: 0x00B091C2
		public bool IsOccupied
		{
			get
			{
				return this.OccupiedUnit != 0;
			}
		}

		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x0602FA55 RID: 195157 RVA: 0x00B0AFCD File Offset: 0x00B091CD
		public int OccupiedUnitId
		{
			get
			{
				return this.OccupiedUnit;
			}
		}

		// Token: 0x17007707 RID: 30471
		// (get) Token: 0x0602FA56 RID: 195158 RVA: 0x00B0AFD5 File Offset: 0x00B091D5
		public bool IsEntityGrid
		{
			get
			{
				return this.EntityPbDataIdValue != 0;
			}
		}

		// Token: 0x17007708 RID: 30472
		// (get) Token: 0x0602FA57 RID: 195159 RVA: 0x00B0AFE0 File Offset: 0x00B091E0
		public int EntityPbDataId
		{
			get
			{
				return this.EntityPbDataIdValue;
			}
		}

		// Token: 0x17007709 RID: 30473
		// (get) Token: 0x0602FA58 RID: 195160 RVA: 0x00B0AFE8 File Offset: 0x00B091E8
		public EWuWaGoEntityType? EntityType
		{
			get
			{
				return this.EntityTypeValue;
			}
		}

		// Token: 0x1700770A RID: 30474
		// (get) Token: 0x0602FA59 RID: 195161 RVA: 0x00B0AFF0 File Offset: 0x00B091F0
		public bool HasAttachedGameplayEntity
		{
			get
			{
				return this.AttachedGameplayEntityPbDataIdsValue.Count > 0;
			}
		}

		// Token: 0x1700770B RID: 30475
		// (get) Token: 0x0602FA5A RID: 195162 RVA: 0x00B0B000 File Offset: 0x00B09200
		public IReadOnlyList<int> AttachedGameplayEntityPbDataIds
		{
			get
			{
				return this.AttachedGameplayEntityPbDataIdsValue;
			}
		}

		// Token: 0x1700770C RID: 30476
		// (get) Token: 0x0602FA5B RID: 195163 RVA: 0x00B0B008 File Offset: 0x00B09208
		public bool IsEndPoint
		{
			get
			{
				return this.EntityTypeValue.GetValueOrDefault() == EWuWaGoEntityType.EndGrid;
			}
		}

		// Token: 0x1700770D RID: 30477
		// (get) Token: 0x0602FA5C RID: 195164 RVA: 0x00B0B018 File Offset: 0x00B09218
		public IReadOnlyList<Vector> LinkedDirections
		{
			get
			{
				return this.LinkDirections;
			}
		}

		// Token: 0x1700770E RID: 30478
		// (get) Token: 0x0602FA5D RID: 195165 RVA: 0x00B0B020 File Offset: 0x00B09220
		public IReadOnlyList<Vector> GearLinkDirections
		{
			get
			{
				return this.GearLinkDirectionsInternal;
			}
		}

		// Token: 0x1700770F RID: 30479
		// (get) Token: 0x0602FA5E RID: 195166 RVA: 0x00B0B028 File Offset: 0x00B09228
		public bool HasGearPath
		{
			get
			{
				return this.HasGearPathInternal;
			}
		}

		// Token: 0x17007710 RID: 30480
		// (get) Token: 0x0602FA5F RID: 195167 RVA: 0x00B0B030 File Offset: 0x00B09230
		[Nullable(2)]
		public IWallFrame WallFrame
		{
			[NullableContext(2)]
			get
			{
				return this.WallFrameInfo;
			}
		}

		// Token: 0x0602FA60 RID: 195168 RVA: 0x00B0B038 File Offset: 0x00B09238
		public bool IsBidirectionalLinkedTo(WuWaGoGrid other)
		{
			double dx = other.Coordinate.X - base.Coordinate.X;
			double dy = other.Coordinate.Y - base.Coordinate.Y;
			double dz = other.Coordinate.Z - base.Coordinate.Z;
			return this.LinkDirections.Any((Vector d) => d.X.Equals(dx) && d.Y.Equals(dy) && d.Z.Equals(dz)) && other.LinkDirections.Any((Vector d) => d.X.Equals(-dx) && d.Y.Equals(-dy) && d.Z.Equals(-dz));
		}

		// Token: 0x0602FA61 RID: 195169 RVA: 0x00B0B0D4 File Offset: 0x00B092D4
		public void InitOpeningDirections()
		{
			this.InitRotatedOpeningDirections(this.GridLinkConfig.GridLinkType, this.OpeningDirections);
			IWuWaGoGridLinkData gearLinkConfig = this.GearLinkConfig;
			this.HasGearPathInternal = this.InitBaseOpeningDirections((gearLinkConfig != null) ? new EWuWaGoGridLinkType?(gearLinkConfig.GridLinkType) : null, this.GearOpeningDirections);
		}

		// Token: 0x0602FA62 RID: 195170 RVA: 0x00B0B12C File Offset: 0x00B0932C
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

		// Token: 0x0602FA63 RID: 195171 RVA: 0x00B0B1E4 File Offset: 0x00B093E4
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

		// Token: 0x0602FA64 RID: 195172 RVA: 0x00B0B2AC File Offset: 0x00B094AC
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

		// Token: 0x0602FA65 RID: 195173 RVA: 0x00B0B2F0 File Offset: 0x00B094F0
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

		// Token: 0x0602FA66 RID: 195174 RVA: 0x00B0B3BC File Offset: 0x00B095BC
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

		// Token: 0x0602FA67 RID: 195175 RVA: 0x00B0B400 File Offset: 0x00B09600
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

		// Token: 0x0602FA68 RID: 195176 RVA: 0x00B0B530 File Offset: 0x00B09730
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

		// Token: 0x0602FA69 RID: 195177 RVA: 0x00B0B6B8 File Offset: 0x00B098B8
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

		// Token: 0x0602FA6A RID: 195178 RVA: 0x00B0B82C File Offset: 0x00B09A2C
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

		// Token: 0x0602FA6B RID: 195179 RVA: 0x00B0B874 File Offset: 0x00B09A74
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

		// Token: 0x0602FA6C RID: 195180 RVA: 0x00B0B970 File Offset: 0x00B09B70
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

		// Token: 0x0602FA6D RID: 195181 RVA: 0x00B0BA94 File Offset: 0x00B09C94
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

		// Token: 0x0602FA6E RID: 195182 RVA: 0x00B0BC14 File Offset: 0x00B09E14
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

		// Token: 0x0602FA6F RID: 195183 RVA: 0x00B0BC8C File Offset: 0x00B09E8C
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

		// Token: 0x0602FA70 RID: 195184 RVA: 0x00B0BD0C File Offset: 0x00B09F0C
		public void AddOccupiedUnitChangedListener(WuWaGoGridOccupiedUnitChangedListener listener)
		{
			this.OccupiedUnitChangedListeners.Add(listener);
		}

		// Token: 0x0602FA71 RID: 195185 RVA: 0x00B0BD1B File Offset: 0x00B09F1B
		public void RemoveOccupiedUnitChangedListener(WuWaGoGridOccupiedUnitChangedListener listener)
		{
			this.OccupiedUnitChangedListeners.Remove(listener);
		}

		// Token: 0x0602FA72 RID: 195186 RVA: 0x00B0BD2C File Offset: 0x00B09F2C
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

		// Token: 0x0602FA73 RID: 195187 RVA: 0x00B0BDA8 File Offset: 0x00B09FA8
		public void RegisterMoveParticipant(IWuWaGoGridMoveParticipant participant)
		{
			this.MoveParticipants.Add(participant);
		}

		// Token: 0x0602FA74 RID: 195188 RVA: 0x00B0BDB7 File Offset: 0x00B09FB7
		public void UnregisterMoveParticipant(IWuWaGoGridMoveParticipant participant)
		{
			this.MoveParticipants.Remove(participant);
		}

		// Token: 0x0602FA75 RID: 195189 RVA: 0x00B0BDC6 File Offset: 0x00B09FC6
		public IReadOnlyList<IWuWaGoGridMoveParticipant> SnapshotMoveParticipants()
		{
			return new List<IWuWaGoGridMoveParticipant>(this.MoveParticipants);
		}

		// Token: 0x0602FA76 RID: 195190 RVA: 0x00B0BDD3 File Offset: 0x00B09FD3
		public void SetEntity(int pbDataId, EWuWaGoEntityType type)
		{
			this.EntityPbDataIdValue = pbDataId;
			this.EntityTypeValue = new EWuWaGoEntityType?(type);
		}

		// Token: 0x0602FA77 RID: 195191 RVA: 0x00B0BDE8 File Offset: 0x00B09FE8
		public void AttachGameplayEntity(int pbDataId)
		{
			if (this.AttachedGameplayEntityPbDataIdsValue.Contains(pbDataId))
			{
				return;
			}
			this.AttachedGameplayEntityPbDataIdsValue.Add(pbDataId);
		}

		// Token: 0x04019BA7 RID: 105383
		private readonly List<Vector> OpeningDirections = new List<Vector>();

		// Token: 0x04019BA8 RID: 105384
		private readonly List<Vector> GearOpeningDirections = new List<Vector>();

		// Token: 0x04019BA9 RID: 105385
		private readonly List<Vector> LinkDirections = new List<Vector>();

		// Token: 0x04019BAA RID: 105386
		private readonly List<Vector> GearLinkDirectionsInternal = new List<Vector>();

		// Token: 0x04019BAB RID: 105387
		private bool HasGearPathInternal;

		// Token: 0x04019BAC RID: 105388
		[Nullable(2)]
		private IWallFrame WallFrameInfo;

		// Token: 0x04019BAD RID: 105389
		[StaticVariableRuleIgnore]
		private static readonly Vector ProbeBufferTemp = Vector.Create();

		// Token: 0x04019BAE RID: 105390
		private const int MAX_CUBE_STACK_PROBE = 16;

		// Token: 0x04019BAF RID: 105391
		private const float GRID_COORDINATE_EPSILON = 0.0001f;

		// Token: 0x04019BB0 RID: 105392
		private int OccupiedUnit;

		// Token: 0x04019BB1 RID: 105393
		private readonly HashSet<WuWaGoGridOccupiedUnitChangedListener> OccupiedUnitChangedListeners = new HashSet<WuWaGoGridOccupiedUnitChangedListener>();

		// Token: 0x04019BB2 RID: 105394
		private readonly HashSet<IWuWaGoGridMoveParticipant> MoveParticipants = new HashSet<IWuWaGoGridMoveParticipant>();

		// Token: 0x04019BB3 RID: 105395
		private int EntityPbDataIdValue;

		// Token: 0x04019BB4 RID: 105396
		private EWuWaGoEntityType? EntityTypeValue;

		// Token: 0x04019BB5 RID: 105397
		private readonly List<int> AttachedGameplayEntityPbDataIdsValue = new List<int>();

		// Token: 0x04019BB7 RID: 105399
		public EGridShape GridShape = gridShape;

		// Token: 0x04019BB8 RID: 105400
		public IWuWaGoGridLinkData GridLinkConfig = gridLinkConfig;

		// Token: 0x04019BB9 RID: 105401
		[Nullable(2)]
		public IWuWaGoGridLinkData GearLinkConfig = gearLinkConfig;

		// Token: 0x04019BBA RID: 105402
		[Nullable(2)]
		public Vector AttachedCubeCoordinate = attachedCubeCoordinate;

		// Token: 0x04019BBB RID: 105403
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

		// Token: 0x04019BBC RID: 105404
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

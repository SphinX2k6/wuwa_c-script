using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589D RID: 22685
	public struct ISceneActorRefComponent : IFlatbufferObject
	{
		// Token: 0x1700A9C9 RID: 43465
		// (get) Token: 0x060263FC RID: 156668 RVA: 0x0054593D File Offset: 0x00543B3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263FD RID: 156669 RVA: 0x0054594A File Offset: 0x00543B4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263FE RID: 156670 RVA: 0x00545954 File Offset: 0x00543B54
		public static ISceneActorRefComponent GetRootAsISceneActorRefComponent(ByteBuffer _bb)
		{
			return ISceneActorRefComponent.GetRootAsISceneActorRefComponent(_bb, default(ISceneActorRefComponent));
		}

		// Token: 0x060263FF RID: 156671 RVA: 0x00545970 File Offset: 0x00543B70
		public static ISceneActorRefComponent GetRootAsISceneActorRefComponent(ByteBuffer _bb, ISceneActorRefComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026400 RID: 156672 RVA: 0x0054598D File Offset: 0x00543B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026401 RID: 156673 RVA: 0x0054599C File Offset: 0x00543B9C
		public ISceneActorRefComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9CA RID: 43466
		// (get) Token: 0x06026402 RID: 156674 RVA: 0x005459AC File Offset: 0x00543BAC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026403 RID: 156675 RVA: 0x005459EC File Offset: 0x00543BEC
		public ISceneActorRefGroup? ActorRefGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneActorRefGroup?(default(ISceneActorRefGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9CB RID: 43467
		// (get) Token: 0x06026404 RID: 156676 RVA: 0x00545A4C File Offset: 0x00543C4C
		public int ActorRefGroupsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026405 RID: 156677 RVA: 0x00545A78 File Offset: 0x00543C78
		public IActorRef? VolumesRef(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9CC RID: 43468
		// (get) Token: 0x06026406 RID: 156678 RVA: 0x00545AD8 File Offset: 0x00543CD8
		public int VolumesRefLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A9CD RID: 43469
		// (get) Token: 0x06026407 RID: 156679 RVA: 0x00545B04 File Offset: 0x00543D04
		public ILiftFloorSeqMarkConfig? LiftFloorSeqMarks
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ILiftFloorSeqMarkConfig?(default(ILiftFloorSeqMarkConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026408 RID: 156680 RVA: 0x00545B64 File Offset: 0x00543D64
		public IActorRef? ZoneFollowCameraControllerRef(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9CE RID: 43470
		// (get) Token: 0x06026409 RID: 156681 RVA: 0x00545BC8 File Offset: 0x00543DC8
		public int ZoneFollowCameraControllerRefLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602640A RID: 156682 RVA: 0x00545BF4 File Offset: 0x00543DF4
		public IRefactorActorRef2Entities? RefactorActorRef2Entities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IRefactorActorRef2Entities?(default(IRefactorActorRef2Entities).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9CF RID: 43471
		// (get) Token: 0x0602640B RID: 156683 RVA: 0x00545C58 File Offset: 0x00543E58
		public int RefactorActorRef2EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602640C RID: 156684 RVA: 0x00545C84 File Offset: 0x00543E84
		public IActorRef? NoiseWallRefs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9D0 RID: 43472
		// (get) Token: 0x0602640D RID: 156685 RVA: 0x00545CE8 File Offset: 0x00543EE8
		public int NoiseWallRefsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A9D1 RID: 43473
		// (get) Token: 0x0602640E RID: 156686 RVA: 0x00545D14 File Offset: 0x00543F14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602640F RID: 156687 RVA: 0x00545D54 File Offset: 0x00543F54
		public static Offset<ISceneActorRefComponent> CreateISceneActorRefComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ActorRefGroupsOffset = default(VectorOffset), VectorOffset VolumesRefOffset = default(VectorOffset), Offset<ILiftFloorSeqMarkConfig> LiftFloorSeqMarksOffset = default(Offset<ILiftFloorSeqMarkConfig>), VectorOffset ZoneFollowCameraControllerRefOffset = default(VectorOffset), VectorOffset RefactorActorRef2EntitiesOffset = default(VectorOffset), VectorOffset NoiseWallRefsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			ISceneActorRefComponent.AddNoiseWallRefs(builder, NoiseWallRefsOffset);
			ISceneActorRefComponent.AddRefactorActorRef2Entities(builder, RefactorActorRef2EntitiesOffset);
			ISceneActorRefComponent.AddZoneFollowCameraControllerRef(builder, ZoneFollowCameraControllerRefOffset);
			ISceneActorRefComponent.AddLiftFloorSeqMarks(builder, LiftFloorSeqMarksOffset);
			ISceneActorRefComponent.AddVolumesRef(builder, VolumesRefOffset);
			ISceneActorRefComponent.AddActorRefGroups(builder, ActorRefGroupsOffset);
			ISceneActorRefComponent.AddNullMask(builder, NullMask);
			ISceneActorRefComponent.AddDisabled(builder, Disabled);
			return ISceneActorRefComponent.EndISceneActorRefComponent(builder);
		}

		// Token: 0x06026410 RID: 156688 RVA: 0x00545DAB File Offset: 0x00543FAB
		public static void StartISceneActorRefComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06026411 RID: 156689 RVA: 0x00545DB4 File Offset: 0x00543FB4
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026412 RID: 156690 RVA: 0x00545DBF File Offset: 0x00543FBF
		public static void AddActorRefGroups(FlatBufferBuilder builder, VectorOffset actorRefGroupsOffset)
		{
			builder.AddOffset(1, actorRefGroupsOffset.Value, 0);
		}

		// Token: 0x06026413 RID: 156691 RVA: 0x00545DD0 File Offset: 0x00543FD0
		public static VectorOffset CreateActorRefGroupsVector(FlatBufferBuilder builder, Offset<ISceneActorRefGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026414 RID: 156692 RVA: 0x00545E10 File Offset: 0x00544010
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISceneActorRefGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneActorRefGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026415 RID: 156693 RVA: 0x00545E2A File Offset: 0x0054402A
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneActorRefGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneActorRefGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026416 RID: 156694 RVA: 0x00545E48 File Offset: 0x00544048
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneActorRefGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026417 RID: 156695 RVA: 0x00545E61 File Offset: 0x00544061
		public static void StartActorRefGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026418 RID: 156696 RVA: 0x00545E6C File Offset: 0x0054406C
		public static void AddVolumesRef(FlatBufferBuilder builder, VectorOffset volumesRefOffset)
		{
			builder.AddOffset(2, volumesRefOffset.Value, 0);
		}

		// Token: 0x06026419 RID: 156697 RVA: 0x00545E7C File Offset: 0x0054407C
		public static VectorOffset CreateVolumesRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602641A RID: 156698 RVA: 0x00545EBC File Offset: 0x005440BC
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602641B RID: 156699 RVA: 0x00545ED6 File Offset: 0x005440D6
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602641C RID: 156700 RVA: 0x00545EF4 File Offset: 0x005440F4
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602641D RID: 156701 RVA: 0x00545F0D File Offset: 0x0054410D
		public static void StartVolumesRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602641E RID: 156702 RVA: 0x00545F18 File Offset: 0x00544118
		public static void AddLiftFloorSeqMarks(FlatBufferBuilder builder, Offset<ILiftFloorSeqMarkConfig> liftFloorSeqMarksOffset)
		{
			builder.AddOffset(3, liftFloorSeqMarksOffset.Value, 0);
		}

		// Token: 0x0602641F RID: 156703 RVA: 0x00545F28 File Offset: 0x00544128
		public static void AddZoneFollowCameraControllerRef(FlatBufferBuilder builder, VectorOffset zoneFollowCameraControllerRefOffset)
		{
			builder.AddOffset(4, zoneFollowCameraControllerRefOffset.Value, 0);
		}

		// Token: 0x06026420 RID: 156704 RVA: 0x00545F38 File Offset: 0x00544138
		public static VectorOffset CreateZoneFollowCameraControllerRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026421 RID: 156705 RVA: 0x00545F78 File Offset: 0x00544178
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026422 RID: 156706 RVA: 0x00545F92 File Offset: 0x00544192
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026423 RID: 156707 RVA: 0x00545FB0 File Offset: 0x005441B0
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026424 RID: 156708 RVA: 0x00545FC9 File Offset: 0x005441C9
		public static void StartZoneFollowCameraControllerRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026425 RID: 156709 RVA: 0x00545FD4 File Offset: 0x005441D4
		public static void AddRefactorActorRef2Entities(FlatBufferBuilder builder, VectorOffset refactorActorRef2EntitiesOffset)
		{
			builder.AddOffset(5, refactorActorRef2EntitiesOffset.Value, 0);
		}

		// Token: 0x06026426 RID: 156710 RVA: 0x00545FE4 File Offset: 0x005441E4
		public static VectorOffset CreateRefactorActorRef2EntitiesVector(FlatBufferBuilder builder, Offset<IRefactorActorRef2Entities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026427 RID: 156711 RVA: 0x00546024 File Offset: 0x00544224
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, Offset<IRefactorActorRef2Entities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRefactorActorRef2Entities>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026428 RID: 156712 RVA: 0x0054603E File Offset: 0x0054423E
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRefactorActorRef2Entities>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRefactorActorRef2Entities>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026429 RID: 156713 RVA: 0x0054605C File Offset: 0x0054425C
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRefactorActorRef2Entities>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602642A RID: 156714 RVA: 0x00546075 File Offset: 0x00544275
		public static void StartRefactorActorRef2EntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602642B RID: 156715 RVA: 0x00546080 File Offset: 0x00544280
		public static void AddNoiseWallRefs(FlatBufferBuilder builder, VectorOffset noiseWallRefsOffset)
		{
			builder.AddOffset(6, noiseWallRefsOffset.Value, 0);
		}

		// Token: 0x0602642C RID: 156716 RVA: 0x00546090 File Offset: 0x00544290
		public static VectorOffset CreateNoiseWallRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602642D RID: 156717 RVA: 0x005460D0 File Offset: 0x005442D0
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602642E RID: 156718 RVA: 0x005460EA File Offset: 0x005442EA
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602642F RID: 156719 RVA: 0x00546108 File Offset: 0x00544308
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026430 RID: 156720 RVA: 0x00546121 File Offset: 0x00544321
		public static void StartNoiseWallRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026431 RID: 156721 RVA: 0x0054612C File Offset: 0x0054432C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06026432 RID: 156722 RVA: 0x00546137 File Offset: 0x00544337
		public static Offset<ISceneActorRefComponent> EndISceneActorRefComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorRefComponent>(builder.EndTable());
		}

		// Token: 0x06026433 RID: 156723 RVA: 0x00546144 File Offset: 0x00544344
		public ISceneActorRefComponentT UnPack()
		{
			ISceneActorRefComponentT sceneActorRefComponentT = new ISceneActorRefComponentT();
			this.UnPackTo(sceneActorRefComponentT);
			return sceneActorRefComponentT;
		}

		// Token: 0x06026434 RID: 156724 RVA: 0x00546160 File Offset: 0x00544360
		public void UnPackTo(ISceneActorRefComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ActorRefGroups = new List<ISceneActorRefGroupT>();
			for (int i = 0; i < this.ActorRefGroupsLength; i++)
			{
				_o.ActorRefGroups.Add((this.ActorRefGroups(i) != null) ? this.ActorRefGroups(i).Value.UnPack() : null);
			}
			_o.VolumesRef = new List<IActorRefT>();
			for (int j = 0; j < this.VolumesRefLength; j++)
			{
				_o.VolumesRef.Add((this.VolumesRef(j) != null) ? this.VolumesRef(j).Value.UnPack() : null);
			}
			_o.LiftFloorSeqMarks = ((this.LiftFloorSeqMarks != null) ? this.LiftFloorSeqMarks.Value.UnPack() : null);
			_o.ZoneFollowCameraControllerRef = new List<IActorRefT>();
			for (int k = 0; k < this.ZoneFollowCameraControllerRefLength; k++)
			{
				_o.ZoneFollowCameraControllerRef.Add((this.ZoneFollowCameraControllerRef(k) != null) ? this.ZoneFollowCameraControllerRef(k).Value.UnPack() : null);
			}
			_o.RefactorActorRef2Entities = new List<IRefactorActorRef2EntitiesT>();
			for (int l = 0; l < this.RefactorActorRef2EntitiesLength; l++)
			{
				_o.RefactorActorRef2Entities.Add((this.RefactorActorRef2Entities(l) != null) ? this.RefactorActorRef2Entities(l).Value.UnPack() : null);
			}
			_o.NoiseWallRefs = new List<IActorRefT>();
			for (int m = 0; m < this.NoiseWallRefsLength; m++)
			{
				_o.NoiseWallRefs.Add((this.NoiseWallRefs(m) != null) ? this.NoiseWallRefs(m).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026435 RID: 156725 RVA: 0x00546370 File Offset: 0x00544570
		public static Offset<ISceneActorRefComponent> Pack(FlatBufferBuilder builder, ISceneActorRefComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorRefComponent>);
			}
			VectorOffset actorRefGroupsOffset = default(VectorOffset);
			if (_o.ActorRefGroups != null)
			{
				Offset<ISceneActorRefGroup>[] array = new Offset<ISceneActorRefGroup>[_o.ActorRefGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneActorRefGroup.Pack(builder, _o.ActorRefGroups[i]);
				}
				actorRefGroupsOffset = ISceneActorRefComponent.CreateActorRefGroupsVector(builder, array);
			}
			VectorOffset volumesRefOffset = default(VectorOffset);
			if (_o.VolumesRef != null)
			{
				Offset<IActorRef>[] array2 = new Offset<IActorRef>[_o.VolumesRef.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActorRef.Pack(builder, _o.VolumesRef[j]);
				}
				volumesRefOffset = ISceneActorRefComponent.CreateVolumesRefVector(builder, array2);
			}
			Offset<ILiftFloorSeqMarkConfig> liftFloorSeqMarksOffset = (_o.LiftFloorSeqMarks == null) ? default(Offset<ILiftFloorSeqMarkConfig>) : ILiftFloorSeqMarkConfig.Pack(builder, _o.LiftFloorSeqMarks);
			VectorOffset zoneFollowCameraControllerRefOffset = default(VectorOffset);
			if (_o.ZoneFollowCameraControllerRef != null)
			{
				Offset<IActorRef>[] array3 = new Offset<IActorRef>[_o.ZoneFollowCameraControllerRef.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActorRef.Pack(builder, _o.ZoneFollowCameraControllerRef[k]);
				}
				zoneFollowCameraControllerRefOffset = ISceneActorRefComponent.CreateZoneFollowCameraControllerRefVector(builder, array3);
			}
			VectorOffset refactorActorRef2EntitiesOffset = default(VectorOffset);
			if (_o.RefactorActorRef2Entities != null)
			{
				Offset<IRefactorActorRef2Entities>[] array4 = new Offset<IRefactorActorRef2Entities>[_o.RefactorActorRef2Entities.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IRefactorActorRef2Entities.Pack(builder, _o.RefactorActorRef2Entities[l]);
				}
				refactorActorRef2EntitiesOffset = ISceneActorRefComponent.CreateRefactorActorRef2EntitiesVector(builder, array4);
			}
			VectorOffset noiseWallRefsOffset = default(VectorOffset);
			if (_o.NoiseWallRefs != null)
			{
				Offset<IActorRef>[] array5 = new Offset<IActorRef>[_o.NoiseWallRefs.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorRef.Pack(builder, _o.NoiseWallRefs[m]);
				}
				noiseWallRefsOffset = ISceneActorRefComponent.CreateNoiseWallRefsVector(builder, array5);
			}
			return ISceneActorRefComponent.CreateISceneActorRefComponent(builder, _o.Disabled, actorRefGroupsOffset, volumesRefOffset, liftFloorSeqMarksOffset, zoneFollowCameraControllerRefOffset, refactorActorRef2EntitiesOffset, noiseWallRefsOffset, _o.NullMask);
		}

		// Token: 0x0400EDFD RID: 60925
		private Table __p;
	}
}

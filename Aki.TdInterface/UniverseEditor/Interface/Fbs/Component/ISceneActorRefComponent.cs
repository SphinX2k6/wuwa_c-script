using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAA RID: 24234
	public struct ISceneActorRefComponent : IFlatbufferObject
	{
		// Token: 0x1700B2F9 RID: 45817
		// (get) Token: 0x0602895E RID: 166238 RVA: 0x0058C489 File Offset: 0x0058A689
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602895F RID: 166239 RVA: 0x0058C496 File Offset: 0x0058A696
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028960 RID: 166240 RVA: 0x0058C4A0 File Offset: 0x0058A6A0
		public static ISceneActorRefComponent GetRootAsISceneActorRefComponent(ByteBuffer _bb)
		{
			return ISceneActorRefComponent.GetRootAsISceneActorRefComponent(_bb, default(ISceneActorRefComponent));
		}

		// Token: 0x06028961 RID: 166241 RVA: 0x0058C4BC File Offset: 0x0058A6BC
		public static ISceneActorRefComponent GetRootAsISceneActorRefComponent(ByteBuffer _bb, ISceneActorRefComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028962 RID: 166242 RVA: 0x0058C4D9 File Offset: 0x0058A6D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028963 RID: 166243 RVA: 0x0058C4E8 File Offset: 0x0058A6E8
		public ISceneActorRefComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2FA RID: 45818
		// (get) Token: 0x06028964 RID: 166244 RVA: 0x0058C4F8 File Offset: 0x0058A6F8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06028965 RID: 166245 RVA: 0x0058C538 File Offset: 0x0058A738
		public ISceneActorRefGroup? ActorRefGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneActorRefGroup?(default(ISceneActorRefGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B2FB RID: 45819
		// (get) Token: 0x06028966 RID: 166246 RVA: 0x0058C598 File Offset: 0x0058A798
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

		// Token: 0x06028967 RID: 166247 RVA: 0x0058C5C4 File Offset: 0x0058A7C4
		public IActorRef? VolumesRef(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B2FC RID: 45820
		// (get) Token: 0x06028968 RID: 166248 RVA: 0x0058C624 File Offset: 0x0058A824
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

		// Token: 0x1700B2FD RID: 45821
		// (get) Token: 0x06028969 RID: 166249 RVA: 0x0058C650 File Offset: 0x0058A850
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

		// Token: 0x0602896A RID: 166250 RVA: 0x0058C6B0 File Offset: 0x0058A8B0
		public IActorRef? ZoneFollowCameraControllerRef(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B2FE RID: 45822
		// (get) Token: 0x0602896B RID: 166251 RVA: 0x0058C714 File Offset: 0x0058A914
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

		// Token: 0x0602896C RID: 166252 RVA: 0x0058C740 File Offset: 0x0058A940
		public IRefactorActorRef2Entities? RefactorActorRef2Entities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IRefactorActorRef2Entities?(default(IRefactorActorRef2Entities).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B2FF RID: 45823
		// (get) Token: 0x0602896D RID: 166253 RVA: 0x0058C7A4 File Offset: 0x0058A9A4
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

		// Token: 0x0602896E RID: 166254 RVA: 0x0058C7D0 File Offset: 0x0058A9D0
		public IActorRef? NoiseWallRefs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B300 RID: 45824
		// (get) Token: 0x0602896F RID: 166255 RVA: 0x0058C834 File Offset: 0x0058AA34
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

		// Token: 0x1700B301 RID: 45825
		// (get) Token: 0x06028970 RID: 166256 RVA: 0x0058C860 File Offset: 0x0058AA60
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

		// Token: 0x06028971 RID: 166257 RVA: 0x0058C8A0 File Offset: 0x0058AAA0
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

		// Token: 0x06028972 RID: 166258 RVA: 0x0058C8F7 File Offset: 0x0058AAF7
		public static void StartISceneActorRefComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06028973 RID: 166259 RVA: 0x0058C900 File Offset: 0x0058AB00
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028974 RID: 166260 RVA: 0x0058C90B File Offset: 0x0058AB0B
		public static void AddActorRefGroups(FlatBufferBuilder builder, VectorOffset actorRefGroupsOffset)
		{
			builder.AddOffset(1, actorRefGroupsOffset.Value, 0);
		}

		// Token: 0x06028975 RID: 166261 RVA: 0x0058C91C File Offset: 0x0058AB1C
		public static VectorOffset CreateActorRefGroupsVector(FlatBufferBuilder builder, Offset<ISceneActorRefGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028976 RID: 166262 RVA: 0x0058C95C File Offset: 0x0058AB5C
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISceneActorRefGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneActorRefGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028977 RID: 166263 RVA: 0x0058C976 File Offset: 0x0058AB76
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneActorRefGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneActorRefGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028978 RID: 166264 RVA: 0x0058C994 File Offset: 0x0058AB94
		public static VectorOffset CreateActorRefGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneActorRefGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028979 RID: 166265 RVA: 0x0058C9AD File Offset: 0x0058ABAD
		public static void StartActorRefGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602897A RID: 166266 RVA: 0x0058C9B8 File Offset: 0x0058ABB8
		public static void AddVolumesRef(FlatBufferBuilder builder, VectorOffset volumesRefOffset)
		{
			builder.AddOffset(2, volumesRefOffset.Value, 0);
		}

		// Token: 0x0602897B RID: 166267 RVA: 0x0058C9C8 File Offset: 0x0058ABC8
		public static VectorOffset CreateVolumesRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602897C RID: 166268 RVA: 0x0058CA08 File Offset: 0x0058AC08
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602897D RID: 166269 RVA: 0x0058CA22 File Offset: 0x0058AC22
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602897E RID: 166270 RVA: 0x0058CA40 File Offset: 0x0058AC40
		public static VectorOffset CreateVolumesRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602897F RID: 166271 RVA: 0x0058CA59 File Offset: 0x0058AC59
		public static void StartVolumesRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028980 RID: 166272 RVA: 0x0058CA64 File Offset: 0x0058AC64
		public static void AddLiftFloorSeqMarks(FlatBufferBuilder builder, Offset<ILiftFloorSeqMarkConfig> liftFloorSeqMarksOffset)
		{
			builder.AddOffset(3, liftFloorSeqMarksOffset.Value, 0);
		}

		// Token: 0x06028981 RID: 166273 RVA: 0x0058CA74 File Offset: 0x0058AC74
		public static void AddZoneFollowCameraControllerRef(FlatBufferBuilder builder, VectorOffset zoneFollowCameraControllerRefOffset)
		{
			builder.AddOffset(4, zoneFollowCameraControllerRefOffset.Value, 0);
		}

		// Token: 0x06028982 RID: 166274 RVA: 0x0058CA84 File Offset: 0x0058AC84
		public static VectorOffset CreateZoneFollowCameraControllerRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028983 RID: 166275 RVA: 0x0058CAC4 File Offset: 0x0058ACC4
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028984 RID: 166276 RVA: 0x0058CADE File Offset: 0x0058ACDE
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028985 RID: 166277 RVA: 0x0058CAFC File Offset: 0x0058ACFC
		public static VectorOffset CreateZoneFollowCameraControllerRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028986 RID: 166278 RVA: 0x0058CB15 File Offset: 0x0058AD15
		public static void StartZoneFollowCameraControllerRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028987 RID: 166279 RVA: 0x0058CB20 File Offset: 0x0058AD20
		public static void AddRefactorActorRef2Entities(FlatBufferBuilder builder, VectorOffset refactorActorRef2EntitiesOffset)
		{
			builder.AddOffset(5, refactorActorRef2EntitiesOffset.Value, 0);
		}

		// Token: 0x06028988 RID: 166280 RVA: 0x0058CB30 File Offset: 0x0058AD30
		public static VectorOffset CreateRefactorActorRef2EntitiesVector(FlatBufferBuilder builder, Offset<IRefactorActorRef2Entities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028989 RID: 166281 RVA: 0x0058CB70 File Offset: 0x0058AD70
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, Offset<IRefactorActorRef2Entities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRefactorActorRef2Entities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602898A RID: 166282 RVA: 0x0058CB8A File Offset: 0x0058AD8A
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRefactorActorRef2Entities>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRefactorActorRef2Entities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602898B RID: 166283 RVA: 0x0058CBA8 File Offset: 0x0058ADA8
		public static VectorOffset CreateRefactorActorRef2EntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRefactorActorRef2Entities>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602898C RID: 166284 RVA: 0x0058CBC1 File Offset: 0x0058ADC1
		public static void StartRefactorActorRef2EntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602898D RID: 166285 RVA: 0x0058CBCC File Offset: 0x0058ADCC
		public static void AddNoiseWallRefs(FlatBufferBuilder builder, VectorOffset noiseWallRefsOffset)
		{
			builder.AddOffset(6, noiseWallRefsOffset.Value, 0);
		}

		// Token: 0x0602898E RID: 166286 RVA: 0x0058CBDC File Offset: 0x0058ADDC
		public static VectorOffset CreateNoiseWallRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602898F RID: 166287 RVA: 0x0058CC1C File Offset: 0x0058AE1C
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028990 RID: 166288 RVA: 0x0058CC36 File Offset: 0x0058AE36
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028991 RID: 166289 RVA: 0x0058CC54 File Offset: 0x0058AE54
		public static VectorOffset CreateNoiseWallRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028992 RID: 166290 RVA: 0x0058CC6D File Offset: 0x0058AE6D
		public static void StartNoiseWallRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028993 RID: 166291 RVA: 0x0058CC78 File Offset: 0x0058AE78
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06028994 RID: 166292 RVA: 0x0058CC83 File Offset: 0x0058AE83
		public static Offset<ISceneActorRefComponent> EndISceneActorRefComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorRefComponent>(builder.EndTable());
		}

		// Token: 0x06028995 RID: 166293 RVA: 0x0058CC90 File Offset: 0x0058AE90
		public ISceneActorRefComponentT UnPack()
		{
			ISceneActorRefComponentT sceneActorRefComponentT = new ISceneActorRefComponentT();
			this.UnPackTo(sceneActorRefComponentT);
			return sceneActorRefComponentT;
		}

		// Token: 0x06028996 RID: 166294 RVA: 0x0058CCAC File Offset: 0x0058AEAC
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

		// Token: 0x06028997 RID: 166295 RVA: 0x0058CEBC File Offset: 0x0058B0BC
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

		// Token: 0x0400FAF0 RID: 64240
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A6 RID: 21414
	public struct IAirWallSpawnerComponent : IFlatbufferObject
	{
		// Token: 0x17009773 RID: 38771
		// (get) Token: 0x060216AB RID: 136875 RVA: 0x0049C479 File Offset: 0x0049A679
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216AC RID: 136876 RVA: 0x0049C486 File Offset: 0x0049A686
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216AD RID: 136877 RVA: 0x0049C490 File Offset: 0x0049A690
		public static IAirWallSpawnerComponent GetRootAsIAirWallSpawnerComponent(ByteBuffer _bb)
		{
			return IAirWallSpawnerComponent.GetRootAsIAirWallSpawnerComponent(_bb, default(IAirWallSpawnerComponent));
		}

		// Token: 0x060216AE RID: 136878 RVA: 0x0049C4AC File Offset: 0x0049A6AC
		public static IAirWallSpawnerComponent GetRootAsIAirWallSpawnerComponent(ByteBuffer _bb, IAirWallSpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216AF RID: 136879 RVA: 0x0049C4C9 File Offset: 0x0049A6C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216B0 RID: 136880 RVA: 0x0049C4D8 File Offset: 0x0049A6D8
		public IAirWallSpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009774 RID: 38772
		// (get) Token: 0x060216B1 RID: 136881 RVA: 0x0049C4E8 File Offset: 0x0049A6E8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009775 RID: 38773
		// (get) Token: 0x060216B2 RID: 136882 RVA: 0x0049C528 File Offset: 0x0049A728
		public int SplineEntity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009776 RID: 38774
		// (get) Token: 0x060216B3 RID: 136883 RVA: 0x0049C564 File Offset: 0x0049A764
		public string WallName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060216B4 RID: 136884 RVA: 0x0049C59B File Offset: 0x0049A79B
		public Span<byte> GetWallNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060216B5 RID: 136885 RVA: 0x0049C5AA File Offset: 0x0049A7AA
		public byte[] GetWallNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009777 RID: 38775
		// (get) Token: 0x060216B6 RID: 136886 RVA: 0x0049C5B8 File Offset: 0x0049A7B8
		public float Thickness
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009778 RID: 38776
		// (get) Token: 0x060216B7 RID: 136887 RVA: 0x0049C5FC File Offset: 0x0049A7FC
		public float Height
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009779 RID: 38777
		// (get) Token: 0x060216B8 RID: 136888 RVA: 0x0049C640 File Offset: 0x0049A840
		public EBiasDirection BiasDirection
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EBiasDirection.Inner;
				}
				return (EBiasDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700977A RID: 38778
		// (get) Token: 0x060216B9 RID: 136889 RVA: 0x0049C680 File Offset: 0x0049A880
		public bool IsExtend
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700977B RID: 38779
		// (get) Token: 0x060216BA RID: 136890 RVA: 0x0049C6C0 File Offset: 0x0049A8C0
		public bool HasCover
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060216BB RID: 136891 RVA: 0x0049C700 File Offset: 0x0049A900
		public IActorRef? WallActorsRef(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700977C RID: 38780
		// (get) Token: 0x060216BC RID: 136892 RVA: 0x0049C764 File Offset: 0x0049A964
		public int WallActorsRefLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700977D RID: 38781
		// (get) Token: 0x060216BD RID: 136893 RVA: 0x0049C790 File Offset: 0x0049A990
		public IAirWallWholeSpawnMode? SpawnMode
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IAirWallWholeSpawnMode?(default(IAirWallWholeSpawnMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700977E RID: 38782
		// (get) Token: 0x060216BE RID: 136894 RVA: 0x0049C7F0 File Offset: 0x0049A9F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060216BF RID: 136895 RVA: 0x0049C830 File Offset: 0x0049AA30
		public static Offset<IAirWallSpawnerComponent> CreateIAirWallSpawnerComponent(FlatBufferBuilder builder, bool Disabled = false, int SplineEntity = 0, StringOffset WallNameOffset = default(StringOffset), float Thickness = 0f, float Height = 0f, EBiasDirection BiasDirection = EBiasDirection.Inner, bool IsExtend = false, bool HasCover = false, VectorOffset WallActorsRefOffset = default(VectorOffset), Offset<IAirWallWholeSpawnMode> SpawnModeOffset = default(Offset<IAirWallWholeSpawnMode>), byte NullMask = 0)
		{
			builder.StartTable(11);
			IAirWallSpawnerComponent.AddSpawnMode(builder, SpawnModeOffset);
			IAirWallSpawnerComponent.AddWallActorsRef(builder, WallActorsRefOffset);
			IAirWallSpawnerComponent.AddHeight(builder, Height);
			IAirWallSpawnerComponent.AddThickness(builder, Thickness);
			IAirWallSpawnerComponent.AddWallName(builder, WallNameOffset);
			IAirWallSpawnerComponent.AddSplineEntity(builder, SplineEntity);
			IAirWallSpawnerComponent.AddNullMask(builder, NullMask);
			IAirWallSpawnerComponent.AddHasCover(builder, HasCover);
			IAirWallSpawnerComponent.AddIsExtend(builder, IsExtend);
			IAirWallSpawnerComponent.AddBiasDirection(builder, BiasDirection);
			IAirWallSpawnerComponent.AddDisabled(builder, Disabled);
			return IAirWallSpawnerComponent.EndIAirWallSpawnerComponent(builder);
		}

		// Token: 0x060216C0 RID: 136896 RVA: 0x0049C8A0 File Offset: 0x0049AAA0
		public static void StartIAirWallSpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060216C1 RID: 136897 RVA: 0x0049C8AA File Offset: 0x0049AAAA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060216C2 RID: 136898 RVA: 0x0049C8B5 File Offset: 0x0049AAB5
		public static void AddSplineEntity(FlatBufferBuilder builder, int splineEntity)
		{
			builder.AddInt(1, splineEntity, 0);
		}

		// Token: 0x060216C3 RID: 136899 RVA: 0x0049C8C0 File Offset: 0x0049AAC0
		public static void AddWallName(FlatBufferBuilder builder, StringOffset wallNameOffset)
		{
			builder.AddOffset(2, wallNameOffset.Value, 0);
		}

		// Token: 0x060216C4 RID: 136900 RVA: 0x0049C8D0 File Offset: 0x0049AAD0
		public static void AddThickness(FlatBufferBuilder builder, float thickness)
		{
			builder.AddFloat(3, thickness, 0.0);
		}

		// Token: 0x060216C5 RID: 136901 RVA: 0x0049C8E3 File Offset: 0x0049AAE3
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(4, height, 0.0);
		}

		// Token: 0x060216C6 RID: 136902 RVA: 0x0049C8F6 File Offset: 0x0049AAF6
		public static void AddBiasDirection(FlatBufferBuilder builder, EBiasDirection biasDirection)
		{
			builder.AddByte(5, (byte)biasDirection, 0);
		}

		// Token: 0x060216C7 RID: 136903 RVA: 0x0049C901 File Offset: 0x0049AB01
		public static void AddIsExtend(FlatBufferBuilder builder, bool isExtend)
		{
			builder.AddBool(6, isExtend, false);
		}

		// Token: 0x060216C8 RID: 136904 RVA: 0x0049C90C File Offset: 0x0049AB0C
		public static void AddHasCover(FlatBufferBuilder builder, bool hasCover)
		{
			builder.AddBool(7, hasCover, false);
		}

		// Token: 0x060216C9 RID: 136905 RVA: 0x0049C917 File Offset: 0x0049AB17
		public static void AddWallActorsRef(FlatBufferBuilder builder, VectorOffset wallActorsRefOffset)
		{
			builder.AddOffset(8, wallActorsRefOffset.Value, 0);
		}

		// Token: 0x060216CA RID: 136906 RVA: 0x0049C928 File Offset: 0x0049AB28
		public static VectorOffset CreateWallActorsRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060216CB RID: 136907 RVA: 0x0049C968 File Offset: 0x0049AB68
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x060216CC RID: 136908 RVA: 0x0049C982 File Offset: 0x0049AB82
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x060216CD RID: 136909 RVA: 0x0049C9A0 File Offset: 0x0049ABA0
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060216CE RID: 136910 RVA: 0x0049C9B9 File Offset: 0x0049ABB9
		public static void StartWallActorsRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060216CF RID: 136911 RVA: 0x0049C9C4 File Offset: 0x0049ABC4
		public static void AddSpawnMode(FlatBufferBuilder builder, Offset<IAirWallWholeSpawnMode> spawnModeOffset)
		{
			builder.AddOffset(9, spawnModeOffset.Value, 0);
		}

		// Token: 0x060216D0 RID: 136912 RVA: 0x0049C9D5 File Offset: 0x0049ABD5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060216D1 RID: 136913 RVA: 0x0049C9E1 File Offset: 0x0049ABE1
		public static Offset<IAirWallSpawnerComponent> EndIAirWallSpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallSpawnerComponent>(builder.EndTable());
		}

		// Token: 0x060216D2 RID: 136914 RVA: 0x0049C9F0 File Offset: 0x0049ABF0
		public IAirWallSpawnerComponentT UnPack()
		{
			IAirWallSpawnerComponentT airWallSpawnerComponentT = new IAirWallSpawnerComponentT();
			this.UnPackTo(airWallSpawnerComponentT);
			return airWallSpawnerComponentT;
		}

		// Token: 0x060216D3 RID: 136915 RVA: 0x0049CA0C File Offset: 0x0049AC0C
		public void UnPackTo(IAirWallSpawnerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SplineEntity = this.SplineEntity;
			_o.WallName = this.WallName;
			_o.Thickness = this.Thickness;
			_o.Height = this.Height;
			_o.BiasDirection = this.BiasDirection;
			_o.IsExtend = this.IsExtend;
			_o.HasCover = this.HasCover;
			_o.WallActorsRef = new List<IActorRefT>();
			for (int i = 0; i < this.WallActorsRefLength; i++)
			{
				_o.WallActorsRef.Add((this.WallActorsRef(i) != null) ? this.WallActorsRef(i).Value.UnPack() : null);
			}
			_o.SpawnMode = ((this.SpawnMode != null) ? this.SpawnMode.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060216D4 RID: 136916 RVA: 0x0049CB08 File Offset: 0x0049AD08
		public static Offset<IAirWallSpawnerComponent> Pack(FlatBufferBuilder builder, IAirWallSpawnerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallSpawnerComponent>);
			}
			StringOffset wallNameOffset = (_o.WallName == null) ? default(StringOffset) : builder.CreateString(_o.WallName);
			VectorOffset wallActorsRefOffset = default(VectorOffset);
			if (_o.WallActorsRef != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.WallActorsRef.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.WallActorsRef[i]);
				}
				wallActorsRefOffset = IAirWallSpawnerComponent.CreateWallActorsRefVector(builder, array);
			}
			Offset<IAirWallWholeSpawnMode> spawnModeOffset = (_o.SpawnMode == null) ? default(Offset<IAirWallWholeSpawnMode>) : IAirWallWholeSpawnMode.Pack(builder, _o.SpawnMode);
			return IAirWallSpawnerComponent.CreateIAirWallSpawnerComponent(builder, _o.Disabled, _o.SplineEntity, wallNameOffset, _o.Thickness, _o.Height, _o.BiasDirection, _o.IsExtend, _o.HasCover, wallActorsRefOffset, spawnModeOffset, _o.NullMask);
		}

		// Token: 0x0400E7DD RID: 59357
		private Table __p;
	}
}

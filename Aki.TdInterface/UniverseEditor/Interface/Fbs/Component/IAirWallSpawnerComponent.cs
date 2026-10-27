using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E8C RID: 20108
	public struct IAirWallSpawnerComponent : IFlatbufferObject
	{
		// Token: 0x1700902B RID: 36907
		// (get) Token: 0x0601FA1E RID: 129566 RVA: 0x00467DB1 File Offset: 0x00465FB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA1F RID: 129567 RVA: 0x00467DBE File Offset: 0x00465FBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA20 RID: 129568 RVA: 0x00467DC8 File Offset: 0x00465FC8
		public static IAirWallSpawnerComponent GetRootAsIAirWallSpawnerComponent(ByteBuffer _bb)
		{
			return IAirWallSpawnerComponent.GetRootAsIAirWallSpawnerComponent(_bb, default(IAirWallSpawnerComponent));
		}

		// Token: 0x0601FA21 RID: 129569 RVA: 0x00467DE4 File Offset: 0x00465FE4
		public static IAirWallSpawnerComponent GetRootAsIAirWallSpawnerComponent(ByteBuffer _bb, IAirWallSpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA22 RID: 129570 RVA: 0x00467E01 File Offset: 0x00466001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA23 RID: 129571 RVA: 0x00467E10 File Offset: 0x00466010
		public IAirWallSpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700902C RID: 36908
		// (get) Token: 0x0601FA24 RID: 129572 RVA: 0x00467E20 File Offset: 0x00466020
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700902D RID: 36909
		// (get) Token: 0x0601FA25 RID: 129573 RVA: 0x00467E60 File Offset: 0x00466060
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

		// Token: 0x1700902E RID: 36910
		// (get) Token: 0x0601FA26 RID: 129574 RVA: 0x00467E9C File Offset: 0x0046609C
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

		// Token: 0x0601FA27 RID: 129575 RVA: 0x00467ED3 File Offset: 0x004660D3
		public Span<byte> GetWallNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601FA28 RID: 129576 RVA: 0x00467EE2 File Offset: 0x004660E2
		public byte[] GetWallNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700902F RID: 36911
		// (get) Token: 0x0601FA29 RID: 129577 RVA: 0x00467EF0 File Offset: 0x004660F0
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

		// Token: 0x17009030 RID: 36912
		// (get) Token: 0x0601FA2A RID: 129578 RVA: 0x00467F34 File Offset: 0x00466134
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

		// Token: 0x17009031 RID: 36913
		// (get) Token: 0x0601FA2B RID: 129579 RVA: 0x00467F78 File Offset: 0x00466178
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

		// Token: 0x17009032 RID: 36914
		// (get) Token: 0x0601FA2C RID: 129580 RVA: 0x00467FB8 File Offset: 0x004661B8
		public bool IsExtend
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009033 RID: 36915
		// (get) Token: 0x0601FA2D RID: 129581 RVA: 0x00467FF8 File Offset: 0x004661F8
		public bool HasCover
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FA2E RID: 129582 RVA: 0x00468038 File Offset: 0x00466238
		public IActorRef? WallActorsRef(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009034 RID: 36916
		// (get) Token: 0x0601FA2F RID: 129583 RVA: 0x0046809C File Offset: 0x0046629C
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

		// Token: 0x17009035 RID: 36917
		// (get) Token: 0x0601FA30 RID: 129584 RVA: 0x004680C8 File Offset: 0x004662C8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA31 RID: 129585 RVA: 0x00468108 File Offset: 0x00466308
		public static Offset<IAirWallSpawnerComponent> CreateIAirWallSpawnerComponent(FlatBufferBuilder builder, bool Disabled = false, int SplineEntity = 0, StringOffset WallNameOffset = default(StringOffset), float Thickness = 0f, float Height = 0f, EBiasDirection BiasDirection = EBiasDirection.Inner, bool IsExtend = false, bool HasCover = false, VectorOffset WallActorsRefOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
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

		// Token: 0x0601FA32 RID: 129586 RVA: 0x00468170 File Offset: 0x00466370
		public static void StartIAirWallSpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601FA33 RID: 129587 RVA: 0x0046817A File Offset: 0x0046637A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FA34 RID: 129588 RVA: 0x00468185 File Offset: 0x00466385
		public static void AddSplineEntity(FlatBufferBuilder builder, int splineEntity)
		{
			builder.AddInt(1, splineEntity, 0);
		}

		// Token: 0x0601FA35 RID: 129589 RVA: 0x00468190 File Offset: 0x00466390
		public static void AddWallName(FlatBufferBuilder builder, StringOffset wallNameOffset)
		{
			builder.AddOffset(2, wallNameOffset.Value, 0);
		}

		// Token: 0x0601FA36 RID: 129590 RVA: 0x004681A0 File Offset: 0x004663A0
		public static void AddThickness(FlatBufferBuilder builder, float thickness)
		{
			builder.AddFloat(3, thickness, 0.0);
		}

		// Token: 0x0601FA37 RID: 129591 RVA: 0x004681B3 File Offset: 0x004663B3
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(4, height, 0.0);
		}

		// Token: 0x0601FA38 RID: 129592 RVA: 0x004681C6 File Offset: 0x004663C6
		public static void AddBiasDirection(FlatBufferBuilder builder, EBiasDirection biasDirection)
		{
			builder.AddByte(5, (byte)biasDirection, 0);
		}

		// Token: 0x0601FA39 RID: 129593 RVA: 0x004681D1 File Offset: 0x004663D1
		public static void AddIsExtend(FlatBufferBuilder builder, bool isExtend)
		{
			builder.AddBool(6, isExtend, false);
		}

		// Token: 0x0601FA3A RID: 129594 RVA: 0x004681DC File Offset: 0x004663DC
		public static void AddHasCover(FlatBufferBuilder builder, bool hasCover)
		{
			builder.AddBool(7, hasCover, false);
		}

		// Token: 0x0601FA3B RID: 129595 RVA: 0x004681E7 File Offset: 0x004663E7
		public static void AddWallActorsRef(FlatBufferBuilder builder, VectorOffset wallActorsRefOffset)
		{
			builder.AddOffset(8, wallActorsRefOffset.Value, 0);
		}

		// Token: 0x0601FA3C RID: 129596 RVA: 0x004681F8 File Offset: 0x004663F8
		public static VectorOffset CreateWallActorsRefVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FA3D RID: 129597 RVA: 0x00468238 File Offset: 0x00466438
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FA3E RID: 129598 RVA: 0x00468252 File Offset: 0x00466452
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FA3F RID: 129599 RVA: 0x00468270 File Offset: 0x00466470
		public static VectorOffset CreateWallActorsRefVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FA40 RID: 129600 RVA: 0x00468289 File Offset: 0x00466489
		public static void StartWallActorsRefVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FA41 RID: 129601 RVA: 0x00468294 File Offset: 0x00466494
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601FA42 RID: 129602 RVA: 0x004682A0 File Offset: 0x004664A0
		public static Offset<IAirWallSpawnerComponent> EndIAirWallSpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallSpawnerComponent>(builder.EndTable());
		}

		// Token: 0x0601FA43 RID: 129603 RVA: 0x004682B0 File Offset: 0x004664B0
		public IAirWallSpawnerComponentT UnPack()
		{
			IAirWallSpawnerComponentT airWallSpawnerComponentT = new IAirWallSpawnerComponentT();
			this.UnPackTo(airWallSpawnerComponentT);
			return airWallSpawnerComponentT;
		}

		// Token: 0x0601FA44 RID: 129604 RVA: 0x004682CC File Offset: 0x004664CC
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FA45 RID: 129605 RVA: 0x00468398 File Offset: 0x00466598
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
			return IAirWallSpawnerComponent.CreateIAirWallSpawnerComponent(builder, _o.Disabled, _o.SplineEntity, wallNameOffset, _o.Thickness, _o.Height, _o.BiasDirection, _o.IsExtend, _o.HasCover, wallActorsRefOffset, _o.NullMask);
		}

		// Token: 0x0400DC5A RID: 56410
		private Table __p;
	}
}

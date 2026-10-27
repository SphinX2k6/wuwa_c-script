using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538F RID: 21391
	public struct IHitLogicChangeByPartHit : IFlatbufferObject
	{
		// Token: 0x17009D33 RID: 40243
		// (get) Token: 0x0602307A RID: 143482 RVA: 0x004D9D14 File Offset: 0x004D7F14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602307B RID: 143483 RVA: 0x004D9D21 File Offset: 0x004D7F21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602307C RID: 143484 RVA: 0x004D9D28 File Offset: 0x004D7F28
		public static IHitLogicChangeByPartHit GetRootAsIHitLogicChangeByPartHit(ByteBuffer _bb)
		{
			return IHitLogicChangeByPartHit.GetRootAsIHitLogicChangeByPartHit(_bb, default(IHitLogicChangeByPartHit));
		}

		// Token: 0x0602307D RID: 143485 RVA: 0x004D9D44 File Offset: 0x004D7F44
		public static IHitLogicChangeByPartHit GetRootAsIHitLogicChangeByPartHit(ByteBuffer _bb, IHitLogicChangeByPartHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602307E RID: 143486 RVA: 0x004D9D61 File Offset: 0x004D7F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602307F RID: 143487 RVA: 0x004D9D70 File Offset: 0x004D7F70
		public IHitLogicChangeByPartHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D34 RID: 40244
		// (get) Token: 0x06023080 RID: 143488 RVA: 0x004D9D80 File Offset: 0x004D7F80
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023081 RID: 143489 RVA: 0x004D9DBC File Offset: 0x004D7FBC
		public IPartHitConfig? PartHitConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPartHitConfig?(default(IPartHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D35 RID: 40245
		// (get) Token: 0x06023082 RID: 143490 RVA: 0x004D9E1C File Offset: 0x004D801C
		public int PartHitConfigLength
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

		// Token: 0x06023083 RID: 143491 RVA: 0x004D9E47 File Offset: 0x004D8047
		public static Offset<IHitLogicChangeByPartHit> CreateIHitLogicChangeByPartHit(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset PartHitConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHitLogicChangeByPartHit.AddPartHitConfig(builder, PartHitConfigOffset);
			IHitLogicChangeByPartHit.AddType(builder, Type);
			return IHitLogicChangeByPartHit.EndIHitLogicChangeByPartHit(builder);
		}

		// Token: 0x06023084 RID: 143492 RVA: 0x004D9E64 File Offset: 0x004D8064
		public static void StartIHitLogicChangeByPartHit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023085 RID: 143493 RVA: 0x004D9E6D File Offset: 0x004D806D
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023086 RID: 143494 RVA: 0x004D9E78 File Offset: 0x004D8078
		public static void AddPartHitConfig(FlatBufferBuilder builder, VectorOffset partHitConfigOffset)
		{
			builder.AddOffset(1, partHitConfigOffset.Value, 0);
		}

		// Token: 0x06023087 RID: 143495 RVA: 0x004D9E88 File Offset: 0x004D8088
		public static VectorOffset CreatePartHitConfigVector(FlatBufferBuilder builder, Offset<IPartHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023088 RID: 143496 RVA: 0x004D9EC8 File Offset: 0x004D80C8
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, Offset<IPartHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPartHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023089 RID: 143497 RVA: 0x004D9EE2 File Offset: 0x004D80E2
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPartHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPartHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602308A RID: 143498 RVA: 0x004D9F00 File Offset: 0x004D8100
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPartHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602308B RID: 143499 RVA: 0x004D9F19 File Offset: 0x004D8119
		public static void StartPartHitConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602308C RID: 143500 RVA: 0x004D9F24 File Offset: 0x004D8124
		public static Offset<IHitLogicChangeByPartHit> EndIHitLogicChangeByPartHit(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeByPartHit>(builder.EndTable());
		}

		// Token: 0x0602308D RID: 143501 RVA: 0x004D9F34 File Offset: 0x004D8134
		public IHitLogicChangeByPartHitT UnPack()
		{
			IHitLogicChangeByPartHitT hitLogicChangeByPartHitT = new IHitLogicChangeByPartHitT();
			this.UnPackTo(hitLogicChangeByPartHitT);
			return hitLogicChangeByPartHitT;
		}

		// Token: 0x0602308E RID: 143502 RVA: 0x004D9F50 File Offset: 0x004D8150
		public void UnPackTo(IHitLogicChangeByPartHitT _o)
		{
			_o.Type = this.Type;
			_o.PartHitConfig = new List<IPartHitConfigT>();
			for (int i = 0; i < this.PartHitConfigLength; i++)
			{
				_o.PartHitConfig.Add((this.PartHitConfig(i) != null) ? this.PartHitConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602308F RID: 143503 RVA: 0x004D9FBC File Offset: 0x004D81BC
		public static Offset<IHitLogicChangeByPartHit> Pack(FlatBufferBuilder builder, IHitLogicChangeByPartHitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeByPartHit>);
			}
			VectorOffset partHitConfigOffset = default(VectorOffset);
			if (_o.PartHitConfig != null)
			{
				Offset<IPartHitConfig>[] array = new Offset<IPartHitConfig>[_o.PartHitConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPartHitConfig.Pack(builder, _o.PartHitConfig[i]);
				}
				partHitConfigOffset = IHitLogicChangeByPartHit.CreatePartHitConfigVector(builder, array);
			}
			return IHitLogicChangeByPartHit.CreateIHitLogicChangeByPartHit(builder, _o.Type, partHitConfigOffset);
		}

		// Token: 0x0400E57B RID: 58747
		private Table __p;
	}
}

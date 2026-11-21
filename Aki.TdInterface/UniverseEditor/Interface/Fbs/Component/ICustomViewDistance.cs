using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C2 RID: 21954
	public struct ICustomViewDistance : IFlatbufferObject
	{
		// Token: 0x17009D2E RID: 40238
		// (get) Token: 0x06022ED5 RID: 143061 RVA: 0x004CEFA5 File Offset: 0x004CD1A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022ED6 RID: 143062 RVA: 0x004CEFB2 File Offset: 0x004CD1B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022ED7 RID: 143063 RVA: 0x004CEFBC File Offset: 0x004CD1BC
		public static ICustomViewDistance GetRootAsICustomViewDistance(ByteBuffer _bb)
		{
			return ICustomViewDistance.GetRootAsICustomViewDistance(_bb, default(ICustomViewDistance));
		}

		// Token: 0x06022ED8 RID: 143064 RVA: 0x004CEFD8 File Offset: 0x004CD1D8
		public static ICustomViewDistance GetRootAsICustomViewDistance(ByteBuffer _bb, ICustomViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022ED9 RID: 143065 RVA: 0x004CEFF5 File Offset: 0x004CD1F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EDA RID: 143066 RVA: 0x004CF004 File Offset: 0x004CD204
		public ICustomViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D2F RID: 40239
		// (get) Token: 0x06022EDB RID: 143067 RVA: 0x004CF014 File Offset: 0x004CD214
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D30 RID: 40240
		// (get) Token: 0x06022EDC RID: 143068 RVA: 0x004CF050 File Offset: 0x004CD250
		public int Distance
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

		// Token: 0x06022EDD RID: 143069 RVA: 0x004CF08C File Offset: 0x004CD28C
		public static Offset<ICustomViewDistance> CreateICustomViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low, int Distance = 0)
		{
			builder.StartTable(2);
			ICustomViewDistance.AddDistance(builder, Distance);
			ICustomViewDistance.AddType(builder, Type);
			return ICustomViewDistance.EndICustomViewDistance(builder);
		}

		// Token: 0x06022EDE RID: 143070 RVA: 0x004CF0A9 File Offset: 0x004CD2A9
		public static void StartICustomViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022EDF RID: 143071 RVA: 0x004CF0B2 File Offset: 0x004CD2B2
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022EE0 RID: 143072 RVA: 0x004CF0BD File Offset: 0x004CD2BD
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(1, distance, 0);
		}

		// Token: 0x06022EE1 RID: 143073 RVA: 0x004CF0C8 File Offset: 0x004CD2C8
		public static Offset<ICustomViewDistance> EndICustomViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICustomViewDistance>(builder.EndTable());
		}

		// Token: 0x06022EE2 RID: 143074 RVA: 0x004CF0D8 File Offset: 0x004CD2D8
		public ICustomViewDistanceT UnPack()
		{
			ICustomViewDistanceT customViewDistanceT = new ICustomViewDistanceT();
			this.UnPackTo(customViewDistanceT);
			return customViewDistanceT;
		}

		// Token: 0x06022EE3 RID: 143075 RVA: 0x004CF0F3 File Offset: 0x004CD2F3
		public void UnPackTo(ICustomViewDistanceT _o)
		{
			_o.Type = this.Type;
			_o.Distance = this.Distance;
		}

		// Token: 0x06022EE4 RID: 143076 RVA: 0x004CF110 File Offset: 0x004CD310
		public static Offset<ICustomViewDistance> Pack(FlatBufferBuilder builder, ICustomViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomViewDistance>);
			}
			return ICustomViewDistance.CreateICustomViewDistance(builder, _o.Type, _o.Distance);
		}

		// Token: 0x0400EC55 RID: 60501
		private Table __p;
	}
}

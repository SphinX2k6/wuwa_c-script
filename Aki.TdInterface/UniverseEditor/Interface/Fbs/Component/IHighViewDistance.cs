using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005368 RID: 21352
	public struct IHighViewDistance : IFlatbufferObject
	{
		// Token: 0x17009CEA RID: 40170
		// (get) Token: 0x06022F08 RID: 143112 RVA: 0x004D6A94 File Offset: 0x004D4C94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F09 RID: 143113 RVA: 0x004D6AA1 File Offset: 0x004D4CA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F0A RID: 143114 RVA: 0x004D6AA8 File Offset: 0x004D4CA8
		public static IHighViewDistance GetRootAsIHighViewDistance(ByteBuffer _bb)
		{
			return IHighViewDistance.GetRootAsIHighViewDistance(_bb, default(IHighViewDistance));
		}

		// Token: 0x06022F0B RID: 143115 RVA: 0x004D6AC4 File Offset: 0x004D4CC4
		public static IHighViewDistance GetRootAsIHighViewDistance(ByteBuffer _bb, IHighViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F0C RID: 143116 RVA: 0x004D6AE1 File Offset: 0x004D4CE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F0D RID: 143117 RVA: 0x004D6AF0 File Offset: 0x004D4CF0
		public IHighViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CEB RID: 40171
		// (get) Token: 0x06022F0E RID: 143118 RVA: 0x004D6B00 File Offset: 0x004D4D00
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

		// Token: 0x06022F0F RID: 143119 RVA: 0x004D6B3C File Offset: 0x004D4D3C
		public static Offset<IHighViewDistance> CreateIHighViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IHighViewDistance.AddType(builder, Type);
			return IHighViewDistance.EndIHighViewDistance(builder);
		}

		// Token: 0x06022F10 RID: 143120 RVA: 0x004D6B52 File Offset: 0x004D4D52
		public static void StartIHighViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022F11 RID: 143121 RVA: 0x004D6B5B File Offset: 0x004D4D5B
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F12 RID: 143122 RVA: 0x004D6B66 File Offset: 0x004D4D66
		public static Offset<IHighViewDistance> EndIHighViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<IHighViewDistance>(builder.EndTable());
		}

		// Token: 0x06022F13 RID: 143123 RVA: 0x004D6B74 File Offset: 0x004D4D74
		public IHighViewDistanceT UnPack()
		{
			IHighViewDistanceT highViewDistanceT = new IHighViewDistanceT();
			this.UnPackTo(highViewDistanceT);
			return highViewDistanceT;
		}

		// Token: 0x06022F14 RID: 143124 RVA: 0x004D6B8F File Offset: 0x004D4D8F
		public void UnPackTo(IHighViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022F15 RID: 143125 RVA: 0x004D6BA0 File Offset: 0x004D4DA0
		public static Offset<IHighViewDistance> Pack(FlatBufferBuilder builder, IHighViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHighViewDistance>);
			}
			return IHighViewDistance.CreateIHighViewDistance(builder, _o.Type);
		}

		// Token: 0x0400E547 RID: 58695
		private Table __p;
	}
}

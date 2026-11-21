using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EE RID: 22766
	public struct IHighViewDistance : IFlatbufferObject
	{
		// Token: 0x1700A522 RID: 42274
		// (get) Token: 0x06024FBC RID: 151484 RVA: 0x00513968 File Offset: 0x00511B68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FBD RID: 151485 RVA: 0x00513975 File Offset: 0x00511B75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FBE RID: 151486 RVA: 0x0051397C File Offset: 0x00511B7C
		public static IHighViewDistance GetRootAsIHighViewDistance(ByteBuffer _bb)
		{
			return IHighViewDistance.GetRootAsIHighViewDistance(_bb, default(IHighViewDistance));
		}

		// Token: 0x06024FBF RID: 151487 RVA: 0x00513998 File Offset: 0x00511B98
		public static IHighViewDistance GetRootAsIHighViewDistance(ByteBuffer _bb, IHighViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FC0 RID: 151488 RVA: 0x005139B5 File Offset: 0x00511BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FC1 RID: 151489 RVA: 0x005139C4 File Offset: 0x00511BC4
		public IHighViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A523 RID: 42275
		// (get) Token: 0x06024FC2 RID: 151490 RVA: 0x005139D4 File Offset: 0x00511BD4
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

		// Token: 0x06024FC3 RID: 151491 RVA: 0x00513A10 File Offset: 0x00511C10
		public static Offset<IHighViewDistance> CreateIHighViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IHighViewDistance.AddType(builder, Type);
			return IHighViewDistance.EndIHighViewDistance(builder);
		}

		// Token: 0x06024FC4 RID: 151492 RVA: 0x00513A26 File Offset: 0x00511C26
		public static void StartIHighViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024FC5 RID: 151493 RVA: 0x00513A2F File Offset: 0x00511C2F
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024FC6 RID: 151494 RVA: 0x00513A3A File Offset: 0x00511C3A
		public static Offset<IHighViewDistance> EndIHighViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<IHighViewDistance>(builder.EndTable());
		}

		// Token: 0x06024FC7 RID: 151495 RVA: 0x00513A48 File Offset: 0x00511C48
		public IHighViewDistanceT UnPack()
		{
			IHighViewDistanceT highViewDistanceT = new IHighViewDistanceT();
			this.UnPackTo(highViewDistanceT);
			return highViewDistanceT;
		}

		// Token: 0x06024FC8 RID: 151496 RVA: 0x00513A63 File Offset: 0x00511C63
		public void UnPackTo(IHighViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024FC9 RID: 151497 RVA: 0x00513A74 File Offset: 0x00511C74
		public static Offset<IHighViewDistance> Pack(FlatBufferBuilder builder, IHighViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHighViewDistance>);
			}
			return IHighViewDistance.CreateIHighViewDistance(builder, _o.Type);
		}

		// Token: 0x0400F177 RID: 61815
		private Table __p;
	}
}

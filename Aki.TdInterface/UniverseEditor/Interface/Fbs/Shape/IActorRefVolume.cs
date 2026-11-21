using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF5 RID: 16373
	public struct IActorRefVolume : IFlatbufferObject
	{
		// Token: 0x17006EE1 RID: 28385
		// (get) Token: 0x0601665D RID: 91741 RVA: 0x003350E0 File Offset: 0x003332E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601665E RID: 91742 RVA: 0x003350ED File Offset: 0x003332ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601665F RID: 91743 RVA: 0x003350F4 File Offset: 0x003332F4
		public static IActorRefVolume GetRootAsIActorRefVolume(ByteBuffer _bb)
		{
			return IActorRefVolume.GetRootAsIActorRefVolume(_bb, default(IActorRefVolume));
		}

		// Token: 0x06016660 RID: 91744 RVA: 0x00335110 File Offset: 0x00333310
		public static IActorRefVolume GetRootAsIActorRefVolume(ByteBuffer _bb, IActorRefVolume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016661 RID: 91745 RVA: 0x0033512D File Offset: 0x0033332D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016662 RID: 91746 RVA: 0x0033513C File Offset: 0x0033333C
		public IActorRefVolume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EE2 RID: 28386
		// (get) Token: 0x06016663 RID: 91747 RVA: 0x0033514C File Offset: 0x0033334C
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016664 RID: 91748 RVA: 0x00335188 File Offset: 0x00333388
		public static Offset<IActorRefVolume> CreateIActorRefVolume(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box)
		{
			builder.StartTable(1);
			IActorRefVolume.AddType(builder, Type);
			return IActorRefVolume.EndIActorRefVolume(builder);
		}

		// Token: 0x06016665 RID: 91749 RVA: 0x0033519E File Offset: 0x0033339E
		public static void StartIActorRefVolume(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016666 RID: 91750 RVA: 0x003351A7 File Offset: 0x003333A7
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016667 RID: 91751 RVA: 0x003351B2 File Offset: 0x003333B2
		public static Offset<IActorRefVolume> EndIActorRefVolume(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefVolume>(builder.EndTable());
		}

		// Token: 0x06016668 RID: 91752 RVA: 0x003351C0 File Offset: 0x003333C0
		public IActorRefVolumeT UnPack()
		{
			IActorRefVolumeT actorRefVolumeT = new IActorRefVolumeT();
			this.UnPackTo(actorRefVolumeT);
			return actorRefVolumeT;
		}

		// Token: 0x06016669 RID: 91753 RVA: 0x003351DB File Offset: 0x003333DB
		public void UnPackTo(IActorRefVolumeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601666A RID: 91754 RVA: 0x003351EC File Offset: 0x003333EC
		public static Offset<IActorRefVolume> Pack(FlatBufferBuilder builder, IActorRefVolumeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorRefVolume>);
			}
			return IActorRefVolume.CreateIActorRefVolume(builder, _o.Type);
		}

		// Token: 0x0400BB38 RID: 47928
		private Table __p;
	}
}

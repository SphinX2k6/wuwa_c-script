using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C51 RID: 23633
	public struct IOverrideCollisionChannel : IFlatbufferObject
	{
		// Token: 0x1700AD98 RID: 44440
		// (get) Token: 0x060272EB RID: 160491 RVA: 0x0055E1FB File Offset: 0x0055C3FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272EC RID: 160492 RVA: 0x0055E208 File Offset: 0x0055C408
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272ED RID: 160493 RVA: 0x0055E210 File Offset: 0x0055C410
		public static IOverrideCollisionChannel GetRootAsIOverrideCollisionChannel(ByteBuffer _bb)
		{
			return IOverrideCollisionChannel.GetRootAsIOverrideCollisionChannel(_bb, default(IOverrideCollisionChannel));
		}

		// Token: 0x060272EE RID: 160494 RVA: 0x0055E22C File Offset: 0x0055C42C
		public static IOverrideCollisionChannel GetRootAsIOverrideCollisionChannel(ByteBuffer _bb, IOverrideCollisionChannel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272EF RID: 160495 RVA: 0x0055E249 File Offset: 0x0055C449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272F0 RID: 160496 RVA: 0x0055E258 File Offset: 0x0055C458
		public IOverrideCollisionChannel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD99 RID: 44441
		// (get) Token: 0x060272F1 RID: 160497 RVA: 0x0055E268 File Offset: 0x0055C468
		public ECollisionChannelPreset CollisionChannelPreset
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECollisionChannelPreset.CanBePassedThrough;
				}
				return (ECollisionChannelPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD9A RID: 44442
		// (get) Token: 0x060272F2 RID: 160498 RVA: 0x0055E2A4 File Offset: 0x0055C4A4
		public float BlurResponseRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD9B RID: 44443
		// (get) Token: 0x060272F3 RID: 160499 RVA: 0x0055E2E4 File Offset: 0x0055C4E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060272F4 RID: 160500 RVA: 0x0055E320 File Offset: 0x0055C520
		public static Offset<IOverrideCollisionChannel> CreateIOverrideCollisionChannel(FlatBufferBuilder builder, ECollisionChannelPreset CollisionChannelPreset = ECollisionChannelPreset.CanBePassedThrough, float BlurResponseRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IOverrideCollisionChannel.AddBlurResponseRadius(builder, BlurResponseRadius);
			IOverrideCollisionChannel.AddNullMask(builder, NullMask);
			IOverrideCollisionChannel.AddCollisionChannelPreset(builder, CollisionChannelPreset);
			return IOverrideCollisionChannel.EndIOverrideCollisionChannel(builder);
		}

		// Token: 0x060272F5 RID: 160501 RVA: 0x0055E344 File Offset: 0x0055C544
		public static void StartIOverrideCollisionChannel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060272F6 RID: 160502 RVA: 0x0055E34D File Offset: 0x0055C54D
		public static void AddCollisionChannelPreset(FlatBufferBuilder builder, ECollisionChannelPreset collisionChannelPreset)
		{
			builder.AddByte(0, (byte)collisionChannelPreset, 0);
		}

		// Token: 0x060272F7 RID: 160503 RVA: 0x0055E358 File Offset: 0x0055C558
		public static void AddBlurResponseRadius(FlatBufferBuilder builder, float blurResponseRadius)
		{
			builder.AddFloat(1, blurResponseRadius, 0.0);
		}

		// Token: 0x060272F8 RID: 160504 RVA: 0x0055E36B File Offset: 0x0055C56B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060272F9 RID: 160505 RVA: 0x0055E376 File Offset: 0x0055C576
		public static Offset<IOverrideCollisionChannel> EndIOverrideCollisionChannel(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideCollisionChannel>(builder.EndTable());
		}

		// Token: 0x060272FA RID: 160506 RVA: 0x0055E384 File Offset: 0x0055C584
		public IOverrideCollisionChannelT UnPack()
		{
			IOverrideCollisionChannelT overrideCollisionChannelT = new IOverrideCollisionChannelT();
			this.UnPackTo(overrideCollisionChannelT);
			return overrideCollisionChannelT;
		}

		// Token: 0x060272FB RID: 160507 RVA: 0x0055E39F File Offset: 0x0055C59F
		public void UnPackTo(IOverrideCollisionChannelT _o)
		{
			_o.CollisionChannelPreset = this.CollisionChannelPreset;
			_o.BlurResponseRadius = this.BlurResponseRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060272FC RID: 160508 RVA: 0x0055E3C8 File Offset: 0x0055C5C8
		public static Offset<IOverrideCollisionChannel> Pack(FlatBufferBuilder builder, IOverrideCollisionChannelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideCollisionChannel>);
			}
			return IOverrideCollisionChannel.CreateIOverrideCollisionChannel(builder, _o.CollisionChannelPreset, _o.BlurResponseRadius, _o.NullMask);
		}

		// Token: 0x0400F73F RID: 63295
		private Table __p;
	}
}

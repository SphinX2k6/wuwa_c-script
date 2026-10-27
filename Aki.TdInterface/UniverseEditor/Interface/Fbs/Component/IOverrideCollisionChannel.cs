using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AD RID: 22189
	public struct IOverrideCollisionChannel : IFlatbufferObject
	{
		// Token: 0x1700A504 RID: 42244
		// (get) Token: 0x06025096 RID: 151702 RVA: 0x0051D2B3 File Offset: 0x0051B4B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025097 RID: 151703 RVA: 0x0051D2C0 File Offset: 0x0051B4C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025098 RID: 151704 RVA: 0x0051D2C8 File Offset: 0x0051B4C8
		public static IOverrideCollisionChannel GetRootAsIOverrideCollisionChannel(ByteBuffer _bb)
		{
			return IOverrideCollisionChannel.GetRootAsIOverrideCollisionChannel(_bb, default(IOverrideCollisionChannel));
		}

		// Token: 0x06025099 RID: 151705 RVA: 0x0051D2E4 File Offset: 0x0051B4E4
		public static IOverrideCollisionChannel GetRootAsIOverrideCollisionChannel(ByteBuffer _bb, IOverrideCollisionChannel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602509A RID: 151706 RVA: 0x0051D301 File Offset: 0x0051B501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602509B RID: 151707 RVA: 0x0051D310 File Offset: 0x0051B510
		public IOverrideCollisionChannel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A505 RID: 42245
		// (get) Token: 0x0602509C RID: 151708 RVA: 0x0051D320 File Offset: 0x0051B520
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

		// Token: 0x1700A506 RID: 42246
		// (get) Token: 0x0602509D RID: 151709 RVA: 0x0051D35C File Offset: 0x0051B55C
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

		// Token: 0x1700A507 RID: 42247
		// (get) Token: 0x0602509E RID: 151710 RVA: 0x0051D39C File Offset: 0x0051B59C
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

		// Token: 0x0602509F RID: 151711 RVA: 0x0051D3D8 File Offset: 0x0051B5D8
		public static Offset<IOverrideCollisionChannel> CreateIOverrideCollisionChannel(FlatBufferBuilder builder, ECollisionChannelPreset CollisionChannelPreset = ECollisionChannelPreset.CanBePassedThrough, float BlurResponseRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IOverrideCollisionChannel.AddBlurResponseRadius(builder, BlurResponseRadius);
			IOverrideCollisionChannel.AddNullMask(builder, NullMask);
			IOverrideCollisionChannel.AddCollisionChannelPreset(builder, CollisionChannelPreset);
			return IOverrideCollisionChannel.EndIOverrideCollisionChannel(builder);
		}

		// Token: 0x060250A0 RID: 151712 RVA: 0x0051D3FC File Offset: 0x0051B5FC
		public static void StartIOverrideCollisionChannel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060250A1 RID: 151713 RVA: 0x0051D405 File Offset: 0x0051B605
		public static void AddCollisionChannelPreset(FlatBufferBuilder builder, ECollisionChannelPreset collisionChannelPreset)
		{
			builder.AddByte(0, (byte)collisionChannelPreset, 0);
		}

		// Token: 0x060250A2 RID: 151714 RVA: 0x0051D410 File Offset: 0x0051B610
		public static void AddBlurResponseRadius(FlatBufferBuilder builder, float blurResponseRadius)
		{
			builder.AddFloat(1, blurResponseRadius, 0.0);
		}

		// Token: 0x060250A3 RID: 151715 RVA: 0x0051D423 File Offset: 0x0051B623
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060250A4 RID: 151716 RVA: 0x0051D42E File Offset: 0x0051B62E
		public static Offset<IOverrideCollisionChannel> EndIOverrideCollisionChannel(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideCollisionChannel>(builder.EndTable());
		}

		// Token: 0x060250A5 RID: 151717 RVA: 0x0051D43C File Offset: 0x0051B63C
		public IOverrideCollisionChannelT UnPack()
		{
			IOverrideCollisionChannelT overrideCollisionChannelT = new IOverrideCollisionChannelT();
			this.UnPackTo(overrideCollisionChannelT);
			return overrideCollisionChannelT;
		}

		// Token: 0x060250A6 RID: 151718 RVA: 0x0051D457 File Offset: 0x0051B657
		public void UnPackTo(IOverrideCollisionChannelT _o)
		{
			_o.CollisionChannelPreset = this.CollisionChannelPreset;
			_o.BlurResponseRadius = this.BlurResponseRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060250A7 RID: 151719 RVA: 0x0051D480 File Offset: 0x0051B680
		public static Offset<IOverrideCollisionChannel> Pack(FlatBufferBuilder builder, IOverrideCollisionChannelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideCollisionChannel>);
			}
			return IOverrideCollisionChannel.CreateIOverrideCollisionChannel(builder, _o.CollisionChannelPreset, _o.BlurResponseRadius, _o.NullMask);
		}

		// Token: 0x0400EAD3 RID: 60115
		private Table __p;
	}
}

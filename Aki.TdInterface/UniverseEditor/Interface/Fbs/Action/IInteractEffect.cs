using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006981 RID: 27009
	public struct IInteractEffect : IFlatbufferObject
	{
		// Token: 0x1700C84F RID: 51279
		// (get) Token: 0x0602F2B4 RID: 193204 RVA: 0x0066CF20 File Offset: 0x0066B120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F2B5 RID: 193205 RVA: 0x0066CF2D File Offset: 0x0066B12D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F2B6 RID: 193206 RVA: 0x0066CF34 File Offset: 0x0066B134
		public static IInteractEffect GetRootAsIInteractEffect(ByteBuffer _bb)
		{
			return IInteractEffect.GetRootAsIInteractEffect(_bb, default(IInteractEffect));
		}

		// Token: 0x0602F2B7 RID: 193207 RVA: 0x0066CF50 File Offset: 0x0066B150
		public static IInteractEffect GetRootAsIInteractEffect(ByteBuffer _bb, IInteractEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F2B8 RID: 193208 RVA: 0x0066CF6D File Offset: 0x0066B16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F2B9 RID: 193209 RVA: 0x0066CF7C File Offset: 0x0066B17C
		public IInteractEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C850 RID: 51280
		// (get) Token: 0x0602F2BA RID: 193210 RVA: 0x0066CF8C File Offset: 0x0066B18C
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C851 RID: 51281
		// (get) Token: 0x0602F2BB RID: 193211 RVA: 0x0066CFC8 File Offset: 0x0066B1C8
		public float DelayTime
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

		// Token: 0x1700C852 RID: 51282
		// (get) Token: 0x0602F2BC RID: 193212 RVA: 0x0066D008 File Offset: 0x0066B208
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

		// Token: 0x0602F2BD RID: 193213 RVA: 0x0066D044 File Offset: 0x0066B244
		public static Offset<IInteractEffect> CreateIInteractEffect(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IInteractEffect.AddDelayTime(builder, DelayTime);
			IInteractEffect.AddNullMask(builder, NullMask);
			IInteractEffect.AddType(builder, Type);
			return IInteractEffect.EndIInteractEffect(builder);
		}

		// Token: 0x0602F2BE RID: 193214 RVA: 0x0066D068 File Offset: 0x0066B268
		public static void StartIInteractEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F2BF RID: 193215 RVA: 0x0066D071 File Offset: 0x0066B271
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F2C0 RID: 193216 RVA: 0x0066D07C File Offset: 0x0066B27C
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602F2C1 RID: 193217 RVA: 0x0066D08F File Offset: 0x0066B28F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F2C2 RID: 193218 RVA: 0x0066D09A File Offset: 0x0066B29A
		public static Offset<IInteractEffect> EndIInteractEffect(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEffect>(builder.EndTable());
		}

		// Token: 0x0602F2C3 RID: 193219 RVA: 0x0066D0A8 File Offset: 0x0066B2A8
		public IInteractEffectT UnPack()
		{
			IInteractEffectT interactEffectT = new IInteractEffectT();
			this.UnPackTo(interactEffectT);
			return interactEffectT;
		}

		// Token: 0x0602F2C4 RID: 193220 RVA: 0x0066D0C3 File Offset: 0x0066B2C3
		public void UnPackTo(IInteractEffectT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F2C5 RID: 193221 RVA: 0x0066D0EC File Offset: 0x0066B2EC
		public static Offset<IInteractEffect> Pack(FlatBufferBuilder builder, IInteractEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEffect>);
			}
			return IInteractEffect.CreateIInteractEffect(builder, _o.Type, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04011108 RID: 69896
		private Table __p;
	}
}

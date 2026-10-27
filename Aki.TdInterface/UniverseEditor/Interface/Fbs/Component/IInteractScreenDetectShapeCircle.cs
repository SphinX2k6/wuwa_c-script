using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005470 RID: 21616
	public struct IInteractScreenDetectShapeCircle : IFlatbufferObject
	{
		// Token: 0x17009F1C RID: 40732
		// (get) Token: 0x060238E9 RID: 145641 RVA: 0x004EAEBE File Offset: 0x004E90BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238EA RID: 145642 RVA: 0x004EAECB File Offset: 0x004E90CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238EB RID: 145643 RVA: 0x004EAED4 File Offset: 0x004E90D4
		public static IInteractScreenDetectShapeCircle GetRootAsIInteractScreenDetectShapeCircle(ByteBuffer _bb)
		{
			return IInteractScreenDetectShapeCircle.GetRootAsIInteractScreenDetectShapeCircle(_bb, default(IInteractScreenDetectShapeCircle));
		}

		// Token: 0x060238EC RID: 145644 RVA: 0x004EAEF0 File Offset: 0x004E90F0
		public static IInteractScreenDetectShapeCircle GetRootAsIInteractScreenDetectShapeCircle(ByteBuffer _bb, IInteractScreenDetectShapeCircle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238ED RID: 145645 RVA: 0x004EAF0D File Offset: 0x004E910D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238EE RID: 145646 RVA: 0x004EAF1C File Offset: 0x004E911C
		public IInteractScreenDetectShapeCircle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F1D RID: 40733
		// (get) Token: 0x060238EF RID: 145647 RVA: 0x004EAF2C File Offset: 0x004E912C
		public EInteractScreenDetectShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return (EInteractScreenDetectShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F1E RID: 40734
		// (get) Token: 0x060238F0 RID: 145648 RVA: 0x004EAF68 File Offset: 0x004E9168
		public float RadiusRatio
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

		// Token: 0x060238F1 RID: 145649 RVA: 0x004EAFA8 File Offset: 0x004E91A8
		public static Offset<IInteractScreenDetectShapeCircle> CreateIInteractScreenDetectShapeCircle(FlatBufferBuilder builder, EInteractScreenDetectShape Type = EInteractScreenDetectShape.Circle, float RadiusRatio = 0f)
		{
			builder.StartTable(2);
			IInteractScreenDetectShapeCircle.AddRadiusRatio(builder, RadiusRatio);
			IInteractScreenDetectShapeCircle.AddType(builder, Type);
			return IInteractScreenDetectShapeCircle.EndIInteractScreenDetectShapeCircle(builder);
		}

		// Token: 0x060238F2 RID: 145650 RVA: 0x004EAFC5 File Offset: 0x004E91C5
		public static void StartIInteractScreenDetectShapeCircle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060238F3 RID: 145651 RVA: 0x004EAFCE File Offset: 0x004E91CE
		public static void AddType(FlatBufferBuilder builder, EInteractScreenDetectShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060238F4 RID: 145652 RVA: 0x004EAFD9 File Offset: 0x004E91D9
		public static void AddRadiusRatio(FlatBufferBuilder builder, float radiusRatio)
		{
			builder.AddFloat(1, radiusRatio, 0.0);
		}

		// Token: 0x060238F5 RID: 145653 RVA: 0x004EAFEC File Offset: 0x004E91EC
		public static Offset<IInteractScreenDetectShapeCircle> EndIInteractScreenDetectShapeCircle(FlatBufferBuilder builder)
		{
			return new Offset<IInteractScreenDetectShapeCircle>(builder.EndTable());
		}

		// Token: 0x060238F6 RID: 145654 RVA: 0x004EAFFC File Offset: 0x004E91FC
		public IInteractScreenDetectShapeCircleT UnPack()
		{
			IInteractScreenDetectShapeCircleT interactScreenDetectShapeCircleT = new IInteractScreenDetectShapeCircleT();
			this.UnPackTo(interactScreenDetectShapeCircleT);
			return interactScreenDetectShapeCircleT;
		}

		// Token: 0x060238F7 RID: 145655 RVA: 0x004EB017 File Offset: 0x004E9217
		public void UnPackTo(IInteractScreenDetectShapeCircleT _o)
		{
			_o.Type = this.Type;
			_o.RadiusRatio = this.RadiusRatio;
		}

		// Token: 0x060238F8 RID: 145656 RVA: 0x004EB034 File Offset: 0x004E9234
		public static Offset<IInteractScreenDetectShapeCircle> Pack(FlatBufferBuilder builder, IInteractScreenDetectShapeCircleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractScreenDetectShapeCircle>);
			}
			return IInteractScreenDetectShapeCircle.CreateIInteractScreenDetectShapeCircle(builder, _o.Type, _o.RadiusRatio);
		}

		// Token: 0x0400E6EE RID: 59118
		private Table __p;
	}
}

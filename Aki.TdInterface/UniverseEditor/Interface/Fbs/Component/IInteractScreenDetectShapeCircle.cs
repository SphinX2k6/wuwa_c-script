using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F6 RID: 23030
	public struct IInteractScreenDetectShapeCircle : IFlatbufferObject
	{
		// Token: 0x1700A756 RID: 42838
		// (get) Token: 0x060259A1 RID: 154017 RVA: 0x00527F32 File Offset: 0x00526132
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259A2 RID: 154018 RVA: 0x00527F3F File Offset: 0x0052613F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259A3 RID: 154019 RVA: 0x00527F48 File Offset: 0x00526148
		public static IInteractScreenDetectShapeCircle GetRootAsIInteractScreenDetectShapeCircle(ByteBuffer _bb)
		{
			return IInteractScreenDetectShapeCircle.GetRootAsIInteractScreenDetectShapeCircle(_bb, default(IInteractScreenDetectShapeCircle));
		}

		// Token: 0x060259A4 RID: 154020 RVA: 0x00527F64 File Offset: 0x00526164
		public static IInteractScreenDetectShapeCircle GetRootAsIInteractScreenDetectShapeCircle(ByteBuffer _bb, IInteractScreenDetectShapeCircle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259A5 RID: 154021 RVA: 0x00527F81 File Offset: 0x00526181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259A6 RID: 154022 RVA: 0x00527F90 File Offset: 0x00526190
		public IInteractScreenDetectShapeCircle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A757 RID: 42839
		// (get) Token: 0x060259A7 RID: 154023 RVA: 0x00527FA0 File Offset: 0x005261A0
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

		// Token: 0x1700A758 RID: 42840
		// (get) Token: 0x060259A8 RID: 154024 RVA: 0x00527FDC File Offset: 0x005261DC
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

		// Token: 0x060259A9 RID: 154025 RVA: 0x0052801C File Offset: 0x0052621C
		public static Offset<IInteractScreenDetectShapeCircle> CreateIInteractScreenDetectShapeCircle(FlatBufferBuilder builder, EInteractScreenDetectShape Type = EInteractScreenDetectShape.Circle, float RadiusRatio = 0f)
		{
			builder.StartTable(2);
			IInteractScreenDetectShapeCircle.AddRadiusRatio(builder, RadiusRatio);
			IInteractScreenDetectShapeCircle.AddType(builder, Type);
			return IInteractScreenDetectShapeCircle.EndIInteractScreenDetectShapeCircle(builder);
		}

		// Token: 0x060259AA RID: 154026 RVA: 0x00528039 File Offset: 0x00526239
		public static void StartIInteractScreenDetectShapeCircle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060259AB RID: 154027 RVA: 0x00528042 File Offset: 0x00526242
		public static void AddType(FlatBufferBuilder builder, EInteractScreenDetectShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060259AC RID: 154028 RVA: 0x0052804D File Offset: 0x0052624D
		public static void AddRadiusRatio(FlatBufferBuilder builder, float radiusRatio)
		{
			builder.AddFloat(1, radiusRatio, 0.0);
		}

		// Token: 0x060259AD RID: 154029 RVA: 0x00528060 File Offset: 0x00526260
		public static Offset<IInteractScreenDetectShapeCircle> EndIInteractScreenDetectShapeCircle(FlatBufferBuilder builder)
		{
			return new Offset<IInteractScreenDetectShapeCircle>(builder.EndTable());
		}

		// Token: 0x060259AE RID: 154030 RVA: 0x00528070 File Offset: 0x00526270
		public IInteractScreenDetectShapeCircleT UnPack()
		{
			IInteractScreenDetectShapeCircleT interactScreenDetectShapeCircleT = new IInteractScreenDetectShapeCircleT();
			this.UnPackTo(interactScreenDetectShapeCircleT);
			return interactScreenDetectShapeCircleT;
		}

		// Token: 0x060259AF RID: 154031 RVA: 0x0052808B File Offset: 0x0052628B
		public void UnPackTo(IInteractScreenDetectShapeCircleT _o)
		{
			_o.Type = this.Type;
			_o.RadiusRatio = this.RadiusRatio;
		}

		// Token: 0x060259B0 RID: 154032 RVA: 0x005280A8 File Offset: 0x005262A8
		public static Offset<IInteractScreenDetectShapeCircle> Pack(FlatBufferBuilder builder, IInteractScreenDetectShapeCircleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractScreenDetectShapeCircle>);
			}
			return IInteractScreenDetectShapeCircle.CreateIInteractScreenDetectShapeCircle(builder, _o.Type, _o.RadiusRatio);
		}

		// Token: 0x0400F31F RID: 62239
		private Table __p;
	}
}

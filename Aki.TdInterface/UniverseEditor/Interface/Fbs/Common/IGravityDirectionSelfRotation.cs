using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006434 RID: 25652
	public struct IGravityDirectionSelfRotation : IFlatbufferObject
	{
		// Token: 0x1700BD6A RID: 48490
		// (get) Token: 0x0602B95A RID: 178522 RVA: 0x005EF232 File Offset: 0x005ED432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B95B RID: 178523 RVA: 0x005EF23F File Offset: 0x005ED43F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B95C RID: 178524 RVA: 0x005EF248 File Offset: 0x005ED448
		public static IGravityDirectionSelfRotation GetRootAsIGravityDirectionSelfRotation(ByteBuffer _bb)
		{
			return IGravityDirectionSelfRotation.GetRootAsIGravityDirectionSelfRotation(_bb, default(IGravityDirectionSelfRotation));
		}

		// Token: 0x0602B95D RID: 178525 RVA: 0x005EF264 File Offset: 0x005ED464
		public static IGravityDirectionSelfRotation GetRootAsIGravityDirectionSelfRotation(ByteBuffer _bb, IGravityDirectionSelfRotation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B95E RID: 178526 RVA: 0x005EF281 File Offset: 0x005ED481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B95F RID: 178527 RVA: 0x005EF290 File Offset: 0x005ED490
		public IGravityDirectionSelfRotation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD6B RID: 48491
		// (get) Token: 0x0602B960 RID: 178528 RVA: 0x005EF2A0 File Offset: 0x005ED4A0
		public EGravityDirectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityDirectionType.SelfRotation;
				}
				return (EGravityDirectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B961 RID: 178529 RVA: 0x005EF2DC File Offset: 0x005ED4DC
		public static Offset<IGravityDirectionSelfRotation> CreateIGravityDirectionSelfRotation(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation)
		{
			builder.StartTable(1);
			IGravityDirectionSelfRotation.AddType(builder, Type);
			return IGravityDirectionSelfRotation.EndIGravityDirectionSelfRotation(builder);
		}

		// Token: 0x0602B962 RID: 178530 RVA: 0x005EF2F2 File Offset: 0x005ED4F2
		public static void StartIGravityDirectionSelfRotation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B963 RID: 178531 RVA: 0x005EF2FB File Offset: 0x005ED4FB
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B964 RID: 178532 RVA: 0x005EF306 File Offset: 0x005ED506
		public static Offset<IGravityDirectionSelfRotation> EndIGravityDirectionSelfRotation(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionSelfRotation>(builder.EndTable());
		}

		// Token: 0x0602B965 RID: 178533 RVA: 0x005EF314 File Offset: 0x005ED514
		public IGravityDirectionSelfRotationT UnPack()
		{
			IGravityDirectionSelfRotationT gravityDirectionSelfRotationT = new IGravityDirectionSelfRotationT();
			this.UnPackTo(gravityDirectionSelfRotationT);
			return gravityDirectionSelfRotationT;
		}

		// Token: 0x0602B966 RID: 178534 RVA: 0x005EF32F File Offset: 0x005ED52F
		public void UnPackTo(IGravityDirectionSelfRotationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B967 RID: 178535 RVA: 0x005EF340 File Offset: 0x005ED540
		public static Offset<IGravityDirectionSelfRotation> Pack(FlatBufferBuilder builder, IGravityDirectionSelfRotationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionSelfRotation>);
			}
			return IGravityDirectionSelfRotation.CreateIGravityDirectionSelfRotation(builder, _o.Type);
		}

		// Token: 0x04010540 RID: 66880
		private Table __p;
	}
}

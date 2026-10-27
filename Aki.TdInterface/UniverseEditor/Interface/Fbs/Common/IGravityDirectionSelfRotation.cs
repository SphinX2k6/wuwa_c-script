using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF7 RID: 24055
	public struct IGravityDirectionSelfRotation : IFlatbufferObject
	{
		// Token: 0x1700B404 RID: 46084
		// (get) Token: 0x060292D0 RID: 168656 RVA: 0x005A6502 File Offset: 0x005A4702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292D1 RID: 168657 RVA: 0x005A650F File Offset: 0x005A470F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292D2 RID: 168658 RVA: 0x005A6518 File Offset: 0x005A4718
		public static IGravityDirectionSelfRotation GetRootAsIGravityDirectionSelfRotation(ByteBuffer _bb)
		{
			return IGravityDirectionSelfRotation.GetRootAsIGravityDirectionSelfRotation(_bb, default(IGravityDirectionSelfRotation));
		}

		// Token: 0x060292D3 RID: 168659 RVA: 0x005A6534 File Offset: 0x005A4734
		public static IGravityDirectionSelfRotation GetRootAsIGravityDirectionSelfRotation(ByteBuffer _bb, IGravityDirectionSelfRotation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292D4 RID: 168660 RVA: 0x005A6551 File Offset: 0x005A4751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292D5 RID: 168661 RVA: 0x005A6560 File Offset: 0x005A4760
		public IGravityDirectionSelfRotation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B405 RID: 46085
		// (get) Token: 0x060292D6 RID: 168662 RVA: 0x005A6570 File Offset: 0x005A4770
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

		// Token: 0x060292D7 RID: 168663 RVA: 0x005A65AC File Offset: 0x005A47AC
		public static Offset<IGravityDirectionSelfRotation> CreateIGravityDirectionSelfRotation(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation)
		{
			builder.StartTable(1);
			IGravityDirectionSelfRotation.AddType(builder, Type);
			return IGravityDirectionSelfRotation.EndIGravityDirectionSelfRotation(builder);
		}

		// Token: 0x060292D8 RID: 168664 RVA: 0x005A65C2 File Offset: 0x005A47C2
		public static void StartIGravityDirectionSelfRotation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060292D9 RID: 168665 RVA: 0x005A65CB File Offset: 0x005A47CB
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060292DA RID: 168666 RVA: 0x005A65D6 File Offset: 0x005A47D6
		public static Offset<IGravityDirectionSelfRotation> EndIGravityDirectionSelfRotation(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionSelfRotation>(builder.EndTable());
		}

		// Token: 0x060292DB RID: 168667 RVA: 0x005A65E4 File Offset: 0x005A47E4
		public IGravityDirectionSelfRotationT UnPack()
		{
			IGravityDirectionSelfRotationT gravityDirectionSelfRotationT = new IGravityDirectionSelfRotationT();
			this.UnPackTo(gravityDirectionSelfRotationT);
			return gravityDirectionSelfRotationT;
		}

		// Token: 0x060292DC RID: 168668 RVA: 0x005A65FF File Offset: 0x005A47FF
		public void UnPackTo(IGravityDirectionSelfRotationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060292DD RID: 168669 RVA: 0x005A6610 File Offset: 0x005A4810
		public static Offset<IGravityDirectionSelfRotation> Pack(FlatBufferBuilder builder, IGravityDirectionSelfRotationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionSelfRotation>);
			}
			return IGravityDirectionSelfRotation.CreateIGravityDirectionSelfRotation(builder, _o.Type);
		}

		// Token: 0x0400F7E5 RID: 63461
		private Table __p;
	}
}

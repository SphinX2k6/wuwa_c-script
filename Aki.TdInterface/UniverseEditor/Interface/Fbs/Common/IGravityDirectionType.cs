using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DFA RID: 24058
	public struct IGravityDirectionType : IFlatbufferObject
	{
		// Token: 0x1700B407 RID: 46087
		// (get) Token: 0x060292E2 RID: 168674 RVA: 0x005A6679 File Offset: 0x005A4879
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292E3 RID: 168675 RVA: 0x005A6686 File Offset: 0x005A4886
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292E4 RID: 168676 RVA: 0x005A6690 File Offset: 0x005A4890
		public static IGravityDirectionType GetRootAsIGravityDirectionType(ByteBuffer _bb)
		{
			return IGravityDirectionType.GetRootAsIGravityDirectionType(_bb, default(IGravityDirectionType));
		}

		// Token: 0x060292E5 RID: 168677 RVA: 0x005A66AC File Offset: 0x005A48AC
		public static IGravityDirectionType GetRootAsIGravityDirectionType(ByteBuffer _bb, IGravityDirectionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292E6 RID: 168678 RVA: 0x005A66C9 File Offset: 0x005A48C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292E7 RID: 168679 RVA: 0x005A66D8 File Offset: 0x005A48D8
		public IGravityDirectionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B408 RID: 46088
		// (get) Token: 0x060292E8 RID: 168680 RVA: 0x005A66E8 File Offset: 0x005A48E8
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

		// Token: 0x060292E9 RID: 168681 RVA: 0x005A6724 File Offset: 0x005A4924
		public static Offset<IGravityDirectionType> CreateIGravityDirectionType(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation)
		{
			builder.StartTable(1);
			IGravityDirectionType.AddType(builder, Type);
			return IGravityDirectionType.EndIGravityDirectionType(builder);
		}

		// Token: 0x060292EA RID: 168682 RVA: 0x005A673A File Offset: 0x005A493A
		public static void StartIGravityDirectionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060292EB RID: 168683 RVA: 0x005A6743 File Offset: 0x005A4943
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060292EC RID: 168684 RVA: 0x005A674E File Offset: 0x005A494E
		public static Offset<IGravityDirectionType> EndIGravityDirectionType(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionType>(builder.EndTable());
		}

		// Token: 0x060292ED RID: 168685 RVA: 0x005A675C File Offset: 0x005A495C
		public IGravityDirectionTypeT UnPack()
		{
			IGravityDirectionTypeT gravityDirectionTypeT = new IGravityDirectionTypeT();
			this.UnPackTo(gravityDirectionTypeT);
			return gravityDirectionTypeT;
		}

		// Token: 0x060292EE RID: 168686 RVA: 0x005A6777 File Offset: 0x005A4977
		public void UnPackTo(IGravityDirectionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060292EF RID: 168687 RVA: 0x005A6788 File Offset: 0x005A4988
		public static Offset<IGravityDirectionType> Pack(FlatBufferBuilder builder, IGravityDirectionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionType>);
			}
			return IGravityDirectionType.CreateIGravityDirectionType(builder, _o.Type);
		}

		// Token: 0x0400F7E7 RID: 63463
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DD RID: 25821
	public struct IControlTrackingType : IFlatbufferObject
	{
		// Token: 0x1700C01F RID: 49183
		// (get) Token: 0x0602CCA6 RID: 183462 RVA: 0x00627A95 File Offset: 0x00625C95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCA7 RID: 183463 RVA: 0x00627AA2 File Offset: 0x00625CA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCA8 RID: 183464 RVA: 0x00627AAC File Offset: 0x00625CAC
		public static IControlTrackingType GetRootAsIControlTrackingType(ByteBuffer _bb)
		{
			return IControlTrackingType.GetRootAsIControlTrackingType(_bb, default(IControlTrackingType));
		}

		// Token: 0x0602CCA9 RID: 183465 RVA: 0x00627AC8 File Offset: 0x00625CC8
		public static IControlTrackingType GetRootAsIControlTrackingType(ByteBuffer _bb, IControlTrackingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCAA RID: 183466 RVA: 0x00627AE5 File Offset: 0x00625CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCAB RID: 183467 RVA: 0x00627AF4 File Offset: 0x00625CF4
		public IControlTrackingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C020 RID: 49184
		// (get) Token: 0x0602CCAC RID: 183468 RVA: 0x00627B04 File Offset: 0x00625D04
		public EControlTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlTrackingType.Self;
				}
				return (EControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CCAD RID: 183469 RVA: 0x00627B40 File Offset: 0x00625D40
		public static Offset<IControlTrackingType> CreateIControlTrackingType(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self)
		{
			builder.StartTable(1);
			IControlTrackingType.AddType(builder, Type);
			return IControlTrackingType.EndIControlTrackingType(builder);
		}

		// Token: 0x0602CCAE RID: 183470 RVA: 0x00627B56 File Offset: 0x00625D56
		public static void StartIControlTrackingType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CCAF RID: 183471 RVA: 0x00627B5F File Offset: 0x00625D5F
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CCB0 RID: 183472 RVA: 0x00627B6A File Offset: 0x00625D6A
		public static Offset<IControlTrackingType> EndIControlTrackingType(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingType>(builder.EndTable());
		}

		// Token: 0x0602CCB1 RID: 183473 RVA: 0x00627B78 File Offset: 0x00625D78
		public IControlTrackingTypeT UnPack()
		{
			IControlTrackingTypeT controlTrackingTypeT = new IControlTrackingTypeT();
			this.UnPackTo(controlTrackingTypeT);
			return controlTrackingTypeT;
		}

		// Token: 0x0602CCB2 RID: 183474 RVA: 0x00627B93 File Offset: 0x00625D93
		public void UnPackTo(IControlTrackingTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CCB3 RID: 183475 RVA: 0x00627BA4 File Offset: 0x00625DA4
		public static Offset<IControlTrackingType> Pack(FlatBufferBuilder builder, IControlTrackingTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingType>);
			}
			return IControlTrackingType.CreateIControlTrackingType(builder, _o.Type);
		}

		// Token: 0x04010B17 RID: 68375
		private Table __p;
	}
}

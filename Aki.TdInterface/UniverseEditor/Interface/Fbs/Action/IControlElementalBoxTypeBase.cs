using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3C RID: 27452
	public struct IControlElementalBoxTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C99F RID: 51615
		// (get) Token: 0x0602F3DA RID: 193498 RVA: 0x00673459 File Offset: 0x00671659
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3DB RID: 193499 RVA: 0x00673466 File Offset: 0x00671666
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3DC RID: 193500 RVA: 0x00673470 File Offset: 0x00671670
		public static IControlElementalBoxTypeBase GetRootAsIControlElementalBoxTypeBase(ByteBuffer _bb)
		{
			return IControlElementalBoxTypeBase.GetRootAsIControlElementalBoxTypeBase(_bb, default(IControlElementalBoxTypeBase));
		}

		// Token: 0x0602F3DD RID: 193501 RVA: 0x0067348C File Offset: 0x0067168C
		public static IControlElementalBoxTypeBase GetRootAsIControlElementalBoxTypeBase(ByteBuffer _bb, IControlElementalBoxTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3DE RID: 193502 RVA: 0x006734A9 File Offset: 0x006716A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3DF RID: 193503 RVA: 0x006734B8 File Offset: 0x006716B8
		public IControlElementalBoxTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9A0 RID: 51616
		// (get) Token: 0x0602F3E0 RID: 193504 RVA: 0x006734C8 File Offset: 0x006716C8
		public EControlElementalBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlElementalBoxType.Capture;
				}
				return (EControlElementalBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3E1 RID: 193505 RVA: 0x00673504 File Offset: 0x00671704
		public static Offset<IControlElementalBoxTypeBase> CreateIControlElementalBoxTypeBase(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture)
		{
			builder.StartTable(1);
			IControlElementalBoxTypeBase.AddType(builder, Type);
			return IControlElementalBoxTypeBase.EndIControlElementalBoxTypeBase(builder);
		}

		// Token: 0x0602F3E2 RID: 193506 RVA: 0x0067351A File Offset: 0x0067171A
		public static void StartIControlElementalBoxTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F3E3 RID: 193507 RVA: 0x00673523 File Offset: 0x00671723
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F3E4 RID: 193508 RVA: 0x0067352E File Offset: 0x0067172E
		public static Offset<IControlElementalBoxTypeBase> EndIControlElementalBoxTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxTypeBase>(builder.EndTable());
		}

		// Token: 0x0602F3E5 RID: 193509 RVA: 0x0067353C File Offset: 0x0067173C
		public IControlElementalBoxTypeBaseT UnPack()
		{
			IControlElementalBoxTypeBaseT controlElementalBoxTypeBaseT = new IControlElementalBoxTypeBaseT();
			this.UnPackTo(controlElementalBoxTypeBaseT);
			return controlElementalBoxTypeBaseT;
		}

		// Token: 0x0602F3E6 RID: 193510 RVA: 0x00673557 File Offset: 0x00671757
		public void UnPackTo(IControlElementalBoxTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F3E7 RID: 193511 RVA: 0x00673568 File Offset: 0x00671768
		public static Offset<IControlElementalBoxTypeBase> Pack(FlatBufferBuilder builder, IControlElementalBoxTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxTypeBase>);
			}
			return IControlElementalBoxTypeBase.CreateIControlElementalBoxTypeBase(builder, _o.Type);
		}

		// Token: 0x0401191F RID: 71967
		private Table __p;
	}
}

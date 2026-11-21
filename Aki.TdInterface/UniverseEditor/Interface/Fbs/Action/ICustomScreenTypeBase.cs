using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7E RID: 27518
	public struct ICustomScreenTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C9F3 RID: 51699
		// (get) Token: 0x0602F5A9 RID: 193961 RVA: 0x006762D6 File Offset: 0x006744D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5AA RID: 193962 RVA: 0x006762E3 File Offset: 0x006744E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5AB RID: 193963 RVA: 0x006762EC File Offset: 0x006744EC
		public static ICustomScreenTypeBase GetRootAsICustomScreenTypeBase(ByteBuffer _bb)
		{
			return ICustomScreenTypeBase.GetRootAsICustomScreenTypeBase(_bb, default(ICustomScreenTypeBase));
		}

		// Token: 0x0602F5AC RID: 193964 RVA: 0x00676308 File Offset: 0x00674508
		public static ICustomScreenTypeBase GetRootAsICustomScreenTypeBase(ByteBuffer _bb, ICustomScreenTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5AD RID: 193965 RVA: 0x00676325 File Offset: 0x00674525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5AE RID: 193966 RVA: 0x00676334 File Offset: 0x00674534
		public ICustomScreenTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9F4 RID: 51700
		// (get) Token: 0x0602F5AF RID: 193967 RVA: 0x00676344 File Offset: 0x00674544
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F5B0 RID: 193968 RVA: 0x00676380 File Offset: 0x00674580
		public static Offset<ICustomScreenTypeBase> CreateICustomScreenTypeBase(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine)
		{
			builder.StartTable(1);
			ICustomScreenTypeBase.AddType(builder, Type);
			return ICustomScreenTypeBase.EndICustomScreenTypeBase(builder);
		}

		// Token: 0x0602F5B1 RID: 193969 RVA: 0x00676396 File Offset: 0x00674596
		public static void StartICustomScreenTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F5B2 RID: 193970 RVA: 0x0067639F File Offset: 0x0067459F
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F5B3 RID: 193971 RVA: 0x006763AA File Offset: 0x006745AA
		public static Offset<ICustomScreenTypeBase> EndICustomScreenTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenTypeBase>(builder.EndTable());
		}

		// Token: 0x0602F5B4 RID: 193972 RVA: 0x006763B8 File Offset: 0x006745B8
		public ICustomScreenTypeBaseT UnPack()
		{
			ICustomScreenTypeBaseT customScreenTypeBaseT = new ICustomScreenTypeBaseT();
			this.UnPackTo(customScreenTypeBaseT);
			return customScreenTypeBaseT;
		}

		// Token: 0x0602F5B5 RID: 193973 RVA: 0x006763D3 File Offset: 0x006745D3
		public void UnPackTo(ICustomScreenTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F5B6 RID: 193974 RVA: 0x006763E4 File Offset: 0x006745E4
		public static Offset<ICustomScreenTypeBase> Pack(FlatBufferBuilder builder, ICustomScreenTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenTypeBase>);
			}
			return ICustomScreenTypeBase.CreateICustomScreenTypeBase(builder, _o.Type);
		}

		// Token: 0x0401196D RID: 72045
		private Table __p;
	}
}

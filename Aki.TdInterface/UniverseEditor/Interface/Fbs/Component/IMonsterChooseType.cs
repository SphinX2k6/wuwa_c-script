using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005569 RID: 21865
	public struct IMonsterChooseType : IFlatbufferObject
	{
		// Token: 0x1700A18B RID: 41355
		// (get) Token: 0x060242BF RID: 148159 RVA: 0x004FEFC7 File Offset: 0x004FD1C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060242C0 RID: 148160 RVA: 0x004FEFD4 File Offset: 0x004FD1D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060242C1 RID: 148161 RVA: 0x004FEFDC File Offset: 0x004FD1DC
		public static IMonsterChooseType GetRootAsIMonsterChooseType(ByteBuffer _bb)
		{
			return IMonsterChooseType.GetRootAsIMonsterChooseType(_bb, default(IMonsterChooseType));
		}

		// Token: 0x060242C2 RID: 148162 RVA: 0x004FEFF8 File Offset: 0x004FD1F8
		public static IMonsterChooseType GetRootAsIMonsterChooseType(ByteBuffer _bb, IMonsterChooseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060242C3 RID: 148163 RVA: 0x004FF015 File Offset: 0x004FD215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060242C4 RID: 148164 RVA: 0x004FF024 File Offset: 0x004FD224
		public IMonsterChooseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A18C RID: 41356
		// (get) Token: 0x060242C5 RID: 148165 RVA: 0x004FF034 File Offset: 0x004FD234
		public EMonsterChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return (EMonsterChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242C6 RID: 148166 RVA: 0x004FF070 File Offset: 0x004FD270
		public static Offset<IMonsterChooseType> CreateIMonsterChooseType(FlatBufferBuilder builder, EMonsterChooseType Type = EMonsterChooseType.RandomPoolChoose)
		{
			builder.StartTable(1);
			IMonsterChooseType.AddType(builder, Type);
			return IMonsterChooseType.EndIMonsterChooseType(builder);
		}

		// Token: 0x060242C7 RID: 148167 RVA: 0x004FF086 File Offset: 0x004FD286
		public static void StartIMonsterChooseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060242C8 RID: 148168 RVA: 0x004FF08F File Offset: 0x004FD28F
		public static void AddType(FlatBufferBuilder builder, EMonsterChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060242C9 RID: 148169 RVA: 0x004FF09A File Offset: 0x004FD29A
		public static Offset<IMonsterChooseType> EndIMonsterChooseType(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterChooseType>(builder.EndTable());
		}

		// Token: 0x060242CA RID: 148170 RVA: 0x004FF0A8 File Offset: 0x004FD2A8
		public IMonsterChooseTypeT UnPack()
		{
			IMonsterChooseTypeT monsterChooseTypeT = new IMonsterChooseTypeT();
			this.UnPackTo(monsterChooseTypeT);
			return monsterChooseTypeT;
		}

		// Token: 0x060242CB RID: 148171 RVA: 0x004FF0C3 File Offset: 0x004FD2C3
		public void UnPackTo(IMonsterChooseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060242CC RID: 148172 RVA: 0x004FF0D4 File Offset: 0x004FD2D4
		public static Offset<IMonsterChooseType> Pack(FlatBufferBuilder builder, IMonsterChooseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterChooseType>);
			}
			return IMonsterChooseType.CreateIMonsterChooseType(builder, _o.Type);
		}

		// Token: 0x0400E88A RID: 59530
		private Table __p;
	}
}

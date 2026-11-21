using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFB RID: 23291
	public struct IMonsterChooseType : IFlatbufferObject
	{
		// Token: 0x1700AA01 RID: 43521
		// (get) Token: 0x06026464 RID: 156772 RVA: 0x0053E88B File Offset: 0x0053CA8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026465 RID: 156773 RVA: 0x0053E898 File Offset: 0x0053CA98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026466 RID: 156774 RVA: 0x0053E8A0 File Offset: 0x0053CAA0
		public static IMonsterChooseType GetRootAsIMonsterChooseType(ByteBuffer _bb)
		{
			return IMonsterChooseType.GetRootAsIMonsterChooseType(_bb, default(IMonsterChooseType));
		}

		// Token: 0x06026467 RID: 156775 RVA: 0x0053E8BC File Offset: 0x0053CABC
		public static IMonsterChooseType GetRootAsIMonsterChooseType(ByteBuffer _bb, IMonsterChooseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026468 RID: 156776 RVA: 0x0053E8D9 File Offset: 0x0053CAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026469 RID: 156777 RVA: 0x0053E8E8 File Offset: 0x0053CAE8
		public IMonsterChooseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA02 RID: 43522
		// (get) Token: 0x0602646A RID: 156778 RVA: 0x0053E8F8 File Offset: 0x0053CAF8
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

		// Token: 0x0602646B RID: 156779 RVA: 0x0053E934 File Offset: 0x0053CB34
		public static Offset<IMonsterChooseType> CreateIMonsterChooseType(FlatBufferBuilder builder, EMonsterChooseType Type = EMonsterChooseType.RandomPoolChoose)
		{
			builder.StartTable(1);
			IMonsterChooseType.AddType(builder, Type);
			return IMonsterChooseType.EndIMonsterChooseType(builder);
		}

		// Token: 0x0602646C RID: 156780 RVA: 0x0053E94A File Offset: 0x0053CB4A
		public static void StartIMonsterChooseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602646D RID: 156781 RVA: 0x0053E953 File Offset: 0x0053CB53
		public static void AddType(FlatBufferBuilder builder, EMonsterChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602646E RID: 156782 RVA: 0x0053E95E File Offset: 0x0053CB5E
		public static Offset<IMonsterChooseType> EndIMonsterChooseType(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterChooseType>(builder.EndTable());
		}

		// Token: 0x0602646F RID: 156783 RVA: 0x0053E96C File Offset: 0x0053CB6C
		public IMonsterChooseTypeT UnPack()
		{
			IMonsterChooseTypeT monsterChooseTypeT = new IMonsterChooseTypeT();
			this.UnPackTo(monsterChooseTypeT);
			return monsterChooseTypeT;
		}

		// Token: 0x06026470 RID: 156784 RVA: 0x0053E987 File Offset: 0x0053CB87
		public void UnPackTo(IMonsterChooseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026471 RID: 156785 RVA: 0x0053E998 File Offset: 0x0053CB98
		public static Offset<IMonsterChooseType> Pack(FlatBufferBuilder builder, IMonsterChooseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterChooseType>);
			}
			return IMonsterChooseType.CreateIMonsterChooseType(builder, _o.Type);
		}

		// Token: 0x0400F4DC RID: 62684
		private Table __p;
	}
}

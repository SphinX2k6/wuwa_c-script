using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004500 RID: 17664
	public struct ILevelPlayInteractResetOption : IFlatbufferObject
	{
		// Token: 0x17007D36 RID: 32054
		// (get) Token: 0x0601A86B RID: 108651 RVA: 0x003C9D8C File Offset: 0x003C7F8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A86C RID: 108652 RVA: 0x003C9D99 File Offset: 0x003C7F99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x003C9DA0 File Offset: 0x003C7FA0
		public static ILevelPlayInteractResetOption GetRootAsILevelPlayInteractResetOption(ByteBuffer _bb)
		{
			return ILevelPlayInteractResetOption.GetRootAsILevelPlayInteractResetOption(_bb, default(ILevelPlayInteractResetOption));
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x003C9DBC File Offset: 0x003C7FBC
		public static ILevelPlayInteractResetOption GetRootAsILevelPlayInteractResetOption(ByteBuffer _bb, ILevelPlayInteractResetOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x003C9DD9 File Offset: 0x003C7FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A870 RID: 108656 RVA: 0x003C9DE8 File Offset: 0x003C7FE8
		public ILevelPlayInteractResetOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D37 RID: 32055
		// (get) Token: 0x0601A871 RID: 108657 RVA: 0x003C9DF8 File Offset: 0x003C7FF8
		public int Count
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D38 RID: 32056
		// (get) Token: 0x0601A872 RID: 108658 RVA: 0x003C9E34 File Offset: 0x003C8034
		public ELevelPlayInteractResetTime Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELevelPlayInteractResetTime.Weekly;
				}
				return (ELevelPlayInteractResetTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A873 RID: 108659 RVA: 0x003C9E70 File Offset: 0x003C8070
		public static Offset<ILevelPlayInteractResetOption> CreateILevelPlayInteractResetOption(FlatBufferBuilder builder, int Count = 0, ELevelPlayInteractResetTime Type = ELevelPlayInteractResetTime.Weekly)
		{
			builder.StartTable(2);
			ILevelPlayInteractResetOption.AddCount(builder, Count);
			ILevelPlayInteractResetOption.AddType(builder, Type);
			return ILevelPlayInteractResetOption.EndILevelPlayInteractResetOption(builder);
		}

		// Token: 0x0601A874 RID: 108660 RVA: 0x003C9E8D File Offset: 0x003C808D
		public static void StartILevelPlayInteractResetOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A875 RID: 108661 RVA: 0x003C9E96 File Offset: 0x003C8096
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(0, count, 0);
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x003C9EA1 File Offset: 0x003C80A1
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInteractResetTime type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A877 RID: 108663 RVA: 0x003C9EAC File Offset: 0x003C80AC
		public static Offset<ILevelPlayInteractResetOption> EndILevelPlayInteractResetOption(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInteractResetOption>(builder.EndTable());
		}

		// Token: 0x0601A878 RID: 108664 RVA: 0x003C9EBC File Offset: 0x003C80BC
		public ILevelPlayInteractResetOptionT UnPack()
		{
			ILevelPlayInteractResetOptionT levelPlayInteractResetOptionT = new ILevelPlayInteractResetOptionT();
			this.UnPackTo(levelPlayInteractResetOptionT);
			return levelPlayInteractResetOptionT;
		}

		// Token: 0x0601A879 RID: 108665 RVA: 0x003C9ED7 File Offset: 0x003C80D7
		public void UnPackTo(ILevelPlayInteractResetOptionT _o)
		{
			_o.Count = this.Count;
			_o.Type = this.Type;
		}

		// Token: 0x0601A87A RID: 108666 RVA: 0x003C9EF4 File Offset: 0x003C80F4
		public static Offset<ILevelPlayInteractResetOption> Pack(FlatBufferBuilder builder, ILevelPlayInteractResetOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInteractResetOption>);
			}
			return ILevelPlayInteractResetOption.CreateILevelPlayInteractResetOption(builder, _o.Count, _o.Type);
		}

		// Token: 0x0400C566 RID: 50534
		private Table __p;
	}
}

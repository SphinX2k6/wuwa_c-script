using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004917 RID: 18711
	public struct IFindSunSpiritGridBase : IFlatbufferObject
	{
		// Token: 0x1700825A RID: 33370
		// (get) Token: 0x0601BC07 RID: 113671 RVA: 0x003EC877 File Offset: 0x003EAA77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC08 RID: 113672 RVA: 0x003EC884 File Offset: 0x003EAA84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC09 RID: 113673 RVA: 0x003EC88C File Offset: 0x003EAA8C
		public static IFindSunSpiritGridBase GetRootAsIFindSunSpiritGridBase(ByteBuffer _bb)
		{
			return IFindSunSpiritGridBase.GetRootAsIFindSunSpiritGridBase(_bb, default(IFindSunSpiritGridBase));
		}

		// Token: 0x0601BC0A RID: 113674 RVA: 0x003EC8A8 File Offset: 0x003EAAA8
		public static IFindSunSpiritGridBase GetRootAsIFindSunSpiritGridBase(ByteBuffer _bb, IFindSunSpiritGridBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC0B RID: 113675 RVA: 0x003EC8C5 File Offset: 0x003EAAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC0C RID: 113676 RVA: 0x003EC8D4 File Offset: 0x003EAAD4
		public IFindSunSpiritGridBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700825B RID: 33371
		// (get) Token: 0x0601BC0D RID: 113677 RVA: 0x003EC8E4 File Offset: 0x003EAAE4
		public EFindSunSpiritGridType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFindSunSpiritGridType.Empty;
				}
				return (EFindSunSpiritGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC0E RID: 113678 RVA: 0x003EC920 File Offset: 0x003EAB20
		public static Offset<IFindSunSpiritGridBase> CreateIFindSunSpiritGridBase(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridBase.AddType(builder, Type);
			return IFindSunSpiritGridBase.EndIFindSunSpiritGridBase(builder);
		}

		// Token: 0x0601BC0F RID: 113679 RVA: 0x003EC936 File Offset: 0x003EAB36
		public static void StartIFindSunSpiritGridBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BC10 RID: 113680 RVA: 0x003EC93F File Offset: 0x003EAB3F
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BC11 RID: 113681 RVA: 0x003EC94A File Offset: 0x003EAB4A
		public static Offset<IFindSunSpiritGridBase> EndIFindSunSpiritGridBase(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridBase>(builder.EndTable());
		}

		// Token: 0x0601BC12 RID: 113682 RVA: 0x003EC958 File Offset: 0x003EAB58
		public IFindSunSpiritGridBaseT UnPack()
		{
			IFindSunSpiritGridBaseT findSunSpiritGridBaseT = new IFindSunSpiritGridBaseT();
			this.UnPackTo(findSunSpiritGridBaseT);
			return findSunSpiritGridBaseT;
		}

		// Token: 0x0601BC13 RID: 113683 RVA: 0x003EC973 File Offset: 0x003EAB73
		public void UnPackTo(IFindSunSpiritGridBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BC14 RID: 113684 RVA: 0x003EC984 File Offset: 0x003EAB84
		public static Offset<IFindSunSpiritGridBase> Pack(FlatBufferBuilder builder, IFindSunSpiritGridBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridBase>);
			}
			return IFindSunSpiritGridBase.CreateIFindSunSpiritGridBase(builder, _o.Type);
		}

		// Token: 0x0400CEEB RID: 52971
		private Table __p;
	}
}

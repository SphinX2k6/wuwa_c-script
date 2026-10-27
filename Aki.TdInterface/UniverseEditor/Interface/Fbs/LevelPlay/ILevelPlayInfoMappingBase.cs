using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F1 RID: 17649
	public struct ILevelPlayInfoMappingBase : IFlatbufferObject
	{
		// Token: 0x17007D12 RID: 32018
		// (get) Token: 0x0601A7C5 RID: 108485 RVA: 0x003C8A07 File Offset: 0x003C6C07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A7C6 RID: 108486 RVA: 0x003C8A14 File Offset: 0x003C6C14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A7C7 RID: 108487 RVA: 0x003C8A1C File Offset: 0x003C6C1C
		public static ILevelPlayInfoMappingBase GetRootAsILevelPlayInfoMappingBase(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingBase.GetRootAsILevelPlayInfoMappingBase(_bb, default(ILevelPlayInfoMappingBase));
		}

		// Token: 0x0601A7C8 RID: 108488 RVA: 0x003C8A38 File Offset: 0x003C6C38
		public static ILevelPlayInfoMappingBase GetRootAsILevelPlayInfoMappingBase(ByteBuffer _bb, ILevelPlayInfoMappingBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A7C9 RID: 108489 RVA: 0x003C8A55 File Offset: 0x003C6C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A7CA RID: 108490 RVA: 0x003C8A64 File Offset: 0x003C6C64
		public ILevelPlayInfoMappingBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D13 RID: 32019
		// (get) Token: 0x0601A7CB RID: 108491 RVA: 0x003C8A74 File Offset: 0x003C6C74
		public ELevelPlayInfoMappingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayInfoMappingType.PunishReport;
				}
				return (ELevelPlayInfoMappingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A7CC RID: 108492 RVA: 0x003C8AB0 File Offset: 0x003C6CB0
		public static Offset<ILevelPlayInfoMappingBase> CreateILevelPlayInfoMappingBase(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport)
		{
			builder.StartTable(1);
			ILevelPlayInfoMappingBase.AddType(builder, Type);
			return ILevelPlayInfoMappingBase.EndILevelPlayInfoMappingBase(builder);
		}

		// Token: 0x0601A7CD RID: 108493 RVA: 0x003C8AC6 File Offset: 0x003C6CC6
		public static void StartILevelPlayInfoMappingBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A7CE RID: 108494 RVA: 0x003C8ACF File Offset: 0x003C6CCF
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A7CF RID: 108495 RVA: 0x003C8ADA File Offset: 0x003C6CDA
		public static Offset<ILevelPlayInfoMappingBase> EndILevelPlayInfoMappingBase(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingBase>(builder.EndTable());
		}

		// Token: 0x0601A7D0 RID: 108496 RVA: 0x003C8AE8 File Offset: 0x003C6CE8
		public ILevelPlayInfoMappingBaseT UnPack()
		{
			ILevelPlayInfoMappingBaseT levelPlayInfoMappingBaseT = new ILevelPlayInfoMappingBaseT();
			this.UnPackTo(levelPlayInfoMappingBaseT);
			return levelPlayInfoMappingBaseT;
		}

		// Token: 0x0601A7D1 RID: 108497 RVA: 0x003C8B03 File Offset: 0x003C6D03
		public void UnPackTo(ILevelPlayInfoMappingBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A7D2 RID: 108498 RVA: 0x003C8B14 File Offset: 0x003C6D14
		public static Offset<ILevelPlayInfoMappingBase> Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInfoMappingBase>);
			}
			return ILevelPlayInfoMappingBase.CreateILevelPlayInfoMappingBase(builder, _o.Type);
		}

		// Token: 0x0400C54B RID: 50507
		private Table __p;
	}
}

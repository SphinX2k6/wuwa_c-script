using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004959 RID: 18777
	public struct ILevelPlayInfoMappingBase : IFlatbufferObject
	{
		// Token: 0x17008353 RID: 33619
		// (get) Token: 0x0601BF9A RID: 114586 RVA: 0x003F4CA3 File Offset: 0x003F2EA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF9B RID: 114587 RVA: 0x003F4CB0 File Offset: 0x003F2EB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF9C RID: 114588 RVA: 0x003F4CB8 File Offset: 0x003F2EB8
		public static ILevelPlayInfoMappingBase GetRootAsILevelPlayInfoMappingBase(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingBase.GetRootAsILevelPlayInfoMappingBase(_bb, default(ILevelPlayInfoMappingBase));
		}

		// Token: 0x0601BF9D RID: 114589 RVA: 0x003F4CD4 File Offset: 0x003F2ED4
		public static ILevelPlayInfoMappingBase GetRootAsILevelPlayInfoMappingBase(ByteBuffer _bb, ILevelPlayInfoMappingBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF9E RID: 114590 RVA: 0x003F4CF1 File Offset: 0x003F2EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF9F RID: 114591 RVA: 0x003F4D00 File Offset: 0x003F2F00
		public ILevelPlayInfoMappingBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008354 RID: 33620
		// (get) Token: 0x0601BFA0 RID: 114592 RVA: 0x003F4D10 File Offset: 0x003F2F10
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

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x003F4D4C File Offset: 0x003F2F4C
		public static Offset<ILevelPlayInfoMappingBase> CreateILevelPlayInfoMappingBase(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport)
		{
			builder.StartTable(1);
			ILevelPlayInfoMappingBase.AddType(builder, Type);
			return ILevelPlayInfoMappingBase.EndILevelPlayInfoMappingBase(builder);
		}

		// Token: 0x0601BFA2 RID: 114594 RVA: 0x003F4D62 File Offset: 0x003F2F62
		public static void StartILevelPlayInfoMappingBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BFA3 RID: 114595 RVA: 0x003F4D6B File Offset: 0x003F2F6B
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BFA4 RID: 114596 RVA: 0x003F4D76 File Offset: 0x003F2F76
		public static Offset<ILevelPlayInfoMappingBase> EndILevelPlayInfoMappingBase(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingBase>(builder.EndTable());
		}

		// Token: 0x0601BFA5 RID: 114597 RVA: 0x003F4D84 File Offset: 0x003F2F84
		public ILevelPlayInfoMappingBaseT UnPack()
		{
			ILevelPlayInfoMappingBaseT levelPlayInfoMappingBaseT = new ILevelPlayInfoMappingBaseT();
			this.UnPackTo(levelPlayInfoMappingBaseT);
			return levelPlayInfoMappingBaseT;
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x003F4D9F File Offset: 0x003F2F9F
		public void UnPackTo(ILevelPlayInfoMappingBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x003F4DB0 File Offset: 0x003F2FB0
		public static Offset<ILevelPlayInfoMappingBase> Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInfoMappingBase>);
			}
			return ILevelPlayInfoMappingBase.CreateILevelPlayInfoMappingBase(builder, _o.Type);
		}

		// Token: 0x0400CF7A RID: 53114
		private Table __p;
	}
}

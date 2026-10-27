using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE1 RID: 15073
	public struct ITargetLevelEntity : IFlatbufferObject
	{
		// Token: 0x17006768 RID: 26472
		// (get) Token: 0x0601488C RID: 84108 RVA: 0x002FDBB0 File Offset: 0x002FBDB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601488D RID: 84109 RVA: 0x002FDBBD File Offset: 0x002FBDBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601488E RID: 84110 RVA: 0x002FDBC4 File Offset: 0x002FBDC4
		public static ITargetLevelEntity GetRootAsITargetLevelEntity(ByteBuffer _bb)
		{
			return ITargetLevelEntity.GetRootAsITargetLevelEntity(_bb, default(ITargetLevelEntity));
		}

		// Token: 0x0601488F RID: 84111 RVA: 0x002FDBE0 File Offset: 0x002FBDE0
		public static ITargetLevelEntity GetRootAsITargetLevelEntity(ByteBuffer _bb, ITargetLevelEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014890 RID: 84112 RVA: 0x002FDBFD File Offset: 0x002FBDFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014891 RID: 84113 RVA: 0x002FDC0C File Offset: 0x002FBE0C
		public ITargetLevelEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006769 RID: 26473
		// (get) Token: 0x06014892 RID: 84114 RVA: 0x002FDC1C File Offset: 0x002FBE1C
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700676A RID: 26474
		// (get) Token: 0x06014893 RID: 84115 RVA: 0x002FDC58 File Offset: 0x002FBE58
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014894 RID: 84116 RVA: 0x002FDC94 File Offset: 0x002FBE94
		public static Offset<ITargetLevelEntity> CreateITargetLevelEntity(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player, int Id = 0)
		{
			builder.StartTable(2);
			ITargetLevelEntity.AddId(builder, Id);
			ITargetLevelEntity.AddType(builder, Type);
			return ITargetLevelEntity.EndITargetLevelEntity(builder);
		}

		// Token: 0x06014895 RID: 84117 RVA: 0x002FDCB1 File Offset: 0x002FBEB1
		public static void StartITargetLevelEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014896 RID: 84118 RVA: 0x002FDCBA File Offset: 0x002FBEBA
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014897 RID: 84119 RVA: 0x002FDCC5 File Offset: 0x002FBEC5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06014898 RID: 84120 RVA: 0x002FDCD0 File Offset: 0x002FBED0
		public static Offset<ITargetLevelEntity> EndITargetLevelEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetLevelEntity>(builder.EndTable());
		}

		// Token: 0x06014899 RID: 84121 RVA: 0x002FDCE0 File Offset: 0x002FBEE0
		public ITargetLevelEntityT UnPack()
		{
			ITargetLevelEntityT targetLevelEntityT = new ITargetLevelEntityT();
			this.UnPackTo(targetLevelEntityT);
			return targetLevelEntityT;
		}

		// Token: 0x0601489A RID: 84122 RVA: 0x002FDCFB File Offset: 0x002FBEFB
		public void UnPackTo(ITargetLevelEntityT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601489B RID: 84123 RVA: 0x002FDD18 File Offset: 0x002FBF18
		public static Offset<ITargetLevelEntity> Pack(FlatBufferBuilder builder, ITargetLevelEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetLevelEntity>);
			}
			return ITargetLevelEntity.CreateITargetLevelEntity(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400AFA2 RID: 44962
		private Table __p;
	}
}

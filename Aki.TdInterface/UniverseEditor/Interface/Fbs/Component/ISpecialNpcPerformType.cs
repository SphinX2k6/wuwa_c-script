using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005971 RID: 22897
	public struct ISpecialNpcPerformType : IFlatbufferObject
	{
		// Token: 0x1700ABD4 RID: 43988
		// (get) Token: 0x06026C21 RID: 158753 RVA: 0x00555FC2 File Offset: 0x005541C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C22 RID: 158754 RVA: 0x00555FCF File Offset: 0x005541CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C23 RID: 158755 RVA: 0x00555FD8 File Offset: 0x005541D8
		public static ISpecialNpcPerformType GetRootAsISpecialNpcPerformType(ByteBuffer _bb)
		{
			return ISpecialNpcPerformType.GetRootAsISpecialNpcPerformType(_bb, default(ISpecialNpcPerformType));
		}

		// Token: 0x06026C24 RID: 158756 RVA: 0x00555FF4 File Offset: 0x005541F4
		public static ISpecialNpcPerformType GetRootAsISpecialNpcPerformType(ByteBuffer _bb, ISpecialNpcPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C25 RID: 158757 RVA: 0x00556011 File Offset: 0x00554211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C26 RID: 158758 RVA: 0x00556020 File Offset: 0x00554220
		public ISpecialNpcPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABD5 RID: 43989
		// (get) Token: 0x06026C27 RID: 158759 RVA: 0x00556030 File Offset: 0x00554230
		public ESpecialNpcType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcType.BaseRoleNpc;
				}
				return (ESpecialNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C28 RID: 158760 RVA: 0x0055606C File Offset: 0x0055426C
		public static Offset<ISpecialNpcPerformType> CreateISpecialNpcPerformType(FlatBufferBuilder builder, ESpecialNpcType Type = ESpecialNpcType.BaseRoleNpc)
		{
			builder.StartTable(1);
			ISpecialNpcPerformType.AddType(builder, Type);
			return ISpecialNpcPerformType.EndISpecialNpcPerformType(builder);
		}

		// Token: 0x06026C29 RID: 158761 RVA: 0x00556082 File Offset: 0x00554282
		public static void StartISpecialNpcPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026C2A RID: 158762 RVA: 0x0055608B File Offset: 0x0055428B
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026C2B RID: 158763 RVA: 0x00556096 File Offset: 0x00554296
		public static Offset<ISpecialNpcPerformType> EndISpecialNpcPerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialNpcPerformType>(builder.EndTable());
		}

		// Token: 0x06026C2C RID: 158764 RVA: 0x005560A4 File Offset: 0x005542A4
		public ISpecialNpcPerformTypeT UnPack()
		{
			ISpecialNpcPerformTypeT specialNpcPerformTypeT = new ISpecialNpcPerformTypeT();
			this.UnPackTo(specialNpcPerformTypeT);
			return specialNpcPerformTypeT;
		}

		// Token: 0x06026C2D RID: 158765 RVA: 0x005560BF File Offset: 0x005542BF
		public void UnPackTo(ISpecialNpcPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026C2E RID: 158766 RVA: 0x005560D0 File Offset: 0x005542D0
		public static Offset<ISpecialNpcPerformType> Pack(FlatBufferBuilder builder, ISpecialNpcPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialNpcPerformType>);
			}
			return ISpecialNpcPerformType.CreateISpecialNpcPerformType(builder, _o.Type);
		}

		// Token: 0x0400EF5D RID: 61277
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B6 RID: 21942
	public struct ICustomBulletLogic : IFlatbufferObject
	{
		// Token: 0x17009D1B RID: 40219
		// (get) Token: 0x06022E7B RID: 142971 RVA: 0x004CE63C File Offset: 0x004CC83C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E7C RID: 142972 RVA: 0x004CE649 File Offset: 0x004CC849
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E7D RID: 142973 RVA: 0x004CE650 File Offset: 0x004CC850
		public static ICustomBulletLogic GetRootAsICustomBulletLogic(ByteBuffer _bb)
		{
			return ICustomBulletLogic.GetRootAsICustomBulletLogic(_bb, default(ICustomBulletLogic));
		}

		// Token: 0x06022E7E RID: 142974 RVA: 0x004CE66C File Offset: 0x004CC86C
		public static ICustomBulletLogic GetRootAsICustomBulletLogic(ByteBuffer _bb, ICustomBulletLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E7F RID: 142975 RVA: 0x004CE689 File Offset: 0x004CC889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E80 RID: 142976 RVA: 0x004CE698 File Offset: 0x004CC898
		public ICustomBulletLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D1C RID: 40220
		// (get) Token: 0x06022E81 RID: 142977 RVA: 0x004CE6A8 File Offset: 0x004CC8A8
		public ECustomBulletLogic Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomBulletLogic.TrafficBullet;
				}
				return (ECustomBulletLogic)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022E82 RID: 142978 RVA: 0x004CE6E4 File Offset: 0x004CC8E4
		public static Offset<ICustomBulletLogic> CreateICustomBulletLogic(FlatBufferBuilder builder, ECustomBulletLogic Type = ECustomBulletLogic.TrafficBullet)
		{
			builder.StartTable(1);
			ICustomBulletLogic.AddType(builder, Type);
			return ICustomBulletLogic.EndICustomBulletLogic(builder);
		}

		// Token: 0x06022E83 RID: 142979 RVA: 0x004CE6FA File Offset: 0x004CC8FA
		public static void StartICustomBulletLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022E84 RID: 142980 RVA: 0x004CE703 File Offset: 0x004CC903
		public static void AddType(FlatBufferBuilder builder, ECustomBulletLogic type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022E85 RID: 142981 RVA: 0x004CE70E File Offset: 0x004CC90E
		public static Offset<ICustomBulletLogic> EndICustomBulletLogic(FlatBufferBuilder builder)
		{
			return new Offset<ICustomBulletLogic>(builder.EndTable());
		}

		// Token: 0x06022E86 RID: 142982 RVA: 0x004CE71C File Offset: 0x004CC91C
		public ICustomBulletLogicT UnPack()
		{
			ICustomBulletLogicT customBulletLogicT = new ICustomBulletLogicT();
			this.UnPackTo(customBulletLogicT);
			return customBulletLogicT;
		}

		// Token: 0x06022E87 RID: 142983 RVA: 0x004CE737 File Offset: 0x004CC937
		public void UnPackTo(ICustomBulletLogicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022E88 RID: 142984 RVA: 0x004CE748 File Offset: 0x004CC948
		public static Offset<ICustomBulletLogic> Pack(FlatBufferBuilder builder, ICustomBulletLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomBulletLogic>);
			}
			return ICustomBulletLogic.CreateICustomBulletLogic(builder, _o.Type);
		}

		// Token: 0x0400EC45 RID: 60485
		private Table __p;
	}
}

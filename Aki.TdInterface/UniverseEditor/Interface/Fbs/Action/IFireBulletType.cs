using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BF RID: 26559
	public struct IFireBulletType : IFlatbufferObject
	{
		// Token: 0x1700C52D RID: 50477
		// (get) Token: 0x0602E3BD RID: 189373 RVA: 0x00650855 File Offset: 0x0064EA55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3BE RID: 189374 RVA: 0x00650862 File Offset: 0x0064EA62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3BF RID: 189375 RVA: 0x0065086C File Offset: 0x0064EA6C
		public static IFireBulletType GetRootAsIFireBulletType(ByteBuffer _bb)
		{
			return IFireBulletType.GetRootAsIFireBulletType(_bb, default(IFireBulletType));
		}

		// Token: 0x0602E3C0 RID: 189376 RVA: 0x00650888 File Offset: 0x0064EA88
		public static IFireBulletType GetRootAsIFireBulletType(ByteBuffer _bb, IFireBulletType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3C1 RID: 189377 RVA: 0x006508A5 File Offset: 0x0064EAA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3C2 RID: 189378 RVA: 0x006508B4 File Offset: 0x0064EAB4
		public IFireBulletType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C52E RID: 50478
		// (get) Token: 0x0602E3C3 RID: 189379 RVA: 0x006508C4 File Offset: 0x0064EAC4
		public EFireBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFireBulletType.TrackTarget;
				}
				return (EFireBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3C4 RID: 189380 RVA: 0x00650900 File Offset: 0x0064EB00
		public static Offset<IFireBulletType> CreateIFireBulletType(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget)
		{
			builder.StartTable(1);
			IFireBulletType.AddType(builder, Type);
			return IFireBulletType.EndIFireBulletType(builder);
		}

		// Token: 0x0602E3C5 RID: 189381 RVA: 0x00650916 File Offset: 0x0064EB16
		public static void StartIFireBulletType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E3C6 RID: 189382 RVA: 0x0065091F File Offset: 0x0064EB1F
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3C7 RID: 189383 RVA: 0x0065092A File Offset: 0x0064EB2A
		public static Offset<IFireBulletType> EndIFireBulletType(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletType>(builder.EndTable());
		}

		// Token: 0x0602E3C8 RID: 189384 RVA: 0x00650938 File Offset: 0x0064EB38
		public IFireBulletTypeT UnPack()
		{
			IFireBulletTypeT fireBulletTypeT = new IFireBulletTypeT();
			this.UnPackTo(fireBulletTypeT);
			return fireBulletTypeT;
		}

		// Token: 0x0602E3C9 RID: 189385 RVA: 0x00650953 File Offset: 0x0064EB53
		public void UnPackTo(IFireBulletTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E3CA RID: 189386 RVA: 0x00650964 File Offset: 0x0064EB64
		public static Offset<IFireBulletType> Pack(FlatBufferBuilder builder, IFireBulletTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletType>);
			}
			return IFireBulletType.CreateIFireBulletType(builder, _o.Type);
		}

		// Token: 0x04010ED5 RID: 69333
		private Table __p;
	}
}

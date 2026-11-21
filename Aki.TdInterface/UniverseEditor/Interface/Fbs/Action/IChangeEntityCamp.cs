using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006952 RID: 26962
	public struct IChangeEntityCamp : IFlatbufferObject
	{
		// Token: 0x1700C674 RID: 50804
		// (get) Token: 0x0602E370 RID: 189296 RVA: 0x0064FF90 File Offset: 0x0064E190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E371 RID: 189297 RVA: 0x0064FF9D File Offset: 0x0064E19D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E372 RID: 189298 RVA: 0x0064FFA4 File Offset: 0x0064E1A4
		public static IChangeEntityCamp GetRootAsIChangeEntityCamp(ByteBuffer _bb)
		{
			return IChangeEntityCamp.GetRootAsIChangeEntityCamp(_bb, default(IChangeEntityCamp));
		}

		// Token: 0x0602E373 RID: 189299 RVA: 0x0064FFC0 File Offset: 0x0064E1C0
		public static IChangeEntityCamp GetRootAsIChangeEntityCamp(ByteBuffer _bb, IChangeEntityCamp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E374 RID: 189300 RVA: 0x0064FFDD File Offset: 0x0064E1DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E375 RID: 189301 RVA: 0x0064FFEC File Offset: 0x0064E1EC
		public IChangeEntityCamp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C675 RID: 50805
		// (get) Token: 0x0602E376 RID: 189302 RVA: 0x0064FFFC File Offset: 0x0064E1FC
		public int TargetEntity
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

		// Token: 0x1700C676 RID: 50806
		// (get) Token: 0x0602E377 RID: 189303 RVA: 0x00650038 File Offset: 0x0064E238
		public ECamp Camp
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECamp.Player;
				}
				return (ECamp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E378 RID: 189304 RVA: 0x00650074 File Offset: 0x0064E274
		public static Offset<IChangeEntityCamp> CreateIChangeEntityCamp(FlatBufferBuilder builder, int TargetEntity = 0, ECamp Camp = ECamp.Player)
		{
			builder.StartTable(2);
			IChangeEntityCamp.AddTargetEntity(builder, TargetEntity);
			IChangeEntityCamp.AddCamp(builder, Camp);
			return IChangeEntityCamp.EndIChangeEntityCamp(builder);
		}

		// Token: 0x0602E379 RID: 189305 RVA: 0x00650091 File Offset: 0x0064E291
		public static void StartIChangeEntityCamp(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E37A RID: 189306 RVA: 0x0065009A File Offset: 0x0064E29A
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(0, targetEntity, 0);
		}

		// Token: 0x0602E37B RID: 189307 RVA: 0x006500A5 File Offset: 0x0064E2A5
		public static void AddCamp(FlatBufferBuilder builder, ECamp camp)
		{
			builder.AddByte(1, (byte)camp, 0);
		}

		// Token: 0x0602E37C RID: 189308 RVA: 0x006500B0 File Offset: 0x0064E2B0
		public static Offset<IChangeEntityCamp> EndIChangeEntityCamp(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityCamp>(builder.EndTable());
		}

		// Token: 0x0602E37D RID: 189309 RVA: 0x006500C0 File Offset: 0x0064E2C0
		public IChangeEntityCampT UnPack()
		{
			IChangeEntityCampT changeEntityCampT = new IChangeEntityCampT();
			this.UnPackTo(changeEntityCampT);
			return changeEntityCampT;
		}

		// Token: 0x0602E37E RID: 189310 RVA: 0x006500DB File Offset: 0x0064E2DB
		public void UnPackTo(IChangeEntityCampT _o)
		{
			_o.TargetEntity = this.TargetEntity;
			_o.Camp = this.Camp;
		}

		// Token: 0x0602E37F RID: 189311 RVA: 0x006500F8 File Offset: 0x0064E2F8
		public static Offset<IChangeEntityCamp> Pack(FlatBufferBuilder builder, IChangeEntityCampT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityCamp>);
			}
			return IChangeEntityCamp.CreateIChangeEntityCamp(builder, _o.TargetEntity, _o.Camp);
		}

		// Token: 0x040116A1 RID: 71329
		private Table __p;
	}
}

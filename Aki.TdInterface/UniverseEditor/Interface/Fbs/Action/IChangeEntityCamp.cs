using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E1 RID: 25313
	public struct IChangeEntityCamp : IFlatbufferObject
	{
		// Token: 0x1700BCEA RID: 48362
		// (get) Token: 0x0602BC07 RID: 179207 RVA: 0x00604F84 File Offset: 0x00603184
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC08 RID: 179208 RVA: 0x00604F91 File Offset: 0x00603191
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC09 RID: 179209 RVA: 0x00604F98 File Offset: 0x00603198
		public static IChangeEntityCamp GetRootAsIChangeEntityCamp(ByteBuffer _bb)
		{
			return IChangeEntityCamp.GetRootAsIChangeEntityCamp(_bb, default(IChangeEntityCamp));
		}

		// Token: 0x0602BC0A RID: 179210 RVA: 0x00604FB4 File Offset: 0x006031B4
		public static IChangeEntityCamp GetRootAsIChangeEntityCamp(ByteBuffer _bb, IChangeEntityCamp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC0B RID: 179211 RVA: 0x00604FD1 File Offset: 0x006031D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC0C RID: 179212 RVA: 0x00604FE0 File Offset: 0x006031E0
		public IChangeEntityCamp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCEB RID: 48363
		// (get) Token: 0x0602BC0D RID: 179213 RVA: 0x00604FF0 File Offset: 0x006031F0
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

		// Token: 0x1700BCEC RID: 48364
		// (get) Token: 0x0602BC0E RID: 179214 RVA: 0x0060502C File Offset: 0x0060322C
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

		// Token: 0x0602BC0F RID: 179215 RVA: 0x00605068 File Offset: 0x00603268
		public static Offset<IChangeEntityCamp> CreateIChangeEntityCamp(FlatBufferBuilder builder, int TargetEntity = 0, ECamp Camp = ECamp.Player)
		{
			builder.StartTable(2);
			IChangeEntityCamp.AddTargetEntity(builder, TargetEntity);
			IChangeEntityCamp.AddCamp(builder, Camp);
			return IChangeEntityCamp.EndIChangeEntityCamp(builder);
		}

		// Token: 0x0602BC10 RID: 179216 RVA: 0x00605085 File Offset: 0x00603285
		public static void StartIChangeEntityCamp(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BC11 RID: 179217 RVA: 0x0060508E File Offset: 0x0060328E
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(0, targetEntity, 0);
		}

		// Token: 0x0602BC12 RID: 179218 RVA: 0x00605099 File Offset: 0x00603299
		public static void AddCamp(FlatBufferBuilder builder, ECamp camp)
		{
			builder.AddByte(1, (byte)camp, 0);
		}

		// Token: 0x0602BC13 RID: 179219 RVA: 0x006050A4 File Offset: 0x006032A4
		public static Offset<IChangeEntityCamp> EndIChangeEntityCamp(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityCamp>(builder.EndTable());
		}

		// Token: 0x0602BC14 RID: 179220 RVA: 0x006050B4 File Offset: 0x006032B4
		public IChangeEntityCampT UnPack()
		{
			IChangeEntityCampT changeEntityCampT = new IChangeEntityCampT();
			this.UnPackTo(changeEntityCampT);
			return changeEntityCampT;
		}

		// Token: 0x0602BC15 RID: 179221 RVA: 0x006050CF File Offset: 0x006032CF
		public void UnPackTo(IChangeEntityCampT _o)
		{
			_o.TargetEntity = this.TargetEntity;
			_o.Camp = this.Camp;
		}

		// Token: 0x0602BC16 RID: 179222 RVA: 0x006050EC File Offset: 0x006032EC
		public static Offset<IChangeEntityCamp> Pack(FlatBufferBuilder builder, IChangeEntityCampT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityCamp>);
			}
			return IChangeEntityCamp.CreateIChangeEntityCamp(builder, _o.TargetEntity, _o.Camp);
		}

		// Token: 0x0401088B RID: 67723
		private Table __p;
	}
}

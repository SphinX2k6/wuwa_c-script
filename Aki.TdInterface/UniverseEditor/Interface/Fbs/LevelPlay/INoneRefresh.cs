using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004530 RID: 17712
	public struct INoneRefresh : IFlatbufferObject
	{
		// Token: 0x17007DA3 RID: 32163
		// (get) Token: 0x0601AA2B RID: 109099 RVA: 0x003CD2AE File Offset: 0x003CB4AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA2C RID: 109100 RVA: 0x003CD2BB File Offset: 0x003CB4BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA2D RID: 109101 RVA: 0x003CD2C4 File Offset: 0x003CB4C4
		public static INoneRefresh GetRootAsINoneRefresh(ByteBuffer _bb)
		{
			return INoneRefresh.GetRootAsINoneRefresh(_bb, default(INoneRefresh));
		}

		// Token: 0x0601AA2E RID: 109102 RVA: 0x003CD2E0 File Offset: 0x003CB4E0
		public static INoneRefresh GetRootAsINoneRefresh(ByteBuffer _bb, INoneRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA2F RID: 109103 RVA: 0x003CD2FD File Offset: 0x003CB4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA30 RID: 109104 RVA: 0x003CD30C File Offset: 0x003CB50C
		public INoneRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DA4 RID: 32164
		// (get) Token: 0x0601AA31 RID: 109105 RVA: 0x003CD31C File Offset: 0x003CB51C
		public ELevelPlayRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRefreshType.None;
				}
				return (ELevelPlayRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA32 RID: 109106 RVA: 0x003CD358 File Offset: 0x003CB558
		public static Offset<INoneRefresh> CreateINoneRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None)
		{
			builder.StartTable(1);
			INoneRefresh.AddType(builder, Type);
			return INoneRefresh.EndINoneRefresh(builder);
		}

		// Token: 0x0601AA33 RID: 109107 RVA: 0x003CD36E File Offset: 0x003CB56E
		public static void StartINoneRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA34 RID: 109108 RVA: 0x003CD377 File Offset: 0x003CB577
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA35 RID: 109109 RVA: 0x003CD382 File Offset: 0x003CB582
		public static Offset<INoneRefresh> EndINoneRefresh(FlatBufferBuilder builder)
		{
			return new Offset<INoneRefresh>(builder.EndTable());
		}

		// Token: 0x0601AA36 RID: 109110 RVA: 0x003CD390 File Offset: 0x003CB590
		public INoneRefreshT UnPack()
		{
			INoneRefreshT noneRefreshT = new INoneRefreshT();
			this.UnPackTo(noneRefreshT);
			return noneRefreshT;
		}

		// Token: 0x0601AA37 RID: 109111 RVA: 0x003CD3AB File Offset: 0x003CB5AB
		public void UnPackTo(INoneRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA38 RID: 109112 RVA: 0x003CD3BC File Offset: 0x003CB5BC
		public static Offset<INoneRefresh> Pack(FlatBufferBuilder builder, INoneRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoneRefresh>);
			}
			return INoneRefresh.CreateINoneRefresh(builder, _o.Type);
		}

		// Token: 0x0400C5B6 RID: 50614
		private Table __p;
	}
}

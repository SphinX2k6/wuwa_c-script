using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004998 RID: 18840
	public struct INoneRefresh : IFlatbufferObject
	{
		// Token: 0x170083E4 RID: 33764
		// (get) Token: 0x0601C200 RID: 115200 RVA: 0x003F954A File Offset: 0x003F774A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C201 RID: 115201 RVA: 0x003F9557 File Offset: 0x003F7757
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C202 RID: 115202 RVA: 0x003F9560 File Offset: 0x003F7760
		public static INoneRefresh GetRootAsINoneRefresh(ByteBuffer _bb)
		{
			return INoneRefresh.GetRootAsINoneRefresh(_bb, default(INoneRefresh));
		}

		// Token: 0x0601C203 RID: 115203 RVA: 0x003F957C File Offset: 0x003F777C
		public static INoneRefresh GetRootAsINoneRefresh(ByteBuffer _bb, INoneRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C204 RID: 115204 RVA: 0x003F9599 File Offset: 0x003F7799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C205 RID: 115205 RVA: 0x003F95A8 File Offset: 0x003F77A8
		public INoneRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083E5 RID: 33765
		// (get) Token: 0x0601C206 RID: 115206 RVA: 0x003F95B8 File Offset: 0x003F77B8
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

		// Token: 0x0601C207 RID: 115207 RVA: 0x003F95F4 File Offset: 0x003F77F4
		public static Offset<INoneRefresh> CreateINoneRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None)
		{
			builder.StartTable(1);
			INoneRefresh.AddType(builder, Type);
			return INoneRefresh.EndINoneRefresh(builder);
		}

		// Token: 0x0601C208 RID: 115208 RVA: 0x003F960A File Offset: 0x003F780A
		public static void StartINoneRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C209 RID: 115209 RVA: 0x003F9613 File Offset: 0x003F7813
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C20A RID: 115210 RVA: 0x003F961E File Offset: 0x003F781E
		public static Offset<INoneRefresh> EndINoneRefresh(FlatBufferBuilder builder)
		{
			return new Offset<INoneRefresh>(builder.EndTable());
		}

		// Token: 0x0601C20B RID: 115211 RVA: 0x003F962C File Offset: 0x003F782C
		public INoneRefreshT UnPack()
		{
			INoneRefreshT noneRefreshT = new INoneRefreshT();
			this.UnPackTo(noneRefreshT);
			return noneRefreshT;
		}

		// Token: 0x0601C20C RID: 115212 RVA: 0x003F9647 File Offset: 0x003F7847
		public void UnPackTo(INoneRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C20D RID: 115213 RVA: 0x003F9658 File Offset: 0x003F7858
		public static Offset<INoneRefresh> Pack(FlatBufferBuilder builder, INoneRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoneRefresh>);
			}
			return INoneRefresh.CreateINoneRefresh(builder, _o.Type);
		}

		// Token: 0x0400CFE5 RID: 53221
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200450C RID: 17676
	public struct ILevelPlayRefresh : IFlatbufferObject
	{
		// Token: 0x17007D55 RID: 32085
		// (get) Token: 0x0601A8F5 RID: 108789 RVA: 0x003CB20B File Offset: 0x003C940B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x003CB218 File Offset: 0x003C9418
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8F7 RID: 108791 RVA: 0x003CB220 File Offset: 0x003C9420
		public static ILevelPlayRefresh GetRootAsILevelPlayRefresh(ByteBuffer _bb)
		{
			return ILevelPlayRefresh.GetRootAsILevelPlayRefresh(_bb, default(ILevelPlayRefresh));
		}

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x003CB23C File Offset: 0x003C943C
		public static ILevelPlayRefresh GetRootAsILevelPlayRefresh(ByteBuffer _bb, ILevelPlayRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8F9 RID: 108793 RVA: 0x003CB259 File Offset: 0x003C9459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8FA RID: 108794 RVA: 0x003CB268 File Offset: 0x003C9468
		public ILevelPlayRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D56 RID: 32086
		// (get) Token: 0x0601A8FB RID: 108795 RVA: 0x003CB278 File Offset: 0x003C9478
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

		// Token: 0x0601A8FC RID: 108796 RVA: 0x003CB2B4 File Offset: 0x003C94B4
		public static Offset<ILevelPlayRefresh> CreateILevelPlayRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None)
		{
			builder.StartTable(1);
			ILevelPlayRefresh.AddType(builder, Type);
			return ILevelPlayRefresh.EndILevelPlayRefresh(builder);
		}

		// Token: 0x0601A8FD RID: 108797 RVA: 0x003CB2CA File Offset: 0x003C94CA
		public static void StartILevelPlayRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A8FE RID: 108798 RVA: 0x003CB2D3 File Offset: 0x003C94D3
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A8FF RID: 108799 RVA: 0x003CB2DE File Offset: 0x003C94DE
		public static Offset<ILevelPlayRefresh> EndILevelPlayRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRefresh>(builder.EndTable());
		}

		// Token: 0x0601A900 RID: 108800 RVA: 0x003CB2EC File Offset: 0x003C94EC
		public ILevelPlayRefreshT UnPack()
		{
			ILevelPlayRefreshT levelPlayRefreshT = new ILevelPlayRefreshT();
			this.UnPackTo(levelPlayRefreshT);
			return levelPlayRefreshT;
		}

		// Token: 0x0601A901 RID: 108801 RVA: 0x003CB307 File Offset: 0x003C9507
		public void UnPackTo(ILevelPlayRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A902 RID: 108802 RVA: 0x003CB318 File Offset: 0x003C9518
		public static Offset<ILevelPlayRefresh> Pack(FlatBufferBuilder builder, ILevelPlayRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRefresh>);
			}
			return ILevelPlayRefresh.CreateILevelPlayRefresh(builder, _o.Type);
		}

		// Token: 0x0400C577 RID: 50551
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C0 RID: 18112
	public struct ITeleportToLevelPlayCenter : IFlatbufferObject
	{
		// Token: 0x170080B1 RID: 32945
		// (get) Token: 0x0601B87F RID: 112767 RVA: 0x003E8218 File Offset: 0x003E6418
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B880 RID: 112768 RVA: 0x003E8225 File Offset: 0x003E6425
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B881 RID: 112769 RVA: 0x003E822C File Offset: 0x003E642C
		public static ITeleportToLevelPlayCenter GetRootAsITeleportToLevelPlayCenter(ByteBuffer _bb)
		{
			return ITeleportToLevelPlayCenter.GetRootAsITeleportToLevelPlayCenter(_bb, default(ITeleportToLevelPlayCenter));
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x003E8248 File Offset: 0x003E6448
		public static ITeleportToLevelPlayCenter GetRootAsITeleportToLevelPlayCenter(ByteBuffer _bb, ITeleportToLevelPlayCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x003E8265 File Offset: 0x003E6465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x003E8274 File Offset: 0x003E6474
		public ITeleportToLevelPlayCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080B2 RID: 32946
		// (get) Token: 0x0601B885 RID: 112773 RVA: 0x003E8284 File Offset: 0x003E6484
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170080B3 RID: 32947
		// (get) Token: 0x0601B886 RID: 112774 RVA: 0x003E82C0 File Offset: 0x003E64C0
		public int LevelPlayId
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

		// Token: 0x0601B887 RID: 112775 RVA: 0x003E82FC File Offset: 0x003E64FC
		public static Offset<ITeleportToLevelPlayCenter> CreateITeleportToLevelPlayCenter(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0)
		{
			builder.StartTable(2);
			ITeleportToLevelPlayCenter.AddLevelPlayId(builder, LevelPlayId);
			ITeleportToLevelPlayCenter.AddType(builder, Type);
			return ITeleportToLevelPlayCenter.EndITeleportToLevelPlayCenter(builder);
		}

		// Token: 0x0601B888 RID: 112776 RVA: 0x003E8319 File Offset: 0x003E6519
		public static void StartITeleportToLevelPlayCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B889 RID: 112777 RVA: 0x003E8322 File Offset: 0x003E6522
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B88A RID: 112778 RVA: 0x003E832D File Offset: 0x003E652D
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B88B RID: 112779 RVA: 0x003E8338 File Offset: 0x003E6538
		public static Offset<ITeleportToLevelPlayCenter> EndITeleportToLevelPlayCenter(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLevelPlayCenter>(builder.EndTable());
		}

		// Token: 0x0601B88C RID: 112780 RVA: 0x003E8348 File Offset: 0x003E6548
		public ITeleportToLevelPlayCenterT UnPack()
		{
			ITeleportToLevelPlayCenterT teleportToLevelPlayCenterT = new ITeleportToLevelPlayCenterT();
			this.UnPackTo(teleportToLevelPlayCenterT);
			return teleportToLevelPlayCenterT;
		}

		// Token: 0x0601B88D RID: 112781 RVA: 0x003E8363 File Offset: 0x003E6563
		public void UnPackTo(ITeleportToLevelPlayCenterT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
		}

		// Token: 0x0601B88E RID: 112782 RVA: 0x003E8380 File Offset: 0x003E6580
		public static Offset<ITeleportToLevelPlayCenter> Pack(FlatBufferBuilder builder, ITeleportToLevelPlayCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLevelPlayCenter>);
			}
			return ITeleportToLevelPlayCenter.CreateITeleportToLevelPlayCenter(builder, _o.Type, _o.LevelPlayId);
		}

		// Token: 0x0400C892 RID: 51346
		private Table __p;
	}
}

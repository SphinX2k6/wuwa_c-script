using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B8A RID: 31626
	public struct ITeleportTransitionType : IFlatbufferObject
	{
		// Token: 0x1700ECCF RID: 60623
		// (get) Token: 0x06038F6E RID: 233326 RVA: 0x007B311C File Offset: 0x007B131C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038F6F RID: 233327 RVA: 0x007B3129 File Offset: 0x007B1329
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038F70 RID: 233328 RVA: 0x007B3130 File Offset: 0x007B1330
		public static ITeleportTransitionType GetRootAsITeleportTransitionType(ByteBuffer _bb)
		{
			return ITeleportTransitionType.GetRootAsITeleportTransitionType(_bb, default(ITeleportTransitionType));
		}

		// Token: 0x06038F71 RID: 233329 RVA: 0x007B314C File Offset: 0x007B134C
		public static ITeleportTransitionType GetRootAsITeleportTransitionType(ByteBuffer _bb, ITeleportTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038F72 RID: 233330 RVA: 0x007B3169 File Offset: 0x007B1369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038F73 RID: 233331 RVA: 0x007B3178 File Offset: 0x007B1378
		public ITeleportTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECD0 RID: 60624
		// (get) Token: 0x06038F74 RID: 233332 RVA: 0x007B3188 File Offset: 0x007B1388
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038F75 RID: 233333 RVA: 0x007B31C4 File Offset: 0x007B13C4
		public static Offset<ITeleportTransitionType> CreateITeleportTransitionType(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4)
		{
			builder.StartTable(1);
			ITeleportTransitionType.AddType(builder, Type);
			return ITeleportTransitionType.EndITeleportTransitionType(builder);
		}

		// Token: 0x06038F76 RID: 233334 RVA: 0x007B31DA File Offset: 0x007B13DA
		public static void StartITeleportTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038F77 RID: 233335 RVA: 0x007B31E3 File Offset: 0x007B13E3
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038F78 RID: 233336 RVA: 0x007B31EE File Offset: 0x007B13EE
		public static Offset<ITeleportTransitionType> EndITeleportTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionType>(builder.EndTable());
		}

		// Token: 0x06038F79 RID: 233337 RVA: 0x007B31FC File Offset: 0x007B13FC
		public ITeleportTransitionTypeT UnPack()
		{
			ITeleportTransitionTypeT teleportTransitionTypeT = new ITeleportTransitionTypeT();
			this.UnPackTo(teleportTransitionTypeT);
			return teleportTransitionTypeT;
		}

		// Token: 0x06038F7A RID: 233338 RVA: 0x007B3217 File Offset: 0x007B1417
		public void UnPackTo(ITeleportTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038F7B RID: 233339 RVA: 0x007B3228 File Offset: 0x007B1428
		public static Offset<ITeleportTransitionType> Pack(FlatBufferBuilder builder, ITeleportTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionType>);
			}
			return ITeleportTransitionType.CreateITeleportTransitionType(builder, _o.Type);
		}

		// Token: 0x040131E4 RID: 78308
		private Table __p;
	}
}

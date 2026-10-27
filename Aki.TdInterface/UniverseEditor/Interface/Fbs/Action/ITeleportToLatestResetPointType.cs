using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007391 RID: 29585
	public struct ITeleportToLatestResetPointType : IFlatbufferObject
	{
		// Token: 0x1700E095 RID: 57493
		// (get) Token: 0x06035B31 RID: 219953 RVA: 0x0074F94D File Offset: 0x0074DB4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B32 RID: 219954 RVA: 0x0074F95A File Offset: 0x0074DB5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B33 RID: 219955 RVA: 0x0074F964 File Offset: 0x0074DB64
		public static ITeleportToLatestResetPointType GetRootAsITeleportToLatestResetPointType(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPointType.GetRootAsITeleportToLatestResetPointType(_bb, default(ITeleportToLatestResetPointType));
		}

		// Token: 0x06035B34 RID: 219956 RVA: 0x0074F980 File Offset: 0x0074DB80
		public static ITeleportToLatestResetPointType GetRootAsITeleportToLatestResetPointType(ByteBuffer _bb, ITeleportToLatestResetPointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B35 RID: 219957 RVA: 0x0074F99D File Offset: 0x0074DB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B36 RID: 219958 RVA: 0x0074F9AC File Offset: 0x0074DBAC
		public ITeleportToLatestResetPointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E096 RID: 57494
		// (get) Token: 0x06035B37 RID: 219959 RVA: 0x0074F9BC File Offset: 0x0074DBBC
		public ETeleportToLatestResetPointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return (ETeleportToLatestResetPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B38 RID: 219960 RVA: 0x0074F9F8 File Offset: 0x0074DBF8
		public static Offset<ITeleportToLatestResetPointType> CreateITeleportToLatestResetPointType(FlatBufferBuilder builder, ETeleportToLatestResetPointType Type = ETeleportToLatestResetPointType.Directly)
		{
			builder.StartTable(1);
			ITeleportToLatestResetPointType.AddType(builder, Type);
			return ITeleportToLatestResetPointType.EndITeleportToLatestResetPointType(builder);
		}

		// Token: 0x06035B39 RID: 219961 RVA: 0x0074FA0E File Offset: 0x0074DC0E
		public static void StartITeleportToLatestResetPointType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B3A RID: 219962 RVA: 0x0074FA17 File Offset: 0x0074DC17
		public static void AddType(FlatBufferBuilder builder, ETeleportToLatestResetPointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B3B RID: 219963 RVA: 0x0074FA22 File Offset: 0x0074DC22
		public static Offset<ITeleportToLatestResetPointType> EndITeleportToLatestResetPointType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPointType>(builder.EndTable());
		}

		// Token: 0x06035B3C RID: 219964 RVA: 0x0074FA30 File Offset: 0x0074DC30
		public ITeleportToLatestResetPointTypeT UnPack()
		{
			ITeleportToLatestResetPointTypeT teleportToLatestResetPointTypeT = new ITeleportToLatestResetPointTypeT();
			this.UnPackTo(teleportToLatestResetPointTypeT);
			return teleportToLatestResetPointTypeT;
		}

		// Token: 0x06035B3D RID: 219965 RVA: 0x0074FA4B File Offset: 0x0074DC4B
		public void UnPackTo(ITeleportToLatestResetPointTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035B3E RID: 219966 RVA: 0x0074FA5C File Offset: 0x0074DC5C
		public static Offset<ITeleportToLatestResetPointType> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPointType>);
			}
			return ITeleportToLatestResetPointType.CreateITeleportToLatestResetPointType(builder, _o.Type);
		}

		// Token: 0x040121AA RID: 74154
		private Table __p;
	}
}

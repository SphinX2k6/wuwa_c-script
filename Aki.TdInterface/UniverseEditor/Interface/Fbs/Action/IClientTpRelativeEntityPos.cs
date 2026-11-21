using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A80 RID: 27264
	public struct IClientTpRelativeEntityPos : IFlatbufferObject
	{
		// Token: 0x1700C839 RID: 51257
		// (get) Token: 0x0602EC6E RID: 191598 RVA: 0x00660019 File Offset: 0x0065E219
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC6F RID: 191599 RVA: 0x00660026 File Offset: 0x0065E226
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC70 RID: 191600 RVA: 0x00660030 File Offset: 0x0065E230
		public static IClientTpRelativeEntityPos GetRootAsIClientTpRelativeEntityPos(ByteBuffer _bb)
		{
			return IClientTpRelativeEntityPos.GetRootAsIClientTpRelativeEntityPos(_bb, default(IClientTpRelativeEntityPos));
		}

		// Token: 0x0602EC71 RID: 191601 RVA: 0x0066004C File Offset: 0x0065E24C
		public static IClientTpRelativeEntityPos GetRootAsIClientTpRelativeEntityPos(ByteBuffer _bb, IClientTpRelativeEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC72 RID: 191602 RVA: 0x00660069 File Offset: 0x0065E269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC73 RID: 191603 RVA: 0x00660078 File Offset: 0x0065E278
		public IClientTpRelativeEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C83A RID: 51258
		// (get) Token: 0x0602EC74 RID: 191604 RVA: 0x00660088 File Offset: 0x0065E288
		public EClientTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return (EClientTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C83B RID: 51259
		// (get) Token: 0x0602EC75 RID: 191605 RVA: 0x006600C4 File Offset: 0x0065E2C4
		public int SourcePosEntityId
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

		// Token: 0x1700C83C RID: 51260
		// (get) Token: 0x0602EC76 RID: 191606 RVA: 0x00660100 File Offset: 0x0065E300
		public int TargetPosEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC77 RID: 191607 RVA: 0x0066013C File Offset: 0x0065E33C
		public static Offset<IClientTpRelativeEntityPos> CreateIClientTpRelativeEntityPos(FlatBufferBuilder builder, EClientTeleportType Type = EClientTeleportType.RelativeEntityPos, int SourcePosEntityId = 0, int TargetPosEntityId = 0)
		{
			builder.StartTable(3);
			IClientTpRelativeEntityPos.AddTargetPosEntityId(builder, TargetPosEntityId);
			IClientTpRelativeEntityPos.AddSourcePosEntityId(builder, SourcePosEntityId);
			IClientTpRelativeEntityPos.AddType(builder, Type);
			return IClientTpRelativeEntityPos.EndIClientTpRelativeEntityPos(builder);
		}

		// Token: 0x0602EC78 RID: 191608 RVA: 0x00660160 File Offset: 0x0065E360
		public static void StartIClientTpRelativeEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EC79 RID: 191609 RVA: 0x00660169 File Offset: 0x0065E369
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC7A RID: 191610 RVA: 0x00660174 File Offset: 0x0065E374
		public static void AddSourcePosEntityId(FlatBufferBuilder builder, int sourcePosEntityId)
		{
			builder.AddInt(1, sourcePosEntityId, 0);
		}

		// Token: 0x0602EC7B RID: 191611 RVA: 0x0066017F File Offset: 0x0065E37F
		public static void AddTargetPosEntityId(FlatBufferBuilder builder, int targetPosEntityId)
		{
			builder.AddInt(2, targetPosEntityId, 0);
		}

		// Token: 0x0602EC7C RID: 191612 RVA: 0x0066018A File Offset: 0x0065E38A
		public static Offset<IClientTpRelativeEntityPos> EndIClientTpRelativeEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpRelativeEntityPos>(builder.EndTable());
		}

		// Token: 0x0602EC7D RID: 191613 RVA: 0x00660198 File Offset: 0x0065E398
		public IClientTpRelativeEntityPosT UnPack()
		{
			IClientTpRelativeEntityPosT clientTpRelativeEntityPosT = new IClientTpRelativeEntityPosT();
			this.UnPackTo(clientTpRelativeEntityPosT);
			return clientTpRelativeEntityPosT;
		}

		// Token: 0x0602EC7E RID: 191614 RVA: 0x006601B3 File Offset: 0x0065E3B3
		public void UnPackTo(IClientTpRelativeEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.SourcePosEntityId = this.SourcePosEntityId;
			_o.TargetPosEntityId = this.TargetPosEntityId;
		}

		// Token: 0x0602EC7F RID: 191615 RVA: 0x006601DC File Offset: 0x0065E3DC
		public static Offset<IClientTpRelativeEntityPos> Pack(FlatBufferBuilder builder, IClientTpRelativeEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTpRelativeEntityPos>);
			}
			return IClientTpRelativeEntityPos.CreateIClientTpRelativeEntityPos(builder, _o.Type, _o.SourcePosEntityId, _o.TargetPosEntityId);
		}

		// Token: 0x04011812 RID: 71698
		private Table __p;
	}
}

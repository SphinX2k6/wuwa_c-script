using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD4 RID: 19156
	public struct IGmSetLevelPlayUpdateForce : IFlatbufferObject
	{
		// Token: 0x17008640 RID: 34368
		// (get) Token: 0x0601CD96 RID: 118166 RVA: 0x0040FFC8 File Offset: 0x0040E1C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CD97 RID: 118167 RVA: 0x0040FFD5 File Offset: 0x0040E1D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CD98 RID: 118168 RVA: 0x0040FFDC File Offset: 0x0040E1DC
		public static IGmSetLevelPlayUpdateForce GetRootAsIGmSetLevelPlayUpdateForce(ByteBuffer _bb)
		{
			return IGmSetLevelPlayUpdateForce.GetRootAsIGmSetLevelPlayUpdateForce(_bb, default(IGmSetLevelPlayUpdateForce));
		}

		// Token: 0x0601CD99 RID: 118169 RVA: 0x0040FFF8 File Offset: 0x0040E1F8
		public static IGmSetLevelPlayUpdateForce GetRootAsIGmSetLevelPlayUpdateForce(ByteBuffer _bb, IGmSetLevelPlayUpdateForce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CD9A RID: 118170 RVA: 0x00410015 File Offset: 0x0040E215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CD9B RID: 118171 RVA: 0x00410024 File Offset: 0x0040E224
		public IGmSetLevelPlayUpdateForce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008641 RID: 34369
		// (get) Token: 0x0601CD9C RID: 118172 RVA: 0x00410034 File Offset: 0x0040E234
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

		// Token: 0x17008642 RID: 34370
		// (get) Token: 0x0601CD9D RID: 118173 RVA: 0x00410070 File Offset: 0x0040E270
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

		// Token: 0x17008643 RID: 34371
		// (get) Token: 0x0601CD9E RID: 118174 RVA: 0x004100AC File Offset: 0x0040E2AC
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CD9F RID: 118175 RVA: 0x004100EB File Offset: 0x0040E2EB
		public static Offset<IGmSetLevelPlayUpdateForce> CreateIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, bool IsTeleport = false)
		{
			builder.StartTable(3);
			IGmSetLevelPlayUpdateForce.AddLevelPlayId(builder, LevelPlayId);
			IGmSetLevelPlayUpdateForce.AddIsTeleport(builder, IsTeleport);
			IGmSetLevelPlayUpdateForce.AddType(builder, Type);
			return IGmSetLevelPlayUpdateForce.EndIGmSetLevelPlayUpdateForce(builder);
		}

		// Token: 0x0601CDA0 RID: 118176 RVA: 0x0041010F File Offset: 0x0040E30F
		public static void StartIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CDA1 RID: 118177 RVA: 0x00410118 File Offset: 0x0040E318
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CDA2 RID: 118178 RVA: 0x00410123 File Offset: 0x0040E323
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601CDA3 RID: 118179 RVA: 0x0041012E File Offset: 0x0040E32E
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601CDA4 RID: 118180 RVA: 0x00410139 File Offset: 0x0040E339
		public static Offset<IGmSetLevelPlayUpdateForce> EndIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder)
		{
			return new Offset<IGmSetLevelPlayUpdateForce>(builder.EndTable());
		}

		// Token: 0x0601CDA5 RID: 118181 RVA: 0x00410148 File Offset: 0x0040E348
		public IGmSetLevelPlayUpdateForceT UnPack()
		{
			IGmSetLevelPlayUpdateForceT gmSetLevelPlayUpdateForceT = new IGmSetLevelPlayUpdateForceT();
			this.UnPackTo(gmSetLevelPlayUpdateForceT);
			return gmSetLevelPlayUpdateForceT;
		}

		// Token: 0x0601CDA6 RID: 118182 RVA: 0x00410163 File Offset: 0x0040E363
		public void UnPackTo(IGmSetLevelPlayUpdateForceT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.IsTeleport = this.IsTeleport;
		}

		// Token: 0x0601CDA7 RID: 118183 RVA: 0x0041018C File Offset: 0x0040E38C
		public static Offset<IGmSetLevelPlayUpdateForce> Pack(FlatBufferBuilder builder, IGmSetLevelPlayUpdateForceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmSetLevelPlayUpdateForce>);
			}
			return IGmSetLevelPlayUpdateForce.CreateIGmSetLevelPlayUpdateForce(builder, _o.Type, _o.LevelPlayId, _o.IsTeleport);
		}

		// Token: 0x0400D25A RID: 53850
		private Table __p;
	}
}

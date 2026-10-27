using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE5 RID: 24037
	public struct IGiantTriggerEnterArea : IFlatbufferObject
	{
		// Token: 0x1700B3EB RID: 46059
		// (get) Token: 0x06029252 RID: 168530 RVA: 0x005A5883 File Offset: 0x005A3A83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029253 RID: 168531 RVA: 0x005A5890 File Offset: 0x005A3A90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029254 RID: 168532 RVA: 0x005A5898 File Offset: 0x005A3A98
		public static IGiantTriggerEnterArea GetRootAsIGiantTriggerEnterArea(ByteBuffer _bb)
		{
			return IGiantTriggerEnterArea.GetRootAsIGiantTriggerEnterArea(_bb, default(IGiantTriggerEnterArea));
		}

		// Token: 0x06029255 RID: 168533 RVA: 0x005A58B4 File Offset: 0x005A3AB4
		public static IGiantTriggerEnterArea GetRootAsIGiantTriggerEnterArea(ByteBuffer _bb, IGiantTriggerEnterArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029256 RID: 168534 RVA: 0x005A58D1 File Offset: 0x005A3AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029257 RID: 168535 RVA: 0x005A58E0 File Offset: 0x005A3AE0
		public IGiantTriggerEnterArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3EC RID: 46060
		// (get) Token: 0x06029258 RID: 168536 RVA: 0x005A58F0 File Offset: 0x005A3AF0
		public EGiantTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantTriggerType.RoleState;
				}
				return (EGiantTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3ED RID: 46061
		// (get) Token: 0x06029259 RID: 168537 RVA: 0x005A592C File Offset: 0x005A3B2C
		public int AreaId
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

		// Token: 0x0602925A RID: 168538 RVA: 0x005A5968 File Offset: 0x005A3B68
		public static Offset<IGiantTriggerEnterArea> CreateIGiantTriggerEnterArea(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, int AreaId = 0)
		{
			builder.StartTable(2);
			IGiantTriggerEnterArea.AddAreaId(builder, AreaId);
			IGiantTriggerEnterArea.AddType(builder, Type);
			return IGiantTriggerEnterArea.EndIGiantTriggerEnterArea(builder);
		}

		// Token: 0x0602925B RID: 168539 RVA: 0x005A5985 File Offset: 0x005A3B85
		public static void StartIGiantTriggerEnterArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602925C RID: 168540 RVA: 0x005A598E File Offset: 0x005A3B8E
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602925D RID: 168541 RVA: 0x005A5999 File Offset: 0x005A3B99
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602925E RID: 168542 RVA: 0x005A59A4 File Offset: 0x005A3BA4
		public static Offset<IGiantTriggerEnterArea> EndIGiantTriggerEnterArea(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerEnterArea>(builder.EndTable());
		}

		// Token: 0x0602925F RID: 168543 RVA: 0x005A59B4 File Offset: 0x005A3BB4
		public IGiantTriggerEnterAreaT UnPack()
		{
			IGiantTriggerEnterAreaT giantTriggerEnterAreaT = new IGiantTriggerEnterAreaT();
			this.UnPackTo(giantTriggerEnterAreaT);
			return giantTriggerEnterAreaT;
		}

		// Token: 0x06029260 RID: 168544 RVA: 0x005A59CF File Offset: 0x005A3BCF
		public void UnPackTo(IGiantTriggerEnterAreaT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x06029261 RID: 168545 RVA: 0x005A59EC File Offset: 0x005A3BEC
		public static Offset<IGiantTriggerEnterArea> Pack(FlatBufferBuilder builder, IGiantTriggerEnterAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerEnterArea>);
			}
			return IGiantTriggerEnterArea.CreateIGiantTriggerEnterArea(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0400F7CF RID: 63439
		private Table __p;
	}
}

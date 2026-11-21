using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006422 RID: 25634
	public struct IGiantTriggerEnterArea : IFlatbufferObject
	{
		// Token: 0x1700BD51 RID: 48465
		// (get) Token: 0x0602B8DC RID: 178396 RVA: 0x005EE5B3 File Offset: 0x005EC7B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B8DD RID: 178397 RVA: 0x005EE5C0 File Offset: 0x005EC7C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B8DE RID: 178398 RVA: 0x005EE5C8 File Offset: 0x005EC7C8
		public static IGiantTriggerEnterArea GetRootAsIGiantTriggerEnterArea(ByteBuffer _bb)
		{
			return IGiantTriggerEnterArea.GetRootAsIGiantTriggerEnterArea(_bb, default(IGiantTriggerEnterArea));
		}

		// Token: 0x0602B8DF RID: 178399 RVA: 0x005EE5E4 File Offset: 0x005EC7E4
		public static IGiantTriggerEnterArea GetRootAsIGiantTriggerEnterArea(ByteBuffer _bb, IGiantTriggerEnterArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B8E0 RID: 178400 RVA: 0x005EE601 File Offset: 0x005EC801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B8E1 RID: 178401 RVA: 0x005EE610 File Offset: 0x005EC810
		public IGiantTriggerEnterArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD52 RID: 48466
		// (get) Token: 0x0602B8E2 RID: 178402 RVA: 0x005EE620 File Offset: 0x005EC820
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

		// Token: 0x1700BD53 RID: 48467
		// (get) Token: 0x0602B8E3 RID: 178403 RVA: 0x005EE65C File Offset: 0x005EC85C
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

		// Token: 0x0602B8E4 RID: 178404 RVA: 0x005EE698 File Offset: 0x005EC898
		public static Offset<IGiantTriggerEnterArea> CreateIGiantTriggerEnterArea(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, int AreaId = 0)
		{
			builder.StartTable(2);
			IGiantTriggerEnterArea.AddAreaId(builder, AreaId);
			IGiantTriggerEnterArea.AddType(builder, Type);
			return IGiantTriggerEnterArea.EndIGiantTriggerEnterArea(builder);
		}

		// Token: 0x0602B8E5 RID: 178405 RVA: 0x005EE6B5 File Offset: 0x005EC8B5
		public static void StartIGiantTriggerEnterArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B8E6 RID: 178406 RVA: 0x005EE6BE File Offset: 0x005EC8BE
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8E7 RID: 178407 RVA: 0x005EE6C9 File Offset: 0x005EC8C9
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602B8E8 RID: 178408 RVA: 0x005EE6D4 File Offset: 0x005EC8D4
		public static Offset<IGiantTriggerEnterArea> EndIGiantTriggerEnterArea(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerEnterArea>(builder.EndTable());
		}

		// Token: 0x0602B8E9 RID: 178409 RVA: 0x005EE6E4 File Offset: 0x005EC8E4
		public IGiantTriggerEnterAreaT UnPack()
		{
			IGiantTriggerEnterAreaT giantTriggerEnterAreaT = new IGiantTriggerEnterAreaT();
			this.UnPackTo(giantTriggerEnterAreaT);
			return giantTriggerEnterAreaT;
		}

		// Token: 0x0602B8EA RID: 178410 RVA: 0x005EE6FF File Offset: 0x005EC8FF
		public void UnPackTo(IGiantTriggerEnterAreaT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x0602B8EB RID: 178411 RVA: 0x005EE71C File Offset: 0x005EC91C
		public static Offset<IGiantTriggerEnterArea> Pack(FlatBufferBuilder builder, IGiantTriggerEnterAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerEnterArea>);
			}
			return IGiantTriggerEnterArea.CreateIGiantTriggerEnterArea(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0401052A RID: 66858
		private Table __p;
	}
}

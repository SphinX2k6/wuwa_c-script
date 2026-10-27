using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708B RID: 28811
	public struct ISetTeleControlConfig : IFlatbufferObject
	{
		// Token: 0x1700D618 RID: 54808
		// (get) Token: 0x06033041 RID: 208961 RVA: 0x006E1B65 File Offset: 0x006DFD65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033042 RID: 208962 RVA: 0x006E1B72 File Offset: 0x006DFD72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033043 RID: 208963 RVA: 0x006E1B7C File Offset: 0x006DFD7C
		public static ISetTeleControlConfig GetRootAsISetTeleControlConfig(ByteBuffer _bb)
		{
			return ISetTeleControlConfig.GetRootAsISetTeleControlConfig(_bb, default(ISetTeleControlConfig));
		}

		// Token: 0x06033044 RID: 208964 RVA: 0x006E1B98 File Offset: 0x006DFD98
		public static ISetTeleControlConfig GetRootAsISetTeleControlConfig(ByteBuffer _bb, ISetTeleControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033045 RID: 208965 RVA: 0x006E1BB5 File Offset: 0x006DFDB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033046 RID: 208966 RVA: 0x006E1BC4 File Offset: 0x006DFDC4
		public ISetTeleControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D619 RID: 54809
		// (get) Token: 0x06033047 RID: 208967 RVA: 0x006E1BD4 File Offset: 0x006DFDD4
		public ESetTeleControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return (ESetTeleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D61A RID: 54810
		// (get) Token: 0x06033048 RID: 208968 RVA: 0x006E1C10 File Offset: 0x006DFE10
		public int EntityId
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

		// Token: 0x06033049 RID: 208969 RVA: 0x006E1C4C File Offset: 0x006DFE4C
		public static Offset<ISetTeleControlConfig> CreateISetTeleControlConfig(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0)
		{
			builder.StartTable(2);
			ISetTeleControlConfig.AddEntityId(builder, EntityId);
			ISetTeleControlConfig.AddType(builder, Type);
			return ISetTeleControlConfig.EndISetTeleControlConfig(builder);
		}

		// Token: 0x0603304A RID: 208970 RVA: 0x006E1C69 File Offset: 0x006DFE69
		public static void StartISetTeleControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603304B RID: 208971 RVA: 0x006E1C72 File Offset: 0x006DFE72
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603304C RID: 208972 RVA: 0x006E1C7D File Offset: 0x006DFE7D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603304D RID: 208973 RVA: 0x006E1C88 File Offset: 0x006DFE88
		public static Offset<ISetTeleControlConfig> EndISetTeleControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetTeleControlConfig>(builder.EndTable());
		}

		// Token: 0x0603304E RID: 208974 RVA: 0x006E1C98 File Offset: 0x006DFE98
		public ISetTeleControlConfigT UnPack()
		{
			ISetTeleControlConfigT setTeleControlConfigT = new ISetTeleControlConfigT();
			this.UnPackTo(setTeleControlConfigT);
			return setTeleControlConfigT;
		}

		// Token: 0x0603304F RID: 208975 RVA: 0x006E1CB3 File Offset: 0x006DFEB3
		public void UnPackTo(ISetTeleControlConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06033050 RID: 208976 RVA: 0x006E1CD0 File Offset: 0x006DFED0
		public static Offset<ISetTeleControlConfig> Pack(FlatBufferBuilder builder, ISetTeleControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTeleControlConfig>);
			}
			return ISetTeleControlConfig.CreateISetTeleControlConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011AF1 RID: 72433
		private Table __p;
	}
}

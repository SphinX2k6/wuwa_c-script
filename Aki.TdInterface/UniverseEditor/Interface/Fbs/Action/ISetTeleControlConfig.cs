using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007857 RID: 30807
	public struct ISetTeleControlConfig : IFlatbufferObject
	{
		// Token: 0x1700E1FB RID: 57851
		// (get) Token: 0x060362E3 RID: 221923 RVA: 0x00742171 File Offset: 0x00740371
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060362E4 RID: 221924 RVA: 0x0074217E File Offset: 0x0074037E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060362E5 RID: 221925 RVA: 0x00742188 File Offset: 0x00740388
		public static ISetTeleControlConfig GetRootAsISetTeleControlConfig(ByteBuffer _bb)
		{
			return ISetTeleControlConfig.GetRootAsISetTeleControlConfig(_bb, default(ISetTeleControlConfig));
		}

		// Token: 0x060362E6 RID: 221926 RVA: 0x007421A4 File Offset: 0x007403A4
		public static ISetTeleControlConfig GetRootAsISetTeleControlConfig(ByteBuffer _bb, ISetTeleControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060362E7 RID: 221927 RVA: 0x007421C1 File Offset: 0x007403C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060362E8 RID: 221928 RVA: 0x007421D0 File Offset: 0x007403D0
		public ISetTeleControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1FC RID: 57852
		// (get) Token: 0x060362E9 RID: 221929 RVA: 0x007421E0 File Offset: 0x007403E0
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

		// Token: 0x1700E1FD RID: 57853
		// (get) Token: 0x060362EA RID: 221930 RVA: 0x0074221C File Offset: 0x0074041C
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

		// Token: 0x060362EB RID: 221931 RVA: 0x00742258 File Offset: 0x00740458
		public static Offset<ISetTeleControlConfig> CreateISetTeleControlConfig(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0)
		{
			builder.StartTable(2);
			ISetTeleControlConfig.AddEntityId(builder, EntityId);
			ISetTeleControlConfig.AddType(builder, Type);
			return ISetTeleControlConfig.EndISetTeleControlConfig(builder);
		}

		// Token: 0x060362EC RID: 221932 RVA: 0x00742275 File Offset: 0x00740475
		public static void StartISetTeleControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060362ED RID: 221933 RVA: 0x0074227E File Offset: 0x0074047E
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060362EE RID: 221934 RVA: 0x00742289 File Offset: 0x00740489
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060362EF RID: 221935 RVA: 0x00742294 File Offset: 0x00740494
		public static Offset<ISetTeleControlConfig> EndISetTeleControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetTeleControlConfig>(builder.EndTable());
		}

		// Token: 0x060362F0 RID: 221936 RVA: 0x007422A4 File Offset: 0x007404A4
		public ISetTeleControlConfigT UnPack()
		{
			ISetTeleControlConfigT setTeleControlConfigT = new ISetTeleControlConfigT();
			this.UnPackTo(setTeleControlConfigT);
			return setTeleControlConfigT;
		}

		// Token: 0x060362F1 RID: 221937 RVA: 0x007422BF File Offset: 0x007404BF
		public void UnPackTo(ISetTeleControlConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060362F2 RID: 221938 RVA: 0x007422DC File Offset: 0x007404DC
		public static Offset<ISetTeleControlConfig> Pack(FlatBufferBuilder builder, ISetTeleControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTeleControlConfig>);
			}
			return ISetTeleControlConfig.CreateISetTeleControlConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04012ADF RID: 76511
		private Table __p;
	}
}

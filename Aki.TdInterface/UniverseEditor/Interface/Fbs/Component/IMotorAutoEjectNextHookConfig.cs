using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B49 RID: 23369
	public struct IMotorAutoEjectNextHookConfig : IFlatbufferObject
	{
		// Token: 0x1700AA7E RID: 43646
		// (get) Token: 0x060266EA RID: 157418 RVA: 0x005433D4 File Offset: 0x005415D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x005433E1 File Offset: 0x005415E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x005433E8 File Offset: 0x005415E8
		public static IMotorAutoEjectNextHookConfig GetRootAsIMotorAutoEjectNextHookConfig(ByteBuffer _bb)
		{
			return IMotorAutoEjectNextHookConfig.GetRootAsIMotorAutoEjectNextHookConfig(_bb, default(IMotorAutoEjectNextHookConfig));
		}

		// Token: 0x060266ED RID: 157421 RVA: 0x00543404 File Offset: 0x00541604
		public static IMotorAutoEjectNextHookConfig GetRootAsIMotorAutoEjectNextHookConfig(ByteBuffer _bb, IMotorAutoEjectNextHookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060266EE RID: 157422 RVA: 0x00543421 File Offset: 0x00541621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060266EF RID: 157423 RVA: 0x00543430 File Offset: 0x00541630
		public IMotorAutoEjectNextHookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA7F RID: 43647
		// (get) Token: 0x060266F0 RID: 157424 RVA: 0x00543440 File Offset: 0x00541640
		public EMotorAutoEjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorAutoEjectType.NextHook;
				}
				return (EMotorAutoEjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA80 RID: 43648
		// (get) Token: 0x060266F1 RID: 157425 RVA: 0x0054347C File Offset: 0x0054167C
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

		// Token: 0x060266F2 RID: 157426 RVA: 0x005434B8 File Offset: 0x005416B8
		public static Offset<IMotorAutoEjectNextHookConfig> CreateIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook, int EntityId = 0)
		{
			builder.StartTable(2);
			IMotorAutoEjectNextHookConfig.AddEntityId(builder, EntityId);
			IMotorAutoEjectNextHookConfig.AddType(builder, Type);
			return IMotorAutoEjectNextHookConfig.EndIMotorAutoEjectNextHookConfig(builder);
		}

		// Token: 0x060266F3 RID: 157427 RVA: 0x005434D5 File Offset: 0x005416D5
		public static void StartIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060266F4 RID: 157428 RVA: 0x005434DE File Offset: 0x005416DE
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060266F5 RID: 157429 RVA: 0x005434E9 File Offset: 0x005416E9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060266F6 RID: 157430 RVA: 0x005434F4 File Offset: 0x005416F4
		public static Offset<IMotorAutoEjectNextHookConfig> EndIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectNextHookConfig>(builder.EndTable());
		}

		// Token: 0x060266F7 RID: 157431 RVA: 0x00543504 File Offset: 0x00541704
		public IMotorAutoEjectNextHookConfigT UnPack()
		{
			IMotorAutoEjectNextHookConfigT motorAutoEjectNextHookConfigT = new IMotorAutoEjectNextHookConfigT();
			this.UnPackTo(motorAutoEjectNextHookConfigT);
			return motorAutoEjectNextHookConfigT;
		}

		// Token: 0x060266F8 RID: 157432 RVA: 0x0054351F File Offset: 0x0054171F
		public void UnPackTo(IMotorAutoEjectNextHookConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060266F9 RID: 157433 RVA: 0x0054353C File Offset: 0x0054173C
		public static Offset<IMotorAutoEjectNextHookConfig> Pack(FlatBufferBuilder builder, IMotorAutoEjectNextHookConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectNextHookConfig>);
			}
			return IMotorAutoEjectNextHookConfig.CreateIMotorAutoEjectNextHookConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400F542 RID: 62786
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E8F RID: 20111
	public struct IAkEventTypeConfig : IFlatbufferObject
	{
		// Token: 0x17009040 RID: 36928
		// (get) Token: 0x0601FA5C RID: 129628 RVA: 0x0046864F File Offset: 0x0046684F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA5D RID: 129629 RVA: 0x0046865C File Offset: 0x0046685C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA5E RID: 129630 RVA: 0x00468664 File Offset: 0x00466864
		public static IAkEventTypeConfig GetRootAsIAkEventTypeConfig(ByteBuffer _bb)
		{
			return IAkEventTypeConfig.GetRootAsIAkEventTypeConfig(_bb, default(IAkEventTypeConfig));
		}

		// Token: 0x0601FA5F RID: 129631 RVA: 0x00468680 File Offset: 0x00466880
		public static IAkEventTypeConfig GetRootAsIAkEventTypeConfig(ByteBuffer _bb, IAkEventTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA60 RID: 129632 RVA: 0x0046869D File Offset: 0x0046689D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA61 RID: 129633 RVA: 0x004686AC File Offset: 0x004668AC
		public IAkEventTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009041 RID: 36929
		// (get) Token: 0x0601FA62 RID: 129634 RVA: 0x004686BC File Offset: 0x004668BC
		public EAkEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventType.Point;
				}
				return (EAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA63 RID: 129635 RVA: 0x004686F8 File Offset: 0x004668F8
		public static Offset<IAkEventTypeConfig> CreateIAkEventTypeConfig(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point)
		{
			builder.StartTable(1);
			IAkEventTypeConfig.AddType(builder, Type);
			return IAkEventTypeConfig.EndIAkEventTypeConfig(builder);
		}

		// Token: 0x0601FA64 RID: 129636 RVA: 0x0046870E File Offset: 0x0046690E
		public static void StartIAkEventTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FA65 RID: 129637 RVA: 0x00468717 File Offset: 0x00466917
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA66 RID: 129638 RVA: 0x00468722 File Offset: 0x00466922
		public static Offset<IAkEventTypeConfig> EndIAkEventTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAkEventTypeConfig>(builder.EndTable());
		}

		// Token: 0x0601FA67 RID: 129639 RVA: 0x00468730 File Offset: 0x00466930
		public IAkEventTypeConfigT UnPack()
		{
			IAkEventTypeConfigT akEventTypeConfigT = new IAkEventTypeConfigT();
			this.UnPackTo(akEventTypeConfigT);
			return akEventTypeConfigT;
		}

		// Token: 0x0601FA68 RID: 129640 RVA: 0x0046874B File Offset: 0x0046694B
		public void UnPackTo(IAkEventTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FA69 RID: 129641 RVA: 0x0046875C File Offset: 0x0046695C
		public static Offset<IAkEventTypeConfig> Pack(FlatBufferBuilder builder, IAkEventTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAkEventTypeConfig>);
			}
			return IAkEventTypeConfig.CreateIAkEventTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400DC65 RID: 56421
		private Table __p;
	}
}

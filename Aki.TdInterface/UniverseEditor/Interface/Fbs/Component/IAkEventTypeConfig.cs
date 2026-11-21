using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B8 RID: 21432
	public struct IAkEventTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700979F RID: 38815
		// (get) Token: 0x06021751 RID: 137041 RVA: 0x0049D8B4 File Offset: 0x0049BAB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021752 RID: 137042 RVA: 0x0049D8C1 File Offset: 0x0049BAC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021753 RID: 137043 RVA: 0x0049D8C8 File Offset: 0x0049BAC8
		public static IAkEventTypeConfig GetRootAsIAkEventTypeConfig(ByteBuffer _bb)
		{
			return IAkEventTypeConfig.GetRootAsIAkEventTypeConfig(_bb, default(IAkEventTypeConfig));
		}

		// Token: 0x06021754 RID: 137044 RVA: 0x0049D8E4 File Offset: 0x0049BAE4
		public static IAkEventTypeConfig GetRootAsIAkEventTypeConfig(ByteBuffer _bb, IAkEventTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021755 RID: 137045 RVA: 0x0049D901 File Offset: 0x0049BB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021756 RID: 137046 RVA: 0x0049D910 File Offset: 0x0049BB10
		public IAkEventTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097A0 RID: 38816
		// (get) Token: 0x06021757 RID: 137047 RVA: 0x0049D920 File Offset: 0x0049BB20
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

		// Token: 0x06021758 RID: 137048 RVA: 0x0049D95C File Offset: 0x0049BB5C
		public static Offset<IAkEventTypeConfig> CreateIAkEventTypeConfig(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point)
		{
			builder.StartTable(1);
			IAkEventTypeConfig.AddType(builder, Type);
			return IAkEventTypeConfig.EndIAkEventTypeConfig(builder);
		}

		// Token: 0x06021759 RID: 137049 RVA: 0x0049D972 File Offset: 0x0049BB72
		public static void StartIAkEventTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602175A RID: 137050 RVA: 0x0049D97B File Offset: 0x0049BB7B
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602175B RID: 137051 RVA: 0x0049D986 File Offset: 0x0049BB86
		public static Offset<IAkEventTypeConfig> EndIAkEventTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAkEventTypeConfig>(builder.EndTable());
		}

		// Token: 0x0602175C RID: 137052 RVA: 0x0049D994 File Offset: 0x0049BB94
		public IAkEventTypeConfigT UnPack()
		{
			IAkEventTypeConfigT akEventTypeConfigT = new IAkEventTypeConfigT();
			this.UnPackTo(akEventTypeConfigT);
			return akEventTypeConfigT;
		}

		// Token: 0x0602175D RID: 137053 RVA: 0x0049D9AF File Offset: 0x0049BBAF
		public void UnPackTo(IAkEventTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602175E RID: 137054 RVA: 0x0049D9C0 File Offset: 0x0049BBC0
		public static Offset<IAkEventTypeConfig> Pack(FlatBufferBuilder builder, IAkEventTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAkEventTypeConfig>);
			}
			return IAkEventTypeConfig.CreateIAkEventTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400E800 RID: 59392
		private Table __p;
	}
}

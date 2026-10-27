using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAE RID: 27822
	public struct IPhoneSystemInteractBase : IFlatbufferObject
	{
		// Token: 0x1700CF27 RID: 53031
		// (get) Token: 0x0603107B RID: 200827 RVA: 0x006A7AB5 File Offset: 0x006A5CB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603107C RID: 200828 RVA: 0x006A7AC2 File Offset: 0x006A5CC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603107D RID: 200829 RVA: 0x006A7ACC File Offset: 0x006A5CCC
		public static IPhoneSystemInteractBase GetRootAsIPhoneSystemInteractBase(ByteBuffer _bb)
		{
			return IPhoneSystemInteractBase.GetRootAsIPhoneSystemInteractBase(_bb, default(IPhoneSystemInteractBase));
		}

		// Token: 0x0603107E RID: 200830 RVA: 0x006A7AE8 File Offset: 0x006A5CE8
		public static IPhoneSystemInteractBase GetRootAsIPhoneSystemInteractBase(ByteBuffer _bb, IPhoneSystemInteractBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603107F RID: 200831 RVA: 0x006A7B05 File Offset: 0x006A5D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031080 RID: 200832 RVA: 0x006A7B14 File Offset: 0x006A5D14
		public IPhoneSystemInteractBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF28 RID: 53032
		// (get) Token: 0x06031081 RID: 200833 RVA: 0x006A7B24 File Offset: 0x006A5D24
		public EPhoneSystemInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return (EPhoneSystemInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031082 RID: 200834 RVA: 0x006A7B60 File Offset: 0x006A5D60
		public static Offset<IPhoneSystemInteractBase> CreateIPhoneSystemInteractBase(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage)
		{
			builder.StartTable(1);
			IPhoneSystemInteractBase.AddType(builder, Type);
			return IPhoneSystemInteractBase.EndIPhoneSystemInteractBase(builder);
		}

		// Token: 0x06031083 RID: 200835 RVA: 0x006A7B76 File Offset: 0x006A5D76
		public static void StartIPhoneSystemInteractBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031084 RID: 200836 RVA: 0x006A7B7F File Offset: 0x006A5D7F
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031085 RID: 200837 RVA: 0x006A7B8A File Offset: 0x006A5D8A
		public static Offset<IPhoneSystemInteractBase> EndIPhoneSystemInteractBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneSystemInteractBase>(builder.EndTable());
		}

		// Token: 0x06031086 RID: 200838 RVA: 0x006A7B98 File Offset: 0x006A5D98
		public IPhoneSystemInteractBaseT UnPack()
		{
			IPhoneSystemInteractBaseT phoneSystemInteractBaseT = new IPhoneSystemInteractBaseT();
			this.UnPackTo(phoneSystemInteractBaseT);
			return phoneSystemInteractBaseT;
		}

		// Token: 0x06031087 RID: 200839 RVA: 0x006A7BB3 File Offset: 0x006A5DB3
		public void UnPackTo(IPhoneSystemInteractBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031088 RID: 200840 RVA: 0x006A7BC4 File Offset: 0x006A5DC4
		public static Offset<IPhoneSystemInteractBase> Pack(FlatBufferBuilder builder, IPhoneSystemInteractBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneSystemInteractBase>);
			}
			return IPhoneSystemInteractBase.CreateIPhoneSystemInteractBase(builder, _o.Type);
		}

		// Token: 0x04011607 RID: 71175
		private Table __p;
	}
}

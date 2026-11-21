using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007424 RID: 29732
	public struct IPhoneSystemInteractBase : IFlatbufferObject
	{
		// Token: 0x1700DA64 RID: 55908
		// (get) Token: 0x06034052 RID: 213074 RVA: 0x00702CE9 File Offset: 0x00700EE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034053 RID: 213075 RVA: 0x00702CF6 File Offset: 0x00700EF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034054 RID: 213076 RVA: 0x00702D00 File Offset: 0x00700F00
		public static IPhoneSystemInteractBase GetRootAsIPhoneSystemInteractBase(ByteBuffer _bb)
		{
			return IPhoneSystemInteractBase.GetRootAsIPhoneSystemInteractBase(_bb, default(IPhoneSystemInteractBase));
		}

		// Token: 0x06034055 RID: 213077 RVA: 0x00702D1C File Offset: 0x00700F1C
		public static IPhoneSystemInteractBase GetRootAsIPhoneSystemInteractBase(ByteBuffer _bb, IPhoneSystemInteractBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034056 RID: 213078 RVA: 0x00702D39 File Offset: 0x00700F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034057 RID: 213079 RVA: 0x00702D48 File Offset: 0x00700F48
		public IPhoneSystemInteractBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA65 RID: 55909
		// (get) Token: 0x06034058 RID: 213080 RVA: 0x00702D58 File Offset: 0x00700F58
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

		// Token: 0x06034059 RID: 213081 RVA: 0x00702D94 File Offset: 0x00700F94
		public static Offset<IPhoneSystemInteractBase> CreateIPhoneSystemInteractBase(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage)
		{
			builder.StartTable(1);
			IPhoneSystemInteractBase.AddType(builder, Type);
			return IPhoneSystemInteractBase.EndIPhoneSystemInteractBase(builder);
		}

		// Token: 0x0603405A RID: 213082 RVA: 0x00702DAA File Offset: 0x00700FAA
		public static void StartIPhoneSystemInteractBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603405B RID: 213083 RVA: 0x00702DB3 File Offset: 0x00700FB3
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603405C RID: 213084 RVA: 0x00702DBE File Offset: 0x00700FBE
		public static Offset<IPhoneSystemInteractBase> EndIPhoneSystemInteractBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneSystemInteractBase>(builder.EndTable());
		}

		// Token: 0x0603405D RID: 213085 RVA: 0x00702DCC File Offset: 0x00700FCC
		public IPhoneSystemInteractBaseT UnPack()
		{
			IPhoneSystemInteractBaseT phoneSystemInteractBaseT = new IPhoneSystemInteractBaseT();
			this.UnPackTo(phoneSystemInteractBaseT);
			return phoneSystemInteractBaseT;
		}

		// Token: 0x0603405E RID: 213086 RVA: 0x00702DE7 File Offset: 0x00700FE7
		public void UnPackTo(IPhoneSystemInteractBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603405F RID: 213087 RVA: 0x00702DF8 File Offset: 0x00700FF8
		public static Offset<IPhoneSystemInteractBase> Pack(FlatBufferBuilder builder, IPhoneSystemInteractBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneSystemInteractBase>);
			}
			return IPhoneSystemInteractBase.CreateIPhoneSystemInteractBase(builder, _o.Type);
		}

		// Token: 0x04012577 RID: 75127
		private Table __p;
	}
}

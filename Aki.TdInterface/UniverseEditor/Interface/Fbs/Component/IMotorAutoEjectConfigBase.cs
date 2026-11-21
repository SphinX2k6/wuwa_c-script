using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B43 RID: 23363
	public struct IMotorAutoEjectConfigBase : IFlatbufferObject
	{
		// Token: 0x1700AA79 RID: 43641
		// (get) Token: 0x060266CA RID: 157386 RVA: 0x00543113 File Offset: 0x00541313
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266CB RID: 157387 RVA: 0x00543120 File Offset: 0x00541320
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266CC RID: 157388 RVA: 0x00543128 File Offset: 0x00541328
		public static IMotorAutoEjectConfigBase GetRootAsIMotorAutoEjectConfigBase(ByteBuffer _bb)
		{
			return IMotorAutoEjectConfigBase.GetRootAsIMotorAutoEjectConfigBase(_bb, default(IMotorAutoEjectConfigBase));
		}

		// Token: 0x060266CD RID: 157389 RVA: 0x00543144 File Offset: 0x00541344
		public static IMotorAutoEjectConfigBase GetRootAsIMotorAutoEjectConfigBase(ByteBuffer _bb, IMotorAutoEjectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060266CE RID: 157390 RVA: 0x00543161 File Offset: 0x00541361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060266CF RID: 157391 RVA: 0x00543170 File Offset: 0x00541370
		public IMotorAutoEjectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA7A RID: 43642
		// (get) Token: 0x060266D0 RID: 157392 RVA: 0x00543180 File Offset: 0x00541380
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

		// Token: 0x060266D1 RID: 157393 RVA: 0x005431BC File Offset: 0x005413BC
		public static Offset<IMotorAutoEjectConfigBase> CreateIMotorAutoEjectConfigBase(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook)
		{
			builder.StartTable(1);
			IMotorAutoEjectConfigBase.AddType(builder, Type);
			return IMotorAutoEjectConfigBase.EndIMotorAutoEjectConfigBase(builder);
		}

		// Token: 0x060266D2 RID: 157394 RVA: 0x005431D2 File Offset: 0x005413D2
		public static void StartIMotorAutoEjectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060266D3 RID: 157395 RVA: 0x005431DB File Offset: 0x005413DB
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060266D4 RID: 157396 RVA: 0x005431E6 File Offset: 0x005413E6
		public static Offset<IMotorAutoEjectConfigBase> EndIMotorAutoEjectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectConfigBase>(builder.EndTable());
		}

		// Token: 0x060266D5 RID: 157397 RVA: 0x005431F4 File Offset: 0x005413F4
		public IMotorAutoEjectConfigBaseT UnPack()
		{
			IMotorAutoEjectConfigBaseT motorAutoEjectConfigBaseT = new IMotorAutoEjectConfigBaseT();
			this.UnPackTo(motorAutoEjectConfigBaseT);
			return motorAutoEjectConfigBaseT;
		}

		// Token: 0x060266D6 RID: 157398 RVA: 0x0054320F File Offset: 0x0054140F
		public void UnPackTo(IMotorAutoEjectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060266D7 RID: 157399 RVA: 0x00543220 File Offset: 0x00541420
		public static Offset<IMotorAutoEjectConfigBase> Pack(FlatBufferBuilder builder, IMotorAutoEjectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectConfigBase>);
			}
			return IMotorAutoEjectConfigBase.CreateIMotorAutoEjectConfigBase(builder, _o.Type);
		}

		// Token: 0x0400F539 RID: 62777
		private Table __p;
	}
}

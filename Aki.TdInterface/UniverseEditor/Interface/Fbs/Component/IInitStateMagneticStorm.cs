using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AB RID: 22955
	public struct IInitStateMagneticStorm : IFlatbufferObject
	{
		// Token: 0x1700A6A9 RID: 42665
		// (get) Token: 0x060256C3 RID: 153283 RVA: 0x005222F9 File Offset: 0x005204F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060256C4 RID: 153284 RVA: 0x00522306 File Offset: 0x00520506
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060256C5 RID: 153285 RVA: 0x00522310 File Offset: 0x00520510
		public static IInitStateMagneticStorm GetRootAsIInitStateMagneticStorm(ByteBuffer _bb)
		{
			return IInitStateMagneticStorm.GetRootAsIInitStateMagneticStorm(_bb, default(IInitStateMagneticStorm));
		}

		// Token: 0x060256C6 RID: 153286 RVA: 0x0052232C File Offset: 0x0052052C
		public static IInitStateMagneticStorm GetRootAsIInitStateMagneticStorm(ByteBuffer _bb, IInitStateMagneticStorm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060256C7 RID: 153287 RVA: 0x00522349 File Offset: 0x00520549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060256C8 RID: 153288 RVA: 0x00522358 File Offset: 0x00520558
		public IInitStateMagneticStorm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6AA RID: 42666
		// (get) Token: 0x060256C9 RID: 153289 RVA: 0x00522368 File Offset: 0x00520568
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060256CA RID: 153290 RVA: 0x005223A4 File Offset: 0x005205A4
		public static Offset<IInitStateMagneticStorm> CreateIInitStateMagneticStorm(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateMagneticStorm.AddType(builder, Type);
			return IInitStateMagneticStorm.EndIInitStateMagneticStorm(builder);
		}

		// Token: 0x060256CB RID: 153291 RVA: 0x005223BA File Offset: 0x005205BA
		public static void StartIInitStateMagneticStorm(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060256CC RID: 153292 RVA: 0x005223C3 File Offset: 0x005205C3
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060256CD RID: 153293 RVA: 0x005223CE File Offset: 0x005205CE
		public static Offset<IInitStateMagneticStorm> EndIInitStateMagneticStorm(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateMagneticStorm>(builder.EndTable());
		}

		// Token: 0x060256CE RID: 153294 RVA: 0x005223DC File Offset: 0x005205DC
		public IInitStateMagneticStormT UnPack()
		{
			IInitStateMagneticStormT initStateMagneticStormT = new IInitStateMagneticStormT();
			this.UnPackTo(initStateMagneticStormT);
			return initStateMagneticStormT;
		}

		// Token: 0x060256CF RID: 153295 RVA: 0x005223F7 File Offset: 0x005205F7
		public void UnPackTo(IInitStateMagneticStormT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060256D0 RID: 153296 RVA: 0x00522408 File Offset: 0x00520608
		public static Offset<IInitStateMagneticStorm> Pack(FlatBufferBuilder builder, IInitStateMagneticStormT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateMagneticStorm>);
			}
			return IInitStateMagneticStorm.CreateIInitStateMagneticStorm(builder, _o.Type);
		}

		// Token: 0x0400F29F RID: 62111
		private Table __p;
	}
}

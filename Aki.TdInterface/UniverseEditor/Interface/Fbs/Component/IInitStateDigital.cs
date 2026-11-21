using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A8 RID: 22952
	public struct IInitStateDigital : IFlatbufferObject
	{
		// Token: 0x1700A6A6 RID: 42662
		// (get) Token: 0x060256B1 RID: 153265 RVA: 0x00522181 File Offset: 0x00520381
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060256B2 RID: 153266 RVA: 0x0052218E File Offset: 0x0052038E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060256B3 RID: 153267 RVA: 0x00522198 File Offset: 0x00520398
		public static IInitStateDigital GetRootAsIInitStateDigital(ByteBuffer _bb)
		{
			return IInitStateDigital.GetRootAsIInitStateDigital(_bb, default(IInitStateDigital));
		}

		// Token: 0x060256B4 RID: 153268 RVA: 0x005221B4 File Offset: 0x005203B4
		public static IInitStateDigital GetRootAsIInitStateDigital(ByteBuffer _bb, IInitStateDigital obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060256B5 RID: 153269 RVA: 0x005221D1 File Offset: 0x005203D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060256B6 RID: 153270 RVA: 0x005221E0 File Offset: 0x005203E0
		public IInitStateDigital __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6A7 RID: 42663
		// (get) Token: 0x060256B7 RID: 153271 RVA: 0x005221F0 File Offset: 0x005203F0
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

		// Token: 0x060256B8 RID: 153272 RVA: 0x0052222C File Offset: 0x0052042C
		public static Offset<IInitStateDigital> CreateIInitStateDigital(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateDigital.AddType(builder, Type);
			return IInitStateDigital.EndIInitStateDigital(builder);
		}

		// Token: 0x060256B9 RID: 153273 RVA: 0x00522242 File Offset: 0x00520442
		public static void StartIInitStateDigital(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060256BA RID: 153274 RVA: 0x0052224B File Offset: 0x0052044B
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060256BB RID: 153275 RVA: 0x00522256 File Offset: 0x00520456
		public static Offset<IInitStateDigital> EndIInitStateDigital(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateDigital>(builder.EndTable());
		}

		// Token: 0x060256BC RID: 153276 RVA: 0x00522264 File Offset: 0x00520464
		public IInitStateDigitalT UnPack()
		{
			IInitStateDigitalT initStateDigitalT = new IInitStateDigitalT();
			this.UnPackTo(initStateDigitalT);
			return initStateDigitalT;
		}

		// Token: 0x060256BD RID: 153277 RVA: 0x0052227F File Offset: 0x0052047F
		public void UnPackTo(IInitStateDigitalT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060256BE RID: 153278 RVA: 0x00522290 File Offset: 0x00520490
		public static Offset<IInitStateDigital> Pack(FlatBufferBuilder builder, IInitStateDigitalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateDigital>);
			}
			return IInitStateDigital.CreateIInitStateDigital(builder, _o.Type);
		}

		// Token: 0x0400F29D RID: 62109
		private Table __p;
	}
}

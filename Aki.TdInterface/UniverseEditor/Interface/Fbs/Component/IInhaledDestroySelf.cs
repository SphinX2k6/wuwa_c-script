using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005990 RID: 22928
	public struct IInhaledDestroySelf : IFlatbufferObject
	{
		// Token: 0x1700A683 RID: 42627
		// (get) Token: 0x06025607 RID: 153095 RVA: 0x00521051 File Offset: 0x0051F251
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025608 RID: 153096 RVA: 0x0052105E File Offset: 0x0051F25E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025609 RID: 153097 RVA: 0x00521068 File Offset: 0x0051F268
		public static IInhaledDestroySelf GetRootAsIInhaledDestroySelf(ByteBuffer _bb)
		{
			return IInhaledDestroySelf.GetRootAsIInhaledDestroySelf(_bb, default(IInhaledDestroySelf));
		}

		// Token: 0x0602560A RID: 153098 RVA: 0x00521084 File Offset: 0x0051F284
		public static IInhaledDestroySelf GetRootAsIInhaledDestroySelf(ByteBuffer _bb, IInhaledDestroySelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602560B RID: 153099 RVA: 0x005210A1 File Offset: 0x0051F2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602560C RID: 153100 RVA: 0x005210B0 File Offset: 0x0051F2B0
		public IInhaledDestroySelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A684 RID: 42628
		// (get) Token: 0x0602560D RID: 153101 RVA: 0x005210C0 File Offset: 0x0051F2C0
		public EInhaledPerResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return (EInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602560E RID: 153102 RVA: 0x005210FC File Offset: 0x0051F2FC
		public static Offset<IInhaledDestroySelf> CreateIInhaledDestroySelf(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf)
		{
			builder.StartTable(1);
			IInhaledDestroySelf.AddType(builder, Type);
			return IInhaledDestroySelf.EndIInhaledDestroySelf(builder);
		}

		// Token: 0x0602560F RID: 153103 RVA: 0x00521112 File Offset: 0x0051F312
		public static void StartIInhaledDestroySelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025610 RID: 153104 RVA: 0x0052111B File Offset: 0x0051F31B
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025611 RID: 153105 RVA: 0x00521126 File Offset: 0x0051F326
		public static Offset<IInhaledDestroySelf> EndIInhaledDestroySelf(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledDestroySelf>(builder.EndTable());
		}

		// Token: 0x06025612 RID: 153106 RVA: 0x00521134 File Offset: 0x0051F334
		public IInhaledDestroySelfT UnPack()
		{
			IInhaledDestroySelfT inhaledDestroySelfT = new IInhaledDestroySelfT();
			this.UnPackTo(inhaledDestroySelfT);
			return inhaledDestroySelfT;
		}

		// Token: 0x06025613 RID: 153107 RVA: 0x0052114F File Offset: 0x0051F34F
		public void UnPackTo(IInhaledDestroySelfT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025614 RID: 153108 RVA: 0x00521160 File Offset: 0x0051F360
		public static Offset<IInhaledDestroySelf> Pack(FlatBufferBuilder builder, IInhaledDestroySelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledDestroySelf>);
			}
			return IInhaledDestroySelf.CreateIInhaledDestroySelf(builder, _o.Type);
		}

		// Token: 0x0400F282 RID: 62082
		private Table __p;
	}
}

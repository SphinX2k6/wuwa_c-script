using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006780 RID: 26496
	public struct IFadeBackgroundType : IFlatbufferObject
	{
		// Token: 0x1700C4AE RID: 50350
		// (get) Token: 0x0602E191 RID: 188817 RVA: 0x0064C312 File Offset: 0x0064A512
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E192 RID: 188818 RVA: 0x0064C31F File Offset: 0x0064A51F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E193 RID: 188819 RVA: 0x0064C328 File Offset: 0x0064A528
		public static IFadeBackgroundType GetRootAsIFadeBackgroundType(ByteBuffer _bb)
		{
			return IFadeBackgroundType.GetRootAsIFadeBackgroundType(_bb, default(IFadeBackgroundType));
		}

		// Token: 0x0602E194 RID: 188820 RVA: 0x0064C344 File Offset: 0x0064A544
		public static IFadeBackgroundType GetRootAsIFadeBackgroundType(ByteBuffer _bb, IFadeBackgroundType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E195 RID: 188821 RVA: 0x0064C361 File Offset: 0x0064A561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E196 RID: 188822 RVA: 0x0064C370 File Offset: 0x0064A570
		public IFadeBackgroundType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4AF RID: 50351
		// (get) Token: 0x0602E197 RID: 188823 RVA: 0x0064C380 File Offset: 0x0064A580
		public EFadeBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundType.Spine;
				}
				return (EFadeBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E198 RID: 188824 RVA: 0x0064C3BC File Offset: 0x0064A5BC
		public static Offset<IFadeBackgroundType> CreateIFadeBackgroundType(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine)
		{
			builder.StartTable(1);
			IFadeBackgroundType.AddType(builder, Type);
			return IFadeBackgroundType.EndIFadeBackgroundType(builder);
		}

		// Token: 0x0602E199 RID: 188825 RVA: 0x0064C3D2 File Offset: 0x0064A5D2
		public static void StartIFadeBackgroundType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E19A RID: 188826 RVA: 0x0064C3DB File Offset: 0x0064A5DB
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E19B RID: 188827 RVA: 0x0064C3E6 File Offset: 0x0064A5E6
		public static Offset<IFadeBackgroundType> EndIFadeBackgroundType(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundType>(builder.EndTable());
		}

		// Token: 0x0602E19C RID: 188828 RVA: 0x0064C3F4 File Offset: 0x0064A5F4
		public IFadeBackgroundTypeT UnPack()
		{
			IFadeBackgroundTypeT fadeBackgroundTypeT = new IFadeBackgroundTypeT();
			this.UnPackTo(fadeBackgroundTypeT);
			return fadeBackgroundTypeT;
		}

		// Token: 0x0602E19D RID: 188829 RVA: 0x0064C40F File Offset: 0x0064A60F
		public void UnPackTo(IFadeBackgroundTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E19E RID: 188830 RVA: 0x0064C420 File Offset: 0x0064A620
		public static Offset<IFadeBackgroundType> Pack(FlatBufferBuilder builder, IFadeBackgroundTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundType>);
			}
			return IFadeBackgroundType.CreateIFadeBackgroundType(builder, _o.Type);
		}

		// Token: 0x04010E80 RID: 69248
		private Table __p;
	}
}

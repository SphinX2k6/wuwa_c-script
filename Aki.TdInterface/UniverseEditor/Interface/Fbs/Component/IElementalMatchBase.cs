using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005132 RID: 20786
	public struct IElementalMatchBase : IFlatbufferObject
	{
		// Token: 0x17009787 RID: 38791
		// (get) Token: 0x0602186E RID: 137326 RVA: 0x004A7C32 File Offset: 0x004A5E32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602186F RID: 137327 RVA: 0x004A7C3F File Offset: 0x004A5E3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021870 RID: 137328 RVA: 0x004A7C48 File Offset: 0x004A5E48
		public static IElementalMatchBase GetRootAsIElementalMatchBase(ByteBuffer _bb)
		{
			return IElementalMatchBase.GetRootAsIElementalMatchBase(_bb, default(IElementalMatchBase));
		}

		// Token: 0x06021871 RID: 137329 RVA: 0x004A7C64 File Offset: 0x004A5E64
		public static IElementalMatchBase GetRootAsIElementalMatchBase(ByteBuffer _bb, IElementalMatchBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021872 RID: 137330 RVA: 0x004A7C81 File Offset: 0x004A5E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021873 RID: 137331 RVA: 0x004A7C90 File Offset: 0x004A5E90
		public IElementalMatchBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009788 RID: 38792
		// (get) Token: 0x06021874 RID: 137332 RVA: 0x004A7CA0 File Offset: 0x004A5EA0
		public EElementalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021875 RID: 137333 RVA: 0x004A7CDC File Offset: 0x004A5EDC
		public static Offset<IElementalMatchBase> CreateIElementalMatchBase(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IElementalMatchBase.AddType(builder, Type);
			return IElementalMatchBase.EndIElementalMatchBase(builder);
		}

		// Token: 0x06021876 RID: 137334 RVA: 0x004A7CF2 File Offset: 0x004A5EF2
		public static void StartIElementalMatchBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021877 RID: 137335 RVA: 0x004A7CFB File Offset: 0x004A5EFB
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021878 RID: 137336 RVA: 0x004A7D06 File Offset: 0x004A5F06
		public static Offset<IElementalMatchBase> EndIElementalMatchBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalMatchBase>(builder.EndTable());
		}

		// Token: 0x06021879 RID: 137337 RVA: 0x004A7D14 File Offset: 0x004A5F14
		public IElementalMatchBaseT UnPack()
		{
			IElementalMatchBaseT elementalMatchBaseT = new IElementalMatchBaseT();
			this.UnPackTo(elementalMatchBaseT);
			return elementalMatchBaseT;
		}

		// Token: 0x0602187A RID: 137338 RVA: 0x004A7D2F File Offset: 0x004A5F2F
		public void UnPackTo(IElementalMatchBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602187B RID: 137339 RVA: 0x004A7D40 File Offset: 0x004A5F40
		public static Offset<IElementalMatchBase> Pack(FlatBufferBuilder builder, IElementalMatchBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalMatchBase>);
			}
			return IElementalMatchBase.CreateIElementalMatchBase(builder, _o.Type);
		}

		// Token: 0x0400E1B6 RID: 57782
		private Table __p;
	}
}

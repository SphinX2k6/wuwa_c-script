using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005697 RID: 22167
	public struct IElementalMatchBase : IFlatbufferObject
	{
		// Token: 0x17009F74 RID: 40820
		// (get) Token: 0x060237C2 RID: 145346 RVA: 0x004E1BBE File Offset: 0x004DFDBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237C3 RID: 145347 RVA: 0x004E1BCB File Offset: 0x004DFDCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237C4 RID: 145348 RVA: 0x004E1BD4 File Offset: 0x004DFDD4
		public static IElementalMatchBase GetRootAsIElementalMatchBase(ByteBuffer _bb)
		{
			return IElementalMatchBase.GetRootAsIElementalMatchBase(_bb, default(IElementalMatchBase));
		}

		// Token: 0x060237C5 RID: 145349 RVA: 0x004E1BF0 File Offset: 0x004DFDF0
		public static IElementalMatchBase GetRootAsIElementalMatchBase(ByteBuffer _bb, IElementalMatchBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237C6 RID: 145350 RVA: 0x004E1C0D File Offset: 0x004DFE0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237C7 RID: 145351 RVA: 0x004E1C1C File Offset: 0x004DFE1C
		public IElementalMatchBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F75 RID: 40821
		// (get) Token: 0x060237C8 RID: 145352 RVA: 0x004E1C2C File Offset: 0x004DFE2C
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

		// Token: 0x060237C9 RID: 145353 RVA: 0x004E1C68 File Offset: 0x004DFE68
		public static Offset<IElementalMatchBase> CreateIElementalMatchBase(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IElementalMatchBase.AddType(builder, Type);
			return IElementalMatchBase.EndIElementalMatchBase(builder);
		}

		// Token: 0x060237CA RID: 145354 RVA: 0x004E1C7E File Offset: 0x004DFE7E
		public static void StartIElementalMatchBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060237CB RID: 145355 RVA: 0x004E1C87 File Offset: 0x004DFE87
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060237CC RID: 145356 RVA: 0x004E1C92 File Offset: 0x004DFE92
		public static Offset<IElementalMatchBase> EndIElementalMatchBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalMatchBase>(builder.EndTable());
		}

		// Token: 0x060237CD RID: 145357 RVA: 0x004E1CA0 File Offset: 0x004DFEA0
		public IElementalMatchBaseT UnPack()
		{
			IElementalMatchBaseT elementalMatchBaseT = new IElementalMatchBaseT();
			this.UnPackTo(elementalMatchBaseT);
			return elementalMatchBaseT;
		}

		// Token: 0x060237CE RID: 145358 RVA: 0x004E1CBB File Offset: 0x004DFEBB
		public void UnPackTo(IElementalMatchBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060237CF RID: 145359 RVA: 0x004E1CCC File Offset: 0x004DFECC
		public static Offset<IElementalMatchBase> Pack(FlatBufferBuilder builder, IElementalMatchBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalMatchBase>);
			}
			return IElementalMatchBase.CreateIElementalMatchBase(builder, _o.Type);
		}

		// Token: 0x0400EDB3 RID: 60851
		private Table __p;
	}
}

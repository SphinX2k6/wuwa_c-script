using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F50 RID: 16208
	public struct INewHandInItemsBase : IFlatbufferObject
	{
		// Token: 0x170070B7 RID: 28855
		// (get) Token: 0x060170C0 RID: 94400 RVA: 0x00352B6E File Offset: 0x00350D6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170C1 RID: 94401 RVA: 0x00352B7B File Offset: 0x00350D7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170C2 RID: 94402 RVA: 0x00352B84 File Offset: 0x00350D84
		public static INewHandInItemsBase GetRootAsINewHandInItemsBase(ByteBuffer _bb)
		{
			return INewHandInItemsBase.GetRootAsINewHandInItemsBase(_bb, default(INewHandInItemsBase));
		}

		// Token: 0x060170C3 RID: 94403 RVA: 0x00352BA0 File Offset: 0x00350DA0
		public static INewHandInItemsBase GetRootAsINewHandInItemsBase(ByteBuffer _bb, INewHandInItemsBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170C4 RID: 94404 RVA: 0x00352BBD File Offset: 0x00350DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170C5 RID: 94405 RVA: 0x00352BCC File Offset: 0x00350DCC
		public INewHandInItemsBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070B8 RID: 28856
		// (get) Token: 0x060170C6 RID: 94406 RVA: 0x00352BDC File Offset: 0x00350DDC
		public ENewHandInItemsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewHandInItemsType.ProjectionMachine;
				}
				return (ENewHandInItemsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060170C7 RID: 94407 RVA: 0x00352C18 File Offset: 0x00350E18
		public static Offset<INewHandInItemsBase> CreateINewHandInItemsBase(FlatBufferBuilder builder, ENewHandInItemsType Type = ENewHandInItemsType.ProjectionMachine)
		{
			builder.StartTable(1);
			INewHandInItemsBase.AddType(builder, Type);
			return INewHandInItemsBase.EndINewHandInItemsBase(builder);
		}

		// Token: 0x060170C8 RID: 94408 RVA: 0x00352C2E File Offset: 0x00350E2E
		public static void StartINewHandInItemsBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060170C9 RID: 94409 RVA: 0x00352C37 File Offset: 0x00350E37
		public static void AddType(FlatBufferBuilder builder, ENewHandInItemsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170CA RID: 94410 RVA: 0x00352C42 File Offset: 0x00350E42
		public static Offset<INewHandInItemsBase> EndINewHandInItemsBase(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsBase>(builder.EndTable());
		}

		// Token: 0x060170CB RID: 94411 RVA: 0x00352C50 File Offset: 0x00350E50
		public INewHandInItemsBaseT UnPack()
		{
			INewHandInItemsBaseT newHandInItemsBaseT = new INewHandInItemsBaseT();
			this.UnPackTo(newHandInItemsBaseT);
			return newHandInItemsBaseT;
		}

		// Token: 0x060170CC RID: 94412 RVA: 0x00352C6B File Offset: 0x00350E6B
		public void UnPackTo(INewHandInItemsBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060170CD RID: 94413 RVA: 0x00352C7C File Offset: 0x00350E7C
		public static Offset<INewHandInItemsBase> Pack(FlatBufferBuilder builder, INewHandInItemsBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewHandInItemsBase>);
			}
			return INewHandInItemsBase.CreateINewHandInItemsBase(builder, _o.Type);
		}

		// Token: 0x0400B961 RID: 47457
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007525 RID: 29989
	public struct IPresentationType : IFlatbufferObject
	{
		// Token: 0x1700DCA7 RID: 56487
		// (get) Token: 0x06034975 RID: 215413 RVA: 0x00713E16 File Offset: 0x00712016
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034976 RID: 215414 RVA: 0x00713E23 File Offset: 0x00712023
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034977 RID: 215415 RVA: 0x00713E2C File Offset: 0x0071202C
		public static IPresentationType GetRootAsIPresentationType(ByteBuffer _bb)
		{
			return IPresentationType.GetRootAsIPresentationType(_bb, default(IPresentationType));
		}

		// Token: 0x06034978 RID: 215416 RVA: 0x00713E48 File Offset: 0x00712048
		public static IPresentationType GetRootAsIPresentationType(ByteBuffer _bb, IPresentationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034979 RID: 215417 RVA: 0x00713E65 File Offset: 0x00712065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603497A RID: 215418 RVA: 0x00713E74 File Offset: 0x00712074
		public IPresentationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCA8 RID: 56488
		// (get) Token: 0x0603497B RID: 215419 RVA: 0x00713E84 File Offset: 0x00712084
		public EResetPresentationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPresentationType.Failure;
				}
				return (EResetPresentationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603497C RID: 215420 RVA: 0x00713EC0 File Offset: 0x007120C0
		public static Offset<IPresentationType> CreateIPresentationType(FlatBufferBuilder builder, EResetPresentationType Type = EResetPresentationType.Failure)
		{
			builder.StartTable(1);
			IPresentationType.AddType(builder, Type);
			return IPresentationType.EndIPresentationType(builder);
		}

		// Token: 0x0603497D RID: 215421 RVA: 0x00713ED6 File Offset: 0x007120D6
		public static void StartIPresentationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603497E RID: 215422 RVA: 0x00713EDF File Offset: 0x007120DF
		public static void AddType(FlatBufferBuilder builder, EResetPresentationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603497F RID: 215423 RVA: 0x00713EEA File Offset: 0x007120EA
		public static Offset<IPresentationType> EndIPresentationType(FlatBufferBuilder builder)
		{
			return new Offset<IPresentationType>(builder.EndTable());
		}

		// Token: 0x06034980 RID: 215424 RVA: 0x00713EF8 File Offset: 0x007120F8
		public IPresentationTypeT UnPack()
		{
			IPresentationTypeT presentationTypeT = new IPresentationTypeT();
			this.UnPackTo(presentationTypeT);
			return presentationTypeT;
		}

		// Token: 0x06034981 RID: 215425 RVA: 0x00713F13 File Offset: 0x00712113
		public void UnPackTo(IPresentationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034982 RID: 215426 RVA: 0x00713F24 File Offset: 0x00712124
		public static Offset<IPresentationType> Pack(FlatBufferBuilder builder, IPresentationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPresentationType>);
			}
			return IPresentationType.CreateIPresentationType(builder, _o.Type);
		}

		// Token: 0x040126FB RID: 75515
		private Table __p;
	}
}

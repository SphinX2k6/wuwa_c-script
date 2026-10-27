using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D67 RID: 15719
	public struct ICheckSpringFestivalGameplayType : IFlatbufferObject
	{
		// Token: 0x17006BE1 RID: 27617
		// (get) Token: 0x06015C05 RID: 89093 RVA: 0x00323167 File Offset: 0x00321367
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C06 RID: 89094 RVA: 0x00323174 File Offset: 0x00321374
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C07 RID: 89095 RVA: 0x0032317C File Offset: 0x0032137C
		public static ICheckSpringFestivalGameplayType GetRootAsICheckSpringFestivalGameplayType(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGameplayType.GetRootAsICheckSpringFestivalGameplayType(_bb, default(ICheckSpringFestivalGameplayType));
		}

		// Token: 0x06015C08 RID: 89096 RVA: 0x00323198 File Offset: 0x00321398
		public static ICheckSpringFestivalGameplayType GetRootAsICheckSpringFestivalGameplayType(ByteBuffer _bb, ICheckSpringFestivalGameplayType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C09 RID: 89097 RVA: 0x003231B5 File Offset: 0x003213B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C0A RID: 89098 RVA: 0x003231C4 File Offset: 0x003213C4
		public ICheckSpringFestivalGameplayType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BE2 RID: 27618
		// (get) Token: 0x06015C0B RID: 89099 RVA: 0x003231D4 File Offset: 0x003213D4
		public ESpringFestivalGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpringFestivalGameplayType.MixDrinks;
				}
				return (ESpringFestivalGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015C0C RID: 89100 RVA: 0x00323210 File Offset: 0x00321410
		public static Offset<ICheckSpringFestivalGameplayType> CreateICheckSpringFestivalGameplayType(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks)
		{
			builder.StartTable(1);
			ICheckSpringFestivalGameplayType.AddType(builder, Type);
			return ICheckSpringFestivalGameplayType.EndICheckSpringFestivalGameplayType(builder);
		}

		// Token: 0x06015C0D RID: 89101 RVA: 0x00323226 File Offset: 0x00321426
		public static void StartICheckSpringFestivalGameplayType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015C0E RID: 89102 RVA: 0x0032322F File Offset: 0x0032142F
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C0F RID: 89103 RVA: 0x0032323A File Offset: 0x0032143A
		public static Offset<ICheckSpringFestivalGameplayType> EndICheckSpringFestivalGameplayType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGameplayType>(builder.EndTable());
		}

		// Token: 0x06015C10 RID: 89104 RVA: 0x00323248 File Offset: 0x00321448
		public ICheckSpringFestivalGameplayTypeT UnPack()
		{
			ICheckSpringFestivalGameplayTypeT checkSpringFestivalGameplayTypeT = new ICheckSpringFestivalGameplayTypeT();
			this.UnPackTo(checkSpringFestivalGameplayTypeT);
			return checkSpringFestivalGameplayTypeT;
		}

		// Token: 0x06015C11 RID: 89105 RVA: 0x00323263 File Offset: 0x00321463
		public void UnPackTo(ICheckSpringFestivalGameplayTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015C12 RID: 89106 RVA: 0x00323274 File Offset: 0x00321474
		public static Offset<ICheckSpringFestivalGameplayType> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGameplayTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGameplayType>);
			}
			return ICheckSpringFestivalGameplayType.CreateICheckSpringFestivalGameplayType(builder, _o.Type);
		}

		// Token: 0x0400B649 RID: 46665
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417E RID: 16766
	public struct ICheckSpringFestivalGameplayType : IFlatbufferObject
	{
		// Token: 0x1700719B RID: 29083
		// (get) Token: 0x0601713D RID: 94525 RVA: 0x0034A3DF File Offset: 0x003485DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x0034A3EC File Offset: 0x003485EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x0034A3F4 File Offset: 0x003485F4
		public static ICheckSpringFestivalGameplayType GetRootAsICheckSpringFestivalGameplayType(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGameplayType.GetRootAsICheckSpringFestivalGameplayType(_bb, default(ICheckSpringFestivalGameplayType));
		}

		// Token: 0x06017140 RID: 94528 RVA: 0x0034A410 File Offset: 0x00348610
		public static ICheckSpringFestivalGameplayType GetRootAsICheckSpringFestivalGameplayType(ByteBuffer _bb, ICheckSpringFestivalGameplayType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017141 RID: 94529 RVA: 0x0034A42D File Offset: 0x0034862D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017142 RID: 94530 RVA: 0x0034A43C File Offset: 0x0034863C
		public ICheckSpringFestivalGameplayType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700719C RID: 29084
		// (get) Token: 0x06017143 RID: 94531 RVA: 0x0034A44C File Offset: 0x0034864C
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

		// Token: 0x06017144 RID: 94532 RVA: 0x0034A488 File Offset: 0x00348688
		public static Offset<ICheckSpringFestivalGameplayType> CreateICheckSpringFestivalGameplayType(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks)
		{
			builder.StartTable(1);
			ICheckSpringFestivalGameplayType.AddType(builder, Type);
			return ICheckSpringFestivalGameplayType.EndICheckSpringFestivalGameplayType(builder);
		}

		// Token: 0x06017145 RID: 94533 RVA: 0x0034A49E File Offset: 0x0034869E
		public static void StartICheckSpringFestivalGameplayType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017146 RID: 94534 RVA: 0x0034A4A7 File Offset: 0x003486A7
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017147 RID: 94535 RVA: 0x0034A4B2 File Offset: 0x003486B2
		public static Offset<ICheckSpringFestivalGameplayType> EndICheckSpringFestivalGameplayType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGameplayType>(builder.EndTable());
		}

		// Token: 0x06017148 RID: 94536 RVA: 0x0034A4C0 File Offset: 0x003486C0
		public ICheckSpringFestivalGameplayTypeT UnPack()
		{
			ICheckSpringFestivalGameplayTypeT checkSpringFestivalGameplayTypeT = new ICheckSpringFestivalGameplayTypeT();
			this.UnPackTo(checkSpringFestivalGameplayTypeT);
			return checkSpringFestivalGameplayTypeT;
		}

		// Token: 0x06017149 RID: 94537 RVA: 0x0034A4DB File Offset: 0x003486DB
		public void UnPackTo(ICheckSpringFestivalGameplayTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601714A RID: 94538 RVA: 0x0034A4EC File Offset: 0x003486EC
		public static Offset<ICheckSpringFestivalGameplayType> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGameplayTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGameplayType>);
			}
			return ICheckSpringFestivalGameplayType.CreateICheckSpringFestivalGameplayType(builder, _o.Type);
		}

		// Token: 0x0400BFF6 RID: 49142
		private Table __p;
	}
}

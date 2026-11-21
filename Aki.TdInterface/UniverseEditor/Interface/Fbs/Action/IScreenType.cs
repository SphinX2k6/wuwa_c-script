using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007702 RID: 30466
	public struct IScreenType : IFlatbufferObject
	{
		// Token: 0x1700DF73 RID: 57203
		// (get) Token: 0x06035749 RID: 218953 RVA: 0x0072B1BD File Offset: 0x007293BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603574A RID: 218954 RVA: 0x0072B1CA File Offset: 0x007293CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603574B RID: 218955 RVA: 0x0072B1D4 File Offset: 0x007293D4
		public static IScreenType GetRootAsIScreenType(ByteBuffer _bb)
		{
			return IScreenType.GetRootAsIScreenType(_bb, default(IScreenType));
		}

		// Token: 0x0603574C RID: 218956 RVA: 0x0072B1F0 File Offset: 0x007293F0
		public static IScreenType GetRootAsIScreenType(ByteBuffer _bb, IScreenType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603574D RID: 218957 RVA: 0x0072B20D File Offset: 0x0072940D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603574E RID: 218958 RVA: 0x0072B21C File Offset: 0x0072941C
		public IScreenType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF74 RID: 57204
		// (get) Token: 0x0603574F RID: 218959 RVA: 0x0072B22C File Offset: 0x0072942C
		public EScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScreenType.Main;
				}
				return (EScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035750 RID: 218960 RVA: 0x0072B268 File Offset: 0x00729468
		public static Offset<IScreenType> CreateIScreenType(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main)
		{
			builder.StartTable(1);
			IScreenType.AddType(builder, Type);
			return IScreenType.EndIScreenType(builder);
		}

		// Token: 0x06035751 RID: 218961 RVA: 0x0072B27E File Offset: 0x0072947E
		public static void StartIScreenType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035752 RID: 218962 RVA: 0x0072B287 File Offset: 0x00729487
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035753 RID: 218963 RVA: 0x0072B292 File Offset: 0x00729492
		public static Offset<IScreenType> EndIScreenType(FlatBufferBuilder builder)
		{
			return new Offset<IScreenType>(builder.EndTable());
		}

		// Token: 0x06035754 RID: 218964 RVA: 0x0072B2A0 File Offset: 0x007294A0
		public IScreenTypeT UnPack()
		{
			IScreenTypeT screenTypeT = new IScreenTypeT();
			this.UnPackTo(screenTypeT);
			return screenTypeT;
		}

		// Token: 0x06035755 RID: 218965 RVA: 0x0072B2BB File Offset: 0x007294BB
		public void UnPackTo(IScreenTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035756 RID: 218966 RVA: 0x0072B2CC File Offset: 0x007294CC
		public static Offset<IScreenType> Pack(FlatBufferBuilder builder, IScreenTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScreenType>);
			}
			return IScreenType.CreateIScreenType(builder, _o.Type);
		}

		// Token: 0x04012917 RID: 76055
		private Table __p;
	}
}

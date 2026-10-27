using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C6 RID: 26310
	public struct IEnterOrbitalCameraType : IFlatbufferObject
	{
		// Token: 0x1700C380 RID: 50048
		// (get) Token: 0x0602DBD0 RID: 187344 RVA: 0x00641D0C File Offset: 0x0063FF0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBD1 RID: 187345 RVA: 0x00641D19 File Offset: 0x0063FF19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBD2 RID: 187346 RVA: 0x00641D20 File Offset: 0x0063FF20
		public static IEnterOrbitalCameraType GetRootAsIEnterOrbitalCameraType(ByteBuffer _bb)
		{
			return IEnterOrbitalCameraType.GetRootAsIEnterOrbitalCameraType(_bb, default(IEnterOrbitalCameraType));
		}

		// Token: 0x0602DBD3 RID: 187347 RVA: 0x00641D3C File Offset: 0x0063FF3C
		public static IEnterOrbitalCameraType GetRootAsIEnterOrbitalCameraType(ByteBuffer _bb, IEnterOrbitalCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBD4 RID: 187348 RVA: 0x00641D59 File Offset: 0x0063FF59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBD5 RID: 187349 RVA: 0x00641D68 File Offset: 0x0063FF68
		public IEnterOrbitalCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C381 RID: 50049
		// (get) Token: 0x0602DBD6 RID: 187350 RVA: 0x00641D78 File Offset: 0x0063FF78
		public EEnterOrbitalCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnterOrbitalCameraType.ControlByMove;
				}
				return (EEnterOrbitalCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DBD7 RID: 187351 RVA: 0x00641DB4 File Offset: 0x0063FFB4
		public static Offset<IEnterOrbitalCameraType> CreateIEnterOrbitalCameraType(FlatBufferBuilder builder, EEnterOrbitalCameraType Type = EEnterOrbitalCameraType.ControlByMove)
		{
			builder.StartTable(1);
			IEnterOrbitalCameraType.AddType(builder, Type);
			return IEnterOrbitalCameraType.EndIEnterOrbitalCameraType(builder);
		}

		// Token: 0x0602DBD8 RID: 187352 RVA: 0x00641DCA File Offset: 0x0063FFCA
		public static void StartIEnterOrbitalCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DBD9 RID: 187353 RVA: 0x00641DD3 File Offset: 0x0063FFD3
		public static void AddType(FlatBufferBuilder builder, EEnterOrbitalCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DBDA RID: 187354 RVA: 0x00641DDE File Offset: 0x0063FFDE
		public static Offset<IEnterOrbitalCameraType> EndIEnterOrbitalCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCameraType>(builder.EndTable());
		}

		// Token: 0x0602DBDB RID: 187355 RVA: 0x00641DEC File Offset: 0x0063FFEC
		public IEnterOrbitalCameraTypeT UnPack()
		{
			IEnterOrbitalCameraTypeT enterOrbitalCameraTypeT = new IEnterOrbitalCameraTypeT();
			this.UnPackTo(enterOrbitalCameraTypeT);
			return enterOrbitalCameraTypeT;
		}

		// Token: 0x0602DBDC RID: 187356 RVA: 0x00641E07 File Offset: 0x00640007
		public void UnPackTo(IEnterOrbitalCameraTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DBDD RID: 187357 RVA: 0x00641E18 File Offset: 0x00640018
		public static Offset<IEnterOrbitalCameraType> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCameraType>);
			}
			return IEnterOrbitalCameraType.CreateIEnterOrbitalCameraType(builder, _o.Type);
		}

		// Token: 0x04010D8F RID: 69007
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A68 RID: 27240
	public struct IMainScreen : IFlatbufferObject
	{
		// Token: 0x1700CA1B RID: 51739
		// (get) Token: 0x0602FB52 RID: 195410 RVA: 0x0067E1D9 File Offset: 0x0067C3D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB53 RID: 195411 RVA: 0x0067E1E6 File Offset: 0x0067C3E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB54 RID: 195412 RVA: 0x0067E1F0 File Offset: 0x0067C3F0
		public static IMainScreen GetRootAsIMainScreen(ByteBuffer _bb)
		{
			return IMainScreen.GetRootAsIMainScreen(_bb, default(IMainScreen));
		}

		// Token: 0x0602FB55 RID: 195413 RVA: 0x0067E20C File Offset: 0x0067C40C
		public static IMainScreen GetRootAsIMainScreen(ByteBuffer _bb, IMainScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB56 RID: 195414 RVA: 0x0067E229 File Offset: 0x0067C429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB57 RID: 195415 RVA: 0x0067E238 File Offset: 0x0067C438
		public IMainScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA1C RID: 51740
		// (get) Token: 0x0602FB58 RID: 195416 RVA: 0x0067E248 File Offset: 0x0067C448
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

		// Token: 0x0602FB59 RID: 195417 RVA: 0x0067E284 File Offset: 0x0067C484
		public static Offset<IMainScreen> CreateIMainScreen(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main)
		{
			builder.StartTable(1);
			IMainScreen.AddType(builder, Type);
			return IMainScreen.EndIMainScreen(builder);
		}

		// Token: 0x0602FB5A RID: 195418 RVA: 0x0067E29A File Offset: 0x0067C49A
		public static void StartIMainScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FB5B RID: 195419 RVA: 0x0067E2A3 File Offset: 0x0067C4A3
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FB5C RID: 195420 RVA: 0x0067E2AE File Offset: 0x0067C4AE
		public static Offset<IMainScreen> EndIMainScreen(FlatBufferBuilder builder)
		{
			return new Offset<IMainScreen>(builder.EndTable());
		}

		// Token: 0x0602FB5D RID: 195421 RVA: 0x0067E2BC File Offset: 0x0067C4BC
		public IMainScreenT UnPack()
		{
			IMainScreenT mainScreenT = new IMainScreenT();
			this.UnPackTo(mainScreenT);
			return mainScreenT;
		}

		// Token: 0x0602FB5E RID: 195422 RVA: 0x0067E2D7 File Offset: 0x0067C4D7
		public void UnPackTo(IMainScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FB5F RID: 195423 RVA: 0x0067E2E8 File Offset: 0x0067C4E8
		public static Offset<IMainScreen> Pack(FlatBufferBuilder builder, IMainScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMainScreen>);
			}
			return IMainScreen.CreateIMainScreen(builder, _o.Type);
		}

		// Token: 0x0401128D RID: 70285
		private Table __p;
	}
}

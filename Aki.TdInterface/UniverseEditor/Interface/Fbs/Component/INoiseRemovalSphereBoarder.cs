using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA9 RID: 23465
	public struct INoiseRemovalSphereBoarder : IFlatbufferObject
	{
		// Token: 0x1700AB88 RID: 43912
		// (get) Token: 0x06026AF1 RID: 158449 RVA: 0x0054BCCC File Offset: 0x00549ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026AF2 RID: 158450 RVA: 0x0054BCD9 File Offset: 0x00549ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026AF3 RID: 158451 RVA: 0x0054BCE0 File Offset: 0x00549EE0
		public static INoiseRemovalSphereBoarder GetRootAsINoiseRemovalSphereBoarder(ByteBuffer _bb)
		{
			return INoiseRemovalSphereBoarder.GetRootAsINoiseRemovalSphereBoarder(_bb, default(INoiseRemovalSphereBoarder));
		}

		// Token: 0x06026AF4 RID: 158452 RVA: 0x0054BCFC File Offset: 0x00549EFC
		public static INoiseRemovalSphereBoarder GetRootAsINoiseRemovalSphereBoarder(ByteBuffer _bb, INoiseRemovalSphereBoarder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026AF5 RID: 158453 RVA: 0x0054BD19 File Offset: 0x00549F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AF6 RID: 158454 RVA: 0x0054BD28 File Offset: 0x00549F28
		public INoiseRemovalSphereBoarder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB89 RID: 43913
		// (get) Token: 0x06026AF7 RID: 158455 RVA: 0x0054BD38 File Offset: 0x00549F38
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB8A RID: 43914
		// (get) Token: 0x06026AF8 RID: 158456 RVA: 0x0054BD74 File Offset: 0x00549F74
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026AF9 RID: 158457 RVA: 0x0054BDB4 File Offset: 0x00549FB4
		public static Offset<INoiseRemovalSphereBoarder> CreateINoiseRemovalSphereBoarder(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box, float Radius = 0f)
		{
			builder.StartTable(2);
			INoiseRemovalSphereBoarder.AddRadius(builder, Radius);
			INoiseRemovalSphereBoarder.AddType(builder, Type);
			return INoiseRemovalSphereBoarder.EndINoiseRemovalSphereBoarder(builder);
		}

		// Token: 0x06026AFA RID: 158458 RVA: 0x0054BDD1 File Offset: 0x00549FD1
		public static void StartINoiseRemovalSphereBoarder(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026AFB RID: 158459 RVA: 0x0054BDDA File Offset: 0x00549FDA
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026AFC RID: 158460 RVA: 0x0054BDE5 File Offset: 0x00549FE5
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x06026AFD RID: 158461 RVA: 0x0054BDF8 File Offset: 0x00549FF8
		public static Offset<INoiseRemovalSphereBoarder> EndINoiseRemovalSphereBoarder(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalSphereBoarder>(builder.EndTable());
		}

		// Token: 0x06026AFE RID: 158462 RVA: 0x0054BE08 File Offset: 0x0054A008
		public INoiseRemovalSphereBoarderT UnPack()
		{
			INoiseRemovalSphereBoarderT noiseRemovalSphereBoarderT = new INoiseRemovalSphereBoarderT();
			this.UnPackTo(noiseRemovalSphereBoarderT);
			return noiseRemovalSphereBoarderT;
		}

		// Token: 0x06026AFF RID: 158463 RVA: 0x0054BE23 File Offset: 0x0054A023
		public void UnPackTo(INoiseRemovalSphereBoarderT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
		}

		// Token: 0x06026B00 RID: 158464 RVA: 0x0054BE40 File Offset: 0x0054A040
		public static Offset<INoiseRemovalSphereBoarder> Pack(FlatBufferBuilder builder, INoiseRemovalSphereBoarderT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalSphereBoarder>);
			}
			return INoiseRemovalSphereBoarder.CreateINoiseRemovalSphereBoarder(builder, _o.Type, _o.Radius);
		}

		// Token: 0x0400F5EE RID: 62958
		private Table __p;
	}
}

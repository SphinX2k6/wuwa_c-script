using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007607 RID: 30215
	public struct IWindProtagonistParkour1 : IFlatbufferObject
	{
		// Token: 0x1700E584 RID: 58756
		// (get) Token: 0x060370A2 RID: 225442 RVA: 0x00777851 File Offset: 0x00775A51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370A3 RID: 225443 RVA: 0x0077785E File Offset: 0x00775A5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370A4 RID: 225444 RVA: 0x00777868 File Offset: 0x00775A68
		public static IWindProtagonistParkour1 GetRootAsIWindProtagonistParkour1(ByteBuffer _bb)
		{
			return IWindProtagonistParkour1.GetRootAsIWindProtagonistParkour1(_bb, default(IWindProtagonistParkour1));
		}

		// Token: 0x060370A5 RID: 225445 RVA: 0x00777884 File Offset: 0x00775A84
		public static IWindProtagonistParkour1 GetRootAsIWindProtagonistParkour1(ByteBuffer _bb, IWindProtagonistParkour1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370A6 RID: 225446 RVA: 0x007778A1 File Offset: 0x00775AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370A7 RID: 225447 RVA: 0x007778B0 File Offset: 0x00775AB0
		public IWindProtagonistParkour1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E585 RID: 58757
		// (get) Token: 0x060370A8 RID: 225448 RVA: 0x007778C0 File Offset: 0x00775AC0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060370A9 RID: 225449 RVA: 0x007778FC File Offset: 0x00775AFC
		public static Offset<IWindProtagonistParkour1> CreateIWindProtagonistParkour1(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour1.AddType(builder, Type);
			return IWindProtagonistParkour1.EndIWindProtagonistParkour1(builder);
		}

		// Token: 0x060370AA RID: 225450 RVA: 0x00777912 File Offset: 0x00775B12
		public static void StartIWindProtagonistParkour1(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370AB RID: 225451 RVA: 0x0077791B File Offset: 0x00775B1B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370AC RID: 225452 RVA: 0x00777926 File Offset: 0x00775B26
		public static Offset<IWindProtagonistParkour1> EndIWindProtagonistParkour1(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour1>(builder.EndTable());
		}

		// Token: 0x060370AD RID: 225453 RVA: 0x00777934 File Offset: 0x00775B34
		public IWindProtagonistParkour1T UnPack()
		{
			IWindProtagonistParkour1T windProtagonistParkour1T = new IWindProtagonistParkour1T();
			this.UnPackTo(windProtagonistParkour1T);
			return windProtagonistParkour1T;
		}

		// Token: 0x060370AE RID: 225454 RVA: 0x0077794F File Offset: 0x00775B4F
		public void UnPackTo(IWindProtagonistParkour1T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370AF RID: 225455 RVA: 0x00777960 File Offset: 0x00775B60
		public static Offset<IWindProtagonistParkour1> Pack(FlatBufferBuilder builder, IWindProtagonistParkour1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour1>);
			}
			return IWindProtagonistParkour1.CreateIWindProtagonistParkour1(builder, _o.Type);
		}

		// Token: 0x04012579 RID: 75129
		private Table __p;
	}
}

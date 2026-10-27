using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760D RID: 30221
	public struct IWindProtagonistParkour3 : IFlatbufferObject
	{
		// Token: 0x1700E58A RID: 58762
		// (get) Token: 0x060370C6 RID: 225478 RVA: 0x00777B41 File Offset: 0x00775D41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370C7 RID: 225479 RVA: 0x00777B4E File Offset: 0x00775D4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370C8 RID: 225480 RVA: 0x00777B58 File Offset: 0x00775D58
		public static IWindProtagonistParkour3 GetRootAsIWindProtagonistParkour3(ByteBuffer _bb)
		{
			return IWindProtagonistParkour3.GetRootAsIWindProtagonistParkour3(_bb, default(IWindProtagonistParkour3));
		}

		// Token: 0x060370C9 RID: 225481 RVA: 0x00777B74 File Offset: 0x00775D74
		public static IWindProtagonistParkour3 GetRootAsIWindProtagonistParkour3(ByteBuffer _bb, IWindProtagonistParkour3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370CA RID: 225482 RVA: 0x00777B91 File Offset: 0x00775D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370CB RID: 225483 RVA: 0x00777BA0 File Offset: 0x00775DA0
		public IWindProtagonistParkour3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E58B RID: 58763
		// (get) Token: 0x060370CC RID: 225484 RVA: 0x00777BB0 File Offset: 0x00775DB0
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

		// Token: 0x060370CD RID: 225485 RVA: 0x00777BEC File Offset: 0x00775DEC
		public static Offset<IWindProtagonistParkour3> CreateIWindProtagonistParkour3(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour3.AddType(builder, Type);
			return IWindProtagonistParkour3.EndIWindProtagonistParkour3(builder);
		}

		// Token: 0x060370CE RID: 225486 RVA: 0x00777C02 File Offset: 0x00775E02
		public static void StartIWindProtagonistParkour3(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370CF RID: 225487 RVA: 0x00777C0B File Offset: 0x00775E0B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370D0 RID: 225488 RVA: 0x00777C16 File Offset: 0x00775E16
		public static Offset<IWindProtagonistParkour3> EndIWindProtagonistParkour3(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour3>(builder.EndTable());
		}

		// Token: 0x060370D1 RID: 225489 RVA: 0x00777C24 File Offset: 0x00775E24
		public IWindProtagonistParkour3T UnPack()
		{
			IWindProtagonistParkour3T windProtagonistParkour3T = new IWindProtagonistParkour3T();
			this.UnPackTo(windProtagonistParkour3T);
			return windProtagonistParkour3T;
		}

		// Token: 0x060370D2 RID: 225490 RVA: 0x00777C3F File Offset: 0x00775E3F
		public void UnPackTo(IWindProtagonistParkour3T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370D3 RID: 225491 RVA: 0x00777C50 File Offset: 0x00775E50
		public static Offset<IWindProtagonistParkour3> Pack(FlatBufferBuilder builder, IWindProtagonistParkour3T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour3>);
			}
			return IWindProtagonistParkour3.CreateIWindProtagonistParkour3(builder, _o.Type);
		}

		// Token: 0x0401257D RID: 75133
		private Table __p;
	}
}

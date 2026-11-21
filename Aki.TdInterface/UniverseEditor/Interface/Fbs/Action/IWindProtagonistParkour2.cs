using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E18 RID: 32280
	public struct IWindProtagonistParkour2 : IFlatbufferObject
	{
		// Token: 0x1700F1C5 RID: 61893
		// (get) Token: 0x0603A559 RID: 238937 RVA: 0x007DBAC5 File Offset: 0x007D9CC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A55A RID: 238938 RVA: 0x007DBAD2 File Offset: 0x007D9CD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A55B RID: 238939 RVA: 0x007DBADC File Offset: 0x007D9CDC
		public static IWindProtagonistParkour2 GetRootAsIWindProtagonistParkour2(ByteBuffer _bb)
		{
			return IWindProtagonistParkour2.GetRootAsIWindProtagonistParkour2(_bb, default(IWindProtagonistParkour2));
		}

		// Token: 0x0603A55C RID: 238940 RVA: 0x007DBAF8 File Offset: 0x007D9CF8
		public static IWindProtagonistParkour2 GetRootAsIWindProtagonistParkour2(ByteBuffer _bb, IWindProtagonistParkour2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A55D RID: 238941 RVA: 0x007DBB15 File Offset: 0x007D9D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A55E RID: 238942 RVA: 0x007DBB24 File Offset: 0x007D9D24
		public IWindProtagonistParkour2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1C6 RID: 61894
		// (get) Token: 0x0603A55F RID: 238943 RVA: 0x007DBB34 File Offset: 0x007D9D34
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

		// Token: 0x0603A560 RID: 238944 RVA: 0x007DBB70 File Offset: 0x007D9D70
		public static Offset<IWindProtagonistParkour2> CreateIWindProtagonistParkour2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour2.AddType(builder, Type);
			return IWindProtagonistParkour2.EndIWindProtagonistParkour2(builder);
		}

		// Token: 0x0603A561 RID: 238945 RVA: 0x007DBB86 File Offset: 0x007D9D86
		public static void StartIWindProtagonistParkour2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A562 RID: 238946 RVA: 0x007DBB8F File Offset: 0x007D9D8F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A563 RID: 238947 RVA: 0x007DBB9A File Offset: 0x007D9D9A
		public static Offset<IWindProtagonistParkour2> EndIWindProtagonistParkour2(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour2>(builder.EndTable());
		}

		// Token: 0x0603A564 RID: 238948 RVA: 0x007DBBA8 File Offset: 0x007D9DA8
		public IWindProtagonistParkour2T UnPack()
		{
			IWindProtagonistParkour2T windProtagonistParkour2T = new IWindProtagonistParkour2T();
			this.UnPackTo(windProtagonistParkour2T);
			return windProtagonistParkour2T;
		}

		// Token: 0x0603A565 RID: 238949 RVA: 0x007DBBC3 File Offset: 0x007D9DC3
		public void UnPackTo(IWindProtagonistParkour2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A566 RID: 238950 RVA: 0x007DBBD4 File Offset: 0x007D9DD4
		public static Offset<IWindProtagonistParkour2> Pack(FlatBufferBuilder builder, IWindProtagonistParkour2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour2>);
			}
			return IWindProtagonistParkour2.CreateIWindProtagonistParkour2(builder, _o.Type);
		}

		// Token: 0x040135C5 RID: 79301
		private Table __p;
	}
}

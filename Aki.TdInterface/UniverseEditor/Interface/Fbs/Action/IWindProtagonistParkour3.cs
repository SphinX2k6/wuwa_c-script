using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1B RID: 32283
	public struct IWindProtagonistParkour3 : IFlatbufferObject
	{
		// Token: 0x1700F1C8 RID: 61896
		// (get) Token: 0x0603A56B RID: 238955 RVA: 0x007DBC3D File Offset: 0x007D9E3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A56C RID: 238956 RVA: 0x007DBC4A File Offset: 0x007D9E4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A56D RID: 238957 RVA: 0x007DBC54 File Offset: 0x007D9E54
		public static IWindProtagonistParkour3 GetRootAsIWindProtagonistParkour3(ByteBuffer _bb)
		{
			return IWindProtagonistParkour3.GetRootAsIWindProtagonistParkour3(_bb, default(IWindProtagonistParkour3));
		}

		// Token: 0x0603A56E RID: 238958 RVA: 0x007DBC70 File Offset: 0x007D9E70
		public static IWindProtagonistParkour3 GetRootAsIWindProtagonistParkour3(ByteBuffer _bb, IWindProtagonistParkour3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A56F RID: 238959 RVA: 0x007DBC8D File Offset: 0x007D9E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A570 RID: 238960 RVA: 0x007DBC9C File Offset: 0x007D9E9C
		public IWindProtagonistParkour3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1C9 RID: 61897
		// (get) Token: 0x0603A571 RID: 238961 RVA: 0x007DBCAC File Offset: 0x007D9EAC
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

		// Token: 0x0603A572 RID: 238962 RVA: 0x007DBCE8 File Offset: 0x007D9EE8
		public static Offset<IWindProtagonistParkour3> CreateIWindProtagonistParkour3(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour3.AddType(builder, Type);
			return IWindProtagonistParkour3.EndIWindProtagonistParkour3(builder);
		}

		// Token: 0x0603A573 RID: 238963 RVA: 0x007DBCFE File Offset: 0x007D9EFE
		public static void StartIWindProtagonistParkour3(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A574 RID: 238964 RVA: 0x007DBD07 File Offset: 0x007D9F07
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A575 RID: 238965 RVA: 0x007DBD12 File Offset: 0x007D9F12
		public static Offset<IWindProtagonistParkour3> EndIWindProtagonistParkour3(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour3>(builder.EndTable());
		}

		// Token: 0x0603A576 RID: 238966 RVA: 0x007DBD20 File Offset: 0x007D9F20
		public IWindProtagonistParkour3T UnPack()
		{
			IWindProtagonistParkour3T windProtagonistParkour3T = new IWindProtagonistParkour3T();
			this.UnPackTo(windProtagonistParkour3T);
			return windProtagonistParkour3T;
		}

		// Token: 0x0603A577 RID: 238967 RVA: 0x007DBD3B File Offset: 0x007D9F3B
		public void UnPackTo(IWindProtagonistParkour3T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A578 RID: 238968 RVA: 0x007DBD4C File Offset: 0x007D9F4C
		public static Offset<IWindProtagonistParkour3> Pack(FlatBufferBuilder builder, IWindProtagonistParkour3T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour3>);
			}
			return IWindProtagonistParkour3.CreateIWindProtagonistParkour3(builder, _o.Type);
		}

		// Token: 0x040135C7 RID: 79303
		private Table __p;
	}
}

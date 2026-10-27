using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688B RID: 26763
	public struct IGetUp : IFlatbufferObject
	{
		// Token: 0x1700C6BA RID: 50874
		// (get) Token: 0x0602EAC6 RID: 191174 RVA: 0x0065D342 File Offset: 0x0065B542
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EAC7 RID: 191175 RVA: 0x0065D34F File Offset: 0x0065B54F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EAC8 RID: 191176 RVA: 0x0065D358 File Offset: 0x0065B558
		public static IGetUp GetRootAsIGetUp(ByteBuffer _bb)
		{
			return IGetUp.GetRootAsIGetUp(_bb, default(IGetUp));
		}

		// Token: 0x0602EAC9 RID: 191177 RVA: 0x0065D374 File Offset: 0x0065B574
		public static IGetUp GetRootAsIGetUp(ByteBuffer _bb, IGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EACA RID: 191178 RVA: 0x0065D391 File Offset: 0x0065B591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EACB RID: 191179 RVA: 0x0065D3A0 File Offset: 0x0065B5A0
		public IGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6BB RID: 50875
		// (get) Token: 0x0602EACC RID: 191180 RVA: 0x0065D3B0 File Offset: 0x0065B5B0
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

		// Token: 0x0602EACD RID: 191181 RVA: 0x0065D3EC File Offset: 0x0065B5EC
		public static Offset<IGetUp> CreateIGetUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGetUp.AddType(builder, Type);
			return IGetUp.EndIGetUp(builder);
		}

		// Token: 0x0602EACE RID: 191182 RVA: 0x0065D402 File Offset: 0x0065B602
		public static void StartIGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EACF RID: 191183 RVA: 0x0065D40B File Offset: 0x0065B60B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EAD0 RID: 191184 RVA: 0x0065D416 File Offset: 0x0065B616
		public static Offset<IGetUp> EndIGetUp(FlatBufferBuilder builder)
		{
			return new Offset<IGetUp>(builder.EndTable());
		}

		// Token: 0x0602EAD1 RID: 191185 RVA: 0x0065D424 File Offset: 0x0065B624
		public IGetUpT UnPack()
		{
			IGetUpT getUpT = new IGetUpT();
			this.UnPackTo(getUpT);
			return getUpT;
		}

		// Token: 0x0602EAD2 RID: 191186 RVA: 0x0065D43F File Offset: 0x0065B63F
		public void UnPackTo(IGetUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EAD3 RID: 191187 RVA: 0x0065D450 File Offset: 0x0065B650
		public static Offset<IGetUp> Pack(FlatBufferBuilder builder, IGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetUp>);
			}
			return IGetUp.CreateIGetUp(builder, _o.Type);
		}

		// Token: 0x04010FDE RID: 69598
		private Table __p;
	}
}

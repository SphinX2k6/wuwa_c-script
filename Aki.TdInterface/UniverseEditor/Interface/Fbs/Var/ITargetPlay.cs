using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE4 RID: 15076
	public struct ITargetPlay : IFlatbufferObject
	{
		// Token: 0x1700676D RID: 26477
		// (get) Token: 0x060148A2 RID: 84130 RVA: 0x002FDDAE File Offset: 0x002FBFAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060148A3 RID: 84131 RVA: 0x002FDDBB File Offset: 0x002FBFBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060148A4 RID: 84132 RVA: 0x002FDDC4 File Offset: 0x002FBFC4
		public static ITargetPlay GetRootAsITargetPlay(ByteBuffer _bb)
		{
			return ITargetPlay.GetRootAsITargetPlay(_bb, default(ITargetPlay));
		}

		// Token: 0x060148A5 RID: 84133 RVA: 0x002FDDE0 File Offset: 0x002FBFE0
		public static ITargetPlay GetRootAsITargetPlay(ByteBuffer _bb, ITargetPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060148A6 RID: 84134 RVA: 0x002FDDFD File Offset: 0x002FBFFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060148A7 RID: 84135 RVA: 0x002FDE0C File Offset: 0x002FC00C
		public ITargetPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700676E RID: 26478
		// (get) Token: 0x060148A8 RID: 84136 RVA: 0x002FDE1C File Offset: 0x002FC01C
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060148A9 RID: 84137 RVA: 0x002FDE58 File Offset: 0x002FC058
		public static Offset<ITargetPlay> CreateITargetPlay(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetPlay.AddType(builder, Type);
			return ITargetPlay.EndITargetPlay(builder);
		}

		// Token: 0x060148AA RID: 84138 RVA: 0x002FDE6E File Offset: 0x002FC06E
		public static void StartITargetPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060148AB RID: 84139 RVA: 0x002FDE77 File Offset: 0x002FC077
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060148AC RID: 84140 RVA: 0x002FDE82 File Offset: 0x002FC082
		public static Offset<ITargetPlay> EndITargetPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITargetPlay>(builder.EndTable());
		}

		// Token: 0x060148AD RID: 84141 RVA: 0x002FDE90 File Offset: 0x002FC090
		public ITargetPlayT UnPack()
		{
			ITargetPlayT targetPlayT = new ITargetPlayT();
			this.UnPackTo(targetPlayT);
			return targetPlayT;
		}

		// Token: 0x060148AE RID: 84142 RVA: 0x002FDEAB File Offset: 0x002FC0AB
		public void UnPackTo(ITargetPlayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060148AF RID: 84143 RVA: 0x002FDEBC File Offset: 0x002FC0BC
		public static Offset<ITargetPlay> Pack(FlatBufferBuilder builder, ITargetPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetPlay>);
			}
			return ITargetPlay.CreateITargetPlay(builder, _o.Type);
		}

		// Token: 0x0400AFA5 RID: 44965
		private Table __p;
	}
}

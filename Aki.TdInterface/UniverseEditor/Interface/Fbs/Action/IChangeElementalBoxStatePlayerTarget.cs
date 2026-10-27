using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D5 RID: 25301
	public struct IChangeElementalBoxStatePlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700BCDD RID: 48349
		// (get) Token: 0x0602BBBF RID: 179135 RVA: 0x0060494C File Offset: 0x00602B4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBC0 RID: 179136 RVA: 0x00604959 File Offset: 0x00602B59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBC1 RID: 179137 RVA: 0x00604960 File Offset: 0x00602B60
		public static IChangeElementalBoxStatePlayerTarget GetRootAsIChangeElementalBoxStatePlayerTarget(ByteBuffer _bb)
		{
			return IChangeElementalBoxStatePlayerTarget.GetRootAsIChangeElementalBoxStatePlayerTarget(_bb, default(IChangeElementalBoxStatePlayerTarget));
		}

		// Token: 0x0602BBC2 RID: 179138 RVA: 0x0060497C File Offset: 0x00602B7C
		public static IChangeElementalBoxStatePlayerTarget GetRootAsIChangeElementalBoxStatePlayerTarget(ByteBuffer _bb, IChangeElementalBoxStatePlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBC3 RID: 179139 RVA: 0x00604999 File Offset: 0x00602B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBC4 RID: 179140 RVA: 0x006049A8 File Offset: 0x00602BA8
		public IChangeElementalBoxStatePlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCDE RID: 48350
		// (get) Token: 0x0602BBC5 RID: 179141 RVA: 0x006049B8 File Offset: 0x00602BB8
		public EChangeElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return (EChangeElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BBC6 RID: 179142 RVA: 0x006049F4 File Offset: 0x00602BF4
		public static Offset<IChangeElementalBoxStatePlayerTarget> CreateIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IChangeElementalBoxStatePlayerTarget.AddType(builder, Type);
			return IChangeElementalBoxStatePlayerTarget.EndIChangeElementalBoxStatePlayerTarget(builder);
		}

		// Token: 0x0602BBC7 RID: 179143 RVA: 0x00604A0A File Offset: 0x00602C0A
		public static void StartIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BBC8 RID: 179144 RVA: 0x00604A13 File Offset: 0x00602C13
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BBC9 RID: 179145 RVA: 0x00604A1E File Offset: 0x00602C1E
		public static Offset<IChangeElementalBoxStatePlayerTarget> EndIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStatePlayerTarget>(builder.EndTable());
		}

		// Token: 0x0602BBCA RID: 179146 RVA: 0x00604A2C File Offset: 0x00602C2C
		public IChangeElementalBoxStatePlayerTargetT UnPack()
		{
			IChangeElementalBoxStatePlayerTargetT changeElementalBoxStatePlayerTargetT = new IChangeElementalBoxStatePlayerTargetT();
			this.UnPackTo(changeElementalBoxStatePlayerTargetT);
			return changeElementalBoxStatePlayerTargetT;
		}

		// Token: 0x0602BBCB RID: 179147 RVA: 0x00604A47 File Offset: 0x00602C47
		public void UnPackTo(IChangeElementalBoxStatePlayerTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BBCC RID: 179148 RVA: 0x00604A58 File Offset: 0x00602C58
		public static Offset<IChangeElementalBoxStatePlayerTarget> Pack(FlatBufferBuilder builder, IChangeElementalBoxStatePlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStatePlayerTarget>);
			}
			return IChangeElementalBoxStatePlayerTarget.CreateIChangeElementalBoxStatePlayerTarget(builder, _o.Type);
		}

		// Token: 0x0401087D RID: 67709
		private Table __p;
	}
}

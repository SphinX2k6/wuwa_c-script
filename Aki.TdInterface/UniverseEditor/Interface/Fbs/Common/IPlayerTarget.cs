using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647C RID: 25724
	public struct IPlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700BDCD RID: 48589
		// (get) Token: 0x0602BB5A RID: 179034 RVA: 0x005F28A9 File Offset: 0x005F0AA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB5B RID: 179035 RVA: 0x005F28B6 File Offset: 0x005F0AB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB5C RID: 179036 RVA: 0x005F28C0 File Offset: 0x005F0AC0
		public static IPlayerTarget GetRootAsIPlayerTarget(ByteBuffer _bb)
		{
			return IPlayerTarget.GetRootAsIPlayerTarget(_bb, default(IPlayerTarget));
		}

		// Token: 0x0602BB5D RID: 179037 RVA: 0x005F28DC File Offset: 0x005F0ADC
		public static IPlayerTarget GetRootAsIPlayerTarget(ByteBuffer _bb, IPlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB5E RID: 179038 RVA: 0x005F28F9 File Offset: 0x005F0AF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB5F RID: 179039 RVA: 0x005F2908 File Offset: 0x005F0B08
		public IPlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDCE RID: 48590
		// (get) Token: 0x0602BB60 RID: 179040 RVA: 0x005F2918 File Offset: 0x005F0B18
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BB61 RID: 179041 RVA: 0x005F2954 File Offset: 0x005F0B54
		public static Offset<IPlayerTarget> CreateIPlayerTarget(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			IPlayerTarget.AddType(builder, Type);
			return IPlayerTarget.EndIPlayerTarget(builder);
		}

		// Token: 0x0602BB62 RID: 179042 RVA: 0x005F296A File Offset: 0x005F0B6A
		public static void StartIPlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BB63 RID: 179043 RVA: 0x005F2973 File Offset: 0x005F0B73
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB64 RID: 179044 RVA: 0x005F297E File Offset: 0x005F0B7E
		public static Offset<IPlayerTarget> EndIPlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerTarget>(builder.EndTable());
		}

		// Token: 0x0602BB65 RID: 179045 RVA: 0x005F298C File Offset: 0x005F0B8C
		public IPlayerTargetT UnPack()
		{
			IPlayerTargetT playerTargetT = new IPlayerTargetT();
			this.UnPackTo(playerTargetT);
			return playerTargetT;
		}

		// Token: 0x0602BB66 RID: 179046 RVA: 0x005F29A7 File Offset: 0x005F0BA7
		public void UnPackTo(IPlayerTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BB67 RID: 179047 RVA: 0x005F29B8 File Offset: 0x005F0BB8
		public static Offset<IPlayerTarget> Pack(FlatBufferBuilder builder, IPlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerTarget>);
			}
			return IPlayerTarget.CreateIPlayerTarget(builder, _o.Type);
		}

		// Token: 0x0401059A RID: 66970
		private Table __p;
	}
}

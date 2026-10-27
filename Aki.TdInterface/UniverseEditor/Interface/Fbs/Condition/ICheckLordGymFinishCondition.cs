using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC6 RID: 19142
	public struct ICheckLordGymFinishCondition : IFlatbufferObject
	{
		// Token: 0x17008AC7 RID: 35527
		// (get) Token: 0x0601E0E0 RID: 123104 RVA: 0x0043793C File Offset: 0x00435B3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0E1 RID: 123105 RVA: 0x00437949 File Offset: 0x00435B49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0E2 RID: 123106 RVA: 0x00437950 File Offset: 0x00435B50
		public static ICheckLordGymFinishCondition GetRootAsICheckLordGymFinishCondition(ByteBuffer _bb)
		{
			return ICheckLordGymFinishCondition.GetRootAsICheckLordGymFinishCondition(_bb, default(ICheckLordGymFinishCondition));
		}

		// Token: 0x0601E0E3 RID: 123107 RVA: 0x0043796C File Offset: 0x00435B6C
		public static ICheckLordGymFinishCondition GetRootAsICheckLordGymFinishCondition(ByteBuffer _bb, ICheckLordGymFinishCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0E4 RID: 123108 RVA: 0x00437989 File Offset: 0x00435B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0E5 RID: 123109 RVA: 0x00437998 File Offset: 0x00435B98
		public ICheckLordGymFinishCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AC8 RID: 35528
		// (get) Token: 0x0601E0E6 RID: 123110 RVA: 0x004379A8 File Offset: 0x00435BA8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AC9 RID: 35529
		// (get) Token: 0x0601E0E7 RID: 123111 RVA: 0x004379E4 File Offset: 0x00435BE4
		public int LordGymId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E0E8 RID: 123112 RVA: 0x00437A20 File Offset: 0x00435C20
		public static Offset<ICheckLordGymFinishCondition> CreateICheckLordGymFinishCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LordGymId = 0)
		{
			builder.StartTable(2);
			ICheckLordGymFinishCondition.AddLordGymId(builder, LordGymId);
			ICheckLordGymFinishCondition.AddType(builder, Type);
			return ICheckLordGymFinishCondition.EndICheckLordGymFinishCondition(builder);
		}

		// Token: 0x0601E0E9 RID: 123113 RVA: 0x00437A3D File Offset: 0x00435C3D
		public static void StartICheckLordGymFinishCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E0EA RID: 123114 RVA: 0x00437A46 File Offset: 0x00435C46
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E0EB RID: 123115 RVA: 0x00437A51 File Offset: 0x00435C51
		public static void AddLordGymId(FlatBufferBuilder builder, int lordGymId)
		{
			builder.AddInt(1, lordGymId, 0);
		}

		// Token: 0x0601E0EC RID: 123116 RVA: 0x00437A5C File Offset: 0x00435C5C
		public static Offset<ICheckLordGymFinishCondition> EndICheckLordGymFinishCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLordGymFinishCondition>(builder.EndTable());
		}

		// Token: 0x0601E0ED RID: 123117 RVA: 0x00437A6C File Offset: 0x00435C6C
		public ICheckLordGymFinishConditionT UnPack()
		{
			ICheckLordGymFinishConditionT checkLordGymFinishConditionT = new ICheckLordGymFinishConditionT();
			this.UnPackTo(checkLordGymFinishConditionT);
			return checkLordGymFinishConditionT;
		}

		// Token: 0x0601E0EE RID: 123118 RVA: 0x00437A87 File Offset: 0x00435C87
		public void UnPackTo(ICheckLordGymFinishConditionT _o)
		{
			_o.Type = this.Type;
			_o.LordGymId = this.LordGymId;
		}

		// Token: 0x0601E0EF RID: 123119 RVA: 0x00437AA4 File Offset: 0x00435CA4
		public static Offset<ICheckLordGymFinishCondition> Pack(FlatBufferBuilder builder, ICheckLordGymFinishConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLordGymFinishCondition>);
			}
			return ICheckLordGymFinishCondition.CreateICheckLordGymFinishCondition(builder, _o.Type, _o.LordGymId);
		}

		// Token: 0x0400D34D RID: 54093
		private Table __p;
	}
}

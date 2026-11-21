using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004484 RID: 17540
	public struct IQuestScheduleType : IFlatbufferObject
	{
		// Token: 0x170079CF RID: 31183
		// (get) Token: 0x060193AF RID: 103343 RVA: 0x00399901 File Offset: 0x00397B01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060193B0 RID: 103344 RVA: 0x0039990E File Offset: 0x00397B0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060193B1 RID: 103345 RVA: 0x00399918 File Offset: 0x00397B18
		public static IQuestScheduleType GetRootAsIQuestScheduleType(ByteBuffer _bb)
		{
			return IQuestScheduleType.GetRootAsIQuestScheduleType(_bb, default(IQuestScheduleType));
		}

		// Token: 0x060193B2 RID: 103346 RVA: 0x00399934 File Offset: 0x00397B34
		public static IQuestScheduleType GetRootAsIQuestScheduleType(ByteBuffer _bb, IQuestScheduleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193B3 RID: 103347 RVA: 0x00399951 File Offset: 0x00397B51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193B4 RID: 103348 RVA: 0x00399960 File Offset: 0x00397B60
		public IQuestScheduleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079D0 RID: 31184
		// (get) Token: 0x060193B5 RID: 103349 RVA: 0x00399970 File Offset: 0x00397B70
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060193B6 RID: 103350 RVA: 0x003999AC File Offset: 0x00397BAC
		public static Offset<IQuestScheduleType> CreateIQuestScheduleType(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleType.AddType(builder, Type);
			return IQuestScheduleType.EndIQuestScheduleType(builder);
		}

		// Token: 0x060193B7 RID: 103351 RVA: 0x003999C2 File Offset: 0x00397BC2
		public static void StartIQuestScheduleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060193B8 RID: 103352 RVA: 0x003999CB File Offset: 0x00397BCB
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060193B9 RID: 103353 RVA: 0x003999D6 File Offset: 0x00397BD6
		public static Offset<IQuestScheduleType> EndIQuestScheduleType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleType>(builder.EndTable());
		}

		// Token: 0x060193BA RID: 103354 RVA: 0x003999E4 File Offset: 0x00397BE4
		public IQuestScheduleTypeT UnPack()
		{
			IQuestScheduleTypeT questScheduleTypeT = new IQuestScheduleTypeT();
			this.UnPackTo(questScheduleTypeT);
			return questScheduleTypeT;
		}

		// Token: 0x060193BB RID: 103355 RVA: 0x003999FF File Offset: 0x00397BFF
		public void UnPackTo(IQuestScheduleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060193BC RID: 103356 RVA: 0x00399A10 File Offset: 0x00397C10
		public static Offset<IQuestScheduleType> Pack(FlatBufferBuilder builder, IQuestScheduleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleType>);
			}
			return IQuestScheduleType.CreateIQuestScheduleType(builder, _o.Type);
		}

		// Token: 0x0400C561 RID: 50529
		private Table __p;
	}
}

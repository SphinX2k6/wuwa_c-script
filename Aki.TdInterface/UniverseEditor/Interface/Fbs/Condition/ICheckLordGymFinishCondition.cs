using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F95 RID: 20373
	public struct ICheckLordGymFinishCondition : IFlatbufferObject
	{
		// Token: 0x170091B4 RID: 37300
		// (get) Token: 0x0601FBC9 RID: 129993 RVA: 0x0046915C File Offset: 0x0046735C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBCA RID: 129994 RVA: 0x00469169 File Offset: 0x00467369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBCB RID: 129995 RVA: 0x00469170 File Offset: 0x00467370
		public static ICheckLordGymFinishCondition GetRootAsICheckLordGymFinishCondition(ByteBuffer _bb)
		{
			return ICheckLordGymFinishCondition.GetRootAsICheckLordGymFinishCondition(_bb, default(ICheckLordGymFinishCondition));
		}

		// Token: 0x0601FBCC RID: 129996 RVA: 0x0046918C File Offset: 0x0046738C
		public static ICheckLordGymFinishCondition GetRootAsICheckLordGymFinishCondition(ByteBuffer _bb, ICheckLordGymFinishCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBCD RID: 129997 RVA: 0x004691A9 File Offset: 0x004673A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBCE RID: 129998 RVA: 0x004691B8 File Offset: 0x004673B8
		public ICheckLordGymFinishCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091B5 RID: 37301
		// (get) Token: 0x0601FBCF RID: 129999 RVA: 0x004691C8 File Offset: 0x004673C8
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

		// Token: 0x170091B6 RID: 37302
		// (get) Token: 0x0601FBD0 RID: 130000 RVA: 0x00469204 File Offset: 0x00467404
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

		// Token: 0x0601FBD1 RID: 130001 RVA: 0x00469240 File Offset: 0x00467440
		public static Offset<ICheckLordGymFinishCondition> CreateICheckLordGymFinishCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LordGymId = 0)
		{
			builder.StartTable(2);
			ICheckLordGymFinishCondition.AddLordGymId(builder, LordGymId);
			ICheckLordGymFinishCondition.AddType(builder, Type);
			return ICheckLordGymFinishCondition.EndICheckLordGymFinishCondition(builder);
		}

		// Token: 0x0601FBD2 RID: 130002 RVA: 0x0046925D File Offset: 0x0046745D
		public static void StartICheckLordGymFinishCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FBD3 RID: 130003 RVA: 0x00469266 File Offset: 0x00467466
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBD4 RID: 130004 RVA: 0x00469271 File Offset: 0x00467471
		public static void AddLordGymId(FlatBufferBuilder builder, int lordGymId)
		{
			builder.AddInt(1, lordGymId, 0);
		}

		// Token: 0x0601FBD5 RID: 130005 RVA: 0x0046927C File Offset: 0x0046747C
		public static Offset<ICheckLordGymFinishCondition> EndICheckLordGymFinishCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLordGymFinishCondition>(builder.EndTable());
		}

		// Token: 0x0601FBD6 RID: 130006 RVA: 0x0046928C File Offset: 0x0046748C
		public ICheckLordGymFinishConditionT UnPack()
		{
			ICheckLordGymFinishConditionT checkLordGymFinishConditionT = new ICheckLordGymFinishConditionT();
			this.UnPackTo(checkLordGymFinishConditionT);
			return checkLordGymFinishConditionT;
		}

		// Token: 0x0601FBD7 RID: 130007 RVA: 0x004692A7 File Offset: 0x004674A7
		public void UnPackTo(ICheckLordGymFinishConditionT _o)
		{
			_o.Type = this.Type;
			_o.LordGymId = this.LordGymId;
		}

		// Token: 0x0601FBD8 RID: 130008 RVA: 0x004692C4 File Offset: 0x004674C4
		public static Offset<ICheckLordGymFinishCondition> Pack(FlatBufferBuilder builder, ICheckLordGymFinishConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLordGymFinishCondition>);
			}
			return ICheckLordGymFinishCondition.CreateICheckLordGymFinishCondition(builder, _o.Type, _o.LordGymId);
		}

		// Token: 0x0400DE32 RID: 56882
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603B RID: 24635
	public struct ITargetGearGroupFailureCondition : IFlatbufferObject
	{
		// Token: 0x1700B6E1 RID: 46817
		// (get) Token: 0x06029966 RID: 170342 RVA: 0x005AD950 File Offset: 0x005ABB50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029967 RID: 170343 RVA: 0x005AD95D File Offset: 0x005ABB5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029968 RID: 170344 RVA: 0x005AD964 File Offset: 0x005ABB64
		public static ITargetGearGroupFailureCondition GetRootAsITargetGearGroupFailureCondition(ByteBuffer _bb)
		{
			return ITargetGearGroupFailureCondition.GetRootAsITargetGearGroupFailureCondition(_bb, default(ITargetGearGroupFailureCondition));
		}

		// Token: 0x06029969 RID: 170345 RVA: 0x005AD980 File Offset: 0x005ABB80
		public static ITargetGearGroupFailureCondition GetRootAsITargetGearGroupFailureCondition(ByteBuffer _bb, ITargetGearGroupFailureCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602996A RID: 170346 RVA: 0x005AD99D File Offset: 0x005ABB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602996B RID: 170347 RVA: 0x005AD9AC File Offset: 0x005ABBAC
		public ITargetGearGroupFailureCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6E2 RID: 46818
		// (get) Token: 0x0602996C RID: 170348 RVA: 0x005AD9BC File Offset: 0x005ABBBC
		public ETargetGearGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return (ETargetGearGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602996D RID: 170349 RVA: 0x005AD9F8 File Offset: 0x005ABBF8
		public static Offset<ITargetGearGroupFailureCondition> CreateITargetGearGroupFailureCondition(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState)
		{
			builder.StartTable(1);
			ITargetGearGroupFailureCondition.AddType(builder, Type);
			return ITargetGearGroupFailureCondition.EndITargetGearGroupFailureCondition(builder);
		}

		// Token: 0x0602996E RID: 170350 RVA: 0x005ADA0E File Offset: 0x005ABC0E
		public static void StartITargetGearGroupFailureCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602996F RID: 170351 RVA: 0x005ADA17 File Offset: 0x005ABC17
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029970 RID: 170352 RVA: 0x005ADA22 File Offset: 0x005ABC22
		public static Offset<ITargetGearGroupFailureCondition> EndITargetGearGroupFailureCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupFailureCondition>(builder.EndTable());
		}

		// Token: 0x06029971 RID: 170353 RVA: 0x005ADA30 File Offset: 0x005ABC30
		public ITargetGearGroupFailureConditionT UnPack()
		{
			ITargetGearGroupFailureConditionT targetGearGroupFailureConditionT = new ITargetGearGroupFailureConditionT();
			this.UnPackTo(targetGearGroupFailureConditionT);
			return targetGearGroupFailureConditionT;
		}

		// Token: 0x06029972 RID: 170354 RVA: 0x005ADA4B File Offset: 0x005ABC4B
		public void UnPackTo(ITargetGearGroupFailureConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029973 RID: 170355 RVA: 0x005ADA5C File Offset: 0x005ABC5C
		public static Offset<ITargetGearGroupFailureCondition> Pack(FlatBufferBuilder builder, ITargetGearGroupFailureConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupFailureCondition>);
			}
			return ITargetGearGroupFailureCondition.CreateITargetGearGroupFailureCondition(builder, _o.Type);
		}

		// Token: 0x0400FD8D RID: 64909
		private Table __p;
	}
}

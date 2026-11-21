using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DFF RID: 15871
	public struct IBvbAdjustPosPreference : IFlatbufferObject
	{
		// Token: 0x17006B36 RID: 27446
		// (get) Token: 0x0601552D RID: 87341 RVA: 0x00314F3A File Offset: 0x0031313A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00314F47 File Offset: 0x00313147
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601552F RID: 87343 RVA: 0x00314F50 File Offset: 0x00313150
		public static IBvbAdjustPosPreference GetRootAsIBvbAdjustPosPreference(ByteBuffer _bb)
		{
			return IBvbAdjustPosPreference.GetRootAsIBvbAdjustPosPreference(_bb, default(IBvbAdjustPosPreference));
		}

		// Token: 0x06015530 RID: 87344 RVA: 0x00314F6C File Offset: 0x0031316C
		public static IBvbAdjustPosPreference GetRootAsIBvbAdjustPosPreference(ByteBuffer _bb, IBvbAdjustPosPreference obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015531 RID: 87345 RVA: 0x00314F89 File Offset: 0x00313189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015532 RID: 87346 RVA: 0x00314F98 File Offset: 0x00313198
		public IBvbAdjustPosPreference __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B37 RID: 27447
		// (get) Token: 0x06015533 RID: 87347 RVA: 0x00314FA8 File Offset: 0x003131A8
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015534 RID: 87348 RVA: 0x00314FE4 File Offset: 0x003131E4
		public static Offset<IBvbAdjustPosPreference> CreateIBvbAdjustPosPreference(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbAdjustPosPreference.AddType(builder, Type);
			return IBvbAdjustPosPreference.EndIBvbAdjustPosPreference(builder);
		}

		// Token: 0x06015535 RID: 87349 RVA: 0x00314FFA File Offset: 0x003131FA
		public static void StartIBvbAdjustPosPreference(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015536 RID: 87350 RVA: 0x00315003 File Offset: 0x00313203
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x0031500E File Offset: 0x0031320E
		public static Offset<IBvbAdjustPosPreference> EndIBvbAdjustPosPreference(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAdjustPosPreference>(builder.EndTable());
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x0031501C File Offset: 0x0031321C
		public IBvbAdjustPosPreferenceT UnPack()
		{
			IBvbAdjustPosPreferenceT bvbAdjustPosPreferenceT = new IBvbAdjustPosPreferenceT();
			this.UnPackTo(bvbAdjustPosPreferenceT);
			return bvbAdjustPosPreferenceT;
		}

		// Token: 0x06015539 RID: 87353 RVA: 0x00315037 File Offset: 0x00313237
		public void UnPackTo(IBvbAdjustPosPreferenceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00315048 File Offset: 0x00313248
		public static Offset<IBvbAdjustPosPreference> Pack(FlatBufferBuilder builder, IBvbAdjustPosPreferenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAdjustPosPreference>);
			}
			return IBvbAdjustPosPreference.CreateIBvbAdjustPosPreference(builder, _o.Type);
		}

		// Token: 0x0400B7BE RID: 47038
		private Table __p;
	}
}

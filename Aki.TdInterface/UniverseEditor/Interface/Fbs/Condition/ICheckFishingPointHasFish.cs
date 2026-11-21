using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EEA RID: 20202
	public struct ICheckFishingPointHasFish : IFlatbufferObject
	{
		// Token: 0x1700903F RID: 36927
		// (get) Token: 0x0601F5CE RID: 128462 RVA: 0x0045E98C File Offset: 0x0045CB8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F5CF RID: 128463 RVA: 0x0045E999 File Offset: 0x0045CB99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F5D0 RID: 128464 RVA: 0x0045E9A0 File Offset: 0x0045CBA0
		public static ICheckFishingPointHasFish GetRootAsICheckFishingPointHasFish(ByteBuffer _bb)
		{
			return ICheckFishingPointHasFish.GetRootAsICheckFishingPointHasFish(_bb, default(ICheckFishingPointHasFish));
		}

		// Token: 0x0601F5D1 RID: 128465 RVA: 0x0045E9BC File Offset: 0x0045CBBC
		public static ICheckFishingPointHasFish GetRootAsICheckFishingPointHasFish(ByteBuffer _bb, ICheckFishingPointHasFish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F5D2 RID: 128466 RVA: 0x0045E9D9 File Offset: 0x0045CBD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F5D3 RID: 128467 RVA: 0x0045E9E8 File Offset: 0x0045CBE8
		public ICheckFishingPointHasFish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009040 RID: 36928
		// (get) Token: 0x0601F5D4 RID: 128468 RVA: 0x0045E9F8 File Offset: 0x0045CBF8
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

		// Token: 0x17009041 RID: 36929
		// (get) Token: 0x0601F5D5 RID: 128469 RVA: 0x0045EA34 File Offset: 0x0045CC34
		public bool HasFish
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F5D6 RID: 128470 RVA: 0x0045EA73 File Offset: 0x0045CC73
		public static Offset<ICheckFishingPointHasFish> CreateICheckFishingPointHasFish(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool HasFish = false)
		{
			builder.StartTable(2);
			ICheckFishingPointHasFish.AddHasFish(builder, HasFish);
			ICheckFishingPointHasFish.AddType(builder, Type);
			return ICheckFishingPointHasFish.EndICheckFishingPointHasFish(builder);
		}

		// Token: 0x0601F5D7 RID: 128471 RVA: 0x0045EA90 File Offset: 0x0045CC90
		public static void StartICheckFishingPointHasFish(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F5D8 RID: 128472 RVA: 0x0045EA99 File Offset: 0x0045CC99
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F5D9 RID: 128473 RVA: 0x0045EAA4 File Offset: 0x0045CCA4
		public static void AddHasFish(FlatBufferBuilder builder, bool hasFish)
		{
			builder.AddBool(1, hasFish, false);
		}

		// Token: 0x0601F5DA RID: 128474 RVA: 0x0045EAAF File Offset: 0x0045CCAF
		public static Offset<ICheckFishingPointHasFish> EndICheckFishingPointHasFish(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFishingPointHasFish>(builder.EndTable());
		}

		// Token: 0x0601F5DB RID: 128475 RVA: 0x0045EABC File Offset: 0x0045CCBC
		public ICheckFishingPointHasFishT UnPack()
		{
			ICheckFishingPointHasFishT checkFishingPointHasFishT = new ICheckFishingPointHasFishT();
			this.UnPackTo(checkFishingPointHasFishT);
			return checkFishingPointHasFishT;
		}

		// Token: 0x0601F5DC RID: 128476 RVA: 0x0045EAD7 File Offset: 0x0045CCD7
		public void UnPackTo(ICheckFishingPointHasFishT _o)
		{
			_o.Type = this.Type;
			_o.HasFish = this.HasFish;
		}

		// Token: 0x0601F5DD RID: 128477 RVA: 0x0045EAF4 File Offset: 0x0045CCF4
		public static Offset<ICheckFishingPointHasFish> Pack(FlatBufferBuilder builder, ICheckFishingPointHasFishT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFishingPointHasFish>);
			}
			return ICheckFishingPointHasFish.CreateICheckFishingPointHasFish(builder, _o.Type, _o.HasFish);
		}

		// Token: 0x0400DD50 RID: 56656
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D49 RID: 23881
	public struct IBvbEnableHatredData : IFlatbufferObject
	{
		// Token: 0x1700B300 RID: 45824
		// (get) Token: 0x06028D9E RID: 167326 RVA: 0x0059D4DD File Offset: 0x0059B6DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D9F RID: 167327 RVA: 0x0059D4EA File Offset: 0x0059B6EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DA0 RID: 167328 RVA: 0x0059D4F4 File Offset: 0x0059B6F4
		public static IBvbEnableHatredData GetRootAsIBvbEnableHatredData(ByteBuffer _bb)
		{
			return IBvbEnableHatredData.GetRootAsIBvbEnableHatredData(_bb, default(IBvbEnableHatredData));
		}

		// Token: 0x06028DA1 RID: 167329 RVA: 0x0059D510 File Offset: 0x0059B710
		public static IBvbEnableHatredData GetRootAsIBvbEnableHatredData(ByteBuffer _bb, IBvbEnableHatredData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DA2 RID: 167330 RVA: 0x0059D52D File Offset: 0x0059B72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DA3 RID: 167331 RVA: 0x0059D53C File Offset: 0x0059B73C
		public IBvbEnableHatredData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B301 RID: 45825
		// (get) Token: 0x06028DA4 RID: 167332 RVA: 0x0059D54C File Offset: 0x0059B74C
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028DA5 RID: 167333 RVA: 0x0059D588 File Offset: 0x0059B788
		public static Offset<IBvbEnableHatredData> CreateIBvbEnableHatredData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbEnableHatredData.AddType(builder, Type);
			return IBvbEnableHatredData.EndIBvbEnableHatredData(builder);
		}

		// Token: 0x06028DA6 RID: 167334 RVA: 0x0059D59E File Offset: 0x0059B79E
		public static void StartIBvbEnableHatredData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028DA7 RID: 167335 RVA: 0x0059D5A7 File Offset: 0x0059B7A7
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028DA8 RID: 167336 RVA: 0x0059D5B2 File Offset: 0x0059B7B2
		public static Offset<IBvbEnableHatredData> EndIBvbEnableHatredData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEnableHatredData>(builder.EndTable());
		}

		// Token: 0x06028DA9 RID: 167337 RVA: 0x0059D5C0 File Offset: 0x0059B7C0
		public IBvbEnableHatredDataT UnPack()
		{
			IBvbEnableHatredDataT bvbEnableHatredDataT = new IBvbEnableHatredDataT();
			this.UnPackTo(bvbEnableHatredDataT);
			return bvbEnableHatredDataT;
		}

		// Token: 0x06028DAA RID: 167338 RVA: 0x0059D5DB File Offset: 0x0059B7DB
		public void UnPackTo(IBvbEnableHatredDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028DAB RID: 167339 RVA: 0x0059D5EC File Offset: 0x0059B7EC
		public static Offset<IBvbEnableHatredData> Pack(FlatBufferBuilder builder, IBvbEnableHatredDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEnableHatredData>);
			}
			return IBvbEnableHatredData.CreateIBvbEnableHatredData(builder, _o.Type);
		}

		// Token: 0x0400F6FE RID: 63230
		private Table __p;
	}
}

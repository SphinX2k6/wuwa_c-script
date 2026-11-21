using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BD RID: 26557
	public struct IAdjustFixedLookAtTargetBase : IFlatbufferObject
	{
		// Token: 0x1700C27E RID: 49790
		// (get) Token: 0x0602D3E1 RID: 185313 RVA: 0x0063102D File Offset: 0x0062F22D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D3E2 RID: 185314 RVA: 0x0063103A File Offset: 0x0062F23A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D3E3 RID: 185315 RVA: 0x00631044 File Offset: 0x0062F244
		public static IAdjustFixedLookAtTargetBase GetRootAsIAdjustFixedLookAtTargetBase(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtTargetBase.GetRootAsIAdjustFixedLookAtTargetBase(_bb, default(IAdjustFixedLookAtTargetBase));
		}

		// Token: 0x0602D3E4 RID: 185316 RVA: 0x00631060 File Offset: 0x0062F260
		public static IAdjustFixedLookAtTargetBase GetRootAsIAdjustFixedLookAtTargetBase(ByteBuffer _bb, IAdjustFixedLookAtTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D3E5 RID: 185317 RVA: 0x0063107D File Offset: 0x0062F27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D3E6 RID: 185318 RVA: 0x0063108C File Offset: 0x0062F28C
		public IAdjustFixedLookAtTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C27F RID: 49791
		// (get) Token: 0x0602D3E7 RID: 185319 RVA: 0x0063109C File Offset: 0x0062F29C
		public EFixedLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return (EFixedLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D3E8 RID: 185320 RVA: 0x006310D8 File Offset: 0x0062F2D8
		public static Offset<IAdjustFixedLookAtTargetBase> CreateIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder, EFixedLookAtTargetType Type = EFixedLookAtTargetType.RangeEntity)
		{
			builder.StartTable(1);
			IAdjustFixedLookAtTargetBase.AddType(builder, Type);
			return IAdjustFixedLookAtTargetBase.EndIAdjustFixedLookAtTargetBase(builder);
		}

		// Token: 0x0602D3E9 RID: 185321 RVA: 0x006310EE File Offset: 0x0062F2EE
		public static void StartIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D3EA RID: 185322 RVA: 0x006310F7 File Offset: 0x0062F2F7
		public static void AddType(FlatBufferBuilder builder, EFixedLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D3EB RID: 185323 RVA: 0x00631102 File Offset: 0x0062F302
		public static Offset<IAdjustFixedLookAtTargetBase> EndIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtTargetBase>(builder.EndTable());
		}

		// Token: 0x0602D3EC RID: 185324 RVA: 0x00631110 File Offset: 0x0062F310
		public IAdjustFixedLookAtTargetBaseT UnPack()
		{
			IAdjustFixedLookAtTargetBaseT adjustFixedLookAtTargetBaseT = new IAdjustFixedLookAtTargetBaseT();
			this.UnPackTo(adjustFixedLookAtTargetBaseT);
			return adjustFixedLookAtTargetBaseT;
		}

		// Token: 0x0602D3ED RID: 185325 RVA: 0x0063112B File Offset: 0x0062F32B
		public void UnPackTo(IAdjustFixedLookAtTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D3EE RID: 185326 RVA: 0x0063113C File Offset: 0x0062F33C
		public static Offset<IAdjustFixedLookAtTargetBase> Pack(FlatBufferBuilder builder, IAdjustFixedLookAtTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedLookAtTargetBase>);
			}
			return IAdjustFixedLookAtTargetBase.CreateIAdjustFixedLookAtTargetBase(builder, _o.Type);
		}

		// Token: 0x040113EA RID: 70634
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B6 RID: 21430
	public struct IHookFetchMoveModeBase : IFlatbufferObject
	{
		// Token: 0x17009D87 RID: 40327
		// (get) Token: 0x060231EC RID: 143852 RVA: 0x004DCAE6 File Offset: 0x004DACE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060231ED RID: 143853 RVA: 0x004DCAF3 File Offset: 0x004DACF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060231EE RID: 143854 RVA: 0x004DCAFC File Offset: 0x004DACFC
		public static IHookFetchMoveModeBase GetRootAsIHookFetchMoveModeBase(ByteBuffer _bb)
		{
			return IHookFetchMoveModeBase.GetRootAsIHookFetchMoveModeBase(_bb, default(IHookFetchMoveModeBase));
		}

		// Token: 0x060231EF RID: 143855 RVA: 0x004DCB18 File Offset: 0x004DAD18
		public static IHookFetchMoveModeBase GetRootAsIHookFetchMoveModeBase(ByteBuffer _bb, IHookFetchMoveModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060231F0 RID: 143856 RVA: 0x004DCB35 File Offset: 0x004DAD35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x004DCB44 File Offset: 0x004DAD44
		public IHookFetchMoveModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D88 RID: 40328
		// (get) Token: 0x060231F2 RID: 143858 RVA: 0x004DCB54 File Offset: 0x004DAD54
		public EHookFetchMoveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookFetchMoveMode.Uniform;
				}
				return (EHookFetchMoveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060231F3 RID: 143859 RVA: 0x004DCB90 File Offset: 0x004DAD90
		public static Offset<IHookFetchMoveModeBase> CreateIHookFetchMoveModeBase(FlatBufferBuilder builder, EHookFetchMoveMode Type = EHookFetchMoveMode.Uniform)
		{
			builder.StartTable(1);
			IHookFetchMoveModeBase.AddType(builder, Type);
			return IHookFetchMoveModeBase.EndIHookFetchMoveModeBase(builder);
		}

		// Token: 0x060231F4 RID: 143860 RVA: 0x004DCBA6 File Offset: 0x004DADA6
		public static void StartIHookFetchMoveModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060231F5 RID: 143861 RVA: 0x004DCBAF File Offset: 0x004DADAF
		public static void AddType(FlatBufferBuilder builder, EHookFetchMoveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060231F6 RID: 143862 RVA: 0x004DCBBA File Offset: 0x004DADBA
		public static Offset<IHookFetchMoveModeBase> EndIHookFetchMoveModeBase(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchMoveModeBase>(builder.EndTable());
		}

		// Token: 0x060231F7 RID: 143863 RVA: 0x004DCBC8 File Offset: 0x004DADC8
		public IHookFetchMoveModeBaseT UnPack()
		{
			IHookFetchMoveModeBaseT hookFetchMoveModeBaseT = new IHookFetchMoveModeBaseT();
			this.UnPackTo(hookFetchMoveModeBaseT);
			return hookFetchMoveModeBaseT;
		}

		// Token: 0x060231F8 RID: 143864 RVA: 0x004DCBE3 File Offset: 0x004DADE3
		public void UnPackTo(IHookFetchMoveModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060231F9 RID: 143865 RVA: 0x004DCBF4 File Offset: 0x004DADF4
		public static Offset<IHookFetchMoveModeBase> Pack(FlatBufferBuilder builder, IHookFetchMoveModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookFetchMoveModeBase>);
			}
			return IHookFetchMoveModeBase.CreateIHookFetchMoveModeBase(builder, _o.Type);
		}

		// Token: 0x0400E5B6 RID: 58806
		private Table __p;
	}
}

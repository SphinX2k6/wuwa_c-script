using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593C RID: 22844
	public struct IHookFetchMoveModeBase : IFlatbufferObject
	{
		// Token: 0x1700A5BF RID: 42431
		// (get) Token: 0x060252A0 RID: 152224 RVA: 0x005199BA File Offset: 0x00517BBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252A1 RID: 152225 RVA: 0x005199C7 File Offset: 0x00517BC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252A2 RID: 152226 RVA: 0x005199D0 File Offset: 0x00517BD0
		public static IHookFetchMoveModeBase GetRootAsIHookFetchMoveModeBase(ByteBuffer _bb)
		{
			return IHookFetchMoveModeBase.GetRootAsIHookFetchMoveModeBase(_bb, default(IHookFetchMoveModeBase));
		}

		// Token: 0x060252A3 RID: 152227 RVA: 0x005199EC File Offset: 0x00517BEC
		public static IHookFetchMoveModeBase GetRootAsIHookFetchMoveModeBase(ByteBuffer _bb, IHookFetchMoveModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252A4 RID: 152228 RVA: 0x00519A09 File Offset: 0x00517C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252A5 RID: 152229 RVA: 0x00519A18 File Offset: 0x00517C18
		public IHookFetchMoveModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5C0 RID: 42432
		// (get) Token: 0x060252A6 RID: 152230 RVA: 0x00519A28 File Offset: 0x00517C28
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

		// Token: 0x060252A7 RID: 152231 RVA: 0x00519A64 File Offset: 0x00517C64
		public static Offset<IHookFetchMoveModeBase> CreateIHookFetchMoveModeBase(FlatBufferBuilder builder, EHookFetchMoveMode Type = EHookFetchMoveMode.Uniform)
		{
			builder.StartTable(1);
			IHookFetchMoveModeBase.AddType(builder, Type);
			return IHookFetchMoveModeBase.EndIHookFetchMoveModeBase(builder);
		}

		// Token: 0x060252A8 RID: 152232 RVA: 0x00519A7A File Offset: 0x00517C7A
		public static void StartIHookFetchMoveModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060252A9 RID: 152233 RVA: 0x00519A83 File Offset: 0x00517C83
		public static void AddType(FlatBufferBuilder builder, EHookFetchMoveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060252AA RID: 152234 RVA: 0x00519A8E File Offset: 0x00517C8E
		public static Offset<IHookFetchMoveModeBase> EndIHookFetchMoveModeBase(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchMoveModeBase>(builder.EndTable());
		}

		// Token: 0x060252AB RID: 152235 RVA: 0x00519A9C File Offset: 0x00517C9C
		public IHookFetchMoveModeBaseT UnPack()
		{
			IHookFetchMoveModeBaseT hookFetchMoveModeBaseT = new IHookFetchMoveModeBaseT();
			this.UnPackTo(hookFetchMoveModeBaseT);
			return hookFetchMoveModeBaseT;
		}

		// Token: 0x060252AC RID: 152236 RVA: 0x00519AB7 File Offset: 0x00517CB7
		public void UnPackTo(IHookFetchMoveModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060252AD RID: 152237 RVA: 0x00519AC8 File Offset: 0x00517CC8
		public static Offset<IHookFetchMoveModeBase> Pack(FlatBufferBuilder builder, IHookFetchMoveModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookFetchMoveModeBase>);
			}
			return IHookFetchMoveModeBase.CreateIHookFetchMoveModeBase(builder, _o.Type);
		}

		// Token: 0x0400F1E6 RID: 61926
		private Table __p;
	}
}

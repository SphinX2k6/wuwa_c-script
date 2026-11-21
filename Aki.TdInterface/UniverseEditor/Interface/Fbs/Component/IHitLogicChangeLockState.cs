using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591B RID: 22811
	public struct IHitLogicChangeLockState : IFlatbufferObject
	{
		// Token: 0x1700A573 RID: 42355
		// (get) Token: 0x0602515C RID: 151900 RVA: 0x00517109 File Offset: 0x00515309
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602515D RID: 151901 RVA: 0x00517116 File Offset: 0x00515316
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602515E RID: 151902 RVA: 0x00517120 File Offset: 0x00515320
		public static IHitLogicChangeLockState GetRootAsIHitLogicChangeLockState(ByteBuffer _bb)
		{
			return IHitLogicChangeLockState.GetRootAsIHitLogicChangeLockState(_bb, default(IHitLogicChangeLockState));
		}

		// Token: 0x0602515F RID: 151903 RVA: 0x0051713C File Offset: 0x0051533C
		public static IHitLogicChangeLockState GetRootAsIHitLogicChangeLockState(ByteBuffer _bb, IHitLogicChangeLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025160 RID: 151904 RVA: 0x00517159 File Offset: 0x00515359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025161 RID: 151905 RVA: 0x00517168 File Offset: 0x00515368
		public IHitLogicChangeLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A574 RID: 42356
		// (get) Token: 0x06025162 RID: 151906 RVA: 0x00517178 File Offset: 0x00515378
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025163 RID: 151907 RVA: 0x005171B4 File Offset: 0x005153B4
		public static Offset<IHitLogicChangeLockState> CreateIHitLogicChangeLockState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeLockState.AddType(builder, Type);
			return IHitLogicChangeLockState.EndIHitLogicChangeLockState(builder);
		}

		// Token: 0x06025164 RID: 151908 RVA: 0x005171CA File Offset: 0x005153CA
		public static void StartIHitLogicChangeLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025165 RID: 151909 RVA: 0x005171D3 File Offset: 0x005153D3
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025166 RID: 151910 RVA: 0x005171DE File Offset: 0x005153DE
		public static Offset<IHitLogicChangeLockState> EndIHitLogicChangeLockState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeLockState>(builder.EndTable());
		}

		// Token: 0x06025167 RID: 151911 RVA: 0x005171EC File Offset: 0x005153EC
		public IHitLogicChangeLockStateT UnPack()
		{
			IHitLogicChangeLockStateT hitLogicChangeLockStateT = new IHitLogicChangeLockStateT();
			this.UnPackTo(hitLogicChangeLockStateT);
			return hitLogicChangeLockStateT;
		}

		// Token: 0x06025168 RID: 151912 RVA: 0x00517207 File Offset: 0x00515407
		public void UnPackTo(IHitLogicChangeLockStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025169 RID: 151913 RVA: 0x00517218 File Offset: 0x00515418
		public static Offset<IHitLogicChangeLockState> Pack(FlatBufferBuilder builder, IHitLogicChangeLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeLockState>);
			}
			return IHitLogicChangeLockState.CreateIHitLogicChangeLockState(builder, _o.Type);
		}

		// Token: 0x0400F1B0 RID: 61872
		private Table __p;
	}
}

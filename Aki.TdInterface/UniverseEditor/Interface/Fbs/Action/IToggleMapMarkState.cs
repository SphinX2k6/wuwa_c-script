using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740F RID: 29711
	public struct IToggleMapMarkState : IFlatbufferObject
	{
		// Token: 0x1700E1A6 RID: 57766
		// (get) Token: 0x06035F9B RID: 221083 RVA: 0x00758042 File Offset: 0x00756242
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F9C RID: 221084 RVA: 0x0075804F File Offset: 0x0075624F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F9D RID: 221085 RVA: 0x00758058 File Offset: 0x00756258
		public static IToggleMapMarkState GetRootAsIToggleMapMarkState(ByteBuffer _bb)
		{
			return IToggleMapMarkState.GetRootAsIToggleMapMarkState(_bb, default(IToggleMapMarkState));
		}

		// Token: 0x06035F9E RID: 221086 RVA: 0x00758074 File Offset: 0x00756274
		public static IToggleMapMarkState GetRootAsIToggleMapMarkState(ByteBuffer _bb, IToggleMapMarkState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F9F RID: 221087 RVA: 0x00758091 File Offset: 0x00756291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FA0 RID: 221088 RVA: 0x007580A0 File Offset: 0x007562A0
		public IToggleMapMarkState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1A7 RID: 57767
		// (get) Token: 0x06035FA1 RID: 221089 RVA: 0x007580B0 File Offset: 0x007562B0
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035FA2 RID: 221090 RVA: 0x007580EC File Offset: 0x007562EC
		public static Offset<IToggleMapMarkState> CreateIToggleMapMarkState(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show)
		{
			builder.StartTable(1);
			IToggleMapMarkState.AddType(builder, Type);
			return IToggleMapMarkState.EndIToggleMapMarkState(builder);
		}

		// Token: 0x06035FA3 RID: 221091 RVA: 0x00758102 File Offset: 0x00756302
		public static void StartIToggleMapMarkState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035FA4 RID: 221092 RVA: 0x0075810B File Offset: 0x0075630B
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035FA5 RID: 221093 RVA: 0x00758116 File Offset: 0x00756316
		public static Offset<IToggleMapMarkState> EndIToggleMapMarkState(FlatBufferBuilder builder)
		{
			return new Offset<IToggleMapMarkState>(builder.EndTable());
		}

		// Token: 0x06035FA6 RID: 221094 RVA: 0x00758124 File Offset: 0x00756324
		public IToggleMapMarkStateT UnPack()
		{
			IToggleMapMarkStateT toggleMapMarkStateT = new IToggleMapMarkStateT();
			this.UnPackTo(toggleMapMarkStateT);
			return toggleMapMarkStateT;
		}

		// Token: 0x06035FA7 RID: 221095 RVA: 0x0075813F File Offset: 0x0075633F
		public void UnPackTo(IToggleMapMarkStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035FA8 RID: 221096 RVA: 0x00758150 File Offset: 0x00756350
		public static Offset<IToggleMapMarkState> Pack(FlatBufferBuilder builder, IToggleMapMarkStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleMapMarkState>);
			}
			return IToggleMapMarkState.CreateIToggleMapMarkState(builder, _o.Type);
		}

		// Token: 0x0401227E RID: 74366
		private Table __p;
	}
}

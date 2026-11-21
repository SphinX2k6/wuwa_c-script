using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9E RID: 27806
	public struct IEffectPlayerPos2 : IFlatbufferObject
	{
		// Token: 0x1700CBF3 RID: 52211
		// (get) Token: 0x0602FE94 RID: 196244 RVA: 0x00685BCB File Offset: 0x00683DCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE95 RID: 196245 RVA: 0x00685BD8 File Offset: 0x00683DD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE96 RID: 196246 RVA: 0x00685BE0 File Offset: 0x00683DE0
		public static IEffectPlayerPos2 GetRootAsIEffectPlayerPos2(ByteBuffer _bb)
		{
			return IEffectPlayerPos2.GetRootAsIEffectPlayerPos2(_bb, default(IEffectPlayerPos2));
		}

		// Token: 0x0602FE97 RID: 196247 RVA: 0x00685BFC File Offset: 0x00683DFC
		public static IEffectPlayerPos2 GetRootAsIEffectPlayerPos2(ByteBuffer _bb, IEffectPlayerPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE98 RID: 196248 RVA: 0x00685C19 File Offset: 0x00683E19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE99 RID: 196249 RVA: 0x00685C28 File Offset: 0x00683E28
		public IEffectPlayerPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBF4 RID: 52212
		// (get) Token: 0x0602FE9A RID: 196250 RVA: 0x00685C38 File Offset: 0x00683E38
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBF5 RID: 52213
		// (get) Token: 0x0602FE9B RID: 196251 RVA: 0x00685C74 File Offset: 0x00683E74
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CBF6 RID: 52214
		// (get) Token: 0x0602FE9C RID: 196252 RVA: 0x00685CD4 File Offset: 0x00683ED4
		public string AttachSocket
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE9D RID: 196253 RVA: 0x00685D0B File Offset: 0x00683F0B
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602FE9E RID: 196254 RVA: 0x00685D1A File Offset: 0x00683F1A
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602FE9F RID: 196255 RVA: 0x00685D28 File Offset: 0x00683F28
		public static Offset<IEffectPlayerPos2> CreateIEffectPlayerPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset AttachSocketOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IEffectPlayerPos2.AddAttachSocket(builder, AttachSocketOffset);
			IEffectPlayerPos2.AddOffset(builder, OffsetOffset);
			IEffectPlayerPos2.AddType(builder, Type);
			return IEffectPlayerPos2.EndIEffectPlayerPos2(builder);
		}

		// Token: 0x0602FEA0 RID: 196256 RVA: 0x00685D4C File Offset: 0x00683F4C
		public static void StartIEffectPlayerPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FEA1 RID: 196257 RVA: 0x00685D55 File Offset: 0x00683F55
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEA2 RID: 196258 RVA: 0x00685D60 File Offset: 0x00683F60
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602FEA3 RID: 196259 RVA: 0x00685D70 File Offset: 0x00683F70
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(2, attachSocketOffset.Value, 0);
		}

		// Token: 0x0602FEA4 RID: 196260 RVA: 0x00685D80 File Offset: 0x00683F80
		public static Offset<IEffectPlayerPos2> EndIEffectPlayerPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEffectPlayerPos2>(builder.EndTable());
		}

		// Token: 0x0602FEA5 RID: 196261 RVA: 0x00685D90 File Offset: 0x00683F90
		public IEffectPlayerPos2T UnPack()
		{
			IEffectPlayerPos2T effectPlayerPos2T = new IEffectPlayerPos2T();
			this.UnPackTo(effectPlayerPos2T);
			return effectPlayerPos2T;
		}

		// Token: 0x0602FEA6 RID: 196262 RVA: 0x00685DAC File Offset: 0x00683FAC
		public void UnPackTo(IEffectPlayerPos2T _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.AttachSocket = this.AttachSocket;
		}

		// Token: 0x0602FEA7 RID: 196263 RVA: 0x00685E00 File Offset: 0x00684000
		public static Offset<IEffectPlayerPos2> Pack(FlatBufferBuilder builder, IEffectPlayerPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectPlayerPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset attachSocketOffset = (_o.AttachSocket == null) ? default(StringOffset) : builder.CreateString(_o.AttachSocket);
			return IEffectPlayerPos2.CreateIEffectPlayerPos2(builder, _o.Type, offsetOffset, attachSocketOffset);
		}

		// Token: 0x04011ADA RID: 72410
		private Table __p;
	}
}

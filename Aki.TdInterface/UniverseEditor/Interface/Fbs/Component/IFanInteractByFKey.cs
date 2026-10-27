using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005231 RID: 21041
	public struct IFanInteractByFKey : IFlatbufferObject
	{
		// Token: 0x17009A2E RID: 39470
		// (get) Token: 0x0602238D RID: 140173 RVA: 0x004BF67D File Offset: 0x004BD87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602238E RID: 140174 RVA: 0x004BF68A File Offset: 0x004BD88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602238F RID: 140175 RVA: 0x004BF694 File Offset: 0x004BD894
		public static IFanInteractByFKey GetRootAsIFanInteractByFKey(ByteBuffer _bb)
		{
			return IFanInteractByFKey.GetRootAsIFanInteractByFKey(_bb, default(IFanInteractByFKey));
		}

		// Token: 0x06022390 RID: 140176 RVA: 0x004BF6B0 File Offset: 0x004BD8B0
		public static IFanInteractByFKey GetRootAsIFanInteractByFKey(ByteBuffer _bb, IFanInteractByFKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022391 RID: 140177 RVA: 0x004BF6CD File Offset: 0x004BD8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022392 RID: 140178 RVA: 0x004BF6DC File Offset: 0x004BD8DC
		public IFanInteractByFKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A2F RID: 39471
		// (get) Token: 0x06022393 RID: 140179 RVA: 0x004BF6EC File Offset: 0x004BD8EC
		public EFanInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFanInteractType.Hit;
				}
				return (EFanInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A30 RID: 39472
		// (get) Token: 0x06022394 RID: 140180 RVA: 0x004BF728 File Offset: 0x004BD928
		public string TidInteractOptionText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022395 RID: 140181 RVA: 0x004BF75F File Offset: 0x004BD95F
		public Span<byte> GetTidInteractOptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022396 RID: 140182 RVA: 0x004BF76E File Offset: 0x004BD96E
		public byte[] GetTidInteractOptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022397 RID: 140183 RVA: 0x004BF77C File Offset: 0x004BD97C
		public static Offset<IFanInteractByFKey> CreateIFanInteractByFKey(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit, StringOffset TidInteractOptionTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFanInteractByFKey.AddTidInteractOptionText(builder, TidInteractOptionTextOffset);
			IFanInteractByFKey.AddType(builder, Type);
			return IFanInteractByFKey.EndIFanInteractByFKey(builder);
		}

		// Token: 0x06022398 RID: 140184 RVA: 0x004BF799 File Offset: 0x004BD999
		public static void StartIFanInteractByFKey(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022399 RID: 140185 RVA: 0x004BF7A2 File Offset: 0x004BD9A2
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602239A RID: 140186 RVA: 0x004BF7AD File Offset: 0x004BD9AD
		public static void AddTidInteractOptionText(FlatBufferBuilder builder, StringOffset tidInteractOptionTextOffset)
		{
			builder.AddOffset(1, tidInteractOptionTextOffset.Value, 0);
		}

		// Token: 0x0602239B RID: 140187 RVA: 0x004BF7BD File Offset: 0x004BD9BD
		public static Offset<IFanInteractByFKey> EndIFanInteractByFKey(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractByFKey>(builder.EndTable());
		}

		// Token: 0x0602239C RID: 140188 RVA: 0x004BF7CC File Offset: 0x004BD9CC
		public IFanInteractByFKeyT UnPack()
		{
			IFanInteractByFKeyT fanInteractByFKeyT = new IFanInteractByFKeyT();
			this.UnPackTo(fanInteractByFKeyT);
			return fanInteractByFKeyT;
		}

		// Token: 0x0602239D RID: 140189 RVA: 0x004BF7E7 File Offset: 0x004BD9E7
		public void UnPackTo(IFanInteractByFKeyT _o)
		{
			_o.Type = this.Type;
			_o.TidInteractOptionText = this.TidInteractOptionText;
		}

		// Token: 0x0602239E RID: 140190 RVA: 0x004BF804 File Offset: 0x004BDA04
		public static Offset<IFanInteractByFKey> Pack(FlatBufferBuilder builder, IFanInteractByFKeyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractByFKey>);
			}
			StringOffset tidInteractOptionTextOffset = (_o.TidInteractOptionText == null) ? default(StringOffset) : builder.CreateString(_o.TidInteractOptionText);
			return IFanInteractByFKey.CreateIFanInteractByFKey(builder, _o.Type, tidInteractOptionTextOffset);
		}

		// Token: 0x0400E377 RID: 58231
		private Table __p;
	}
}

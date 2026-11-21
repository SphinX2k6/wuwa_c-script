using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007163 RID: 29027
	public struct ILongPressInteractStyleConfig : IFlatbufferObject
	{
		// Token: 0x1700D480 RID: 54400
		// (get) Token: 0x0603272E RID: 206638 RVA: 0x006D1CF6 File Offset: 0x006CFEF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603272F RID: 206639 RVA: 0x006D1D03 File Offset: 0x006CFF03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032730 RID: 206640 RVA: 0x006D1D0C File Offset: 0x006CFF0C
		public static ILongPressInteractStyleConfig GetRootAsILongPressInteractStyleConfig(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfig.GetRootAsILongPressInteractStyleConfig(_bb, default(ILongPressInteractStyleConfig));
		}

		// Token: 0x06032731 RID: 206641 RVA: 0x006D1D28 File Offset: 0x006CFF28
		public static ILongPressInteractStyleConfig GetRootAsILongPressInteractStyleConfig(ByteBuffer _bb, ILongPressInteractStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032732 RID: 206642 RVA: 0x006D1D45 File Offset: 0x006CFF45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032733 RID: 206643 RVA: 0x006D1D54 File Offset: 0x006CFF54
		public ILongPressInteractStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D481 RID: 54401
		// (get) Token: 0x06032734 RID: 206644 RVA: 0x006D1D64 File Offset: 0x006CFF64
		public ELongPressInteractStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELongPressInteractStyle.Default;
				}
				return (ELongPressInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032735 RID: 206645 RVA: 0x006D1DA0 File Offset: 0x006CFFA0
		public static Offset<ILongPressInteractStyleConfig> CreateILongPressInteractStyleConfig(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleConfig.AddType(builder, Type);
			return ILongPressInteractStyleConfig.EndILongPressInteractStyleConfig(builder);
		}

		// Token: 0x06032736 RID: 206646 RVA: 0x006D1DB6 File Offset: 0x006CFFB6
		public static void StartILongPressInteractStyleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032737 RID: 206647 RVA: 0x006D1DBF File Offset: 0x006CFFBF
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032738 RID: 206648 RVA: 0x006D1DCA File Offset: 0x006CFFCA
		public static Offset<ILongPressInteractStyleConfig> EndILongPressInteractStyleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfig>(builder.EndTable());
		}

		// Token: 0x06032739 RID: 206649 RVA: 0x006D1DD8 File Offset: 0x006CFFD8
		public ILongPressInteractStyleConfigT UnPack()
		{
			ILongPressInteractStyleConfigT longPressInteractStyleConfigT = new ILongPressInteractStyleConfigT();
			this.UnPackTo(longPressInteractStyleConfigT);
			return longPressInteractStyleConfigT;
		}

		// Token: 0x0603273A RID: 206650 RVA: 0x006D1DF3 File Offset: 0x006CFFF3
		public void UnPackTo(ILongPressInteractStyleConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603273B RID: 206651 RVA: 0x006D1E04 File Offset: 0x006D0004
		public static Offset<ILongPressInteractStyleConfig> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfig>);
			}
			return ILongPressInteractStyleConfig.CreateILongPressInteractStyleConfig(builder, _o.Type);
		}

		// Token: 0x04012154 RID: 74068
		private Table __p;
	}
}

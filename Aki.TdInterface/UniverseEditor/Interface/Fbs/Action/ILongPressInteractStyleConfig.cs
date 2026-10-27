using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A41 RID: 27201
	public struct ILongPressInteractStyleConfig : IFlatbufferObject
	{
		// Token: 0x1700C9D5 RID: 51669
		// (get) Token: 0x0602FA08 RID: 195080 RVA: 0x0067BC36 File Offset: 0x00679E36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA09 RID: 195081 RVA: 0x0067BC43 File Offset: 0x00679E43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA0A RID: 195082 RVA: 0x0067BC4C File Offset: 0x00679E4C
		public static ILongPressInteractStyleConfig GetRootAsILongPressInteractStyleConfig(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfig.GetRootAsILongPressInteractStyleConfig(_bb, default(ILongPressInteractStyleConfig));
		}

		// Token: 0x0602FA0B RID: 195083 RVA: 0x0067BC68 File Offset: 0x00679E68
		public static ILongPressInteractStyleConfig GetRootAsILongPressInteractStyleConfig(ByteBuffer _bb, ILongPressInteractStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA0C RID: 195084 RVA: 0x0067BC85 File Offset: 0x00679E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA0D RID: 195085 RVA: 0x0067BC94 File Offset: 0x00679E94
		public ILongPressInteractStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9D6 RID: 51670
		// (get) Token: 0x0602FA0E RID: 195086 RVA: 0x0067BCA4 File Offset: 0x00679EA4
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

		// Token: 0x0602FA0F RID: 195087 RVA: 0x0067BCE0 File Offset: 0x00679EE0
		public static Offset<ILongPressInteractStyleConfig> CreateILongPressInteractStyleConfig(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleConfig.AddType(builder, Type);
			return ILongPressInteractStyleConfig.EndILongPressInteractStyleConfig(builder);
		}

		// Token: 0x0602FA10 RID: 195088 RVA: 0x0067BCF6 File Offset: 0x00679EF6
		public static void StartILongPressInteractStyleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA11 RID: 195089 RVA: 0x0067BCFF File Offset: 0x00679EFF
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA12 RID: 195090 RVA: 0x0067BD0A File Offset: 0x00679F0A
		public static Offset<ILongPressInteractStyleConfig> EndILongPressInteractStyleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfig>(builder.EndTable());
		}

		// Token: 0x0602FA13 RID: 195091 RVA: 0x0067BD18 File Offset: 0x00679F18
		public ILongPressInteractStyleConfigT UnPack()
		{
			ILongPressInteractStyleConfigT longPressInteractStyleConfigT = new ILongPressInteractStyleConfigT();
			this.UnPackTo(longPressInteractStyleConfigT);
			return longPressInteractStyleConfigT;
		}

		// Token: 0x0602FA14 RID: 195092 RVA: 0x0067BD33 File Offset: 0x00679F33
		public void UnPackTo(ILongPressInteractStyleConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA15 RID: 195093 RVA: 0x0067BD44 File Offset: 0x00679F44
		public static Offset<ILongPressInteractStyleConfig> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfig>);
			}
			return ILongPressInteractStyleConfig.CreateILongPressInteractStyleConfig(builder, _o.Type);
		}

		// Token: 0x0401125C RID: 70236
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006455 RID: 25685
	public struct IOutAreaBorderEffectType : IFlatbufferObject
	{
		// Token: 0x1700BDA0 RID: 48544
		// (get) Token: 0x0602BA68 RID: 178792 RVA: 0x005F1139 File Offset: 0x005EF339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA69 RID: 178793 RVA: 0x005F1146 File Offset: 0x005EF346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA6A RID: 178794 RVA: 0x005F1150 File Offset: 0x005EF350
		public static IOutAreaBorderEffectType GetRootAsIOutAreaBorderEffectType(ByteBuffer _bb)
		{
			return IOutAreaBorderEffectType.GetRootAsIOutAreaBorderEffectType(_bb, default(IOutAreaBorderEffectType));
		}

		// Token: 0x0602BA6B RID: 178795 RVA: 0x005F116C File Offset: 0x005EF36C
		public static IOutAreaBorderEffectType GetRootAsIOutAreaBorderEffectType(ByteBuffer _bb, IOutAreaBorderEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA6C RID: 178796 RVA: 0x005F1189 File Offset: 0x005EF389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA6D RID: 178797 RVA: 0x005F1198 File Offset: 0x005EF398
		public IOutAreaBorderEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDA1 RID: 48545
		// (get) Token: 0x0602BA6E RID: 178798 RVA: 0x005F11A8 File Offset: 0x005EF3A8
		public EOutAreaBorderEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderEffectType.BuffId;
				}
				return (EOutAreaBorderEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA6F RID: 178799 RVA: 0x005F11E4 File Offset: 0x005EF3E4
		public static Offset<IOutAreaBorderEffectType> CreateIOutAreaBorderEffectType(FlatBufferBuilder builder, EOutAreaBorderEffectType Type = EOutAreaBorderEffectType.BuffId)
		{
			builder.StartTable(1);
			IOutAreaBorderEffectType.AddType(builder, Type);
			return IOutAreaBorderEffectType.EndIOutAreaBorderEffectType(builder);
		}

		// Token: 0x0602BA70 RID: 178800 RVA: 0x005F11FA File Offset: 0x005EF3FA
		public static void StartIOutAreaBorderEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BA71 RID: 178801 RVA: 0x005F1203 File Offset: 0x005EF403
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA72 RID: 178802 RVA: 0x005F120E File Offset: 0x005EF40E
		public static Offset<IOutAreaBorderEffectType> EndIOutAreaBorderEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderEffectType>(builder.EndTable());
		}

		// Token: 0x0602BA73 RID: 178803 RVA: 0x005F121C File Offset: 0x005EF41C
		public IOutAreaBorderEffectTypeT UnPack()
		{
			IOutAreaBorderEffectTypeT outAreaBorderEffectTypeT = new IOutAreaBorderEffectTypeT();
			this.UnPackTo(outAreaBorderEffectTypeT);
			return outAreaBorderEffectTypeT;
		}

		// Token: 0x0602BA74 RID: 178804 RVA: 0x005F1237 File Offset: 0x005EF437
		public void UnPackTo(IOutAreaBorderEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BA75 RID: 178805 RVA: 0x005F1248 File Offset: 0x005EF448
		public static Offset<IOutAreaBorderEffectType> Pack(FlatBufferBuilder builder, IOutAreaBorderEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderEffectType>);
			}
			return IOutAreaBorderEffectType.CreateIOutAreaBorderEffectType(builder, _o.Type);
		}

		// Token: 0x04010568 RID: 66920
		private Table __p;
	}
}

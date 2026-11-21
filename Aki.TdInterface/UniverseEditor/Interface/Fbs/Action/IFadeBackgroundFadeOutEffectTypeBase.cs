using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF4 RID: 28148
	public struct IFadeBackgroundFadeOutEffectTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CE4D RID: 52813
		// (get) Token: 0x06030979 RID: 199033 RVA: 0x00698F21 File Offset: 0x00697121
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603097A RID: 199034 RVA: 0x00698F2E File Offset: 0x0069712E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603097B RID: 199035 RVA: 0x00698F38 File Offset: 0x00697138
		public static IFadeBackgroundFadeOutEffectTypeBase GetRootAsIFadeBackgroundFadeOutEffectTypeBase(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectTypeBase.GetRootAsIFadeBackgroundFadeOutEffectTypeBase(_bb, default(IFadeBackgroundFadeOutEffectTypeBase));
		}

		// Token: 0x0603097C RID: 199036 RVA: 0x00698F54 File Offset: 0x00697154
		public static IFadeBackgroundFadeOutEffectTypeBase GetRootAsIFadeBackgroundFadeOutEffectTypeBase(ByteBuffer _bb, IFadeBackgroundFadeOutEffectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603097D RID: 199037 RVA: 0x00698F71 File Offset: 0x00697171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603097E RID: 199038 RVA: 0x00698F80 File Offset: 0x00697180
		public IFadeBackgroundFadeOutEffectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE4E RID: 52814
		// (get) Token: 0x0603097F RID: 199039 RVA: 0x00698F90 File Offset: 0x00697190
		public EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundFadeOutEffectType.Black;
				}
				return (EFadeBackgroundFadeOutEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030980 RID: 199040 RVA: 0x00698FCC File Offset: 0x006971CC
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> CreateIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType Type = EFadeBackgroundFadeOutEffectType.Black)
		{
			builder.StartTable(1);
			IFadeBackgroundFadeOutEffectTypeBase.AddType(builder, Type);
			return IFadeBackgroundFadeOutEffectTypeBase.EndIFadeBackgroundFadeOutEffectTypeBase(builder);
		}

		// Token: 0x06030981 RID: 199041 RVA: 0x00698FE2 File Offset: 0x006971E2
		public static void StartIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030982 RID: 199042 RVA: 0x00698FEB File Offset: 0x006971EB
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030983 RID: 199043 RVA: 0x00698FF6 File Offset: 0x006971F6
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> EndIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectTypeBase>(builder.EndTable());
		}

		// Token: 0x06030984 RID: 199044 RVA: 0x00699004 File Offset: 0x00697204
		public IFadeBackgroundFadeOutEffectTypeBaseT UnPack()
		{
			IFadeBackgroundFadeOutEffectTypeBaseT fadeBackgroundFadeOutEffectTypeBaseT = new IFadeBackgroundFadeOutEffectTypeBaseT();
			this.UnPackTo(fadeBackgroundFadeOutEffectTypeBaseT);
			return fadeBackgroundFadeOutEffectTypeBaseT;
		}

		// Token: 0x06030985 RID: 199045 RVA: 0x0069901F File Offset: 0x0069721F
		public void UnPackTo(IFadeBackgroundFadeOutEffectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030986 RID: 199046 RVA: 0x00699030 File Offset: 0x00697230
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectTypeBase>);
			}
			return IFadeBackgroundFadeOutEffectTypeBase.CreateIFadeBackgroundFadeOutEffectTypeBase(builder, _o.Type);
		}

		// Token: 0x04011C9F RID: 72863
		private Table __p;
	}
}

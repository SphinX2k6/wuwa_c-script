using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006774 RID: 26484
	public struct IFadeBackgroundFadeOutEffectTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C497 RID: 50327
		// (get) Token: 0x0602E133 RID: 188723 RVA: 0x0064B7DD File Offset: 0x006499DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E134 RID: 188724 RVA: 0x0064B7EA File Offset: 0x006499EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E135 RID: 188725 RVA: 0x0064B7F4 File Offset: 0x006499F4
		public static IFadeBackgroundFadeOutEffectTypeBase GetRootAsIFadeBackgroundFadeOutEffectTypeBase(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectTypeBase.GetRootAsIFadeBackgroundFadeOutEffectTypeBase(_bb, default(IFadeBackgroundFadeOutEffectTypeBase));
		}

		// Token: 0x0602E136 RID: 188726 RVA: 0x0064B810 File Offset: 0x00649A10
		public static IFadeBackgroundFadeOutEffectTypeBase GetRootAsIFadeBackgroundFadeOutEffectTypeBase(ByteBuffer _bb, IFadeBackgroundFadeOutEffectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E137 RID: 188727 RVA: 0x0064B82D File Offset: 0x00649A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E138 RID: 188728 RVA: 0x0064B83C File Offset: 0x00649A3C
		public IFadeBackgroundFadeOutEffectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C498 RID: 50328
		// (get) Token: 0x0602E139 RID: 188729 RVA: 0x0064B84C File Offset: 0x00649A4C
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

		// Token: 0x0602E13A RID: 188730 RVA: 0x0064B888 File Offset: 0x00649A88
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> CreateIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType Type = EFadeBackgroundFadeOutEffectType.Black)
		{
			builder.StartTable(1);
			IFadeBackgroundFadeOutEffectTypeBase.AddType(builder, Type);
			return IFadeBackgroundFadeOutEffectTypeBase.EndIFadeBackgroundFadeOutEffectTypeBase(builder);
		}

		// Token: 0x0602E13B RID: 188731 RVA: 0x0064B89E File Offset: 0x00649A9E
		public static void StartIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E13C RID: 188732 RVA: 0x0064B8A7 File Offset: 0x00649AA7
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E13D RID: 188733 RVA: 0x0064B8B2 File Offset: 0x00649AB2
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> EndIFadeBackgroundFadeOutEffectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectTypeBase>(builder.EndTable());
		}

		// Token: 0x0602E13E RID: 188734 RVA: 0x0064B8C0 File Offset: 0x00649AC0
		public IFadeBackgroundFadeOutEffectTypeBaseT UnPack()
		{
			IFadeBackgroundFadeOutEffectTypeBaseT fadeBackgroundFadeOutEffectTypeBaseT = new IFadeBackgroundFadeOutEffectTypeBaseT();
			this.UnPackTo(fadeBackgroundFadeOutEffectTypeBaseT);
			return fadeBackgroundFadeOutEffectTypeBaseT;
		}

		// Token: 0x0602E13F RID: 188735 RVA: 0x0064B8DB File Offset: 0x00649ADB
		public void UnPackTo(IFadeBackgroundFadeOutEffectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E140 RID: 188736 RVA: 0x0064B8EC File Offset: 0x00649AEC
		public static Offset<IFadeBackgroundFadeOutEffectTypeBase> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectTypeBase>);
			}
			return IFadeBackgroundFadeOutEffectTypeBase.CreateIFadeBackgroundFadeOutEffectTypeBase(builder, _o.Type);
		}

		// Token: 0x04010E6D RID: 69229
		private Table __p;
	}
}

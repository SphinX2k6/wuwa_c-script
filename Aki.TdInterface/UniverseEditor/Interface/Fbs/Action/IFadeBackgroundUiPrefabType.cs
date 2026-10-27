using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678C RID: 26508
	public struct IFadeBackgroundUiPrefabType : IFlatbufferObject
	{
		// Token: 0x1700C4C1 RID: 50369
		// (get) Token: 0x0602E1EB RID: 188907 RVA: 0x0064CC28 File Offset: 0x0064AE28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1EC RID: 188908 RVA: 0x0064CC35 File Offset: 0x0064AE35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1ED RID: 188909 RVA: 0x0064CC3C File Offset: 0x0064AE3C
		public static IFadeBackgroundUiPrefabType GetRootAsIFadeBackgroundUiPrefabType(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefabType.GetRootAsIFadeBackgroundUiPrefabType(_bb, default(IFadeBackgroundUiPrefabType));
		}

		// Token: 0x0602E1EE RID: 188910 RVA: 0x0064CC58 File Offset: 0x0064AE58
		public static IFadeBackgroundUiPrefabType GetRootAsIFadeBackgroundUiPrefabType(ByteBuffer _bb, IFadeBackgroundUiPrefabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1EF RID: 188911 RVA: 0x0064CC75 File Offset: 0x0064AE75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1F0 RID: 188912 RVA: 0x0064CC84 File Offset: 0x0064AE84
		public IFadeBackgroundUiPrefabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4C2 RID: 50370
		// (get) Token: 0x0602E1F1 RID: 188913 RVA: 0x0064CC94 File Offset: 0x0064AE94
		public EFadeBackgroundUiPrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				}
				return (EFadeBackgroundUiPrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E1F2 RID: 188914 RVA: 0x0064CCD0 File Offset: 0x0064AED0
		public static Offset<IFadeBackgroundUiPrefabType> CreateIFadeBackgroundUiPrefabType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText)
		{
			builder.StartTable(1);
			IFadeBackgroundUiPrefabType.AddType(builder, Type);
			return IFadeBackgroundUiPrefabType.EndIFadeBackgroundUiPrefabType(builder);
		}

		// Token: 0x0602E1F3 RID: 188915 RVA: 0x0064CCE6 File Offset: 0x0064AEE6
		public static void StartIFadeBackgroundUiPrefabType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E1F4 RID: 188916 RVA: 0x0064CCEF File Offset: 0x0064AEEF
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E1F5 RID: 188917 RVA: 0x0064CCFA File Offset: 0x0064AEFA
		public static Offset<IFadeBackgroundUiPrefabType> EndIFadeBackgroundUiPrefabType(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefabType>(builder.EndTable());
		}

		// Token: 0x0602E1F6 RID: 188918 RVA: 0x0064CD08 File Offset: 0x0064AF08
		public IFadeBackgroundUiPrefabTypeT UnPack()
		{
			IFadeBackgroundUiPrefabTypeT fadeBackgroundUiPrefabTypeT = new IFadeBackgroundUiPrefabTypeT();
			this.UnPackTo(fadeBackgroundUiPrefabTypeT);
			return fadeBackgroundUiPrefabTypeT;
		}

		// Token: 0x0602E1F7 RID: 188919 RVA: 0x0064CD23 File Offset: 0x0064AF23
		public void UnPackTo(IFadeBackgroundUiPrefabTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E1F8 RID: 188920 RVA: 0x0064CD34 File Offset: 0x0064AF34
		public static Offset<IFadeBackgroundUiPrefabType> Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundUiPrefabType>);
			}
			return IFadeBackgroundUiPrefabType.CreateIFadeBackgroundUiPrefabType(builder, _o.Type);
		}

		// Token: 0x04010E92 RID: 69266
		private Table __p;
	}
}

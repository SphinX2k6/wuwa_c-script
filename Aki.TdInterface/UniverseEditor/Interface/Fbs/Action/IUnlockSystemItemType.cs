using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E1 RID: 29921
	public struct IUnlockSystemItemType : IFlatbufferObject
	{
		// Token: 0x1700E306 RID: 58118
		// (get) Token: 0x06036650 RID: 222800 RVA: 0x00763EC9 File Offset: 0x007620C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036651 RID: 222801 RVA: 0x00763ED6 File Offset: 0x007620D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036652 RID: 222802 RVA: 0x00763EE0 File Offset: 0x007620E0
		public static IUnlockSystemItemType GetRootAsIUnlockSystemItemType(ByteBuffer _bb)
		{
			return IUnlockSystemItemType.GetRootAsIUnlockSystemItemType(_bb, default(IUnlockSystemItemType));
		}

		// Token: 0x06036653 RID: 222803 RVA: 0x00763EFC File Offset: 0x007620FC
		public static IUnlockSystemItemType GetRootAsIUnlockSystemItemType(ByteBuffer _bb, IUnlockSystemItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036654 RID: 222804 RVA: 0x00763F19 File Offset: 0x00762119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036655 RID: 222805 RVA: 0x00763F28 File Offset: 0x00762128
		public IUnlockSystemItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E307 RID: 58119
		// (get) Token: 0x06036656 RID: 222806 RVA: 0x00763F38 File Offset: 0x00762138
		public EUnlockSystemItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return (EUnlockSystemItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036657 RID: 222807 RVA: 0x00763F74 File Offset: 0x00762174
		public static Offset<IUnlockSystemItemType> CreateIUnlockSystemItemType(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem)
		{
			builder.StartTable(1);
			IUnlockSystemItemType.AddType(builder, Type);
			return IUnlockSystemItemType.EndIUnlockSystemItemType(builder);
		}

		// Token: 0x06036658 RID: 222808 RVA: 0x00763F8A File Offset: 0x0076218A
		public static void StartIUnlockSystemItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036659 RID: 222809 RVA: 0x00763F93 File Offset: 0x00762193
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603665A RID: 222810 RVA: 0x00763F9E File Offset: 0x0076219E
		public static Offset<IUnlockSystemItemType> EndIUnlockSystemItemType(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockSystemItemType>(builder.EndTable());
		}

		// Token: 0x0603665B RID: 222811 RVA: 0x00763FAC File Offset: 0x007621AC
		public IUnlockSystemItemTypeT UnPack()
		{
			IUnlockSystemItemTypeT unlockSystemItemTypeT = new IUnlockSystemItemTypeT();
			this.UnPackTo(unlockSystemItemTypeT);
			return unlockSystemItemTypeT;
		}

		// Token: 0x0603665C RID: 222812 RVA: 0x00763FC7 File Offset: 0x007621C7
		public void UnPackTo(IUnlockSystemItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603665D RID: 222813 RVA: 0x00763FD8 File Offset: 0x007621D8
		public static Offset<IUnlockSystemItemType> Pack(FlatBufferBuilder builder, IUnlockSystemItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockSystemItemType>);
			}
			return IUnlockSystemItemType.CreateIUnlockSystemItemType(builder, _o.Type);
		}

		// Token: 0x040123A8 RID: 74664
		private Table __p;
	}
}

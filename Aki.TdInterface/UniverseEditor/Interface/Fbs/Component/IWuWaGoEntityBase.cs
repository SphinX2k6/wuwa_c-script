using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061BA RID: 25018
	public struct IWuWaGoEntityBase : IFlatbufferObject
	{
		// Token: 0x1700BA91 RID: 47761
		// (get) Token: 0x0602A87D RID: 174205 RVA: 0x005CCF8A File Offset: 0x005CB18A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A87E RID: 174206 RVA: 0x005CCF97 File Offset: 0x005CB197
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A87F RID: 174207 RVA: 0x005CCFA0 File Offset: 0x005CB1A0
		public static IWuWaGoEntityBase GetRootAsIWuWaGoEntityBase(ByteBuffer _bb)
		{
			return IWuWaGoEntityBase.GetRootAsIWuWaGoEntityBase(_bb, default(IWuWaGoEntityBase));
		}

		// Token: 0x0602A880 RID: 174208 RVA: 0x005CCFBC File Offset: 0x005CB1BC
		public static IWuWaGoEntityBase GetRootAsIWuWaGoEntityBase(ByteBuffer _bb, IWuWaGoEntityBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A881 RID: 174209 RVA: 0x005CCFD9 File Offset: 0x005CB1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A882 RID: 174210 RVA: 0x005CCFE8 File Offset: 0x005CB1E8
		public IWuWaGoEntityBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA92 RID: 47762
		// (get) Token: 0x0602A883 RID: 174211 RVA: 0x005CCFF8 File Offset: 0x005CB1F8
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A884 RID: 174212 RVA: 0x005CD034 File Offset: 0x005CB234
		public static Offset<IWuWaGoEntityBase> CreateIWuWaGoEntityBase(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter)
		{
			builder.StartTable(1);
			IWuWaGoEntityBase.AddType(builder, Type);
			return IWuWaGoEntityBase.EndIWuWaGoEntityBase(builder);
		}

		// Token: 0x0602A885 RID: 174213 RVA: 0x005CD04A File Offset: 0x005CB24A
		public static void StartIWuWaGoEntityBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A886 RID: 174214 RVA: 0x005CD053 File Offset: 0x005CB253
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A887 RID: 174215 RVA: 0x005CD05E File Offset: 0x005CB25E
		public static Offset<IWuWaGoEntityBase> EndIWuWaGoEntityBase(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoEntityBase>(builder.EndTable());
		}

		// Token: 0x0602A888 RID: 174216 RVA: 0x005CD06C File Offset: 0x005CB26C
		public IWuWaGoEntityBaseT UnPack()
		{
			IWuWaGoEntityBaseT wuWaGoEntityBaseT = new IWuWaGoEntityBaseT();
			this.UnPackTo(wuWaGoEntityBaseT);
			return wuWaGoEntityBaseT;
		}

		// Token: 0x0602A889 RID: 174217 RVA: 0x005CD087 File Offset: 0x005CB287
		public void UnPackTo(IWuWaGoEntityBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A88A RID: 174218 RVA: 0x005CD098 File Offset: 0x005CB298
		public static Offset<IWuWaGoEntityBase> Pack(FlatBufferBuilder builder, IWuWaGoEntityBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoEntityBase>);
			}
			return IWuWaGoEntityBase.CreateIWuWaGoEntityBase(builder, _o.Type);
		}

		// Token: 0x04010011 RID: 65553
		private Table __p;
	}
}

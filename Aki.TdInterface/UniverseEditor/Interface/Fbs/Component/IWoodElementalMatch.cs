using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619F RID: 24991
	public struct IWoodElementalMatch : IFlatbufferObject
	{
		// Token: 0x1700BA5D RID: 47709
		// (get) Token: 0x0602A793 RID: 173971 RVA: 0x005CB20F File Offset: 0x005C940F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A794 RID: 173972 RVA: 0x005CB21C File Offset: 0x005C941C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A795 RID: 173973 RVA: 0x005CB224 File Offset: 0x005C9424
		public static IWoodElementalMatch GetRootAsIWoodElementalMatch(ByteBuffer _bb)
		{
			return IWoodElementalMatch.GetRootAsIWoodElementalMatch(_bb, default(IWoodElementalMatch));
		}

		// Token: 0x0602A796 RID: 173974 RVA: 0x005CB240 File Offset: 0x005C9440
		public static IWoodElementalMatch GetRootAsIWoodElementalMatch(ByteBuffer _bb, IWoodElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A797 RID: 173975 RVA: 0x005CB25D File Offset: 0x005C945D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A798 RID: 173976 RVA: 0x005CB26C File Offset: 0x005C946C
		public IWoodElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA5E RID: 47710
		// (get) Token: 0x0602A799 RID: 173977 RVA: 0x005CB27C File Offset: 0x005C947C
		public EElementalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A79A RID: 173978 RVA: 0x005CB2B8 File Offset: 0x005C94B8
		public static Offset<IWoodElementalMatch> CreateIWoodElementalMatch(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IWoodElementalMatch.AddType(builder, Type);
			return IWoodElementalMatch.EndIWoodElementalMatch(builder);
		}

		// Token: 0x0602A79B RID: 173979 RVA: 0x005CB2CE File Offset: 0x005C94CE
		public static void StartIWoodElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A79C RID: 173980 RVA: 0x005CB2D7 File Offset: 0x005C94D7
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A79D RID: 173981 RVA: 0x005CB2E2 File Offset: 0x005C94E2
		public static Offset<IWoodElementalMatch> EndIWoodElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IWoodElementalMatch>(builder.EndTable());
		}

		// Token: 0x0602A79E RID: 173982 RVA: 0x005CB2F0 File Offset: 0x005C94F0
		public IWoodElementalMatchT UnPack()
		{
			IWoodElementalMatchT woodElementalMatchT = new IWoodElementalMatchT();
			this.UnPackTo(woodElementalMatchT);
			return woodElementalMatchT;
		}

		// Token: 0x0602A79F RID: 173983 RVA: 0x005CB30B File Offset: 0x005C950B
		public void UnPackTo(IWoodElementalMatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A7A0 RID: 173984 RVA: 0x005CB31C File Offset: 0x005C951C
		public static Offset<IWoodElementalMatch> Pack(FlatBufferBuilder builder, IWoodElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodElementalMatch>);
			}
			return IWoodElementalMatch.CreateIWoodElementalMatch(builder, _o.Type);
		}

		// Token: 0x0400FFED RID: 65517
		private Table __p;
	}
}

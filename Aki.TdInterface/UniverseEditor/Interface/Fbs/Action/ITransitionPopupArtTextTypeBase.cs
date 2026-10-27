using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743F RID: 29759
	public struct ITransitionPopupArtTextTypeBase : IFlatbufferObject
	{
		// Token: 0x1700E1F3 RID: 57843
		// (get) Token: 0x06036102 RID: 221442 RVA: 0x0075A6EC File Offset: 0x007588EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036103 RID: 221443 RVA: 0x0075A6F9 File Offset: 0x007588F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036104 RID: 221444 RVA: 0x0075A700 File Offset: 0x00758900
		public static ITransitionPopupArtTextTypeBase GetRootAsITransitionPopupArtTextTypeBase(ByteBuffer _bb)
		{
			return ITransitionPopupArtTextTypeBase.GetRootAsITransitionPopupArtTextTypeBase(_bb, default(ITransitionPopupArtTextTypeBase));
		}

		// Token: 0x06036105 RID: 221445 RVA: 0x0075A71C File Offset: 0x0075891C
		public static ITransitionPopupArtTextTypeBase GetRootAsITransitionPopupArtTextTypeBase(ByteBuffer _bb, ITransitionPopupArtTextTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036106 RID: 221446 RVA: 0x0075A739 File Offset: 0x00758939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036107 RID: 221447 RVA: 0x0075A748 File Offset: 0x00758948
		public ITransitionPopupArtTextTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1F4 RID: 57844
		// (get) Token: 0x06036108 RID: 221448 RVA: 0x0075A758 File Offset: 0x00758958
		public ETransitionPopupArtTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupArtTextType.YuanCheng;
				}
				return (ETransitionPopupArtTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036109 RID: 221449 RVA: 0x0075A794 File Offset: 0x00758994
		public static Offset<ITransitionPopupArtTextTypeBase> CreateITransitionPopupArtTextTypeBase(FlatBufferBuilder builder, ETransitionPopupArtTextType Type = ETransitionPopupArtTextType.YuanCheng)
		{
			builder.StartTable(1);
			ITransitionPopupArtTextTypeBase.AddType(builder, Type);
			return ITransitionPopupArtTextTypeBase.EndITransitionPopupArtTextTypeBase(builder);
		}

		// Token: 0x0603610A RID: 221450 RVA: 0x0075A7AA File Offset: 0x007589AA
		public static void StartITransitionPopupArtTextTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603610B RID: 221451 RVA: 0x0075A7B3 File Offset: 0x007589B3
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupArtTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603610C RID: 221452 RVA: 0x0075A7BE File Offset: 0x007589BE
		public static Offset<ITransitionPopupArtTextTypeBase> EndITransitionPopupArtTextTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupArtTextTypeBase>(builder.EndTable());
		}

		// Token: 0x0603610D RID: 221453 RVA: 0x0075A7CC File Offset: 0x007589CC
		public ITransitionPopupArtTextTypeBaseT UnPack()
		{
			ITransitionPopupArtTextTypeBaseT transitionPopupArtTextTypeBaseT = new ITransitionPopupArtTextTypeBaseT();
			this.UnPackTo(transitionPopupArtTextTypeBaseT);
			return transitionPopupArtTextTypeBaseT;
		}

		// Token: 0x0603610E RID: 221454 RVA: 0x0075A7E7 File Offset: 0x007589E7
		public void UnPackTo(ITransitionPopupArtTextTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603610F RID: 221455 RVA: 0x0075A7F8 File Offset: 0x007589F8
		public static Offset<ITransitionPopupArtTextTypeBase> Pack(FlatBufferBuilder builder, ITransitionPopupArtTextTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupArtTextTypeBase>);
			}
			return ITransitionPopupArtTextTypeBase.CreateITransitionPopupArtTextTypeBase(builder, _o.Type);
		}

		// Token: 0x040122BE RID: 74430
		private Table __p;
	}
}

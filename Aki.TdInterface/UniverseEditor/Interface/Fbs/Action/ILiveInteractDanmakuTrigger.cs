using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FD RID: 28925
	public struct ILiveInteractDanmakuTrigger : IFlatbufferObject
	{
		// Token: 0x1700D3D6 RID: 54230
		// (get) Token: 0x060323C9 RID: 205769 RVA: 0x006CB694 File Offset: 0x006C9894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323CA RID: 205770 RVA: 0x006CB6A1 File Offset: 0x006C98A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323CB RID: 205771 RVA: 0x006CB6A8 File Offset: 0x006C98A8
		public static ILiveInteractDanmakuTrigger GetRootAsILiveInteractDanmakuTrigger(ByteBuffer _bb)
		{
			return ILiveInteractDanmakuTrigger.GetRootAsILiveInteractDanmakuTrigger(_bb, default(ILiveInteractDanmakuTrigger));
		}

		// Token: 0x060323CC RID: 205772 RVA: 0x006CB6C4 File Offset: 0x006C98C4
		public static ILiveInteractDanmakuTrigger GetRootAsILiveInteractDanmakuTrigger(ByteBuffer _bb, ILiveInteractDanmakuTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323CD RID: 205773 RVA: 0x006CB6E1 File Offset: 0x006C98E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323CE RID: 205774 RVA: 0x006CB6F0 File Offset: 0x006C98F0
		public ILiveInteractDanmakuTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3D7 RID: 54231
		// (get) Token: 0x060323CF RID: 205775 RVA: 0x006CB700 File Offset: 0x006C9900
		public ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return (ELiveInteractDanmakuTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060323D0 RID: 205776 RVA: 0x006CB73C File Offset: 0x006C993C
		public static Offset<ILiveInteractDanmakuTrigger> CreateILiveInteractDanmakuTrigger(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType Type = ELiveInteractDanmakuTriggerType.SkillGenre)
		{
			builder.StartTable(1);
			ILiveInteractDanmakuTrigger.AddType(builder, Type);
			return ILiveInteractDanmakuTrigger.EndILiveInteractDanmakuTrigger(builder);
		}

		// Token: 0x060323D1 RID: 205777 RVA: 0x006CB752 File Offset: 0x006C9952
		public static void StartILiveInteractDanmakuTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060323D2 RID: 205778 RVA: 0x006CB75B File Offset: 0x006C995B
		public static void AddType(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060323D3 RID: 205779 RVA: 0x006CB766 File Offset: 0x006C9966
		public static Offset<ILiveInteractDanmakuTrigger> EndILiveInteractDanmakuTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractDanmakuTrigger>(builder.EndTable());
		}

		// Token: 0x060323D4 RID: 205780 RVA: 0x006CB774 File Offset: 0x006C9974
		public ILiveInteractDanmakuTriggerT UnPack()
		{
			ILiveInteractDanmakuTriggerT liveInteractDanmakuTriggerT = new ILiveInteractDanmakuTriggerT();
			this.UnPackTo(liveInteractDanmakuTriggerT);
			return liveInteractDanmakuTriggerT;
		}

		// Token: 0x060323D5 RID: 205781 RVA: 0x006CB78F File Offset: 0x006C998F
		public void UnPackTo(ILiveInteractDanmakuTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060323D6 RID: 205782 RVA: 0x006CB7A0 File Offset: 0x006C99A0
		public static Offset<ILiveInteractDanmakuTrigger> Pack(FlatBufferBuilder builder, ILiveInteractDanmakuTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractDanmakuTrigger>);
			}
			return ILiveInteractDanmakuTrigger.CreateILiveInteractDanmakuTrigger(builder, _o.Type);
		}

		// Token: 0x040120D0 RID: 73936
		private Table __p;
	}
}

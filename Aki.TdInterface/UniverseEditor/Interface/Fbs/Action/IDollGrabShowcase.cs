using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006603 RID: 26115
	public struct IDollGrabShowcase : IFlatbufferObject
	{
		// Token: 0x1700C207 RID: 49671
		// (get) Token: 0x0602D575 RID: 185717 RVA: 0x00636DE5 File Offset: 0x00634FE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D576 RID: 185718 RVA: 0x00636DF2 File Offset: 0x00634FF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D577 RID: 185719 RVA: 0x00636DFC File Offset: 0x00634FFC
		public static IDollGrabShowcase GetRootAsIDollGrabShowcase(ByteBuffer _bb)
		{
			return IDollGrabShowcase.GetRootAsIDollGrabShowcase(_bb, default(IDollGrabShowcase));
		}

		// Token: 0x0602D578 RID: 185720 RVA: 0x00636E18 File Offset: 0x00635018
		public static IDollGrabShowcase GetRootAsIDollGrabShowcase(ByteBuffer _bb, IDollGrabShowcase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D579 RID: 185721 RVA: 0x00636E35 File Offset: 0x00635035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D57A RID: 185722 RVA: 0x00636E44 File Offset: 0x00635044
		public IDollGrabShowcase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C208 RID: 49672
		// (get) Token: 0x0602D57B RID: 185723 RVA: 0x00636E54 File Offset: 0x00635054
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C209 RID: 49673
		// (get) Token: 0x0602D57C RID: 185724 RVA: 0x00636E90 File Offset: 0x00635090
		public int ShowcaseEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D57D RID: 185725 RVA: 0x00636ECC File Offset: 0x006350CC
		public static Offset<IDollGrabShowcase> CreateIDollGrabShowcase(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int ShowcaseEntityId = 0)
		{
			builder.StartTable(2);
			IDollGrabShowcase.AddShowcaseEntityId(builder, ShowcaseEntityId);
			IDollGrabShowcase.AddType(builder, Type);
			return IDollGrabShowcase.EndIDollGrabShowcase(builder);
		}

		// Token: 0x0602D57E RID: 185726 RVA: 0x00636EE9 File Offset: 0x006350E9
		public static void StartIDollGrabShowcase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D57F RID: 185727 RVA: 0x00636EF2 File Offset: 0x006350F2
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D580 RID: 185728 RVA: 0x00636EFD File Offset: 0x006350FD
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0602D581 RID: 185729 RVA: 0x00636F08 File Offset: 0x00635108
		public static Offset<IDollGrabShowcase> EndIDollGrabShowcase(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcase>(builder.EndTable());
		}

		// Token: 0x0602D582 RID: 185730 RVA: 0x00636F18 File Offset: 0x00635118
		public IDollGrabShowcaseT UnPack()
		{
			IDollGrabShowcaseT dollGrabShowcaseT = new IDollGrabShowcaseT();
			this.UnPackTo(dollGrabShowcaseT);
			return dollGrabShowcaseT;
		}

		// Token: 0x0602D583 RID: 185731 RVA: 0x00636F33 File Offset: 0x00635133
		public void UnPackTo(IDollGrabShowcaseT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
		}

		// Token: 0x0602D584 RID: 185732 RVA: 0x00636F50 File Offset: 0x00635150
		public static Offset<IDollGrabShowcase> Pack(FlatBufferBuilder builder, IDollGrabShowcaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabShowcase>);
			}
			return IDollGrabShowcase.CreateIDollGrabShowcase(builder, _o.Type, _o.ShowcaseEntityId);
		}

		// Token: 0x04010C87 RID: 68743
		private Table __p;
	}
}

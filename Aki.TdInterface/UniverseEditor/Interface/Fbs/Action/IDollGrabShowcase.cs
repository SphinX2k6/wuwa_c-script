using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C74 RID: 27764
	public struct IDollGrabShowcase : IFlatbufferObject
	{
		// Token: 0x1700CBA5 RID: 52133
		// (get) Token: 0x0602FD46 RID: 195910 RVA: 0x0068394D File Offset: 0x00681B4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD47 RID: 195911 RVA: 0x0068395A File Offset: 0x00681B5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD48 RID: 195912 RVA: 0x00683964 File Offset: 0x00681B64
		public static IDollGrabShowcase GetRootAsIDollGrabShowcase(ByteBuffer _bb)
		{
			return IDollGrabShowcase.GetRootAsIDollGrabShowcase(_bb, default(IDollGrabShowcase));
		}

		// Token: 0x0602FD49 RID: 195913 RVA: 0x00683980 File Offset: 0x00681B80
		public static IDollGrabShowcase GetRootAsIDollGrabShowcase(ByteBuffer _bb, IDollGrabShowcase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD4A RID: 195914 RVA: 0x0068399D File Offset: 0x00681B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD4B RID: 195915 RVA: 0x006839AC File Offset: 0x00681BAC
		public IDollGrabShowcase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBA6 RID: 52134
		// (get) Token: 0x0602FD4C RID: 195916 RVA: 0x006839BC File Offset: 0x00681BBC
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

		// Token: 0x1700CBA7 RID: 52135
		// (get) Token: 0x0602FD4D RID: 195917 RVA: 0x006839F8 File Offset: 0x00681BF8
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

		// Token: 0x0602FD4E RID: 195918 RVA: 0x00683A34 File Offset: 0x00681C34
		public static Offset<IDollGrabShowcase> CreateIDollGrabShowcase(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int ShowcaseEntityId = 0)
		{
			builder.StartTable(2);
			IDollGrabShowcase.AddShowcaseEntityId(builder, ShowcaseEntityId);
			IDollGrabShowcase.AddType(builder, Type);
			return IDollGrabShowcase.EndIDollGrabShowcase(builder);
		}

		// Token: 0x0602FD4F RID: 195919 RVA: 0x00683A51 File Offset: 0x00681C51
		public static void StartIDollGrabShowcase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FD50 RID: 195920 RVA: 0x00683A5A File Offset: 0x00681C5A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD51 RID: 195921 RVA: 0x00683A65 File Offset: 0x00681C65
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0602FD52 RID: 195922 RVA: 0x00683A70 File Offset: 0x00681C70
		public static Offset<IDollGrabShowcase> EndIDollGrabShowcase(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcase>(builder.EndTable());
		}

		// Token: 0x0602FD53 RID: 195923 RVA: 0x00683A80 File Offset: 0x00681C80
		public IDollGrabShowcaseT UnPack()
		{
			IDollGrabShowcaseT dollGrabShowcaseT = new IDollGrabShowcaseT();
			this.UnPackTo(dollGrabShowcaseT);
			return dollGrabShowcaseT;
		}

		// Token: 0x0602FD54 RID: 195924 RVA: 0x00683A9B File Offset: 0x00681C9B
		public void UnPackTo(IDollGrabShowcaseT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
		}

		// Token: 0x0602FD55 RID: 195925 RVA: 0x00683AB8 File Offset: 0x00681CB8
		public static Offset<IDollGrabShowcase> Pack(FlatBufferBuilder builder, IDollGrabShowcaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabShowcase>);
			}
			return IDollGrabShowcase.CreateIDollGrabShowcase(builder, _o.Type, _o.ShowcaseEntityId);
		}

		// Token: 0x04011AA2 RID: 72354
		private Table __p;
	}
}

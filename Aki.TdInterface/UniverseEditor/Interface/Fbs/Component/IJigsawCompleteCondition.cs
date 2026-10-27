using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A0 RID: 21664
	public struct IJigsawCompleteCondition : IFlatbufferObject
	{
		// Token: 0x17009F85 RID: 40837
		// (get) Token: 0x06023A86 RID: 146054 RVA: 0x004EDFE2 File Offset: 0x004EC1E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A87 RID: 146055 RVA: 0x004EDFEF File Offset: 0x004EC1EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A88 RID: 146056 RVA: 0x004EDFF8 File Offset: 0x004EC1F8
		public static IJigsawCompleteCondition GetRootAsIJigsawCompleteCondition(ByteBuffer _bb)
		{
			return IJigsawCompleteCondition.GetRootAsIJigsawCompleteCondition(_bb, default(IJigsawCompleteCondition));
		}

		// Token: 0x06023A89 RID: 146057 RVA: 0x004EE014 File Offset: 0x004EC214
		public static IJigsawCompleteCondition GetRootAsIJigsawCompleteCondition(ByteBuffer _bb, IJigsawCompleteCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A8A RID: 146058 RVA: 0x004EE031 File Offset: 0x004EC231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A8B RID: 146059 RVA: 0x004EE040 File Offset: 0x004EC240
		public IJigsawCompleteCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F86 RID: 40838
		// (get) Token: 0x06023A8C RID: 146060 RVA: 0x004EE050 File Offset: 0x004EC250
		public EJigsawCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return (EJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A8D RID: 146061 RVA: 0x004EE08C File Offset: 0x004EC28C
		public static Offset<IJigsawCompleteCondition> CreateIJigsawCompleteCondition(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece)
		{
			builder.StartTable(1);
			IJigsawCompleteCondition.AddType(builder, Type);
			return IJigsawCompleteCondition.EndIJigsawCompleteCondition(builder);
		}

		// Token: 0x06023A8E RID: 146062 RVA: 0x004EE0A2 File Offset: 0x004EC2A2
		public static void StartIJigsawCompleteCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023A8F RID: 146063 RVA: 0x004EE0AB File Offset: 0x004EC2AB
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023A90 RID: 146064 RVA: 0x004EE0B6 File Offset: 0x004EC2B6
		public static Offset<IJigsawCompleteCondition> EndIJigsawCompleteCondition(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawCompleteCondition>(builder.EndTable());
		}

		// Token: 0x06023A91 RID: 146065 RVA: 0x004EE0C4 File Offset: 0x004EC2C4
		public IJigsawCompleteConditionT UnPack()
		{
			IJigsawCompleteConditionT jigsawCompleteConditionT = new IJigsawCompleteConditionT();
			this.UnPackTo(jigsawCompleteConditionT);
			return jigsawCompleteConditionT;
		}

		// Token: 0x06023A92 RID: 146066 RVA: 0x004EE0DF File Offset: 0x004EC2DF
		public void UnPackTo(IJigsawCompleteConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023A93 RID: 146067 RVA: 0x004EE0F0 File Offset: 0x004EC2F0
		public static Offset<IJigsawCompleteCondition> Pack(FlatBufferBuilder builder, IJigsawCompleteConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawCompleteCondition>);
			}
			return IJigsawCompleteCondition.CreateIJigsawCompleteCondition(builder, _o.Type);
		}

		// Token: 0x0400E73C RID: 59196
		private Table __p;
	}
}

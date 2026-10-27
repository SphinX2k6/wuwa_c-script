using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A2 RID: 4258
	[NetMessage(EMessageId.RoleQuestNewUnlockNotify)]
	public sealed class RoleQuestNewUnlockNotify : IMessage<RoleQuestNewUnlockNotify>, IMessage, IEquatable<RoleQuestNewUnlockNotify>, IDeepCloneable<RoleQuestNewUnlockNotify>, IBufferMessage
	{
		// Token: 0x06016BD8 RID: 93144 RVA: 0x0034E079 File Offset: 0x0034C279
		[NullableContext(1)]
		public static RoleQuestNewUnlockNotify Create()
		{
			return new RoleQuestNewUnlockNotify();
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x06016BD9 RID: 93145 RVA: 0x0034E080 File Offset: 0x0034C280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x06016BDA RID: 93146 RVA: 0x0034E083 File Offset: 0x0034C283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestNewUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06016BDB RID: 93147 RVA: 0x0034E08A File Offset: 0x0034C28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify()
		{
		}

		// Token: 0x06016BDC RID: 93148 RVA: 0x0034E09D File Offset: 0x0034C29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify(RoleQuestNewUnlockNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BDD RID: 93149 RVA: 0x0034E0C7 File Offset: 0x0034C2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify Clone()
		{
			return new RoleQuestNewUnlockNotify(this);
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x06016BDE RID: 93150 RVA: 0x0034E0CF File Offset: 0x0034C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06016BDF RID: 93151 RVA: 0x0034E0D7 File Offset: 0x0034C2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestNewUnlockNotify);
		}

		// Token: 0x06016BE0 RID: 93152 RVA: 0x0034E0E5 File Offset: 0x0034C2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestNewUnlockNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x0034E118 File Offset: 0x0034C318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016BE2 RID: 93154 RVA: 0x0034E14C File Offset: 0x0034C34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BE3 RID: 93155 RVA: 0x0034E159 File Offset: 0x0034C359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BE4 RID: 93156 RVA: 0x0034E162 File Offset: 0x0034C362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, RoleQuestNewUnlockNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x0034E18C File Offset: 0x0034C38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(RoleQuestNewUnlockNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x0034E1C5 File Offset: 0x0034C3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestNewUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x0034E1F3 File Offset: 0x0034C3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x0034E1FC File Offset: 0x0034C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, RoleQuestNewUnlockNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040087D0 RID: 34768
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087D1 RID: 34769
		public const int QuestIdsFieldNumber = 5;

		// Token: 0x040087D2 RID: 34770
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040087D3 RID: 34771
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F0 RID: 2288
	[NetMessage(EMessageId.LeaveQuestRecallNotify)]
	public sealed class LeaveQuestRecallNotify : IMessage<LeaveQuestRecallNotify>, IMessage, IEquatable<LeaveQuestRecallNotify>, IDeepCloneable<LeaveQuestRecallNotify>, IBufferMessage
	{
		// Token: 0x0600CA46 RID: 51782 RVA: 0x001DDB3D File Offset: 0x001DBD3D
		[NullableContext(1)]
		public static LeaveQuestRecallNotify Create()
		{
			return new LeaveQuestRecallNotify();
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600CA47 RID: 51783 RVA: 0x001DDB44 File Offset: 0x001DBD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x001DDB47 File Offset: 0x001DBD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveQuestRecallNotify.Descriptor;
			}
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x001DDB4E File Offset: 0x001DBD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify()
		{
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x001DDB61 File Offset: 0x001DBD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify(LeaveQuestRecallNotify other) : this()
		{
			this.destroyRecallQuestIds_ = other.destroyRecallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x001DDB8B File Offset: 0x001DBD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify Clone()
		{
			return new LeaveQuestRecallNotify(this);
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600CA4C RID: 51788 RVA: 0x001DDB93 File Offset: 0x001DBD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DestroyRecallQuestIds
		{
			get
			{
				return this.destroyRecallQuestIds_;
			}
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x001DDB9B File Offset: 0x001DBD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveQuestRecallNotify);
		}

		// Token: 0x0600CA4E RID: 51790 RVA: 0x001DDBA9 File Offset: 0x001DBDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveQuestRecallNotify other)
		{
			return other != null && (other == this || (this.destroyRecallQuestIds_.Equals(other.destroyRecallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x001DDBDC File Offset: 0x001DBDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.destroyRecallQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x001DDC10 File Offset: 0x001DBE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x001DDC1D File Offset: 0x001DBE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x001DDC26 File Offset: 0x001DBE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.destroyRecallQuestIds_.WriteTo(ref output, LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x001DDC50 File Offset: 0x001DBE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.destroyRecallQuestIds_.CalculateSize(LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA54 RID: 51796 RVA: 0x001DDC89 File Offset: 0x001DBE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveQuestRecallNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.destroyRecallQuestIds_.Add(other.destroyRecallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x001DDCB7 File Offset: 0x001DBEB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x001DDCC0 File Offset: 0x001DBEC0
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.destroyRecallQuestIds_.AddEntriesFrom(ref input, LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
				}
			}
		}

		// Token: 0x0400561B RID: 22043
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400561C RID: 22044
		public const int DestroyRecallQuestIdsFieldNumber = 2;

		// Token: 0x0400561D RID: 22045
		private static readonly FieldCodec<int> _repeated_destroyRecallQuestIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400561E RID: 22046
		private readonly RepeatedField<int> destroyRecallQuestIds_ = new RepeatedField<int>();
	}
}

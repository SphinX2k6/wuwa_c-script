using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001167 RID: 4455
	[NetMessage(EMessageId.RoverRogueTalentUnlockNotify)]
	public sealed class RoverRogueTalentUnlockNotify : IMessage<RoverRogueTalentUnlockNotify>, IMessage, IEquatable<RoverRogueTalentUnlockNotify>, IDeepCloneable<RoverRogueTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06017CF1 RID: 97521 RVA: 0x003779E2 File Offset: 0x00375BE2
		[NullableContext(1)]
		public static RoverRogueTalentUnlockNotify Create()
		{
			return new RoverRogueTalentUnlockNotify();
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x06017CF2 RID: 97522 RVA: 0x003779E9 File Offset: 0x00375BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x06017CF3 RID: 97523 RVA: 0x003779EC File Offset: 0x00375BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06017CF4 RID: 97524 RVA: 0x003779F3 File Offset: 0x00375BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify()
		{
		}

		// Token: 0x06017CF5 RID: 97525 RVA: 0x00377A06 File Offset: 0x00375C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify(RoverRogueTalentUnlockNotify other) : this()
		{
			this.talentIds_ = other.talentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CF6 RID: 97526 RVA: 0x00377A30 File Offset: 0x00375C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify Clone()
		{
			return new RoverRogueTalentUnlockNotify(this);
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x06017CF7 RID: 97527 RVA: 0x00377A38 File Offset: 0x00375C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TalentIds
		{
			get
			{
				return this.talentIds_;
			}
		}

		// Token: 0x06017CF8 RID: 97528 RVA: 0x00377A40 File Offset: 0x00375C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockNotify);
		}

		// Token: 0x06017CF9 RID: 97529 RVA: 0x00377A4E File Offset: 0x00375C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.talentIds_.Equals(other.talentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CFA RID: 97530 RVA: 0x00377A84 File Offset: 0x00375C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.talentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017CFB RID: 97531 RVA: 0x00377AB8 File Offset: 0x00375CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CFC RID: 97532 RVA: 0x00377AC5 File Offset: 0x00375CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CFD RID: 97533 RVA: 0x00377ACE File Offset: 0x00375CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talentIds_.WriteTo(ref output, RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CFE RID: 97534 RVA: 0x00377AF8 File Offset: 0x00375CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talentIds_.CalculateSize(RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017CFF RID: 97535 RVA: 0x00377B31 File Offset: 0x00375D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.talentIds_.Add(other.talentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D00 RID: 97536 RVA: 0x00377B5F File Offset: 0x00375D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D01 RID: 97537 RVA: 0x00377B68 File Offset: 0x00375D68
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.talentIds_.AddEntriesFrom(ref input, RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
				}
			}
		}

		// Token: 0x04008E16 RID: 36374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E17 RID: 36375
		public const int TalentIdsFieldNumber = 7;

		// Token: 0x04008E18 RID: 36376
		private static readonly FieldCodec<int> _repeated_talentIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008E19 RID: 36377
		private readonly RepeatedField<int> talentIds_ = new RepeatedField<int>();
	}
}

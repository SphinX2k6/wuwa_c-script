using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B18 RID: 2840
	[NetMessage(EMessageId.NewJourneyResponse)]
	public sealed class NewJourneyResponse : IMessage<NewJourneyResponse>, IMessage, IEquatable<NewJourneyResponse>, IDeepCloneable<NewJourneyResponse>, IBufferMessage
	{
		// Token: 0x0600F698 RID: 63128 RVA: 0x0023F511 File Offset: 0x0023D711
		[NullableContext(1)]
		public static NewJourneyResponse Create()
		{
			return new NewJourneyResponse();
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600F699 RID: 63129 RVA: 0x0023F518 File Offset: 0x0023D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600F69A RID: 63130 RVA: 0x0023F51B File Offset: 0x0023D71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyResponse.Descriptor;
			}
		}

		// Token: 0x0600F69B RID: 63131 RVA: 0x0023F522 File Offset: 0x0023D722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse()
		{
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x0023F535 File Offset: 0x0023D735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse(NewJourneyResponse other) : this()
		{
			this.newJourneyTask_ = other.newJourneyTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x0023F55F File Offset: 0x0023D75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse Clone()
		{
			return new NewJourneyResponse(this);
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600F69E RID: 63134 RVA: 0x0023F567 File Offset: 0x0023D767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewJourneyTask> NewJourneyTask
		{
			get
			{
				return this.newJourneyTask_;
			}
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x0023F56F File Offset: 0x0023D76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyResponse);
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x0023F57D File Offset: 0x0023D77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyResponse other)
		{
			return other != null && (other == this || (this.newJourneyTask_.Equals(other.newJourneyTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6A1 RID: 63137 RVA: 0x0023F5B0 File Offset: 0x0023D7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.newJourneyTask_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F6A2 RID: 63138 RVA: 0x0023F5E4 File Offset: 0x0023D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6A3 RID: 63139 RVA: 0x0023F5F1 File Offset: 0x0023D7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6A4 RID: 63140 RVA: 0x0023F5FA File Offset: 0x0023D7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.newJourneyTask_.WriteTo(ref output, NewJourneyResponse._repeated_newJourneyTask_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6A5 RID: 63141 RVA: 0x0023F624 File Offset: 0x0023D824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.newJourneyTask_.CalculateSize(NewJourneyResponse._repeated_newJourneyTask_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F6A6 RID: 63142 RVA: 0x0023F65D File Offset: 0x0023D85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewJourneyResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.newJourneyTask_.Add(other.newJourneyTask_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x0023F68B File Offset: 0x0023D88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0023F694 File Offset: 0x0023D894
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.newJourneyTask_.AddEntriesFrom(ref input, NewJourneyResponse._repeated_newJourneyTask_codec);
				}
			}
		}

		// Token: 0x04006300 RID: 25344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006301 RID: 25345
		public const int NewJourneyTaskFieldNumber = 9;

		// Token: 0x04006302 RID: 25346
		private static readonly FieldCodec<NewJourneyTask> _repeated_newJourneyTask_codec = FieldCodec.ForMessage<NewJourneyTask>(74U, Aki.Protocol.NewJourneyTask.Parser);

		// Token: 0x04006303 RID: 25347
		private readonly RepeatedField<NewJourneyTask> newJourneyTask_ = new RepeatedField<NewJourneyTask>();
	}
}

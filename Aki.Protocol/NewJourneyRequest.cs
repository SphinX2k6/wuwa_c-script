using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B17 RID: 2839
	[NetMessage(EMessageId.NewJourneyRequest)]
	public sealed class NewJourneyRequest : IMessage<NewJourneyRequest>, IMessage, IEquatable<NewJourneyRequest>, IDeepCloneable<NewJourneyRequest>, IBufferMessage
	{
		// Token: 0x0600F686 RID: 63110 RVA: 0x0023F32F File Offset: 0x0023D52F
		[NullableContext(1)]
		public static NewJourneyRequest Create()
		{
			return new NewJourneyRequest();
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600F687 RID: 63111 RVA: 0x0023F336 File Offset: 0x0023D536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600F688 RID: 63112 RVA: 0x0023F339 File Offset: 0x0023D539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyRequest.Descriptor;
			}
		}

		// Token: 0x0600F689 RID: 63113 RVA: 0x0023F340 File Offset: 0x0023D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest()
		{
		}

		// Token: 0x0600F68A RID: 63114 RVA: 0x0023F353 File Offset: 0x0023D553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest(NewJourneyRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F68B RID: 63115 RVA: 0x0023F37D File Offset: 0x0023D57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest Clone()
		{
			return new NewJourneyRequest(this);
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600F68C RID: 63116 RVA: 0x0023F385 File Offset: 0x0023D585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x0023F38D File Offset: 0x0023D58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyRequest);
		}

		// Token: 0x0600F68E RID: 63118 RVA: 0x0023F39B File Offset: 0x0023D59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F68F RID: 63119 RVA: 0x0023F3D0 File Offset: 0x0023D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x0023F404 File Offset: 0x0023D604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x0023F411 File Offset: 0x0023D611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x0023F41A File Offset: 0x0023D61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, NewJourneyRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F693 RID: 63123 RVA: 0x0023F444 File Offset: 0x0023D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(NewJourneyRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x0023F47D File Offset: 0x0023D67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewJourneyRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F695 RID: 63125 RVA: 0x0023F4AB File Offset: 0x0023D6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F696 RID: 63126 RVA: 0x0023F4B4 File Offset: 0x0023D6B4
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, NewJourneyRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040062FC RID: 25340
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062FD RID: 25341
		public const int TaskIdsFieldNumber = 11;

		// Token: 0x040062FE RID: 25342
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040062FF RID: 25343
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}

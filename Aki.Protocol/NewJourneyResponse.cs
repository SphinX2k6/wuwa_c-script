using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B07 RID: 2823
	[NetMessage(EMessageId.NewJourneyResponse)]
	public sealed class NewJourneyResponse : IMessage<NewJourneyResponse>, IMessage, IEquatable<NewJourneyResponse>, IDeepCloneable<NewJourneyResponse>, IBufferMessage
	{
		// Token: 0x0600F57E RID: 62846 RVA: 0x0023D2FD File Offset: 0x0023B4FD
		[NullableContext(1)]
		public static NewJourneyResponse Create()
		{
			return new NewJourneyResponse();
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600F57F RID: 62847 RVA: 0x0023D304 File Offset: 0x0023B504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600F580 RID: 62848 RVA: 0x0023D307 File Offset: 0x0023B507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyResponse.Descriptor;
			}
		}

		// Token: 0x0600F581 RID: 62849 RVA: 0x0023D30E File Offset: 0x0023B50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse()
		{
		}

		// Token: 0x0600F582 RID: 62850 RVA: 0x0023D321 File Offset: 0x0023B521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse(NewJourneyResponse other) : this()
		{
			this.newJourneyTask_ = other.newJourneyTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F583 RID: 62851 RVA: 0x0023D34B File Offset: 0x0023B54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyResponse Clone()
		{
			return new NewJourneyResponse(this);
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600F584 RID: 62852 RVA: 0x0023D353 File Offset: 0x0023B553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewJourneyTask> NewJourneyTask
		{
			get
			{
				return this.newJourneyTask_;
			}
		}

		// Token: 0x0600F585 RID: 62853 RVA: 0x0023D35B File Offset: 0x0023B55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyResponse);
		}

		// Token: 0x0600F586 RID: 62854 RVA: 0x0023D369 File Offset: 0x0023B569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyResponse other)
		{
			return other != null && (other == this || (this.newJourneyTask_.Equals(other.newJourneyTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F587 RID: 62855 RVA: 0x0023D39C File Offset: 0x0023B59C
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

		// Token: 0x0600F588 RID: 62856 RVA: 0x0023D3D0 File Offset: 0x0023B5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F589 RID: 62857 RVA: 0x0023D3DD File Offset: 0x0023B5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F58A RID: 62858 RVA: 0x0023D3E6 File Offset: 0x0023B5E6
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

		// Token: 0x0600F58B RID: 62859 RVA: 0x0023D410 File Offset: 0x0023B610
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

		// Token: 0x0600F58C RID: 62860 RVA: 0x0023D449 File Offset: 0x0023B649
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

		// Token: 0x0600F58D RID: 62861 RVA: 0x0023D477 File Offset: 0x0023B677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F58E RID: 62862 RVA: 0x0023D480 File Offset: 0x0023B680
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.newJourneyTask_.AddEntriesFrom(ref input, NewJourneyResponse._repeated_newJourneyTask_codec);
				}
			}
		}

		// Token: 0x04006309 RID: 25353
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400630A RID: 25354
		public const int NewJourneyTaskFieldNumber = 1;

		// Token: 0x0400630B RID: 25355
		private static readonly FieldCodec<NewJourneyTask> _repeated_newJourneyTask_codec = FieldCodec.ForMessage<NewJourneyTask>(10U, Aki.Protocol.NewJourneyTask.Parser);

		// Token: 0x0400630C RID: 25356
		private readonly RepeatedField<NewJourneyTask> newJourneyTask_ = new RepeatedField<NewJourneyTask>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B06 RID: 2822
	[NetMessage(EMessageId.NewJourneyRequest)]
	public sealed class NewJourneyRequest : IMessage<NewJourneyRequest>, IMessage, IEquatable<NewJourneyRequest>, IDeepCloneable<NewJourneyRequest>, IBufferMessage
	{
		// Token: 0x0600F56C RID: 62828 RVA: 0x0023D11B File Offset: 0x0023B31B
		[NullableContext(1)]
		public static NewJourneyRequest Create()
		{
			return new NewJourneyRequest();
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600F56D RID: 62829 RVA: 0x0023D122 File Offset: 0x0023B322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600F56E RID: 62830 RVA: 0x0023D125 File Offset: 0x0023B325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyRequest.Descriptor;
			}
		}

		// Token: 0x0600F56F RID: 62831 RVA: 0x0023D12C File Offset: 0x0023B32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest()
		{
		}

		// Token: 0x0600F570 RID: 62832 RVA: 0x0023D13F File Offset: 0x0023B33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest(NewJourneyRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F571 RID: 62833 RVA: 0x0023D169 File Offset: 0x0023B369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyRequest Clone()
		{
			return new NewJourneyRequest(this);
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600F572 RID: 62834 RVA: 0x0023D171 File Offset: 0x0023B371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F573 RID: 62835 RVA: 0x0023D179 File Offset: 0x0023B379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyRequest);
		}

		// Token: 0x0600F574 RID: 62836 RVA: 0x0023D187 File Offset: 0x0023B387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F575 RID: 62837 RVA: 0x0023D1BC File Offset: 0x0023B3BC
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

		// Token: 0x0600F576 RID: 62838 RVA: 0x0023D1F0 File Offset: 0x0023B3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F577 RID: 62839 RVA: 0x0023D1FD File Offset: 0x0023B3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F578 RID: 62840 RVA: 0x0023D206 File Offset: 0x0023B406
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

		// Token: 0x0600F579 RID: 62841 RVA: 0x0023D230 File Offset: 0x0023B430
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

		// Token: 0x0600F57A RID: 62842 RVA: 0x0023D269 File Offset: 0x0023B469
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

		// Token: 0x0600F57B RID: 62843 RVA: 0x0023D297 File Offset: 0x0023B497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F57C RID: 62844 RVA: 0x0023D2A0 File Offset: 0x0023B4A0
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, NewJourneyRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04006305 RID: 25349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006306 RID: 25350
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x04006307 RID: 25351
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006308 RID: 25352
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}

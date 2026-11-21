using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B10 RID: 2832
	[NetMessage(EMessageId.NewPlayerSupportRewardTaskRequest)]
	public sealed class NewPlayerSupportRewardTaskRequest : IMessage<NewPlayerSupportRewardTaskRequest>, IMessage, IEquatable<NewPlayerSupportRewardTaskRequest>, IDeepCloneable<NewPlayerSupportRewardTaskRequest>, IBufferMessage
	{
		// Token: 0x0600F644 RID: 63044 RVA: 0x0023F18C File Offset: 0x0023D38C
		[NullableContext(1)]
		public static NewPlayerSupportRewardTaskRequest Create()
		{
			return new NewPlayerSupportRewardTaskRequest();
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600F645 RID: 63045 RVA: 0x0023F193 File Offset: 0x0023D393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600F646 RID: 63046 RVA: 0x0023F196 File Offset: 0x0023D396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportRewardTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x0023F19D File Offset: 0x0023D39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest()
		{
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x0023F1B0 File Offset: 0x0023D3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest(NewPlayerSupportRewardTaskRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F649 RID: 63049 RVA: 0x0023F1DA File Offset: 0x0023D3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest Clone()
		{
			return new NewPlayerSupportRewardTaskRequest(this);
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600F64A RID: 63050 RVA: 0x0023F1E2 File Offset: 0x0023D3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F64B RID: 63051 RVA: 0x0023F1EA File Offset: 0x0023D3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportRewardTaskRequest);
		}

		// Token: 0x0600F64C RID: 63052 RVA: 0x0023F1F8 File Offset: 0x0023D3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportRewardTaskRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F64D RID: 63053 RVA: 0x0023F22C File Offset: 0x0023D42C
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

		// Token: 0x0600F64E RID: 63054 RVA: 0x0023F260 File Offset: 0x0023D460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x0023F26D File Offset: 0x0023D46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F650 RID: 63056 RVA: 0x0023F276 File Offset: 0x0023D476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, NewPlayerSupportRewardTaskRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x0023F2A0 File Offset: 0x0023D4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(NewPlayerSupportRewardTaskRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F652 RID: 63058 RVA: 0x0023F2D9 File Offset: 0x0023D4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportRewardTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F653 RID: 63059 RVA: 0x0023F307 File Offset: 0x0023D507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F654 RID: 63060 RVA: 0x0023F310 File Offset: 0x0023D510
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
					this.taskIds_.AddEntriesFrom(ref input, NewPlayerSupportRewardTaskRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04006351 RID: 25425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006352 RID: 25426
		public const int TaskIdsFieldNumber = 11;

		// Token: 0x04006353 RID: 25427
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006354 RID: 25428
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}

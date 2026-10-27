using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B21 RID: 2849
	[NetMessage(EMessageId.NewPlayerSupportRewardTaskRequest)]
	public sealed class NewPlayerSupportRewardTaskRequest : IMessage<NewPlayerSupportRewardTaskRequest>, IMessage, IEquatable<NewPlayerSupportRewardTaskRequest>, IDeepCloneable<NewPlayerSupportRewardTaskRequest>, IBufferMessage
	{
		// Token: 0x0600F75E RID: 63326 RVA: 0x002413A4 File Offset: 0x0023F5A4
		[NullableContext(1)]
		public static NewPlayerSupportRewardTaskRequest Create()
		{
			return new NewPlayerSupportRewardTaskRequest();
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600F75F RID: 63327 RVA: 0x002413AB File Offset: 0x0023F5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600F760 RID: 63328 RVA: 0x002413AE File Offset: 0x0023F5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportRewardTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600F761 RID: 63329 RVA: 0x002413B5 File Offset: 0x0023F5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest()
		{
		}

		// Token: 0x0600F762 RID: 63330 RVA: 0x002413C8 File Offset: 0x0023F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest(NewPlayerSupportRewardTaskRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F763 RID: 63331 RVA: 0x002413F2 File Offset: 0x0023F5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskRequest Clone()
		{
			return new NewPlayerSupportRewardTaskRequest(this);
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600F764 RID: 63332 RVA: 0x002413FA File Offset: 0x0023F5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F765 RID: 63333 RVA: 0x00241402 File Offset: 0x0023F602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportRewardTaskRequest);
		}

		// Token: 0x0600F766 RID: 63334 RVA: 0x00241410 File Offset: 0x0023F610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportRewardTaskRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F767 RID: 63335 RVA: 0x00241444 File Offset: 0x0023F644
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

		// Token: 0x0600F768 RID: 63336 RVA: 0x00241478 File Offset: 0x0023F678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F769 RID: 63337 RVA: 0x00241485 File Offset: 0x0023F685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F76A RID: 63338 RVA: 0x0024148E File Offset: 0x0023F68E
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

		// Token: 0x0600F76B RID: 63339 RVA: 0x002414B8 File Offset: 0x0023F6B8
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

		// Token: 0x0600F76C RID: 63340 RVA: 0x002414F1 File Offset: 0x0023F6F1
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

		// Token: 0x0600F76D RID: 63341 RVA: 0x0024151F File Offset: 0x0023F71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F76E RID: 63342 RVA: 0x00241528 File Offset: 0x0023F728
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
					this.taskIds_.AddEntriesFrom(ref input, NewPlayerSupportRewardTaskRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04006348 RID: 25416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006349 RID: 25417
		public const int TaskIdsFieldNumber = 2;

		// Token: 0x0400634A RID: 25418
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400634B RID: 25419
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}

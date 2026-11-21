using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DE RID: 2014
	[NetMessage(EMessageId.InfrThemeActivityAwardRequest)]
	public sealed class InfrThemeActivityAwardRequest : IMessage<InfrThemeActivityAwardRequest>, IMessage, IEquatable<InfrThemeActivityAwardRequest>, IDeepCloneable<InfrThemeActivityAwardRequest>, IBufferMessage
	{
		// Token: 0x0600B508 RID: 46344 RVA: 0x001B0B1E File Offset: 0x001AED1E
		[NullableContext(1)]
		public static InfrThemeActivityAwardRequest Create()
		{
			return new InfrThemeActivityAwardRequest();
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600B509 RID: 46345 RVA: 0x001B0B25 File Offset: 0x001AED25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x001B0B28 File Offset: 0x001AED28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityAwardRequest.Descriptor;
			}
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x001B0B2F File Offset: 0x001AED2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest()
		{
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x001B0B42 File Offset: 0x001AED42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest(InfrThemeActivityAwardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x001B0B6C File Offset: 0x001AED6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest Clone()
		{
			return new InfrThemeActivityAwardRequest(this);
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600B50E RID: 46350 RVA: 0x001B0B74 File Offset: 0x001AED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x001B0B7C File Offset: 0x001AED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityAwardRequest);
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x001B0B8A File Offset: 0x001AED8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityAwardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x001B0BC0 File Offset: 0x001AEDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x001B0BF4 File Offset: 0x001AEDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x001B0C01 File Offset: 0x001AEE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x001B0C0A File Offset: 0x001AEE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, InfrThemeActivityAwardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x001B0C34 File Offset: 0x001AEE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(InfrThemeActivityAwardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x001B0C6D File Offset: 0x001AEE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrThemeActivityAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x001B0C9B File Offset: 0x001AEE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x001B0CA4 File Offset: 0x001AEEA4
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, InfrThemeActivityAwardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040050C1 RID: 20673
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050C2 RID: 20674
		public const int TaskIdFieldNumber = 15;

		// Token: 0x040050C3 RID: 20675
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040050C4 RID: 20676
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}

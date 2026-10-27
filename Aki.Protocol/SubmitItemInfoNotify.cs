using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A2 RID: 4770
	[NetMessage(EMessageId.SubmitItemInfoNotify)]
	public sealed class SubmitItemInfoNotify : IMessage<SubmitItemInfoNotify>, IMessage, IEquatable<SubmitItemInfoNotify>, IDeepCloneable<SubmitItemInfoNotify>, IBufferMessage
	{
		// Token: 0x06019634 RID: 103988 RVA: 0x003B0AC5 File Offset: 0x003AECC5
		[NullableContext(1)]
		public static SubmitItemInfoNotify Create()
		{
			return new SubmitItemInfoNotify();
		}

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x06019635 RID: 103989 RVA: 0x003B0ACC File Offset: 0x003AECCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x06019636 RID: 103990 RVA: 0x003B0ACF File Offset: 0x003AECCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitItemInfoNotify.Descriptor;
			}
		}

		// Token: 0x06019637 RID: 103991 RVA: 0x003B0AD6 File Offset: 0x003AECD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify()
		{
		}

		// Token: 0x06019638 RID: 103992 RVA: 0x003B0AE9 File Offset: 0x003AECE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify(SubmitItemInfoNotify other) : this()
		{
			this.gatherTaskSubmitInfos_ = other.gatherTaskSubmitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019639 RID: 103993 RVA: 0x003B0B13 File Offset: 0x003AED13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify Clone()
		{
			return new SubmitItemInfoNotify(this);
		}

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x0601963A RID: 103994 RVA: 0x003B0B1B File Offset: 0x003AED1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherTaskSubmitInfo> GatherTaskSubmitInfos
		{
			get
			{
				return this.gatherTaskSubmitInfos_;
			}
		}

		// Token: 0x0601963B RID: 103995 RVA: 0x003B0B23 File Offset: 0x003AED23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitItemInfoNotify);
		}

		// Token: 0x0601963C RID: 103996 RVA: 0x003B0B31 File Offset: 0x003AED31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitItemInfoNotify other)
		{
			return other != null && (other == this || (this.gatherTaskSubmitInfos_.Equals(other.gatherTaskSubmitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601963D RID: 103997 RVA: 0x003B0B64 File Offset: 0x003AED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gatherTaskSubmitInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601963E RID: 103998 RVA: 0x003B0B98 File Offset: 0x003AED98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601963F RID: 103999 RVA: 0x003B0BA5 File Offset: 0x003AEDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019640 RID: 104000 RVA: 0x003B0BAE File Offset: 0x003AEDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gatherTaskSubmitInfos_.WriteTo(ref output, SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019641 RID: 104001 RVA: 0x003B0BD8 File Offset: 0x003AEDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gatherTaskSubmitInfos_.CalculateSize(SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x003B0C11 File Offset: 0x003AEE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitItemInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gatherTaskSubmitInfos_.Add(other.gatherTaskSubmitInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019643 RID: 104003 RVA: 0x003B0C3F File Offset: 0x003AEE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x003B0C48 File Offset: 0x003AEE48
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
					this.gatherTaskSubmitInfos_.AddEntriesFrom(ref input, SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
				}
			}
		}

		// Token: 0x04009517 RID: 38167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009518 RID: 38168
		public const int GatherTaskSubmitInfosFieldNumber = 9;

		// Token: 0x04009519 RID: 38169
		private static readonly FieldCodec<GatherTaskSubmitInfo> _repeated_gatherTaskSubmitInfos_codec = FieldCodec.ForMessage<GatherTaskSubmitInfo>(74U, GatherTaskSubmitInfo.Parser);

		// Token: 0x0400951A RID: 38170
		private readonly RepeatedField<GatherTaskSubmitInfo> gatherTaskSubmitInfos_ = new RepeatedField<GatherTaskSubmitInfo>();
	}
}

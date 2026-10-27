using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000121 RID: 289
	public sealed class AttachMarkInfo : IMessage<AttachMarkInfo>, IMessage, IEquatable<AttachMarkInfo>, IDeepCloneable<AttachMarkInfo>, IBufferMessage
	{
		// Token: 0x060026FF RID: 9983 RVA: 0x000677C5 File Offset: 0x000659C5
		[NullableContext(1)]
		public static AttachMarkInfo Create()
		{
			return new AttachMarkInfo();
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000677CC File Offset: 0x000659CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000677CF File Offset: 0x000659CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachMarkInfo.Descriptor;
			}
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000677D6 File Offset: 0x000659D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo()
		{
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000677E9 File Offset: 0x000659E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo(AttachMarkInfo other) : this()
		{
			this.markPointInfo_ = other.markPointInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00067813 File Offset: 0x00065A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo Clone()
		{
			return new AttachMarkInfo(this);
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x0006781B File Offset: 0x00065A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> MarkPointInfo
		{
			get
			{
				return this.markPointInfo_;
			}
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00067823 File Offset: 0x00065A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachMarkInfo);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00067831 File Offset: 0x00065A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachMarkInfo other)
		{
			return other != null && (other == this || (this.markPointInfo_.Equals(other.markPointInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00067864 File Offset: 0x00065A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markPointInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00067898 File Offset: 0x00065A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000678A5 File Offset: 0x00065AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000678AE File Offset: 0x00065AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markPointInfo_.WriteTo(ref output, AttachMarkInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000678D8 File Offset: 0x00065AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markPointInfo_.CalculateSize(AttachMarkInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00067911 File Offset: 0x00065B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachMarkInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.markPointInfo_.Add(other.markPointInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0006793F File Offset: 0x00065B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00067948 File Offset: 0x00065B48
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
					this.markPointInfo_.AddEntriesFrom(ref input, AttachMarkInfo._repeated_markPointInfo_codec);
				}
			}
		}

		// Token: 0x04002643 RID: 9795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002644 RID: 9796
		public const int MarkPointInfoFieldNumber = 1;

		// Token: 0x04002645 RID: 9797
		private static readonly FieldCodec<MarkPointInfo> _repeated_markPointInfo_codec = FieldCodec.ForMessage<MarkPointInfo>(10U, Aki.Protocol.MarkPointInfo.Parser);

		// Token: 0x04002646 RID: 9798
		private readonly RepeatedField<MarkPointInfo> markPointInfo_ = new RepeatedField<MarkPointInfo>();
	}
}

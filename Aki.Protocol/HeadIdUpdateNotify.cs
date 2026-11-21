using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000739 RID: 1849
	[NetMessage(EMessageId.HeadIdUpdateNotify)]
	public sealed class HeadIdUpdateNotify : IMessage<HeadIdUpdateNotify>, IMessage, IEquatable<HeadIdUpdateNotify>, IDeepCloneable<HeadIdUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A7E4 RID: 42980 RVA: 0x00194473 File Offset: 0x00192673
		[NullableContext(1)]
		public static HeadIdUpdateNotify Create()
		{
			return new HeadIdUpdateNotify();
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x0019447A File Offset: 0x0019267A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x0600A7E6 RID: 42982 RVA: 0x0019447D File Offset: 0x0019267D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeadIdUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x00194484 File Offset: 0x00192684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify()
		{
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x0019448C File Offset: 0x0019268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify(HeadIdUpdateNotify other) : this()
		{
			this.headId_ = other.headId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x001944B1 File Offset: 0x001926B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify Clone()
		{
			return new HeadIdUpdateNotify(this);
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x0600A7EA RID: 42986 RVA: 0x001944B9 File Offset: 0x001926B9
		// (set) Token: 0x0600A7EB RID: 42987 RVA: 0x001944C1 File Offset: 0x001926C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x001944CA File Offset: 0x001926CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeadIdUpdateNotify);
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x001944D8 File Offset: 0x001926D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeadIdUpdateNotify other)
		{
			return other != null && (other == this || (this.HeadId == other.HeadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x00194508 File Offset: 0x00192708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x00194547 File Offset: 0x00192747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x00194554 File Offset: 0x00192754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x0019455D File Offset: 0x0019275D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x00194590 File Offset: 0x00192790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x001945CE File Offset: 0x001927CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeadIdUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x001945FF File Offset: 0x001927FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x00194608 File Offset: 0x00192808
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D08 RID: 19720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D09 RID: 19721
		public const int HeadIdFieldNumber = 5;

		// Token: 0x04004D0A RID: 19722
		private int headId_;
	}
}

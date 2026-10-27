using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074D RID: 1869
	[NetMessage(EMessageId.HeadIdUpdateNotify)]
	public sealed class HeadIdUpdateNotify : IMessage<HeadIdUpdateNotify>, IMessage, IEquatable<HeadIdUpdateNotify>, IDeepCloneable<HeadIdUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A93A RID: 43322 RVA: 0x00196E9F File Offset: 0x0019509F
		[NullableContext(1)]
		public static HeadIdUpdateNotify Create()
		{
			return new HeadIdUpdateNotify();
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600A93B RID: 43323 RVA: 0x00196EA6 File Offset: 0x001950A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600A93C RID: 43324 RVA: 0x00196EA9 File Offset: 0x001950A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeadIdUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x00196EB0 File Offset: 0x001950B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify()
		{
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x00196EB8 File Offset: 0x001950B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify(HeadIdUpdateNotify other) : this()
		{
			this.headId_ = other.headId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x00196EDD File Offset: 0x001950DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeadIdUpdateNotify Clone()
		{
			return new HeadIdUpdateNotify(this);
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600A940 RID: 43328 RVA: 0x00196EE5 File Offset: 0x001950E5
		// (set) Token: 0x0600A941 RID: 43329 RVA: 0x00196EED File Offset: 0x001950ED
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

		// Token: 0x0600A942 RID: 43330 RVA: 0x00196EF6 File Offset: 0x001950F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeadIdUpdateNotify);
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x00196F04 File Offset: 0x00195104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeadIdUpdateNotify other)
		{
			return other != null && (other == this || (this.HeadId == other.HeadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x00196F34 File Offset: 0x00195134
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

		// Token: 0x0600A945 RID: 43333 RVA: 0x00196F73 File Offset: 0x00195173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x00196F80 File Offset: 0x00195180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x00196F89 File Offset: 0x00195189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x00196FBC File Offset: 0x001951BC
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

		// Token: 0x0600A949 RID: 43337 RVA: 0x00196FFA File Offset: 0x001951FA
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

		// Token: 0x0600A94A RID: 43338 RVA: 0x0019702B File Offset: 0x0019522B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A94B RID: 43339 RVA: 0x00197034 File Offset: 0x00195234
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D0F RID: 19727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D10 RID: 19728
		public const int HeadIdFieldNumber = 2;

		// Token: 0x04004D11 RID: 19729
		private int headId_;
	}
}

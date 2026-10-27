using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074F RID: 1871
	[NetMessage(EMessageId.HeartbeatResponse)]
	public sealed class HeartbeatResponse : IMessage<HeartbeatResponse>, IMessage, IEquatable<HeartbeatResponse>, IDeepCloneable<HeartbeatResponse>, IBufferMessage
	{
		// Token: 0x0600A95E RID: 43358 RVA: 0x00197281 File Offset: 0x00195481
		[NullableContext(1)]
		public static HeartbeatResponse Create()
		{
			return new HeartbeatResponse();
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600A95F RID: 43359 RVA: 0x00197288 File Offset: 0x00195488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600A960 RID: 43360 RVA: 0x0019728B File Offset: 0x0019548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartbeatResponse.Descriptor;
			}
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x00197292 File Offset: 0x00195492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse()
		{
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x0019729A File Offset: 0x0019549A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse(HeartbeatResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x001972B3 File Offset: 0x001954B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse Clone()
		{
			return new HeartbeatResponse(this);
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x001972BB File Offset: 0x001954BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartbeatResponse);
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x001972C9 File Offset: 0x001954C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartbeatResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x001972E8 File Offset: 0x001954E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x0019730E File Offset: 0x0019550E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x0019731B File Offset: 0x0019551B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x00197324 File Offset: 0x00195524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x0019733C File Offset: 0x0019553C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x00197362 File Offset: 0x00195562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartbeatResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x0019737F File Offset: 0x0019557F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x00197388 File Offset: 0x00195588
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D15 RID: 19733
		private UnknownFieldSet _unknownFields;
	}
}

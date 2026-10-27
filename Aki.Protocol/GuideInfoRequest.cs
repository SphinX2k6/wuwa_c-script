using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000726 RID: 1830
	[NetMessage(EMessageId.GuideInfoRequest)]
	public sealed class GuideInfoRequest : IMessage<GuideInfoRequest>, IMessage, IEquatable<GuideInfoRequest>, IDeepCloneable<GuideInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A63A RID: 42554 RVA: 0x00190D2D File Offset: 0x0018EF2D
		[NullableContext(1)]
		public static GuideInfoRequest Create()
		{
			return new GuideInfoRequest();
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x00190D34 File Offset: 0x0018EF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x00190D37 File Offset: 0x0018EF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x00190D3E File Offset: 0x0018EF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest()
		{
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x00190D46 File Offset: 0x0018EF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest(GuideInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x00190D5F File Offset: 0x0018EF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoRequest Clone()
		{
			return new GuideInfoRequest(this);
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x00190D67 File Offset: 0x0018EF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideInfoRequest);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x00190D75 File Offset: 0x0018EF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00190D94 File Offset: 0x0018EF94
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

		// Token: 0x0600A643 RID: 42563 RVA: 0x00190DBA File Offset: 0x0018EFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x00190DC7 File Offset: 0x0018EFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x00190DD0 File Offset: 0x0018EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x00190DE8 File Offset: 0x0018EFE8
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

		// Token: 0x0600A647 RID: 42567 RVA: 0x00190E0E File Offset: 0x0018F00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x00190E2B File Offset: 0x0018F02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x00190E34 File Offset: 0x0018F034
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

		// Token: 0x04004C4D RID: 19533
		private UnknownFieldSet _unknownFields;
	}
}

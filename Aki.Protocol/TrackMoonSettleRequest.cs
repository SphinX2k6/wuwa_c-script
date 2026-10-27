using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EA RID: 5098
	[NetMessage(EMessageId.TrackMoonSettleRequest)]
	public sealed class TrackMoonSettleRequest : IMessage<TrackMoonSettleRequest>, IMessage, IEquatable<TrackMoonSettleRequest>, IDeepCloneable<TrackMoonSettleRequest>, IBufferMessage
	{
		// Token: 0x0601B043 RID: 110659 RVA: 0x003E9829 File Offset: 0x003E7A29
		[NullableContext(1)]
		public static TrackMoonSettleRequest Create()
		{
			return new TrackMoonSettleRequest();
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x0601B044 RID: 110660 RVA: 0x003E9830 File Offset: 0x003E7A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x0601B045 RID: 110661 RVA: 0x003E9833 File Offset: 0x003E7A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonSettleRequest.Descriptor;
			}
		}

		// Token: 0x0601B046 RID: 110662 RVA: 0x003E983A File Offset: 0x003E7A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest()
		{
		}

		// Token: 0x0601B047 RID: 110663 RVA: 0x003E9842 File Offset: 0x003E7A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest(TrackMoonSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B048 RID: 110664 RVA: 0x003E985B File Offset: 0x003E7A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest Clone()
		{
			return new TrackMoonSettleRequest(this);
		}

		// Token: 0x0601B049 RID: 110665 RVA: 0x003E9863 File Offset: 0x003E7A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonSettleRequest);
		}

		// Token: 0x0601B04A RID: 110666 RVA: 0x003E9871 File Offset: 0x003E7A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B04B RID: 110667 RVA: 0x003E9890 File Offset: 0x003E7A90
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

		// Token: 0x0601B04C RID: 110668 RVA: 0x003E98B6 File Offset: 0x003E7AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B04D RID: 110669 RVA: 0x003E98C3 File Offset: 0x003E7AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B04E RID: 110670 RVA: 0x003E98CC File Offset: 0x003E7ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B04F RID: 110671 RVA: 0x003E98E4 File Offset: 0x003E7AE4
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

		// Token: 0x0601B050 RID: 110672 RVA: 0x003E990A File Offset: 0x003E7B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B051 RID: 110673 RVA: 0x003E9927 File Offset: 0x003E7B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B052 RID: 110674 RVA: 0x003E9930 File Offset: 0x003E7B30
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

		// Token: 0x04009C62 RID: 40034
		private UnknownFieldSet _unknownFields;
	}
}

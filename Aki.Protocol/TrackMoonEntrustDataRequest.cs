using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E2 RID: 5090
	[NetMessage(EMessageId.TrackMoonEntrustDataRequest)]
	public sealed class TrackMoonEntrustDataRequest : IMessage<TrackMoonEntrustDataRequest>, IMessage, IEquatable<TrackMoonEntrustDataRequest>, IDeepCloneable<TrackMoonEntrustDataRequest>, IBufferMessage
	{
		// Token: 0x0601AFB7 RID: 110519 RVA: 0x003E8A6F File Offset: 0x003E6C6F
		[NullableContext(1)]
		public static TrackMoonEntrustDataRequest Create()
		{
			return new TrackMoonEntrustDataRequest();
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x0601AFB8 RID: 110520 RVA: 0x003E8A76 File Offset: 0x003E6C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x0601AFB9 RID: 110521 RVA: 0x003E8A79 File Offset: 0x003E6C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonEntrustDataRequest.Descriptor;
			}
		}

		// Token: 0x0601AFBA RID: 110522 RVA: 0x003E8A80 File Offset: 0x003E6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest()
		{
		}

		// Token: 0x0601AFBB RID: 110523 RVA: 0x003E8A88 File Offset: 0x003E6C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest(TrackMoonEntrustDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFBC RID: 110524 RVA: 0x003E8AA1 File Offset: 0x003E6CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest Clone()
		{
			return new TrackMoonEntrustDataRequest(this);
		}

		// Token: 0x0601AFBD RID: 110525 RVA: 0x003E8AA9 File Offset: 0x003E6CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonEntrustDataRequest);
		}

		// Token: 0x0601AFBE RID: 110526 RVA: 0x003E8AB7 File Offset: 0x003E6CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonEntrustDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AFBF RID: 110527 RVA: 0x003E8AD8 File Offset: 0x003E6CD8
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

		// Token: 0x0601AFC0 RID: 110528 RVA: 0x003E8AFE File Offset: 0x003E6CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFC1 RID: 110529 RVA: 0x003E8B0B File Offset: 0x003E6D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFC2 RID: 110530 RVA: 0x003E8B14 File Offset: 0x003E6D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFC3 RID: 110531 RVA: 0x003E8B2C File Offset: 0x003E6D2C
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

		// Token: 0x0601AFC4 RID: 110532 RVA: 0x003E8B52 File Offset: 0x003E6D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonEntrustDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFC5 RID: 110533 RVA: 0x003E8B6F File Offset: 0x003E6D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFC6 RID: 110534 RVA: 0x003E8B78 File Offset: 0x003E6D78
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

		// Token: 0x04009C48 RID: 40008
		private UnknownFieldSet _unknownFields;
	}
}

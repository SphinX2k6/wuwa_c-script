using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DB RID: 987
	[NetMessage(EMessageId.DollGrabPauseStartRequest)]
	public sealed class DollGrabPauseStartRequest : IMessage<DollGrabPauseStartRequest>, IMessage, IEquatable<DollGrabPauseStartRequest>, IDeepCloneable<DollGrabPauseStartRequest>, IBufferMessage
	{
		// Token: 0x06006043 RID: 24643 RVA: 0x000E8C19 File Offset: 0x000E6E19
		[NullableContext(1)]
		public static DollGrabPauseStartRequest Create()
		{
			return new DollGrabPauseStartRequest();
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x000E8C20 File Offset: 0x000E6E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x000E8C23 File Offset: 0x000E6E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseStartRequest.Descriptor;
			}
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x000E8C2A File Offset: 0x000E6E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest()
		{
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x000E8C32 File Offset: 0x000E6E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest(DollGrabPauseStartRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x000E8C57 File Offset: 0x000E6E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest Clone()
		{
			return new DollGrabPauseStartRequest(this);
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x000E8C5F File Offset: 0x000E6E5F
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x000E8C67 File Offset: 0x000E6E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x000E8C70 File Offset: 0x000E6E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseStartRequest);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x000E8C7E File Offset: 0x000E6E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseStartRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x000E8CAC File Offset: 0x000E6EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x000E8CEB File Offset: 0x000E6EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x000E8D01 File Offset: 0x000E6F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x000E8D34 File Offset: 0x000E6F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x000E8D72 File Offset: 0x000E6F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x000E8DA3 File Offset: 0x000E6FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x000E8DAC File Offset: 0x000E6FAC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037A1 RID: 14241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A2 RID: 14242
		public const int EntityIncIdFieldNumber = 4;

		// Token: 0x040037A3 RID: 14243
		private long entityIncId_;
	}
}

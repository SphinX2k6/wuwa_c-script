using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F7 RID: 1015
	[NetMessage(EMessageId.DollGrabStopRequest)]
	public sealed class DollGrabStopRequest : IMessage<DollGrabStopRequest>, IMessage, IEquatable<DollGrabStopRequest>, IDeepCloneable<DollGrabStopRequest>, IBufferMessage
	{
		// Token: 0x06006231 RID: 25137 RVA: 0x000EC880 File Offset: 0x000EAA80
		[NullableContext(1)]
		public static DollGrabStopRequest Create()
		{
			return new DollGrabStopRequest();
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x000EC887 File Offset: 0x000EAA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x000EC88A File Offset: 0x000EAA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabStopRequest.Descriptor;
			}
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x000EC891 File Offset: 0x000EAA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest()
		{
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x000EC899 File Offset: 0x000EAA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest(DollGrabStopRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x000EC8BE File Offset: 0x000EAABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest Clone()
		{
			return new DollGrabStopRequest(this);
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x000EC8C6 File Offset: 0x000EAAC6
		// (set) Token: 0x06006238 RID: 25144 RVA: 0x000EC8CE File Offset: 0x000EAACE
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

		// Token: 0x06006239 RID: 25145 RVA: 0x000EC8D7 File Offset: 0x000EAAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabStopRequest);
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x000EC8E5 File Offset: 0x000EAAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabStopRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x000EC914 File Offset: 0x000EAB14
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

		// Token: 0x0600623C RID: 25148 RVA: 0x000EC953 File Offset: 0x000EAB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x000EC960 File Offset: 0x000EAB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x000EC969 File Offset: 0x000EAB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x000EC99C File Offset: 0x000EAB9C
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

		// Token: 0x06006240 RID: 25152 RVA: 0x000EC9DA File Offset: 0x000EABDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabStopRequest other)
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

		// Token: 0x06006241 RID: 25153 RVA: 0x000ECA0B File Offset: 0x000EAC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x000ECA14 File Offset: 0x000EAC14
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037C9 RID: 14281
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037CA RID: 14282
		public const int EntityIncIdFieldNumber = 6;

		// Token: 0x040037CB RID: 14283
		private long entityIncId_;
	}
}

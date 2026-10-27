using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EC RID: 1004
	[NetMessage(EMessageId.DollGarbStartRequest)]
	public sealed class DollGarbStartRequest : IMessage<DollGarbStartRequest>, IMessage, IEquatable<DollGarbStartRequest>, IDeepCloneable<DollGarbStartRequest>, IBufferMessage
	{
		// Token: 0x0600615F RID: 24927 RVA: 0x000EB015 File Offset: 0x000E9215
		[NullableContext(1)]
		public static DollGarbStartRequest Create()
		{
			return new DollGarbStartRequest();
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x000EB01C File Offset: 0x000E921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06006161 RID: 24929 RVA: 0x000EB01F File Offset: 0x000E921F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbStartRequest.Descriptor;
			}
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x000EB026 File Offset: 0x000E9226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest()
		{
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x000EB02E File Offset: 0x000E922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest(DollGarbStartRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x000EB053 File Offset: 0x000E9253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest Clone()
		{
			return new DollGarbStartRequest(this);
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06006165 RID: 24933 RVA: 0x000EB05B File Offset: 0x000E925B
		// (set) Token: 0x06006166 RID: 24934 RVA: 0x000EB063 File Offset: 0x000E9263
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

		// Token: 0x06006167 RID: 24935 RVA: 0x000EB06C File Offset: 0x000E926C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbStartRequest);
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x000EB07A File Offset: 0x000E927A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbStartRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x000EB0A8 File Offset: 0x000E92A8
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

		// Token: 0x0600616A RID: 24938 RVA: 0x000EB0E7 File Offset: 0x000E92E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x000EB0F4 File Offset: 0x000E92F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x000EB0FD File Offset: 0x000E92FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x000EB130 File Offset: 0x000E9330
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

		// Token: 0x0600616E RID: 24942 RVA: 0x000EB16E File Offset: 0x000E936E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbStartRequest other)
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

		// Token: 0x0600616F RID: 24943 RVA: 0x000EB19F File Offset: 0x000E939F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x000EB1A8 File Offset: 0x000E93A8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400379A RID: 14234
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379B RID: 14235
		public const int EntityIncIdFieldNumber = 11;

		// Token: 0x0400379C RID: 14236
		private long entityIncId_;
	}
}

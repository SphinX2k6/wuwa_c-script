using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000287 RID: 647
	[NetMessage(EMessageId.CheckGearRequest)]
	public sealed class CheckGearRequest : IMessage<CheckGearRequest>, IMessage, IEquatable<CheckGearRequest>, IDeepCloneable<CheckGearRequest>, IBufferMessage
	{
		// Token: 0x060043EB RID: 17387 RVA: 0x000A6D5B File Offset: 0x000A4F5B
		[NullableContext(1)]
		public static CheckGearRequest Create()
		{
			return new CheckGearRequest();
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x000A6D62 File Offset: 0x000A4F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x000A6D65 File Offset: 0x000A4F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckGearRequest.Descriptor;
			}
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x000A6D6C File Offset: 0x000A4F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest()
		{
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x000A6D74 File Offset: 0x000A4F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest(CheckGearRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x000A6D99 File Offset: 0x000A4F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest Clone()
		{
			return new CheckGearRequest(this);
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x000A6DA1 File Offset: 0x000A4FA1
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x000A6DA9 File Offset: 0x000A4FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000A6DB2 File Offset: 0x000A4FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckGearRequest);
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x000A6DC0 File Offset: 0x000A4FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckGearRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000A6E2F File Offset: 0x000A502F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000A6E3C File Offset: 0x000A503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x000A6E45 File Offset: 0x000A5045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000A6E78 File Offset: 0x000A5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x000A6EB6 File Offset: 0x000A50B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckGearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x000A6EE7 File Offset: 0x000A50E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000A6EF0 File Offset: 0x000A50F0
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002ED1 RID: 11985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED2 RID: 11986
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04002ED3 RID: 11987
		private long entityId_;
	}
}

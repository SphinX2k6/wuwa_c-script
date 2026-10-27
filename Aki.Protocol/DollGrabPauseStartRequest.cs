using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F2 RID: 1010
	[NetMessage(EMessageId.DollGrabPauseStartRequest)]
	public sealed class DollGrabPauseStartRequest : IMessage<DollGrabPauseStartRequest>, IMessage, IEquatable<DollGrabPauseStartRequest>, IDeepCloneable<DollGrabPauseStartRequest>, IBufferMessage
	{
		// Token: 0x060061D3 RID: 25043 RVA: 0x000EBD99 File Offset: 0x000E9F99
		[NullableContext(1)]
		public static DollGrabPauseStartRequest Create()
		{
			return new DollGrabPauseStartRequest();
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x000EBDA0 File Offset: 0x000E9FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x000EBDA3 File Offset: 0x000E9FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseStartRequest.Descriptor;
			}
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x000EBDAA File Offset: 0x000E9FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest()
		{
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x000EBDB2 File Offset: 0x000E9FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest(DollGrabPauseStartRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x000EBDD7 File Offset: 0x000E9FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartRequest Clone()
		{
			return new DollGrabPauseStartRequest(this);
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x000EBDDF File Offset: 0x000E9FDF
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x000EBDE7 File Offset: 0x000E9FE7
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

		// Token: 0x060061DB RID: 25051 RVA: 0x000EBDF0 File Offset: 0x000E9FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseStartRequest);
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x000EBDFE File Offset: 0x000E9FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseStartRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x000EBE2C File Offset: 0x000EA02C
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

		// Token: 0x060061DE RID: 25054 RVA: 0x000EBE6B File Offset: 0x000EA06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x000EBE78 File Offset: 0x000EA078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x000EBE81 File Offset: 0x000EA081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x000EBEB4 File Offset: 0x000EA0B4
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

		// Token: 0x060061E2 RID: 25058 RVA: 0x000EBEF2 File Offset: 0x000EA0F2
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

		// Token: 0x060061E3 RID: 25059 RVA: 0x000EBF23 File Offset: 0x000EA123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x000EBF2C File Offset: 0x000EA12C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037B4 RID: 14260
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037B5 RID: 14261
		public const int EntityIncIdFieldNumber = 9;

		// Token: 0x040037B6 RID: 14262
		private long entityIncId_;
	}
}

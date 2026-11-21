using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F09 RID: 3849
	[NetMessage(EMessageId.RenjuResetRequest)]
	public sealed class RenjuResetRequest : IMessage<RenjuResetRequest>, IMessage, IEquatable<RenjuResetRequest>, IDeepCloneable<RenjuResetRequest>, IBufferMessage
	{
		// Token: 0x06014A1F RID: 84511 RVA: 0x002FF325 File Offset: 0x002FD525
		[NullableContext(1)]
		public static RenjuResetRequest Create()
		{
			return new RenjuResetRequest();
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x06014A20 RID: 84512 RVA: 0x002FF32C File Offset: 0x002FD52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700449A RID: 17562
		// (get) Token: 0x06014A21 RID: 84513 RVA: 0x002FF32F File Offset: 0x002FD52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuResetRequest.Descriptor;
			}
		}

		// Token: 0x06014A22 RID: 84514 RVA: 0x002FF336 File Offset: 0x002FD536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest()
		{
		}

		// Token: 0x06014A23 RID: 84515 RVA: 0x002FF33E File Offset: 0x002FD53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest(RenjuResetRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A24 RID: 84516 RVA: 0x002FF363 File Offset: 0x002FD563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest Clone()
		{
			return new RenjuResetRequest(this);
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x06014A25 RID: 84517 RVA: 0x002FF36B File Offset: 0x002FD56B
		// (set) Token: 0x06014A26 RID: 84518 RVA: 0x002FF373 File Offset: 0x002FD573
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

		// Token: 0x06014A27 RID: 84519 RVA: 0x002FF37C File Offset: 0x002FD57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuResetRequest);
		}

		// Token: 0x06014A28 RID: 84520 RVA: 0x002FF38A File Offset: 0x002FD58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuResetRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A29 RID: 84521 RVA: 0x002FF3B8 File Offset: 0x002FD5B8
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

		// Token: 0x06014A2A RID: 84522 RVA: 0x002FF3F7 File Offset: 0x002FD5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A2B RID: 84523 RVA: 0x002FF404 File Offset: 0x002FD604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A2C RID: 84524 RVA: 0x002FF40D File Offset: 0x002FD60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A2D RID: 84525 RVA: 0x002FF440 File Offset: 0x002FD640
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

		// Token: 0x06014A2E RID: 84526 RVA: 0x002FF47E File Offset: 0x002FD67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuResetRequest other)
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

		// Token: 0x06014A2F RID: 84527 RVA: 0x002FF4AF File Offset: 0x002FD6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A30 RID: 84528 RVA: 0x002FF4B8 File Offset: 0x002FD6B8
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D36 RID: 32054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D37 RID: 32055
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04007D38 RID: 32056
		private long entityId_;
	}
}

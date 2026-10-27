using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0E RID: 3854
	[NetMessage(EMessageId.RemoveTemporaryTeleportRequest)]
	public sealed class RemoveTemporaryTeleportRequest : IMessage<RemoveTemporaryTeleportRequest>, IMessage, IEquatable<RemoveTemporaryTeleportRequest>, IDeepCloneable<RemoveTemporaryTeleportRequest>, IBufferMessage
	{
		// Token: 0x06014A32 RID: 84530 RVA: 0x002FF121 File Offset: 0x002FD321
		[NullableContext(1)]
		public static RemoveTemporaryTeleportRequest Create()
		{
			return new RemoveTemporaryTeleportRequest();
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x06014A33 RID: 84531 RVA: 0x002FF128 File Offset: 0x002FD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x06014A34 RID: 84532 RVA: 0x002FF12B File Offset: 0x002FD32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06014A35 RID: 84533 RVA: 0x002FF132 File Offset: 0x002FD332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest()
		{
		}

		// Token: 0x06014A36 RID: 84534 RVA: 0x002FF13A File Offset: 0x002FD33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest(RemoveTemporaryTeleportRequest other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A37 RID: 84535 RVA: 0x002FF15F File Offset: 0x002FD35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest Clone()
		{
			return new RemoveTemporaryTeleportRequest(this);
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x06014A38 RID: 84536 RVA: 0x002FF167 File Offset: 0x002FD367
		// (set) Token: 0x06014A39 RID: 84537 RVA: 0x002FF16F File Offset: 0x002FD36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x06014A3A RID: 84538 RVA: 0x002FF178 File Offset: 0x002FD378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportRequest);
		}

		// Token: 0x06014A3B RID: 84539 RVA: 0x002FF186 File Offset: 0x002FD386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportRequest other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A3C RID: 84540 RVA: 0x002FF1B4 File Offset: 0x002FD3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A3D RID: 84541 RVA: 0x002FF1F3 File Offset: 0x002FD3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A3E RID: 84542 RVA: 0x002FF200 File Offset: 0x002FD400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A3F RID: 84543 RVA: 0x002FF209 File Offset: 0x002FD409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A40 RID: 84544 RVA: 0x002FF23C File Offset: 0x002FD43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A41 RID: 84545 RVA: 0x002FF27A File Offset: 0x002FD47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTemporaryTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A42 RID: 84546 RVA: 0x002FF2AB File Offset: 0x002FD4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A43 RID: 84547 RVA: 0x002FF2B4 File Offset: 0x002FD4B4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007CE0 RID: 31968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CE1 RID: 31969
		public const int TemporaryTeleportIdFieldNumber = 15;

		// Token: 0x04007CE2 RID: 31970
		private long temporaryTeleportId_;
	}
}

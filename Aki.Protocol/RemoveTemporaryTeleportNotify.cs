using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0D RID: 3853
	[NetMessage(EMessageId.RemoveTemporaryTeleportNotify)]
	public sealed class RemoveTemporaryTeleportNotify : IMessage<RemoveTemporaryTeleportNotify>, IMessage, IEquatable<RemoveTemporaryTeleportNotify>, IDeepCloneable<RemoveTemporaryTeleportNotify>, IBufferMessage
	{
		// Token: 0x06014A20 RID: 84512 RVA: 0x002FEF47 File Offset: 0x002FD147
		[NullableContext(1)]
		public static RemoveTemporaryTeleportNotify Create()
		{
			return new RemoveTemporaryTeleportNotify();
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x06014A21 RID: 84513 RVA: 0x002FEF4E File Offset: 0x002FD14E
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
		// (get) Token: 0x06014A22 RID: 84514 RVA: 0x002FEF51 File Offset: 0x002FD151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportNotify.Descriptor;
			}
		}

		// Token: 0x06014A23 RID: 84515 RVA: 0x002FEF58 File Offset: 0x002FD158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify()
		{
		}

		// Token: 0x06014A24 RID: 84516 RVA: 0x002FEF60 File Offset: 0x002FD160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify(RemoveTemporaryTeleportNotify other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A25 RID: 84517 RVA: 0x002FEF85 File Offset: 0x002FD185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify Clone()
		{
			return new RemoveTemporaryTeleportNotify(this);
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x06014A26 RID: 84518 RVA: 0x002FEF8D File Offset: 0x002FD18D
		// (set) Token: 0x06014A27 RID: 84519 RVA: 0x002FEF95 File Offset: 0x002FD195
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

		// Token: 0x06014A28 RID: 84520 RVA: 0x002FEF9E File Offset: 0x002FD19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportNotify);
		}

		// Token: 0x06014A29 RID: 84521 RVA: 0x002FEFAC File Offset: 0x002FD1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportNotify other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A2A RID: 84522 RVA: 0x002FEFDC File Offset: 0x002FD1DC
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

		// Token: 0x06014A2B RID: 84523 RVA: 0x002FF01B File Offset: 0x002FD21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A2C RID: 84524 RVA: 0x002FF028 File Offset: 0x002FD228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A2D RID: 84525 RVA: 0x002FF031 File Offset: 0x002FD231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A2E RID: 84526 RVA: 0x002FF064 File Offset: 0x002FD264
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

		// Token: 0x06014A2F RID: 84527 RVA: 0x002FF0A2 File Offset: 0x002FD2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTemporaryTeleportNotify other)
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

		// Token: 0x06014A30 RID: 84528 RVA: 0x002FF0D3 File Offset: 0x002FD2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A31 RID: 84529 RVA: 0x002FF0DC File Offset: 0x002FD2DC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007CDD RID: 31965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CDE RID: 31966
		public const int TemporaryTeleportIdFieldNumber = 2;

		// Token: 0x04007CDF RID: 31967
		private long temporaryTeleportId_;
	}
}

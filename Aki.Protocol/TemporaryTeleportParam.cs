using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BF RID: 5055
	public sealed class TemporaryTeleportParam : IMessage<TemporaryTeleportParam>, IMessage, IEquatable<TemporaryTeleportParam>, IDeepCloneable<TemporaryTeleportParam>, IBufferMessage
	{
		// Token: 0x0601AE7B RID: 110203 RVA: 0x003EB473 File Offset: 0x003E9673
		[NullableContext(1)]
		public static TemporaryTeleportParam Create()
		{
			return new TemporaryTeleportParam();
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x0601AE7C RID: 110204 RVA: 0x003EB47A File Offset: 0x003E967A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x0601AE7D RID: 110205 RVA: 0x003EB47D File Offset: 0x003E967D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportParam.Descriptor;
			}
		}

		// Token: 0x0601AE7E RID: 110206 RVA: 0x003EB484 File Offset: 0x003E9684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam()
		{
		}

		// Token: 0x0601AE7F RID: 110207 RVA: 0x003EB48C File Offset: 0x003E968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam(TemporaryTeleportParam other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE80 RID: 110208 RVA: 0x003EB4B1 File Offset: 0x003E96B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam Clone()
		{
			return new TemporaryTeleportParam(this);
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x0601AE81 RID: 110209 RVA: 0x003EB4B9 File Offset: 0x003E96B9
		// (set) Token: 0x0601AE82 RID: 110210 RVA: 0x003EB4C1 File Offset: 0x003E96C1
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

		// Token: 0x0601AE83 RID: 110211 RVA: 0x003EB4CA File Offset: 0x003E96CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportParam);
		}

		// Token: 0x0601AE84 RID: 110212 RVA: 0x003EB4D8 File Offset: 0x003E96D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportParam other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE85 RID: 110213 RVA: 0x003EB508 File Offset: 0x003E9708
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

		// Token: 0x0601AE86 RID: 110214 RVA: 0x003EB547 File Offset: 0x003E9747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE87 RID: 110215 RVA: 0x003EB554 File Offset: 0x003E9754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE88 RID: 110216 RVA: 0x003EB55D File Offset: 0x003E975D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE89 RID: 110217 RVA: 0x003EB590 File Offset: 0x003E9790
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

		// Token: 0x0601AE8A RID: 110218 RVA: 0x003EB5CE File Offset: 0x003E97CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportParam other)
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

		// Token: 0x0601AE8B RID: 110219 RVA: 0x003EB5FF File Offset: 0x003E97FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE8C RID: 110220 RVA: 0x003EB608 File Offset: 0x003E9808
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009D61 RID: 40289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D62 RID: 40290
		public const int TemporaryTeleportIdFieldNumber = 1;

		// Token: 0x04009D63 RID: 40291
		private long temporaryTeleportId_;
	}
}

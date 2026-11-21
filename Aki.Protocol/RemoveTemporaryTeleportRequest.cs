using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFE RID: 3838
	[NetMessage(EMessageId.RemoveTemporaryTeleportRequest)]
	public sealed class RemoveTemporaryTeleportRequest : IMessage<RemoveTemporaryTeleportRequest>, IMessage, IEquatable<RemoveTemporaryTeleportRequest>, IDeepCloneable<RemoveTemporaryTeleportRequest>, IBufferMessage
	{
		// Token: 0x0601494D RID: 84301 RVA: 0x002FDA65 File Offset: 0x002FBC65
		[NullableContext(1)]
		public static RemoveTemporaryTeleportRequest Create()
		{
			return new RemoveTemporaryTeleportRequest();
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x0601494E RID: 84302 RVA: 0x002FDA6C File Offset: 0x002FBC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x0601494F RID: 84303 RVA: 0x002FDA6F File Offset: 0x002FBC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06014950 RID: 84304 RVA: 0x002FDA76 File Offset: 0x002FBC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest()
		{
		}

		// Token: 0x06014951 RID: 84305 RVA: 0x002FDA7E File Offset: 0x002FBC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest(RemoveTemporaryTeleportRequest other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014952 RID: 84306 RVA: 0x002FDAA3 File Offset: 0x002FBCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportRequest Clone()
		{
			return new RemoveTemporaryTeleportRequest(this);
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x06014953 RID: 84307 RVA: 0x002FDAAB File Offset: 0x002FBCAB
		// (set) Token: 0x06014954 RID: 84308 RVA: 0x002FDAB3 File Offset: 0x002FBCB3
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

		// Token: 0x06014955 RID: 84309 RVA: 0x002FDABC File Offset: 0x002FBCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportRequest);
		}

		// Token: 0x06014956 RID: 84310 RVA: 0x002FDACA File Offset: 0x002FBCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportRequest other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014957 RID: 84311 RVA: 0x002FDAF8 File Offset: 0x002FBCF8
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

		// Token: 0x06014958 RID: 84312 RVA: 0x002FDB37 File Offset: 0x002FBD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014959 RID: 84313 RVA: 0x002FDB44 File Offset: 0x002FBD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601495A RID: 84314 RVA: 0x002FDB4D File Offset: 0x002FBD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601495B RID: 84315 RVA: 0x002FDB80 File Offset: 0x002FBD80
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

		// Token: 0x0601495C RID: 84316 RVA: 0x002FDBBE File Offset: 0x002FBDBE
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

		// Token: 0x0601495D RID: 84317 RVA: 0x002FDBEF File Offset: 0x002FBDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601495E RID: 84318 RVA: 0x002FDBF8 File Offset: 0x002FBDF8
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
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D0A RID: 32010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D0B RID: 32011
		public const int TemporaryTeleportIdFieldNumber = 4;

		// Token: 0x04007D0C RID: 32012
		private long temporaryTeleportId_;
	}
}

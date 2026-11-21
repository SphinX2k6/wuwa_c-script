using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFD RID: 3837
	[NetMessage(EMessageId.RemoveTemporaryTeleportNotify)]
	public sealed class RemoveTemporaryTeleportNotify : IMessage<RemoveTemporaryTeleportNotify>, IMessage, IEquatable<RemoveTemporaryTeleportNotify>, IDeepCloneable<RemoveTemporaryTeleportNotify>, IBufferMessage
	{
		// Token: 0x0601493B RID: 84283 RVA: 0x002FD88C File Offset: 0x002FBA8C
		[NullableContext(1)]
		public static RemoveTemporaryTeleportNotify Create()
		{
			return new RemoveTemporaryTeleportNotify();
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x0601493C RID: 84284 RVA: 0x002FD893 File Offset: 0x002FBA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x0601493D RID: 84285 RVA: 0x002FD896 File Offset: 0x002FBA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportNotify.Descriptor;
			}
		}

		// Token: 0x0601493E RID: 84286 RVA: 0x002FD89D File Offset: 0x002FBA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify()
		{
		}

		// Token: 0x0601493F RID: 84287 RVA: 0x002FD8A5 File Offset: 0x002FBAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify(RemoveTemporaryTeleportNotify other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014940 RID: 84288 RVA: 0x002FD8CA File Offset: 0x002FBACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportNotify Clone()
		{
			return new RemoveTemporaryTeleportNotify(this);
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x06014941 RID: 84289 RVA: 0x002FD8D2 File Offset: 0x002FBAD2
		// (set) Token: 0x06014942 RID: 84290 RVA: 0x002FD8DA File Offset: 0x002FBADA
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

		// Token: 0x06014943 RID: 84291 RVA: 0x002FD8E3 File Offset: 0x002FBAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportNotify);
		}

		// Token: 0x06014944 RID: 84292 RVA: 0x002FD8F1 File Offset: 0x002FBAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportNotify other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014945 RID: 84293 RVA: 0x002FD920 File Offset: 0x002FBB20
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

		// Token: 0x06014946 RID: 84294 RVA: 0x002FD95F File Offset: 0x002FBB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014947 RID: 84295 RVA: 0x002FD96C File Offset: 0x002FBB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014948 RID: 84296 RVA: 0x002FD975 File Offset: 0x002FBB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014949 RID: 84297 RVA: 0x002FD9A8 File Offset: 0x002FBBA8
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

		// Token: 0x0601494A RID: 84298 RVA: 0x002FD9E6 File Offset: 0x002FBBE6
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

		// Token: 0x0601494B RID: 84299 RVA: 0x002FDA17 File Offset: 0x002FBC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601494C RID: 84300 RVA: 0x002FDA20 File Offset: 0x002FBC20
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
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D07 RID: 32007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D08 RID: 32008
		public const int TemporaryTeleportIdFieldNumber = 11;

		// Token: 0x04007D09 RID: 32009
		private long temporaryTeleportId_;
	}
}

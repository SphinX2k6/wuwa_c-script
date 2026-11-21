using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAF RID: 3503
	[NetMessage(EMessageId.PlayerXboxInfoGetRequest)]
	public sealed class PlayerXboxInfoGetRequest : IMessage<PlayerXboxInfoGetRequest>, IMessage, IEquatable<PlayerXboxInfoGetRequest>, IDeepCloneable<PlayerXboxInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012E45 RID: 77381 RVA: 0x002C1C82 File Offset: 0x002BFE82
		[NullableContext(1)]
		public static PlayerXboxInfoGetRequest Create()
		{
			return new PlayerXboxInfoGetRequest();
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x06012E46 RID: 77382 RVA: 0x002C1C89 File Offset: 0x002BFE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x06012E47 RID: 77383 RVA: 0x002C1C8C File Offset: 0x002BFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012E48 RID: 77384 RVA: 0x002C1C93 File Offset: 0x002BFE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest()
		{
		}

		// Token: 0x06012E49 RID: 77385 RVA: 0x002C1CA6 File Offset: 0x002BFEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest(PlayerXboxInfoGetRequest other) : this()
		{
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E4A RID: 77386 RVA: 0x002C1CCB File Offset: 0x002BFECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest Clone()
		{
			return new PlayerXboxInfoGetRequest(this);
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x06012E4B RID: 77387 RVA: 0x002C1CD3 File Offset: 0x002BFED3
		// (set) Token: 0x06012E4C RID: 77388 RVA: 0x002C1CDB File Offset: 0x002BFEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxOnlineId
		{
			get
			{
				return this.xboxOnlineId_;
			}
			set
			{
				this.xboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012E4D RID: 77389 RVA: 0x002C1CEE File Offset: 0x002BFEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxInfoGetRequest);
		}

		// Token: 0x06012E4E RID: 77390 RVA: 0x002C1CFC File Offset: 0x002BFEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxInfoGetRequest other)
		{
			return other != null && (other == this || (!(this.XboxOnlineId != other.XboxOnlineId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E4F RID: 77391 RVA: 0x002C1D30 File Offset: 0x002BFF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.XboxOnlineId.Length != 0)
			{
				num ^= this.XboxOnlineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E50 RID: 77392 RVA: 0x002C1D71 File Offset: 0x002BFF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E51 RID: 77393 RVA: 0x002C1D7E File Offset: 0x002BFF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E52 RID: 77394 RVA: 0x002C1D87 File Offset: 0x002BFF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.XboxOnlineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E53 RID: 77395 RVA: 0x002C1DC0 File Offset: 0x002BFFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.XboxOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxOnlineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012E54 RID: 77396 RVA: 0x002C1E03 File Offset: 0x002C0003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxInfoGetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.XboxOnlineId.Length != 0)
			{
				this.XboxOnlineId = other.XboxOnlineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E55 RID: 77397 RVA: 0x002C1E39 File Offset: 0x002C0039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E56 RID: 77398 RVA: 0x002C1E44 File Offset: 0x002C0044
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.XboxOnlineId = input.ReadString();
				}
			}
		}

		// Token: 0x0400754A RID: 30026
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400754B RID: 30027
		public const int XboxOnlineIdFieldNumber = 8;

		// Token: 0x0400754C RID: 30028
		private string xboxOnlineId_ = "";
	}
}

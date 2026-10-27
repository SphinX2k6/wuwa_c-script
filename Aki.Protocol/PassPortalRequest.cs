using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD7 RID: 3031
	[NetMessage(EMessageId.PassPortalRequest)]
	public sealed class PassPortalRequest : IMessage<PassPortalRequest>, IMessage, IEquatable<PassPortalRequest>, IDeepCloneable<PassPortalRequest>, IBufferMessage
	{
		// Token: 0x06010699 RID: 67225 RVA: 0x00264819 File Offset: 0x00262A19
		[NullableContext(1)]
		public static PassPortalRequest Create()
		{
			return new PassPortalRequest();
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0601069A RID: 67226 RVA: 0x00264820 File Offset: 0x00262A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0601069B RID: 67227 RVA: 0x00264823 File Offset: 0x00262A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassPortalRequest.Descriptor;
			}
		}

		// Token: 0x0601069C RID: 67228 RVA: 0x0026482A File Offset: 0x00262A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest()
		{
		}

		// Token: 0x0601069D RID: 67229 RVA: 0x00264834 File Offset: 0x00262A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest(PassPortalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601069E RID: 67230 RVA: 0x00264880 File Offset: 0x00262A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest Clone()
		{
			return new PassPortalRequest(this);
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0601069F RID: 67231 RVA: 0x00264888 File Offset: 0x00262A88
		// (set) Token: 0x060106A0 RID: 67232 RVA: 0x00264890 File Offset: 0x00262A90
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

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x060106A1 RID: 67233 RVA: 0x00264899 File Offset: 0x00262A99
		// (set) Token: 0x060106A2 RID: 67234 RVA: 0x002648A1 File Offset: 0x00262AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x060106A3 RID: 67235 RVA: 0x002648AA File Offset: 0x00262AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassPortalRequest);
		}

		// Token: 0x060106A4 RID: 67236 RVA: 0x002648B8 File Offset: 0x00262AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassPortalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106A5 RID: 67237 RVA: 0x00264908 File Offset: 0x00262B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060106A6 RID: 67238 RVA: 0x0026495D File Offset: 0x00262B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106A7 RID: 67239 RVA: 0x0026496A File Offset: 0x00262B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106A8 RID: 67240 RVA: 0x00264974 File Offset: 0x00262B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Location);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060106A9 RID: 67241 RVA: 0x002649D0 File Offset: 0x00262BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060106AA RID: 67242 RVA: 0x00264A28 File Offset: 0x00262C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassPortalRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060106AB RID: 67243 RVA: 0x00264A90 File Offset: 0x00262C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106AC RID: 67244 RVA: 0x00264A9C File Offset: 0x00262C9C
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
				if (num != 10U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.location_ == null)
					{
						this.Location = new Vector();
					}
					input.ReadMessage(this.Location);
				}
			}
		}

		// Token: 0x04006818 RID: 26648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006819 RID: 26649
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400681A RID: 26650
		private long entityId_;

		// Token: 0x0400681B RID: 26651
		public const int LocationFieldNumber = 1;

		// Token: 0x0400681C RID: 26652
		private Vector location_;
	}
}

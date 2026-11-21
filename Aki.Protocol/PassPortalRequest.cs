using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC7 RID: 3015
	[NetMessage(EMessageId.PassPortalRequest)]
	public sealed class PassPortalRequest : IMessage<PassPortalRequest>, IMessage, IEquatable<PassPortalRequest>, IDeepCloneable<PassPortalRequest>, IBufferMessage
	{
		// Token: 0x06010595 RID: 66965 RVA: 0x0026295D File Offset: 0x00260B5D
		[NullableContext(1)]
		public static PassPortalRequest Create()
		{
			return new PassPortalRequest();
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x06010596 RID: 66966 RVA: 0x00262964 File Offset: 0x00260B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x06010597 RID: 66967 RVA: 0x00262967 File Offset: 0x00260B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassPortalRequest.Descriptor;
			}
		}

		// Token: 0x06010598 RID: 66968 RVA: 0x0026296E File Offset: 0x00260B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest()
		{
		}

		// Token: 0x06010599 RID: 66969 RVA: 0x00262978 File Offset: 0x00260B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest(PassPortalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601059A RID: 66970 RVA: 0x002629C4 File Offset: 0x00260BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalRequest Clone()
		{
			return new PassPortalRequest(this);
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0601059B RID: 66971 RVA: 0x002629CC File Offset: 0x00260BCC
		// (set) Token: 0x0601059C RID: 66972 RVA: 0x002629D4 File Offset: 0x00260BD4
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

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0601059D RID: 66973 RVA: 0x002629DD File Offset: 0x00260BDD
		// (set) Token: 0x0601059E RID: 66974 RVA: 0x002629E5 File Offset: 0x00260BE5
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

		// Token: 0x0601059F RID: 66975 RVA: 0x002629EE File Offset: 0x00260BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassPortalRequest);
		}

		// Token: 0x060105A0 RID: 66976 RVA: 0x002629FC File Offset: 0x00260BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassPortalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105A1 RID: 66977 RVA: 0x00262A4C File Offset: 0x00260C4C
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

		// Token: 0x060105A2 RID: 66978 RVA: 0x00262AA1 File Offset: 0x00260CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105A3 RID: 66979 RVA: 0x00262AAE File Offset: 0x00260CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105A4 RID: 66980 RVA: 0x00262AB8 File Offset: 0x00260CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105A5 RID: 66981 RVA: 0x00262B14 File Offset: 0x00260D14
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

		// Token: 0x060105A6 RID: 66982 RVA: 0x00262B6C File Offset: 0x00260D6C
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

		// Token: 0x060105A7 RID: 66983 RVA: 0x00262BD4 File Offset: 0x00260DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105A8 RID: 66984 RVA: 0x00262BE0 File Offset: 0x00260DE0
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006828 RID: 26664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006829 RID: 26665
		public const int EntityIdFieldNumber = 4;

		// Token: 0x0400682A RID: 26666
		private long entityId_;

		// Token: 0x0400682B RID: 26667
		public const int LocationFieldNumber = 9;

		// Token: 0x0400682C RID: 26668
		private Vector location_;
	}
}

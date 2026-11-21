using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E6 RID: 1766
	[NetMessage(EMessageId.GmEntityFsmGroupInfoRequest)]
	public sealed class GmEntityFsmGroupInfoRequest : IMessage<GmEntityFsmGroupInfoRequest>, IMessage, IEquatable<GmEntityFsmGroupInfoRequest>, IDeepCloneable<GmEntityFsmGroupInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A159 RID: 41305 RVA: 0x00186AE5 File Offset: 0x00184CE5
		[NullableContext(1)]
		public static GmEntityFsmGroupInfoRequest Create()
		{
			return new GmEntityFsmGroupInfoRequest();
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x00186AEC File Offset: 0x00184CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600A15B RID: 41307 RVA: 0x00186AEF File Offset: 0x00184CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmGroupInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x00186AF6 File Offset: 0x00184CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest()
		{
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x00186AFE File Offset: 0x00184CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest(GmEntityFsmGroupInfoRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x00186B23 File Offset: 0x00184D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest Clone()
		{
			return new GmEntityFsmGroupInfoRequest(this);
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600A15F RID: 41311 RVA: 0x00186B2B File Offset: 0x00184D2B
		// (set) Token: 0x0600A160 RID: 41312 RVA: 0x00186B33 File Offset: 0x00184D33
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

		// Token: 0x0600A161 RID: 41313 RVA: 0x00186B3C File Offset: 0x00184D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmGroupInfoRequest);
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00186B4A File Offset: 0x00184D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmGroupInfoRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00186B78 File Offset: 0x00184D78
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

		// Token: 0x0600A164 RID: 41316 RVA: 0x00186BB7 File Offset: 0x00184DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00186BC4 File Offset: 0x00184DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x00186BCD File Offset: 0x00184DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x00186C00 File Offset: 0x00184E00
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

		// Token: 0x0600A168 RID: 41320 RVA: 0x00186C3E File Offset: 0x00184E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmGroupInfoRequest other)
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

		// Token: 0x0600A169 RID: 41321 RVA: 0x00186C6F File Offset: 0x00184E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x00186C78 File Offset: 0x00184E78
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004B4E RID: 19278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B4F RID: 19279
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04004B50 RID: 19280
		private long entityId_;
	}
}

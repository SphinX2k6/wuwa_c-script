using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB9 RID: 3001
	[NetMessage(EMessageId.PartUpdateRequest)]
	public sealed class PartUpdateRequest : IMessage<PartUpdateRequest>, IMessage, IEquatable<PartUpdateRequest>, IDeepCloneable<PartUpdateRequest>, IBufferMessage
	{
		// Token: 0x06010483 RID: 66691 RVA: 0x002607D4 File Offset: 0x0025E9D4
		[NullableContext(1)]
		public static PartUpdateRequest Create()
		{
			return new PartUpdateRequest();
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x06010484 RID: 66692 RVA: 0x002607DB File Offset: 0x0025E9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x06010485 RID: 66693 RVA: 0x002607DE File Offset: 0x0025E9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06010486 RID: 66694 RVA: 0x002607E5 File Offset: 0x0025E9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest()
		{
		}

		// Token: 0x06010487 RID: 66695 RVA: 0x002607F8 File Offset: 0x0025E9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest(PartUpdateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partUpdateInfos_ = other.partUpdateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010488 RID: 66696 RVA: 0x0026082E File Offset: 0x0025EA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest Clone()
		{
			return new PartUpdateRequest(this);
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x06010489 RID: 66697 RVA: 0x00260836 File Offset: 0x0025EA36
		// (set) Token: 0x0601048A RID: 66698 RVA: 0x0026083E File Offset: 0x0025EA3E
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

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0601048B RID: 66699 RVA: 0x00260847 File Offset: 0x0025EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartUpdateInfo> PartUpdateInfos
		{
			get
			{
				return this.partUpdateInfos_;
			}
		}

		// Token: 0x0601048C RID: 66700 RVA: 0x0026084F File Offset: 0x0025EA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateRequest);
		}

		// Token: 0x0601048D RID: 66701 RVA: 0x00260860 File Offset: 0x0025EA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partUpdateInfos_.Equals(other.partUpdateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601048E RID: 66702 RVA: 0x002608B0 File Offset: 0x0025EAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.partUpdateInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601048F RID: 66703 RVA: 0x002608FD File Offset: 0x0025EAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010490 RID: 66704 RVA: 0x0026090A File Offset: 0x0025EB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010491 RID: 66705 RVA: 0x00260914 File Offset: 0x0025EB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.partUpdateInfos_.WriteTo(ref output, PartUpdateRequest._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010492 RID: 66706 RVA: 0x00260964 File Offset: 0x0025EB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.partUpdateInfos_.CalculateSize(PartUpdateRequest._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010493 RID: 66707 RVA: 0x002609B8 File Offset: 0x0025EBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.partUpdateInfos_.Add(other.partUpdateInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010494 RID: 66708 RVA: 0x00260A05 File Offset: 0x0025EC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010495 RID: 66709 RVA: 0x00260A10 File Offset: 0x0025EC10
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.partUpdateInfos_.AddEntriesFrom(ref input, PartUpdateRequest._repeated_partUpdateInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067E5 RID: 26597
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067E6 RID: 26598
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040067E7 RID: 26599
		private long entityId_;

		// Token: 0x040067E8 RID: 26600
		public const int PartUpdateInfosFieldNumber = 2;

		// Token: 0x040067E9 RID: 26601
		private static readonly FieldCodec<PartUpdateInfo> _repeated_partUpdateInfos_codec = FieldCodec.ForMessage<PartUpdateInfo>(18U, PartUpdateInfo.Parser);

		// Token: 0x040067EA RID: 26602
		private readonly RepeatedField<PartUpdateInfo> partUpdateInfos_ = new RepeatedField<PartUpdateInfo>();
	}
}

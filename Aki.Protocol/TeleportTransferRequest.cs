using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B4 RID: 5044
	[NetMessage(EMessageId.TeleportTransferRequest)]
	public sealed class TeleportTransferRequest : IMessage<TeleportTransferRequest>, IMessage, IEquatable<TeleportTransferRequest>, IDeepCloneable<TeleportTransferRequest>, IBufferMessage
	{
		// Token: 0x0601AD76 RID: 109942 RVA: 0x003E88C5 File Offset: 0x003E6AC5
		[NullableContext(1)]
		public static TeleportTransferRequest Create()
		{
			return new TeleportTransferRequest();
		}

		// Token: 0x17005AE0 RID: 23264
		// (get) Token: 0x0601AD77 RID: 109943 RVA: 0x003E88CC File Offset: 0x003E6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AE1 RID: 23265
		// (get) Token: 0x0601AD78 RID: 109944 RVA: 0x003E88CF File Offset: 0x003E6ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportTransferRequest.Descriptor;
			}
		}

		// Token: 0x0601AD79 RID: 109945 RVA: 0x003E88D6 File Offset: 0x003E6AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest()
		{
		}

		// Token: 0x0601AD7A RID: 109946 RVA: 0x003E88DE File Offset: 0x003E6ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest(TeleportTransferRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD7B RID: 109947 RVA: 0x003E8903 File Offset: 0x003E6B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest Clone()
		{
			return new TeleportTransferRequest(this);
		}

		// Token: 0x17005AE2 RID: 23266
		// (get) Token: 0x0601AD7C RID: 109948 RVA: 0x003E890B File Offset: 0x003E6B0B
		// (set) Token: 0x0601AD7D RID: 109949 RVA: 0x003E8913 File Offset: 0x003E6B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601AD7E RID: 109950 RVA: 0x003E891C File Offset: 0x003E6B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportTransferRequest);
		}

		// Token: 0x0601AD7F RID: 109951 RVA: 0x003E892A File Offset: 0x003E6B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportTransferRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD80 RID: 109952 RVA: 0x003E8958 File Offset: 0x003E6B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AD81 RID: 109953 RVA: 0x003E8997 File Offset: 0x003E6B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD82 RID: 109954 RVA: 0x003E89A4 File Offset: 0x003E6BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD83 RID: 109955 RVA: 0x003E89AD File Offset: 0x003E6BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD84 RID: 109956 RVA: 0x003E89E0 File Offset: 0x003E6BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AD85 RID: 109957 RVA: 0x003E8A1E File Offset: 0x003E6C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportTransferRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD86 RID: 109958 RVA: 0x003E8A4F File Offset: 0x003E6C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD87 RID: 109959 RVA: 0x003E8A58 File Offset: 0x003E6C58
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009CFC RID: 40188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CFD RID: 40189
		public const int IdFieldNumber = 4;

		// Token: 0x04009CFE RID: 40190
		private int id_;
	}
}

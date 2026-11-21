using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E7 RID: 1767
	[NetMessage(EMessageId.GmEntityFsmGroupInfoResponse)]
	public sealed class GmEntityFsmGroupInfoResponse : IMessage<GmEntityFsmGroupInfoResponse>, IMessage, IEquatable<GmEntityFsmGroupInfoResponse>, IDeepCloneable<GmEntityFsmGroupInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A16B RID: 41323 RVA: 0x00186CBD File Offset: 0x00184EBD
		[NullableContext(1)]
		public static GmEntityFsmGroupInfoResponse Create()
		{
			return new GmEntityFsmGroupInfoResponse();
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600A16C RID: 41324 RVA: 0x00186CC4 File Offset: 0x00184EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600A16D RID: 41325 RVA: 0x00186CC7 File Offset: 0x00184EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmGroupInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x00186CCE File Offset: 0x00184ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse()
		{
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x00186CE1 File Offset: 0x00184EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse(GmEntityFsmGroupInfoResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.gmEntityFsmMachineInfos_ = other.gmEntityFsmMachineInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x00186D17 File Offset: 0x00184F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse Clone()
		{
			return new GmEntityFsmGroupInfoResponse(this);
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600A171 RID: 41329 RVA: 0x00186D1F File Offset: 0x00184F1F
		// (set) Token: 0x0600A172 RID: 41330 RVA: 0x00186D27 File Offset: 0x00184F27
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

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x00186D30 File Offset: 0x00184F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmMachineInfo> GmEntityFsmMachineInfos
		{
			get
			{
				return this.gmEntityFsmMachineInfos_;
			}
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x00186D38 File Offset: 0x00184F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmGroupInfoResponse);
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x00186D48 File Offset: 0x00184F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmGroupInfoResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.gmEntityFsmMachineInfos_.Equals(other.gmEntityFsmMachineInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x00186D98 File Offset: 0x00184F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.gmEntityFsmMachineInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x00186DE5 File Offset: 0x00184FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x00186DF2 File Offset: 0x00184FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x00186DFC File Offset: 0x00184FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			this.gmEntityFsmMachineInfos_.WriteTo(ref output, GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x00186E4C File Offset: 0x0018504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.gmEntityFsmMachineInfos_.CalculateSize(GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x00186EA0 File Offset: 0x001850A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmGroupInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.gmEntityFsmMachineInfos_.Add(other.gmEntityFsmMachineInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x00186EED File Offset: 0x001850ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x00186EF8 File Offset: 0x001850F8
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gmEntityFsmMachineInfos_.AddEntriesFrom(ref input, GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004B51 RID: 19281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B52 RID: 19282
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04004B53 RID: 19283
		private long entityId_;

		// Token: 0x04004B54 RID: 19284
		public const int GmEntityFsmMachineInfosFieldNumber = 9;

		// Token: 0x04004B55 RID: 19285
		private static readonly FieldCodec<GmEntityFsmMachineInfo> _repeated_gmEntityFsmMachineInfos_codec = FieldCodec.ForMessage<GmEntityFsmMachineInfo>(74U, GmEntityFsmMachineInfo.Parser);

		// Token: 0x04004B56 RID: 19286
		private readonly RepeatedField<GmEntityFsmMachineInfo> gmEntityFsmMachineInfos_ = new RepeatedField<GmEntityFsmMachineInfo>();
	}
}

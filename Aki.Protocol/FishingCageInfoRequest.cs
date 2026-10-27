using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054C RID: 1356
	[NetMessage(EMessageId.FishingCageInfoRequest)]
	public sealed class FishingCageInfoRequest : IMessage<FishingCageInfoRequest>, IMessage, IEquatable<FishingCageInfoRequest>, IDeepCloneable<FishingCageInfoRequest>, IBufferMessage
	{
		// Token: 0x06007EC7 RID: 32455 RVA: 0x00132D65 File Offset: 0x00130F65
		[NullableContext(1)]
		public static FishingCageInfoRequest Create()
		{
			return new FishingCageInfoRequest();
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06007EC8 RID: 32456 RVA: 0x00132D6C File Offset: 0x00130F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x00132D6F File Offset: 0x00130F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x00132D76 File Offset: 0x00130F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest()
		{
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x00132D7E File Offset: 0x00130F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest(FishingCageInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x00132DA3 File Offset: 0x00130FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoRequest Clone()
		{
			return new FishingCageInfoRequest(this);
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06007ECD RID: 32461 RVA: 0x00132DAB File Offset: 0x00130FAB
		// (set) Token: 0x06007ECE RID: 32462 RVA: 0x00132DB3 File Offset: 0x00130FB3
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

		// Token: 0x06007ECF RID: 32463 RVA: 0x00132DBC File Offset: 0x00130FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCageInfoRequest);
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x00132DCA File Offset: 0x00130FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCageInfoRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x00132DF8 File Offset: 0x00130FF8
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

		// Token: 0x06007ED2 RID: 32466 RVA: 0x00132E37 File Offset: 0x00131037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00132E44 File Offset: 0x00131044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00132E4D File Offset: 0x0013104D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x00132E80 File Offset: 0x00131080
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

		// Token: 0x06007ED6 RID: 32470 RVA: 0x00132EBE File Offset: 0x001310BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCageInfoRequest other)
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

		// Token: 0x06007ED7 RID: 32471 RVA: 0x00132EEF File Offset: 0x001310EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x00132EF8 File Offset: 0x001310F8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004034 RID: 16436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004035 RID: 16437
		public const int IdFieldNumber = 10;

		// Token: 0x04004036 RID: 16438
		private int id_;
	}
}

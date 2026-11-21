using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB7 RID: 2999
	[NetMessage(EMessageId.PartUpdateNotify)]
	public sealed class PartUpdateNotify : IMessage<PartUpdateNotify>, IMessage, IEquatable<PartUpdateNotify>, IDeepCloneable<PartUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601045B RID: 66651 RVA: 0x0026027E File Offset: 0x0025E47E
		[NullableContext(1)]
		public static PartUpdateNotify Create()
		{
			return new PartUpdateNotify();
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0601045C RID: 66652 RVA: 0x00260285 File Offset: 0x0025E485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0601045D RID: 66653 RVA: 0x00260288 File Offset: 0x0025E488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601045E RID: 66654 RVA: 0x0026028F File Offset: 0x0025E48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify()
		{
		}

		// Token: 0x0601045F RID: 66655 RVA: 0x002602A2 File Offset: 0x0025E4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify(PartUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partInfos_ = other.partInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010460 RID: 66656 RVA: 0x002602D8 File Offset: 0x0025E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify Clone()
		{
			return new PartUpdateNotify(this);
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x06010461 RID: 66657 RVA: 0x002602E0 File Offset: 0x0025E4E0
		// (set) Token: 0x06010462 RID: 66658 RVA: 0x002602E8 File Offset: 0x0025E4E8
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

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x06010463 RID: 66659 RVA: 0x002602F1 File Offset: 0x0025E4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartInfos
		{
			get
			{
				return this.partInfos_;
			}
		}

		// Token: 0x06010464 RID: 66660 RVA: 0x002602F9 File Offset: 0x0025E4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateNotify);
		}

		// Token: 0x06010465 RID: 66661 RVA: 0x00260308 File Offset: 0x0025E508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partInfos_.Equals(other.partInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010466 RID: 66662 RVA: 0x00260358 File Offset: 0x0025E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.partInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010467 RID: 66663 RVA: 0x002603A5 File Offset: 0x0025E5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010468 RID: 66664 RVA: 0x002603B2 File Offset: 0x0025E5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010469 RID: 66665 RVA: 0x002603BC File Offset: 0x0025E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partInfos_.WriteTo(ref output, PartUpdateNotify._repeated_partInfos_codec);
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

		// Token: 0x0601046A RID: 66666 RVA: 0x0026040C File Offset: 0x0025E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.partInfos_.CalculateSize(PartUpdateNotify._repeated_partInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601046B RID: 66667 RVA: 0x00260460 File Offset: 0x0025E660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.partInfos_.Add(other.partInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601046C RID: 66668 RVA: 0x002604AD File Offset: 0x0025E6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601046D RID: 66669 RVA: 0x002604B8 File Offset: 0x0025E6B8
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
				if (num != 82U)
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
					this.partInfos_.AddEntriesFrom(ref input, PartUpdateNotify._repeated_partInfos_codec);
				}
			}
		}

		// Token: 0x040067D9 RID: 26585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067DA RID: 26586
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040067DB RID: 26587
		private long entityId_;

		// Token: 0x040067DC RID: 26588
		public const int PartInfosFieldNumber = 10;

		// Token: 0x040067DD RID: 26589
		private static readonly FieldCodec<PartInformation> _repeated_partInfos_codec = FieldCodec.ForMessage<PartInformation>(82U, PartInformation.Parser);

		// Token: 0x040067DE RID: 26590
		private readonly RepeatedField<PartInformation> partInfos_ = new RepeatedField<PartInformation>();
	}
}

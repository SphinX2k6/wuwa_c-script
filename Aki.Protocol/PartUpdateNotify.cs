using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC7 RID: 3015
	[NetMessage(EMessageId.PartUpdateNotify)]
	public sealed class PartUpdateNotify : IMessage<PartUpdateNotify>, IMessage, IEquatable<PartUpdateNotify>, IDeepCloneable<PartUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601055F RID: 66911 RVA: 0x00262136 File Offset: 0x00260336
		[NullableContext(1)]
		public static PartUpdateNotify Create()
		{
			return new PartUpdateNotify();
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x06010560 RID: 66912 RVA: 0x0026213D File Offset: 0x0026033D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x06010561 RID: 66913 RVA: 0x00262140 File Offset: 0x00260340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010562 RID: 66914 RVA: 0x00262147 File Offset: 0x00260347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify()
		{
		}

		// Token: 0x06010563 RID: 66915 RVA: 0x0026215A File Offset: 0x0026035A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify(PartUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partInfos_ = other.partInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010564 RID: 66916 RVA: 0x00262190 File Offset: 0x00260390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify Clone()
		{
			return new PartUpdateNotify(this);
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x06010565 RID: 66917 RVA: 0x00262198 File Offset: 0x00260398
		// (set) Token: 0x06010566 RID: 66918 RVA: 0x002621A0 File Offset: 0x002603A0
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

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x06010567 RID: 66919 RVA: 0x002621A9 File Offset: 0x002603A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartInfos
		{
			get
			{
				return this.partInfos_;
			}
		}

		// Token: 0x06010568 RID: 66920 RVA: 0x002621B1 File Offset: 0x002603B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateNotify);
		}

		// Token: 0x06010569 RID: 66921 RVA: 0x002621C0 File Offset: 0x002603C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partInfos_.Equals(other.partInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601056A RID: 66922 RVA: 0x00262210 File Offset: 0x00260410
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

		// Token: 0x0601056B RID: 66923 RVA: 0x0026225D File Offset: 0x0026045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601056C RID: 66924 RVA: 0x0026226A File Offset: 0x0026046A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601056D RID: 66925 RVA: 0x00262274 File Offset: 0x00260474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			this.partInfos_.WriteTo(ref output, PartUpdateNotify._repeated_partInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601056E RID: 66926 RVA: 0x002622C4 File Offset: 0x002604C4
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

		// Token: 0x0601056F RID: 66927 RVA: 0x00262318 File Offset: 0x00260518
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

		// Token: 0x06010570 RID: 66928 RVA: 0x00262365 File Offset: 0x00260565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010571 RID: 66929 RVA: 0x00262370 File Offset: 0x00260570
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.partInfos_.AddEntriesFrom(ref input, PartUpdateNotify._repeated_partInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067C9 RID: 26569
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067CA RID: 26570
		public const int EntityIdFieldNumber = 4;

		// Token: 0x040067CB RID: 26571
		private long entityId_;

		// Token: 0x040067CC RID: 26572
		public const int PartInfosFieldNumber = 14;

		// Token: 0x040067CD RID: 26573
		private static readonly FieldCodec<PartInformation> _repeated_partInfos_codec = FieldCodec.ForMessage<PartInformation>(114U, PartInformation.Parser);

		// Token: 0x040067CE RID: 26574
		private readonly RepeatedField<PartInformation> partInfos_ = new RepeatedField<PartInformation>();
	}
}

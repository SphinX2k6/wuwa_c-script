using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000341 RID: 833
	public sealed class DangoBrawlBaseItemInfo : IMessage<DangoBrawlBaseItemInfo>, IMessage, IEquatable<DangoBrawlBaseItemInfo>, IDeepCloneable<DangoBrawlBaseItemInfo>, IBufferMessage
	{
		// Token: 0x060053BA RID: 21434 RVA: 0x000CC892 File Offset: 0x000CAA92
		[NullableContext(1)]
		public static DangoBrawlBaseItemInfo Create()
		{
			return new DangoBrawlBaseItemInfo();
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x000CC899 File Offset: 0x000CAA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060053BC RID: 21436 RVA: 0x000CC89C File Offset: 0x000CAA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBaseItemInfo.Descriptor;
			}
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x000CC8A3 File Offset: 0x000CAAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo()
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x000CC8AB File Offset: 0x000CAAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo(DangoBrawlBaseItemInfo other) : this()
		{
			this.uid_ = other.uid_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x000CC8DC File Offset: 0x000CAADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Clone()
		{
			return new DangoBrawlBaseItemInfo(this);
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x000CC8E4 File Offset: 0x000CAAE4
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x000CC8EC File Offset: 0x000CAAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x000CC8F5 File Offset: 0x000CAAF5
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x000CC8FD File Offset: 0x000CAAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x000CC906 File Offset: 0x000CAB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBaseItemInfo);
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x000CC914 File Offset: 0x000CAB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBaseItemInfo other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x000CC954 File Offset: 0x000CAB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x000CC9AC File Offset: 0x000CABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x000CC9B9 File Offset: 0x000CABB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x000CC9C4 File Offset: 0x000CABC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Uid);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x000CCA1C File Offset: 0x000CAC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Uid);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x000CCA74 File Offset: 0x000CAC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBaseItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0)
			{
				this.Uid = other.Uid;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x000CCAC4 File Offset: 0x000CACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x000CCAD0 File Offset: 0x000CACD0
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.Uid = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033EA RID: 13290
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033EB RID: 13291
		public const int UidFieldNumber = 1;

		// Token: 0x040033EC RID: 13292
		private int uid_;

		// Token: 0x040033ED RID: 13293
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x040033EE RID: 13294
		private int configId_;
	}
}

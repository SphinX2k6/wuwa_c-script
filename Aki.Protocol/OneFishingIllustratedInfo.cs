using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B86 RID: 2950
	public sealed class OneFishingIllustratedInfo : IMessage<OneFishingIllustratedInfo>, IMessage, IEquatable<OneFishingIllustratedInfo>, IDeepCloneable<OneFishingIllustratedInfo>, IBufferMessage
	{
		// Token: 0x0600FFBA RID: 65466 RVA: 0x00254E4C File Offset: 0x0025304C
		[NullableContext(1)]
		public static OneFishingIllustratedInfo Create()
		{
			return new OneFishingIllustratedInfo();
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600FFBB RID: 65467 RVA: 0x00254E53 File Offset: 0x00253053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishingIllustratedInfo> Parser
		{
			get
			{
				return OneFishingIllustratedInfo._parser;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600FFBC RID: 65468 RVA: 0x00254E5A File Offset: 0x0025305A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600FFBD RID: 65469 RVA: 0x00254E5D File Offset: 0x0025305D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishingIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0600FFBE RID: 65470 RVA: 0x00254E64 File Offset: 0x00253064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo()
		{
		}

		// Token: 0x0600FFBF RID: 65471 RVA: 0x00254E6C File Offset: 0x0025306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo(OneFishingIllustratedInfo other) : this()
		{
			this.id_ = other.id_;
			this.maxSize_ = other.maxSize_;
			this.minSize_ = other.minSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFC0 RID: 65472 RVA: 0x00254EA9 File Offset: 0x002530A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo Clone()
		{
			return new OneFishingIllustratedInfo(this);
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600FFC1 RID: 65473 RVA: 0x00254EB1 File Offset: 0x002530B1
		// (set) Token: 0x0600FFC2 RID: 65474 RVA: 0x00254EB9 File Offset: 0x002530B9
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

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600FFC3 RID: 65475 RVA: 0x00254EC2 File Offset: 0x002530C2
		// (set) Token: 0x0600FFC4 RID: 65476 RVA: 0x00254ECA File Offset: 0x002530CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				this.maxSize_ = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600FFC5 RID: 65477 RVA: 0x00254ED3 File Offset: 0x002530D3
		// (set) Token: 0x0600FFC6 RID: 65478 RVA: 0x00254EDB File Offset: 0x002530DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				this.minSize_ = value;
			}
		}

		// Token: 0x0600FFC7 RID: 65479 RVA: 0x00254EE4 File Offset: 0x002530E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishingIllustratedInfo);
		}

		// Token: 0x0600FFC8 RID: 65480 RVA: 0x00254EF4 File Offset: 0x002530F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishingIllustratedInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.MaxSize == other.MaxSize && this.MinSize == other.MinSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFC9 RID: 65481 RVA: 0x00254F50 File Offset: 0x00253150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MaxSize != 0)
			{
				num ^= this.MaxSize.GetHashCode();
			}
			if (this.MinSize != 0)
			{
				num ^= this.MinSize.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FFCA RID: 65482 RVA: 0x00254FC1 File Offset: 0x002531C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFCB RID: 65483 RVA: 0x00254FCE File Offset: 0x002531CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFCC RID: 65484 RVA: 0x00254FD8 File Offset: 0x002531D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.MaxSize != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MinSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FFCD RID: 65485 RVA: 0x0025504C File Offset: 0x0025324C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MaxSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinSize);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FFCE RID: 65486 RVA: 0x002550BC File Offset: 0x002532BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneFishingIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MaxSize != 0)
			{
				this.MaxSize = other.MaxSize;
			}
			if (other.MinSize != 0)
			{
				this.MinSize = other.MinSize;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FFCF RID: 65487 RVA: 0x00255120 File Offset: 0x00253320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFD0 RID: 65488 RVA: 0x0025512C File Offset: 0x0025332C
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MinSize = input.ReadInt32();
						}
					}
					else
					{
						this.MaxSize = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040065E4 RID: 26084
		private static readonly MessageParser<OneFishingIllustratedInfo> _parser = new MessageParser<OneFishingIllustratedInfo>(() => new OneFishingIllustratedInfo());

		// Token: 0x040065E5 RID: 26085
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065E6 RID: 26086
		public const int IdFieldNumber = 1;

		// Token: 0x040065E7 RID: 26087
		private int id_;

		// Token: 0x040065E8 RID: 26088
		public const int MaxSizeFieldNumber = 2;

		// Token: 0x040065E9 RID: 26089
		private int maxSize_;

		// Token: 0x040065EA RID: 26090
		public const int MinSizeFieldNumber = 3;

		// Token: 0x040065EB RID: 26091
		private int minSize_;
	}
}

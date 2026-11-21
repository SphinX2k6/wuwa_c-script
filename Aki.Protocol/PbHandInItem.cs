using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF5 RID: 3061
	public sealed class PbHandInItem : IMessage<PbHandInItem>, IMessage, IEquatable<PbHandInItem>, IDeepCloneable<PbHandInItem>, IBufferMessage
	{
		// Token: 0x06010A3C RID: 68156 RVA: 0x00270304 File Offset: 0x0026E504
		[NullableContext(1)]
		public static PbHandInItem Create()
		{
			return new PbHandInItem();
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x06010A3D RID: 68157 RVA: 0x0027030B File Offset: 0x0026E50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbHandInItem> Parser
		{
			get
			{
				return PbHandInItem._parser;
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x06010A3E RID: 68158 RVA: 0x00270312 File Offset: 0x0026E512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x06010A3F RID: 68159 RVA: 0x00270315 File Offset: 0x0026E515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbHandInItem.Descriptor;
			}
		}

		// Token: 0x06010A40 RID: 68160 RVA: 0x0027031C File Offset: 0x0026E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem()
		{
		}

		// Token: 0x06010A41 RID: 68161 RVA: 0x00270330 File Offset: 0x0026E530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem(PbHandInItem other) : this()
		{
			this.handItemInfo_ = other.handItemInfo_.Clone();
			this.count_ = other.count_;
			this.pbHandInItemType_ = other.pbHandInItemType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A42 RID: 68162 RVA: 0x0027037D File Offset: 0x0026E57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem Clone()
		{
			return new PbHandInItem(this);
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x06010A43 RID: 68163 RVA: 0x00270385 File Offset: 0x0026E585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbHandInItemInfo> HandItemInfo
		{
			get
			{
				return this.handItemInfo_;
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x06010A44 RID: 68164 RVA: 0x0027038D File Offset: 0x0026E58D
		// (set) Token: 0x06010A45 RID: 68165 RVA: 0x00270395 File Offset: 0x0026E595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x06010A46 RID: 68166 RVA: 0x0027039E File Offset: 0x0026E59E
		// (set) Token: 0x06010A47 RID: 68167 RVA: 0x002703A6 File Offset: 0x0026E5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemType PbHandInItemType
		{
			get
			{
				return this.pbHandInItemType_;
			}
			set
			{
				this.pbHandInItemType_ = value;
			}
		}

		// Token: 0x06010A48 RID: 68168 RVA: 0x002703AF File Offset: 0x0026E5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbHandInItem);
		}

		// Token: 0x06010A49 RID: 68169 RVA: 0x002703C0 File Offset: 0x0026E5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbHandInItem other)
		{
			return other != null && (other == this || (this.handItemInfo_.Equals(other.handItemInfo_) && this.Count == other.Count && this.PbHandInItemType == other.PbHandInItemType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A4A RID: 68170 RVA: 0x00270420 File Offset: 0x0026E620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.handItemInfo_.GetHashCode();
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.PbHandInItemType != PbHandInItemType.ItemIds)
			{
				num ^= this.PbHandInItemType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A4B RID: 68171 RVA: 0x0027048C File Offset: 0x0026E68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A4C RID: 68172 RVA: 0x00270499 File Offset: 0x0026E699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A4D RID: 68173 RVA: 0x002704A4 File Offset: 0x0026E6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handItemInfo_.WriteTo(ref output, PbHandInItem._repeated_handItemInfo_codec);
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.PbHandInItemType != PbHandInItemType.ItemIds)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PbHandInItemType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A4E RID: 68174 RVA: 0x00270510 File Offset: 0x0026E710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.handItemInfo_.CalculateSize(PbHandInItem._repeated_handItemInfo_codec);
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.PbHandInItemType != PbHandInItemType.ItemIds)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PbHandInItemType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A4F RID: 68175 RVA: 0x0027057C File Offset: 0x0026E77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbHandInItem other)
		{
			if (other == null)
			{
				return;
			}
			this.handItemInfo_.Add(other.handItemInfo_);
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.PbHandInItemType != PbHandInItemType.ItemIds)
			{
				this.PbHandInItemType = other.PbHandInItemType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A50 RID: 68176 RVA: 0x002705DD File Offset: 0x0026E7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A51 RID: 68177 RVA: 0x002705E8 File Offset: 0x0026E7E8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PbHandInItemType = (PbHandInItemType)input.ReadEnum();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.handItemInfo_.AddEntriesFrom(ref input, PbHandInItem._repeated_handItemInfo_codec);
				}
			}
		}

		// Token: 0x04006A36 RID: 27190
		private static readonly MessageParser<PbHandInItem> _parser = new MessageParser<PbHandInItem>(() => new PbHandInItem());

		// Token: 0x04006A37 RID: 27191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A38 RID: 27192
		public const int HandItemInfoFieldNumber = 1;

		// Token: 0x04006A39 RID: 27193
		private static readonly FieldCodec<PbHandInItemInfo> _repeated_handItemInfo_codec = FieldCodec.ForMessage<PbHandInItemInfo>(10U, PbHandInItemInfo.Parser);

		// Token: 0x04006A3A RID: 27194
		private readonly RepeatedField<PbHandInItemInfo> handItemInfo_ = new RepeatedField<PbHandInItemInfo>();

		// Token: 0x04006A3B RID: 27195
		public const int CountFieldNumber = 2;

		// Token: 0x04006A3C RID: 27196
		private int count_;

		// Token: 0x04006A3D RID: 27197
		public const int PbHandInItemTypeFieldNumber = 3;

		// Token: 0x04006A3E RID: 27198
		private PbHandInItemType pbHandInItemType_;
	}
}

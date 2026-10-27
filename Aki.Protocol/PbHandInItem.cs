using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C05 RID: 3077
	public sealed class PbHandInItem : IMessage<PbHandInItem>, IMessage, IEquatable<PbHandInItem>, IDeepCloneable<PbHandInItem>, IBufferMessage
	{
		// Token: 0x06010B3C RID: 68412 RVA: 0x0027206C File Offset: 0x0027026C
		[NullableContext(1)]
		public static PbHandInItem Create()
		{
			return new PbHandInItem();
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x06010B3D RID: 68413 RVA: 0x00272073 File Offset: 0x00270273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbHandInItem> Parser
		{
			get
			{
				return PbHandInItem._parser;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x06010B3E RID: 68414 RVA: 0x0027207A File Offset: 0x0027027A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x06010B3F RID: 68415 RVA: 0x0027207D File Offset: 0x0027027D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbHandInItem.Descriptor;
			}
		}

		// Token: 0x06010B40 RID: 68416 RVA: 0x00272084 File Offset: 0x00270284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem()
		{
		}

		// Token: 0x06010B41 RID: 68417 RVA: 0x00272098 File Offset: 0x00270298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem(PbHandInItem other) : this()
		{
			this.handItemInfo_ = other.handItemInfo_.Clone();
			this.count_ = other.count_;
			this.pbHandInItemType_ = other.pbHandInItemType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B42 RID: 68418 RVA: 0x002720E5 File Offset: 0x002702E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItem Clone()
		{
			return new PbHandInItem(this);
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x06010B43 RID: 68419 RVA: 0x002720ED File Offset: 0x002702ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbHandInItemInfo> HandItemInfo
		{
			get
			{
				return this.handItemInfo_;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x06010B44 RID: 68420 RVA: 0x002720F5 File Offset: 0x002702F5
		// (set) Token: 0x06010B45 RID: 68421 RVA: 0x002720FD File Offset: 0x002702FD
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

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x06010B46 RID: 68422 RVA: 0x00272106 File Offset: 0x00270306
		// (set) Token: 0x06010B47 RID: 68423 RVA: 0x0027210E File Offset: 0x0027030E
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

		// Token: 0x06010B48 RID: 68424 RVA: 0x00272117 File Offset: 0x00270317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbHandInItem);
		}

		// Token: 0x06010B49 RID: 68425 RVA: 0x00272128 File Offset: 0x00270328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbHandInItem other)
		{
			return other != null && (other == this || (this.handItemInfo_.Equals(other.handItemInfo_) && this.Count == other.Count && this.PbHandInItemType == other.PbHandInItemType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B4A RID: 68426 RVA: 0x00272188 File Offset: 0x00270388
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

		// Token: 0x06010B4B RID: 68427 RVA: 0x002721F4 File Offset: 0x002703F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B4C RID: 68428 RVA: 0x00272201 File Offset: 0x00270401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B4D RID: 68429 RVA: 0x0027220C File Offset: 0x0027040C
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

		// Token: 0x06010B4E RID: 68430 RVA: 0x00272278 File Offset: 0x00270478
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

		// Token: 0x06010B4F RID: 68431 RVA: 0x002722E4 File Offset: 0x002704E4
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

		// Token: 0x06010B50 RID: 68432 RVA: 0x00272345 File Offset: 0x00270545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B51 RID: 68433 RVA: 0x00272350 File Offset: 0x00270550
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

		// Token: 0x04006A22 RID: 27170
		private static readonly MessageParser<PbHandInItem> _parser = new MessageParser<PbHandInItem>(() => new PbHandInItem());

		// Token: 0x04006A23 RID: 27171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A24 RID: 27172
		public const int HandItemInfoFieldNumber = 1;

		// Token: 0x04006A25 RID: 27173
		private static readonly FieldCodec<PbHandInItemInfo> _repeated_handItemInfo_codec = FieldCodec.ForMessage<PbHandInItemInfo>(10U, PbHandInItemInfo.Parser);

		// Token: 0x04006A26 RID: 27174
		private readonly RepeatedField<PbHandInItemInfo> handItemInfo_ = new RepeatedField<PbHandInItemInfo>();

		// Token: 0x04006A27 RID: 27175
		public const int CountFieldNumber = 2;

		// Token: 0x04006A28 RID: 27176
		private int count_;

		// Token: 0x04006A29 RID: 27177
		public const int PbHandInItemTypeFieldNumber = 3;

		// Token: 0x04006A2A RID: 27178
		private PbHandInItemType pbHandInItemType_;
	}
}

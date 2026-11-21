using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D64 RID: 3428
	public sealed class PlacementInfoChangeInfo : IMessage<PlacementInfoChangeInfo>, IMessage, IEquatable<PlacementInfoChangeInfo>, IDeepCloneable<PlacementInfoChangeInfo>, IBufferMessage
	{
		// Token: 0x06012816 RID: 75798 RVA: 0x002B399C File Offset: 0x002B1B9C
		[NullableContext(1)]
		public static PlacementInfoChangeInfo Create()
		{
			return new PlacementInfoChangeInfo();
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x06012817 RID: 75799 RVA: 0x002B39A3 File Offset: 0x002B1BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlacementInfoChangeInfo> Parser
		{
			get
			{
				return PlacementInfoChangeInfo._parser;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x06012818 RID: 75800 RVA: 0x002B39AA File Offset: 0x002B1BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x06012819 RID: 75801 RVA: 0x002B39AD File Offset: 0x002B1BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementInfoChangeInfo.Descriptor;
			}
		}

		// Token: 0x0601281A RID: 75802 RVA: 0x002B39B4 File Offset: 0x002B1BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo()
		{
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x002B39BC File Offset: 0x002B1BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo(PlacementInfoChangeInfo other) : this()
		{
			this.placementItemPb_ = ((other.placementItemPb_ != null) ? other.placementItemPb_.Clone() : null);
			this.placementEntityId_ = other.placementEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x002B3A08 File Offset: 0x002B1C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo Clone()
		{
			return new PlacementInfoChangeInfo(this);
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0601281D RID: 75805 RVA: 0x002B3A10 File Offset: 0x002B1C10
		// (set) Token: 0x0601281E RID: 75806 RVA: 0x002B3A18 File Offset: 0x002B1C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb PlacementItemPb
		{
			get
			{
				return this.placementItemPb_;
			}
			set
			{
				this.placementItemPb_ = value;
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0601281F RID: 75807 RVA: 0x002B3A21 File Offset: 0x002B1C21
		// (set) Token: 0x06012820 RID: 75808 RVA: 0x002B3A29 File Offset: 0x002B1C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlacementEntityId
		{
			get
			{
				return this.placementEntityId_;
			}
			set
			{
				this.placementEntityId_ = value;
			}
		}

		// Token: 0x06012821 RID: 75809 RVA: 0x002B3A32 File Offset: 0x002B1C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementInfoChangeInfo);
		}

		// Token: 0x06012822 RID: 75810 RVA: 0x002B3A40 File Offset: 0x002B1C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementInfoChangeInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PlacementItemPb, other.PlacementItemPb) && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012823 RID: 75811 RVA: 0x002B3A90 File Offset: 0x002B1C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.placementItemPb_ != null)
			{
				num ^= this.PlacementItemPb.GetHashCode();
			}
			if (this.PlacementEntityId != 0L)
			{
				num ^= this.PlacementEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012824 RID: 75812 RVA: 0x002B3AE5 File Offset: 0x002B1CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012825 RID: 75813 RVA: 0x002B3AF2 File Offset: 0x002B1CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012826 RID: 75814 RVA: 0x002B3AFC File Offset: 0x002B1CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.placementItemPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PlacementItemPb);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012827 RID: 75815 RVA: 0x002B3B58 File Offset: 0x002B1D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.placementItemPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlacementItemPb);
			}
			if (this.PlacementEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlacementEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012828 RID: 75816 RVA: 0x002B3BB0 File Offset: 0x002B1DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlacementInfoChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.placementItemPb_ != null)
			{
				if (this.placementItemPb_ == null)
				{
					this.PlacementItemPb = new PlacementItemPb();
				}
				this.PlacementItemPb.MergeFrom(other.PlacementItemPb);
			}
			if (other.PlacementEntityId != 0L)
			{
				this.PlacementEntityId = other.PlacementEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012829 RID: 75817 RVA: 0x002B3C18 File Offset: 0x002B1E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601282A RID: 75818 RVA: 0x002B3C24 File Offset: 0x002B1E24
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlacementEntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.placementItemPb_ == null)
					{
						this.PlacementItemPb = new PlacementItemPb();
					}
					input.ReadMessage(this.PlacementItemPb);
				}
			}
		}

		// Token: 0x04007364 RID: 29540
		private static readonly MessageParser<PlacementInfoChangeInfo> _parser = new MessageParser<PlacementInfoChangeInfo>(() => new PlacementInfoChangeInfo());

		// Token: 0x04007365 RID: 29541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007366 RID: 29542
		public const int PlacementItemPbFieldNumber = 1;

		// Token: 0x04007367 RID: 29543
		private PlacementItemPb placementItemPb_;

		// Token: 0x04007368 RID: 29544
		public const int PlacementEntityIdFieldNumber = 2;

		// Token: 0x04007369 RID: 29545
		private long placementEntityId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D74 RID: 3444
	public sealed class PlacementInfoChangeInfo : IMessage<PlacementInfoChangeInfo>, IMessage, IEquatable<PlacementInfoChangeInfo>, IDeepCloneable<PlacementInfoChangeInfo>, IBufferMessage
	{
		// Token: 0x06012912 RID: 76050 RVA: 0x002B55B8 File Offset: 0x002B37B8
		[NullableContext(1)]
		public static PlacementInfoChangeInfo Create()
		{
			return new PlacementInfoChangeInfo();
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x06012913 RID: 76051 RVA: 0x002B55BF File Offset: 0x002B37BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlacementInfoChangeInfo> Parser
		{
			get
			{
				return PlacementInfoChangeInfo._parser;
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x06012914 RID: 76052 RVA: 0x002B55C6 File Offset: 0x002B37C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x06012915 RID: 76053 RVA: 0x002B55C9 File Offset: 0x002B37C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementInfoChangeInfo.Descriptor;
			}
		}

		// Token: 0x06012916 RID: 76054 RVA: 0x002B55D0 File Offset: 0x002B37D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo()
		{
		}

		// Token: 0x06012917 RID: 76055 RVA: 0x002B55D8 File Offset: 0x002B37D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo(PlacementInfoChangeInfo other) : this()
		{
			this.placementItemPb_ = ((other.placementItemPb_ != null) ? other.placementItemPb_.Clone() : null);
			this.placementEntityId_ = other.placementEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012918 RID: 76056 RVA: 0x002B5624 File Offset: 0x002B3824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeInfo Clone()
		{
			return new PlacementInfoChangeInfo(this);
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x06012919 RID: 76057 RVA: 0x002B562C File Offset: 0x002B382C
		// (set) Token: 0x0601291A RID: 76058 RVA: 0x002B5634 File Offset: 0x002B3834
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

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0601291B RID: 76059 RVA: 0x002B563D File Offset: 0x002B383D
		// (set) Token: 0x0601291C RID: 76060 RVA: 0x002B5645 File Offset: 0x002B3845
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

		// Token: 0x0601291D RID: 76061 RVA: 0x002B564E File Offset: 0x002B384E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementInfoChangeInfo);
		}

		// Token: 0x0601291E RID: 76062 RVA: 0x002B565C File Offset: 0x002B385C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementInfoChangeInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PlacementItemPb, other.PlacementItemPb) && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601291F RID: 76063 RVA: 0x002B56AC File Offset: 0x002B38AC
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

		// Token: 0x06012920 RID: 76064 RVA: 0x002B5701 File Offset: 0x002B3901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012921 RID: 76065 RVA: 0x002B570E File Offset: 0x002B390E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012922 RID: 76066 RVA: 0x002B5718 File Offset: 0x002B3918
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

		// Token: 0x06012923 RID: 76067 RVA: 0x002B5774 File Offset: 0x002B3974
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

		// Token: 0x06012924 RID: 76068 RVA: 0x002B57CC File Offset: 0x002B39CC
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

		// Token: 0x06012925 RID: 76069 RVA: 0x002B5834 File Offset: 0x002B3A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012926 RID: 76070 RVA: 0x002B5840 File Offset: 0x002B3A40
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

		// Token: 0x0400734C RID: 29516
		private static readonly MessageParser<PlacementInfoChangeInfo> _parser = new MessageParser<PlacementInfoChangeInfo>(() => new PlacementInfoChangeInfo());

		// Token: 0x0400734D RID: 29517
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400734E RID: 29518
		public const int PlacementItemPbFieldNumber = 1;

		// Token: 0x0400734F RID: 29519
		private PlacementItemPb placementItemPb_;

		// Token: 0x04007350 RID: 29520
		public const int PlacementEntityIdFieldNumber = 2;

		// Token: 0x04007351 RID: 29521
		private long placementEntityId_;
	}
}

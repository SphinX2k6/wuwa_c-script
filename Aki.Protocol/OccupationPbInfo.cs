using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7E RID: 2942
	public sealed class OccupationPbInfo : IMessage<OccupationPbInfo>, IMessage, IEquatable<OccupationPbInfo>, IDeepCloneable<OccupationPbInfo>, IBufferMessage
	{
		// Token: 0x0600FEFA RID: 65274 RVA: 0x00252F31 File Offset: 0x00251131
		[NullableContext(1)]
		public static OccupationPbInfo Create()
		{
			return new OccupationPbInfo();
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600FEFB RID: 65275 RVA: 0x00252F38 File Offset: 0x00251138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OccupationPbInfo> Parser
		{
			get
			{
				return OccupationPbInfo._parser;
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600FEFC RID: 65276 RVA: 0x00252F3F File Offset: 0x0025113F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600FEFD RID: 65277 RVA: 0x00252F42 File Offset: 0x00251142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupationPbInfo.Descriptor;
			}
		}

		// Token: 0x0600FEFE RID: 65278 RVA: 0x00252F49 File Offset: 0x00251149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo()
		{
		}

		// Token: 0x0600FEFF RID: 65279 RVA: 0x00252F5C File Offset: 0x0025115C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo(OccupationPbInfo other) : this()
		{
			this.resourceName_ = other.resourceName_;
			this.nodeId_ = other.nodeId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF00 RID: 65280 RVA: 0x00252F99 File Offset: 0x00251199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo Clone()
		{
			return new OccupationPbInfo(this);
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600FF01 RID: 65281 RVA: 0x00252FA1 File Offset: 0x002511A1
		// (set) Token: 0x0600FF02 RID: 65282 RVA: 0x00252FA9 File Offset: 0x002511A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResourceName
		{
			get
			{
				return this.resourceName_;
			}
			set
			{
				this.resourceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600FF03 RID: 65283 RVA: 0x00252FBC File Offset: 0x002511BC
		// (set) Token: 0x0600FF04 RID: 65284 RVA: 0x00252FC4 File Offset: 0x002511C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600FF05 RID: 65285 RVA: 0x00252FCD File Offset: 0x002511CD
		// (set) Token: 0x0600FF06 RID: 65286 RVA: 0x00252FD5 File Offset: 0x002511D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600FF07 RID: 65287 RVA: 0x00252FDE File Offset: 0x002511DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupationPbInfo);
		}

		// Token: 0x0600FF08 RID: 65288 RVA: 0x00252FEC File Offset: 0x002511EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupationPbInfo other)
		{
			return other != null && (other == this || (!(this.ResourceName != other.ResourceName) && this.NodeId == other.NodeId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF09 RID: 65289 RVA: 0x0025304C File Offset: 0x0025124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResourceName.Length != 0)
			{
				num ^= this.ResourceName.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FF0A RID: 65290 RVA: 0x002530BF File Offset: 0x002512BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF0B RID: 65291 RVA: 0x002530CC File Offset: 0x002512CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF0C RID: 65292 RVA: 0x002530D8 File Offset: 0x002512D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResourceName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ResourceName);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.IncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FF0D RID: 65293 RVA: 0x00253154 File Offset: 0x00251354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResourceName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResourceName);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FF0E RID: 65294 RVA: 0x002531C8 File Offset: 0x002513C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupationPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResourceName.Length != 0)
			{
				this.ResourceName = other.ResourceName;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FF0F RID: 65295 RVA: 0x00253231 File Offset: 0x00251431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF10 RID: 65296 RVA: 0x0025323C File Offset: 0x0025143C
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
							this.IncId = input.ReadInt64();
						}
					}
					else
					{
						this.NodeId = input.ReadInt32();
					}
				}
				else
				{
					this.ResourceName = input.ReadString();
				}
			}
		}

		// Token: 0x04006594 RID: 26004
		private static readonly MessageParser<OccupationPbInfo> _parser = new MessageParser<OccupationPbInfo>(() => new OccupationPbInfo());

		// Token: 0x04006595 RID: 26005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006596 RID: 26006
		public const int ResourceNameFieldNumber = 1;

		// Token: 0x04006597 RID: 26007
		private string resourceName_ = "";

		// Token: 0x04006598 RID: 26008
		public const int NodeIdFieldNumber = 2;

		// Token: 0x04006599 RID: 26009
		private int nodeId_;

		// Token: 0x0400659A RID: 26010
		public const int IncIdFieldNumber = 3;

		// Token: 0x0400659B RID: 26011
		private long incId_;
	}
}

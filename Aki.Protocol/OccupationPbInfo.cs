using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6E RID: 2926
	public sealed class OccupationPbInfo : IMessage<OccupationPbInfo>, IMessage, IEquatable<OccupationPbInfo>, IDeepCloneable<OccupationPbInfo>, IBufferMessage
	{
		// Token: 0x0600FDF6 RID: 65014 RVA: 0x00251061 File Offset: 0x0024F261
		[NullableContext(1)]
		public static OccupationPbInfo Create()
		{
			return new OccupationPbInfo();
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600FDF7 RID: 65015 RVA: 0x00251068 File Offset: 0x0024F268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OccupationPbInfo> Parser
		{
			get
			{
				return OccupationPbInfo._parser;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600FDF8 RID: 65016 RVA: 0x0025106F File Offset: 0x0024F26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600FDF9 RID: 65017 RVA: 0x00251072 File Offset: 0x0024F272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupationPbInfo.Descriptor;
			}
		}

		// Token: 0x0600FDFA RID: 65018 RVA: 0x00251079 File Offset: 0x0024F279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo()
		{
		}

		// Token: 0x0600FDFB RID: 65019 RVA: 0x0025108C File Offset: 0x0024F28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo(OccupationPbInfo other) : this()
		{
			this.resourceName_ = other.resourceName_;
			this.nodeId_ = other.nodeId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDFC RID: 65020 RVA: 0x002510C9 File Offset: 0x0024F2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationPbInfo Clone()
		{
			return new OccupationPbInfo(this);
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600FDFD RID: 65021 RVA: 0x002510D1 File Offset: 0x0024F2D1
		// (set) Token: 0x0600FDFE RID: 65022 RVA: 0x002510D9 File Offset: 0x0024F2D9
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

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x002510EC File Offset: 0x0024F2EC
		// (set) Token: 0x0600FE00 RID: 65024 RVA: 0x002510F4 File Offset: 0x0024F2F4
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

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600FE01 RID: 65025 RVA: 0x002510FD File Offset: 0x0024F2FD
		// (set) Token: 0x0600FE02 RID: 65026 RVA: 0x00251105 File Offset: 0x0024F305
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

		// Token: 0x0600FE03 RID: 65027 RVA: 0x0025110E File Offset: 0x0024F30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupationPbInfo);
		}

		// Token: 0x0600FE04 RID: 65028 RVA: 0x0025111C File Offset: 0x0024F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupationPbInfo other)
		{
			return other != null && (other == this || (!(this.ResourceName != other.ResourceName) && this.NodeId == other.NodeId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE05 RID: 65029 RVA: 0x0025117C File Offset: 0x0024F37C
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

		// Token: 0x0600FE06 RID: 65030 RVA: 0x002511EF File Offset: 0x0024F3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE07 RID: 65031 RVA: 0x002511FC File Offset: 0x0024F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE08 RID: 65032 RVA: 0x00251208 File Offset: 0x0024F408
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

		// Token: 0x0600FE09 RID: 65033 RVA: 0x00251284 File Offset: 0x0024F484
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

		// Token: 0x0600FE0A RID: 65034 RVA: 0x002512F8 File Offset: 0x0024F4F8
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

		// Token: 0x0600FE0B RID: 65035 RVA: 0x00251361 File Offset: 0x0024F561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE0C RID: 65036 RVA: 0x0025136C File Offset: 0x0024F56C
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

		// Token: 0x040065A4 RID: 26020
		private static readonly MessageParser<OccupationPbInfo> _parser = new MessageParser<OccupationPbInfo>(() => new OccupationPbInfo());

		// Token: 0x040065A5 RID: 26021
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065A6 RID: 26022
		public const int ResourceNameFieldNumber = 1;

		// Token: 0x040065A7 RID: 26023
		private string resourceName_ = "";

		// Token: 0x040065A8 RID: 26024
		public const int NodeIdFieldNumber = 2;

		// Token: 0x040065A9 RID: 26025
		private int nodeId_;

		// Token: 0x040065AA RID: 26026
		public const int IncIdFieldNumber = 3;

		// Token: 0x040065AB RID: 26027
		private long incId_;
	}
}

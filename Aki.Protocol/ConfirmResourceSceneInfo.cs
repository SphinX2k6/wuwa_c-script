using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DB RID: 731
	public sealed class ConfirmResourceSceneInfo : IMessage<ConfirmResourceSceneInfo>, IMessage, IEquatable<ConfirmResourceSceneInfo>, IDeepCloneable<ConfirmResourceSceneInfo>, IBufferMessage
	{
		// Token: 0x06004AF4 RID: 19188 RVA: 0x000B75BE File Offset: 0x000B57BE
		[NullableContext(1)]
		public static ConfirmResourceSceneInfo Create()
		{
			return new ConfirmResourceSceneInfo();
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x000B75C5 File Offset: 0x000B57C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConfirmResourceSceneInfo> Parser
		{
			get
			{
				return ConfirmResourceSceneInfo._parser;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x000B75CC File Offset: 0x000B57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x000B75CF File Offset: 0x000B57CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmResourceSceneInfo.Descriptor;
			}
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x000B75D6 File Offset: 0x000B57D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo()
		{
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x000B75E0 File Offset: 0x000B57E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo(ConfirmResourceSceneInfo other) : this()
		{
			this.instanceId_ = other.instanceId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x000B762C File Offset: 0x000B582C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo Clone()
		{
			return new ConfirmResourceSceneInfo(this);
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x000B7634 File Offset: 0x000B5834
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x000B763C File Offset: 0x000B583C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x000B7645 File Offset: 0x000B5845
		// (set) Token: 0x06004AFE RID: 19198 RVA: 0x000B764D File Offset: 0x000B584D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x000B7656 File Offset: 0x000B5856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmResourceSceneInfo);
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x000B7664 File Offset: 0x000B5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmResourceSceneInfo other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x000B76B4 File Offset: 0x000B58B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x000B7709 File Offset: 0x000B5909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x000B7716 File Offset: 0x000B5916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x000B7720 File Offset: 0x000B5920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstanceId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x000B7778 File Offset: 0x000B5978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x000B77D0 File Offset: 0x000B59D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmResourceSceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x000B7838 File Offset: 0x000B5A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x000B7844 File Offset: 0x000B5A44
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.InstanceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030F9 RID: 12537
		private static readonly MessageParser<ConfirmResourceSceneInfo> _parser = new MessageParser<ConfirmResourceSceneInfo>(() => new ConfirmResourceSceneInfo());

		// Token: 0x040030FA RID: 12538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030FB RID: 12539
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x040030FC RID: 12540
		private int instanceId_;

		// Token: 0x040030FD RID: 12541
		public const int LocationFieldNumber = 2;

		// Token: 0x040030FE RID: 12542
		private Vector location_;
	}
}

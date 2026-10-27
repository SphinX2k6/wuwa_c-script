using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CB RID: 971
	public sealed class DetectionEntityPosInfo : IMessage<DetectionEntityPosInfo>, IMessage, IEquatable<DetectionEntityPosInfo>, IDeepCloneable<DetectionEntityPosInfo>, IBufferMessage
	{
		// Token: 0x06005EC1 RID: 24257 RVA: 0x000E55E1 File Offset: 0x000E37E1
		[NullableContext(1)]
		public static DetectionEntityPosInfo Create()
		{
			return new DetectionEntityPosInfo();
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x000E55E8 File Offset: 0x000E37E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionEntityPosInfo> Parser
		{
			get
			{
				return DetectionEntityPosInfo._parser;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x000E55EF File Offset: 0x000E37EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x000E55F2 File Offset: 0x000E37F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionEntityPosInfo.Descriptor;
			}
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x000E55F9 File Offset: 0x000E37F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo()
		{
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x000E5604 File Offset: 0x000E3804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo(DetectionEntityPosInfo other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x000E5650 File Offset: 0x000E3850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo Clone()
		{
			return new DetectionEntityPosInfo(this);
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x000E5658 File Offset: 0x000E3858
		// (set) Token: 0x06005EC9 RID: 24265 RVA: 0x000E5660 File Offset: 0x000E3860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x000E5669 File Offset: 0x000E3869
		// (set) Token: 0x06005ECB RID: 24267 RVA: 0x000E5671 File Offset: 0x000E3871
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

		// Token: 0x06005ECC RID: 24268 RVA: 0x000E567A File Offset: 0x000E387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionEntityPosInfo);
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x000E5688 File Offset: 0x000E3888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionEntityPosInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x000E56D8 File Offset: 0x000E38D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
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

		// Token: 0x06005ECF RID: 24271 RVA: 0x000E572D File Offset: 0x000E392D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x000E573A File Offset: 0x000E393A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x000E5744 File Offset: 0x000E3944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
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

		// Token: 0x06005ED2 RID: 24274 RVA: 0x000E57A0 File Offset: 0x000E39A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
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

		// Token: 0x06005ED3 RID: 24275 RVA: 0x000E57F8 File Offset: 0x000E39F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionEntityPosInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x000E5860 File Offset: 0x000E3A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x000E586C File Offset: 0x000E3A6C
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
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x040036DD RID: 14045
		private static readonly MessageParser<DetectionEntityPosInfo> _parser = new MessageParser<DetectionEntityPosInfo>(() => new DetectionEntityPosInfo());

		// Token: 0x040036DE RID: 14046
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036DF RID: 14047
		public const int PosFieldNumber = 1;

		// Token: 0x040036E0 RID: 14048
		private Vector pos_;

		// Token: 0x040036E1 RID: 14049
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x040036E2 RID: 14050
		private int configId_;
	}
}

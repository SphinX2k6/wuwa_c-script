using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B4 RID: 948
	public sealed class DetectionEntityPosInfo : IMessage<DetectionEntityPosInfo>, IMessage, IEquatable<DetectionEntityPosInfo>, IDeepCloneable<DetectionEntityPosInfo>, IBufferMessage
	{
		// Token: 0x06005D31 RID: 23857 RVA: 0x000E245D File Offset: 0x000E065D
		[NullableContext(1)]
		public static DetectionEntityPosInfo Create()
		{
			return new DetectionEntityPosInfo();
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06005D32 RID: 23858 RVA: 0x000E2464 File Offset: 0x000E0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionEntityPosInfo> Parser
		{
			get
			{
				return DetectionEntityPosInfo._parser;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06005D33 RID: 23859 RVA: 0x000E246B File Offset: 0x000E066B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x000E246E File Offset: 0x000E066E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionEntityPosInfo.Descriptor;
			}
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x000E2475 File Offset: 0x000E0675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo()
		{
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x000E2480 File Offset: 0x000E0680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo(DetectionEntityPosInfo other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x000E24CC File Offset: 0x000E06CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo Clone()
		{
			return new DetectionEntityPosInfo(this);
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06005D38 RID: 23864 RVA: 0x000E24D4 File Offset: 0x000E06D4
		// (set) Token: 0x06005D39 RID: 23865 RVA: 0x000E24DC File Offset: 0x000E06DC
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

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06005D3A RID: 23866 RVA: 0x000E24E5 File Offset: 0x000E06E5
		// (set) Token: 0x06005D3B RID: 23867 RVA: 0x000E24ED File Offset: 0x000E06ED
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

		// Token: 0x06005D3C RID: 23868 RVA: 0x000E24F6 File Offset: 0x000E06F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionEntityPosInfo);
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x000E2504 File Offset: 0x000E0704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionEntityPosInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x000E2554 File Offset: 0x000E0754
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

		// Token: 0x06005D3F RID: 23871 RVA: 0x000E25A9 File Offset: 0x000E07A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x000E25B6 File Offset: 0x000E07B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x000E25C0 File Offset: 0x000E07C0
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

		// Token: 0x06005D42 RID: 23874 RVA: 0x000E261C File Offset: 0x000E081C
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

		// Token: 0x06005D43 RID: 23875 RVA: 0x000E2674 File Offset: 0x000E0874
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

		// Token: 0x06005D44 RID: 23876 RVA: 0x000E26DC File Offset: 0x000E08DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x000E26E8 File Offset: 0x000E08E8
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

		// Token: 0x040036CA RID: 14026
		private static readonly MessageParser<DetectionEntityPosInfo> _parser = new MessageParser<DetectionEntityPosInfo>(() => new DetectionEntityPosInfo());

		// Token: 0x040036CB RID: 14027
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036CC RID: 14028
		public const int PosFieldNumber = 1;

		// Token: 0x040036CD RID: 14029
		private Vector pos_;

		// Token: 0x040036CE RID: 14030
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x040036CF RID: 14031
		private int configId_;
	}
}

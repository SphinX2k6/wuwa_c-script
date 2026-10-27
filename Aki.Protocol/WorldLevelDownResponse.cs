using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151B RID: 5403
	[NetMessage(EMessageId.WorldLevelDownResponse)]
	public sealed class WorldLevelDownResponse : IMessage<WorldLevelDownResponse>, IMessage, IEquatable<WorldLevelDownResponse>, IDeepCloneable<WorldLevelDownResponse>, IBufferMessage
	{
		// Token: 0x0601C8C3 RID: 116931 RVA: 0x0041F1BE File Offset: 0x0041D3BE
		[NullableContext(1)]
		public static WorldLevelDownResponse Create()
		{
			return new WorldLevelDownResponse();
		}

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x0601C8C4 RID: 116932 RVA: 0x0041F1C5 File Offset: 0x0041D3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x0601C8C5 RID: 116933 RVA: 0x0041F1C8 File Offset: 0x0041D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelDownResponse.Descriptor;
			}
		}

		// Token: 0x0601C8C6 RID: 116934 RVA: 0x0041F1CF File Offset: 0x0041D3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse()
		{
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x0041F1D8 File Offset: 0x0041D3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse(WorldLevelDownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.originWorldLevel_ = other.originWorldLevel_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.worldLevelTimeStamp_ = other.worldLevelTimeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x0041F22C File Offset: 0x0041D42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse Clone()
		{
			return new WorldLevelDownResponse(this);
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x0601C8C9 RID: 116937 RVA: 0x0041F234 File Offset: 0x0041D434
		// (set) Token: 0x0601C8CA RID: 116938 RVA: 0x0041F23C File Offset: 0x0041D43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x0601C8CB RID: 116939 RVA: 0x0041F245 File Offset: 0x0041D445
		// (set) Token: 0x0601C8CC RID: 116940 RVA: 0x0041F24D File Offset: 0x0041D44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginWorldLevel
		{
			get
			{
				return this.originWorldLevel_;
			}
			set
			{
				this.originWorldLevel_ = value;
			}
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x0601C8CD RID: 116941 RVA: 0x0041F256 File Offset: 0x0041D456
		// (set) Token: 0x0601C8CE RID: 116942 RVA: 0x0041F25E File Offset: 0x0041D45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWorldLevel
		{
			get
			{
				return this.curWorldLevel_;
			}
			set
			{
				this.curWorldLevel_ = value;
			}
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x0601C8CF RID: 116943 RVA: 0x0041F267 File Offset: 0x0041D467
		// (set) Token: 0x0601C8D0 RID: 116944 RVA: 0x0041F26F File Offset: 0x0041D46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevelTimeStamp
		{
			get
			{
				return this.worldLevelTimeStamp_;
			}
			set
			{
				this.worldLevelTimeStamp_ = value;
			}
		}

		// Token: 0x0601C8D1 RID: 116945 RVA: 0x0041F278 File Offset: 0x0041D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelDownResponse);
		}

		// Token: 0x0601C8D2 RID: 116946 RVA: 0x0041F288 File Offset: 0x0041D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelDownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.WorldLevelTimeStamp == other.WorldLevelTimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8D3 RID: 116947 RVA: 0x0041F2F4 File Offset: 0x0041D4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.OriginWorldLevel != 0)
			{
				num ^= this.OriginWorldLevel.GetHashCode();
			}
			if (this.CurWorldLevel != 0)
			{
				num ^= this.CurWorldLevel.GetHashCode();
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num ^= this.WorldLevelTimeStamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C8D4 RID: 116948 RVA: 0x0041F384 File Offset: 0x0041D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8D5 RID: 116949 RVA: 0x0041F391 File Offset: 0x0041D591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8D6 RID: 116950 RVA: 0x0041F39C File Offset: 0x0041D59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OriginWorldLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.WorldLevelTimeStamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8D7 RID: 116951 RVA: 0x0041F430 File Offset: 0x0041D630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.OriginWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWorldLevel);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevelTimeStamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C8D8 RID: 116952 RVA: 0x0041F4B8 File Offset: 0x0041D6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelDownResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.OriginWorldLevel != 0)
			{
				this.OriginWorldLevel = other.OriginWorldLevel;
			}
			if (other.CurWorldLevel != 0)
			{
				this.CurWorldLevel = other.CurWorldLevel;
			}
			if (other.WorldLevelTimeStamp != 0)
			{
				this.WorldLevelTimeStamp = other.WorldLevelTimeStamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8D9 RID: 116953 RVA: 0x0041F530 File Offset: 0x0041D730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8DA RID: 116954 RVA: 0x0041F53C File Offset: 0x0041D73C
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.OriginWorldLevel = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CurWorldLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.WorldLevelTimeStamp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A33E RID: 41790
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A33F RID: 41791
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A340 RID: 41792
		private ErrorCode errorCode_;

		// Token: 0x0400A341 RID: 41793
		public const int OriginWorldLevelFieldNumber = 2;

		// Token: 0x0400A342 RID: 41794
		private int originWorldLevel_;

		// Token: 0x0400A343 RID: 41795
		public const int CurWorldLevelFieldNumber = 8;

		// Token: 0x0400A344 RID: 41796
		private int curWorldLevel_;

		// Token: 0x0400A345 RID: 41797
		public const int WorldLevelTimeStampFieldNumber = 13;

		// Token: 0x0400A346 RID: 41798
		private int worldLevelTimeStamp_;
	}
}

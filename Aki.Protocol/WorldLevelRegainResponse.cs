using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151D RID: 5405
	[NetMessage(EMessageId.WorldLevelRegainResponse)]
	public sealed class WorldLevelRegainResponse : IMessage<WorldLevelRegainResponse>, IMessage, IEquatable<WorldLevelRegainResponse>, IDeepCloneable<WorldLevelRegainResponse>, IBufferMessage
	{
		// Token: 0x0601C8EB RID: 116971 RVA: 0x0041F6FA File Offset: 0x0041D8FA
		[NullableContext(1)]
		public static WorldLevelRegainResponse Create()
		{
			return new WorldLevelRegainResponse();
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x0601C8EC RID: 116972 RVA: 0x0041F701 File Offset: 0x0041D901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x0601C8ED RID: 116973 RVA: 0x0041F704 File Offset: 0x0041D904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelRegainResponse.Descriptor;
			}
		}

		// Token: 0x0601C8EE RID: 116974 RVA: 0x0041F70B File Offset: 0x0041D90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse()
		{
		}

		// Token: 0x0601C8EF RID: 116975 RVA: 0x0041F714 File Offset: 0x0041D914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse(WorldLevelRegainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.originWorldLevel_ = other.originWorldLevel_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.worldLevelTimeStamp_ = other.worldLevelTimeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8F0 RID: 116976 RVA: 0x0041F768 File Offset: 0x0041D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse Clone()
		{
			return new WorldLevelRegainResponse(this);
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x0601C8F1 RID: 116977 RVA: 0x0041F770 File Offset: 0x0041D970
		// (set) Token: 0x0601C8F2 RID: 116978 RVA: 0x0041F778 File Offset: 0x0041D978
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

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x0601C8F3 RID: 116979 RVA: 0x0041F781 File Offset: 0x0041D981
		// (set) Token: 0x0601C8F4 RID: 116980 RVA: 0x0041F789 File Offset: 0x0041D989
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

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x0601C8F5 RID: 116981 RVA: 0x0041F792 File Offset: 0x0041D992
		// (set) Token: 0x0601C8F6 RID: 116982 RVA: 0x0041F79A File Offset: 0x0041D99A
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

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x0601C8F7 RID: 116983 RVA: 0x0041F7A3 File Offset: 0x0041D9A3
		// (set) Token: 0x0601C8F8 RID: 116984 RVA: 0x0041F7AB File Offset: 0x0041D9AB
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

		// Token: 0x0601C8F9 RID: 116985 RVA: 0x0041F7B4 File Offset: 0x0041D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelRegainResponse);
		}

		// Token: 0x0601C8FA RID: 116986 RVA: 0x0041F7C4 File Offset: 0x0041D9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelRegainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.WorldLevelTimeStamp == other.WorldLevelTimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8FB RID: 116987 RVA: 0x0041F830 File Offset: 0x0041DA30
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

		// Token: 0x0601C8FC RID: 116988 RVA: 0x0041F8C0 File Offset: 0x0041DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8FD RID: 116989 RVA: 0x0041F8CD File Offset: 0x0041DACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8FE RID: 116990 RVA: 0x0041F8D8 File Offset: 0x0041DAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OriginWorldLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WorldLevelTimeStamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8FF RID: 116991 RVA: 0x0041F968 File Offset: 0x0041DB68
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

		// Token: 0x0601C900 RID: 116992 RVA: 0x0041F9F0 File Offset: 0x0041DBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelRegainResponse other)
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

		// Token: 0x0601C901 RID: 116993 RVA: 0x0041FA68 File Offset: 0x0041DC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C902 RID: 116994 RVA: 0x0041FA74 File Offset: 0x0041DC74
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.OriginWorldLevel = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.CurWorldLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.WorldLevelTimeStamp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A348 RID: 41800
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A349 RID: 41801
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A34A RID: 41802
		private ErrorCode errorCode_;

		// Token: 0x0400A34B RID: 41803
		public const int OriginWorldLevelFieldNumber = 1;

		// Token: 0x0400A34C RID: 41804
		private int originWorldLevel_;

		// Token: 0x0400A34D RID: 41805
		public const int CurWorldLevelFieldNumber = 6;

		// Token: 0x0400A34E RID: 41806
		private int curWorldLevel_;

		// Token: 0x0400A34F RID: 41807
		public const int WorldLevelTimeStampFieldNumber = 15;

		// Token: 0x0400A350 RID: 41808
		private int worldLevelTimeStamp_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B8 RID: 952
	[NetMessage(EMessageId.DetectionResponse)]
	public sealed class DetectionResponse : IMessage<DetectionResponse>, IMessage, IEquatable<DetectionResponse>, IDeepCloneable<DetectionResponse>, IBufferMessage
	{
		// Token: 0x06005D82 RID: 23938 RVA: 0x000E2F8A File Offset: 0x000E118A
		[NullableContext(1)]
		public static DetectionResponse Create()
		{
			return new DetectionResponse();
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x000E2F91 File Offset: 0x000E1191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x000E2F94 File Offset: 0x000E1194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionResponse.Descriptor;
			}
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x000E2F9B File Offset: 0x000E119B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse()
		{
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x000E2FB0 File Offset: 0x000E11B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse(DetectionResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this.detectionConfId_ = other.detectionConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x000E2FFD File Offset: 0x000E11FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse Clone()
		{
			return new DetectionResponse(this);
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x000E3005 File Offset: 0x000E1205
		// (set) Token: 0x06005D89 RID: 23945 RVA: 0x000E300D File Offset: 0x000E120D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06005D8A RID: 23946 RVA: 0x000E3016 File Offset: 0x000E1216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06005D8B RID: 23947 RVA: 0x000E301E File Offset: 0x000E121E
		// (set) Token: 0x06005D8C RID: 23948 RVA: 0x000E3026 File Offset: 0x000E1226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionConfId
		{
			get
			{
				return this.detectionConfId_;
			}
			set
			{
				this.detectionConfId_ = value;
			}
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x000E302F File Offset: 0x000E122F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionResponse);
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x000E3040 File Offset: 0x000E1240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionTarget_.Equals(other.detectionTarget_) && this.DetectionConfId == other.DetectionConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x000E30A0 File Offset: 0x000E12A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.detectionTarget_.GetHashCode();
			if (this.DetectionConfId != 0)
			{
				num ^= this.DetectionConfId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x000E310C File Offset: 0x000E130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x000E3119 File Offset: 0x000E1319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x000E3124 File Offset: 0x000E1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.detectionTarget_.WriteTo(ref output, DetectionResponse._repeated_detectionTarget_codec);
			if (this.DetectionConfId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DetectionConfId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x000E3190 File Offset: 0x000E1390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.detectionTarget_.CalculateSize(DetectionResponse._repeated_detectionTarget_codec);
			if (this.DetectionConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionConfId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x000E31FC File Offset: 0x000E13FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			if (other.DetectionConfId != 0)
			{
				this.DetectionConfId = other.DetectionConfId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x000E325D File Offset: 0x000E145D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x000E3268 File Offset: 0x000E1468
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
				if (num != 18U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.DetectionConfId = input.ReadInt32();
					}
				}
				else
				{
					this.detectionTarget_.AddEntriesFrom(ref input, DetectionResponse._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x040036E2 RID: 14050
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E3 RID: 14051
		public const int CodeFieldNumber = 11;

		// Token: 0x040036E4 RID: 14052
		private ErrorCode code_;

		// Token: 0x040036E5 RID: 14053
		public const int DetectionTargetFieldNumber = 2;

		// Token: 0x040036E6 RID: 14054
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(18U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040036E7 RID: 14055
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();

		// Token: 0x040036E8 RID: 14056
		public const int DetectionConfIdFieldNumber = 9;

		// Token: 0x040036E9 RID: 14057
		private int detectionConfId_;
	}
}

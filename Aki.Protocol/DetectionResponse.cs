using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CF RID: 975
	[NetMessage(EMessageId.DetectionResponse)]
	public sealed class DetectionResponse : IMessage<DetectionResponse>, IMessage, IEquatable<DetectionResponse>, IDeepCloneable<DetectionResponse>, IBufferMessage
	{
		// Token: 0x06005F12 RID: 24338 RVA: 0x000E610E File Offset: 0x000E430E
		[NullableContext(1)]
		public static DetectionResponse Create()
		{
			return new DetectionResponse();
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x000E6115 File Offset: 0x000E4315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x000E6118 File Offset: 0x000E4318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionResponse.Descriptor;
			}
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x000E611F File Offset: 0x000E431F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse()
		{
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x000E6134 File Offset: 0x000E4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse(DetectionResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this.detectionConfId_ = other.detectionConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x000E6181 File Offset: 0x000E4381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionResponse Clone()
		{
			return new DetectionResponse(this);
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x000E6189 File Offset: 0x000E4389
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x000E6191 File Offset: 0x000E4391
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

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x000E619A File Offset: 0x000E439A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x000E61A2 File Offset: 0x000E43A2
		// (set) Token: 0x06005F1C RID: 24348 RVA: 0x000E61AA File Offset: 0x000E43AA
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

		// Token: 0x06005F1D RID: 24349 RVA: 0x000E61B3 File Offset: 0x000E43B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionResponse);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x000E61C4 File Offset: 0x000E43C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionTarget_.Equals(other.detectionTarget_) && this.DetectionConfId == other.DetectionConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x000E6224 File Offset: 0x000E4424
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

		// Token: 0x06005F20 RID: 24352 RVA: 0x000E6290 File Offset: 0x000E4490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x000E629D File Offset: 0x000E449D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x000E62A8 File Offset: 0x000E44A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.detectionTarget_.WriteTo(ref output, DetectionResponse._repeated_detectionTarget_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this.DetectionConfId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DetectionConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x000E6314 File Offset: 0x000E4514
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

		// Token: 0x06005F24 RID: 24356 RVA: 0x000E6380 File Offset: 0x000E4580
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

		// Token: 0x06005F25 RID: 24357 RVA: 0x000E63E1 File Offset: 0x000E45E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x000E63EC File Offset: 0x000E45EC
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
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DetectionConfId = input.ReadInt32();
						}
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.detectionTarget_.AddEntriesFrom(ref input, DetectionResponse._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x040036F5 RID: 14069
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F6 RID: 14070
		public const int CodeFieldNumber = 7;

		// Token: 0x040036F7 RID: 14071
		private ErrorCode code_;

		// Token: 0x040036F8 RID: 14072
		public const int DetectionTargetFieldNumber = 1;

		// Token: 0x040036F9 RID: 14073
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(10U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040036FA RID: 14074
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();

		// Token: 0x040036FB RID: 14075
		public const int DetectionConfIdFieldNumber = 9;

		// Token: 0x040036FC RID: 14076
		private int detectionConfId_;
	}
}

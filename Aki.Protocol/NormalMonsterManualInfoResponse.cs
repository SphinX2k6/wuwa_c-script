using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B52 RID: 2898
	[NetMessage(EMessageId.NormalMonsterManualInfoResponse)]
	public sealed class NormalMonsterManualInfoResponse : IMessage<NormalMonsterManualInfoResponse>, IMessage, IEquatable<NormalMonsterManualInfoResponse>, IDeepCloneable<NormalMonsterManualInfoResponse>, IBufferMessage
	{
		// Token: 0x0600FB74 RID: 64372 RVA: 0x0024A3A1 File Offset: 0x002485A1
		[NullableContext(1)]
		public static NormalMonsterManualInfoResponse Create()
		{
			return new NormalMonsterManualInfoResponse();
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600FB75 RID: 64373 RVA: 0x0024A3A8 File Offset: 0x002485A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600FB76 RID: 64374 RVA: 0x0024A3AB File Offset: 0x002485AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalMonsterManualInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600FB77 RID: 64375 RVA: 0x0024A3B2 File Offset: 0x002485B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse()
		{
		}

		// Token: 0x0600FB78 RID: 64376 RVA: 0x0024A3C5 File Offset: 0x002485C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse(NormalMonsterManualInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB79 RID: 64377 RVA: 0x0024A3FB File Offset: 0x002485FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse Clone()
		{
			return new NormalMonsterManualInfoResponse(this);
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600FB7A RID: 64378 RVA: 0x0024A403 File Offset: 0x00248603
		// (set) Token: 0x0600FB7B RID: 64379 RVA: 0x0024A40B File Offset: 0x0024860B
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

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600FB7C RID: 64380 RVA: 0x0024A414 File Offset: 0x00248614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x0600FB7D RID: 64381 RVA: 0x0024A41C File Offset: 0x0024861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalMonsterManualInfoResponse);
		}

		// Token: 0x0600FB7E RID: 64382 RVA: 0x0024A42C File Offset: 0x0024862C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalMonsterManualInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB7F RID: 64383 RVA: 0x0024A47C File Offset: 0x0024867C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB80 RID: 64384 RVA: 0x0024A4CF File Offset: 0x002486CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB81 RID: 64385 RVA: 0x0024A4DC File Offset: 0x002486DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB82 RID: 64386 RVA: 0x0024A4E8 File Offset: 0x002486E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			this.detectionTarget_.WriteTo(ref output, NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB83 RID: 64387 RVA: 0x0024A538 File Offset: 0x00248738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.detectionTarget_.CalculateSize(NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB84 RID: 64388 RVA: 0x0024A58C File Offset: 0x0024878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalMonsterManualInfoResponse other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB85 RID: 64389 RVA: 0x0024A5D9 File Offset: 0x002487D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB86 RID: 64390 RVA: 0x0024A5E4 File Offset: 0x002487E4
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
				if (num != 80U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.detectionTarget_.AddEntriesFrom(ref input, NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040064D2 RID: 25810
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064D3 RID: 25811
		public const int CodeFieldNumber = 10;

		// Token: 0x040064D4 RID: 25812
		private ErrorCode code_;

		// Token: 0x040064D5 RID: 25813
		public const int DetectionTargetFieldNumber = 11;

		// Token: 0x040064D6 RID: 25814
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(90U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040064D7 RID: 25815
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}

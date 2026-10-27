using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110A RID: 4362
	[NetMessage(EMessageId.RoverRogueInsListResponse)]
	public sealed class RoverRogueInsListResponse : IMessage<RoverRogueInsListResponse>, IMessage, IEquatable<RoverRogueInsListResponse>, IDeepCloneable<RoverRogueInsListResponse>, IBufferMessage
	{
		// Token: 0x06017442 RID: 95298 RVA: 0x00360EA5 File Offset: 0x0035F0A5
		[NullableContext(1)]
		public static RoverRogueInsListResponse Create()
		{
			return new RoverRogueInsListResponse();
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x06017443 RID: 95299 RVA: 0x00360EAC File Offset: 0x0035F0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x06017444 RID: 95300 RVA: 0x00360EAF File Offset: 0x0035F0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsListResponse.Descriptor;
			}
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x00360EB6 File Offset: 0x0035F0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse()
		{
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x00360EC9 File Offset: 0x0035F0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse(RoverRogueInsListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x00360EFF File Offset: 0x0035F0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse Clone()
		{
			return new RoverRogueInsListResponse(this);
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x06017448 RID: 95304 RVA: 0x00360F07 File Offset: 0x0035F107
		// (set) Token: 0x06017449 RID: 95305 RVA: 0x00360F0F File Offset: 0x0035F10F
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

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x0601744A RID: 95306 RVA: 0x00360F18 File Offset: 0x0035F118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueInsEntry> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x0601744B RID: 95307 RVA: 0x00360F20 File Offset: 0x0035F120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsListResponse);
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x00360F30 File Offset: 0x0035F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.list_.Equals(other.list_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601744D RID: 95309 RVA: 0x00360F80 File Offset: 0x0035F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.list_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x00360FD3 File Offset: 0x0035F1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601744F RID: 95311 RVA: 0x00360FE0 File Offset: 0x0035F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017450 RID: 95312 RVA: 0x00360FEC File Offset: 0x0035F1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, RoverRogueInsListResponse._repeated_list_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017451 RID: 95313 RVA: 0x0036103C File Offset: 0x0035F23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.list_.CalculateSize(RoverRogueInsListResponse._repeated_list_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017452 RID: 95314 RVA: 0x00361090 File Offset: 0x0035F290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.list_.Add(other.list_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017453 RID: 95315 RVA: 0x003610DD File Offset: 0x0035F2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017454 RID: 95316 RVA: 0x003610E8 File Offset: 0x0035F2E8
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
				if (num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.list_.AddEntriesFrom(ref input, RoverRogueInsListResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x04008A6F RID: 35439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A70 RID: 35440
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008A71 RID: 35441
		private ErrorCode errorCode_;

		// Token: 0x04008A72 RID: 35442
		public const int ListFieldNumber = 5;

		// Token: 0x04008A73 RID: 35443
		private static readonly FieldCodec<RoverRogueInsEntry> _repeated_list_codec = FieldCodec.ForMessage<RoverRogueInsEntry>(42U, RoverRogueInsEntry.Parser);

		// Token: 0x04008A74 RID: 35444
		private readonly RepeatedField<RoverRogueInsEntry> list_ = new RepeatedField<RoverRogueInsEntry>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001158 RID: 4440
	[NetMessage(EMessageId.RoverRogueResultResponse)]
	public sealed class RoverRogueResultResponse : IMessage<RoverRogueResultResponse>, IMessage, IEquatable<RoverRogueResultResponse>, IDeepCloneable<RoverRogueResultResponse>, IBufferMessage
	{
		// Token: 0x06017BA3 RID: 97187 RVA: 0x003746AC File Offset: 0x003728AC
		[NullableContext(1)]
		public static RoverRogueResultResponse Create()
		{
			return new RoverRogueResultResponse();
		}

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06017BA4 RID: 97188 RVA: 0x003746B3 File Offset: 0x003728B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06017BA5 RID: 97189 RVA: 0x003746B6 File Offset: 0x003728B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultResponse.Descriptor;
			}
		}

		// Token: 0x06017BA6 RID: 97190 RVA: 0x003746BD File Offset: 0x003728BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse()
		{
		}

		// Token: 0x06017BA7 RID: 97191 RVA: 0x003746C8 File Offset: 0x003728C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse(RoverRogueResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.resultInfo_ = ((other.resultInfo_ != null) ? other.resultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BA8 RID: 97192 RVA: 0x00374714 File Offset: 0x00372914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse Clone()
		{
			return new RoverRogueResultResponse(this);
		}

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x06017BA9 RID: 97193 RVA: 0x0037471C File Offset: 0x0037291C
		// (set) Token: 0x06017BAA RID: 97194 RVA: 0x00374724 File Offset: 0x00372924
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

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06017BAB RID: 97195 RVA: 0x0037472D File Offset: 0x0037292D
		// (set) Token: 0x06017BAC RID: 97196 RVA: 0x00374735 File Offset: 0x00372935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo ResultInfo
		{
			get
			{
				return this.resultInfo_;
			}
			set
			{
				this.resultInfo_ = value;
			}
		}

		// Token: 0x06017BAD RID: 97197 RVA: 0x0037473E File Offset: 0x0037293E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultResponse);
		}

		// Token: 0x06017BAE RID: 97198 RVA: 0x0037474C File Offset: 0x0037294C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ResultInfo, other.ResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BAF RID: 97199 RVA: 0x0037479C File Offset: 0x0037299C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.resultInfo_ != null)
			{
				num ^= this.ResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017BB0 RID: 97200 RVA: 0x003747F7 File Offset: 0x003729F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BB1 RID: 97201 RVA: 0x00374804 File Offset: 0x00372A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BB2 RID: 97202 RVA: 0x00374810 File Offset: 0x00372A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.resultInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017BB3 RID: 97203 RVA: 0x00374868 File Offset: 0x00372A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.resultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017BB4 RID: 97204 RVA: 0x003748C0 File Offset: 0x00372AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.resultInfo_ != null)
			{
				if (this.resultInfo_ == null)
				{
					this.ResultInfo = new RoverRogueResultInfo();
				}
				this.ResultInfo.MergeFrom(other.ResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017BB5 RID: 97205 RVA: 0x00374928 File Offset: 0x00372B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BB6 RID: 97206 RVA: 0x00374934 File Offset: 0x00372B34
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.resultInfo_ == null)
						{
							this.ResultInfo = new RoverRogueResultInfo();
						}
						input.ReadMessage(this.ResultInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008DA3 RID: 36259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DA4 RID: 36260
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008DA5 RID: 36261
		private ErrorCode errorCode_;

		// Token: 0x04008DA6 RID: 36262
		public const int ResultInfoFieldNumber = 10;

		// Token: 0x04008DA7 RID: 36263
		private RoverRogueResultInfo resultInfo_;
	}
}

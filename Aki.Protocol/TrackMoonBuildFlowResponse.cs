using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DE RID: 5086
	[NetMessage(EMessageId.TrackMoonBuildFlowResponse)]
	public sealed class TrackMoonBuildFlowResponse : IMessage<TrackMoonBuildFlowResponse>, IMessage, IEquatable<TrackMoonBuildFlowResponse>, IDeepCloneable<TrackMoonBuildFlowResponse>, IBufferMessage
	{
		// Token: 0x0601AF6F RID: 110447 RVA: 0x003E827D File Offset: 0x003E647D
		[NullableContext(1)]
		public static TrackMoonBuildFlowResponse Create()
		{
			return new TrackMoonBuildFlowResponse();
		}

		// Token: 0x17005AE8 RID: 23272
		// (get) Token: 0x0601AF70 RID: 110448 RVA: 0x003E8284 File Offset: 0x003E6484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AE9 RID: 23273
		// (get) Token: 0x0601AF71 RID: 110449 RVA: 0x003E8287 File Offset: 0x003E6487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildFlowResponse.Descriptor;
			}
		}

		// Token: 0x0601AF72 RID: 110450 RVA: 0x003E828E File Offset: 0x003E648E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse()
		{
		}

		// Token: 0x0601AF73 RID: 110451 RVA: 0x003E8296 File Offset: 0x003E6496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse(TrackMoonBuildFlowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF74 RID: 110452 RVA: 0x003E82BB File Offset: 0x003E64BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowResponse Clone()
		{
			return new TrackMoonBuildFlowResponse(this);
		}

		// Token: 0x17005AEA RID: 23274
		// (get) Token: 0x0601AF75 RID: 110453 RVA: 0x003E82C3 File Offset: 0x003E64C3
		// (set) Token: 0x0601AF76 RID: 110454 RVA: 0x003E82CB File Offset: 0x003E64CB
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

		// Token: 0x0601AF77 RID: 110455 RVA: 0x003E82D4 File Offset: 0x003E64D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildFlowResponse);
		}

		// Token: 0x0601AF78 RID: 110456 RVA: 0x003E82E2 File Offset: 0x003E64E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildFlowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF79 RID: 110457 RVA: 0x003E8310 File Offset: 0x003E6510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF7A RID: 110458 RVA: 0x003E8355 File Offset: 0x003E6555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF7B RID: 110459 RVA: 0x003E8362 File Offset: 0x003E6562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF7C RID: 110460 RVA: 0x003E836B File Offset: 0x003E656B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF7D RID: 110461 RVA: 0x003E83A0 File Offset: 0x003E65A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF7E RID: 110462 RVA: 0x003E83DE File Offset: 0x003E65DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonBuildFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF7F RID: 110463 RVA: 0x003E840F File Offset: 0x003E660F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF80 RID: 110464 RVA: 0x003E8418 File Offset: 0x003E6618
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C3B RID: 39995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C3C RID: 39996
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009C3D RID: 39997
		private ErrorCode errorCode_;
	}
}

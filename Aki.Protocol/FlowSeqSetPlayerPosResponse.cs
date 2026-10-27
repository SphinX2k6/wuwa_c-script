using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000603 RID: 1539
	[NetMessage(EMessageId.FlowSeqSetPlayerPosResponse)]
	public sealed class FlowSeqSetPlayerPosResponse : IMessage<FlowSeqSetPlayerPosResponse>, IMessage, IEquatable<FlowSeqSetPlayerPosResponse>, IDeepCloneable<FlowSeqSetPlayerPosResponse>, IBufferMessage
	{
		// Token: 0x06008E57 RID: 36439 RVA: 0x0015900A File Offset: 0x0015720A
		[NullableContext(1)]
		public static FlowSeqSetPlayerPosResponse Create()
		{
			return new FlowSeqSetPlayerPosResponse();
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06008E58 RID: 36440 RVA: 0x00159011 File Offset: 0x00157211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x00159014 File Offset: 0x00157214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowSeqSetPlayerPosResponse.Descriptor;
			}
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x0015901B File Offset: 0x0015721B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse()
		{
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x00159023 File Offset: 0x00157223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse(FlowSeqSetPlayerPosResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00159048 File Offset: 0x00157248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse Clone()
		{
			return new FlowSeqSetPlayerPosResponse(this);
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x00159050 File Offset: 0x00157250
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x00159058 File Offset: 0x00157258
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

		// Token: 0x06008E5F RID: 36447 RVA: 0x00159061 File Offset: 0x00157261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowSeqSetPlayerPosResponse);
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x0015906F File Offset: 0x0015726F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowSeqSetPlayerPosResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x001590A0 File Offset: 0x001572A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x001590E5 File Offset: 0x001572E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x001590F2 File Offset: 0x001572F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x001590FB File Offset: 0x001572FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x00159130 File Offset: 0x00157330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x0015916E File Offset: 0x0015736E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowSeqSetPlayerPosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x0015919F File Offset: 0x0015739F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x001591A8 File Offset: 0x001573A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004551 RID: 17745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004552 RID: 17746
		public const int CodeFieldNumber = 10;

		// Token: 0x04004553 RID: 17747
		private ErrorCode code_;
	}
}

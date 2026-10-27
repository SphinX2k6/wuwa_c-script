using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001170 RID: 4464
	[NetMessage(EMessageId.SceneItemSequenceFrameEndResponse)]
	public sealed class SceneItemSequenceFrameEndResponse : IMessage<SceneItemSequenceFrameEndResponse>, IMessage, IEquatable<SceneItemSequenceFrameEndResponse>, IDeepCloneable<SceneItemSequenceFrameEndResponse>, IBufferMessage
	{
		// Token: 0x06017CC9 RID: 97481 RVA: 0x003750C9 File Offset: 0x003732C9
		[NullableContext(1)]
		public static SceneItemSequenceFrameEndResponse Create()
		{
			return new SceneItemSequenceFrameEndResponse();
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x06017CCA RID: 97482 RVA: 0x003750D0 File Offset: 0x003732D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x06017CCB RID: 97483 RVA: 0x003750D3 File Offset: 0x003732D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameEndResponse.Descriptor;
			}
		}

		// Token: 0x06017CCC RID: 97484 RVA: 0x003750DA File Offset: 0x003732DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse()
		{
		}

		// Token: 0x06017CCD RID: 97485 RVA: 0x003750E2 File Offset: 0x003732E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse(SceneItemSequenceFrameEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CCE RID: 97486 RVA: 0x00375107 File Offset: 0x00373307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse Clone()
		{
			return new SceneItemSequenceFrameEndResponse(this);
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x06017CCF RID: 97487 RVA: 0x0037510F File Offset: 0x0037330F
		// (set) Token: 0x06017CD0 RID: 97488 RVA: 0x00375117 File Offset: 0x00373317
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

		// Token: 0x06017CD1 RID: 97489 RVA: 0x00375120 File Offset: 0x00373320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameEndResponse);
		}

		// Token: 0x06017CD2 RID: 97490 RVA: 0x0037512E File Offset: 0x0037332E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CD3 RID: 97491 RVA: 0x0037515C File Offset: 0x0037335C
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

		// Token: 0x06017CD4 RID: 97492 RVA: 0x003751A1 File Offset: 0x003733A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CD5 RID: 97493 RVA: 0x003751AE File Offset: 0x003733AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CD6 RID: 97494 RVA: 0x003751B7 File Offset: 0x003733B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CD7 RID: 97495 RVA: 0x003751EC File Offset: 0x003733EC
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

		// Token: 0x06017CD8 RID: 97496 RVA: 0x0037522A File Offset: 0x0037342A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameEndResponse other)
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

		// Token: 0x06017CD9 RID: 97497 RVA: 0x0037525B File Offset: 0x0037345B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CDA RID: 97498 RVA: 0x00375264 File Offset: 0x00373464
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D2B RID: 36139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D2C RID: 36140
		public const int CodeFieldNumber = 12;

		// Token: 0x04008D2D RID: 36141
		private ErrorCode code_;
	}
}

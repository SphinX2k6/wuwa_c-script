using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B5 RID: 4533
	[NetMessage(EMessageId.SceneItemStopResponse)]
	public sealed class SceneItemStopResponse : IMessage<SceneItemStopResponse>, IMessage, IEquatable<SceneItemStopResponse>, IDeepCloneable<SceneItemStopResponse>, IBufferMessage
	{
		// Token: 0x06018348 RID: 99144 RVA: 0x00386168 File Offset: 0x00384368
		[NullableContext(1)]
		public static SceneItemStopResponse Create()
		{
			return new SceneItemStopResponse();
		}

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x06018349 RID: 99145 RVA: 0x0038616F File Offset: 0x0038436F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x0601834A RID: 99146 RVA: 0x00386172 File Offset: 0x00384372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopResponse.Descriptor;
			}
		}

		// Token: 0x0601834B RID: 99147 RVA: 0x00386179 File Offset: 0x00384379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse()
		{
		}

		// Token: 0x0601834C RID: 99148 RVA: 0x00386181 File Offset: 0x00384381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse(SceneItemStopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601834D RID: 99149 RVA: 0x003861A6 File Offset: 0x003843A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse Clone()
		{
			return new SceneItemStopResponse(this);
		}

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x0601834E RID: 99150 RVA: 0x003861AE File Offset: 0x003843AE
		// (set) Token: 0x0601834F RID: 99151 RVA: 0x003861B6 File Offset: 0x003843B6
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

		// Token: 0x06018350 RID: 99152 RVA: 0x003861BF File Offset: 0x003843BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopResponse);
		}

		// Token: 0x06018351 RID: 99153 RVA: 0x003861CD File Offset: 0x003843CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x003861FC File Offset: 0x003843FC
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

		// Token: 0x06018353 RID: 99155 RVA: 0x00386241 File Offset: 0x00384441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018354 RID: 99156 RVA: 0x0038624E File Offset: 0x0038444E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x00386257 File Offset: 0x00384457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x0038628C File Offset: 0x0038448C
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

		// Token: 0x06018357 RID: 99159 RVA: 0x003862CA File Offset: 0x003844CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStopResponse other)
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

		// Token: 0x06018358 RID: 99160 RVA: 0x003862FB File Offset: 0x003844FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x00386304 File Offset: 0x00384504
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FF7 RID: 36855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FF8 RID: 36856
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008FF9 RID: 36857
		private ErrorCode errorCode_;
	}
}

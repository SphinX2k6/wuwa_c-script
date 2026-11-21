using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001522 RID: 5410
	[NetMessage(EMessageId.UpdateSceneItemBlackboardResponse)]
	public sealed class UpdateSceneItemBlackboardResponse : IMessage<UpdateSceneItemBlackboardResponse>, IMessage, IEquatable<UpdateSceneItemBlackboardResponse>, IDeepCloneable<UpdateSceneItemBlackboardResponse>, IBufferMessage
	{
		// Token: 0x0601CA90 RID: 117392 RVA: 0x00427270 File Offset: 0x00425470
		[NullableContext(1)]
		public static UpdateSceneItemBlackboardResponse Create()
		{
			return new UpdateSceneItemBlackboardResponse();
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x0601CA91 RID: 117393 RVA: 0x00427277 File Offset: 0x00425477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x0601CA92 RID: 117394 RVA: 0x0042727A File Offset: 0x0042547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneItemBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x0601CA93 RID: 117395 RVA: 0x00427281 File Offset: 0x00425481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse()
		{
		}

		// Token: 0x0601CA94 RID: 117396 RVA: 0x00427289 File Offset: 0x00425489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse(UpdateSceneItemBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA95 RID: 117397 RVA: 0x004272AE File Offset: 0x004254AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse Clone()
		{
			return new UpdateSceneItemBlackboardResponse(this);
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x0601CA96 RID: 117398 RVA: 0x004272B6 File Offset: 0x004254B6
		// (set) Token: 0x0601CA97 RID: 117399 RVA: 0x004272BE File Offset: 0x004254BE
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

		// Token: 0x0601CA98 RID: 117400 RVA: 0x004272C7 File Offset: 0x004254C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneItemBlackboardResponse);
		}

		// Token: 0x0601CA99 RID: 117401 RVA: 0x004272D5 File Offset: 0x004254D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneItemBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA9A RID: 117402 RVA: 0x00427304 File Offset: 0x00425504
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

		// Token: 0x0601CA9B RID: 117403 RVA: 0x00427349 File Offset: 0x00425549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA9C RID: 117404 RVA: 0x00427356 File Offset: 0x00425556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA9D RID: 117405 RVA: 0x0042735F File Offset: 0x0042555F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA9E RID: 117406 RVA: 0x00427394 File Offset: 0x00425594
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

		// Token: 0x0601CA9F RID: 117407 RVA: 0x004273D2 File Offset: 0x004255D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneItemBlackboardResponse other)
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

		// Token: 0x0601CAA0 RID: 117408 RVA: 0x00427403 File Offset: 0x00425603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAA1 RID: 117409 RVA: 0x0042740C File Offset: 0x0042560C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A51A RID: 42266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A51B RID: 42267
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A51C RID: 42268
		private ErrorCode errorCode_;
	}
}

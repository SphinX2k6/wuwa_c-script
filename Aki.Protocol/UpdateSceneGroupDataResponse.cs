using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001520 RID: 5408
	[NetMessage(EMessageId.UpdateSceneGroupDataResponse)]
	public sealed class UpdateSceneGroupDataResponse : IMessage<UpdateSceneGroupDataResponse>, IMessage, IEquatable<UpdateSceneGroupDataResponse>, IDeepCloneable<UpdateSceneGroupDataResponse>, IBufferMessage
	{
		// Token: 0x0601CA6A RID: 117354 RVA: 0x00426DE4 File Offset: 0x00424FE4
		[NullableContext(1)]
		public static UpdateSceneGroupDataResponse Create()
		{
			return new UpdateSceneGroupDataResponse();
		}

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x0601CA6B RID: 117355 RVA: 0x00426DEB File Offset: 0x00424FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x0601CA6C RID: 117356 RVA: 0x00426DEE File Offset: 0x00424FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataResponse.Descriptor;
			}
		}

		// Token: 0x0601CA6D RID: 117357 RVA: 0x00426DF5 File Offset: 0x00424FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse()
		{
		}

		// Token: 0x0601CA6E RID: 117358 RVA: 0x00426DFD File Offset: 0x00424FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse(UpdateSceneGroupDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA6F RID: 117359 RVA: 0x00426E22 File Offset: 0x00425022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse Clone()
		{
			return new UpdateSceneGroupDataResponse(this);
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x0601CA70 RID: 117360 RVA: 0x00426E2A File Offset: 0x0042502A
		// (set) Token: 0x0601CA71 RID: 117361 RVA: 0x00426E32 File Offset: 0x00425032
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

		// Token: 0x0601CA72 RID: 117362 RVA: 0x00426E3B File Offset: 0x0042503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataResponse);
		}

		// Token: 0x0601CA73 RID: 117363 RVA: 0x00426E49 File Offset: 0x00425049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA74 RID: 117364 RVA: 0x00426E78 File Offset: 0x00425078
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

		// Token: 0x0601CA75 RID: 117365 RVA: 0x00426EBD File Offset: 0x004250BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA76 RID: 117366 RVA: 0x00426ECA File Offset: 0x004250CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA77 RID: 117367 RVA: 0x00426ED3 File Offset: 0x004250D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA78 RID: 117368 RVA: 0x00426F08 File Offset: 0x00425108
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

		// Token: 0x0601CA79 RID: 117369 RVA: 0x00426F46 File Offset: 0x00425146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneGroupDataResponse other)
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

		// Token: 0x0601CA7A RID: 117370 RVA: 0x00426F77 File Offset: 0x00425177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA7B RID: 117371 RVA: 0x00426F80 File Offset: 0x00425180
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A511 RID: 42257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A512 RID: 42258
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A513 RID: 42259
		private ErrorCode errorCode_;
	}
}

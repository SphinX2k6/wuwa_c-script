using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001517 RID: 5399
	[NetMessage(EMessageId.WorldBlackboardResponse)]
	public sealed class WorldBlackboardResponse : IMessage<WorldBlackboardResponse>, IMessage, IEquatable<WorldBlackboardResponse>, IDeepCloneable<WorldBlackboardResponse>, IBufferMessage
	{
		// Token: 0x0601C87B RID: 116859 RVA: 0x0041EA1D File Offset: 0x0041CC1D
		[NullableContext(1)]
		public static WorldBlackboardResponse Create()
		{
			return new WorldBlackboardResponse();
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x0601C87C RID: 116860 RVA: 0x0041EA24 File Offset: 0x0041CC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x0601C87D RID: 116861 RVA: 0x0041EA27 File Offset: 0x0041CC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x0601C87E RID: 116862 RVA: 0x0041EA2E File Offset: 0x0041CC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse()
		{
		}

		// Token: 0x0601C87F RID: 116863 RVA: 0x0041EA36 File Offset: 0x0041CC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse(WorldBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C880 RID: 116864 RVA: 0x0041EA5B File Offset: 0x0041CC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse Clone()
		{
			return new WorldBlackboardResponse(this);
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x0601C881 RID: 116865 RVA: 0x0041EA63 File Offset: 0x0041CC63
		// (set) Token: 0x0601C882 RID: 116866 RVA: 0x0041EA6B File Offset: 0x0041CC6B
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

		// Token: 0x0601C883 RID: 116867 RVA: 0x0041EA74 File Offset: 0x0041CC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardResponse);
		}

		// Token: 0x0601C884 RID: 116868 RVA: 0x0041EA82 File Offset: 0x0041CC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C885 RID: 116869 RVA: 0x0041EAB0 File Offset: 0x0041CCB0
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

		// Token: 0x0601C886 RID: 116870 RVA: 0x0041EAF5 File Offset: 0x0041CCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C887 RID: 116871 RVA: 0x0041EB02 File Offset: 0x0041CD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C888 RID: 116872 RVA: 0x0041EB0B File Offset: 0x0041CD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C889 RID: 116873 RVA: 0x0041EB40 File Offset: 0x0041CD40
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

		// Token: 0x0601C88A RID: 116874 RVA: 0x0041EB7E File Offset: 0x0041CD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldBlackboardResponse other)
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

		// Token: 0x0601C88B RID: 116875 RVA: 0x0041EBAF File Offset: 0x0041CDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C88C RID: 116876 RVA: 0x0041EBB8 File Offset: 0x0041CDB8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A332 RID: 41778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A333 RID: 41779
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400A334 RID: 41780
		private ErrorCode errorCode_;
	}
}

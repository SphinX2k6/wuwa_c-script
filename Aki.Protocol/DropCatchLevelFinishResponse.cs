using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F3 RID: 1011
	[NetMessage(EMessageId.DropCatchLevelFinishResponse)]
	public sealed class DropCatchLevelFinishResponse : IMessage<DropCatchLevelFinishResponse>, IMessage, IEquatable<DropCatchLevelFinishResponse>, IDeepCloneable<DropCatchLevelFinishResponse>, IBufferMessage
	{
		// Token: 0x06006221 RID: 25121 RVA: 0x000EC920 File Offset: 0x000EAB20
		[NullableContext(1)]
		public static DropCatchLevelFinishResponse Create()
		{
			return new DropCatchLevelFinishResponse();
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06006222 RID: 25122 RVA: 0x000EC927 File Offset: 0x000EAB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x000EC92A File Offset: 0x000EAB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelFinishResponse.Descriptor;
			}
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x000EC931 File Offset: 0x000EAB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse()
		{
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x000EC939 File Offset: 0x000EAB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse(DropCatchLevelFinishResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x000EC95E File Offset: 0x000EAB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse Clone()
		{
			return new DropCatchLevelFinishResponse(this);
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06006227 RID: 25127 RVA: 0x000EC966 File Offset: 0x000EAB66
		// (set) Token: 0x06006228 RID: 25128 RVA: 0x000EC96E File Offset: 0x000EAB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x000EC977 File Offset: 0x000EAB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelFinishResponse);
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x000EC985 File Offset: 0x000EAB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelFinishResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x000EC9B4 File Offset: 0x000EABB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x000EC9F9 File Offset: 0x000EABF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x000ECA06 File Offset: 0x000EAC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x000ECA0F File Offset: 0x000EAC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x000ECA44 File Offset: 0x000EAC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x000ECA82 File Offset: 0x000EAC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x000ECAB3 File Offset: 0x000EACB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x000ECABC File Offset: 0x000EACBC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003820 RID: 14368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003821 RID: 14369
		public const int ErrorFieldNumber = 2;

		// Token: 0x04003822 RID: 14370
		private ErrorCode error_;
	}
}

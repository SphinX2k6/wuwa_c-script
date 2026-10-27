using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001340 RID: 4928
	[NetMessage(EMessageId.TeleportToTargetResponse)]
	public sealed class TeleportToTargetResponse : IMessage<TeleportToTargetResponse>, IMessage, IEquatable<TeleportToTargetResponse>, IDeepCloneable<TeleportToTargetResponse>, IBufferMessage
	{
		// Token: 0x0601A2DD RID: 107229 RVA: 0x003CD5B7 File Offset: 0x003CB7B7
		[NullableContext(1)]
		public static TeleportToTargetResponse Create()
		{
			return new TeleportToTargetResponse();
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x0601A2DE RID: 107230 RVA: 0x003CD5BE File Offset: 0x003CB7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x0601A2DF RID: 107231 RVA: 0x003CD5C1 File Offset: 0x003CB7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToTargetResponse.Descriptor;
			}
		}

		// Token: 0x0601A2E0 RID: 107232 RVA: 0x003CD5C8 File Offset: 0x003CB7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse()
		{
		}

		// Token: 0x0601A2E1 RID: 107233 RVA: 0x003CD5D0 File Offset: 0x003CB7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse(TeleportToTargetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2E2 RID: 107234 RVA: 0x003CD5F5 File Offset: 0x003CB7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse Clone()
		{
			return new TeleportToTargetResponse(this);
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x0601A2E3 RID: 107235 RVA: 0x003CD5FD File Offset: 0x003CB7FD
		// (set) Token: 0x0601A2E4 RID: 107236 RVA: 0x003CD605 File Offset: 0x003CB805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601A2E5 RID: 107237 RVA: 0x003CD60E File Offset: 0x003CB80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToTargetResponse);
		}

		// Token: 0x0601A2E6 RID: 107238 RVA: 0x003CD61C File Offset: 0x003CB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToTargetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2E7 RID: 107239 RVA: 0x003CD64C File Offset: 0x003CB84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2E8 RID: 107240 RVA: 0x003CD691 File Offset: 0x003CB891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2E9 RID: 107241 RVA: 0x003CD69E File Offset: 0x003CB89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2EA RID: 107242 RVA: 0x003CD6A7 File Offset: 0x003CB8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2EB RID: 107243 RVA: 0x003CD6DC File Offset: 0x003CB8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2EC RID: 107244 RVA: 0x003CD71A File Offset: 0x003CB91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToTargetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2ED RID: 107245 RVA: 0x003CD74B File Offset: 0x003CB94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2EE RID: 107246 RVA: 0x003CD754 File Offset: 0x003CB954
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040098B7 RID: 39095
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098B8 RID: 39096
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x040098B9 RID: 39097
		private ErrorCode errCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFF RID: 3839
	[NetMessage(EMessageId.RemoveTemporaryTeleportResponse)]
	public sealed class RemoveTemporaryTeleportResponse : IMessage<RemoveTemporaryTeleportResponse>, IMessage, IEquatable<RemoveTemporaryTeleportResponse>, IDeepCloneable<RemoveTemporaryTeleportResponse>, IBufferMessage
	{
		// Token: 0x0601495F RID: 84319 RVA: 0x002FDC3D File Offset: 0x002FBE3D
		[NullableContext(1)]
		public static RemoveTemporaryTeleportResponse Create()
		{
			return new RemoveTemporaryTeleportResponse();
		}

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x06014960 RID: 84320 RVA: 0x002FDC44 File Offset: 0x002FBE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x06014961 RID: 84321 RVA: 0x002FDC47 File Offset: 0x002FBE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportResponse.Descriptor;
			}
		}

		// Token: 0x06014962 RID: 84322 RVA: 0x002FDC4E File Offset: 0x002FBE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse()
		{
		}

		// Token: 0x06014963 RID: 84323 RVA: 0x002FDC56 File Offset: 0x002FBE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse(RemoveTemporaryTeleportResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014964 RID: 84324 RVA: 0x002FDC7B File Offset: 0x002FBE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse Clone()
		{
			return new RemoveTemporaryTeleportResponse(this);
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x06014965 RID: 84325 RVA: 0x002FDC83 File Offset: 0x002FBE83
		// (set) Token: 0x06014966 RID: 84326 RVA: 0x002FDC8B File Offset: 0x002FBE8B
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

		// Token: 0x06014967 RID: 84327 RVA: 0x002FDC94 File Offset: 0x002FBE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportResponse);
		}

		// Token: 0x06014968 RID: 84328 RVA: 0x002FDCA2 File Offset: 0x002FBEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014969 RID: 84329 RVA: 0x002FDCD0 File Offset: 0x002FBED0
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

		// Token: 0x0601496A RID: 84330 RVA: 0x002FDD15 File Offset: 0x002FBF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601496B RID: 84331 RVA: 0x002FDD22 File Offset: 0x002FBF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601496C RID: 84332 RVA: 0x002FDD2B File Offset: 0x002FBF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601496D RID: 84333 RVA: 0x002FDD60 File Offset: 0x002FBF60
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

		// Token: 0x0601496E RID: 84334 RVA: 0x002FDD9E File Offset: 0x002FBF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTemporaryTeleportResponse other)
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

		// Token: 0x0601496F RID: 84335 RVA: 0x002FDDCF File Offset: 0x002FBFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014970 RID: 84336 RVA: 0x002FDDD8 File Offset: 0x002FBFD8
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D0D RID: 32013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D0E RID: 32014
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04007D0F RID: 32015
		private ErrorCode errCode_;
	}
}

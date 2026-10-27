using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001435 RID: 5173
	[NetMessage(EMessageId.TrapDefensePreviewFinishResponse)]
	public sealed class TrapDefensePreviewFinishResponse : IMessage<TrapDefensePreviewFinishResponse>, IMessage, IEquatable<TrapDefensePreviewFinishResponse>, IDeepCloneable<TrapDefensePreviewFinishResponse>, IBufferMessage
	{
		// Token: 0x0601B674 RID: 112244 RVA: 0x003F7C3A File Offset: 0x003F5E3A
		[NullableContext(1)]
		public static TrapDefensePreviewFinishResponse Create()
		{
			return new TrapDefensePreviewFinishResponse();
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x0601B675 RID: 112245 RVA: 0x003F7C41 File Offset: 0x003F5E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x0601B676 RID: 112246 RVA: 0x003F7C44 File Offset: 0x003F5E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601B677 RID: 112247 RVA: 0x003F7C4B File Offset: 0x003F5E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse()
		{
		}

		// Token: 0x0601B678 RID: 112248 RVA: 0x003F7C53 File Offset: 0x003F5E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse(TrapDefensePreviewFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B679 RID: 112249 RVA: 0x003F7C78 File Offset: 0x003F5E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse Clone()
		{
			return new TrapDefensePreviewFinishResponse(this);
		}

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x0601B67A RID: 112250 RVA: 0x003F7C80 File Offset: 0x003F5E80
		// (set) Token: 0x0601B67B RID: 112251 RVA: 0x003F7C88 File Offset: 0x003F5E88
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

		// Token: 0x0601B67C RID: 112252 RVA: 0x003F7C91 File Offset: 0x003F5E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewFinishResponse);
		}

		// Token: 0x0601B67D RID: 112253 RVA: 0x003F7C9F File Offset: 0x003F5E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B67E RID: 112254 RVA: 0x003F7CD0 File Offset: 0x003F5ED0
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

		// Token: 0x0601B67F RID: 112255 RVA: 0x003F7D15 File Offset: 0x003F5F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B680 RID: 112256 RVA: 0x003F7D22 File Offset: 0x003F5F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B681 RID: 112257 RVA: 0x003F7D2B File Offset: 0x003F5F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B682 RID: 112258 RVA: 0x003F7D60 File Offset: 0x003F5F60
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

		// Token: 0x0601B683 RID: 112259 RVA: 0x003F7D9E File Offset: 0x003F5F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewFinishResponse other)
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

		// Token: 0x0601B684 RID: 112260 RVA: 0x003F7DCF File Offset: 0x003F5FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B685 RID: 112261 RVA: 0x003F7DD8 File Offset: 0x003F5FD8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E2A RID: 40490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E2B RID: 40491
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009E2C RID: 40492
		private ErrorCode errorCode_;
	}
}

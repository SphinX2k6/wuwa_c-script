using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FF RID: 255
	[NetMessage(EMessageId.ApplyBuffS2cResponsePush)]
	public sealed class ApplyBuffS2cResponsePush : IMessage<ApplyBuffS2cResponsePush>, IMessage, IEquatable<ApplyBuffS2cResponsePush>, IDeepCloneable<ApplyBuffS2cResponsePush>, IBufferMessage
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x0006054B File Offset: 0x0005E74B
		[NullableContext(1)]
		public static ApplyBuffS2cResponsePush Create()
		{
			return new ApplyBuffS2cResponsePush();
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x00060552 File Offset: 0x0005E752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x00060555 File Offset: 0x0005E755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0006055C File Offset: 0x0005E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush()
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00060564 File Offset: 0x0005E764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush(ApplyBuffS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.handle_ = other.handle_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000605A1 File Offset: 0x0005E7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush Clone()
		{
			return new ApplyBuffS2cResponsePush(this);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000605A9 File Offset: 0x0005E7A9
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x000605B1 File Offset: 0x0005E7B1
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000605BA File Offset: 0x0005E7BA
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x000605C2 File Offset: 0x0005E7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000605CB File Offset: 0x0005E7CB
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x000605D3 File Offset: 0x0005E7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000605DC File Offset: 0x0005E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffS2cResponsePush);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000605EC File Offset: 0x0005E7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Handle == other.Handle && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00060648 File Offset: 0x0005E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.IsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000606BF File Offset: 0x0005E8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000606CC File Offset: 0x0005E8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000606D8 File Offset: 0x0005E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActive)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsActive);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Handle);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00060750 File Offset: 0x0005E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.IsActive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000607B4 File Offset: 0x0005E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyBuffS2cResponsePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.IsActive)
			{
				this.IsActive = other.IsActive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00060818 File Offset: 0x0005EA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00060824 File Offset: 0x0005EA24
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.Handle = input.ReadInt32();
					}
				}
				else
				{
					this.IsActive = input.ReadBool();
				}
			}
		}

		// Token: 0x04002580 RID: 9600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002581 RID: 9601
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002582 RID: 9602
		private ErrorCode errorCode_;

		// Token: 0x04002583 RID: 9603
		public const int HandleFieldNumber = 10;

		// Token: 0x04002584 RID: 9604
		private int handle_;

		// Token: 0x04002585 RID: 9605
		public const int IsActiveFieldNumber = 8;

		// Token: 0x04002586 RID: 9606
		private bool isActive_;
	}
}

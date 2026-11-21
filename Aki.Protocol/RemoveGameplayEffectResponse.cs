using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEB RID: 3819
	[NetMessage(EMessageId.RemoveGameplayEffectResponse)]
	public sealed class RemoveGameplayEffectResponse : IMessage<RemoveGameplayEffectResponse>, IMessage, IEquatable<RemoveGameplayEffectResponse>, IDeepCloneable<RemoveGameplayEffectResponse>, IBufferMessage
	{
		// Token: 0x060147DF RID: 83935 RVA: 0x002FADA2 File Offset: 0x002F8FA2
		[NullableContext(1)]
		public static RemoveGameplayEffectResponse Create()
		{
			return new RemoveGameplayEffectResponse();
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x060147E0 RID: 83936 RVA: 0x002FADA9 File Offset: 0x002F8FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x060147E1 RID: 83937 RVA: 0x002FADAC File Offset: 0x002F8FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectResponse.Descriptor;
			}
		}

		// Token: 0x060147E2 RID: 83938 RVA: 0x002FADB3 File Offset: 0x002F8FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse()
		{
		}

		// Token: 0x060147E3 RID: 83939 RVA: 0x002FADBB File Offset: 0x002F8FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse(RemoveGameplayEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.handle_ = other.handle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147E4 RID: 83940 RVA: 0x002FADEC File Offset: 0x002F8FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse Clone()
		{
			return new RemoveGameplayEffectResponse(this);
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x060147E5 RID: 83941 RVA: 0x002FADF4 File Offset: 0x002F8FF4
		// (set) Token: 0x060147E6 RID: 83942 RVA: 0x002FADFC File Offset: 0x002F8FFC
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

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x060147E7 RID: 83943 RVA: 0x002FAE05 File Offset: 0x002F9005
		// (set) Token: 0x060147E8 RID: 83944 RVA: 0x002FAE0D File Offset: 0x002F900D
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

		// Token: 0x060147E9 RID: 83945 RVA: 0x002FAE16 File Offset: 0x002F9016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectResponse);
		}

		// Token: 0x060147EA RID: 83946 RVA: 0x002FAE24 File Offset: 0x002F9024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Handle == other.Handle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147EB RID: 83947 RVA: 0x002FAE64 File Offset: 0x002F9064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060147EC RID: 83948 RVA: 0x002FAEC2 File Offset: 0x002F90C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147ED RID: 83949 RVA: 0x002FAECF File Offset: 0x002F90CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147EE RID: 83950 RVA: 0x002FAED8 File Offset: 0x002F90D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Handle);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147EF RID: 83951 RVA: 0x002FAF34 File Offset: 0x002F9134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060147F0 RID: 83952 RVA: 0x002FAF8C File Offset: 0x002F918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGameplayEffectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x002FAFDC File Offset: 0x002F91DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147F2 RID: 83954 RVA: 0x002FAFE8 File Offset: 0x002F91E8
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
				if (num != 24U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Handle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CB5 RID: 31925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CB6 RID: 31926
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04007CB7 RID: 31927
		private ErrorCode errCode_;

		// Token: 0x04007CB8 RID: 31928
		public const int HandleFieldNumber = 3;

		// Token: 0x04007CB9 RID: 31929
		private int handle_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFB RID: 3835
	[NetMessage(EMessageId.RemoveGameplayEffectResponse)]
	public sealed class RemoveGameplayEffectResponse : IMessage<RemoveGameplayEffectResponse>, IMessage, IEquatable<RemoveGameplayEffectResponse>, IDeepCloneable<RemoveGameplayEffectResponse>, IBufferMessage
	{
		// Token: 0x060148C4 RID: 84164 RVA: 0x002FC45F File Offset: 0x002FA65F
		[NullableContext(1)]
		public static RemoveGameplayEffectResponse Create()
		{
			return new RemoveGameplayEffectResponse();
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x060148C5 RID: 84165 RVA: 0x002FC466 File Offset: 0x002FA666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x060148C6 RID: 84166 RVA: 0x002FC469 File Offset: 0x002FA669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectResponse.Descriptor;
			}
		}

		// Token: 0x060148C7 RID: 84167 RVA: 0x002FC470 File Offset: 0x002FA670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse()
		{
		}

		// Token: 0x060148C8 RID: 84168 RVA: 0x002FC478 File Offset: 0x002FA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse(RemoveGameplayEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.handle_ = other.handle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148C9 RID: 84169 RVA: 0x002FC4A9 File Offset: 0x002FA6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse Clone()
		{
			return new RemoveGameplayEffectResponse(this);
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x060148CA RID: 84170 RVA: 0x002FC4B1 File Offset: 0x002FA6B1
		// (set) Token: 0x060148CB RID: 84171 RVA: 0x002FC4B9 File Offset: 0x002FA6B9
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

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x060148CC RID: 84172 RVA: 0x002FC4C2 File Offset: 0x002FA6C2
		// (set) Token: 0x060148CD RID: 84173 RVA: 0x002FC4CA File Offset: 0x002FA6CA
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

		// Token: 0x060148CE RID: 84174 RVA: 0x002FC4D3 File Offset: 0x002FA6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectResponse);
		}

		// Token: 0x060148CF RID: 84175 RVA: 0x002FC4E1 File Offset: 0x002FA6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Handle == other.Handle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148D0 RID: 84176 RVA: 0x002FC520 File Offset: 0x002FA720
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

		// Token: 0x060148D1 RID: 84177 RVA: 0x002FC57E File Offset: 0x002FA77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148D2 RID: 84178 RVA: 0x002FC58B File Offset: 0x002FA78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148D3 RID: 84179 RVA: 0x002FC594 File Offset: 0x002FA794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Handle);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148D4 RID: 84180 RVA: 0x002FC5F0 File Offset: 0x002FA7F0
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

		// Token: 0x060148D5 RID: 84181 RVA: 0x002FC648 File Offset: 0x002FA848
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

		// Token: 0x060148D6 RID: 84182 RVA: 0x002FC698 File Offset: 0x002FA898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148D7 RID: 84183 RVA: 0x002FC6A4 File Offset: 0x002FA8A4
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
					if (num != 96U)
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

		// Token: 0x04007C8B RID: 31883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C8C RID: 31884
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04007C8D RID: 31885
		private ErrorCode errCode_;

		// Token: 0x04007C8E RID: 31886
		public const int HandleFieldNumber = 2;

		// Token: 0x04007C8F RID: 31887
		private int handle_;
	}
}

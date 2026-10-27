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
		// Token: 0x060023E0 RID: 9184 RVA: 0x0005FA76 File Offset: 0x0005DC76
		[NullableContext(1)]
		public static ApplyBuffS2cResponsePush Create()
		{
			return new ApplyBuffS2cResponsePush();
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0005FA7D File Offset: 0x0005DC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0005FA80 File Offset: 0x0005DC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0005FA87 File Offset: 0x0005DC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush()
		{
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x0005FA8F File Offset: 0x0005DC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush(ApplyBuffS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.handle_ = other.handle_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0005FACC File Offset: 0x0005DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush Clone()
		{
			return new ApplyBuffS2cResponsePush(this);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0005FADC File Offset: 0x0005DCDC
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x0005FAE5 File Offset: 0x0005DCE5
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0005FAED File Offset: 0x0005DCED
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0005FAF6 File Offset: 0x0005DCF6
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0005FAFE File Offset: 0x0005DCFE
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

		// Token: 0x060023EC RID: 9196 RVA: 0x0005FB07 File Offset: 0x0005DD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffS2cResponsePush);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0005FB18 File Offset: 0x0005DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Handle == other.Handle && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0005FB74 File Offset: 0x0005DD74
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

		// Token: 0x060023EF RID: 9199 RVA: 0x0005FBEB File Offset: 0x0005DDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0005FC04 File Offset: 0x0005DE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsActive);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0005FC7C File Offset: 0x0005DE7C
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

		// Token: 0x060023F3 RID: 9203 RVA: 0x0005FCE0 File Offset: 0x0005DEE0
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

		// Token: 0x060023F4 RID: 9204 RVA: 0x0005FD44 File Offset: 0x0005DF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0005FD50 File Offset: 0x0005DF50
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002521 RID: 9505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002522 RID: 9506
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002523 RID: 9507
		private ErrorCode errorCode_;

		// Token: 0x04002524 RID: 9508
		public const int HandleFieldNumber = 11;

		// Token: 0x04002525 RID: 9509
		private int handle_;

		// Token: 0x04002526 RID: 9510
		public const int IsActiveFieldNumber = 5;

		// Token: 0x04002527 RID: 9511
		private bool isActive_;
	}
}

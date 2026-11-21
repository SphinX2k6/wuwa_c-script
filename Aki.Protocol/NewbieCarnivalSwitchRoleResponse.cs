using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF3 RID: 2803
	[NetMessage(EMessageId.NewbieCarnivalSwitchRoleResponse)]
	public sealed class NewbieCarnivalSwitchRoleResponse : IMessage<NewbieCarnivalSwitchRoleResponse>, IMessage, IEquatable<NewbieCarnivalSwitchRoleResponse>, IDeepCloneable<NewbieCarnivalSwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x0600F3FF RID: 62463 RVA: 0x0023A420 File Offset: 0x00238620
		[NullableContext(1)]
		public static NewbieCarnivalSwitchRoleResponse Create()
		{
			return new NewbieCarnivalSwitchRoleResponse();
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600F400 RID: 62464 RVA: 0x0023A427 File Offset: 0x00238627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600F401 RID: 62465 RVA: 0x0023A42A File Offset: 0x0023862A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalSwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600F402 RID: 62466 RVA: 0x0023A431 File Offset: 0x00238631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse()
		{
		}

		// Token: 0x0600F403 RID: 62467 RVA: 0x0023A439 File Offset: 0x00238639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse(NewbieCarnivalSwitchRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F404 RID: 62468 RVA: 0x0023A45E File Offset: 0x0023865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse Clone()
		{
			return new NewbieCarnivalSwitchRoleResponse(this);
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600F405 RID: 62469 RVA: 0x0023A466 File Offset: 0x00238666
		// (set) Token: 0x0600F406 RID: 62470 RVA: 0x0023A46E File Offset: 0x0023866E
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

		// Token: 0x0600F407 RID: 62471 RVA: 0x0023A477 File Offset: 0x00238677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalSwitchRoleResponse);
		}

		// Token: 0x0600F408 RID: 62472 RVA: 0x0023A485 File Offset: 0x00238685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalSwitchRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F409 RID: 62473 RVA: 0x0023A4B4 File Offset: 0x002386B4
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

		// Token: 0x0600F40A RID: 62474 RVA: 0x0023A4F9 File Offset: 0x002386F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F40B RID: 62475 RVA: 0x0023A506 File Offset: 0x00238706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F40C RID: 62476 RVA: 0x0023A50F File Offset: 0x0023870F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F40D RID: 62477 RVA: 0x0023A544 File Offset: 0x00238744
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

		// Token: 0x0600F40E RID: 62478 RVA: 0x0023A582 File Offset: 0x00238782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalSwitchRoleResponse other)
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

		// Token: 0x0600F40F RID: 62479 RVA: 0x0023A5B3 File Offset: 0x002387B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F410 RID: 62480 RVA: 0x0023A5BC File Offset: 0x002387BC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062A8 RID: 25256
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062A9 RID: 25257
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040062AA RID: 25258
		private ErrorCode errorCode_;
	}
}

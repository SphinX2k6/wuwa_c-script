using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031A RID: 794
	[NetMessage(EMessageId.CreateBulletResponse)]
	public sealed class CreateBulletResponse : IMessage<CreateBulletResponse>, IMessage, IEquatable<CreateBulletResponse>, IDeepCloneable<CreateBulletResponse>, IBufferMessage
	{
		// Token: 0x06005050 RID: 20560 RVA: 0x000C439C File Offset: 0x000C259C
		[NullableContext(1)]
		public static CreateBulletResponse Create()
		{
			return new CreateBulletResponse();
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x000C43A3 File Offset: 0x000C25A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x000C43A6 File Offset: 0x000C25A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletResponse.Descriptor;
			}
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x000C43AD File Offset: 0x000C25AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse()
		{
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x000C43B5 File Offset: 0x000C25B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse(CreateBulletResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x000C43DA File Offset: 0x000C25DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse Clone()
		{
			return new CreateBulletResponse(this);
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x000C43E2 File Offset: 0x000C25E2
		// (set) Token: 0x06005057 RID: 20567 RVA: 0x000C43EA File Offset: 0x000C25EA
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

		// Token: 0x06005058 RID: 20568 RVA: 0x000C43F3 File Offset: 0x000C25F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletResponse);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x000C4401 File Offset: 0x000C2601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x000C4430 File Offset: 0x000C2630
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

		// Token: 0x0600505B RID: 20571 RVA: 0x000C4475 File Offset: 0x000C2675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x000C4482 File Offset: 0x000C2682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x000C448B File Offset: 0x000C268B
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

		// Token: 0x0600505E RID: 20574 RVA: 0x000C44C0 File Offset: 0x000C26C0
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

		// Token: 0x0600505F RID: 20575 RVA: 0x000C44FE File Offset: 0x000C26FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateBulletResponse other)
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

		// Token: 0x06005060 RID: 20576 RVA: 0x000C452F File Offset: 0x000C272F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x000C4538 File Offset: 0x000C2738
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

		// Token: 0x040032B1 RID: 12977
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B2 RID: 12978
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040032B3 RID: 12979
		private ErrorCode errorCode_;
	}
}

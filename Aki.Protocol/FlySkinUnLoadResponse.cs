using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000610 RID: 1552
	[NetMessage(EMessageId.FlySkinUnLoadResponse)]
	public sealed class FlySkinUnLoadResponse : IMessage<FlySkinUnLoadResponse>, IMessage, IEquatable<FlySkinUnLoadResponse>, IDeepCloneable<FlySkinUnLoadResponse>, IBufferMessage
	{
		// Token: 0x06008F6A RID: 36714 RVA: 0x0015B6EC File Offset: 0x001598EC
		[NullableContext(1)]
		public static FlySkinUnLoadResponse Create()
		{
			return new FlySkinUnLoadResponse();
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06008F6B RID: 36715 RVA: 0x0015B6F3 File Offset: 0x001598F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x0015B6F6 File Offset: 0x001598F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x0015B6FD File Offset: 0x001598FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse()
		{
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x0015B705 File Offset: 0x00159905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse(FlySkinUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F6F RID: 36719 RVA: 0x0015B72A File Offset: 0x0015992A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse Clone()
		{
			return new FlySkinUnLoadResponse(this);
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0015B732 File Offset: 0x00159932
		// (set) Token: 0x06008F71 RID: 36721 RVA: 0x0015B73A File Offset: 0x0015993A
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

		// Token: 0x06008F72 RID: 36722 RVA: 0x0015B743 File Offset: 0x00159943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinUnLoadResponse);
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x0015B751 File Offset: 0x00159951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x0015B780 File Offset: 0x00159980
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

		// Token: 0x06008F75 RID: 36725 RVA: 0x0015B7C5 File Offset: 0x001599C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0015B7D2 File Offset: 0x001599D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x0015B7DB File Offset: 0x001599DB
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

		// Token: 0x06008F78 RID: 36728 RVA: 0x0015B810 File Offset: 0x00159A10
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

		// Token: 0x06008F79 RID: 36729 RVA: 0x0015B84E File Offset: 0x00159A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinUnLoadResponse other)
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

		// Token: 0x06008F7A RID: 36730 RVA: 0x0015B87F File Offset: 0x00159A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x0015B888 File Offset: 0x00159A88
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

		// Token: 0x040045A4 RID: 17828
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045A5 RID: 17829
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040045A6 RID: 17830
		private ErrorCode errorCode_;
	}
}

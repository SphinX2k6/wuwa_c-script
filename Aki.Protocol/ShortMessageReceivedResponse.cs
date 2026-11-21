using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001244 RID: 4676
	[NetMessage(EMessageId.ShortMessageReceivedResponse)]
	public sealed class ShortMessageReceivedResponse : IMessage<ShortMessageReceivedResponse>, IMessage, IEquatable<ShortMessageReceivedResponse>, IDeepCloneable<ShortMessageReceivedResponse>, IBufferMessage
	{
		// Token: 0x06018F8A RID: 102282 RVA: 0x003A4065 File Offset: 0x003A2265
		[NullableContext(1)]
		public static ShortMessageReceivedResponse Create()
		{
			return new ShortMessageReceivedResponse();
		}

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x06018F8B RID: 102283 RVA: 0x003A406C File Offset: 0x003A226C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x06018F8C RID: 102284 RVA: 0x003A406F File Offset: 0x003A226F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReceivedResponse.Descriptor;
			}
		}

		// Token: 0x06018F8D RID: 102285 RVA: 0x003A4076 File Offset: 0x003A2276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse()
		{
		}

		// Token: 0x06018F8E RID: 102286 RVA: 0x003A407E File Offset: 0x003A227E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse(ShortMessageReceivedResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F8F RID: 102287 RVA: 0x003A40A3 File Offset: 0x003A22A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse Clone()
		{
			return new ShortMessageReceivedResponse(this);
		}

		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x06018F90 RID: 102288 RVA: 0x003A40AB File Offset: 0x003A22AB
		// (set) Token: 0x06018F91 RID: 102289 RVA: 0x003A40B3 File Offset: 0x003A22B3
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

		// Token: 0x06018F92 RID: 102290 RVA: 0x003A40BC File Offset: 0x003A22BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReceivedResponse);
		}

		// Token: 0x06018F93 RID: 102291 RVA: 0x003A40CA File Offset: 0x003A22CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReceivedResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F94 RID: 102292 RVA: 0x003A40F8 File Offset: 0x003A22F8
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

		// Token: 0x06018F95 RID: 102293 RVA: 0x003A413D File Offset: 0x003A233D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F96 RID: 102294 RVA: 0x003A414A File Offset: 0x003A234A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F97 RID: 102295 RVA: 0x003A4153 File Offset: 0x003A2353
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

		// Token: 0x06018F98 RID: 102296 RVA: 0x003A4188 File Offset: 0x003A2388
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

		// Token: 0x06018F99 RID: 102297 RVA: 0x003A41C6 File Offset: 0x003A23C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReceivedResponse other)
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

		// Token: 0x06018F9A RID: 102298 RVA: 0x003A41F7 File Offset: 0x003A23F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F9B RID: 102299 RVA: 0x003A4200 File Offset: 0x003A2400
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

		// Token: 0x0400941C RID: 37916
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400941D RID: 37917
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x0400941E RID: 37918
		private ErrorCode errCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000224 RID: 548
	[NetMessage(EMessageId.CalabashLevelRewardResponse)]
	public sealed class CalabashLevelRewardResponse : IMessage<CalabashLevelRewardResponse>, IMessage, IEquatable<CalabashLevelRewardResponse>, IDeepCloneable<CalabashLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06003C01 RID: 15361 RVA: 0x00095829 File Offset: 0x00093A29
		[NullableContext(1)]
		public static CalabashLevelRewardResponse Create()
		{
			return new CalabashLevelRewardResponse();
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06003C02 RID: 15362 RVA: 0x00095830 File Offset: 0x00093A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x00095833 File Offset: 0x00093A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x0009583A File Offset: 0x00093A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse()
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00095842 File Offset: 0x00093A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse(CalabashLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x00095867 File Offset: 0x00093A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse Clone()
		{
			return new CalabashLevelRewardResponse(this);
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0009586F File Offset: 0x00093A6F
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x00095877 File Offset: 0x00093A77
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

		// Token: 0x06003C09 RID: 15369 RVA: 0x00095880 File Offset: 0x00093A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelRewardResponse);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x0009588E File Offset: 0x00093A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x000958BC File Offset: 0x00093ABC
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

		// Token: 0x06003C0C RID: 15372 RVA: 0x00095901 File Offset: 0x00093B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x0009590E File Offset: 0x00093B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00095917 File Offset: 0x00093B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0009594C File Offset: 0x00093B4C
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

		// Token: 0x06003C10 RID: 15376 RVA: 0x0009598A File Offset: 0x00093B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelRewardResponse other)
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

		// Token: 0x06003C11 RID: 15377 RVA: 0x000959BB File Offset: 0x00093BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000959C4 File Offset: 0x00093BC4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002CA4 RID: 11428
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CA5 RID: 11429
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002CA6 RID: 11430
		private ErrorCode errorCode_;
	}
}

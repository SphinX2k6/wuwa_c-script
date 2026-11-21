using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050A RID: 1290
	[NetMessage(EMessageId.FarmGoldLevelDiffResponse)]
	public sealed class FarmGoldLevelDiffResponse : IMessage<FarmGoldLevelDiffResponse>, IMessage, IEquatable<FarmGoldLevelDiffResponse>, IDeepCloneable<FarmGoldLevelDiffResponse>, IBufferMessage
	{
		// Token: 0x060079AE RID: 31150 RVA: 0x00127EE2 File Offset: 0x001260E2
		[NullableContext(1)]
		public static FarmGoldLevelDiffResponse Create()
		{
			return new FarmGoldLevelDiffResponse();
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x060079AF RID: 31151 RVA: 0x00127EE9 File Offset: 0x001260E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x00127EEC File Offset: 0x001260EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelDiffResponse.Descriptor;
			}
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x00127EF3 File Offset: 0x001260F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse()
		{
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00127EFB File Offset: 0x001260FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse(FarmGoldLevelDiffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x00127F20 File Offset: 0x00126120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse Clone()
		{
			return new FarmGoldLevelDiffResponse(this);
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x00127F28 File Offset: 0x00126128
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x00127F30 File Offset: 0x00126130
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

		// Token: 0x060079B6 RID: 31158 RVA: 0x00127F39 File Offset: 0x00126139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelDiffResponse);
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00127F47 File Offset: 0x00126147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelDiffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00127F78 File Offset: 0x00126178
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

		// Token: 0x060079B9 RID: 31161 RVA: 0x00127FBD File Offset: 0x001261BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00127FCA File Offset: 0x001261CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00127FD3 File Offset: 0x001261D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00128008 File Offset: 0x00126208
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

		// Token: 0x060079BD RID: 31165 RVA: 0x00128046 File Offset: 0x00126246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelDiffResponse other)
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

		// Token: 0x060079BE RID: 31166 RVA: 0x00128077 File Offset: 0x00126277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00128080 File Offset: 0x00126280
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F0A RID: 16138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F0B RID: 16139
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003F0C RID: 16140
		private ErrorCode errorCode_;
	}
}

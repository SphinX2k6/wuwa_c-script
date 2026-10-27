using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135B RID: 4955
	[NetMessage(EMessageId.ThemePersonalScoreResponse)]
	public sealed class ThemePersonalScoreResponse : IMessage<ThemePersonalScoreResponse>, IMessage, IEquatable<ThemePersonalScoreResponse>, IDeepCloneable<ThemePersonalScoreResponse>, IBufferMessage
	{
		// Token: 0x0601A52D RID: 107821 RVA: 0x003D2FED File Offset: 0x003D11ED
		[NullableContext(1)]
		public static ThemePersonalScoreResponse Create()
		{
			return new ThemePersonalScoreResponse();
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x0601A52E RID: 107822 RVA: 0x003D2FF4 File Offset: 0x003D11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x0601A52F RID: 107823 RVA: 0x003D2FF7 File Offset: 0x003D11F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemePersonalScoreResponse.Descriptor;
			}
		}

		// Token: 0x0601A530 RID: 107824 RVA: 0x003D2FFE File Offset: 0x003D11FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse()
		{
		}

		// Token: 0x0601A531 RID: 107825 RVA: 0x003D3006 File Offset: 0x003D1206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse(ThemePersonalScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A532 RID: 107826 RVA: 0x003D302B File Offset: 0x003D122B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse Clone()
		{
			return new ThemePersonalScoreResponse(this);
		}

		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x0601A533 RID: 107827 RVA: 0x003D3033 File Offset: 0x003D1233
		// (set) Token: 0x0601A534 RID: 107828 RVA: 0x003D303B File Offset: 0x003D123B
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

		// Token: 0x0601A535 RID: 107829 RVA: 0x003D3044 File Offset: 0x003D1244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemePersonalScoreResponse);
		}

		// Token: 0x0601A536 RID: 107830 RVA: 0x003D3052 File Offset: 0x003D1252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemePersonalScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A537 RID: 107831 RVA: 0x003D3080 File Offset: 0x003D1280
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

		// Token: 0x0601A538 RID: 107832 RVA: 0x003D30C5 File Offset: 0x003D12C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A539 RID: 107833 RVA: 0x003D30D2 File Offset: 0x003D12D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A53A RID: 107834 RVA: 0x003D30DB File Offset: 0x003D12DB
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

		// Token: 0x0601A53B RID: 107835 RVA: 0x003D3110 File Offset: 0x003D1310
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

		// Token: 0x0601A53C RID: 107836 RVA: 0x003D314E File Offset: 0x003D134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemePersonalScoreResponse other)
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

		// Token: 0x0601A53D RID: 107837 RVA: 0x003D317F File Offset: 0x003D137F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A53E RID: 107838 RVA: 0x003D3188 File Offset: 0x003D1388
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

		// Token: 0x0400997B RID: 39291
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400997C RID: 39292
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400997D RID: 39293
		private ErrorCode errorCode_;
	}
}

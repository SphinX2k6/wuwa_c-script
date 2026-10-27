using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001386 RID: 4998
	public sealed class TokenAwardView : IMessage<TokenAwardView>, IMessage, IEquatable<TokenAwardView>, IDeepCloneable<TokenAwardView>, IBufferMessage
	{
		// Token: 0x0601A877 RID: 108663 RVA: 0x003D98A5 File Offset: 0x003D7AA5
		[NullableContext(1)]
		public static TokenAwardView Create()
		{
			return new TokenAwardView();
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x0601A878 RID: 108664 RVA: 0x003D98AC File Offset: 0x003D7AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x0601A879 RID: 108665 RVA: 0x003D98AF File Offset: 0x003D7AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TokenAwardView.Descriptor;
			}
		}

		// Token: 0x0601A87A RID: 108666 RVA: 0x003D98B6 File Offset: 0x003D7AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView()
		{
		}

		// Token: 0x0601A87B RID: 108667 RVA: 0x003D98BE File Offset: 0x003D7ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView(TokenAwardView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A87C RID: 108668 RVA: 0x003D98F3 File Offset: 0x003D7AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView Clone()
		{
			return new TokenAwardView(this);
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x0601A87D RID: 108669 RVA: 0x003D98FB File Offset: 0x003D7AFB
		// (set) Token: 0x0601A87E RID: 108670 RVA: 0x003D9903 File Offset: 0x003D7B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption SurvivorsOption
		{
			get
			{
				return this.survivorsOption_;
			}
			set
			{
				this.survivorsOption_ = value;
			}
		}

		// Token: 0x0601A87F RID: 108671 RVA: 0x003D990C File Offset: 0x003D7B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TokenAwardView);
		}

		// Token: 0x0601A880 RID: 108672 RVA: 0x003D991A File Offset: 0x003D7B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TokenAwardView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A881 RID: 108673 RVA: 0x003D9950 File Offset: 0x003D7B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorsOption_ != null)
			{
				num ^= this.SurvivorsOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A882 RID: 108674 RVA: 0x003D998C File Offset: 0x003D7B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A883 RID: 108675 RVA: 0x003D9999 File Offset: 0x003D7B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A884 RID: 108676 RVA: 0x003D99A2 File Offset: 0x003D7BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorsOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A885 RID: 108677 RVA: 0x003D99D4 File Offset: 0x003D7BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorsOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A886 RID: 108678 RVA: 0x003D9A14 File Offset: 0x003D7C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TokenAwardView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorsOption_ != null)
			{
				if (this.survivorsOption_ == null)
				{
					this.SurvivorsOption = new SurvivorsOption();
				}
				this.SurvivorsOption.MergeFrom(other.SurvivorsOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A887 RID: 108679 RVA: 0x003D9A68 File Offset: 0x003D7C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A888 RID: 108680 RVA: 0x003D9A74 File Offset: 0x003D7C74
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.survivorsOption_ == null)
					{
						this.SurvivorsOption = new SurvivorsOption();
					}
					input.ReadMessage(this.SurvivorsOption);
				}
			}
		}

		// Token: 0x04009A4B RID: 39499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A4C RID: 39500
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04009A4D RID: 39501
		private SurvivorsOption survivorsOption_;
	}
}

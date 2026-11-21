using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F9 RID: 5113
	public sealed class TokenAwardView : IMessage<TokenAwardView>, IMessage, IEquatable<TokenAwardView>, IDeepCloneable<TokenAwardView>, IBufferMessage
	{
		// Token: 0x0601B300 RID: 111360 RVA: 0x003F4AB9 File Offset: 0x003F2CB9
		[NullableContext(1)]
		public static TokenAwardView Create()
		{
			return new TokenAwardView();
		}

		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x0601B301 RID: 111361 RVA: 0x003F4AC0 File Offset: 0x003F2CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x0601B302 RID: 111362 RVA: 0x003F4AC3 File Offset: 0x003F2CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TokenAwardView.Descriptor;
			}
		}

		// Token: 0x0601B303 RID: 111363 RVA: 0x003F4ACA File Offset: 0x003F2CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView()
		{
		}

		// Token: 0x0601B304 RID: 111364 RVA: 0x003F4AD2 File Offset: 0x003F2CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView(TokenAwardView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B305 RID: 111365 RVA: 0x003F4B07 File Offset: 0x003F2D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView Clone()
		{
			return new TokenAwardView(this);
		}

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x0601B306 RID: 111366 RVA: 0x003F4B0F File Offset: 0x003F2D0F
		// (set) Token: 0x0601B307 RID: 111367 RVA: 0x003F4B17 File Offset: 0x003F2D17
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

		// Token: 0x0601B308 RID: 111368 RVA: 0x003F4B20 File Offset: 0x003F2D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TokenAwardView);
		}

		// Token: 0x0601B309 RID: 111369 RVA: 0x003F4B2E File Offset: 0x003F2D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TokenAwardView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B30A RID: 111370 RVA: 0x003F4B64 File Offset: 0x003F2D64
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

		// Token: 0x0601B30B RID: 111371 RVA: 0x003F4BA0 File Offset: 0x003F2DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B30C RID: 111372 RVA: 0x003F4BAD File Offset: 0x003F2DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B30D RID: 111373 RVA: 0x003F4BB6 File Offset: 0x003F2DB6
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

		// Token: 0x0601B30E RID: 111374 RVA: 0x003F4BE8 File Offset: 0x003F2DE8
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

		// Token: 0x0601B30F RID: 111375 RVA: 0x003F4C28 File Offset: 0x003F2E28
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

		// Token: 0x0601B310 RID: 111376 RVA: 0x003F4C7C File Offset: 0x003F2E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B311 RID: 111377 RVA: 0x003F4C88 File Offset: 0x003F2E88
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

		// Token: 0x04009E90 RID: 40592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E91 RID: 40593
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04009E92 RID: 40594
		private SurvivorsOption survivorsOption_;
	}
}

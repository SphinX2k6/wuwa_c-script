using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FA RID: 5114
	public sealed class TokenSelectView : IMessage<TokenSelectView>, IMessage, IEquatable<TokenSelectView>, IDeepCloneable<TokenSelectView>, IBufferMessage
	{
		// Token: 0x0601B312 RID: 111378 RVA: 0x003F4CE0 File Offset: 0x003F2EE0
		[NullableContext(1)]
		public static TokenSelectView Create()
		{
			return new TokenSelectView();
		}

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x0601B313 RID: 111379 RVA: 0x003F4CE7 File Offset: 0x003F2EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x0601B314 RID: 111380 RVA: 0x003F4CEA File Offset: 0x003F2EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TokenSelectView.Descriptor;
			}
		}

		// Token: 0x0601B315 RID: 111381 RVA: 0x003F4CF1 File Offset: 0x003F2EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView()
		{
		}

		// Token: 0x0601B316 RID: 111382 RVA: 0x003F4CF9 File Offset: 0x003F2EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView(TokenSelectView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B317 RID: 111383 RVA: 0x003F4D2E File Offset: 0x003F2F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView Clone()
		{
			return new TokenSelectView(this);
		}

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x0601B318 RID: 111384 RVA: 0x003F4D36 File Offset: 0x003F2F36
		// (set) Token: 0x0601B319 RID: 111385 RVA: 0x003F4D3E File Offset: 0x003F2F3E
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

		// Token: 0x0601B31A RID: 111386 RVA: 0x003F4D47 File Offset: 0x003F2F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TokenSelectView);
		}

		// Token: 0x0601B31B RID: 111387 RVA: 0x003F4D55 File Offset: 0x003F2F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TokenSelectView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B31C RID: 111388 RVA: 0x003F4D88 File Offset: 0x003F2F88
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

		// Token: 0x0601B31D RID: 111389 RVA: 0x003F4DC4 File Offset: 0x003F2FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B31E RID: 111390 RVA: 0x003F4DD1 File Offset: 0x003F2FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B31F RID: 111391 RVA: 0x003F4DDA File Offset: 0x003F2FDA
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

		// Token: 0x0601B320 RID: 111392 RVA: 0x003F4E0C File Offset: 0x003F300C
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

		// Token: 0x0601B321 RID: 111393 RVA: 0x003F4E4C File Offset: 0x003F304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TokenSelectView other)
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

		// Token: 0x0601B322 RID: 111394 RVA: 0x003F4EA0 File Offset: 0x003F30A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B323 RID: 111395 RVA: 0x003F4EAC File Offset: 0x003F30AC
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

		// Token: 0x04009E93 RID: 40595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E94 RID: 40596
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04009E95 RID: 40597
		private SurvivorsOption survivorsOption_;
	}
}

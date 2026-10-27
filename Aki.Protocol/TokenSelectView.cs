using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001387 RID: 4999
	public sealed class TokenSelectView : IMessage<TokenSelectView>, IMessage, IEquatable<TokenSelectView>, IDeepCloneable<TokenSelectView>, IBufferMessage
	{
		// Token: 0x0601A889 RID: 108681 RVA: 0x003D9ACC File Offset: 0x003D7CCC
		[NullableContext(1)]
		public static TokenSelectView Create()
		{
			return new TokenSelectView();
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x0601A88A RID: 108682 RVA: 0x003D9AD3 File Offset: 0x003D7CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x0601A88B RID: 108683 RVA: 0x003D9AD6 File Offset: 0x003D7CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TokenSelectView.Descriptor;
			}
		}

		// Token: 0x0601A88C RID: 108684 RVA: 0x003D9ADD File Offset: 0x003D7CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView()
		{
		}

		// Token: 0x0601A88D RID: 108685 RVA: 0x003D9AE5 File Offset: 0x003D7CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView(TokenSelectView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A88E RID: 108686 RVA: 0x003D9B1A File Offset: 0x003D7D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView Clone()
		{
			return new TokenSelectView(this);
		}

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x0601A88F RID: 108687 RVA: 0x003D9B22 File Offset: 0x003D7D22
		// (set) Token: 0x0601A890 RID: 108688 RVA: 0x003D9B2A File Offset: 0x003D7D2A
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

		// Token: 0x0601A891 RID: 108689 RVA: 0x003D9B33 File Offset: 0x003D7D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TokenSelectView);
		}

		// Token: 0x0601A892 RID: 108690 RVA: 0x003D9B41 File Offset: 0x003D7D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TokenSelectView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A893 RID: 108691 RVA: 0x003D9B74 File Offset: 0x003D7D74
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

		// Token: 0x0601A894 RID: 108692 RVA: 0x003D9BB0 File Offset: 0x003D7DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A895 RID: 108693 RVA: 0x003D9BBD File Offset: 0x003D7DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A896 RID: 108694 RVA: 0x003D9BC6 File Offset: 0x003D7DC6
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

		// Token: 0x0601A897 RID: 108695 RVA: 0x003D9BF8 File Offset: 0x003D7DF8
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

		// Token: 0x0601A898 RID: 108696 RVA: 0x003D9C38 File Offset: 0x003D7E38
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

		// Token: 0x0601A899 RID: 108697 RVA: 0x003D9C8C File Offset: 0x003D7E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A89A RID: 108698 RVA: 0x003D9C98 File Offset: 0x003D7E98
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

		// Token: 0x04009A4E RID: 39502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A4F RID: 39503
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04009A50 RID: 39504
		private SurvivorsOption survivorsOption_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000301 RID: 769
	[NetMessage(EMessageId.CookingInfoUpdateNotify)]
	public sealed class CookingInfoUpdateNotify : IMessage<CookingInfoUpdateNotify>, IMessage, IEquatable<CookingInfoUpdateNotify>, IDeepCloneable<CookingInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004DF4 RID: 19956 RVA: 0x000BDC6F File Offset: 0x000BBE6F
		[NullableContext(1)]
		public static CookingInfoUpdateNotify Create()
		{
			return new CookingInfoUpdateNotify();
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004DF5 RID: 19957 RVA: 0x000BDC76 File Offset: 0x000BBE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x000BDC79 File Offset: 0x000BBE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x000BDC80 File Offset: 0x000BBE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify()
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x000BDC88 File Offset: 0x000BBE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify(CookingInfoUpdateNotify other) : this()
		{
			this.cookingInfo_ = ((other.cookingInfo_ != null) ? other.cookingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x000BDCBD File Offset: 0x000BBEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify Clone()
		{
			return new CookingInfoUpdateNotify(this);
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x000BDCC5 File Offset: 0x000BBEC5
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x000BDCCD File Offset: 0x000BBECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo CookingInfo
		{
			get
			{
				return this.cookingInfo_;
			}
			set
			{
				this.cookingInfo_ = value;
			}
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x000BDCD6 File Offset: 0x000BBED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingInfoUpdateNotify);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x000BDCE4 File Offset: 0x000BBEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CookingInfo, other.CookingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x000BDD18 File Offset: 0x000BBF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cookingInfo_ != null)
			{
				num ^= this.CookingInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x000BDD54 File Offset: 0x000BBF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x000BDD61 File Offset: 0x000BBF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x000BDD6A File Offset: 0x000BBF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cookingInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CookingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x000BDD9C File Offset: 0x000BBF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cookingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CookingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x000BDDDC File Offset: 0x000BBFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cookingInfo_ != null)
			{
				if (this.cookingInfo_ == null)
				{
					this.CookingInfo = new CookingInfo();
				}
				this.CookingInfo.MergeFrom(other.CookingInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x000BDE30 File Offset: 0x000BC030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x000BDE3C File Offset: 0x000BC03C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.cookingInfo_ == null)
					{
						this.CookingInfo = new CookingInfo();
					}
					input.ReadMessage(this.CookingInfo);
				}
			}
		}

		// Token: 0x040031CD RID: 12749
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031CE RID: 12750
		public const int CookingInfoFieldNumber = 4;

		// Token: 0x040031CF RID: 12751
		private CookingInfo cookingInfo_;
	}
}

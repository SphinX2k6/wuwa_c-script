using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E2 RID: 4322
	public sealed class RoleTowerRoleAttributeInfo : IMessage<RoleTowerRoleAttributeInfo>, IMessage, IEquatable<RoleTowerRoleAttributeInfo>, IDeepCloneable<RoleTowerRoleAttributeInfo>, IBufferMessage
	{
		// Token: 0x060171AE RID: 94638 RVA: 0x0035C905 File Offset: 0x0035AB05
		[NullableContext(1)]
		public static RoleTowerRoleAttributeInfo Create()
		{
			return new RoleTowerRoleAttributeInfo();
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x060171AF RID: 94639 RVA: 0x0035C90C File Offset: 0x0035AB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRoleAttributeInfo> Parser
		{
			get
			{
				return RoleTowerRoleAttributeInfo._parser;
			}
		}

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x060171B0 RID: 94640 RVA: 0x0035C913 File Offset: 0x0035AB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x060171B1 RID: 94641 RVA: 0x0035C916 File Offset: 0x0035AB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRoleAttributeInfo.Descriptor;
			}
		}

		// Token: 0x060171B2 RID: 94642 RVA: 0x0035C91D File Offset: 0x0035AB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleAttributeInfo()
		{
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x0035C930 File Offset: 0x0035AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleAttributeInfo(RoleTowerRoleAttributeInfo other) : this()
		{
			this.roleProp_ = ((other.roleProp_ != null) ? other.roleProp_.Clone() : null);
			this.phantomInfos_ = other.phantomInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171B4 RID: 94644 RVA: 0x0035C981 File Offset: 0x0035AB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleAttributeInfo Clone()
		{
			return new RoleTowerRoleAttributeInfo(this);
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x060171B5 RID: 94645 RVA: 0x0035C989 File Offset: 0x0035AB89
		// (set) Token: 0x060171B6 RID: 94646 RVA: 0x0035C991 File Offset: 0x0035AB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo RoleProp
		{
			get
			{
				return this.roleProp_;
			}
			set
			{
				this.roleProp_ = value;
			}
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x060171B7 RID: 94647 RVA: 0x0035C99A File Offset: 0x0035AB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerPhantomAttributeInfo> PhantomInfos
		{
			get
			{
				return this.phantomInfos_;
			}
		}

		// Token: 0x060171B8 RID: 94648 RVA: 0x0035C9A2 File Offset: 0x0035ABA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRoleAttributeInfo);
		}

		// Token: 0x060171B9 RID: 94649 RVA: 0x0035C9B0 File Offset: 0x0035ABB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRoleAttributeInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RoleProp, other.RoleProp) && this.phantomInfos_.Equals(other.phantomInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171BA RID: 94650 RVA: 0x0035CA04 File Offset: 0x0035AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleProp_ != null)
			{
				num ^= this.RoleProp.GetHashCode();
			}
			num ^= this.phantomInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171BB RID: 94651 RVA: 0x0035CA4E File Offset: 0x0035AC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171BC RID: 94652 RVA: 0x0035CA5B File Offset: 0x0035AC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171BD RID: 94653 RVA: 0x0035CA64 File Offset: 0x0035AC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleProp_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleProp);
			}
			this.phantomInfos_.WriteTo(ref output, RoleTowerRoleAttributeInfo._repeated_phantomInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171BE RID: 94654 RVA: 0x0035CAB4 File Offset: 0x0035ACB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleProp_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleProp);
			}
			num += this.phantomInfos_.CalculateSize(RoleTowerRoleAttributeInfo._repeated_phantomInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171BF RID: 94655 RVA: 0x0035CB08 File Offset: 0x0035AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRoleAttributeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleProp_ != null)
			{
				if (this.roleProp_ == null)
				{
					this.RoleProp = new RolePropInfo();
				}
				this.RoleProp.MergeFrom(other.RoleProp);
			}
			this.phantomInfos_.Add(other.phantomInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x0035CB6D File Offset: 0x0035AD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x0035CB78 File Offset: 0x0035AD78
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
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomInfos_.AddEntriesFrom(ref input, RoleTowerRoleAttributeInfo._repeated_phantomInfos_codec);
					}
				}
				else
				{
					if (this.roleProp_ == null)
					{
						this.RoleProp = new RolePropInfo();
					}
					input.ReadMessage(this.RoleProp);
				}
			}
		}

		// Token: 0x04008A4A RID: 35402
		private static readonly MessageParser<RoleTowerRoleAttributeInfo> _parser = new MessageParser<RoleTowerRoleAttributeInfo>(() => new RoleTowerRoleAttributeInfo());

		// Token: 0x04008A4B RID: 35403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A4C RID: 35404
		public const int RolePropFieldNumber = 1;

		// Token: 0x04008A4D RID: 35405
		private RolePropInfo roleProp_;

		// Token: 0x04008A4E RID: 35406
		public const int PhantomInfosFieldNumber = 3;

		// Token: 0x04008A4F RID: 35407
		private static readonly FieldCodec<RoleTowerPhantomAttributeInfo> _repeated_phantomInfos_codec = FieldCodec.ForMessage<RoleTowerPhantomAttributeInfo>(26U, RoleTowerPhantomAttributeInfo.Parser);

		// Token: 0x04008A50 RID: 35408
		private readonly RepeatedField<RoleTowerPhantomAttributeInfo> phantomInfos_ = new RepeatedField<RoleTowerPhantomAttributeInfo>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFA RID: 3322
	public sealed class PhantomStackMergeInfo : IMessage<PhantomStackMergeInfo>, IMessage, IEquatable<PhantomStackMergeInfo>, IDeepCloneable<PhantomStackMergeInfo>, IBufferMessage
	{
		// Token: 0x06011F9F RID: 73631 RVA: 0x002A1243 File Offset: 0x0029F443
		[NullableContext(1)]
		public static PhantomStackMergeInfo Create()
		{
			return new PhantomStackMergeInfo();
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x06011FA0 RID: 73632 RVA: 0x002A124A File Offset: 0x0029F44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackMergeInfo> Parser
		{
			get
			{
				return PhantomStackMergeInfo._parser;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x06011FA1 RID: 73633 RVA: 0x002A1251 File Offset: 0x0029F451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x002A1254 File Offset: 0x0029F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackMergeInfo.Descriptor;
			}
		}

		// Token: 0x06011FA3 RID: 73635 RVA: 0x002A125B File Offset: 0x0029F45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo()
		{
		}

		// Token: 0x06011FA4 RID: 73636 RVA: 0x002A1264 File Offset: 0x0029F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo(PhantomStackMergeInfo other) : this()
		{
			this.mergedIncrId_ = other.mergedIncrId_;
			this.representativeItem_ = ((other.representativeItem_ != null) ? other.representativeItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FA5 RID: 73637 RVA: 0x002A12B0 File Offset: 0x0029F4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo Clone()
		{
			return new PhantomStackMergeInfo(this);
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x06011FA6 RID: 73638 RVA: 0x002A12B8 File Offset: 0x0029F4B8
		// (set) Token: 0x06011FA7 RID: 73639 RVA: 0x002A12C0 File Offset: 0x0029F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MergedIncrId
		{
			get
			{
				return this.mergedIncrId_;
			}
			set
			{
				this.mergedIncrId_ = value;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x06011FA8 RID: 73640 RVA: 0x002A12C9 File Offset: 0x0029F4C9
		// (set) Token: 0x06011FA9 RID: 73641 RVA: 0x002A12D1 File Offset: 0x0029F4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem RepresentativeItem
		{
			get
			{
				return this.representativeItem_;
			}
			set
			{
				this.representativeItem_ = value;
			}
		}

		// Token: 0x06011FAA RID: 73642 RVA: 0x002A12DA File Offset: 0x0029F4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackMergeInfo);
		}

		// Token: 0x06011FAB RID: 73643 RVA: 0x002A12E8 File Offset: 0x0029F4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackMergeInfo other)
		{
			return other != null && (other == this || (this.MergedIncrId == other.MergedIncrId && object.Equals(this.RepresentativeItem, other.RepresentativeItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FAC RID: 73644 RVA: 0x002A1338 File Offset: 0x0029F538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MergedIncrId != 0)
			{
				num ^= this.MergedIncrId.GetHashCode();
			}
			if (this.representativeItem_ != null)
			{
				num ^= this.RepresentativeItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FAD RID: 73645 RVA: 0x002A138D File Offset: 0x0029F58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FAE RID: 73646 RVA: 0x002A139A File Offset: 0x0029F59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FAF RID: 73647 RVA: 0x002A13A4 File Offset: 0x0029F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MergedIncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MergedIncrId);
			}
			if (this.representativeItem_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RepresentativeItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FB0 RID: 73648 RVA: 0x002A13FC File Offset: 0x0029F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MergedIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MergedIncrId);
			}
			if (this.representativeItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RepresentativeItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FB1 RID: 73649 RVA: 0x002A1454 File Offset: 0x0029F654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomStackMergeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MergedIncrId != 0)
			{
				this.MergedIncrId = other.MergedIncrId;
			}
			if (other.representativeItem_ != null)
			{
				if (this.representativeItem_ == null)
				{
					this.RepresentativeItem = new PhantomItem();
				}
				this.RepresentativeItem.MergeFrom(other.RepresentativeItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FB2 RID: 73650 RVA: 0x002A14BC File Offset: 0x0029F6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FB3 RID: 73651 RVA: 0x002A14C8 File Offset: 0x0029F6C8
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.representativeItem_ == null)
						{
							this.RepresentativeItem = new PhantomItem();
						}
						input.ReadMessage(this.RepresentativeItem);
					}
				}
				else
				{
					this.MergedIncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007104 RID: 28932
		private static readonly MessageParser<PhantomStackMergeInfo> _parser = new MessageParser<PhantomStackMergeInfo>(() => new PhantomStackMergeInfo());

		// Token: 0x04007105 RID: 28933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007106 RID: 28934
		public const int MergedIncrIdFieldNumber = 1;

		// Token: 0x04007107 RID: 28935
		private int mergedIncrId_;

		// Token: 0x04007108 RID: 28936
		public const int RepresentativeItemFieldNumber = 2;

		// Token: 0x04007109 RID: 28937
		private PhantomItem representativeItem_;
	}
}

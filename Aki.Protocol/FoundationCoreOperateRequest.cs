using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000624 RID: 1572
	[NetMessage(EMessageId.FoundationCoreOperateRequest)]
	public sealed class FoundationCoreOperateRequest : IMessage<FoundationCoreOperateRequest>, IMessage, IEquatable<FoundationCoreOperateRequest>, IDeepCloneable<FoundationCoreOperateRequest>, IBufferMessage
	{
		// Token: 0x0600915F RID: 37215 RVA: 0x0016051C File Offset: 0x0015E71C
		[NullableContext(1)]
		public static FoundationCoreOperateRequest Create()
		{
			return new FoundationCoreOperateRequest();
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x00160523 File Offset: 0x0015E723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x00160526 File Offset: 0x0015E726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreOperateRequest.Descriptor;
			}
		}

		// Token: 0x06009162 RID: 37218 RVA: 0x0016052D File Offset: 0x0015E72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest()
		{
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x00160535 File Offset: 0x0015E735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest(FoundationCoreOperateRequest other) : this()
		{
			this.foundationEntityIncId_ = other.foundationEntityIncId_;
			this.isTakeOut_ = other.isTakeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x00160566 File Offset: 0x0015E766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest Clone()
		{
			return new FoundationCoreOperateRequest(this);
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06009165 RID: 37221 RVA: 0x0016056E File Offset: 0x0015E76E
		// (set) Token: 0x06009166 RID: 37222 RVA: 0x00160576 File Offset: 0x0015E776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FoundationEntityIncId
		{
			get
			{
				return this.foundationEntityIncId_;
			}
			set
			{
				this.foundationEntityIncId_ = value;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06009167 RID: 37223 RVA: 0x0016057F File Offset: 0x0015E77F
		// (set) Token: 0x06009168 RID: 37224 RVA: 0x00160587 File Offset: 0x0015E787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakeOut
		{
			get
			{
				return this.isTakeOut_;
			}
			set
			{
				this.isTakeOut_ = value;
			}
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x00160590 File Offset: 0x0015E790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreOperateRequest);
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0016059E File Offset: 0x0015E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreOperateRequest other)
		{
			return other != null && (other == this || (this.FoundationEntityIncId == other.FoundationEntityIncId && this.IsTakeOut == other.IsTakeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x001605DC File Offset: 0x0015E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityIncId != 0L)
			{
				num ^= this.FoundationEntityIncId.GetHashCode();
			}
			if (this.IsTakeOut)
			{
				num ^= this.IsTakeOut.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x00160634 File Offset: 0x0015E834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x00160641 File Offset: 0x0015E841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x0016064C File Offset: 0x0015E84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsTakeOut)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsTakeOut);
			}
			if (this.FoundationEntityIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.FoundationEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x001606A8 File Offset: 0x0015E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FoundationEntityIncId);
			}
			if (this.IsTakeOut)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x001606F4 File Offset: 0x0015E8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityIncId != 0L)
			{
				this.FoundationEntityIncId = other.FoundationEntityIncId;
			}
			if (other.IsTakeOut)
			{
				this.IsTakeOut = other.IsTakeOut;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x00160744 File Offset: 0x0015E944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x00160750 File Offset: 0x0015E950
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FoundationEntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.IsTakeOut = input.ReadBool();
				}
			}
		}

		// Token: 0x040046A9 RID: 18089
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046AA RID: 18090
		public const int FoundationEntityIncIdFieldNumber = 3;

		// Token: 0x040046AB RID: 18091
		private long foundationEntityIncId_;

		// Token: 0x040046AC RID: 18092
		public const int IsTakeOutFieldNumber = 2;

		// Token: 0x040046AD RID: 18093
		private bool isTakeOut_;
	}
}

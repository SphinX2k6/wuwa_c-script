using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F9 RID: 4601
	[NetMessage(EMessageId.SelectDetectionTargetRequest)]
	public sealed class SelectDetectionTargetRequest : IMessage<SelectDetectionTargetRequest>, IMessage, IEquatable<SelectDetectionTargetRequest>, IDeepCloneable<SelectDetectionTargetRequest>, IBufferMessage
	{
		// Token: 0x0601897F RID: 100735 RVA: 0x00396A20 File Offset: 0x00394C20
		[NullableContext(1)]
		public static SelectDetectionTargetRequest Create()
		{
			return new SelectDetectionTargetRequest();
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x06018980 RID: 100736 RVA: 0x00396A27 File Offset: 0x00394C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x06018981 RID: 100737 RVA: 0x00396A2A File Offset: 0x00394C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTargetRequest.Descriptor;
			}
		}

		// Token: 0x06018982 RID: 100738 RVA: 0x00396A31 File Offset: 0x00394C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest()
		{
		}

		// Token: 0x06018983 RID: 100739 RVA: 0x00396A3C File Offset: 0x00394C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest(SelectDetectionTargetRequest other) : this()
		{
			this.selectDetectionTarget_ = ((other.selectDetectionTarget_ != null) ? other.selectDetectionTarget_.Clone() : null);
			this.isCancelSelect_ = other.isCancelSelect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018984 RID: 100740 RVA: 0x00396A88 File Offset: 0x00394C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest Clone()
		{
			return new SelectDetectionTargetRequest(this);
		}

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x06018985 RID: 100741 RVA: 0x00396A90 File Offset: 0x00394C90
		// (set) Token: 0x06018986 RID: 100742 RVA: 0x00396A98 File Offset: 0x00394C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget SelectDetectionTarget
		{
			get
			{
				return this.selectDetectionTarget_;
			}
			set
			{
				this.selectDetectionTarget_ = value;
			}
		}

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x06018987 RID: 100743 RVA: 0x00396AA1 File Offset: 0x00394CA1
		// (set) Token: 0x06018988 RID: 100744 RVA: 0x00396AA9 File Offset: 0x00394CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCancelSelect
		{
			get
			{
				return this.isCancelSelect_;
			}
			set
			{
				this.isCancelSelect_ = value;
			}
		}

		// Token: 0x06018989 RID: 100745 RVA: 0x00396AB2 File Offset: 0x00394CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTargetRequest);
		}

		// Token: 0x0601898A RID: 100746 RVA: 0x00396AC0 File Offset: 0x00394CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTargetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.SelectDetectionTarget, other.SelectDetectionTarget) && this.IsCancelSelect == other.IsCancelSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601898B RID: 100747 RVA: 0x00396B10 File Offset: 0x00394D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.selectDetectionTarget_ != null)
			{
				num ^= this.SelectDetectionTarget.GetHashCode();
			}
			if (this.IsCancelSelect)
			{
				num ^= this.IsCancelSelect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601898C RID: 100748 RVA: 0x00396B65 File Offset: 0x00394D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601898D RID: 100749 RVA: 0x00396B72 File Offset: 0x00394D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601898E RID: 100750 RVA: 0x00396B7C File Offset: 0x00394D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selectDetectionTarget_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SelectDetectionTarget);
			}
			if (this.IsCancelSelect)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsCancelSelect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601898F RID: 100751 RVA: 0x00396BD8 File Offset: 0x00394DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.selectDetectionTarget_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectDetectionTarget);
			}
			if (this.IsCancelSelect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018990 RID: 100752 RVA: 0x00396C24 File Offset: 0x00394E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectDetectionTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.selectDetectionTarget_ != null)
			{
				if (this.selectDetectionTarget_ == null)
				{
					this.SelectDetectionTarget = new SelectDetectionTarget();
				}
				this.SelectDetectionTarget.MergeFrom(other.SelectDetectionTarget);
			}
			if (other.IsCancelSelect)
			{
				this.IsCancelSelect = other.IsCancelSelect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018991 RID: 100753 RVA: 0x00396C8C File Offset: 0x00394E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018992 RID: 100754 RVA: 0x00396C98 File Offset: 0x00394E98
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
				if (num != 58U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsCancelSelect = input.ReadBool();
					}
				}
				else
				{
					if (this.selectDetectionTarget_ == null)
					{
						this.SelectDetectionTarget = new SelectDetectionTarget();
					}
					input.ReadMessage(this.SelectDetectionTarget);
				}
			}
		}

		// Token: 0x04009250 RID: 37456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009251 RID: 37457
		public const int SelectDetectionTargetFieldNumber = 7;

		// Token: 0x04009252 RID: 37458
		private SelectDetectionTarget selectDetectionTarget_;

		// Token: 0x04009253 RID: 37459
		public const int IsCancelSelectFieldNumber = 10;

		// Token: 0x04009254 RID: 37460
		private bool isCancelSelect_;
	}
}

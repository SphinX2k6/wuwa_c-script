using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BF RID: 4543
	[NetMessage(EMessageId.SelectDetectionTargetRequest)]
	public sealed class SelectDetectionTargetRequest : IMessage<SelectDetectionTargetRequest>, IMessage, IEquatable<SelectDetectionTargetRequest>, IDeepCloneable<SelectDetectionTargetRequest>, IBufferMessage
	{
		// Token: 0x060183DE RID: 99294 RVA: 0x003876F0 File Offset: 0x003858F0
		[NullableContext(1)]
		public static SelectDetectionTargetRequest Create()
		{
			return new SelectDetectionTargetRequest();
		}

		// Token: 0x170051AC RID: 20908
		// (get) Token: 0x060183DF RID: 99295 RVA: 0x003876F7 File Offset: 0x003858F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x060183E0 RID: 99296 RVA: 0x003876FA File Offset: 0x003858FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTargetRequest.Descriptor;
			}
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x00387701 File Offset: 0x00385901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest()
		{
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x0038770C File Offset: 0x0038590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest(SelectDetectionTargetRequest other) : this()
		{
			this.selectDetectionTarget_ = ((other.selectDetectionTarget_ != null) ? other.selectDetectionTarget_.Clone() : null);
			this.isCancelSelect_ = other.isCancelSelect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x00387758 File Offset: 0x00385958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetRequest Clone()
		{
			return new SelectDetectionTargetRequest(this);
		}

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x060183E4 RID: 99300 RVA: 0x00387760 File Offset: 0x00385960
		// (set) Token: 0x060183E5 RID: 99301 RVA: 0x00387768 File Offset: 0x00385968
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

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x060183E6 RID: 99302 RVA: 0x00387771 File Offset: 0x00385971
		// (set) Token: 0x060183E7 RID: 99303 RVA: 0x00387779 File Offset: 0x00385979
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

		// Token: 0x060183E8 RID: 99304 RVA: 0x00387782 File Offset: 0x00385982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTargetRequest);
		}

		// Token: 0x060183E9 RID: 99305 RVA: 0x00387790 File Offset: 0x00385990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTargetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.SelectDetectionTarget, other.SelectDetectionTarget) && this.IsCancelSelect == other.IsCancelSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183EA RID: 99306 RVA: 0x003877E0 File Offset: 0x003859E0
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

		// Token: 0x060183EB RID: 99307 RVA: 0x00387835 File Offset: 0x00385A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183EC RID: 99308 RVA: 0x00387842 File Offset: 0x00385A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183ED RID: 99309 RVA: 0x0038784C File Offset: 0x00385A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCancelSelect)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsCancelSelect);
			}
			if (this.selectDetectionTarget_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SelectDetectionTarget);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183EE RID: 99310 RVA: 0x003878A8 File Offset: 0x00385AA8
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

		// Token: 0x060183EF RID: 99311 RVA: 0x003878F4 File Offset: 0x00385AF4
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

		// Token: 0x060183F0 RID: 99312 RVA: 0x0038795C File Offset: 0x00385B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183F1 RID: 99313 RVA: 0x00387968 File Offset: 0x00385B68
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsCancelSelect = input.ReadBool();
				}
			}
		}

		// Token: 0x04008FBD RID: 36797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FBE RID: 36798
		public const int SelectDetectionTargetFieldNumber = 9;

		// Token: 0x04008FBF RID: 36799
		private SelectDetectionTarget selectDetectionTarget_;

		// Token: 0x04008FC0 RID: 36800
		public const int IsCancelSelectFieldNumber = 6;

		// Token: 0x04008FC1 RID: 36801
		private bool isCancelSelect_;
	}
}

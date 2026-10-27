using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001523 RID: 5411
	[NetMessage(EMessageId.WuWuKujiGachaRequest)]
	public sealed class WuWuKujiGachaRequest : IMessage<WuWuKujiGachaRequest>, IMessage, IEquatable<WuWuKujiGachaRequest>, IDeepCloneable<WuWuKujiGachaRequest>, IBufferMessage
	{
		// Token: 0x0601C991 RID: 117137 RVA: 0x00421608 File Offset: 0x0041F808
		[NullableContext(1)]
		public static WuWuKujiGachaRequest Create()
		{
			return new WuWuKujiGachaRequest();
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x0601C992 RID: 117138 RVA: 0x0042160F File Offset: 0x0041F80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x0601C993 RID: 117139 RVA: 0x00421612 File Offset: 0x0041F812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiGachaRequest.Descriptor;
			}
		}

		// Token: 0x0601C994 RID: 117140 RVA: 0x00421619 File Offset: 0x0041F819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest()
		{
		}

		// Token: 0x0601C995 RID: 117141 RVA: 0x00421621 File Offset: 0x0041F821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest(WuWuKujiGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C996 RID: 117142 RVA: 0x00421646 File Offset: 0x0041F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest Clone()
		{
			return new WuWuKujiGachaRequest(this);
		}

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x0601C997 RID: 117143 RVA: 0x0042164E File Offset: 0x0041F84E
		// (set) Token: 0x0601C998 RID: 117144 RVA: 0x00421656 File Offset: 0x0041F856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601C999 RID: 117145 RVA: 0x0042165F File Offset: 0x0041F85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiGachaRequest);
		}

		// Token: 0x0601C99A RID: 117146 RVA: 0x0042166D File Offset: 0x0041F86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C99B RID: 117147 RVA: 0x0042169C File Offset: 0x0041F89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C99C RID: 117148 RVA: 0x004216DB File Offset: 0x0041F8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C99D RID: 117149 RVA: 0x004216E8 File Offset: 0x0041F8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C99E RID: 117150 RVA: 0x004216F1 File Offset: 0x0041F8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C99F RID: 117151 RVA: 0x00421724 File Offset: 0x0041F924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9A0 RID: 117152 RVA: 0x00421762 File Offset: 0x0041F962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuKujiGachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x00421793 File Offset: 0x0041F993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9A2 RID: 117154 RVA: 0x0042179C File Offset: 0x0041F99C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A394 RID: 41876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A395 RID: 41877
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x0400A396 RID: 41878
		private int activityId_;
	}
}

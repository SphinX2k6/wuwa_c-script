using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CF RID: 207
	[NetMessage(EMessageId.AdviceSetRequest)]
	public sealed class AdviceSetRequest : IMessage<AdviceSetRequest>, IMessage, IEquatable<AdviceSetRequest>, IDeepCloneable<AdviceSetRequest>, IBufferMessage
	{
		// Token: 0x06001FEC RID: 8172 RVA: 0x000567D0 File Offset: 0x000549D0
		[NullableContext(1)]
		public static AdviceSetRequest Create()
		{
			return new AdviceSetRequest();
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000567D7 File Offset: 0x000549D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000567DA File Offset: 0x000549DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSetRequest.Descriptor;
			}
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000567E1 File Offset: 0x000549E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest()
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000567E9 File Offset: 0x000549E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest(AdviceSetRequest other) : this()
		{
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0005680E File Offset: 0x00054A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest Clone()
		{
			return new AdviceSetRequest(this);
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00056816 File Offset: 0x00054A16
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x0005681E File Offset: 0x00054A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00056827 File Offset: 0x00054A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSetRequest);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00056835 File Offset: 0x00054A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSetRequest other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00056864 File Offset: 0x00054A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000568A3 File Offset: 0x00054AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000568B0 File Offset: 0x00054AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000568B9 File Offset: 0x00054AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000568EC File Offset: 0x00054AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0005691E File Offset: 0x00054B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0005694F File Offset: 0x00054B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00056958 File Offset: 0x00054B58
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x040023D9 RID: 9177
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023DA RID: 9178
		public const int IsShowFieldNumber = 3;

		// Token: 0x040023DB RID: 9179
		private bool isShow_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CD RID: 4813
	[NetMessage(EMessageId.SurvivorsLastInfoResponse)]
	public sealed class SurvivorsLastInfoResponse : IMessage<SurvivorsLastInfoResponse>, IMessage, IEquatable<SurvivorsLastInfoResponse>, IDeepCloneable<SurvivorsLastInfoResponse>, IBufferMessage
	{
		// Token: 0x060199BF RID: 104895 RVA: 0x003B92DE File Offset: 0x003B74DE
		[NullableContext(1)]
		public static SurvivorsLastInfoResponse Create()
		{
			return new SurvivorsLastInfoResponse();
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x060199C0 RID: 104896 RVA: 0x003B92E5 File Offset: 0x003B74E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x060199C1 RID: 104897 RVA: 0x003B92E8 File Offset: 0x003B74E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x060199C2 RID: 104898 RVA: 0x003B92EF File Offset: 0x003B74EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse()
		{
		}

		// Token: 0x060199C3 RID: 104899 RVA: 0x003B92F7 File Offset: 0x003B74F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse(SurvivorsLastInfoResponse other) : this()
		{
			this.survivorLastInfo_ = ((other.survivorLastInfo_ != null) ? other.survivorLastInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199C4 RID: 104900 RVA: 0x003B932C File Offset: 0x003B752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse Clone()
		{
			return new SurvivorsLastInfoResponse(this);
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x060199C5 RID: 104901 RVA: 0x003B9334 File Offset: 0x003B7534
		// (set) Token: 0x060199C6 RID: 104902 RVA: 0x003B933C File Offset: 0x003B753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo SurvivorLastInfo
		{
			get
			{
				return this.survivorLastInfo_;
			}
			set
			{
				this.survivorLastInfo_ = value;
			}
		}

		// Token: 0x060199C7 RID: 104903 RVA: 0x003B9345 File Offset: 0x003B7545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLastInfoResponse);
		}

		// Token: 0x060199C8 RID: 104904 RVA: 0x003B9353 File Offset: 0x003B7553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLastInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorLastInfo, other.SurvivorLastInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199C9 RID: 104905 RVA: 0x003B9388 File Offset: 0x003B7588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorLastInfo_ != null)
			{
				num ^= this.SurvivorLastInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060199CA RID: 104906 RVA: 0x003B93C4 File Offset: 0x003B75C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199CB RID: 104907 RVA: 0x003B93D1 File Offset: 0x003B75D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199CC RID: 104908 RVA: 0x003B93DA File Offset: 0x003B75DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorLastInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SurvivorLastInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199CD RID: 104909 RVA: 0x003B940C File Offset: 0x003B760C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorLastInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorLastInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060199CE RID: 104910 RVA: 0x003B944C File Offset: 0x003B764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLastInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorLastInfo_ != null)
			{
				if (this.survivorLastInfo_ == null)
				{
					this.SurvivorLastInfo = new SurvivorLastInfo();
				}
				this.SurvivorLastInfo.MergeFrom(other.SurvivorLastInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060199CF RID: 104911 RVA: 0x003B94A0 File Offset: 0x003B76A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199D0 RID: 104912 RVA: 0x003B94AC File Offset: 0x003B76AC
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.survivorLastInfo_ == null)
					{
						this.SurvivorLastInfo = new SurvivorLastInfo();
					}
					input.ReadMessage(this.SurvivorLastInfo);
				}
			}
		}

		// Token: 0x0400963B RID: 38459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400963C RID: 38460
		public const int SurvivorLastInfoFieldNumber = 10;

		// Token: 0x0400963D RID: 38461
		private SurvivorLastInfo survivorLastInfo_;
	}
}

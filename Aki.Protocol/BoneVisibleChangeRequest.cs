using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C0 RID: 448
	[NetMessage(EMessageId.BoneVisibleChangeRequest)]
	public sealed class BoneVisibleChangeRequest : IMessage<BoneVisibleChangeRequest>, IMessage, IEquatable<BoneVisibleChangeRequest>, IDeepCloneable<BoneVisibleChangeRequest>, IBufferMessage
	{
		// Token: 0x060033D7 RID: 13271 RVA: 0x00083588 File Offset: 0x00081788
		[NullableContext(1)]
		public static BoneVisibleChangeRequest Create()
		{
			return new BoneVisibleChangeRequest();
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x0008358F File Offset: 0x0008178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x00083592 File Offset: 0x00081792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeRequest.Descriptor;
			}
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00083599 File Offset: 0x00081799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest()
		{
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000835A1 File Offset: 0x000817A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest(BoneVisibleChangeRequest other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000835D6 File Offset: 0x000817D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest Clone()
		{
			return new BoneVisibleChangeRequest(this);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x000835DE File Offset: 0x000817DE
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x000835E6 File Offset: 0x000817E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData BoneVisibleData
		{
			get
			{
				return this.boneVisibleData_;
			}
			set
			{
				this.boneVisibleData_ = value;
			}
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x000835EF File Offset: 0x000817EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeRequest);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000835FD File Offset: 0x000817FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeRequest other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00083630 File Offset: 0x00081830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.boneVisibleData_ != null)
			{
				num ^= this.BoneVisibleData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0008366C File Offset: 0x0008186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00083679 File Offset: 0x00081879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00083682 File Offset: 0x00081882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000836B4 File Offset: 0x000818B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.boneVisibleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000836F4 File Offset: 0x000818F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.boneVisibleData_ != null)
			{
				if (this.boneVisibleData_ == null)
				{
					this.BoneVisibleData = new BoneVisibleData();
				}
				this.BoneVisibleData.MergeFrom(other.BoneVisibleData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00083748 File Offset: 0x00081948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00083754 File Offset: 0x00081954
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.boneVisibleData_ == null)
					{
						this.BoneVisibleData = new BoneVisibleData();
					}
					input.ReadMessage(this.BoneVisibleData);
				}
			}
		}

		// Token: 0x04002A2D RID: 10797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A2E RID: 10798
		public const int BoneVisibleDataFieldNumber = 11;

		// Token: 0x04002A2F RID: 10799
		private BoneVisibleData boneVisibleData_;
	}
}

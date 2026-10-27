using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056E RID: 1390
	[NetMessage(EMessageId.FishingPointInfoRequest)]
	public sealed class FishingPointInfoRequest : IMessage<FishingPointInfoRequest>, IMessage, IEquatable<FishingPointInfoRequest>, IDeepCloneable<FishingPointInfoRequest>, IBufferMessage
	{
		// Token: 0x06008175 RID: 33141 RVA: 0x00138D05 File Offset: 0x00136F05
		[NullableContext(1)]
		public static FishingPointInfoRequest Create()
		{
			return new FishingPointInfoRequest();
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06008176 RID: 33142 RVA: 0x00138D0C File Offset: 0x00136F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06008177 RID: 33143 RVA: 0x00138D0F File Offset: 0x00136F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPointInfoRequest.Descriptor;
			}
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00138D16 File Offset: 0x00136F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest()
		{
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00138D1E File Offset: 0x00136F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest(FishingPointInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00138D43 File Offset: 0x00136F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest Clone()
		{
			return new FishingPointInfoRequest(this);
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x00138D4B File Offset: 0x00136F4B
		// (set) Token: 0x0600817C RID: 33148 RVA: 0x00138D53 File Offset: 0x00136F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x00138D5C File Offset: 0x00136F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPointInfoRequest);
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00138D6A File Offset: 0x00136F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPointInfoRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00138D98 File Offset: 0x00136F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x00138DD7 File Offset: 0x00136FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x00138DE4 File Offset: 0x00136FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00138DED File Offset: 0x00136FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00138E20 File Offset: 0x00137020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00138E5E File Offset: 0x0013705E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPointInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00138E8F File Offset: 0x0013708F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00138E98 File Offset: 0x00137098
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004107 RID: 16647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004108 RID: 16648
		public const int IdFieldNumber = 4;

		// Token: 0x04004109 RID: 16649
		private int id_;
	}
}

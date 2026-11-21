using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000559 RID: 1369
	[NetMessage(EMessageId.FishingPointInfoRequest)]
	public sealed class FishingPointInfoRequest : IMessage<FishingPointInfoRequest>, IMessage, IEquatable<FishingPointInfoRequest>, IDeepCloneable<FishingPointInfoRequest>, IBufferMessage
	{
		// Token: 0x0600800D RID: 32781 RVA: 0x00136105 File Offset: 0x00134305
		[NullableContext(1)]
		public static FishingPointInfoRequest Create()
		{
			return new FishingPointInfoRequest();
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x0013610C File Offset: 0x0013430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600800F RID: 32783 RVA: 0x0013610F File Offset: 0x0013430F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPointInfoRequest.Descriptor;
			}
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x00136116 File Offset: 0x00134316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest()
		{
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x0013611E File Offset: 0x0013431E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest(FishingPointInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x00136143 File Offset: 0x00134343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoRequest Clone()
		{
			return new FishingPointInfoRequest(this);
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x0013614B File Offset: 0x0013434B
		// (set) Token: 0x06008014 RID: 32788 RVA: 0x00136153 File Offset: 0x00134353
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

		// Token: 0x06008015 RID: 32789 RVA: 0x0013615C File Offset: 0x0013435C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPointInfoRequest);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x0013616A File Offset: 0x0013436A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPointInfoRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x00136198 File Offset: 0x00134398
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

		// Token: 0x06008018 RID: 32792 RVA: 0x001361D7 File Offset: 0x001343D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x001361E4 File Offset: 0x001343E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x001361ED File Offset: 0x001343ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00136220 File Offset: 0x00134420
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

		// Token: 0x0600801C RID: 32796 RVA: 0x0013625E File Offset: 0x0013445E
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

		// Token: 0x0600801D RID: 32797 RVA: 0x0013628F File Offset: 0x0013448F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00136298 File Offset: 0x00134498
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040040FD RID: 16637
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040FE RID: 16638
		public const int IdFieldNumber = 11;

		// Token: 0x040040FF RID: 16639
		private int id_;
	}
}

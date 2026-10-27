using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020D RID: 525
	[NetMessage(EMessageId.BuildingLevelUpRequest)]
	public sealed class BuildingLevelUpRequest : IMessage<BuildingLevelUpRequest>, IMessage, IEquatable<BuildingLevelUpRequest>, IDeepCloneable<BuildingLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060039DF RID: 14815 RVA: 0x000905FE File Offset: 0x0008E7FE
		[NullableContext(1)]
		public static BuildingLevelUpRequest Create()
		{
			return new BuildingLevelUpRequest();
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x00090605 File Offset: 0x0008E805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x00090608 File Offset: 0x0008E808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x0009060F File Offset: 0x0008E80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest()
		{
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00090617 File Offset: 0x0008E817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest(BuildingLevelUpRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0009063C File Offset: 0x0008E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest Clone()
		{
			return new BuildingLevelUpRequest(this);
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x00090644 File Offset: 0x0008E844
		// (set) Token: 0x060039E6 RID: 14822 RVA: 0x0009064C File Offset: 0x0008E84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuildingId
		{
			get
			{
				return this.buildingId_;
			}
			set
			{
				this.buildingId_ = value;
			}
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00090655 File Offset: 0x0008E855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingLevelUpRequest);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00090663 File Offset: 0x0008E863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingLevelUpRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x00090694 File Offset: 0x0008E894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuildingId != 0)
			{
				num ^= this.BuildingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x000906D3 File Offset: 0x0008E8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x000906E0 File Offset: 0x0008E8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x000906E9 File Offset: 0x0008E8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0009071C File Offset: 0x0008E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuildingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0009075A File Offset: 0x0008E95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuildingId != 0)
			{
				this.BuildingId = other.BuildingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x0009078B File Offset: 0x0008E98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00090794 File Offset: 0x0008E994
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BAD RID: 11181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BAE RID: 11182
		public const int BuildingIdFieldNumber = 1;

		// Token: 0x04002BAF RID: 11183
		private int buildingId_;
	}
}

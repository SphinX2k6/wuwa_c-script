using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DF RID: 1247
	[NetMessage(EMessageId.ExploreEntityTraceRequest)]
	public sealed class ExploreEntityTraceRequest : IMessage<ExploreEntityTraceRequest>, IMessage, IEquatable<ExploreEntityTraceRequest>, IDeepCloneable<ExploreEntityTraceRequest>, IBufferMessage
	{
		// Token: 0x06007660 RID: 30304 RVA: 0x00121461 File Offset: 0x0011F661
		[NullableContext(1)]
		public static ExploreEntityTraceRequest Create()
		{
			return new ExploreEntityTraceRequest();
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x00121468 File Offset: 0x0011F668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06007662 RID: 30306 RVA: 0x0012146B File Offset: 0x0011F66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreEntityTraceRequest.Descriptor;
			}
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00121472 File Offset: 0x0011F672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest()
		{
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x0012147A File Offset: 0x0011F67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest(ExploreEntityTraceRequest other) : this()
		{
			this.exploratoryDegree_ = other.exploratoryDegree_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x001214AB File Offset: 0x0011F6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest Clone()
		{
			return new ExploreEntityTraceRequest(this);
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x001214B3 File Offset: 0x0011F6B3
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x001214BB File Offset: 0x0011F6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploratoryDegree
		{
			get
			{
				return this.exploratoryDegree_;
			}
			set
			{
				this.exploratoryDegree_ = value;
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x001214C4 File Offset: 0x0011F6C4
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x001214CC File Offset: 0x0011F6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x001214D5 File Offset: 0x0011F6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreEntityTraceRequest);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x001214E3 File Offset: 0x0011F6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreEntityTraceRequest other)
		{
			return other != null && (other == this || (this.ExploratoryDegree == other.ExploratoryDegree && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00121524 File Offset: 0x0011F724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExploratoryDegree != 0)
			{
				num ^= this.ExploratoryDegree.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x0012157C File Offset: 0x0011F77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00121589 File Offset: 0x0011F789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00121594 File Offset: 0x0011F794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExploratoryDegree != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExploratoryDegree);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x001215EC File Offset: 0x0011F7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExploratoryDegree != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploratoryDegree);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00121644 File Offset: 0x0011F844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreEntityTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExploratoryDegree != 0)
			{
				this.ExploratoryDegree = other.ExploratoryDegree;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00121694 File Offset: 0x0011F894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x001216A0 File Offset: 0x0011F8A0
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AreaId = input.ReadInt32();
					}
				}
				else
				{
					this.ExploratoryDegree = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E36 RID: 15926
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E37 RID: 15927
		public const int ExploratoryDegreeFieldNumber = 1;

		// Token: 0x04003E38 RID: 15928
		private int exploratoryDegree_;

		// Token: 0x04003E39 RID: 15929
		public const int AreaIdFieldNumber = 13;

		// Token: 0x04003E3A RID: 15930
		private int areaId_;
	}
}

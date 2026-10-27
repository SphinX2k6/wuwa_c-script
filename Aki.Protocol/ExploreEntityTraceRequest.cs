using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F5 RID: 1269
	[NetMessage(EMessageId.ExploreEntityTraceRequest)]
	public sealed class ExploreEntityTraceRequest : IMessage<ExploreEntityTraceRequest>, IMessage, IEquatable<ExploreEntityTraceRequest>, IDeepCloneable<ExploreEntityTraceRequest>, IBufferMessage
	{
		// Token: 0x060077DC RID: 30684 RVA: 0x001242ED File Offset: 0x001224ED
		[NullableContext(1)]
		public static ExploreEntityTraceRequest Create()
		{
			return new ExploreEntityTraceRequest();
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x001242F4 File Offset: 0x001224F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x001242F7 File Offset: 0x001224F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreEntityTraceRequest.Descriptor;
			}
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x001242FE File Offset: 0x001224FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest()
		{
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00124306 File Offset: 0x00122506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest(ExploreEntityTraceRequest other) : this()
		{
			this.exploratoryDegree_ = other.exploratoryDegree_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00124337 File Offset: 0x00122537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceRequest Clone()
		{
			return new ExploreEntityTraceRequest(this);
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x060077E2 RID: 30690 RVA: 0x0012433F File Offset: 0x0012253F
		// (set) Token: 0x060077E3 RID: 30691 RVA: 0x00124347 File Offset: 0x00122547
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

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x00124350 File Offset: 0x00122550
		// (set) Token: 0x060077E5 RID: 30693 RVA: 0x00124358 File Offset: 0x00122558
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

		// Token: 0x060077E6 RID: 30694 RVA: 0x00124361 File Offset: 0x00122561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreEntityTraceRequest);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x0012436F File Offset: 0x0012256F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreEntityTraceRequest other)
		{
			return other != null && (other == this || (this.ExploratoryDegree == other.ExploratoryDegree && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x001243B0 File Offset: 0x001225B0
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

		// Token: 0x060077E9 RID: 30697 RVA: 0x00124408 File Offset: 0x00122608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00124415 File Offset: 0x00122615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00124420 File Offset: 0x00122620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AreaId);
			}
			if (this.ExploratoryDegree != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ExploratoryDegree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x0012447C File Offset: 0x0012267C
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

		// Token: 0x060077ED RID: 30701 RVA: 0x001244D4 File Offset: 0x001226D4
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

		// Token: 0x060077EE RID: 30702 RVA: 0x00124524 File Offset: 0x00122724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x00124530 File Offset: 0x00122730
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExploratoryDegree = input.ReadInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E45 RID: 15941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E46 RID: 15942
		public const int ExploratoryDegreeFieldNumber = 12;

		// Token: 0x04003E47 RID: 15943
		private int exploratoryDegree_;

		// Token: 0x04003E48 RID: 15944
		public const int AreaIdFieldNumber = 6;

		// Token: 0x04003E49 RID: 15945
		private int areaId_;
	}
}

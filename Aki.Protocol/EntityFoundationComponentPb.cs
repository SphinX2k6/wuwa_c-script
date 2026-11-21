using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000477 RID: 1143
	public sealed class EntityFoundationComponentPb : IMessage<EntityFoundationComponentPb>, IMessage, IEquatable<EntityFoundationComponentPb>, IDeepCloneable<EntityFoundationComponentPb>, IBufferMessage
	{
		// Token: 0x06006DF3 RID: 28147 RVA: 0x0010EAC5 File Offset: 0x0010CCC5
		[NullableContext(1)]
		public static EntityFoundationComponentPb Create()
		{
			return new EntityFoundationComponentPb();
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x0010EACC File Offset: 0x0010CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x0010EACF File Offset: 0x0010CCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFoundationComponentPb.Descriptor;
			}
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x0010EAD6 File Offset: 0x0010CCD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb()
		{
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x0010EADE File Offset: 0x0010CCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb(EntityFoundationComponentPb other) : this()
		{
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x0010EB13 File Offset: 0x0010CD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb Clone()
		{
			return new EntityFoundationComponentPb(this);
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x0010EB1B File Offset: 0x0010CD1B
		// (set) Token: 0x06006DFA RID: 28154 RVA: 0x0010EB23 File Offset: 0x0010CD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x0010EB2C File Offset: 0x0010CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFoundationComponentPb);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x0010EB3A File Offset: 0x0010CD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFoundationComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x0010EB70 File Offset: 0x0010CD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x0010EBAC File Offset: 0x0010CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x0010EBB9 File Offset: 0x0010CDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x0010EBC2 File Offset: 0x0010CDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x0010EBF4 File Offset: 0x0010CDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x0010EC34 File Offset: 0x0010CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFoundationComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x0010EC88 File Offset: 0x0010CE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x0010EC94 File Offset: 0x0010CE94
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x04003BE0 RID: 15328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE1 RID: 15329
		public const int FoundationCoreInfoFieldNumber = 1;

		// Token: 0x04003BE2 RID: 15330
		private FoundationCoreInfo foundationCoreInfo_;
	}
}

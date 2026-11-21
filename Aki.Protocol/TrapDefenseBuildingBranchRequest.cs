using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001480 RID: 5248
	[NetMessage(EMessageId.TrapDefenseBuildingBranchRequest)]
	public sealed class TrapDefenseBuildingBranchRequest : IMessage<TrapDefenseBuildingBranchRequest>, IMessage, IEquatable<TrapDefenseBuildingBranchRequest>, IDeepCloneable<TrapDefenseBuildingBranchRequest>, IBufferMessage
	{
		// Token: 0x0601BDDE RID: 114142 RVA: 0x0040C87D File Offset: 0x0040AA7D
		[NullableContext(1)]
		public static TrapDefenseBuildingBranchRequest Create()
		{
			return new TrapDefenseBuildingBranchRequest();
		}

		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x0601BDDF RID: 114143 RVA: 0x0040C884 File Offset: 0x0040AA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x0601BDE0 RID: 114144 RVA: 0x0040C887 File Offset: 0x0040AA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingBranchRequest.Descriptor;
			}
		}

		// Token: 0x0601BDE1 RID: 114145 RVA: 0x0040C88E File Offset: 0x0040AA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest()
		{
		}

		// Token: 0x0601BDE2 RID: 114146 RVA: 0x0040C896 File Offset: 0x0040AA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest(TrapDefenseBuildingBranchRequest other) : this()
		{
			this.id_ = other.id_;
			this.branch_ = other.branch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDE3 RID: 114147 RVA: 0x0040C8C7 File Offset: 0x0040AAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest Clone()
		{
			return new TrapDefenseBuildingBranchRequest(this);
		}

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x0601BDE4 RID: 114148 RVA: 0x0040C8CF File Offset: 0x0040AACF
		// (set) Token: 0x0601BDE5 RID: 114149 RVA: 0x0040C8D7 File Offset: 0x0040AAD7
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

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x0601BDE6 RID: 114150 RVA: 0x0040C8E0 File Offset: 0x0040AAE0
		// (set) Token: 0x0601BDE7 RID: 114151 RVA: 0x0040C8E8 File Offset: 0x0040AAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Branch
		{
			get
			{
				return this.branch_;
			}
			set
			{
				this.branch_ = value;
			}
		}

		// Token: 0x0601BDE8 RID: 114152 RVA: 0x0040C8F1 File Offset: 0x0040AAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingBranchRequest);
		}

		// Token: 0x0601BDE9 RID: 114153 RVA: 0x0040C8FF File Offset: 0x0040AAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingBranchRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Branch == other.Branch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDEA RID: 114154 RVA: 0x0040C940 File Offset: 0x0040AB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Branch != 0)
			{
				num ^= this.Branch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BDEB RID: 114155 RVA: 0x0040C998 File Offset: 0x0040AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDEC RID: 114156 RVA: 0x0040C9A5 File Offset: 0x0040ABA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDED RID: 114157 RVA: 0x0040C9B0 File Offset: 0x0040ABB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Branch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDEE RID: 114158 RVA: 0x0040CA0C File Offset: 0x0040AC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Branch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Branch);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BDEF RID: 114159 RVA: 0x0040CA64 File Offset: 0x0040AC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingBranchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Branch != 0)
			{
				this.Branch = other.Branch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BDF0 RID: 114160 RVA: 0x0040CAB4 File Offset: 0x0040ACB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDF1 RID: 114161 RVA: 0x0040CAC0 File Offset: 0x0040ACC0
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Branch = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1AB RID: 41387
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1AC RID: 41388
		public const int IdFieldNumber = 3;

		// Token: 0x0400A1AD RID: 41389
		private int id_;

		// Token: 0x0400A1AE RID: 41390
		public const int BranchFieldNumber = 6;

		// Token: 0x0400A1AF RID: 41391
		private int branch_;
	}
}

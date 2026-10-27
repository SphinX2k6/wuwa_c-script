using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140D RID: 5133
	[NetMessage(EMessageId.TrapDefenseBuildingBranchRequest)]
	public sealed class TrapDefenseBuildingBranchRequest : IMessage<TrapDefenseBuildingBranchRequest>, IMessage, IEquatable<TrapDefenseBuildingBranchRequest>, IDeepCloneable<TrapDefenseBuildingBranchRequest>, IBufferMessage
	{
		// Token: 0x0601B353 RID: 111443 RVA: 0x003F15A9 File Offset: 0x003EF7A9
		[NullableContext(1)]
		public static TrapDefenseBuildingBranchRequest Create()
		{
			return new TrapDefenseBuildingBranchRequest();
		}

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x0601B354 RID: 111444 RVA: 0x003F15B0 File Offset: 0x003EF7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x0601B355 RID: 111445 RVA: 0x003F15B3 File Offset: 0x003EF7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingBranchRequest.Descriptor;
			}
		}

		// Token: 0x0601B356 RID: 111446 RVA: 0x003F15BA File Offset: 0x003EF7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest()
		{
		}

		// Token: 0x0601B357 RID: 111447 RVA: 0x003F15C2 File Offset: 0x003EF7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest(TrapDefenseBuildingBranchRequest other) : this()
		{
			this.id_ = other.id_;
			this.branch_ = other.branch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B358 RID: 111448 RVA: 0x003F15F3 File Offset: 0x003EF7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchRequest Clone()
		{
			return new TrapDefenseBuildingBranchRequest(this);
		}

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x0601B359 RID: 111449 RVA: 0x003F15FB File Offset: 0x003EF7FB
		// (set) Token: 0x0601B35A RID: 111450 RVA: 0x003F1603 File Offset: 0x003EF803
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

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x0601B35B RID: 111451 RVA: 0x003F160C File Offset: 0x003EF80C
		// (set) Token: 0x0601B35C RID: 111452 RVA: 0x003F1614 File Offset: 0x003EF814
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

		// Token: 0x0601B35D RID: 111453 RVA: 0x003F161D File Offset: 0x003EF81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingBranchRequest);
		}

		// Token: 0x0601B35E RID: 111454 RVA: 0x003F162B File Offset: 0x003EF82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingBranchRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Branch == other.Branch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B35F RID: 111455 RVA: 0x003F166C File Offset: 0x003EF86C
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

		// Token: 0x0601B360 RID: 111456 RVA: 0x003F16C4 File Offset: 0x003EF8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B361 RID: 111457 RVA: 0x003F16D1 File Offset: 0x003EF8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B362 RID: 111458 RVA: 0x003F16DC File Offset: 0x003EF8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Branch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B363 RID: 111459 RVA: 0x003F1738 File Offset: 0x003EF938
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

		// Token: 0x0601B364 RID: 111460 RVA: 0x003F1790 File Offset: 0x003EF990
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

		// Token: 0x0601B365 RID: 111461 RVA: 0x003F17E0 File Offset: 0x003EF9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B366 RID: 111462 RVA: 0x003F17EC File Offset: 0x003EF9EC
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
				if (num != 72U)
				{
					if (num != 96U)
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

		// Token: 0x04009D64 RID: 40292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D65 RID: 40293
		public const int IdFieldNumber = 9;

		// Token: 0x04009D66 RID: 40294
		private int id_;

		// Token: 0x04009D67 RID: 40295
		public const int BranchFieldNumber = 12;

		// Token: 0x04009D68 RID: 40296
		private int branch_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001403 RID: 5123
	[NetMessage(EMessageId.TrapDefenseAuxiliaryBranchRequest)]
	public sealed class TrapDefenseAuxiliaryBranchRequest : IMessage<TrapDefenseAuxiliaryBranchRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryBranchRequest>, IDeepCloneable<TrapDefenseAuxiliaryBranchRequest>, IBufferMessage
	{
		// Token: 0x0601B295 RID: 111253 RVA: 0x003F0006 File Offset: 0x003EE206
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryBranchRequest Create()
		{
			return new TrapDefenseAuxiliaryBranchRequest();
		}

		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x0601B296 RID: 111254 RVA: 0x003F000D File Offset: 0x003EE20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x0601B297 RID: 111255 RVA: 0x003F0010 File Offset: 0x003EE210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryBranchRequest.Descriptor;
			}
		}

		// Token: 0x0601B298 RID: 111256 RVA: 0x003F0017 File Offset: 0x003EE217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest()
		{
		}

		// Token: 0x0601B299 RID: 111257 RVA: 0x003F001F File Offset: 0x003EE21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest(TrapDefenseAuxiliaryBranchRequest other) : this()
		{
			this.id_ = other.id_;
			this.branch_ = other.branch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B29A RID: 111258 RVA: 0x003F0050 File Offset: 0x003EE250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest Clone()
		{
			return new TrapDefenseAuxiliaryBranchRequest(this);
		}

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x0601B29B RID: 111259 RVA: 0x003F0058 File Offset: 0x003EE258
		// (set) Token: 0x0601B29C RID: 111260 RVA: 0x003F0060 File Offset: 0x003EE260
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

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x0601B29D RID: 111261 RVA: 0x003F0069 File Offset: 0x003EE269
		// (set) Token: 0x0601B29E RID: 111262 RVA: 0x003F0071 File Offset: 0x003EE271
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

		// Token: 0x0601B29F RID: 111263 RVA: 0x003F007A File Offset: 0x003EE27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryBranchRequest);
		}

		// Token: 0x0601B2A0 RID: 111264 RVA: 0x003F0088 File Offset: 0x003EE288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryBranchRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Branch == other.Branch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2A1 RID: 111265 RVA: 0x003F00C8 File Offset: 0x003EE2C8
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

		// Token: 0x0601B2A2 RID: 111266 RVA: 0x003F0120 File Offset: 0x003EE320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2A3 RID: 111267 RVA: 0x003F012D File Offset: 0x003EE32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2A4 RID: 111268 RVA: 0x003F0138 File Offset: 0x003EE338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Branch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2A5 RID: 111269 RVA: 0x003F0190 File Offset: 0x003EE390
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

		// Token: 0x0601B2A6 RID: 111270 RVA: 0x003F01E8 File Offset: 0x003EE3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryBranchRequest other)
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

		// Token: 0x0601B2A7 RID: 111271 RVA: 0x003F0238 File Offset: 0x003EE438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2A8 RID: 111272 RVA: 0x003F0244 File Offset: 0x003EE444
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
					if (num != 24U)
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

		// Token: 0x04009D3A RID: 40250
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D3B RID: 40251
		public const int IdFieldNumber = 1;

		// Token: 0x04009D3C RID: 40252
		private int id_;

		// Token: 0x04009D3D RID: 40253
		public const int BranchFieldNumber = 3;

		// Token: 0x04009D3E RID: 40254
		private int branch_;
	}
}

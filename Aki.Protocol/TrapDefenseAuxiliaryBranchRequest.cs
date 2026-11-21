using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001476 RID: 5238
	[NetMessage(EMessageId.TrapDefenseAuxiliaryBranchRequest)]
	public sealed class TrapDefenseAuxiliaryBranchRequest : IMessage<TrapDefenseAuxiliaryBranchRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryBranchRequest>, IDeepCloneable<TrapDefenseAuxiliaryBranchRequest>, IBufferMessage
	{
		// Token: 0x0601BD20 RID: 113952 RVA: 0x0040B2DA File Offset: 0x004094DA
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryBranchRequest Create()
		{
			return new TrapDefenseAuxiliaryBranchRequest();
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0601BD21 RID: 113953 RVA: 0x0040B2E1 File Offset: 0x004094E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E36 RID: 24118
		// (get) Token: 0x0601BD22 RID: 113954 RVA: 0x0040B2E4 File Offset: 0x004094E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryBranchRequest.Descriptor;
			}
		}

		// Token: 0x0601BD23 RID: 113955 RVA: 0x0040B2EB File Offset: 0x004094EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest()
		{
		}

		// Token: 0x0601BD24 RID: 113956 RVA: 0x0040B2F3 File Offset: 0x004094F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest(TrapDefenseAuxiliaryBranchRequest other) : this()
		{
			this.id_ = other.id_;
			this.branch_ = other.branch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD25 RID: 113957 RVA: 0x0040B324 File Offset: 0x00409524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchRequest Clone()
		{
			return new TrapDefenseAuxiliaryBranchRequest(this);
		}

		// Token: 0x17005E37 RID: 24119
		// (get) Token: 0x0601BD26 RID: 113958 RVA: 0x0040B32C File Offset: 0x0040952C
		// (set) Token: 0x0601BD27 RID: 113959 RVA: 0x0040B334 File Offset: 0x00409534
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

		// Token: 0x17005E38 RID: 24120
		// (get) Token: 0x0601BD28 RID: 113960 RVA: 0x0040B33D File Offset: 0x0040953D
		// (set) Token: 0x0601BD29 RID: 113961 RVA: 0x0040B345 File Offset: 0x00409545
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

		// Token: 0x0601BD2A RID: 113962 RVA: 0x0040B34E File Offset: 0x0040954E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryBranchRequest);
		}

		// Token: 0x0601BD2B RID: 113963 RVA: 0x0040B35C File Offset: 0x0040955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryBranchRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Branch == other.Branch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD2C RID: 113964 RVA: 0x0040B39C File Offset: 0x0040959C
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

		// Token: 0x0601BD2D RID: 113965 RVA: 0x0040B3F4 File Offset: 0x004095F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD2E RID: 113966 RVA: 0x0040B401 File Offset: 0x00409601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD2F RID: 113967 RVA: 0x0040B40C File Offset: 0x0040960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Branch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD30 RID: 113968 RVA: 0x0040B468 File Offset: 0x00409668
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

		// Token: 0x0601BD31 RID: 113969 RVA: 0x0040B4C0 File Offset: 0x004096C0
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

		// Token: 0x0601BD32 RID: 113970 RVA: 0x0040B510 File Offset: 0x00409710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD33 RID: 113971 RVA: 0x0040B51C File Offset: 0x0040971C
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
				if (num != 40U)
				{
					if (num != 112U)
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

		// Token: 0x0400A181 RID: 41345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A182 RID: 41346
		public const int IdFieldNumber = 5;

		// Token: 0x0400A183 RID: 41347
		private int id_;

		// Token: 0x0400A184 RID: 41348
		public const int BranchFieldNumber = 14;

		// Token: 0x0400A185 RID: 41349
		private int branch_;
	}
}

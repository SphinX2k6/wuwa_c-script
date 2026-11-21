using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058C RID: 1420
	public sealed class FlagStrongholdInfo : IMessage<FlagStrongholdInfo>, IMessage, IEquatable<FlagStrongholdInfo>, IDeepCloneable<FlagStrongholdInfo>, IBufferMessage
	{
		// Token: 0x060083E3 RID: 33763 RVA: 0x0013DBCD File Offset: 0x0013BDCD
		[NullableContext(1)]
		public static FlagStrongholdInfo Create()
		{
			return new FlagStrongholdInfo();
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060083E4 RID: 33764 RVA: 0x0013DBD4 File Offset: 0x0013BDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagStrongholdInfo> Parser
		{
			get
			{
				return FlagStrongholdInfo._parser;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060083E5 RID: 33765 RVA: 0x0013DBDB File Offset: 0x0013BDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060083E6 RID: 33766 RVA: 0x0013DBDE File Offset: 0x0013BDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagStrongholdInfo.Descriptor;
			}
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x0013DBE5 File Offset: 0x0013BDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo()
		{
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x0013DBED File Offset: 0x0013BDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo(FlagStrongholdInfo other) : this()
		{
			this.id_ = other.id_;
			this.isPass_ = other.isPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x0013DC1E File Offset: 0x0013BE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo Clone()
		{
			return new FlagStrongholdInfo(this);
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x0013DC26 File Offset: 0x0013BE26
		// (set) Token: 0x060083EB RID: 33771 RVA: 0x0013DC2E File Offset: 0x0013BE2E
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060083EC RID: 33772 RVA: 0x0013DC37 File Offset: 0x0013BE37
		// (set) Token: 0x060083ED RID: 33773 RVA: 0x0013DC3F File Offset: 0x0013BE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPass
		{
			get
			{
				return this.isPass_;
			}
			set
			{
				this.isPass_ = value;
			}
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x0013DC48 File Offset: 0x0013BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagStrongholdInfo);
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x0013DC56 File Offset: 0x0013BE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagStrongholdInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsPass == other.IsPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x0013DC94 File Offset: 0x0013BE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsPass)
			{
				num ^= this.IsPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083F1 RID: 33777 RVA: 0x0013DCEC File Offset: 0x0013BEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x0013DCF9 File Offset: 0x0013BEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x0013DD04 File Offset: 0x0013BF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsPass)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083F4 RID: 33780 RVA: 0x0013DD5C File Offset: 0x0013BF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083F5 RID: 33781 RVA: 0x0013DDA8 File Offset: 0x0013BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagStrongholdInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsPass)
			{
				this.IsPass = other.IsPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x0013DDF8 File Offset: 0x0013BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083F7 RID: 33783 RVA: 0x0013DE04 File Offset: 0x0013C004
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsPass = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041E8 RID: 16872
		private static readonly MessageParser<FlagStrongholdInfo> _parser = new MessageParser<FlagStrongholdInfo>(() => new FlagStrongholdInfo());

		// Token: 0x040041E9 RID: 16873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041EA RID: 16874
		public const int IdFieldNumber = 1;

		// Token: 0x040041EB RID: 16875
		private int id_;

		// Token: 0x040041EC RID: 16876
		public const int IsPassFieldNumber = 2;

		// Token: 0x040041ED RID: 16877
		private bool isPass_;
	}
}

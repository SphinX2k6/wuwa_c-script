using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A1 RID: 1441
	public sealed class FlagStrongholdInfo : IMessage<FlagStrongholdInfo>, IMessage, IEquatable<FlagStrongholdInfo>, IDeepCloneable<FlagStrongholdInfo>, IBufferMessage
	{
		// Token: 0x0600854B RID: 34123 RVA: 0x001407D4 File Offset: 0x0013E9D4
		[NullableContext(1)]
		public static FlagStrongholdInfo Create()
		{
			return new FlagStrongholdInfo();
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x0600854C RID: 34124 RVA: 0x001407DB File Offset: 0x0013E9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagStrongholdInfo> Parser
		{
			get
			{
				return FlagStrongholdInfo._parser;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x001407E2 File Offset: 0x0013E9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x0600854E RID: 34126 RVA: 0x001407E5 File Offset: 0x0013E9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagStrongholdInfo.Descriptor;
			}
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x001407EC File Offset: 0x0013E9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo()
		{
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x001407F4 File Offset: 0x0013E9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo(FlagStrongholdInfo other) : this()
		{
			this.id_ = other.id_;
			this.isPass_ = other.isPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x00140825 File Offset: 0x0013EA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfo Clone()
		{
			return new FlagStrongholdInfo(this);
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06008552 RID: 34130 RVA: 0x0014082D File Offset: 0x0013EA2D
		// (set) Token: 0x06008553 RID: 34131 RVA: 0x00140835 File Offset: 0x0013EA35
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

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06008554 RID: 34132 RVA: 0x0014083E File Offset: 0x0013EA3E
		// (set) Token: 0x06008555 RID: 34133 RVA: 0x00140846 File Offset: 0x0013EA46
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

		// Token: 0x06008556 RID: 34134 RVA: 0x0014084F File Offset: 0x0013EA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagStrongholdInfo);
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x0014085D File Offset: 0x0013EA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagStrongholdInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsPass == other.IsPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x0014089C File Offset: 0x0013EA9C
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

		// Token: 0x06008559 RID: 34137 RVA: 0x001408F4 File Offset: 0x0013EAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00140901 File Offset: 0x0013EB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x0014090C File Offset: 0x0013EB0C
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

		// Token: 0x0600855C RID: 34140 RVA: 0x00140964 File Offset: 0x0013EB64
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

		// Token: 0x0600855D RID: 34141 RVA: 0x001409B0 File Offset: 0x0013EBB0
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

		// Token: 0x0600855E RID: 34142 RVA: 0x00140A00 File Offset: 0x0013EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x00140A0C File Offset: 0x0013EC0C
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

		// Token: 0x040041F2 RID: 16882
		private static readonly MessageParser<FlagStrongholdInfo> _parser = new MessageParser<FlagStrongholdInfo>(() => new FlagStrongholdInfo());

		// Token: 0x040041F3 RID: 16883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041F4 RID: 16884
		public const int IdFieldNumber = 1;

		// Token: 0x040041F5 RID: 16885
		private int id_;

		// Token: 0x040041F6 RID: 16886
		public const int IsPassFieldNumber = 2;

		// Token: 0x040041F7 RID: 16887
		private bool isPass_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDB RID: 4059
	public sealed class RogueResFormation : IMessage<RogueResFormation>, IMessage, IEquatable<RogueResFormation>, IDeepCloneable<RogueResFormation>, IBufferMessage
	{
		// Token: 0x06015B14 RID: 88852 RVA: 0x00325E19 File Offset: 0x00324019
		[NullableContext(1)]
		public static RogueResFormation Create()
		{
			return new RogueResFormation();
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x06015B15 RID: 88853 RVA: 0x00325E20 File Offset: 0x00324020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResFormation> Parser
		{
			get
			{
				return RogueResFormation._parser;
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x06015B16 RID: 88854 RVA: 0x00325E27 File Offset: 0x00324027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x06015B17 RID: 88855 RVA: 0x00325E2A File Offset: 0x0032402A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFormation.Descriptor;
			}
		}

		// Token: 0x06015B18 RID: 88856 RVA: 0x00325E31 File Offset: 0x00324031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation()
		{
		}

		// Token: 0x06015B19 RID: 88857 RVA: 0x00325E44 File Offset: 0x00324044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation(RogueResFormation other) : this()
		{
			this.roleId_ = other.roleId_.Clone();
			this.linkId_ = other.linkId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B1A RID: 88858 RVA: 0x00325E7A File Offset: 0x0032407A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation Clone()
		{
			return new RogueResFormation(this);
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x06015B1B RID: 88859 RVA: 0x00325E82 File Offset: 0x00324082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x06015B1C RID: 88860 RVA: 0x00325E8A File Offset: 0x0032408A
		// (set) Token: 0x06015B1D RID: 88861 RVA: 0x00325E92 File Offset: 0x00324092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LinkId
		{
			get
			{
				return this.linkId_;
			}
			set
			{
				this.linkId_ = value;
			}
		}

		// Token: 0x06015B1E RID: 88862 RVA: 0x00325E9B File Offset: 0x0032409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFormation);
		}

		// Token: 0x06015B1F RID: 88863 RVA: 0x00325EAC File Offset: 0x003240AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFormation other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && this.LinkId == other.LinkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B20 RID: 88864 RVA: 0x00325EFC File Offset: 0x003240FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleId_.GetHashCode();
			if (this.LinkId != 0)
			{
				num ^= this.LinkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B21 RID: 88865 RVA: 0x00325F49 File Offset: 0x00324149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B22 RID: 88866 RVA: 0x00325F56 File Offset: 0x00324156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B23 RID: 88867 RVA: 0x00325F60 File Offset: 0x00324160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, RogueResFormation._repeated_roleId_codec);
			if (this.LinkId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LinkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B24 RID: 88868 RVA: 0x00325FB0 File Offset: 0x003241B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleId_.CalculateSize(RogueResFormation._repeated_roleId_codec);
			if (this.LinkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LinkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B25 RID: 88869 RVA: 0x00326004 File Offset: 0x00324204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResFormation other)
		{
			if (other == null)
			{
				return;
			}
			this.roleId_.Add(other.roleId_);
			if (other.LinkId != 0)
			{
				this.LinkId = other.LinkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B26 RID: 88870 RVA: 0x00326051 File Offset: 0x00324251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B27 RID: 88871 RVA: 0x0032605C File Offset: 0x0032425C
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
				if (num != 8U && num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LinkId = input.ReadInt32();
					}
				}
				else
				{
					this.roleId_.AddEntriesFrom(ref input, RogueResFormation._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x0400822F RID: 33327
		private static readonly MessageParser<RogueResFormation> _parser = new MessageParser<RogueResFormation>(() => new RogueResFormation());

		// Token: 0x04008230 RID: 33328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008231 RID: 33329
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008232 RID: 33330
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008233 RID: 33331
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();

		// Token: 0x04008234 RID: 33332
		public const int LinkIdFieldNumber = 2;

		// Token: 0x04008235 RID: 33333
		private int linkId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCB RID: 4043
	public sealed class RogueResFormation : IMessage<RogueResFormation>, IMessage, IEquatable<RogueResFormation>, IDeepCloneable<RogueResFormation>, IBufferMessage
	{
		// Token: 0x06015A2F RID: 88623 RVA: 0x00324765 File Offset: 0x00322965
		[NullableContext(1)]
		public static RogueResFormation Create()
		{
			return new RogueResFormation();
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x06015A30 RID: 88624 RVA: 0x0032476C File Offset: 0x0032296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResFormation> Parser
		{
			get
			{
				return RogueResFormation._parser;
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x06015A31 RID: 88625 RVA: 0x00324773 File Offset: 0x00322973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x06015A32 RID: 88626 RVA: 0x00324776 File Offset: 0x00322976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFormation.Descriptor;
			}
		}

		// Token: 0x06015A33 RID: 88627 RVA: 0x0032477D File Offset: 0x0032297D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation()
		{
		}

		// Token: 0x06015A34 RID: 88628 RVA: 0x00324790 File Offset: 0x00322990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation(RogueResFormation other) : this()
		{
			this.roleId_ = other.roleId_.Clone();
			this.linkId_ = other.linkId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A35 RID: 88629 RVA: 0x003247C6 File Offset: 0x003229C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation Clone()
		{
			return new RogueResFormation(this);
		}

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x06015A36 RID: 88630 RVA: 0x003247CE File Offset: 0x003229CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x06015A37 RID: 88631 RVA: 0x003247D6 File Offset: 0x003229D6
		// (set) Token: 0x06015A38 RID: 88632 RVA: 0x003247DE File Offset: 0x003229DE
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

		// Token: 0x06015A39 RID: 88633 RVA: 0x003247E7 File Offset: 0x003229E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFormation);
		}

		// Token: 0x06015A3A RID: 88634 RVA: 0x003247F8 File Offset: 0x003229F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFormation other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && this.LinkId == other.LinkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A3B RID: 88635 RVA: 0x00324848 File Offset: 0x00322A48
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

		// Token: 0x06015A3C RID: 88636 RVA: 0x00324895 File Offset: 0x00322A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A3D RID: 88637 RVA: 0x003248A2 File Offset: 0x00322AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A3E RID: 88638 RVA: 0x003248AC File Offset: 0x00322AAC
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

		// Token: 0x06015A3F RID: 88639 RVA: 0x003248FC File Offset: 0x00322AFC
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

		// Token: 0x06015A40 RID: 88640 RVA: 0x00324950 File Offset: 0x00322B50
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

		// Token: 0x06015A41 RID: 88641 RVA: 0x0032499D File Offset: 0x00322B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A42 RID: 88642 RVA: 0x003249A8 File Offset: 0x00322BA8
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

		// Token: 0x04008259 RID: 33369
		private static readonly MessageParser<RogueResFormation> _parser = new MessageParser<RogueResFormation>(() => new RogueResFormation());

		// Token: 0x0400825A RID: 33370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400825B RID: 33371
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400825C RID: 33372
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400825D RID: 33373
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();

		// Token: 0x0400825E RID: 33374
		public const int LinkIdFieldNumber = 2;

		// Token: 0x0400825F RID: 33375
		private int linkId_;
	}
}

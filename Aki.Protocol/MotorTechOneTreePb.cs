using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAD RID: 2733
	public sealed class MotorTechOneTreePb : IMessage<MotorTechOneTreePb>, IMessage, IEquatable<MotorTechOneTreePb>, IDeepCloneable<MotorTechOneTreePb>, IBufferMessage
	{
		// Token: 0x0600EDDE RID: 60894 RVA: 0x0022B7DF File Offset: 0x002299DF
		[NullableContext(1)]
		public static MotorTechOneTreePb Create()
		{
			return new MotorTechOneTreePb();
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600EDDF RID: 60895 RVA: 0x0022B7E6 File Offset: 0x002299E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTechOneTreePb> Parser
		{
			get
			{
				return MotorTechOneTreePb._parser;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0022B7ED File Offset: 0x002299ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600EDE1 RID: 60897 RVA: 0x0022B7F0 File Offset: 0x002299F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechOneTreePb.Descriptor;
			}
		}

		// Token: 0x0600EDE2 RID: 60898 RVA: 0x0022B7F7 File Offset: 0x002299F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb()
		{
		}

		// Token: 0x0600EDE3 RID: 60899 RVA: 0x0022B80A File Offset: 0x00229A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb(MotorTechOneTreePb other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tech_ = other.tech_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDE4 RID: 60900 RVA: 0x0022B840 File Offset: 0x00229A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb Clone()
		{
			return new MotorTechOneTreePb(this);
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x0022B848 File Offset: 0x00229A48
		// (set) Token: 0x0600EDE6 RID: 60902 RVA: 0x0022B850 File Offset: 0x00229A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600EDE7 RID: 60903 RVA: 0x0022B859 File Offset: 0x00229A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechPb> Tech
		{
			get
			{
				return this.tech_;
			}
		}

		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0022B861 File Offset: 0x00229A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechOneTreePb);
		}

		// Token: 0x0600EDE9 RID: 60905 RVA: 0x0022B870 File Offset: 0x00229A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechOneTreePb other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tech_.Equals(other.tech_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDEA RID: 60906 RVA: 0x0022B8C0 File Offset: 0x00229AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			num ^= this.tech_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EDEB RID: 60907 RVA: 0x0022B90D File Offset: 0x00229B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDEC RID: 60908 RVA: 0x0022B91A File Offset: 0x00229B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDED RID: 60909 RVA: 0x0022B924 File Offset: 0x00229B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeId);
			}
			this.tech_.WriteTo(ref output, MotorTechOneTreePb._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDEE RID: 60910 RVA: 0x0022B974 File Offset: 0x00229B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			num += this.tech_.CalculateSize(MotorTechOneTreePb._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x0022B9C8 File Offset: 0x00229BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechOneTreePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this.tech_.Add(other.tech_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x0022BA15 File Offset: 0x00229C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDF1 RID: 60913 RVA: 0x0022BA20 File Offset: 0x00229C20
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tech_.AddEntriesFrom(ref input, MotorTechOneTreePb._repeated_tech_codec);
					}
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006049 RID: 24649
		private static readonly MessageParser<MotorTechOneTreePb> _parser = new MessageParser<MotorTechOneTreePb>(() => new MotorTechOneTreePb());

		// Token: 0x0400604A RID: 24650
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400604B RID: 24651
		public const int TreeIdFieldNumber = 1;

		// Token: 0x0400604C RID: 24652
		private int treeId_;

		// Token: 0x0400604D RID: 24653
		public const int TechFieldNumber = 2;

		// Token: 0x0400604E RID: 24654
		private static readonly FieldCodec<MotorTechPb> _repeated_tech_codec = FieldCodec.ForMessage<MotorTechPb>(18U, MotorTechPb.Parser);

		// Token: 0x0400604F RID: 24655
		private readonly RepeatedField<MotorTechPb> tech_ = new RepeatedField<MotorTechPb>();
	}
}

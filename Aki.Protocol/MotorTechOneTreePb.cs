using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9C RID: 2716
	public sealed class MotorTechOneTreePb : IMessage<MotorTechOneTreePb>, IMessage, IEquatable<MotorTechOneTreePb>, IDeepCloneable<MotorTechOneTreePb>, IBufferMessage
	{
		// Token: 0x0600ECC4 RID: 60612 RVA: 0x002295E3 File Offset: 0x002277E3
		[NullableContext(1)]
		public static MotorTechOneTreePb Create()
		{
			return new MotorTechOneTreePb();
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600ECC5 RID: 60613 RVA: 0x002295EA File Offset: 0x002277EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTechOneTreePb> Parser
		{
			get
			{
				return MotorTechOneTreePb._parser;
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600ECC6 RID: 60614 RVA: 0x002295F1 File Offset: 0x002277F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600ECC7 RID: 60615 RVA: 0x002295F4 File Offset: 0x002277F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechOneTreePb.Descriptor;
			}
		}

		// Token: 0x0600ECC8 RID: 60616 RVA: 0x002295FB File Offset: 0x002277FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb()
		{
		}

		// Token: 0x0600ECC9 RID: 60617 RVA: 0x0022960E File Offset: 0x0022780E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb(MotorTechOneTreePb other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tech_ = other.tech_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECCA RID: 60618 RVA: 0x00229644 File Offset: 0x00227844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb Clone()
		{
			return new MotorTechOneTreePb(this);
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600ECCB RID: 60619 RVA: 0x0022964C File Offset: 0x0022784C
		// (set) Token: 0x0600ECCC RID: 60620 RVA: 0x00229654 File Offset: 0x00227854
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

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600ECCD RID: 60621 RVA: 0x0022965D File Offset: 0x0022785D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechPb> Tech
		{
			get
			{
				return this.tech_;
			}
		}

		// Token: 0x0600ECCE RID: 60622 RVA: 0x00229665 File Offset: 0x00227865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechOneTreePb);
		}

		// Token: 0x0600ECCF RID: 60623 RVA: 0x00229674 File Offset: 0x00227874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechOneTreePb other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tech_.Equals(other.tech_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECD0 RID: 60624 RVA: 0x002296C4 File Offset: 0x002278C4
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

		// Token: 0x0600ECD1 RID: 60625 RVA: 0x00229711 File Offset: 0x00227911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECD2 RID: 60626 RVA: 0x0022971E File Offset: 0x0022791E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECD3 RID: 60627 RVA: 0x00229728 File Offset: 0x00227928
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

		// Token: 0x0600ECD4 RID: 60628 RVA: 0x00229778 File Offset: 0x00227978
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

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x002297CC File Offset: 0x002279CC
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

		// Token: 0x0600ECD6 RID: 60630 RVA: 0x00229819 File Offset: 0x00227A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECD7 RID: 60631 RVA: 0x00229824 File Offset: 0x00227A24
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

		// Token: 0x04006052 RID: 24658
		private static readonly MessageParser<MotorTechOneTreePb> _parser = new MessageParser<MotorTechOneTreePb>(() => new MotorTechOneTreePb());

		// Token: 0x04006053 RID: 24659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006054 RID: 24660
		public const int TreeIdFieldNumber = 1;

		// Token: 0x04006055 RID: 24661
		private int treeId_;

		// Token: 0x04006056 RID: 24662
		public const int TechFieldNumber = 2;

		// Token: 0x04006057 RID: 24663
		private static readonly FieldCodec<MotorTechPb> _repeated_tech_codec = FieldCodec.ForMessage<MotorTechPb>(18U, MotorTechPb.Parser);

		// Token: 0x04006058 RID: 24664
		private readonly RepeatedField<MotorTechPb> tech_ = new RepeatedField<MotorTechPb>();
	}
}
